using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;
using System.Configuration;             
namespace FatiIkhlassYoun.membreFolder
{
    public partial class FormMbrExporter : Form
    {
        private int memberId;

        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementSystem"].ConnectionString;

        public FormMbrExporter(int userId)
        {
            InitializeComponent();
            this.memberId = userId;
            LoadTeamsAndTasks();
            LoadStatuses();
            ConfigureDateTimePickers();
        }

        private void LoadTeamsAndTasks()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Charger les équipes du membre
                    string teamsQuery = @"
                    SELECT DISTINCT t.TeamID, t.Name 
                    FROM Teams t
                    JOIN TeamMembers tm ON t.TeamID = tm.TeamID
                    WHERE tm.UserID = @MemberID";

                    SqlCommand teamsCmd = new SqlCommand(teamsQuery, conn);
                    teamsCmd.Parameters.AddWithValue("@MemberID", memberId);

                    DataTable teamsTable = new DataTable();
                    teamsTable.Load(teamsCmd.ExecuteReader());

                    checkedListBoxEquipes.Items.Clear();
                    foreach (DataRow row in teamsTable.Rows)
                    {
                        checkedListBoxEquipes.Items.Add(
                            new TeamItem(
                                Convert.ToInt32(row["TeamID"]),
                                row["Name"].ToString()
                            ), false);
                    }

                    // Charger toutes les tâches  du membre
                    string tasksQuery = @"
                    SELECT t.TaskID, t.Title, t.TeamLeadID, t.Status, t.DueDate, tm.TeamID
                    FROM Tasks t
                    JOIN Task_Assignments ta ON t.TaskID = ta.TaskID
                    LEFT JOIN Teams tm ON t.TeamLeadID = tm.LeaderID
                    WHERE ta.UserID = @MemberID";

                    SqlCommand tasksCmd = new SqlCommand(tasksQuery, conn);
                    tasksCmd.Parameters.AddWithValue("@MemberID", memberId);

                    DataTable tasksTable = new DataTable();
                    tasksTable.Load(tasksCmd.ExecuteReader());

                    this.tasksData = tasksTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données: {ex.Message}", "Erreur",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable tasksData;

        private void LoadStatuses()
        {
            checkedListBoxStatuts.Items.Clear();
            checkedListBoxStatuts.Items.Add("En attente", true);
            checkedListBoxStatuts.Items.Add("En cours", true);
            checkedListBoxStatuts.Items.Add("Terminée", true);
        }

        private void ConfigureDateTimePickers()
        {
            dateTimePickerDebut.Value = DateTime.Now.AddMonths(-1);
            dateTimePickerFin.Value = DateTime.Now;
        }

        private void checkedListBoxEquipes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke(new Action(UpdateTasksList));
        }

        private void UpdateTasksList()
        {
            checkedListBoxTaches.Items.Clear();

            if (checkedListBoxEquipes.CheckedItems.Count == 0)
                return;

            var selectedTeamIds = checkedListBoxEquipes.CheckedItems
                .Cast<TeamItem>()
                .Select(t => t.Id)
                .ToList();

            var filteredTasks = tasksData.AsEnumerable()
                .Where(row =>
                {
                    int? teamId = row.Field<int?>("TeamID");
                    return teamId.HasValue && selectedTeamIds.Contains(teamId.Value);
                })
                .ToList();

            foreach (var task in filteredTasks)
            {
                checkedListBoxTaches.Items.Add(
                    new TaskItem(
                        task.Field<int>("TaskID"),
                        task.Field<string>("Title"),
                        task.Field<string>("Status"),
                        task.Field<DateTime>("DueDate")
                    ), true);
            }
        }

        private void btnSelectAllTeams_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxEquipes.Items.Count; i++)
            {
                checkedListBoxEquipes.SetItemChecked(i, true);
            }
        }

        private void btnSelectAllTasks_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxTaches.Items.Count; i++)
            {
                checkedListBoxTaches.SetItemChecked(i, true);
            }
        }

        private void btnExporter_Click(object sender, EventArgs e)
        {
            if (radioButtonCSV.Checked)
            {
                ExportToCSV();
            }
            else
            {
                ExportToPDF();
            }
        }

        private void ExportToCSV()
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Fichiers CSV (*.csv)|*.csv";
                saveFileDialog.Title = "Exporter vers Excel";
                saveFileDialog.FileName = $"RapportTaches_{DateTime.Now:yyyyMMdd}.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, System.Text.Encoding.UTF8))
                    {
                        // En-têtes avec séparateur clair
                        writer.WriteLine("Équipe;Tâche;Statut;Date d'échéance;Date de début;Date de fin;Jours restants");

                        // Données organisées
                        foreach (TeamItem team in checkedListBoxEquipes.CheckedItems)
                        {
                            var teamTasks = checkedListBoxTaches.CheckedItems
                                .Cast<TaskItem>()
                                .Where(t => tasksData.AsEnumerable()
                                    .Any(row => row.Field<int>("TaskID") == t.Id &&
                                           (row.Field<int?>("TeamID") ?? -1) == team.Id))
                                .Where(t => checkedListBoxStatuts.CheckedItems.Contains(t.Status))
                                .OrderBy(t => t.DueDate);

                            foreach (var task in teamTasks)
                            {
                                int daysLeft = (task.DueDate - DateTime.Now).Days;
                                string daysText = daysLeft < 0 ? "En retard" : daysLeft.ToString();

                                writer.WriteLine(
                                    $"{EscapeCsv(team.Name)};" +
                                    $"{EscapeCsv(task.Title)};" +
                                    $"{EscapeCsv(task.Status)};" +
                                    $"{task.DueDate:dd/MM/yyyy};" +
                                    $"{dateTimePickerDebut.Value:dd/MM/yyyy};" +
                                    $"{dateTimePickerFin.Value:dd/MM/yyyy};" +
                                    $"{daysText}");
                            }
                        }
                    }

                    // Optionnel: Ouvrir Excel directement
                    try
                    {
                        System.Diagnostics.Process.Start(saveFileDialog.FileName);
                    }
                    catch { }

                    MessageBox.Show("Export Excel terminé avec succès!", "Succès",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'export Excel: {ex.Message}", "Erreur",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string EscapeCsv(string value)
        {
            if (string.IsNullOrEmpty(value)) return "";

            // Remplacer les sauts de ligne et guillemets
            value = value.Replace("\"", "\"\"")
                         .Replace("\r", " ")
                         .Replace("\n", " ");

            // Encadrer avec guillemets si contient un point-virgule
            if (value.Contains(";") || value.Contains("\""))
            {
                return $"\"{value}\"";
            }
            return value;
        }

        private void ExportToPDF()
{
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Fichiers PDF (*.pdf)|*.pdf";
                saveFileDialog.Title = "Exporter vers PDF";
                saveFileDialog.FileName = $"RapportTaches_{DateTime.Now:yyyyMMdd}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Document document = new Document(PageSize.A4.Rotate(), 20, 20, 30, 30);
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));

                    document.Open();

                    // Styles
                    Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, BaseColor.DARK_GRAY);
                    Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.WHITE);
                    Font normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);
                    Font highlightFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, BaseColor.RED);

                    // Titre
                    Paragraph title = new Paragraph("RAPPORT D'ACTIVITÉS - MEMBRE", titleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    title.SpacingAfter = 20;
                    document.Add(title);

                    // Informations
                    PdfPTable infoTable = new PdfPTable(2);
                    infoTable.WidthPercentage = 100;
                    infoTable.SetWidths(new float[] { 1, 3 });

                    AddInfoCell(infoTable, "Période du rapport:", headerFont, BaseColor.GRAY);
                    AddInfoCell(infoTable, $"{dateTimePickerDebut.Value:dd/MM/yyyy} au {dateTimePickerFin.Value:dd/MM/yyyy}", normalFont);

                    AddInfoCell(infoTable, "Statuts inclus:", headerFont, BaseColor.GRAY);
                    AddInfoCell(infoTable, string.Join(", ", checkedListBoxStatuts.CheckedItems.Cast<string>()), normalFont);

                    if (!string.IsNullOrWhiteSpace(textBoxCommentaire.Text))
                    {
                        AddInfoCell(infoTable, "Commentaires:", headerFont, BaseColor.GRAY);
                        AddInfoCell(infoTable, textBoxCommentaire.Text, normalFont);
                    }

                    document.Add(infoTable);
                    document.Add(new Paragraph(" "));

                    // Données par équipe
                    foreach (TeamItem team in checkedListBoxEquipes.CheckedItems)
                    {
                        // Titre équipe - Version corrigée avec fond coloré
                        Paragraph teamHeaderText = new Paragraph($"ÉQUIPE: {team.Name.ToUpper()}",
                            FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, BaseColor.WHITE));

                        PdfPCell headerCell = new PdfPCell(teamHeaderText);
                        headerCell.BackgroundColor = new BaseColor(51, 51, 76);
                        headerCell.Border = iTextSharp.text.Rectangle.NO_BORDER; // Solution avec namespace complet
                        headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        headerCell.PaddingTop = 10;
                        headerCell.PaddingBottom = 10;

                        PdfPTable headerTable = new PdfPTable(1);
                        headerTable.WidthPercentage = 100;
                        headerTable.SpacingBefore = 25;
                        headerTable.SpacingAfter = 10;
                        headerTable.AddCell(headerCell);

                        document.Add(headerTable);

                        // Tableau des tâches
                        PdfPTable taskTable = new PdfPTable(5);
                taskTable.WidthPercentage = 100;
                taskTable.SetWidths(new float[] { 4, 2, 2, 2, 2 });

                // En-têtes
                AddHeaderCell(taskTable, "TÂCHE", headerFont);
                AddHeaderCell(taskTable, "STATUT", headerFont);
                AddHeaderCell(taskTable, "DÉBUT", headerFont);
                AddHeaderCell(taskTable, "ÉCHÉANCE", headerFont);
                AddHeaderCell(taskTable, "JOURS RESTANTS", headerFont);

                var teamTasks = checkedListBoxTaches.CheckedItems
                    .Cast<TaskItem>()
                    .Where(t => tasksData.AsEnumerable()
                        .Any(row => row.Field<int>("TaskID") == t.Id &&
                               (row.Field<int?>("TeamID") ?? -1) == team.Id))
                    .Where(t => checkedListBoxStatuts.CheckedItems.Contains(t.Status))
                    .OrderBy(t => t.DueDate);

                foreach (var task in teamTasks)
                {
                    AddTaskCell(taskTable, task.Title, normalFont);
                    AddTaskCell(taskTable, task.Status, normalFont);
                    AddTaskCell(taskTable, dateTimePickerDebut.Value.ToString("dd/MM/yyyy"), normalFont);
                    AddTaskCell(taskTable, task.DueDate.ToString("dd/MM/yyyy"), normalFont);

                    int daysLeft = (task.DueDate - DateTime.Now).Days;
                    if (daysLeft < 0)
                    {
                        AddTaskCell(taskTable, "EN RETARD", highlightFont);
                    }
                    else
                    {
                        AddTaskCell(taskTable, $"{daysLeft} jours", normalFont);
                    }
                }

                document.Add(taskTable);
            }

            // Pied de page
            Paragraph footer = new Paragraph($"Généré le {DateTime.Now:dd/MM/yyyy à HH:mm}",
                FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 8));
            footer.SpacingBefore = 20;
            footer.Alignment = Element.ALIGN_RIGHT;
            document.Add(footer);

            document.Close();

            MessageBox.Show("Export PDF terminé avec succès!", "Succès",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Erreur lors de l'export PDF: {ex.Message}", "Erreur",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

        private void AddInfoCell(PdfPTable table, string text, Font font, BaseColor bgColor = null)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text, font));
            cell.BackgroundColor = bgColor ?? BaseColor.WHITE;
            cell.BorderWidth = 0.5f;
            cell.Padding = 5;
            table.AddCell(cell);
        }

        private void AddHeaderCell(PdfPTable table, string text, Font font)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text, font));
            cell.BackgroundColor = new BaseColor(51, 51, 76);
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.Padding = 5;
            table.AddCell(cell);
        }

        private void AddTaskCell(PdfPTable table, string text, Font font)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text, font));
            cell.Padding = 5;
            table.AddCell(cell);
        }

        private void radioButtonFormat_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCommentaire.Visible = radioButtonPDF.Checked;
            labelCommentaire.Visible = radioButtonPDF.Checked;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private class TeamItem
        {
            public int Id { get; }
            public string Name { get; }

            public TeamItem(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public override string ToString() => Name;
        }

        private class TaskItem
        {
            public int Id { get; }
            public string Title { get; }
            public string Status { get; }
            public DateTime DueDate { get; }

            public TaskItem(int id, string title, string status, DateTime dueDate)
            {
                Id = id;
                Title = title;
                Status = status;
                DueDate = dueDate;
            }

            public override string ToString() => $"{Title} ({Status}, {DueDate:dd/MM/yyyy})";
        }
    }
}
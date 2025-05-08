using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Globalization;
using System.Text;
using System.Configuration;
namespace FatiIkhlassYoun
{
    public partial class ReportGeneratorForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementSystem"].ConnectionString;

        public ReportGeneratorForm()
        {
            InitializeComponent();
            dtpStartDate.Value = DateTime.Now.AddMonths(-1);
            dtpEndDate.Value = DateTime.Now;
        }

        private void ReportGeneratorForm_Load(object sender, EventArgs e)
        {
            LoadProjects();
        }

        private void LoadProjects()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ProjectID, Title FROM Projects ORDER BY Title";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    clbProjects.Items.Clear();
                    while (reader.Read())
                    {
                        clbProjects.Items.Add(new KeyValuePair<int, string>(
                            reader.GetInt32(0),
                            reader.GetString(1)), false);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des projets: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTeamsForSelectedProjects()
        {
            List<int> selectedProjectIds = new List<int>();
            foreach (KeyValuePair<int, string> item in clbProjects.CheckedItems)
            {
                selectedProjectIds.Add(item.Key);
            }

            if (selectedProjectIds.Count == 0)
            {
                clbTeams.Items.Clear();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT TeamID, Name FROM Teams WHERE ProjectID IN (" +
                        string.Join(",", selectedProjectIds) + ") ORDER BY Name";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    clbTeams.Items.Clear();
                    while (reader.Read())
                    {
                        clbTeams.Items.Add(new KeyValuePair<int, string>(
                            reader.GetInt32(0),
                            reader.GetString(1)), false);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des équipes: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clbProjects_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)(() => LoadTeamsForSelectedProjects()));
        }

        private void chkSelectAllProjects_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < clbProjects.Items.Count; i++)
            {
                clbProjects.SetItemChecked(i, chkSelectAllProjects.Checked);
            }
        }

        private void chkSelectAllTeams_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < clbTeams.Items.Count; i++)
            {
                clbTeams.SetItemChecked(i, chkSelectAllTeams.Checked);
            }
        }

        private void chkSelectAllStatus_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < clbStatus.Items.Count; i++)
            {
                clbStatus.SetItemChecked(i, chkSelectAllStatus.Checked);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                GenerateReport();
            }
        }

        private bool ValidateInputs()
        {
            if (clbProjects.CheckedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner au moins un projet.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpStartDate.Value > dtpEndDate.Value)
            {
                MessageBox.Show("La date de début doit être antérieure à la date de fin.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private List<int> GetCheckedProjectIds()
        {
            List<int> ids = new List<int>();
            foreach (KeyValuePair<int, string> item in clbProjects.CheckedItems)
            {
                ids.Add(item.Key);
            }
            return ids;
        }

        private List<int> GetCheckedTeamIds()
        {
            List<int> ids = new List<int>();
            foreach (KeyValuePair<int, string> item in clbTeams.CheckedItems)
            {
                ids.Add(item.Key);
            }
            return ids;
        }

        private List<string> GetCheckedStatuses()
        {
            List<string> statuses = new List<string>();
            foreach (var item in clbStatus.CheckedItems)
            {
                statuses.Add(item.ToString());
            }
            return statuses;
        }

        private DataTable GetTasksData(List<int> projectIds, List<int> teamIds, List<string> statuses,
            DateTime startDate, DateTime endDate)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                    SELECT 
                        t.Title,
                        t.StartDate,
                        t.DueDate,
                        t.Status,
                        p.Title AS ProjectName
                    FROM Tasks t
                    JOIN Projects p ON t.ProjectID = p.ProjectID
                    WHERE 
                        t.ProjectID IN (" + string.Join(",", projectIds) + @")
                        AND t.Status IN ('" + string.Join("','", statuses) + @"')
                        AND t.StartDate BETWEEN @StartDate AND @EndDate
                    ORDER BY t.StartDate";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des tâches: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        private string GetSelectedProjectNames(List<int> projectIds)
        {
            if (projectIds.Count == 0) return string.Empty;

            List<string> names = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Title FROM Projects WHERE ProjectID IN (" + string.Join(",", projectIds) + ")";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    names.Add(reader.GetString(0));
                }
            }
            return string.Join(", ", names);
        }

        private void GenerateReport()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                List<int> projectIds = GetCheckedProjectIds();
                List<int> teamIds = GetCheckedTeamIds();
                List<string> statuses = GetCheckedStatuses();
                DateTime startDate = dtpStartDate.Value;
                DateTime endDate = dtpEndDate.Value;

                // Demander où sauvegarder les fichiers
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "Fichiers PDF (*.pdf)|*.pdf";
                    saveDialog.FileName = $"RapportTaches_{DateTime.Now:yyyyMMdd_HHmmss}";
                    saveDialog.DefaultExt = "pdf";
                    saveDialog.AddExtension = true;
                    saveDialog.Title = "Enregistrer le rapport PDF";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        string basePath = Path.Combine(Path.GetDirectoryName(saveDialog.FileName),
                                                    Path.GetFileNameWithoutExtension(saveDialog.FileName));

                        // Générer les deux formats
                        GeneratePdfReport($"{basePath}.pdf", projectIds, teamIds, statuses, startDate, endDate);
                        GenerateCsvReport($"{basePath}.csv", projectIds, teamIds, statuses, startDate, endDate);

                        MessageBox.Show($"Rapports générés avec succès:\n{basePath}.pdf\n{basePath}.csv",
                            "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la génération des rapports: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void GeneratePdfReport(string filePath, List<int> projectIds, List<int> teamIds,
                             List<string> statuses, DateTime startDate, DateTime endDate)
        {
            try
            {
                Document document = new Document(PageSize.A4, 50, 50, 50, 50);
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                // Utiliser une police qui supporte les caractères français
                string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

                iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bf, 18, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font headerFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font normalFont = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

                // Titre avec accents corrects
                Paragraph title = new Paragraph("RAPPORT DÉTAILLÉ DES TÂCHES", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 20;
                document.Add(title);

                // Informations
                PdfPTable infoTable = new PdfPTable(2);
                infoTable.WidthPercentage = 100;
                infoTable.SetWidths(new float[] { 30, 70 });

                AddInfoCell(infoTable, "Date de génération:", DateTime.Now.ToString("dd/MM/yyyy HH:mm"), headerFont, normalFont);
                AddInfoCell(infoTable, "Chef d'équipe:", "chef.equipe1", headerFont, normalFont);
                AddInfoCell(infoTable, "Période couverte:", $"{startDate:dd/MM/yyyy} au {endDate:dd/MM/yyyy}", headerFont, normalFont);

                string projectNames = GetSelectedProjectNames(projectIds);
                AddInfoCell(infoTable, "Projets sélectionnés:", projectNames, headerFont, normalFont);

                string statusList = string.Join(", ", statuses);
                AddInfoCell(infoTable, "Statuts sélectionnés:", statusList, headerFont, normalFont);

                document.Add(infoTable);
                document.Add(new Paragraph(" "));

                // Données
                DataTable tasksData = GetTasksData(projectIds, teamIds, statuses, startDate, endDate);
                if (tasksData.Rows.Count > 0)
                {
                    PdfPTable taskTable = new PdfPTable(5);
                    taskTable.WidthPercentage = 100;
                    taskTable.SetWidths(new float[] { 40, 15, 15, 15, 15 });

                    AddHeaderCell(taskTable, "TÂCHE", headerFont);
                    AddHeaderCell(taskTable, "DATE DÉBUT", headerFont);
                    AddHeaderCell(taskTable, "DATE FIN", headerFont);
                    AddHeaderCell(taskTable, "STATUT", headerFont);
                    AddHeaderCell(taskTable, "PROJET", headerFont);

                    foreach (DataRow row in tasksData.Rows)
                    {
                        AddDataCell(taskTable, row["Title"].ToString(), normalFont);
                        AddDataCell(taskTable, Convert.ToDateTime(row["StartDate"]).ToString("dd/MM/yyyy"), normalFont);
                        AddDataCell(taskTable, Convert.ToDateTime(row["DueDate"]).ToString("dd/MM/yyyy"), normalFont);
                        AddDataCell(taskTable, row["Status"].ToString(), normalFont);
                        AddDataCell(taskTable, row["ProjectName"].ToString(), normalFont);
                    }

                    document.Add(taskTable);
                    document.Add(new Paragraph($"TOTAL DES TÂCHES: {tasksData.Rows.Count}", headerFont));
                    document.Add(new Paragraph(" "));



                }
                else
                {
                    document.Add(new Paragraph("Aucune tâche trouvée pour les critères sélectionnés.", normalFont));
                }

                document.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur lors de la génération du PDF: " + ex.Message);
            }
        }

        private void GenerateCsvReport(string filePath, List<int> projectIds, List<int> teamIds,
                              List<string> statuses, DateTime startDate, DateTime endDate)
        {
            try
            {
                DataTable tasksData = GetTasksData(projectIds, teamIds, statuses, startDate, endDate);

                using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    // En-tête avec encodage UTF-8
                    writer.WriteLine("RAPPORT DÉTAILLÉ DES TÂCHES");
                    writer.WriteLine($"Date de génération;{DateTime.Now:dd/MM/yyyy HH:mm}");
                    writer.WriteLine($"Chef d'équipe;chef.equipe1");
                    writer.WriteLine($"Période couverte;{startDate:dd/MM/yyyy} au {endDate:dd/MM/yyyy}");
                    writer.WriteLine($"Projets sélectionnés;{GetSelectedProjectNames(projectIds)}");
                    writer.WriteLine($"Statuts sélectionnés;{string.Join(", ", statuses)}");
                    writer.WriteLine();

                    // Colonnes
                    writer.WriteLine("TÂCHE;DATE DÉBUT;DATE FIN;STATUT;PROJET");

                    // Données
                    foreach (DataRow row in tasksData.Rows)
                    {
                        writer.WriteLine(
                            $"\"{EscapeCsvValue(row["Title"].ToString())}\";" +
                            $"{Convert.ToDateTime(row["StartDate"]):dd/MM/yyyy};" +
                            $"{Convert.ToDateTime(row["DueDate"]):dd/MM/yyyy};" +
                            $"{EscapeCsvValue(row["Status"].ToString())};" +
                            $"{EscapeCsvValue(row["ProjectName"].ToString())}"
                        );
                    }

                    writer.WriteLine();
                    writer.WriteLine($"TOTAL DES TÂCHES;{tasksData.Rows.Count}");
                    writer.WriteLine();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur lors de la génération du CSV: " + ex.Message);
            }
        }

        private string EscapeCsvValue(string value)
        {
            if (value.Contains(";") || value.Contains("\"") || value.Contains("\n"))
            {
                return "\"" + value.Replace("\"", "\"\"") + "\"";
            }
            return value;
        }

        private void AddInfoCell(PdfPTable table, string label, string value, iTextSharp.text.Font labelFont, iTextSharp.text.Font valueFont)
        {
            PdfPCell labelCell = new PdfPCell(new Phrase(label, labelFont));
            labelCell.Border = PdfPCell.NO_BORDER;
            table.AddCell(labelCell);

            PdfPCell valueCell = new PdfPCell(new Phrase(value, valueFont));
            valueCell.Border = PdfPCell.NO_BORDER;
            table.AddCell(valueCell);
        }

        private void AddHeaderCell(PdfPTable table, string text, iTextSharp.text.Font font)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text, font));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.BackgroundColor = new BaseColor(200, 200, 200);
            table.AddCell(cell);
        }

        private void AddDataCell(PdfPTable table, string text, iTextSharp.text.Font font)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text, font));
            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            table.AddCell(cell);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void gbReportType_Enter(object sender, EventArgs e)
        {

        }
    }
}
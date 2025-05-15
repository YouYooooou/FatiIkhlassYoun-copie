using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Diagnostics;

// Alias pour iTextSharp
using iText = iTextSharp.text;
using iTextPdf = iTextSharp.text.pdf;
using System.Configuration;

namespace ProjectManagementSystem.ChefProjetFolder.Reports
{
    public partial class ExportProjetReportForm : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementSystem"].ConnectionString;
        private bool _exportInProgress = false;

        public ExportProjetReportForm()
        {
            InitializeComponent();
            this.Load += ExportProjetReportForm_Load;
            btnExporter.Click += btnExporter_Click;
        }

        private void ExportProjetReportForm_Load(object sender, EventArgs e)
        {
            ChargerProjets();
            ChargerStatuts();
            dateDebutPicker.Value = DateTime.Now.AddDays(-30); // Par défaut sur 1 mois
            dateFinPicker.Value = DateTime.Now;
        }

        private void ChargerProjets()
        {
            checkedListBoxProjets.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT p.ProjectID, p.Title 
                               FROM Projects p
                               WHERE p.ManagerID = @ManagerID
                               ORDER BY p.Title";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ManagerID", SessionUtilisateur.UserID);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        checkedListBoxProjets.Items.Add(new ProjetItem
                        {
                            Text = reader["Title"].ToString(),
                            Value = reader["ProjectID"].ToString()
                        }, true); // Tous les projets cochés par défaut
                    }
                }
            }
        }

        private void ChargerStatuts()
        {
            checkedListBoxStatuts.Items.Clear();
            checkedListBoxStatuts.Items.Add("En attente", true);
            checkedListBoxStatuts.Items.Add("En cours", true);
            checkedListBoxStatuts.Items.Add("Terminée", true);
            checkedListBoxStatuts.Items.Add("Bloquée", true);
        }

        private class ProjetItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private string CleanCsvField(string field)
        {
            if (string.IsNullOrEmpty(field))
                return string.Empty;
            return field.Replace(",", ";")
                      .Replace("\n", " ")
                      .Replace("\r", " ")
                      .Trim();
        }

        private string FormatDateForCsv(object dateValue)
        {
            if (dateValue == DBNull.Value || dateValue == null)
                return string.Empty;
            if (DateTime.TryParse(dateValue.ToString(), out DateTime date))
                return date.ToString("dd/MM/yyyy");
            return string.Empty;
        }

        private void btnExporter_Click(object sender, EventArgs e)
        {
            if (_exportInProgress) return;

            _exportInProgress = true;
            btnExporter.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                List<string> projetsSelectionnes = checkedListBoxProjets.CheckedItems
                    .Cast<ProjetItem>()
                    .Select(item => item.Value)
                    .Distinct()
                    .ToList();

                List<string> statutsSelectionnes = checkedListBoxStatuts.CheckedItems
                    .Cast<string>()
                    .Distinct()
                    .ToList();

                if (!projetsSelectionnes.Any() || !statutsSelectionnes.Any())
                {
                    MessageBox.Show("Veuillez sélectionner au moins un projet et un statut.",
                                 "Sélection requise",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                    return;
                }

                if (dateDebutPicker.Value > dateFinPicker.Value)
                {
                    MessageBox.Show("La date de début doit être antérieure à la date de fin.",
                                 "Erreur de dates",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                    return;
                }

                DataTable data = GetProjectData(projetsSelectionnes, statutsSelectionnes);

                if (data.Rows.Count == 0)
                {
                    MessageBox.Show("Aucune donnée trouvée avec les critères sélectionnés.",
                                 "Information",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                    return;
                }

                if (radioCSV.Checked)
                {
                    SaveToCsvFile(data);
                }
                else
                {
                    SaveToPdfFile(data);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'export : {ex.Message}\nStack Trace: {ex.StackTrace}",
                              "Erreur",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
            finally
            {
                _exportInProgress = false;
                btnExporter.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
        }

        private void SaveToPdfFile(DataTable data)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Fichiers PDF (.pdf)|.pdf";
                saveDialog.FileName = $"RapportProjets_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                saveDialog.OverwritePrompt = true;
                saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string fullPath = saveDialog.FileName;
                        Debug.WriteLine($"Chemin d'export PDF: {fullPath}");

                        string directory = Path.GetDirectoryName(fullPath);
                        if (!Directory.Exists(directory))
                        {
                            Directory.CreateDirectory(directory);
                        }

                        GeneratePdfReport(data, fullPath);

                        MessageBox.Show($"Export PDF réussi!\nFichier enregistré sous :\n{fullPath}",
                                      "Succès",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Échec de l'export PDF :\n{ex.Message}\nStack Trace: {ex.StackTrace}",
                                      "Erreur",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void GeneratePdfReport(DataTable data, string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("Le chemin du fichier ne peut pas être vide");

            filePath = Path.GetFullPath(filePath);

            iText.Document document = new iText.Document(iText.PageSize.A4.Rotate()); // Format paysage pour plus d'espace
            FileStream fs = null;

            try
            {
                fs = new FileStream(filePath, FileMode.Create);
                iTextPdf.PdfWriter writer = iTextPdf.PdfWriter.GetInstance(document, fs);

                document.AddTitle("Rapport Global des Projets");
                document.AddAuthor(SessionUtilisateur.UserID.ToString());
                document.AddCreator("Project Management System");

                document.Open();

                // Titre avec style
                iText.Font titleFont = iText.FontFactory.GetFont(iText.FontFactory.HELVETICA_BOLD, 18, iText.BaseColor.DARK_GRAY);
                iText.Paragraph title = new iText.Paragraph("RAPPORT GLOBAL DES PROJETS", titleFont);
                title.Alignment = iText.Element.ALIGN_CENTER;
                title.SpacingAfter = 20f;
                document.Add(title);

                // Bloc d'informations
                iTextPdf.PdfPTable infoTable = new iTextPdf.PdfPTable(2);
                infoTable.WidthPercentage = 95;
                infoTable.SetWidths(new float[] { 1, 3 });

                string chefProjetNom = SessionUtilisateur.FullName;
                AddInfoCell(infoTable, "Date de génération:", DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                AddInfoCell(infoTable, "Chef de projet:", chefProjetNom);
                AddInfoCell(infoTable, "Période couverte:", $"{dateDebutPicker.Value:dd/MM/yyyy} au {dateFinPicker.Value:dd/MM/yyyy}");
                AddInfoCell(infoTable, "Projets sélectionnés:", string.Join(", ", checkedListBoxProjets.CheckedItems.Cast<ProjetItem>().Select(p => p.Text)));
                AddInfoCell(infoTable, "Statuts sélectionnés:", string.Join(", ", checkedListBoxStatuts.CheckedItems.Cast<string>()));

                document.Add(infoTable);
                document.Add(iText.Chunk.NEWLINE);

                // Tableau des données
                iTextPdf.PdfPTable table = new iTextPdf.PdfPTable(8);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 2.5f, 1.5f, 1.5f, 1.5f, 2f, 2f, 2f, 3f });

                string[] headers = { "TÂCHE", "DATE DÉBUT", "DATE FIN", "STATUT", "PROJET", "CHEF D'ÉQUIPE", "ÉQUIPE", "MEMBRES AFFECTÉS" };
                iText.Font headerFont = iText.FontFactory.GetFont(iText.FontFactory.HELVETICA_BOLD, 9, iText.BaseColor.BLACK);

                foreach (string header in headers)
                {
                    iTextPdf.PdfPCell cell = new iTextPdf.PdfPCell(new iText.Phrase(header, headerFont));
                    cell.BackgroundColor = new iText.BaseColor(79, 129, 189);
                    cell.HorizontalAlignment = iText.Element.ALIGN_CENTER;
                    cell.Padding = 5;
                    table.AddCell(cell);
                }

                iText.Font contentFont = iText.FontFactory.GetFont(iText.FontFactory.HELVETICA, 8, iText.BaseColor.BLACK);
                bool alternate = false;

                foreach (DataRow row in data.Rows)
                {
                    iText.BaseColor bgColor = alternate ? new iText.BaseColor(221, 235, 247) : iText.BaseColor.WHITE;

                    AddTableRow(table, row["Title"]?.ToString() ?? "", contentFont, bgColor);
                    AddTableRow(table, FormatDateForCsv(row["StartDate"]), contentFont, bgColor);
                    AddTableRow(table, FormatDateForCsv(row["DueDate"]), contentFont, bgColor);

                    string status = row["Status"]?.ToString() ?? "";
                    iText.BaseColor statusColor = GetStatusColor(status);
                    AddTableRow(table, status, contentFont, bgColor, statusColor);

                    AddTableRow(table, row["NomProjet"]?.ToString() ?? "", contentFont, bgColor);
                    AddTableRow(table, row["ChefEquipeNom"]?.ToString() ?? "", contentFont, bgColor);
                    AddTableRow(table, row["NomEquipe"]?.ToString() ?? "Aucune", contentFont, bgColor);
                    AddTableRow(table, row["MembresAffectes"]?.ToString() ?? "Aucun", contentFont, bgColor);

                    alternate = !alternate;
                }
                document.Add(table);
                document.Add(iText.Chunk.NEWLINE);

                // Statistiques
                iText.Font statsFont = iText.FontFactory.GetFont(iText.FontFactory.HELVETICA_BOLD, 11);
                document.Add(new iText.Paragraph($"TOTAL DES TÂCHES: {data.Rows.Count}", statsFont));

                // Ajout des statistiques par projet
                var statsParProjet = data.AsEnumerable()
                    .GroupBy(r => r["NomProjet"].ToString())
                    .Select(g => new {
                        Projet = g.Key,
                        Total = g.Count(),
                        Terminees = g.Count(r => r["Status"].ToString().Equals("Terminée", StringComparison.OrdinalIgnoreCase)),
                        EnCours = g.Count(r => r["Status"].ToString().Equals("En cours", StringComparison.OrdinalIgnoreCase)),
                        EnAttente = g.Count(r => r["Status"].ToString().Equals("En attente", StringComparison.OrdinalIgnoreCase))
                    });

                iTextPdf.PdfPTable statsTable = new iTextPdf.PdfPTable(5);
                statsTable.WidthPercentage = 95;
                statsTable.SetWidths(new float[] { 3, 1, 1, 1, 1 });

                // En-tête des statistiques
                string[] statsHeaders = { "PROJET", "TOTAL", "TERMINÉES", "EN COURS", "EN ATTENTE" };
                foreach (string header in statsHeaders)
                {
                    iTextPdf.PdfPCell cell = new iTextPdf.PdfPCell(new iText.Phrase(header, headerFont));
                    cell.BackgroundColor = new iText.BaseColor(79, 129, 189);
                    cell.HorizontalAlignment = iText.Element.ALIGN_CENTER;
                    cell.Padding = 5;
                    statsTable.AddCell(cell);
                }

                foreach (var stat in statsParProjet)
                {
                    AddTableRow(statsTable, stat.Projet, contentFont, iText.BaseColor.WHITE);
                    AddTableRow(statsTable, stat.Total.ToString(), contentFont, iText.BaseColor.WHITE);
                    AddTableRow(statsTable, stat.Terminees.ToString(), contentFont, iText.BaseColor.WHITE);
                    AddTableRow(statsTable, stat.EnCours.ToString(), contentFont, iText.BaseColor.WHITE);
                    AddTableRow(statsTable, stat.EnAttente.ToString(), contentFont, iText.BaseColor.WHITE);
                }

                document.Add(statsTable);
                document.Add(iText.Chunk.NEWLINE);

                if (!string.IsNullOrWhiteSpace(txtCommentaire.Text))
                {
                    document.Add(new iText.Paragraph("COMMENTAIRE:", statsFont));
                    iText.Font commentFont = iText.FontFactory.GetFont(iText.FontFactory.HELVETICA_OBLIQUE, 10);
                    iText.Paragraph comment = new iText.Paragraph(txtCommentaire.Text, commentFont);
                    comment.IndentationLeft = 20;
                    document.Add(comment);
                }

                document.Close();
            }
            catch (Exception ex)
            {
                try
                {
                    fs?.Close();
                    if (File.Exists(filePath))
                        File.Delete(filePath);
                }
                catch { }

                throw new Exception($"Échec de la génération du PDF : {ex.Message}", ex);
            }
            finally
            {
                document.Close();
                fs?.Dispose();
            }
        }
        public static class SessionUtilisateur
        {
            public static int UserID { get; set; }
            public static string Username { get; set; }
            public static string FullName { get; set; }
            public static int RoleID { get; set; }

            public static void Clear()
            {
                UserID = 0;
                Username = string.Empty;
                FullName = string.Empty;
                RoleID = 0;
            }
        }
        private void CheckAllStatus_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = checkAllStatus.Checked;
            for (int i = 0; i < checkedListBoxStatuts.Items.Count; i++)
            {
                checkedListBoxStatuts.SetItemChecked(i, isChecked);
            }
        }

        private void CheckAllProjects_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = checkAllProjects.Checked;
            for (int i = 0; i < checkedListBoxProjets.Items.Count; i++)
            {
                checkedListBoxProjets.SetItemChecked(i, isChecked);
            }
        }

        private DataTable GetProjectData(List<string> projetsSelectionnes, List<string> statutsSelectionnes)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT 
                    t.Title,
                    t.StartDate,
                    t.DueDate,
                    t.Status,
                    p.Title AS NomProjet,
                    u.Username AS ChefEquipeNom,
                    te.Name AS NomEquipe,
                    STRING_AGG(u2.Username, ', ') AS MembresAffectes
                FROM Tasks t
                INNER JOIN Projects p ON t.ProjectID = p.ProjectID
                INNER JOIN Users u ON t.TeamLeadID = u.UserID
                LEFT JOIN Teams te ON t.TeamID = te.TeamID
                LEFT JOIN Task_Assignments ta ON ta.TaskID = t.TaskID
                LEFT JOIN Users u2 ON ta.UserID = u2.UserID
                WHERE 
                    p.ProjectManagerID = @ProjectManagerID
                    AND t.ProjectID IN (" + string.Join(",", projetsSelectionnes.Select((s, i) => "@proj" + i)) + @")
                    AND t.Status IN (" + string.Join(",", statutsSelectionnes.Select((s, i) => "@stat" + i)) + @")
                    AND t.StartDate >= @DateDebut AND t.DueDate <= @DateFin
                GROUP BY 
                    t.Title, t.StartDate, t.DueDate, t.Status, p.Title, u.Username, te.Name
                ORDER BY p.Title, t.StartDate";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProjectManagerID", SessionUtilisateur.UserID);
                cmd.Parameters.AddWithValue("@DateDebut", dateDebutPicker.Value.Date);
                cmd.Parameters.AddWithValue("@DateFin", dateFinPicker.Value.Date);

                for (int i = 0; i < projetsSelectionnes.Count; i++)
                    cmd.Parameters.AddWithValue("@proj" + i, projetsSelectionnes[i]);

                for (int i = 0; i < statutsSelectionnes.Count; i++)
                    cmd.Parameters.AddWithValue("@stat" + i, statutsSelectionnes[i]);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        private void SaveToCsvFile(DataTable data)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Fichiers CSV (.csv)|.csv";
                saveDialog.FileName = $"RapportProjets_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
                saveDialog.OverwritePrompt = true;
                saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string fullPath = saveDialog.FileName;
                        Debug.WriteLine($"Chemin d'export CSV: {fullPath}");

                        string directory = Path.GetDirectoryName(fullPath);
                        if (!Directory.Exists(directory))
                        {
                            Directory.CreateDirectory(directory);
                        }

                        File.WriteAllText(fullPath, GenerateCsvContent(data), new UTF8Encoding(true));

                        MessageBox.Show($"Export CSV réussi!\nFichier enregistré sous :\n{fullPath}",
                                      "Succès",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur lors de l'export CSV :\n{ex.Message}\nStack Trace: {ex.StackTrace}",
                                      "Erreur",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                    }
                }
            }
        }

        private string GenerateCsvContent(DataTable data)
        {
            StringBuilder sb = new StringBuilder();
            string chefProjetNom = SessionUtilisateur.FullName;

            // En-tête du rapport
            sb.AppendLine("Rapport Global des Projets");
            sb.AppendLine($"Généré le : {DateTime.Now:dd/MM/yyyy HH:mm}");
            sb.AppendLine($"Chef de projet : {chefProjetNom}");
            sb.AppendLine($"Période : {dateDebutPicker.Value:dd/MM/yyyy} au {dateFinPicker.Value:dd/MM/yyyy}");
            sb.AppendLine($"Projets inclus : {string.Join(", ", checkedListBoxProjets.CheckedItems.Cast<ProjetItem>().Select(p => p.Text))}");
            sb.AppendLine($"Statuts inclus : {string.Join(", ", checkedListBoxStatuts.CheckedItems.Cast<string>())}");
            sb.AppendLine();

            // En-tête des colonnes
            sb.AppendLine("Titre;Date Début;Date Fin;Statut;Projet;Chef d'équipe;Équipe;Membres affectés");

            // Données
            foreach (DataRow row in data.Rows)
            {
                sb.AppendLine(string.Join(";",
                    CleanCsvField(row["Title"]?.ToString()),
                    FormatDateForCsv(row["StartDate"]),
                    FormatDateForCsv(row["DueDate"]),
                    CleanCsvField(row["Status"]?.ToString()),
                    CleanCsvField(row["NomProjet"]?.ToString()),
                    CleanCsvField(row["ChefEquipeNom"]?.ToString()),
                    CleanCsvField(row["NomEquipe"]?.ToString() ?? "Aucune"),
                    CleanCsvField(row["MembresAffectes"]?.ToString() ?? "Aucun")
                ));
            }

            // Statistiques
            sb.AppendLine();
            sb.AppendLine("STATISTIQUES PAR PROJET");
            sb.AppendLine("Projet;Total;Terminées;En cours;En attente");

            var statsParProjet = data.AsEnumerable()
                .GroupBy(r => r["NomProjet"].ToString())
                .Select(g => new {
                    Projet = g.Key,
                    Total = g.Count(),
                    Terminees = g.Count(r => r["Status"].ToString().Equals("Terminée", StringComparison.OrdinalIgnoreCase)),
                    EnCours = g.Count(r => r["Status"].ToString().Equals("En cours", StringComparison.OrdinalIgnoreCase)),
                    EnAttente = g.Count(r => r["Status"].ToString().Equals("En attente", StringComparison.OrdinalIgnoreCase))
                });

            foreach (var stat in statsParProjet)
            {
                sb.AppendLine(string.Join(";",
                    CleanCsvField(stat.Projet),
                    stat.Total,
                    stat.Terminees,
                    stat.EnCours,
                    stat.EnAttente
                ));
            }

            // Commentaire
            if (!string.IsNullOrWhiteSpace(txtCommentaire.Text))
            {
                sb.AppendLine();
                sb.AppendLine("COMMENTAIRE");
                sb.AppendLine(CleanCsvField(txtCommentaire.Text));
            }

            return sb.ToString();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Méthodes utilitaires pour le PDF
        private void AddInfoCell(iTextPdf.PdfPTable table, string label, string value)
        {
            iText.Font labelFont = iText.FontFactory.GetFont(iText.FontFactory.HELVETICA_BOLD, 10);
            iText.Font valueFont = iText.FontFactory.GetFont(iText.FontFactory.HELVETICA, 10);

            table.AddCell(new iText.Phrase(label, labelFont));
            table.AddCell(new iText.Phrase(value, valueFont));
        }

        private void AddTableRow(iTextPdf.PdfPTable table, string text, iText.Font font, iText.BaseColor bgColor, iText.BaseColor textColor = null)
        {
            iTextPdf.PdfPCell cell = new iTextPdf.PdfPCell(new iText.Phrase(text, font));
            cell.BackgroundColor = bgColor;
            cell.Padding = 5;

            if (textColor != null)
                cell.Phrase.Font.Color = textColor;

            table.AddCell(cell);
        }

        private iText.BaseColor GetStatusColor(string status)
        {
            switch (status.ToUpper())
            {
                case "EN ATTENTE": return new iText.BaseColor(255, 192, 0); // Orange
                case "EN COURS": return new iText.BaseColor(0, 176, 80); // Vert
                case "TERMINÉE": return new iText.BaseColor(0, 112, 192); // Bleu
                case "BLOQUÉE": return new iText.BaseColor(255, 0, 0); // Rouge
                default: return iText.BaseColor.BLACK;
            }
        }
    }
}
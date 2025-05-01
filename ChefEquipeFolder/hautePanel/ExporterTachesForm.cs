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

namespace FatiIkhlassYoun.ChefEquipeFolder.hautePanel
{
    public partial class ExporterTachesForm : Form
    {
        private string connectionString = "Data Source=YOUNES\\SQLEXPRESS;Initial Catalog=ProjectManagementSystem;Integrated Security=True";
        private bool _exportInProgress = false;

        public ExporterTachesForm()
        {
            InitializeComponent();
            this.Load += ExporterTachesForm_Load;
            btnExporter.Click += btnExporter_Click;
        }

        private void ExporterTachesForm_Load(object sender, EventArgs e)
        {
            ChargerProjets();
            ChargerStatuts();
            dateDebutPicker.Value = DateTime.Now.AddDays(-7);
            dateFinPicker.Value = DateTime.Now;
        }

        private void ChargerProjets()
        {
            checkedListBoxProjets.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT DISTINCT p.ProjectID, p.Title 
                               FROM Projects p
                               JOIN Tasks t ON t.ProjectID = p.ProjectID
                               WHERE t.TeamLeadID = @TeamLeadID
                               ORDER BY p.Title";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TeamLeadID", SessionUtilisateur.UserID);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        checkedListBoxProjets.Items.Add(new ProjetItem
                        {
                            Text = reader["Title"].ToString(),
                            Value = reader["ProjectID"].ToString()
                        }, false);
                    }
                }
            }
        }

        private void ChargerStatuts()
        {
            checkedListBoxStatuts.Items.Clear();
            checkedListBoxStatuts.Items.Add("En attente");
            checkedListBoxStatuts.Items.Add("En cours");
            checkedListBoxStatuts.Items.Add("Terminée");
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

                DataTable data = GetTasksData(projetsSelectionnes, statutsSelectionnes);

                if (data.Rows.Count == 0)
                {
                    MessageBox.Show("Aucune tâche trouvée avec les critères sélectionnés.",
                                 "Information",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                    return;
                }

                SaveToCsvFile(data);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'export : {ex.Message}",
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

        private DataTable GetTasksData(List<string> projetsIds, List<string> statuts)
        {
            string query = $@"
                SELECT DISTINCT t.Title, t.StartDate, t.DueDate, t.Status, p.Title AS NomProjet
                FROM Tasks t
                JOIN Projects p ON t.ProjectID = p.ProjectID
                WHERE t.TeamLeadID = @TeamLeadID
                AND t.ProjectID IN ({string.Join(",", projetsIds.Select((_, i) => $"@proj{i}"))})
                AND t.Status IN ({string.Join(",", statuts.Select((_, i) => $"@stat{i}"))})
                AND t.StartDate >= @DateDebut 
                AND t.DueDate <= @DateFin";

            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TeamLeadID", SessionUtilisateur.UserID);
                cmd.Parameters.AddWithValue("@DateDebut", dateDebutPicker.Value.Date);
                cmd.Parameters.AddWithValue("@DateFin", dateFinPicker.Value.Date);

                for (int i = 0; i < projetsIds.Count; i++)
                    cmd.Parameters.AddWithValue($"@proj{i}", projetsIds[i]);

                for (int i = 0; i < statuts.Count; i++)
                    cmd.Parameters.AddWithValue($"@stat{i}", statuts[i]);

                conn.Open();
                new SqlDataAdapter(cmd).Fill(dt);
            }

            return dt;
        }

        private void SaveToCsvFile(DataTable data)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Fichiers CSV (*.csv)|*.csv";
                saveDialog.FileName = $"ExportTaches_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
                saveDialog.OverwritePrompt = true;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveDialog.FileName, GenerateCsvContent(data), Encoding.UTF8);
                    MessageBox.Show($"Export terminé avec succès!\nFichier : {saveDialog.FileName}",
                                  "Export réussi",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                }
            }
        }

        private string GenerateCsvContent(DataTable data)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Rapport des Tâches");
            sb.AppendLine($"Généré le : {DateTime.Now:dd/MM/yyyy HH:mm}");
            sb.AppendLine($"Chef d'équipe : {SessionUtilisateur.UserID}");
            sb.AppendLine();
            sb.AppendLine("Titre;Date Début;Date Fin;Statut;Projet");

            foreach (DataRow row in data.Rows)
            {
                sb.AppendLine(string.Join(";",
                    CleanCsvField(row["Title"]?.ToString()),
                    FormatDateForCsv(row["StartDate"]),
                    FormatDateForCsv(row["DueDate"]),
                    CleanCsvField(row["Status"]?.ToString()),
                    CleanCsvField(row["NomProjet"]?.ToString())));
            }

            return sb.ToString();
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
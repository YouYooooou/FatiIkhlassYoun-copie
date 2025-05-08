using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace FatiIkhlassYoun
{
    public partial class FormTaskStatistics : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementSystem"].ConnectionString;

        public FormTaskStatistics()
        {
            InitializeComponent();
            this.Text = "Statistiques des Tâches";

            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Initialisation des contrôles si nécessaire
        }

        private void FormTaskStatistics_Load(object sender, EventArgs e)
        {
            LoadTeams();
            LoadProjects();
            dtpStart.Value = DateTime.Now.AddMonths(-1);
            dtpEnd.Value = DateTime.Now;
        }

        private void LoadTeams()
        {
            cmbTeams.Items.Clear();
            cmbTeams.Items.Add(new ComboboxItem { Text = "-- Toutes les équipes --", Value = 0 });

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TeamID, Name FROM Teams";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbTeams.Items.Add(new ComboboxItem
                            {
                                Text = reader["Name"].ToString(),
                                Value = reader["TeamID"]
                            });
                        }
                    }
                }
            }
            cmbTeams.SelectedIndex = 0;
        }

        private void LoadProjects()
        {
            cmbProjects.Items.Clear();
            cmbProjects.Items.Add(new ComboboxItem { Text = "-- Tous les projets --", Value = 0 });

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ProjectID, Title FROM Projects";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbProjects.Items.Add(new ComboboxItem
                            {
                                Text = reader["Title"].ToString(),
                                Value = reader["ProjectID"]
                            });
                        }
                    }
                }
            }
            cmbProjects.SelectedIndex = 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                int teamId = (cmbTeams.SelectedItem is ComboboxItem teamItem) ? Convert.ToInt32(teamItem.Value) : 0;
                int projectId = (cmbProjects.SelectedItem is ComboboxItem projectItem) ? Convert.ToInt32(projectItem.Value) : 0;

                if (teamId == 0 && projectId == 0)
                {
                    MessageBox.Show("Veuillez sélectionner au moins un critère de filtrage (équipe ou projet).",
                                  "Sélection requise",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }

                LoadStatistics(teamId, projectId, dtpStart.Value, dtpEnd.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du rafraîchissement: {ex.Message}",
                              "Erreur",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void LoadStatistics(int teamId, int projectId, DateTime startDate, DateTime endDate)
        {
            DataTable stats = new DataTable();

            string query = @"
                SELECT 
                    t.Status,
                    COUNT(*) as Count
                FROM Tasks t
                LEFT JOIN Task_Assignments ta ON t.TaskID = ta.TaskID
                LEFT JOIN TeamMembers tm ON ta.UserID = tm.UserID
                WHERE 
                    (@TeamID = 0 OR tm.TeamID = @TeamID) AND
                    (@ProjectID = 0 OR t.ProjectID = @ProjectID) AND
                    t.StartDate >= @StartDate AND
                    t.DueDate <= @EndDate
                GROUP BY t.Status";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TeamID", teamId);
                cmd.Parameters.AddWithValue("@ProjectID", projectId);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);

                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(stats);
                }
            }

            DisplayChart(stats);
        }

        private void DisplayChart(DataTable stats)
        {
            try
            {
                // Préparer les données pour le graphique
                Dictionary<string, int> chartData = new Dictionary<string, int>();
                foreach (DataRow row in stats.Rows)
                {
                    string status = row["Status"].ToString();
                    int count = Convert.ToInt32(row["Count"]);

                    // Traduction des statuts pour une meilleure lisibilité
                    string displayStatus = status switch
                    {
                        "En attente" => "🕒 En attente",
                        "En cours" => "🔧 En cours",
                        "Terminée" => "✅ Terminée",
                        _ => status
                    };

                    chartData.Add(displayStatus, count);
                }

                // Mettre à jour le graphique
                if (cuiChartPieStatuts != null)
                {
                    // Si votre contrôle CUIChartPie a une méthode SetData
                }
                else
                {
                    // Solution alternative si le contrôle n'est pas disponible
                    DataGridView dgv = new DataGridView
                    {
                        Dock = DockStyle.Fill,
                        DataSource = stats
                    };
                    this.Controls.Add(dgv);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'affichage du graphique: {ex.Message}",
                              "Erreur",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString() => Text;
        }
        private void cmbProjects_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbTeams_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dtpStart_ValueChanged(object sender, EventArgs e) { }
        private void dtpEnd_ValueChanged(object sender, EventArgs e) { }
        private void cuiLabel1_Load_1(object sender, EventArgs e) { }

    
        private void cuiButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cuiChartPieStatuts_Load(object sender, EventArgs e)
        {

        }
    }
}
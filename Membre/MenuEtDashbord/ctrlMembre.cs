using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using FatiIkhlassYoun.ChefEquipeFolder.hautePanel;
namespace FatiIkhlassYoun.membreFolder
{
    public partial class ctrlMembre : UserControl
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementSystem"].ConnectionString;

        public ctrlMembre()
        {
            InitializeComponent();
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            int userId = SessionUtilisateur.UserID;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // 1. Charger les statistiques globales
                    LoadGlobalStats(conn, userId);

                    // 2. Charger les tâches dans le DataGridView
                    LoadTasksData(conn, userId);

                    // 3. Charger les progressions par équipe
                    LoadTeamProgressBars(conn, userId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de chargement: {ex.Message}", "Erreur",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadGlobalStats(SqlConnection conn, int userId)
        {
            string query = @"
            SELECT 
                SUM(CASE WHEN Status = 'Terminée' THEN 1 ELSE 0 END) AS Terminees,
                SUM(CASE WHEN Status = 'En cours' THEN 1 ELSE 0 END) AS EnCours,
                SUM(CASE WHEN Status = 'En attente' THEN 1 ELSE 0 END) AS EnAttente,
                (SELECT COUNT(DISTINCT TeamID) FROM TeamMembers WHERE UserID = @UserID) AS Equipes
            FROM Tasks t
            INNER JOIN Task_Assignments ta ON t.TaskID = ta.TaskID
            WHERE ta.UserID = @UserID";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        labelTachesTerminees.Text = $"Tâches terminées : {reader["Terminees"]}";
                        labelTachesEnCours.Text = $"Tâches en cours : {reader["EnCours"]}";
                        labelTacheEnAttende.Text = $"Tâches en attente : {reader["EnAttente"]}";
                        labelEquipes.Text = $"Équipes : {reader["Equipes"]}";
                    }
                }
            }
        }
        private void LoadTasksData(SqlConnection conn, int userId)
        {
            string query = @"
            SELECT 
                p.Title AS Projet,
                t.Title AS Tâche,
                t.Description AS Description,
                t.Status AS Statut,
                FORMAT(t.DueDate, 'dd/MM/yyyy') AS [Date échéance],
                FORMAT(t.StartDate, 'dd/MM/yyyy') AS [Date début],
                tm.Name AS Équipe
            FROM Tasks t
            INNER JOIN Task_Assignments ta ON t.TaskID = ta.TaskID
            INNER JOIN Projects p ON t.ProjectID = p.ProjectID
            LEFT JOIN Teams tm ON t.TeamLeadID = tm.LeaderID
            WHERE ta.UserID = @UserID
            ORDER BY t.DueDate";

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@UserID", userId);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewTaches.DataSource = dt;

                // Formatage conditionnel
                foreach (DataGridViewRow row in dataGridViewTaches.Rows)
                {
                    if (row.Cells["Statut"].Value?.ToString() == "En attente")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightYellow;
                    }
                    else if (row.Cells["Statut"].Value?.ToString() == "Terminée")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
            }
        }
        private void LoadTeamProgressBars(SqlConnection conn, int userId)
        {
            panelTeamProgress.Controls.Clear();

            string query = @"
            SELECT 
                t.TeamID,
                t.Name AS TeamName,
                COUNT(CASE WHEN ts.Status = 'Terminée' THEN 1 END) AS Completed,
                COUNT(CASE WHEN ts.Status = 'En cours' THEN 1 END) AS InProgress,
                COUNT(CASE WHEN ts.Status = 'En attente' THEN 1 END) AS Pending,
                COUNT(*) AS TotalTasks
            FROM TeamMembers tm
            JOIN Teams t ON tm.TeamID = t.TeamID
            LEFT JOIN Tasks ts ON ts.TeamLeadID = t.LeaderID
            WHERE tm.UserID = @UserID
            GROUP BY t.TeamID, t.Name";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int teamId = reader.GetInt32(0);
                        string teamName = reader.GetString(1);
                        int completed = reader.GetInt32(2);
                        int inProgress = reader.GetInt32(3);
                        int pending = reader.GetInt32(4);
                        int total = reader.GetInt32(5);

                        AddTeamProgressCard(teamName, completed, inProgress, pending, total);
                    }
                }
            }
        }
        private void AddTeamProgressCard(string teamName, int completed, int inProgress, int pending, int total)
        {
            Panel card = new Panel
            {
                Width = 350,
                Height = 100,
                Margin = new Padding(10),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Nom de l'équipe
            Label lblTeam = new Label
            {
                Text = teamName,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            // ProgressBar
            ProgressBar progressBar = new ProgressBar
            {
                Maximum = 100,
                Value = total > 0 ? (completed * 100) / total : 0,
                Style = ProgressBarStyle.Continuous,
                ForeColor = GetProgressColor((completed * 100) / total),
                Location = new Point(10, 40),
                Width = 320,
                Height = 20
            };

            // Détails
            Label lblDetails = new Label
            {
                Text = $"{completed} terminées • {inProgress} en cours • {pending} en attente",
                Location = new Point(10, 70),
                AutoSize = true,
                Font = new Font("Segoe UI", 8)
            };

            // Pourcentage
            Label lblPercent = new Label
            {
                Text = $"{progressBar.Value}%",
                Location = new Point(280, 40),
                AutoSize = true,
                Font = new Font("Segoe UI", 8, FontStyle.Bold)
            };

            card.Controls.Add(lblTeam);
            card.Controls.Add(progressBar);
            card.Controls.Add(lblDetails);
            card.Controls.Add(lblPercent);

            panelTeamProgress.Controls.Add(card);
        }

        private Color GetProgressColor(int percent)
        {
            if (percent < 30) return Color.Red;
            if (percent < 70) return Color.Orange;
            return Color.Green;
        }

        private void LoadStatistics(SqlConnection conn, int userId)
        {
            string query = @"
            SELECT 
                SUM(CASE WHEN Status = 'Terminée' THEN 1 ELSE 0 END) AS Terminees,
                SUM(CASE WHEN Status = 'En cours' THEN 1 ELSE 0 END) AS EnCours,
                SUM(CASE WHEN Status = 'En attente' THEN 1 ELSE 0 END) AS EnAttente,
                (SELECT COUNT(DISTINCT TeamID) FROM TeamMembers WHERE UserID = @UserID) AS Equipes
            FROM Tasks t
            INNER JOIN Task_Assignments ta ON t.TaskID = ta.TaskID
            WHERE ta.UserID = @UserID";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        labelTachesTerminees.Text = $"Tâches terminées: {reader["Terminees"]}";
                        labelTachesEnCours.Text = $"Tâches en cours: {reader["EnCours"]}";
                        labelTacheEnAttende.Text = $"Tâches en attente: {reader["EnAttente"]}";
                        labelEquipes.Text = $"Équipes: {reader["Equipes"]}";
                    }
                }
            }
        }

        private void LoadTasks(SqlConnection conn, int userId)
        {
            string query = @"
            SELECT 
                p.Title AS Projet,
                t.Title AS Tâche,
                t.Description,
                t.Status AS Statut,
                FORMAT(t.DueDate, 'dd/MM/yyyy') AS [Date échéance],
                FORMAT(t.StartDate, 'dd/MM/yyyy') AS [Date début],
                tm.Name AS Équipe
            FROM Tasks t
            INNER JOIN Task_Assignments ta ON t.TaskID = ta.TaskID
            INNER JOIN Projects p ON t.ProjectID = p.ProjectID
            LEFT JOIN Teams tm ON t.TeamLeadID = tm.LeaderID
            WHERE ta.UserID = @UserID
            ORDER BY t.DueDate";

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@UserID", userId);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewTaches.DataSource = dt;

                // Formatage conditionnel
                foreach (DataGridViewRow row in dataGridViewTaches.Rows)
                {
                    if (row.Cells["Statut"].Value?.ToString() == "En attente")
                        row.DefaultCellStyle.BackColor = Color.LightYellow;
                    else if (row.Cells["Statut"].Value?.ToString() == "Terminée")
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        public void RefreshData()
        {
            LoadDashboardData();
        }
    }
}
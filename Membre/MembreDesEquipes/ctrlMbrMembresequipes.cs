using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;     
namespace FatiIkhlassYoun.membreFolder
{
    public partial class ctrlMbrMembresequipes : UserControl
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementSystem"].ConnectionString;

        public ctrlMbrMembresequipes()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadTeamsData(); // Charger les données dès l'initialisation
            this.SizeChanged += (s, e) => AdjustDataGridViewSize();
            dataGridViewTeams.DataBindingComplete += (s, e) => FinalizeDataGridViewSetup();
        }

        private void ConfigureDataGridView()
        {
            // Configuration de base
            dataGridViewTeams.Dock = DockStyle.Fill;
            dataGridViewTeams.Margin = new Padding(5);
            dataGridViewTeams.BackgroundColor = Color.White;
            dataGridViewTeams.BorderStyle = BorderStyle.None;

            // Style des cellules
            dataGridViewTeams.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dataGridViewTeams.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dataGridViewTeams.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;

            // Comportement
            dataGridViewTeams.RowHeadersVisible = false;
            dataGridViewTeams.AllowUserToAddRows = false;
            dataGridViewTeams.AllowUserToDeleteRows = false;
            dataGridViewTeams.ReadOnly = true;
            dataGridViewTeams.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTeams.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadTeamsData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Requête optimisée avec gestion des versions SQL sans STRING_AGG
                    string query = @"
                    SELECT 
                        t.TeamID,
                        t.Name AS TeamName,
                        leader.Username AS TeamLeader,
                        (
                            SELECT TOP 1 CONCAT(p.Title, ' (Chef: ', u.Username, ')')
                            FROM Projects p
                            JOIN Users u ON p.ManagerID = u.UserID
                            WHERE p.ManagerID = t.LeaderID
                            ORDER BY p.Title
                        ) AS ProjectWithLeader,
                        u.UserID,
                        u.Username AS MemberName,
                        u.Email AS MemberEmail,
                        u.Role AS MemberRole
                    FROM Teams t
                    LEFT JOIN Users leader ON t.LeaderID = leader.UserID
                    LEFT JOIN TeamMembers tm ON t.TeamID = tm.TeamID
                    LEFT JOIN Users u ON tm.UserID = u.UserID
                    ORDER BY t.Name, u.Username";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewTeams.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données: {ex.Message}", "Erreur",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FinalizeDataGridViewSetup()
        {
            try
            {
                // Masquer les colonnes techniques
                HideColumnIfExists("TeamID");
                HideColumnIfExists("UserID");

                // Configurer les colonnes visibles
                ConfigureColumnIfExists("TeamName", "Équipe", 150);
                ConfigureColumnIfExists("TeamLeader", "Chef d'Équipe", 120);
                ConfigureColumnIfExists("ProjectWithLeader", "Projet (Chef)", 200);
                ConfigureColumnIfExists("MemberName", "Membre", 120);
                ConfigureColumnIfExists("MemberEmail", "Email", 150);
                ConfigureColumnIfExists("MemberRole", "Rôle", 80);

                // Ajustement automatique des lignes
                dataGridViewTeams.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur de configuration finale: {ex.Message}");
            }
        }

        private void AdjustDataGridViewSize()
        {
            try
            {
                // Rééquilibrage des colonnes lors du redimensionnement
                if (dataGridViewTeams.Columns.Contains("ProjectWithLeader"))
                    dataGridViewTeams.Columns["ProjectWithLeader"].FillWeight = 40;

                if (dataGridViewTeams.Columns.Contains("TeamName"))
                    dataGridViewTeams.Columns["TeamName"].FillWeight = 20;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur d'ajustement: {ex.Message}");
            }
        }

        private void HideColumnIfExists(string columnName)
        {
            if (dataGridViewTeams.Columns.Contains(columnName))
            {
                dataGridViewTeams.Columns[columnName].Visible = false;
            }
        }

        private void ConfigureColumnIfExists(string columnName, string headerText, int width)
        {
            if (dataGridViewTeams.Columns.Contains(columnName))
            {
                dataGridViewTeams.Columns[columnName].HeaderText = headerText;
                dataGridViewTeams.Columns[columnName].Width = width;
                dataGridViewTeams.Columns[columnName].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }
    }
}
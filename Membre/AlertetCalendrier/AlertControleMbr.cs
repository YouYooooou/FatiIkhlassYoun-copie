using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace FatiIkhlassYoun.MemberEquipeFolder.hautePanel
{
    public partial class AlertControlMember : UserControl
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementSystem"].ConnectionString;
        private int currentUserId;

        public AlertControlMember(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
            InitializeDataGridView();
            LoadAlertTasks();
        }

        private void InitializeDataGridView()
        {
            // Configuration de base du DataGridView
            dataGridViewAlerts.Dock = DockStyle.Fill;
            dataGridViewAlerts.BackgroundColor = Color.White;
            dataGridViewAlerts.BorderStyle = BorderStyle.None;
            dataGridViewAlerts.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dataGridViewAlerts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dataGridViewAlerts.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;
            dataGridViewAlerts.RowHeadersVisible = false;
            dataGridViewAlerts.AllowUserToAddRows = false;
            dataGridViewAlerts.AllowUserToDeleteRows = false;
            dataGridViewAlerts.ReadOnly = true;
            dataGridViewAlerts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAlerts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadAlertTasks()
        {
            try
            {
                DataTable dataTable = new DataTable(); // Déclaration de dataTable

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                    SELECT 
                        t.TaskID,
                        t.Title AS 'Tâche',
                        ISNULL(p.Title, 'Sans projet') AS 'Projet',
                        t.Status AS 'Statut',
                        t.DueDate AS 'Date limite',
                        CASE 
                            WHEN t.DueDate < GETDATE() THEN 'En retard'
                            WHEN t.DueDate <= DATEADD(day, 3, GETDATE()) THEN 'Échéance proche'
                            ELSE 'En cours'
                        END AS 'État',
                        ISNULL(t.Priority, 'Non définie') AS 'Priorité'
                    FROM Tasks t
                    LEFT JOIN Projects p ON t.ProjectID = p.ProjectID
                    JOIN Task_Assignments ta ON t.TaskID = ta.TaskID
                    WHERE ta.UserID = @UserId
                    AND (t.Status = 'En cours' OR t.Status = 'En attente')
                    AND (t.DueDate < GETDATE() OR t.DueDate <= DATEADD(day, 3, GETDATE()))
                    ORDER BY t.DueDate, 
                        CASE t.Priority
                            WHEN 'Haute' THEN 1
                            WHEN 'Moyenne' THEN 2
                            WHEN 'Basse' THEN 3
                            ELSE 4
                        END";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@UserId", currentUserId);
                    adapter.Fill(dataTable);

                    // Appliquer des styles conditionnels
                    dataGridViewAlerts.DataSource = dataTable;
                    ApplyDataGridViewStyles();
                }

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Aucune alerte pour le moment", "Information",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des alertes: {ex.Message}", "Erreur",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyDataGridViewStyles()
        {
            if (dataGridViewAlerts.Columns.Contains("Date limite"))
            {
                dataGridViewAlerts.Columns["Date limite"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dataGridViewAlerts.Columns.Contains("État"))
            {
                dataGridViewAlerts.Columns["État"].DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }

            // Colorer les lignes en fonction de l'état
            foreach (DataGridViewRow row in dataGridViewAlerts.Rows)
            {
                if (row.Cells["État"].Value?.ToString() == "En retard")
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                    row.DefaultCellStyle.ForeColor = Color.DarkRed;
                }
                else if (row.Cells["État"].Value?.ToString() == "Échéance proche")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                    row.DefaultCellStyle.ForeColor = Color.DarkGoldenrod;
                }
            }

            dataGridViewAlerts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dataGridViewAlerts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                dataGridViewAlerts.Columns[e.ColumnIndex].Name == "Tâche" &&
                dataGridViewAlerts.Rows[e.RowIndex].Cells["TaskID"].Value != null)
            {
                int taskId = Convert.ToInt32(dataGridViewAlerts.Rows[e.RowIndex].Cells["TaskID"].Value);
                OnTaskSelected?.Invoke(taskId);
            }
        }

        public event Action<int> OnTaskSelected;
    }
}
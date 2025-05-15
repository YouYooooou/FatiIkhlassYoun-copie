using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration; // Nécessaire pour App.config

namespace WindowsFormsApp1
{
    public partial class AlertForm : Form
    {
        public AlertForm()
        {
            InitializeComponent();
            LoadAlertTasks();
        }

        private void LoadAlertTasks()
        {
            flowLayoutPanel1.Controls.Clear();

            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            string query = @"
    SELECT 
        T.Title, 
        T.Description, 
        T.DueDate, 
        T.Status, 
        P.Title AS ProjectTitle
    FROM Tasks T
    JOIN Projects P ON T.ProjectID = P.ProjectID
    WHERE 
        (T.DueDate < GETDATE() OR DATEDIFF(DAY, GETDATE(), T.DueDate) <= 3)
        AND LOWER(T.Status) <> 'Terminée'";


            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string title = reader["Title"].ToString();
                        string description = reader["Description"].ToString();
                        DateTime dueDate = Convert.ToDateTime(reader["DueDate"]);
                        string status = reader["Status"].ToString();
                        string projectTitle = reader["ProjectTitle"].ToString();

                        // Créer un panneau d’alerte pour chaque tâche
                        Panel alertPanel = new Panel
                        {
                            Width = flowLayoutPanel1.Width - 30,
                            Height = 100,
                            BackColor = dueDate < DateTime.Now ? Color.LightCoral : Color.Khaki,
                            Margin = new Padding(5)
                        };

                        Label lblTitle = new Label
                        {
                            Text = $"Tâche: {title} (Projet: {projectTitle})",
                            Font = new Font("Segoe UI", 10, FontStyle.Bold),
                            AutoSize = true,
                            Location = new Point(10, 10)
                        };

                        Label lblDesc = new Label
                        {
                            Text = $"Description: {description}",
                            AutoSize = true,
                            Location = new Point(10, 35)
                        };

                        Label lblDue = new Label
                        {
                            Text = $"Échéance: {dueDate:dd/MM/yyyy} | Statut: {status}",
                            AutoSize = true,
                            Location = new Point(10, 60)
                        };

                        alertPanel.Controls.Add(lblTitle);
                        alertPanel.Controls.Add(lblDesc);
                        alertPanel.Controls.Add(lblDue);

                        flowLayoutPanel1.Controls.Add(alertPanel);
                    }

                    if (!reader.HasRows)
                    {
                        Label noAlert = new Label
                        {
                            Text = "Aucune tâche en retard ou proche de l’échéance.",
                            AutoSize = true,
                            Font = new Font("Segoe UI", 10, FontStyle.Italic),
                            ForeColor = Color.Green,
                            Padding = new Padding(10)
                        };
                        flowLayoutPanel1.Controls.Add(noAlert);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des tâches en alerte : " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlertForm_Load(object sender, EventArgs e)
        {

        }
    }
}


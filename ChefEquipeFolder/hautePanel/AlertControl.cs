using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FatiIkhlassYoun.ChefEquipeFolder.hautePanel
{
    public partial class AlertControl : UserControl
    {
        private string connectionString = @"Data Source=YOUNES\SQLEXPRESS;Initial Catalog=ProjectManagementSystem;Integrated Security=True";

        public AlertControl()
        {
            InitializeComponent();

            // Ajouter un en-tête
            Label header = new Label
            {
                Text = "ALERTES - TÂCHES CRITIQUES",
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Height = 50,
                BackColor = Color.FromArgb(51, 51, 76),
                ForeColor = Color.White
            };
            this.Controls.Add(header);

            LoadAlerts();
        }

        private void LoadAlerts()
        {
            var alerts = GetAlertTasks();
            DisplayAlerts(alerts);
        }

        public List<AlertTask> GetAlertTasks()
        {
            var alerts = new List<AlertTask>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT t.TaskID, t.Title, t.DueDate, t.Status, p.Title as ProjectName 
                        FROM Tasks t
                        JOIN Projects p ON t.ProjectID = p.ProjectID
                        WHERE (t.Status = 'En cours' OR t.Status = 'En attente')
                        AND (t.DueDate < GETDATE() OR t.DueDate <= DATEADD(day, 3, GETDATE()))";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var task = new AlertTask
                        {
                            TaskID = (int)reader["TaskID"],
                            Title = reader["Title"].ToString(),
                            DueDate = (DateTime)reader["DueDate"],
                            Status = reader["Status"].ToString(),
                            ProjectName = reader["ProjectName"].ToString(),
                            IsOverdue = (DateTime)reader["DueDate"] < DateTime.Now
                        };
                        alerts.Add(task);
                    }
                }
            }

            return alerts;
        }

        private void DisplayAlerts(List<AlertTask> alerts)
        {
            SuspendLayout();
            Controls.Clear();

            if (!alerts.Any())
            {
                Label noAlertsLabel = new Label
                {
                    Text = "Aucune alerte pour le moment",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 12, FontStyle.Italic)
                };
                Controls.Add(noAlertsLabel);
                ResumeLayout();
                return;
            }

            Panel container = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(15) // Marge intérieure
            };

            int yPos = 10;
            int alertCount = 1;

            foreach (var alert in alerts.OrderByDescending(a => a.IsOverdue).ThenBy(a => a.DueDate))
            {
                Panel alertPanel = CreateAlertPanel(alert, alertCount++);
                alertPanel.Location = new Point(10, yPos);
                yPos += alertPanel.Height + 10;

                container.Controls.Add(alertPanel);
            }

            Controls.Add(container);
            ResumeLayout();
        }


        private Panel CreateAlertPanel(AlertTask alert, int alertNumber)
        {
            Panel panel = new Panel
            {
                BackColor = alert.IsOverdue ? Color.FromArgb(255, 230, 230) : Color.FromArgb(255, 255, 200),
                BorderStyle = BorderStyle.FixedSingle,
                Width = 730,
                Height = 120,
                Padding = new Padding(10)
            };

            Label numberLabel = new Label
            {
                Text = $"{alertNumber}.",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            Label titleLabel = new Label
            {
                Text = $"Tâche: {alert.Title}",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(40, 10),
                AutoSize = true
            };

            Label projectLabel = new Label
            {
                Text = $"Projet: {alert.ProjectName}",
                Font = new Font("Segoe UI", 9),
                Location = new Point(40, 35),
                AutoSize = true
            };

            Label statusLabel = new Label
            {
                Text = $"Statut: {alert.Status}",
                Font = new Font("Segoe UI", 9),
                Location = new Point(40, 55),
                AutoSize = true
            };

            Label dueDateLabel = new Label
            {
                Text = $"Date limite: {alert.DueDate:dd/MM/yyyy}",
                Font = new Font("Segoe UI", 9),
                Location = new Point(40, 75),
                AutoSize = true
            };

            Label alertTypeLabel = new Label
            {
                Text = alert.IsOverdue ? "EN RETARD!" : "ÉCHÉANCE PROCHE (3 jours ou moins)",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = alert.IsOverdue ? Color.Red : Color.Orange,
                Location = new Point(40, 95),
                AutoSize = true
            };

            Button actionButton = new Button
            {
                Text = "Voir détails",
                Tag = alert.TaskID,
                Size = new Size(100, 30),
                Location = new Point(panel.Width - 120, 40),
                FlatStyle = FlatStyle.Flat
            };

            // Modifier ici pour déclencher l'événement
            actionButton.Click += (s, e) => OnTaskSelected?.Invoke(alert.TaskID);

            panel.Controls.AddRange(new Control[] { numberLabel, titleLabel, projectLabel,
                                        statusLabel, dueDateLabel, alertTypeLabel,
                                        actionButton });

            return panel;
        }

        public event Action<int> OnTaskSelected; // Déplacer cette déclaration au niveau de la classe

        private void ShowTaskDetails(int taskId)
        {
            MessageBox.Show($"Affichage des détails de la tâche ID: {taskId}");
        }
    }

    public class AlertTask
    {
        public int TaskID { get; set; }
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
        public string ProjectName { get; set; }
        public bool IsOverdue { get; set; }
    }
}
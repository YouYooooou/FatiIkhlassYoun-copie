using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using FatiIkhlassYoun.ChefEquipeFolder.hautePanel;

namespace FatiIkhlassYoun.Membre.AlertetCalendrier
{
    public partial class CalendrierControleMbr : UserControl
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementSystem"].ConnectionString;
        private Dictionary<DateTime, List<string>> tachesParDate = new Dictionary<DateTime, List<string>>();

        public CalendrierControleMbr()
        {
            InitializeComponent();
            this.Load += CalendrierControleMbr_Load;
        }

        private void CalendrierControleMbr_Load(object sender, EventArgs e)
        {
            ChargerTachesMembre();
        }

        private void ChargerTachesMembre()
        {
            string query = @"
                SELECT t.Title, t.DueDate, t.Status 
                FROM Tasks t
                JOIN Task_Assignments ta ON t.TaskID = ta.TaskID
                WHERE ta.UserID = @userID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userID", SessionUtilisateur.UserID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    tachesParDate.Clear();

                    while (reader.Read())
                    {
                        string titre = reader.GetString(0);
                        DateTime date = reader.GetDateTime(1).Date;
                        string status = reader.GetString(2);

                        string affichage = $"Nom de la tâche : {titre} | Statut : ({status})";

                        if (!tachesParDate.ContainsKey(date))
                            tachesParDate[date] = new List<string>();

                        tachesParDate[date].Add(affichage);
                    }

                    monthCalendarMbr.BoldedDates = tachesParDate.Keys.ToArray();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors du chargement des tâches: {ex.Message}",
                                  "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void monthCalendarMbr_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime dateSelectionnee = monthCalendarMbr.SelectionStart.Date;
            labelDateMbr.Text = $"Tâches pour le {dateSelectionnee.ToString("dd/MM/yyyy")}";
            listBoxTasksMbr.Items.Clear();

            if (tachesParDate.ContainsKey(dateSelectionnee))
            {
                List<string> taches = tachesParDate[dateSelectionnee];
                if (taches.Count > 0)
                {
                    foreach (var tache in taches)
                    {
                        listBoxTasksMbr.Items.Add(tache);
                    }
                }
                else
                {
                    listBoxTasksMbr.Items.Add("Aucune tâche prévue.");
                }
            }
            else
            {
                listBoxTasksMbr.Items.Add("Aucune tâche prévue.");
            }
        }

        private void listBoxTasksMbr_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            string itemText = listBoxTasksMbr.Items[e.Index].ToString();
            Color itemColor = Color.Black;
            Font itemFont = new Font(e.Font, FontStyle.Bold);

            if (itemText.Contains("(En cours)"))
                itemColor = Color.Orange;
            else if (itemText.Contains("(Terminée)"))
                itemColor = Color.Green;
            else if (itemText.Contains("(En attente)"))
                itemColor = Color.Blue;

            e.DrawBackground();
            using (SolidBrush brush = new SolidBrush(itemColor))
            {
                e.Graphics.DrawString(itemText, itemFont, brush, e.Bounds);
            }
            e.DrawFocusRectangle();
        }
    }
}
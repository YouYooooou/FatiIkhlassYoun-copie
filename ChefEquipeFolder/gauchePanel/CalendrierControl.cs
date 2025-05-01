using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FatiIkhlassYoun.ChefEquipeFolder.hautePanel;
using System.Data.SqlClient;

namespace FatiIkhlassYoun
{
    public partial class CalendrierControl : UserControl
    {
        private Dictionary<DateTime, List<string>> tachesParDate = new Dictionary<DateTime, List<string>>();
        private string connectionString = @"Data Source=YOUNES\SQLEXPRESS;Initial Catalog=ProjectManagementSystem;Integrated Security=True;";
        public CalendrierControl()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime dateSelectionnee = monthCalendar1.SelectionStart.Date;
            // 🆕 Mettre à jour ton label
            labelDate.Text = $"Tâches pour le {dateSelectionnee.ToString("dd/MM/yyyy")}";
            CalendarTasksList.Items.Clear();

            if (tachesParDate.ContainsKey(dateSelectionnee))
            {
                List<string> taches = tachesParDate[dateSelectionnee];
                if (taches.Count > 0)
                {
                    foreach (var tache in taches)
                    {
                        CalendarTasksList.Items.Add(tache);
                    }
                }
                else
                {
                    CalendarTasksList.Items.Add("Aucune tâche prévue.");
                }
            }
            else
            {
                CalendarTasksList.Items.Add("Aucune tâche prévue.");
            }
        }



        private void CalendrierControl_Load(object sender, EventArgs e)
        {
            ChargerTachesChefEquipe();
        }
        private void ChargerTachesChefEquipe()
        {
            if (SessionUtilisateur.Role != "chef_equipe")
            {
                MessageBox.Show("Accès refusé : vous n'êtes pas un chef d'équipe.");
                return;
            }

            string query = @"
              SELECT Title, DueDate, Status 
              FROM Tasks 
              WHERE TeamLeadID = @userID
              ";

            using (SqlConnection conn = new SqlConnection(connectionString))
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

                    string affichage = $" Nom de la tâche : {titre}  |  Statue : ({status})";

                    if (!tachesParDate.ContainsKey(date))
                        tachesParDate[date] = new List<string>();

                    tachesParDate[date].Add(affichage);
                }
            }

            monthCalendar1.BoldedDates = tachesParDate.Keys.ToArray();
        }

        private void CalendarTasksList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return; // sécurité

            // Récupérer le texte de l'item
            string itemText = CalendarTasksList.Items[e.Index].ToString();

            // Définir la couleur par défaut
            Color itemColor = Color.Black;
            Font itemFont = new Font(e.Font, FontStyle.Bold); // Police en gras

            // Logique pour choisir la couleur en fonction du statut
            if (itemText.Contains("(En cours)"))
                itemColor = Color.Orange;
            else if (itemText.Contains("(Terminée)"))
                itemColor = Color.Green;
            else if (itemText.Contains("(En attente)"))
                itemColor = Color.Blue;

            // Dessiner le fond
            e.DrawBackground();

            // Dessiner le texte
            using (SolidBrush brush = new SolidBrush(itemColor))
            {
                e.Graphics.DrawString(itemText, itemFont, brush, e.Bounds);
            }

            // Dessiner un cadre autour si sélectionné
            e.DrawFocusRectangle();
        }

        private void CalendarTasksList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }

        private void labelDate_Click_1(object sender, EventArgs e)
        {

        }
    }
}

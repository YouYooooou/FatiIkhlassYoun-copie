using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class TacheStatistiquesForm : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementSystem"].ConnectionString;

        public TacheStatistiquesForm()
        {
            InitializeComponent();
        }

        private void ChargerEquipes()
        {
            comboEquipes.Items.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT TeamID, Name FROM Teams";  
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                comboEquipes.DisplayMember = "Name";
                comboEquipes.ValueMember = "TeamID";
                comboEquipes.DataSource = dt;
            }

            if (comboEquipes.Items.Count > 0)
                comboEquipes.SelectedIndex = 0;
        }

        private void ChargerDonneesParEquipe(string nomEquipe)
        {
            int nbTerminees = 0;
            int nbEnCours = 0;
            int nbEnAttente = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT T.Status, COUNT(*) AS Nombre
            FROM Tasks T
            JOIN Task_Assignments TA ON T.TaskID = TA.TaskID
            JOIN TeamMembers TM ON TA.UserID = TM.UserID
            JOIN Teams E ON TM.TeamID = E.TeamID
            WHERE E.Name = @Equipe
            GROUP BY T.Status";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Equipe", nomEquipe);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string status = reader["Status"].ToString();
                    int count = Convert.ToInt32(reader["Nombre"]);

                    switch (status)
                    {
                        case "Terminée":
                            nbTerminees = count;
                            break;
                        case "En cours":
                            nbEnCours = count;
                            break;
                        case "En attente":
                            nbEnAttente = count;
                            break;
                    }
                }
            }

            // Mise à jour des labels
            lblTerminees.Text = $"Tâches Terminées : {nbTerminees}";
            lblEnCours.Text = $"Tâches En cours : {nbEnCours}";
            lblEnAttente.Text = $"Tâches En attente : {nbEnAttente}";

            // Mise à jour du graphique
            chartTaches.Series.Clear();
            chartTaches.ChartAreas.Clear();
            chartTaches.Legends.Clear();
            chartTaches.Titles.Clear();

            chartTaches.ChartAreas.Add(new ChartArea("Zone"));
            Legend legend = new Legend("Légende");
            chartTaches.Legends.Add(legend);

            Series serie = new Series("Tâches");
            serie.ChartType = SeriesChartType.Pie;
            serie.Points.AddXY("Terminée", nbTerminees);
            serie.Points.AddXY("En cours", nbEnCours);
            serie.Points.AddXY("En attente", nbEnAttente);

            serie.Points[0].Color = Color.Green;
            serie.Points[1].Color = Color.Orange;
            serie.Points[2].Color = Color.Red;

            chartTaches.Series.Add(serie);
            serie.Legend = "Légende";
        }



        private void ChargerDonneesTaches()
        {
            int nbTerminees = 0;
            int nbEnCours = 0;
            int nbEnAttente = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT Status, COUNT(*) as Nombre FROM Tasks GROUP BY Status";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string status = reader["Status"].ToString();
                    int count = Convert.ToInt32(reader["Nombre"]);

                    switch (status)
                    {
                        case "Terminée":
                            nbTerminees = count;
                            break;
                        case "En cours":
                            nbEnCours = count;
                            break;
                        case "En attente":
                            nbEnAttente = count;
                            break;
                    }

                    lblTerminees.Text = $"Tâches Terminées : {nbTerminees}";
                    lblEnCours.Text = $"Tâches En cours : {nbEnCours}";
                    lblEnAttente.Text = $"Tâches En attente : {nbEnAttente}";

                }
            }

            // Configurer le chart
            chartTaches.Series.Clear();
            chartTaches.ChartAreas.Clear();
            chartTaches.Legends.Clear();
            chartTaches.Titles.Clear();

            // Ajouter une zone pour le graphique
            chartTaches.ChartAreas.Add(new ChartArea("Zone"));

            // Ajouter et configurer la légende
            Legend legend = new Legend("Légende");
            chartTaches.Legends.Add(legend);

            // Créer la série
            Series serie = new Series("Tâches");
            serie.ChartType = SeriesChartType.Pie;
            serie.Points.AddXY("Terminée", nbTerminees);
            serie.Points.AddXY("En cours", nbEnCours);
            serie.Points.AddXY("En attente", nbEnAttente);

            // Appliquer des couleurs personnalisées
            serie.Points[0].Color = Color.Green;      // Terminée
            serie.Points[1].Color = Color.Orange;     // En cours
            serie.Points[2].Color = Color.Red;        // En attente

            // Ajouter la série au graphique
            chartTaches.Series.Add(serie);

            // Assurer que la légende est correctement assignée à la série
            serie.Legend = "Légende";
        }

        private void StatistiquesForm_Load(object sender, EventArgs e)
        {
            chartTaches.Series.Clear();
            chartTaches.ChartAreas.Clear();

            // Créer une nouvelle zone de graphique
            ChartArea area = new ChartArea("ZonePrincipale");
            area.BackColor = Color.White;
            chartTaches.ChartAreas.Add(area);

            // Créer une nouvelle série pour afficher les tâches
            Series serieTaches = new Series("Statut des Tâches");
            serieTaches.ChartType = SeriesChartType.Pie;
            serieTaches.IsValueShownAsLabel = true;
            serieTaches.LabelForeColor = Color.Black;

            // Ajouter la série au graphique
            chartTaches.Series.Add(serieTaches);

            // Charger les données dans le graphique
            ChargerDonneesTaches();

            ChargerEquipes();
        }

        private void chartTaches_Click(object sender, EventArgs e)
        {
            // Code d'événement au besoin
        }

        private void lblTerminees_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrerEquipe_Click(object sender, EventArgs e)
        {
            if (comboEquipes.SelectedItem != null)
            {
                DataRowView selectedRow = comboEquipes.SelectedItem as DataRowView;
                string nomEquipe = selectedRow["Name"].ToString();
                ChargerDonneesParEquipe(nomEquipe);
            }
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

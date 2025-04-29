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
using FatiIkhlassYoun.ChefEquipeFolder.hautePanel;
using FatiIkhlassYoun.NewFolder;
//using System.Windows.Forms.DataVisualization.Charting;


namespace FatiIkhlassYoun
{
    public partial class DashboardControl : UserControl
    {
        public int idChefEquipe; // 🟩 À remplir lors du login
        private Button btnModifier;
        private Button btnSupprimer;
        private int selectedTaskId;


        public DashboardControl()
        {
            InitializeComponent();
            this.Load += UserControlDashboard_Load;
            idChefEquipe = SessionUtilisateur.UserID; // ✅ lire depuis la session

            btnModifier = new Button
            {
                Text = "Modifier",
                Size = new Size(100, 30),
                Visible = false
            };
            btnSupprimer = new Button
            {
                Text = "Supprimer",
                Size = new Size(100, 30),
                Visible = false
            };

            // Positionne les boutons (ajuste si nécessaire)
            btnModifier.Location = new Point(50, dataGridViewTaches.Bottom + 10);
            btnSupprimer.Location = new Point(160, dataGridViewTaches.Bottom + 10);

            // Ajoute les événements
            btnModifier.Click += BtnModifier_Click;
            btnSupprimer.Click += BtnSupprimer_Click;

            // Ajoute les boutons au contrôle
            this.Controls.Add(btnModifier);
            this.Controls.Add(btnSupprimer);

            // Ajoute l'événement pour masquer les boutons lors d'un clic sur le DashboardControl
            this.Click += DashboardControl_Click;  // C'est ici que vous ajoutez l'événement
        }

        string connectionString = "Data Source=YOUNES\\SQLEXPRESS;Initial Catalog=ProjectManagementSystem;Integrated Security=True";


        private void dataGridViewTaches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewTaches.Rows[e.RowIndex].Cells["TaskID"].Value != DBNull.Value)
            {
                selectedTaskId = Convert.ToInt32(dataGridViewTaches.Rows[e.RowIndex].Cells["TaskID"].Value);

                // Obtenir la position du curseur dans le contrôle parent (DashboardControl)
                Point mousePosition = dataGridViewTaches.PointToClient(Cursor.Position);
                Point positionDansControl = dataGridViewTaches.PointToScreen(mousePosition);
                Point positionRelative = this.PointToClient(positionDansControl);

                // Positionner le bouton "Modifier" au niveau du curseur
                btnModifier.Location = new Point(positionRelative.X, positionRelative.Y);

                // Positionner le bouton "Supprimer" juste en dessous du bouton "Modifier"
                btnSupprimer.Location = new Point(positionRelative.X, positionRelative.Y + btnModifier.Height + 5);

                btnModifier.Visible = true;
                btnSupprimer.Visible = true;

                btnModifier.BringToFront();
                btnSupprimer.BringToFront();
            }
            else
            {
                btnModifier.Visible = false;
                btnSupprimer.Visible = false;
            }
        }



        private int GetCountFromQuery(string query)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                return (int)cmd.ExecuteScalar();
            }
        }
        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            MettreAJourStatistiques();
        }

        private void MettreAJourStatistiques()
        {
            int tachesTerminees = GetCountFromQuery("SELECT COUNT(*) FROM Tasks WHERE Status = 'Terminée'");
            int tachesEnCours = GetCountFromQuery("SELECT COUNT(*) FROM Tasks WHERE Status = 'En cours'");

            // Nouvelle requête pour compter les membres actifs par tâches en attente
            int tachesEnAttente = GetCountFromQuery(@"SELECT COUNT(*) FROM Tasks WHERE Status = 'En attente'");

            int totalEquipes = GetCountFromQuery("SELECT COUNT(*) FROM Teams");

            labelTachesTerminees.Text = $"Tâches terminées : {tachesTerminees}";
            labelTachesEnCours.Text = $"Tâches en cours : {tachesEnCours}";
            labelMembresActifs.Text = $"Tâches en attente : {tachesEnAttente}";
            labelEquipes.Text = $"Équipes : {totalEquipes}";
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            MettreAJourStatistiques();
        }


        private void labelTitre_Click(object sender, EventArgs e)
        {

        }
        private void ChargerTachesChefEquipe(int idChefEquipe)
        {
            string connectionString = @"Data Source=YOUNES\SQLEXPRESS;Initial Catalog=ProjectManagementSystem;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT 
                                t.TaskID,
                                t.Title AS TitreTache,
                                t.Status,
                                t.DueDate,
                                p.Title AS NomProjet
                             FROM Tasks t
                             JOIN Projects p ON t.ProjectID = p.ProjectID
                             WHERE t.TeamLeadID = @idChefEquipe";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idChefEquipe", idChefEquipe);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewTaches.DataSource = dt;

                    ColorerTachesRetardées();
                }
            }
        }
        private void ColorerTachesRetardées()
        {
            foreach (DataGridViewRow row in dataGridViewTaches.Rows)
            {
                if (row.Cells["DueDate"].Value != DBNull.Value)
                {
                    DateTime dueDate = Convert.ToDateTime(row.Cells["DueDate"].Value);
                    string status = row.Cells["Status"].Value.ToString();

                    if (dueDate < DateTime.Now && status != "Terminée")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }
        private void groupBoxStats_Enter(object sender, EventArgs e)
        {

        }

        private void labelTachesEnCours_Click(object sender, EventArgs e)
        {

        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            ChargerTachesChefEquipe(idChefEquipe);
            dataGridViewTaches.CellClick += dataGridViewTaches_CellClick;
            dataGridViewTaches.CellMouseClick += DataGridViewTaches_CellMouseClick;
         }

        private void DataGridViewTaches_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) // Clic sur l’en-tête ou ailleurs dans la grille
            {
                btnModifier.Visible = false;
                btnSupprimer.Visible = false;
            }
        }


        private void dataGridViewTaches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            // Ouvre le formulaire de modification avec l'ID de la tâche sélectionnée
            ModifierTache modifForm = new ModifierTache(SessionUtilisateur.UserID, selectedTaskId);
            modifForm.ShowDialog();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            SupprimerTache suppForm = new SupprimerTache(SessionUtilisateur.UserID, selectedTaskId);
            suppForm.ShowDialog();
        }

        // Ajoutez un gestionnaire pour les clics ailleurs dans le contrôle (par exemple dans la forme parent)
        private void DashboardControl_Click(object sender, EventArgs e)
        {
            btnModifier.Visible = false;
            btnSupprimer.Visible = false;
        }


    }
}

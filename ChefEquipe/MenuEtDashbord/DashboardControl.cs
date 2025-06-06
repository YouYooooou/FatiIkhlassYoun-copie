﻿using System;
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
using System.Configuration;
//using System.Windows.Forms.DataVisualization.Charting;


namespace FatiIkhlassYoun
{
    public partial class DashboardControl : UserControl
    {
        public int idChefEquipe;
        private Button btnModifier;
        private Button btnSupprimer;
        private int selectedTaskId;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementSystem"].ConnectionString;

        public DashboardControl()
        {
            InitializeComponent();
            this.Load += UserControlDashboard_Load;
            idChefEquipe = SessionUtilisateur.UserID;


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

            btnModifier.Location = new Point(50, dataGridViewTaches.Bottom + 10);
            btnSupprimer.Location = new Point(160, dataGridViewTaches.Bottom + 10);

            btnModifier.Click += BtnModifier_Click;
            btnSupprimer.Click += BtnSupprimer_Click;

            this.Controls.Add(btnModifier);
            this.Controls.Add(btnSupprimer);
            this.Click += DashboardControl_Click;
        }

        private void InitializeProgressBar()
        {
            // Création de la ProgressBar
            progressBarTaches = new ProgressBar
            {
                Location = new Point(86, 220), // Position sous le groupBoxStats
                Size = new Size(578, 23),
                Minimum = 0,
                Maximum = 100,
                Step = 1
            };

            // Création du label pour afficher le pourcentage
            labelProgression = new Label
            {
                Location = new Point(progressBarTaches.Right + 10, progressBarTaches.Top),
                Size = new Size(50, 23),
                TextAlign = ContentAlignment.MiddleLeft
            };

            // Ajout des contrôles au UserControl
            this.Controls.Add(progressBarTaches);
            this.Controls.Add(labelProgression);

            // Ajustez la position du DataGridView
            dataGridViewTaches.Location = new Point(39, progressBarTaches.Bottom + 20);
        }

        private void MettreAJourProgressBar()
        {
            int totalTaches = GetCountFromQuery("SELECT COUNT(*) FROM Tasks WHERE TeamLeadID = " + idChefEquipe);
            int tachesTerminees = GetCountFromQuery("SELECT COUNT(*) FROM Tasks WHERE Status = 'Terminée' AND TeamLeadID = " + idChefEquipe);

            if (totalTaches > 0)
            {
                int pourcentage = (int)((double)tachesTerminees / totalTaches * 100);
                progressBarTaches.Value = pourcentage;
                labelProgression.Text = $"{pourcentage}%";
            }
            else
            {
                progressBarTaches.Value = 0;
                labelProgression.Text = "0%";
            }
        }

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

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Nouvelle requête qui regroupe les membres par tâche
                string query = @"
        SELECT 
            t.TaskID,
            t.Title AS TitreTache,
            t.Status,
            t.DueDate,
            p.Title AS NomProjet,
            STRING_AGG(u.Username, ', ') AS MembresAffectes
        FROM Tasks t
        JOIN Projects p ON t.ProjectID = p.ProjectID
        LEFT JOIN Task_Assignments ta ON t.TaskID = ta.TaskID
        LEFT JOIN Users u ON ta.UserID = u.UserID
        WHERE t.TeamLeadID = @idChefEquipe
        GROUP BY t.TaskID, t.Title, t.Status, t.DueDate, p.Title";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idChefEquipe", idChefEquipe);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewTaches.DataSource = dt;

                    // Configurer les colonnes
                    ConfigurerColonnesDataGridView();
                    ColorerTachesRetardées();
                }
            }
        }
        private void ConfigurerColonnesDataGridView()
        {
            if (dataGridViewTaches.Columns.Count > 0)
            {
                // Masquer la colonne TaskID (optionnel)
                dataGridViewTaches.Columns["TaskID"].Visible = false;

                // Configurer les en-têtes
                dataGridViewTaches.Columns["TitreTache"].HeaderText = "Tâche";
                dataGridViewTaches.Columns["Status"].HeaderText = "Statut";
                dataGridViewTaches.Columns["DueDate"].HeaderText = "Date limite";
                dataGridViewTaches.Columns["NomProjet"].HeaderText = "Projet";
                dataGridViewTaches.Columns["MembresAffectes"].HeaderText = "Membres affectés";

                // Formater la date
                dataGridViewTaches.Columns["DueDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

                // Configurer la colonne des membres pour afficher les noms sur plusieurs lignes
                dataGridViewTaches.Columns["MembresAffectes"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridViewTaches.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
            MettreAJourProgressBar();
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
            MettreAJourProgressBar();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            SupprimerTache suppForm = new SupprimerTache(SessionUtilisateur.UserID, selectedTaskId);
            suppForm.ShowDialog();
            MettreAJourProgressBar();
        }

        // Ajoutez un gestionnaire pour les clics ailleurs dans le contrôle (par exemple dans la forme parent)
        private void DashboardControl_Click(object sender, EventArgs e)
        {
            btnModifier.Visible = false;
            btnSupprimer.Visible = false;
        }
        public void SelectTaskInGrid(int taskId)
        {
            // Attendre que la DataGridView soit remplie si nécessaire
            if (dataGridViewTaches.DataSource == null || dataGridViewTaches.Rows.Count == 0)
            {
                ChargerTachesChefEquipe(idChefEquipe);
            }

            foreach (DataGridViewRow row in dataGridViewTaches.Rows)
            {
                // Vérifier si la ligne n'est pas une nouvelle ligne (ligne vide pour l'ajout)
                if (!row.IsNewRow && row.Cells["TaskID"].Value != null &&
                    Convert.ToInt32(row.Cells["TaskID"].Value) == taskId)
                {
                    try
                    {
                        // Désélectionner toutes les lignes d'abord
                        dataGridViewTaches.ClearSelection();

                        // Sélectionner la ligne
                        row.Selected = true;

                        // Définir la cellule courante (utilisez une colonne visible)
                        dataGridViewTaches.CurrentCell = row.Cells[1]; // Choisissez l'index d'une colonne visible

                        // Faire défiler jusqu'à la ligne
                        dataGridViewTaches.FirstDisplayedScrollingRowIndex = row.Index;

                        // Simuler un clic sur la ligne pour afficher les boutons
                        if (dataGridViewTaches_CellClick != null)
                        {
                            dataGridViewTaches_CellClick(null, new DataGridViewCellEventArgs(1, row.Index));
                        }

                        break;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur lors de la sélection de la tâche: {ex.Message}");
                    }
                }
            }
        }


    }
}

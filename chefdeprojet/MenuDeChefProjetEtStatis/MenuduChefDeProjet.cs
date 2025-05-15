using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.ComponentModel;
using System.Diagnostics;
using ProjectManagementSystem.ChefProjetFolder.Reports;
using System.Linq;

namespace WindowsFormsApp1
{
    public partial class MenuduChefDeProjet : Form
    {
        private TreeView treeViewEquipes;
        private PictureBox pictureBoxChef;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementSystem"].ConnectionString;

        public MenuduChefDeProjet()
        {
            InitializeComponent(); // Doit être appelé en premier

            // Ensuite initialiser les composants personnalisés
            InitializeCustomComponents();

            // Configuration initiale
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(800, 600);

            // Configurer le DataGridView
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellMouseEnter += dataGridView1_CellMouseEnter;
            dataGridView1.CellMouseLeave += dataGridView1_CellMouseLeave;

            // Charger les données
            this.Load += (s, args) => {
                labelRole.Location = new Point((panelMenu.Width - labelRole.Width) / 2,
                                             (panelMenu.Height - labelRole.Height) / 2);
                ChargerTreeView();
                AfficherInfosChefProjet();
                LoadAllTeams();
                MettreAJourProgressionGlobale();
            };
        }

        private void InterfaceChefDeProjet_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("InterfaceChefDeProjet_Load appelée");
            labelRole.Location = new Point((panelMenu.Width - labelRole.Width) / 2, (panelMenu.Height - labelRole.Height) / 2);
            ChargerTreeView();
            AfficherInfosChefProjet();
            LoadAllTeams();
            MettreAJourProgressionGlobale();
        }

        private void LoadDataGrid()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            // Par défaut, on peut charger uniquement les colonnes pour l'affichage global des équipes
            dataGridView1.Columns.Add("TeamName", "Nom de l'équipe");
            dataGridView1.Columns.Add("LeaderName", "Chef de l'équipe");
            dataGridView1.Columns.Add("MemberCount", "Nombre de membres");
            dataGridView1.Columns.Add("TaskCount", "Nombre de tâches");



        }

        private void InitializeCustomComponents()
        {
            treeViewEquipes = new TreeView
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 9),
                BackColor = Color.WhiteSmoke
            };
            treeViewEquipes.AfterSelect += treeViewEquipes_AfterSelect;
            panelSidebar.Controls.Add(treeViewEquipes);

            pictureBoxChef = new PictureBox
            {
                Size = new Size(100, 100),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Dock = DockStyle.Top
            };
            panelInfos.Controls.Add(pictureBoxChef);
        }


        private void ChargerTreeView()
        {
            treeViewEquipes.Nodes.Clear();
            TreeNode noeudEquipes = new TreeNode("Équipes");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmdEquipes = new SqlCommand("SELECT TeamID, Name, LeaderID FROM Teams", conn);
                SqlDataReader readerEquipes = cmdEquipes.ExecuteReader();

                while (readerEquipes.Read())
                {
                    int teamId = Convert.ToInt32(readerEquipes["TeamID"]);
                    string teamName = readerEquipes["Name"].ToString();
                    int leaderId = Convert.ToInt32(readerEquipes["LeaderID"]);

                    string nomChef = GetNomUtilisateur(conn, leaderId);

                    TreeNode nodeEquipe = new TreeNode(teamName);
                    nodeEquipe.Nodes.Add(new TreeNode($"Chef : {nomChef}"));

                    TreeNode nodeMembres = new TreeNode("Membres");

                    // Charger les membres SAUF le chef (LeaderID)
                    SqlCommand cmdMembres = new SqlCommand(@"
                SELECT U.Username
                FROM TeamMembers TM
                JOIN Users U ON TM.UserID = U.UserID
                WHERE TM.TeamID = @TeamID AND U.UserID <> @LeaderID", conn);

                    cmdMembres.Parameters.AddWithValue("@TeamID", teamId);
                    cmdMembres.Parameters.AddWithValue("@LeaderID", leaderId);

                    using (SqlDataReader readerMembres = cmdMembres.ExecuteReader())
                    {
                        while (readerMembres.Read())
                        {
                            string username = readerMembres["Username"].ToString();
                            nodeMembres.Nodes.Add(new TreeNode(username));
                        }
                    }

                    nodeEquipe.Nodes.Add(nodeMembres);

                    // Charger les tâches
                    TreeNode nodeTaches = new TreeNode("Tâches");
                    SqlCommand cmdTaches = new SqlCommand("SELECT Title FROM Tasks WHERE TeamID = @TeamID", conn);
                    cmdTaches.Parameters.AddWithValue("@TeamID", teamId);

                    using (SqlDataReader readerTaches = cmdTaches.ExecuteReader())
                    {
                        while (readerTaches.Read())
                        {
                            string titre = readerTaches["Title"].ToString();
                            nodeTaches.Nodes.Add(new TreeNode(titre));
                        }
                    }

                    nodeEquipe.Nodes.Add(nodeTaches);
                    noeudEquipes.Nodes.Add(nodeEquipe);
                }
            }

            treeViewEquipes.Nodes.Add(noeudEquipes);
            treeViewEquipes.ExpandAll();
        }




        private void LoadAllTeams()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("TeamName", "Nom de l'équipe");
            dataGridView1.Columns.Add("LeaderName", "Chef de l'équipe");
            dataGridView1.Columns.Add("MemberCount", "Nombre de membres");
            dataGridView1.Columns.Add("TaskCount", "Nombre de tâches");

            AjouterColonnesBoutons();




            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @" SELECT 
                T.Name AS TeamName,
                U.Username AS LeaderName,
                (SELECT COUNT(*) FROM TeamMembers TM WHERE TM.TeamID = T.TeamID) AS MemberCount,
                (SELECT COUNT(*) FROM Tasks TK WHERE TK.TeamID = T.TeamID) AS TaskCount
                FROM Teams T
                JOIN Users U ON T.LeaderID = U.UserID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(
                            reader["TeamName"].ToString(),
                            reader["LeaderName"].ToString(),
                            reader["MemberCount"].ToString(),
                            reader["TaskCount"].ToString()
                        );
                    }
                }
            }
        }



        public class DataGridViewProgressColumn : DataGridViewImageColumn
        {
            public DataGridViewProgressColumn()
            {
                this.CellTemplate = new DataGridViewProgressCell();
                this.ValueType = typeof(int);
            }
        }

        public class DataGridViewProgressCell : DataGridViewImageCell
        {
            static Image emptyImage;

            static DataGridViewProgressCell()
            {
                emptyImage = new Bitmap(1, 1, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            }

            public DataGridViewProgressCell()
            {
                this.ValueType = typeof(int);
            }

            protected override object GetFormattedValue(object value,
                int rowIndex, ref DataGridViewCellStyle cellStyle,
                TypeConverter valueTypeConverter, TypeConverter formattedValueTypeConverter,
                DataGridViewDataErrorContexts context)
            {
                return emptyImage;
            }

            protected override void Paint(Graphics g, Rectangle clipBounds,
                Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState,
                object value, object formattedValue, string errorText,
                DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle,
                DataGridViewPaintParts paintParts)
            {
                base.Paint(g, clipBounds, cellBounds, rowIndex, cellState,
                    value, formattedValue, errorText, cellStyle,
                    advancedBorderStyle, paintParts);

                int progressVal = (value == DBNull.Value) ? 0 : Convert.ToInt32(value);

                float percentage = ((float)progressVal / 100.0f);
                Brush backColorBrush = new SolidBrush(cellStyle.BackColor);
                Brush foreColorBrush = new SolidBrush(cellStyle.ForeColor);

                // Efface la cellule
                g.FillRectangle(backColorBrush, cellBounds);

                // Dessine la bordure
                PaintBorder(g, clipBounds, cellBounds, cellStyle, advancedBorderStyle);

                // Dessine la barre
                if (progressVal > 0)
                {
                    g.FillRectangle(Brushes.LightGreen, cellBounds.X + 2, cellBounds.Y + 2,
                        Convert.ToInt32((percentage * (cellBounds.Width - 4))), cellBounds.Height - 4);
                }

                // Texte (ex : "75%")
                string text = progressVal.ToString() + "%";
                SizeF textSize = g.MeasureString(text, cellStyle.Font);
                PointF textLocation = new PointF(cellBounds.X + (cellBounds.Width - textSize.Width) / 2,
                                                 cellBounds.Y + (cellBounds.Height - textSize.Height) / 2);
                g.DrawString(text, cellStyle.Font, foreColorBrush, textLocation);
            }
        }



        private void treeViewEquipes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            if (selectedNode.Text == "Équipes")
            {
                LoadAllTeams(); // Affiche la liste globale des équipes
            }
            else if (selectedNode.Parent != null && selectedNode.Parent.Text == "Équipes") // Clique sur une équipe (ex: Équipe A)
            {
                string nomEquipe = selectedNode.Text;
                ChargerDetailsEquipe(nomEquipe); // Affiche les détails de cette équipe
            }

            if (e.Node.Level == 2 && e.Node.Text == "Tâches") // 3e niveau
            {
                TreeNode parentEquipe = e.Node.Parent;
                int teamID = ObtenirTeamIDDepuisNom(parentEquipe.Text); // crée cette méthode si nécessaire
                LoadTachesAvecProgression(teamID);
            }
        }

        private int ObtenirTeamIDDepuisNom(string nomEquipe)
        {
            int teamID = -1;

            using(SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT TeamID FROM Teams WHERE Name = @nomEquipe", con);
                cmd.Parameters.AddWithValue("@nomEquipe", nomEquipe);

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    teamID = Convert.ToInt32(result);
                }
            }

            return teamID;
        }






        private void ChargerDetailsEquipe(string nomEquipe)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            // Colonnes spécifiques aux détails d'une équipe
            dataGridView1.Columns.Add("ChefEquipe", "Chef d'Équipe");
            dataGridView1.Columns.Add("MembreEquipe", "Membre");
            dataGridView1.Columns.Add("NomTache", "Tâche");
            dataGridView1.Columns.Add("StatutTache", "Statut");

            DataGridViewProgressColumn progressColumn = new DataGridViewProgressColumn();
            progressColumn.HeaderText = "Progression";
            progressColumn.Name = "Progression";
            dataGridView1.Columns.Add(progressColumn);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Obtenir ID équipe + nom chef
                SqlCommand cmd = new SqlCommand(@" SELECT t.TeamID, u.Username AS ChefNom
               FROM Teams t
               JOIN Users u ON t.LeaderID = u.UserID
               WHERE t.Name = @NomEquipe", conn);
                cmd.Parameters.AddWithValue("@NomEquipe", nomEquipe);

                int teamId = 0;
                string nomChef = "";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        teamId = reader.GetInt32(0);
                        nomChef = reader.GetString(1);
                    }
                }

                // Obtenir les tâches + progression + membres assignés
                cmd = new SqlCommand(@"SELECT ta.Title, ta.Status, tas.Progression, COALESCE(u.Username, 'Non assigné') AS Membre
                FROM Tasks ta
                LEFT JOIN Task_Assignments tas ON ta.TaskID = tas.TaskID
                LEFT JOIN Users u ON tas.UserID = u.UserID
                WHERE ta.TeamID = @TeamID", conn);
                cmd.Parameters.AddWithValue("@TeamID", teamId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nomTache = reader.GetString(0);
                        string statut = reader.IsDBNull(1) ? "Non défini" : reader.GetString(1);
                        int progress = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                        string membre = reader.GetString(3);

                        Console.WriteLine($"Tâche: {nomTache}, Membre: {membre}, Progression: {progress}");
                        dataGridView1.Rows.Add(nomChef, membre, nomTache, statut, progress);
                    }
                }
            }

            AjouterColonnesBoutons();
        }

        private void LoadTachesAvecProgression(int teamID)
        {
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"
            SELECT ta.Title AS TitreTache, tas.Progression
            FROM Tasks ta
            INNER JOIN Task_Assignments tas ON ta.TaskID = tas.TaskID
            WHERE ta.TeamID = @teamID", con);

                cmd.Parameters.AddWithValue("@teamID", teamID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
              
                adapter.Fill(table);

                Console.WriteLine("Nombre de tâches récupérées : " + table.Rows.Count);
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = table;
               

                AjouterProgressBarColumn();
            }
        }

        private void AjouterProgressBarColumn()
        {
            if (dataGridView1.Columns.Contains("Progression"))
            {
                DataGridViewProgressColumn progressColumn = new DataGridViewProgressColumn
                {
                    HeaderText = "Progression",
                    Name = "ProgressionBar",
                    DataPropertyName = "Progression", // doit correspondre à la colonne du DataTable
                    Width = 200
                };

                if (!dataGridView1.Columns.Contains("ProgressionBar"))
                    dataGridView1.Columns.Add(progressColumn);
            }
        }








        private void AfficherInfosChefProjet()
        {
            panelInfos.Controls.Clear();

            Label titre = new Label
            {
                Text = "Chef de Projet : Ahmed",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Dock = DockStyle.Top,
                Height = 40
            };

            Label email = new Label
            {
                Text = "Email : ahmed@entreprise.com",
                Dock = DockStyle.Top
            };

            Label tel = new Label
            {
                Text = "Téléphone : 0612345678",
                Dock = DockStyle.Top
            };

            Button btnParametres = new Button
            {
                Text = "⚙ Paramètres",
                Dock = DockStyle.Top,
                Height = 30
            };

            panelInfos.Controls.Add(btnParametres);
            panelInfos.Controls.Add(tel);
            panelInfos.Controls.Add(email);
            panelInfos.Controls.Add(titre);
        }

        private void AfficherInfosChefEquipe(string nomEquipe, string nomChef, string photoChef)
        {
            panelInfos.Controls.Clear();

            Label titre = new Label
            {
                Text = $"Chef de l'équipe : {nomChef}",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Dock = DockStyle.Top,
                Height = 40
            };

            Label equipe = new Label
            {
                Text = $"Équipe : {nomEquipe}",
                Dock = DockStyle.Top
            };

            Button btnModifier = new Button
            {
                Text = "Modifier le profil",
                Dock = DockStyle.Top,
                Height = 30
            };

            panelInfos.Controls.Add(btnModifier);
            panelInfos.Controls.Add(equipe);
            panelInfos.Controls.Add(titre);
        }

        private string GetPhotoChef(string nomChef)
        {
            if (nomChef == "Alice") return "chemin/vers/photoAlice.jpg";
            if (nomChef == "David") return "chemin/vers/photoDavid.jpg";
            return "chemin/vers/photoDefault.jpg";
        }



        private void LoadTeamDetails(string nomEquipe)
        {
           string query = @" SELECT U.Username AS Membre,T.Title AS Tâche,TA.Progression
           FROM Teams TE
           JOIN TeamMembers TM ON TE.TeamID = TM.TeamID
           JOIN Users U ON TM.UserID = U.UserID
           JOIN Task_Assignments TA ON U.UserID = TA.UserID
           JOIN Tasks T ON TA.TaskID = T.TaskID
           WHERE TE.Name = @Name";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Name", nomEquipe);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                // Configurer la colonne Progression comme ProgressBar
                if (!dataGridView1.Columns.Contains("ProgressionBar"))
                {
                    DataGridViewProgressColumn progressColumn = new DataGridViewProgressColumn();
                    progressColumn.HeaderText = "Progression (%)";
                    progressColumn.DataPropertyName = "Progression";
                    progressColumn.Name = "ProgressionBar";
                    progressColumn.Width = 150;

                    dataGridView1.Columns.Add(progressColumn);
                }

                dataGridView1.Columns["Progression"].Visible = false; // Masquer la colonne brute si besoin
            }
        }



        private string GetNomUtilisateur(SqlConnection conn, int userID)
        {
            using (SqlCommand command = new SqlCommand("SELECT Username FROM Users WHERE UserID = @UserID", conn))
            {
                command.Parameters.AddWithValue("@UserID", userID);
                object result = command.ExecuteScalar();
                return result != null ? result.ToString() : string.Empty;
            }
        }





        private void button10_Click(object sender, EventArgs e) {

            DialogResult result = MessageBox.Show("Voulez-vous vraiment vous déconnecter ?", "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Fermer le formulaire actuel (MainForm)
               // this.Hide();
                // Afficher à nouveau le formulaire de connexion
                //  LoginForm loginForm = new LoginForm();
                //  loginForm.Show();

                this.Close();
            }

        }

        private void btnAjtProjet_Click(object sender, EventArgs e)
        {
            contextMenuAdd.Show(btnAdd, new Point(0, btnAdd.Height));
        }

        private void ajouterUneTacheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AjouterTache().ShowDialog();
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ajouterUnMembreToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new AjouterMembreForm().ShowDialog();
        }

        private void ajouterUnChefDéquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AjouterChefEquipeForm().ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnEdit, new Point(0, btnEdit.Height));
        }

        private void modifierUneTacheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ModifierTache().ShowDialog();
        }

        private void modifierUnMembreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ModifierMembreForm().ShowDialog();
        }

        private void modifierUneÉquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ModifierEquipeForm().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(btnEdit, new Point(0, btnEdit.Height));
        }

        private void supprimerUneTacheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SupprimerTacheForm().ShowDialog();
        }

        private void supprimerUnMembreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SupprimerMembre().ShowDialog();
        }

        private void supprimerUneÉquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SupprimerEquipe().ShowDialog();
        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private ModifierEquipeForm ModifierEquipeForm = null;
        private ModifierMembreForm ModifierMembreForm = null;
        private ModifierTache ModifierTache = null;
        private SupprimerEquipe SupprimerEquipe = null;
        private SupprimerMembre SupprimerMembre = null;
        private SupprimerTacheForm SupprimerTacheForm = null;

        private bool isProcessingClick = false;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignorer les clics sur les en-têtes
            if (e.RowIndex < 0) return;

            var senderGrid = (DataGridView)sender;
            var columnName = senderGrid.Columns[e.ColumnIndex].Name;

            // Vérifier si c'est un clic sur un bouton
            if (columnName != "Modifier" && columnName != "Supprimer") return;

            // Empêcher le double traitement
            if (isProcessingClick) return;
            isProcessingClick = true;

            try
            {
                // Terminer toute édition en cours
                senderGrid.EndEdit();

                // Détection du clic sur le bouton "Modifier"
                if (columnName == "Modifier")
                {
                    if (dataGridView1.Columns.Contains("TeamName")) // Vue globale
                    {
                        string nomEquipe = dataGridView1.Rows[e.RowIndex].Cells["TeamName"].Value?.ToString();
                        if (!string.IsNullOrEmpty(nomEquipe))
                        {
                            int idEquipe = GetTeamIdByName(nomEquipe);
                            if (idEquipe > 0)
                            {
                                if (ModifierEquipeForm == null || ModifierEquipeForm.IsDisposed)
                                {
                                    ModifierEquipeForm = new ModifierEquipeForm();
                                    ModifierEquipeForm.SetEquipeInfo(idEquipe, nomEquipe);
                                    ModifierEquipeForm.FormClosed += (s, args) => {
                                        ModifierEquipeForm = null;
                                        ChargerTreeView(); // Rafraîchir après fermeture
                                    };
                                    ModifierEquipeForm.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show("L'interface de modification de l'équipe est déjà ouverte.");
                                }
                            }
                        }
                    }
                    else if (dataGridView1.Columns.Contains("NomTache")) // Vue détaillée
                    {
                        string nomTache = dataGridView1.Rows[e.RowIndex].Cells["NomTache"].Value?.ToString();
                        string nomMembre = dataGridView1.Rows[e.RowIndex].Cells["MembreEquipe"].Value?.ToString();

                        if (!string.IsNullOrWhiteSpace(nomMembre) && nomMembre != "Non assigné")
                        {
                            int idMembre = GetUserIdByName(nomMembre);
                            if (idMembre > 0)
                            {
                                if (ModifierMembreForm == null || ModifierMembreForm.IsDisposed)
                                {
                                    ModifierMembreForm = new ModifierMembreForm();
                                    ModifierMembreForm.SetMembreInfo(idMembre, nomMembre);
                                    ModifierMembreForm.FormClosed += (s, args) => {
                                        ModifierMembreForm = null;
                                        ChargerTreeView(); // Rafraîchir après fermeture
                                    };
                                    ModifierMembreForm.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show("L'interface de modification du membre est déjà ouverte.");
                                }
                            }
                        }

                        if (!string.IsNullOrEmpty(nomTache))
                        {
                            int idTache = GetTaskIdByName(nomTache);
                            if (idTache > 0)
                            {
                                if (ModifierTache == null || ModifierTache.IsDisposed)
                                {
                                    ModifierTache = new ModifierTache();
                                    ModifierTache.SetTacheInfo(idTache, nomTache);
                                    ModifierTache.FormClosed += (s, args) => {
                                        ModifierTache = null;
                                        ChargerTreeView(); // Rafraîchir après fermeture
                                    };
                                    ModifierTache.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show("L'interface de modification de la tâche est déjà ouverte.");
                                }
                            }
                        }
                    }
                }
                // Détection du clic sur le bouton "Supprimer"
                else if (columnName == "Supprimer")
                {
                    if (dataGridView1.Columns.Contains("TeamName")) // Vue globale
                    {
                        string nomEquipe = dataGridView1.Rows[e.RowIndex].Cells["TeamName"].Value?.ToString();
                        if (!string.IsNullOrEmpty(nomEquipe))
                        {
                            int idEquipe = GetTeamIdByName(nomEquipe);
                            if (idEquipe > 0)
                            {
                                if (SupprimerEquipe == null || SupprimerEquipe.IsDisposed)
                                {
                                    SupprimerEquipe = new SupprimerEquipe();
                                    SupprimerEquipe.SetEquipeInfo(idEquipe, nomEquipe);
                                    SupprimerEquipe.FormClosed += (s, args) => {
                                        SupprimerEquipe = null;
                                        ChargerTreeView(); // Rafraîchir après fermeture
                                    };
                                    SupprimerEquipe.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show("L'interface de suppression de l'équipe est déjà ouverte.");
                                }
                            }
                        }
                    }
                    else if (dataGridView1.Columns.Contains("NomTache")) // Vue détaillée
                    {
                        string nomTache = dataGridView1.Rows[e.RowIndex].Cells["NomTache"].Value?.ToString();
                        string nomMembre = dataGridView1.Rows[e.RowIndex].Cells["MembreEquipe"].Value?.ToString();

                        if (!string.IsNullOrWhiteSpace(nomMembre) && nomMembre != "Non assigné")
                        {
                            int idMembre = GetUserIdByName(nomMembre);
                            if (idMembre > 0)
                            {
                                if (SupprimerMembre == null || SupprimerMembre.IsDisposed)
                                {
                                    SupprimerMembre = new SupprimerMembre();
                                    SupprimerMembre.SetMembreInfo(idMembre, nomMembre);
                                    SupprimerMembre.FormClosed += (s, args) => {
                                        SupprimerMembre = null;
                                        ChargerTreeView(); // Rafraîchir après fermeture
                                    };
                                    SupprimerMembre.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show("L'interface de suppression du membre est déjà ouverte.");
                                }
                            }
                        }

                        if (!string.IsNullOrEmpty(nomTache))
                        {
                            int idTache = GetTaskIdByName(nomTache);
                            if (idTache > 0)
                            {
                                if (SupprimerTacheForm == null || SupprimerTacheForm.IsDisposed)
                                {
                                    SupprimerTacheForm = new SupprimerTacheForm();
                                    SupprimerTacheForm.SetTacheInfo(idTache, nomTache);
                                    SupprimerTacheForm.FormClosed += (s, args) => {
                                        SupprimerTacheForm = null;
                                        ChargerTreeView(); // Rafraîchir après fermeture
                                    };
                                    SupprimerTacheForm.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show("L'interface de suppression de la tâche est déjà ouverte.");
                                }
                            }
                        }
                    }
                }
            }
            finally
            {
                isProcessingClick = false;
            }
        }







        private int GetTaskIdByName(string taskName)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT TaskID FROM Tasks WHERE Title = @Title", con);
                cmd.Parameters.AddWithValue("@Title", taskName);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        private int GetUserIdByName(string userName)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT UserID FROM Users WHERE Username = @Username", con);
                cmd.Parameters.AddWithValue("@Username", userName);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        private int GetTeamIdByName(string teamName)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT TeamID FROM Teams WHERE Name = @Name", con);
                cmd.Parameters.AddWithValue("@Name", teamName);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TacheStatistiquesForm statForm = new TacheStatistiquesForm();
            statForm.ShowDialog() ;
        }

        private void MettreAJourProgressionGlobale()
        {
           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Nombre total de tâches
                string queryTotal = "SELECT COUNT(*) FROM Tasks";
                SqlCommand cmdTotal = new SqlCommand(queryTotal, connection);
                int totalTaches = (int)cmdTotal.ExecuteScalar();

                // Nombre de tâches terminées
                string queryTerminees = "SELECT COUNT(*) FROM Tasks WHERE Status = 'Terminée'";
                SqlCommand cmdTerminees = new SqlCommand(queryTerminees, connection);
                int tachesTerminees = (int)cmdTerminees.ExecuteScalar();

                if (totalTaches > 0)
                {
                    int pourcentage = (int)((double)tachesTerminees / totalTaches * 100);
                    progressBarGlobal.Value = pourcentage;
                    labelPourcentageGlobal.Text = $"Progression globale des taches : {pourcentage}%";
                }
                else
                {
                    progressBarGlobal.Value = 0;
                    labelPourcentageGlobal.Text = "Aucune tâche créée";
                }
            }
        }

        private void AjouterColonnesBoutons()
        {
            // Colonne Modifier
            DataGridViewButtonColumn btnModifier = new DataGridViewButtonColumn();
            btnModifier.Name = "Modifier";
            btnModifier.Text = "Modifier";
            btnModifier.UseColumnTextForButtonValue = true;
            btnModifier.Width = 80;
            btnModifier.DefaultCellStyle.BackColor = Color.LightBlue;

            // Colonne Supprimer
            DataGridViewButtonColumn btnSupprimer = new DataGridViewButtonColumn();
            btnSupprimer.Name = "Supprimer";
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseColumnTextForButtonValue = true;
            btnSupprimer.Width = 80;
            btnSupprimer.DefaultCellStyle.BackColor = Color.LightCoral;

            // Ajouter les colonnes seulement si elles n'existent pas déjà
            if (!dataGridView1.Columns.Contains("Modifier"))
                dataGridView1.Columns.Add(btnModifier);

            if (!dataGridView1.Columns.Contains("Supprimer"))
                dataGridView1.Columns.Add(btnSupprimer);
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Vérification de l'existence des colonnes "Modifier" et "Supprimer"
                var modifierColumn = dataGridView1.Columns["Modifier"];
                var supprimerColumn = dataGridView1.Columns["Supprimer"];

                if (modifierColumn != null && e.ColumnIndex == modifierColumn.Index ||
                    supprimerColumn != null && e.ColumnIndex == supprimerColumn.Index)
                {
                    dataGridView1.Cursor = Cursors.Hand;
                }
            }
        }


        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Cursor = Cursors.Default;
            }
        }


        private string DetermineObjetARemplacer(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= dataGridView1.Rows.Count)
                return "Inconnu";

            // Vue "Détails d'une équipe"
            if (dataGridView1.Columns.Contains("NomTache") &&
                dataGridView1.Rows[rowIndex].Cells["NomTache"].Value != null)
            {
                return "Tâche";
            }
            else if (dataGridView1.Columns.Contains("MembreEquipe") &&
                     dataGridView1.Rows[rowIndex].Cells["MembreEquipe"].Value != null)
            {
                // Si c'est le chef d'équipe
                if (dataGridView1.Columns.Contains("ChefEquipe") &&
                    dataGridView1.Rows[rowIndex].Cells["MembreEquipe"].Value.ToString() ==
                    dataGridView1.Rows[rowIndex].Cells["ChefEquipe"].Value.ToString())
                {
                    return "Chef";
                }
                return "Membre";
            }
            // Vue "Liste globale"
            else if (dataGridView1.Columns.Contains("LeaderName") &&
                     dataGridView1.Rows[rowIndex].Cells["LeaderName"].Value != null)
            {
                return "Chef";
            }

            return "Inconnu";
        }

        private void StyliserBoutonsDataGridView()
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column is DataGridViewButtonColumn)
                {
                    column.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    if (column.Name == "Modifier")
                        column.DefaultCellStyle.BackColor = Color.LightBlue;
                    else if (column.Name == "Supprimer")
                        column.DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExportProjetReportForm exportForm = new ExportProjetReportForm();

            // Option 1: Afficher comme fenêtre modale (bloque la fenêtre parent)
            DialogResult result = exportForm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupération des données
                var members = GetAllTeamMembers();
                var tasks = GetAllTasks();

                if (members == null || !members.Any())
                {
                    MessageBox.Show("Aucun membre d'équipe trouvé.", "Information",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (tasks == null || !tasks.Any())
                {
                    MessageBox.Show("Aucune tâche trouvée.", "Information",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Affichage du formulaire
                using (var whatsAppForm = new WhatsAppForm(members, tasks))
                {
                    whatsAppForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ouverture de l'interface WhatsApp: {ex.Message}",
                              "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
        private List<TeamMember> GetAllTeamMembers()
        {
            List<TeamMember> members = new List<TeamMember>();
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT Username, Phone, Email FROM Users WHERE Role = 'Membre'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    members.Add(new TeamMember
                    {
                        Name = reader["Username"].ToString(),
                        PhoneNumber = reader["Phone"].ToString(),
                        Email = reader["Email"].ToString()
                    });
                }
            }
            return members;
        }

        private List<ProjectTask> GetAllTasks()
        {
            var taskList = new List<ProjectTask>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT u.Username AS AssignedTo,
                        t.Title AS TaskName,
                        t.DueDate,
                        t.Status
                        FROM Tasks t
                        JOIN Task_Assignments ta ON ta.TaskID = t.TaskID
                        JOIN Users u ON u.UserID = ta.UserID";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Gestion des valeurs NULL
                        string taskName = reader["TaskName"] != DBNull.Value ? reader["TaskName"].ToString() : string.Empty;
                        string assignedTo = reader["AssignedTo"] != DBNull.Value ? reader["AssignedTo"].ToString() : string.Empty;
                        DateTime dueDate = reader["DueDate"] != DBNull.Value ? Convert.ToDateTime(reader["DueDate"]) : DateTime.MinValue;
                        string status = reader["Status"] != DBNull.Value ? reader["Status"].ToString() : "En attente";

                        taskList.Add(new ProjectTask
                        {
                            Name = taskName,
                            AssignedTo = assignedTo,
                            DueDate = dueDate,
                            Status = WhatsAppForm.ParseTaskStatusFromString(status)
                        });
                    }
                }
            }
            return taskList;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AlertForm alertForm = new AlertForm();
            alertForm.ShowDialog();
        }
    }
}


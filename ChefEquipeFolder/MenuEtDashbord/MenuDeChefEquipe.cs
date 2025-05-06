using FatiIkhlassYoun.ChefEquipeFolder.hautePanel;
using FatiIkhlassYoun.NewFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FatiIkhlassYoun
{
    public partial class MenuDeChefEquipe : Form
    {
        public MenuDeChefEquipe()
        {
            InitializeComponent();
            this.Load += MenuDeChefEquipe_Load;
            LoadContent(new DashboardControl()); // Charger le contenu par défaut
            RemplirInfosUtilisateur(); // Remplir les infos de l'utilisateur après le chargement du formulaire

        }
        private TreeView treeViewMenu;
        private void MenuDeChefEquipe_Load(object sender, EventArgs e)
        {
            treeViewMenu = new TreeView();
            treeViewMenu.Dock = DockStyle.Fill;
            panelGauche.Controls.Add(treeViewMenu);
            RemplirTreeViewProjetEtEquipes();
        }
        private void RemplirTreeViewProjetEtEquipes()
        {
            int userId = SessionUtilisateur.UserID;
            string connectionString = @"Data Source=YOUNES\SQLEXPRESS;Initial Catalog=ProjectManagementSystem;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1. Récupérer d'abord tous les projets dans une liste
                List<(int ProjectId, string ProjectTitle)> projets = new List<(int, string)>();
                string queryProjet = "SELECT ProjectID, Title FROM Projects WHERE ManagerID = @UserID";

                using (SqlCommand cmdProjet = new SqlCommand(queryProjet, conn))
                {
                    cmdProjet.Parameters.AddWithValue("@UserID", userId);

                    using (SqlDataReader readerProjet = cmdProjet.ExecuteReader())
                    {
                        while (readerProjet.Read())
                        {
                            projets.Add((readerProjet.GetInt32(0), readerProjet.GetString(1)));
                        }
                    } // Le reader est fermé ici
                }

                if (projets.Count == 0)
                {
                    treeViewMenu.Nodes.Add("Aucun projet assigné");
                    return;
                }

                // 2. Pour chaque projet, récupérer les membres et les tâches
                foreach (var projet in projets)
                {
                    TreeNode projectNode = new TreeNode(projet.ProjectTitle);

                    // --- Membres de l'équipe ---
                    TreeNode membresNode = new TreeNode("Membres d'équipe");
                    List<string> membres = new List<string>();

                    string queryMembres = @"SELECT U.Username
                                  FROM Users U
                                  INNER JOIN TeamMembers TM ON U.UserID = TM.UserID
                                  INNER JOIN Teams T ON T.TeamID = TM.TeamID
                                  WHERE T.LeaderID = @UserID";

                    using (SqlCommand cmdMembres = new SqlCommand(queryMembres, conn))
                    {
                        cmdMembres.Parameters.AddWithValue("@UserID", userId);

                        using (SqlDataReader readerMembres = cmdMembres.ExecuteReader())
                        {
                            while (readerMembres.Read())
                            {
                                membres.Add(readerMembres.GetString(0));
                            }
                        } // Le reader est fermé ici
                    }

                    if (membres.Count > 0)
                    {
                        foreach (var membre in membres)
                        {
                            membresNode.Nodes.Add(membre);
                        }
                    }
                    else
                    {
                        membresNode.Nodes.Add("Vide");
                    }

                    // --- Tâches du projet ---
                    TreeNode tachesNode = new TreeNode("Tâches");
                    List<string> taches = new List<string>();

                    string queryTaches = "SELECT Title FROM Tasks WHERE ProjectID = @ProjectID";

                    using (SqlCommand cmdTaches = new SqlCommand(queryTaches, conn))
                    {
                        cmdTaches.Parameters.AddWithValue("@ProjectID", projet.ProjectId);

                        using (SqlDataReader readerTaches = cmdTaches.ExecuteReader())
                        {
                            while (readerTaches.Read())
                            {
                                taches.Add(readerTaches.GetString(0));
                            }
                        } // Le reader est fermé ici
                    }

                    if (taches.Count > 0)
                    {
                        foreach (var tache in taches)
                        {
                            tachesNode.Nodes.Add(tache);
                        }
                    }
                    else
                    {
                        tachesNode.Nodes.Add("Vide");
                    }

                    // Ajouter les sous-noeuds au projet
                    projectNode.Nodes.Add(membresNode);
                    projectNode.Nodes.Add(tachesNode);

                    // Ajouter le projet au TreeView
                    treeViewMenu.Nodes.Add(projectNode);
                }
            }
        }

        public void RefreshTreeView()
        {
            treeViewMenu.Nodes.Clear(); // Vider le TreeView actuel
            RemplirTreeViewProjetEtEquipes(); // Le recharger
        }

        private void RemplirInfosUtilisateur()
        {
            // Exemple : supposons que tu as un UserID dans la session utilisateur
            int userID = SessionUtilisateur.UserID;  // Ou récupère l'ID de l'utilisateur connecté

            // Requête SQL pour récupérer le nom d'utilisateur et le rôle de l'utilisateur
            string query = "SELECT Username, Role FROM Users WHERE UserID = @UserID";

            // Connexion à la base de données
            using (SqlConnection conn = new SqlConnection(@"Data Source=YOUNES\SQLEXPRESS;Initial Catalog=ProjectManagementSystem;Integrated Security=True;"))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userID);

                // Exécution de la requête et récupération des données
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string username = reader.GetString(0);  // Récupère le nom d'utilisateur
                    string role = reader.GetString(1);      // Récupère le rôle

                    // Vérification si le nom d'utilisateur contient un espace
                    if (username.Contains(" "))
                    {
                        // Si oui, on divise le nom et le prénom
                        string[] usernameParts = username.Split(' ');
                        labelNom.Text = usernameParts[0].ToUpper();  // Premier élément comme nom
                        labelPrenom.Text = usernameParts[1];         // Deuxième élément comme prénom
                    }
                    else
                    {
                        // Sinon, on affiche uniquement le nom et on laisse le prénom vide
                        labelNom.Text = username.ToUpper();  // Afficher tout le username comme nom
                        labelPrenom.Text = "";              // Laisser le prénom vide
                    }

                    // Afficher le rôle dans le labelRole
                    labelRole.Text = "(" + role.Replace('_', ' ') + ")";
                }
                else
                {
                    MessageBox.Show("Utilisateur non trouvé");
                }
            }
        }
        public void LoadContent(UserControl control)
        {
            panelContenu.Controls.Clear();       // Vider le contenu précédent
            control.Dock = DockStyle.Fill;       // Prendre toute la place
            panelContenu.Controls.Add(control);  // Afficher le nouveau contenu
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }


        private void cuiButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (AjouterTache form = new AjouterTache(SessionUtilisateur.UserID))
                {
                    // Abonnement à l'événement avant d'afficher le formulaire
                    form.TaskAdded += (s, args) =>
                    {
                        // Rafraîchir le TreeView sur le thread UI
                        this.Invoke((MethodInvoker)delegate
                        {
                            RefreshTreeView();
                        });
                    };

                    var result = form.ShowDialog();

                    // Vous pouvez vérifier le résultat si nécessaire
                    if (result == DialogResult.OK)
                    {
                        // Action supplémentaire si besoin
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }




        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cuiButton5_Click(object sender, EventArgs e)
        {
            LoadContent(new DashboardControl());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadContent(new MesEquipesControl());

        }



        private void button3_Click(object sender, EventArgs e)
        {
            LoadContent(new SuiviAvancementControl());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadContent(new CalendrierControl());

        }

        private void panelContenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelDernieresTaches_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExporterTaches_Click(object sender, EventArgs e)
        {
            ExporterTachesForm form = new ExporterTachesForm();
            form.ShowDialog();
        }


        private void panelGauche_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadContent(new MembresEquipeControl());
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            LoadContent(new CalendrierControl());
        }

        private void btnWhatsapp_Click(object sender, EventArgs e)
        {
            WhatsAppMessageForm form = new WhatsAppMessageForm(SessionUtilisateur.UserID);
            form.ShowDialog();
        }

        private void btnAlert_Click(object sender, EventArgs e)
        {
            var alertControl = new AlertControl();

            // Abonnement à l'événement
            alertControl.OnTaskSelected += (taskId) =>
            {
                // Charger le dashboard
                var dashboard = new DashboardControl();
                LoadContent(dashboard);

                // Sélectionner la tâche après un petit délai pour laisser le temps au contrôle de se charger
                this.BeginInvoke((MethodInvoker)delegate
                {
                    dashboard.SelectTaskInGrid(taskId);
                });
            };

            LoadContent(alertControl);
        }

        private void cuiButtonADD_Click(object sender, EventArgs e)
        {
            try
            {
                using (AjouterTache form = new AjouterTache(SessionUtilisateur.UserID))
                {
                    // Abonnement à l'événement avant d'afficher le formulaire
                    form.TaskAdded += (s, args) =>
                    {
                        // Rafraîchir le TreeView sur le thread UI
                        this.Invoke((MethodInvoker)delegate
                        {
                            RefreshTreeView();
                        });
                    };

                    var result = form.ShowDialog();

                    // Vous pouvez vérifier le résultat si nécessaire
                    if (result == DialogResult.OK)
                    {
                        // Action supplémentaire si besoin
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnModifierTache_Click(object sender, EventArgs e)
        {

        }
    }
}

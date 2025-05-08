using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using FatiIkhlassYoun.ChefEquipeFolder.hautePanel;
namespace FatiIkhlassYoun.membreFolder
{
    public partial class MenudeMembre : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementSystem"].ConnectionString;

        public MenudeMembre()
        {
            InitializeComponent();
            InitializeTreeView();
            RemplirInfosUtilisateur();
            LoadMemberTasks();
            LoadContent(new ctrlMembre());

        }

        private void InitializeTreeView()
        {
            treeViewMenu = new TreeView();
            treeViewMenu.Dock = DockStyle.Fill;
            treeViewMenu.Font = new Font("Segoe UI", 10);
            panelGauche.Controls.Add(treeViewMenu);
        }

        private void LoadMemberTasks()
        {
            treeViewMenu.Nodes.Clear();
            int memberId = SessionUtilisateur.UserID;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Requête optimisée pour les membres
                    string query = @"
                SELECT DISTINCT
                    p.ProjectID, 
                    p.Title AS ProjectTitle,
                    t.TeamID,
                    t.Name AS TeamName,
                    ts.TaskID, 
                    ts.Title AS TaskTitle, 
                    ts.Status,
                    ts.DueDate
                FROM Task_Assignments ta
                JOIN Tasks ts ON ta.TaskID = ts.TaskID
                JOIN Projects p ON ts.ProjectID = p.ProjectID
                LEFT JOIN Teams t ON ts.TeamLeadID = t.LeaderID
                WHERE ta.UserID = @MemberID
                ORDER BY p.Title, t.Name, ts.DueDate";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MemberID", memberId);

                    Dictionary<int, TreeNode> projectNodes = new Dictionary<int, TreeNode>();
                    Dictionary<string, TreeNode> teamNodes = new Dictionary<string, TreeNode>();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            treeViewMenu.Nodes.Add("Aucune tâche assignée");
                            return;
                        }

                        while (reader.Read())
                        {
                            int projectId = reader.GetInt32(0);
                            string projectTitle = reader.GetString(1);
                            int teamId = reader.IsDBNull(2) ? -1 : reader.GetInt32(2);
                            string teamName = reader.IsDBNull(3) ? "Tâches sans équipe" : reader.GetString(3);
                            int taskId = reader.GetInt32(4);
                            string taskTitle = reader.GetString(5);
                            string taskStatus = reader.GetString(6);
                            DateTime dueDate = reader.GetDateTime(7);

                            // Gestion des projets
                            if (!projectNodes.ContainsKey(projectId))
                            {
                                TreeNode projectNode = new TreeNode($"📁 {projectTitle}")
                                {
                                    Tag = $"Project|{projectId}",
                                    NodeFont = new Font("Segoe UI", 10, FontStyle.Bold)
                                };
                                projectNodes.Add(projectId, projectNode);
                                treeViewMenu.Nodes.Add(projectNode);
                            }

                            // Gestion des équipes
                            string teamKey = $"{projectId}_{teamId}";
                            if (!teamNodes.ContainsKey(teamKey))
                            {
                                TreeNode teamNode = new TreeNode($"👥 {teamName}")
                                {
                                    Tag = $"Team|{teamId}",
                                    NodeFont = new Font("Segoe UI", 9, FontStyle.Italic)
                                };
                                teamNodes.Add(teamKey, teamNode);
                                projectNodes[projectId].Nodes.Add(teamNode);
                            }

                            // Ajout des tâches avec date d'échéance
                            string statusIcon = taskStatus == "Terminée" ? "✅" : "🟡";
                            string dueText = dueDate < DateTime.Now ? "⚠ En retard" : dueDate.ToString("dd/MM");
                            TreeNode taskNode = new TreeNode($"{statusIcon} {taskTitle} ({dueText})")
                            {
                                Tag = $"Task|{taskId}",
                                ForeColor = dueDate < DateTime.Now ? Color.Red : Color.Black
                            };
                            teamNodes[teamKey].Nodes.Add(taskNode);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des tâches: {ex.Message}", "Erreur",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void DisplayTaskDetails(int taskId)
        {
            // Implémentez cette méthode pour afficher les détails de la tâche
            // dans votre panneau de contenu principal
        }

        private void DisplayTeamDetails(int teamId)
        {
            // Implémentez cette méthode si nécessaire
        }

        private void DisplayProjectDetails(int projectId)
        {
            // Implémentez cette méthode si nécessaire
        }
        private void RemplirInfosUtilisateur()
        {
            // Exemple : supposons que tu as un UserID dans la session utilisateur
            int userID = SessionUtilisateur.UserID;  // Ou récupère l'ID de l'utilisateur connecté

            // Requête SQL pour récupérer le nom d'utilisateur et le rôle de l'utilisateur
            string query = "SELECT Username, Role FROM Users WHERE UserID = @UserID";

            // Connexion à la base de données
            using (SqlConnection conn = new SqlConnection(connectionString))
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
        private void labelNom_Click(object sender, EventArgs e)
        {

        }

        private void panelGauche_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LoadContent(UserControl userControl)
        {
            // Vider le panel avant d'ajouter un nouveau contrôle
            panelContenu.Controls.Clear();

            // Configurer le contrôle
            userControl.Dock = DockStyle.Fill;

            // Ajouter le contrôle au panel
            panelContenu.Controls.Add(userControl);
        }
        private void cuiButton5_Click(object sender, EventArgs e)
        {
            // Créez une instance du contrôle
            ctrlMembre membreControl = new ctrlMembre();

            // Chargez le contrôle dans le panelContenu
            LoadContent(membreControl);
        }

        private void btnModifierTache_Click(object sender, EventArgs e)
        {
            formModfTacheMembre form = new formModfTacheMembre(SessionUtilisateur.UserID);
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Créez une instance du contrôle des membres d'équipe
            ctrlMbrMembresequipes membresEquipesControl = new ctrlMbrMembresequipes();

            // Chargez le contrôle dans le panelContenu
            LoadContent(membresEquipesControl);
        }

        private void btnExporterTaches_Click(object sender, EventArgs e)
        {
            FormMbrExporter formExport = new FormMbrExporter(SessionUtilisateur.UserID);
            formExport.ShowDialog();

        }
    }
}

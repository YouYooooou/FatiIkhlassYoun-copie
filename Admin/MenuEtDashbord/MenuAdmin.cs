using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Rectangle = System.Drawing.Rectangle;
using Font = System.Drawing.Font;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Configuration;
using FatiIkhlassYoun.ChefEquipeFolder.hautePanel;
using ProjectManagementSystem;

namespace FatiIkhlassYoun
{
    public partial class MenuAdmin : Form
    {
        // Déclaration des variables
        private object favorites;
        private object treeViewMenu;
        private object filters;
        private Document document1;
        private string fileName;
        private int selectedId;
        private string currentViewType;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private ComboBox cmbRole;
        private CheckBox chkIsActive;
        private TextBox txtPhone;
        private string connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementSystem"].ConnectionString;
        private object dgvTasks;

        public string Title { get; private set; }
        public string ProjectID { get; private set; }

        public MenuAdmin()
        {
            InitializeComponent();
            InitializeControls();
            UpdateTreeView();
            LoadInitialData();
            RemplirInfosUtilisateur();
        }

        private void InitializeControls()
        {
            // Initialisation des contrôles
            txtPassword = new TextBox
            {
                Name = "txtPassword",
                Text = "",
                Location = new Point(10, 10),
                Size = new Size(200, 30)
            };
            this.Controls.Add(txtPassword);
        }

        #region Gestion des Événements de Base
        private void MenuDeApp_Load(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void button1_Click_1(object sender, EventArgs e) { }
        private void cuiDataGridView1_Click(object sender, EventArgs e) { }
        private void panelsup2_Paint(object sender, PaintEventArgs e) { }
        private void panelSup_Paint(object sender, PaintEventArgs e) { }
        private void panel1_Paint_1(object sender, PaintEventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void toolStripComboBox1_Click(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
        #endregion

        #region Gestion des Boutons
        private void cuiButtonADD_Click(object sender, EventArgs e)
        {
            contextMenuAdd.Show(cuiButtonADD, new Point(0, cuiButtonADD.Height));
        }

        private void cuiButtonEdit_Click(object sender, EventArgs e)
        {
            contextMenuEdit.Show(cuiButtonEdit, new Point(cuiButtonEdit.Width, 0));
        }


        private void cuiButtonReport_Click(object sender, EventArgs e)
        {
            ReportGeneratorForm reportForm = new ReportGeneratorForm();
            reportForm.ShowDialog(); // Utilisez ShowDialog() pour un formulaire modal
        }


        private void cuiButtonWtsp_Click(object sender, EventArgs e)
        {
            try
            {
                // Créer et afficher le formulaire WhatsApp
                using (WhatsAppForm whatsappForm = new WhatsAppForm())
                {
                    // Définir le propriétaire du formulaire pour le centrer correctement
                    whatsappForm.StartPosition = FormStartPosition.CenterParent;

                    // Afficher le formulaire comme une boîte de dialogue modale
                    DialogResult result = whatsappForm.ShowDialog(this); // 'this' référence le formulaire parent

                    // Vérifier le résultat après la fermeture du formulaire
                    if (result == DialogResult.OK)
                    {
                        // Journaliser l'action
                        LogAction("WhatsApp messages sent via admin dashboard");

                        // Afficher une confirmation à l'utilisateur
                        ShowNotification("Messages WhatsApp envoyés avec succès", NotificationType.Success);
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        // Journaliser l'annulation
                        LogAction("WhatsApp message sending cancelled");
                    }
                }
            }
            catch (Exception ex)
            {
                // Gérer les erreurs et afficher un message à l'utilisateur
                MessageBox.Show(this,
                    $"Une erreur est survenue lors de l'ouverture du formulaire WhatsApp :\n{ex.Message}",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                LogError("Failed to open WhatsApp form", ex);
            }
        }

        // Méthodes helper (à ajouter à votre classe)
        private void LogAction(string action)
        {
            // Implémentez votre logique de journalisation ici
            // Exemple : enregistrement dans une base de données ou un fichier log
            Console.WriteLine($"[{DateTime.Now}] ACTION: {action}");
        }

        private void LogError(string message, Exception ex)
        {
            // Implémentez votre logique de journalisation d'erreur ici
            Console.WriteLine($"[{DateTime.Now}] ERROR: {message}\n{ex}");
        }

        private void ShowNotification(string message, NotificationType type)
        {
            // Implémentez votre système de notification personnalisé ici
            // Pour l'instant, nous utilisons MessageBox comme solution de base
            MessageBoxIcon icon = type == NotificationType.Success ? MessageBoxIcon.Information : MessageBoxIcon.Warning;
            MessageBox.Show(this, message, "Notification", MessageBoxButtons.OK, icon);
        }

        public enum NotificationType
        {
            Success,
            Warning,
            Error
        }
        #endregion

        #region Gestion des Menus Contextuels
        private void contextMenuAdd_Opening(object sender, CancelEventArgs e) { }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Récupérez l'ID de l'admin connecté depuis la session
            int adminId = SessionUtilisateur.UserID;

            // Créez et affichez le formulaire modalement
            using (FormAddEmployee form = new FormAddEmployee(adminId))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshCurrentView();
                }
            }
        }

        private void addTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddTeam form = new FormAddTeam();
            form.Show();
            form.FormClosed += (s, args) => RefreshCurrentView();
        }

        private void AddProjettoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddProject formAddProject = new FormAddProject();
            formAddProject.Show();
            formAddProject.FormClosed += (s, args) => RefreshCurrentView();
        }

        private void AddTasktoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddTask formAddTask = new FormAddTask();
            formAddTask.Show();
            formAddTask.FormClosed += (s, args) => RefreshCurrentView();
        }

        private void contextMenuEdit_Opening(object sender, CancelEventArgs e) { }

        private void editTeamInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int teamId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["TeamID"].Value);
                FormEditTeam form = new FormEditTeam(teamId);
                form.Show();
                form.FormClosed += (s, args) => RefreshCurrentView();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une équipe à modifier",
                              "Aucune sélection",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
            }
        }

        private void editTaskInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Vérifier qu'une ligne est sélectionnée
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une tâche à modifier",
                              "Aucune sélection",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            // Vérifier que la colonne TaskID existe
            if (!dataGridView.Columns.Contains("TaskID"))
            {
                MessageBox.Show("La colonne TaskID est introuvable dans la vue",
                              "Erreur de configuration",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Récupérer l'ID de la tâche
                var selectedRow = dataGridView.SelectedRows[0];
                var taskIdCell = selectedRow.Cells["TaskID"];

                if (taskIdCell.Value == null || taskIdCell.Value == DBNull.Value)
                {
                    MessageBox.Show("L'ID de la tâche est invalide",
                                  "Donnée corrompue",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                    return;
                }

                int taskId = Convert.ToInt32(taskIdCell.Value);

                // Ouvrir le formulaire d'édition
                FormEditTask form = new FormEditTask(taskId);
                form.Show();
                form.FormClosed += (s, args) => RefreshCurrentView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ouverture de l'éditeur : {ex.Message}",
                              "Erreur",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Fonctions de Gestion des Données
        private void LoadInitialData()
        {
            LoadUsersData(connectionString);
        }

        private void RefreshCurrentView()
        {
            if (treeView.SelectedNode == null) return;

            try
            {
                switch (treeView.SelectedNode.Text)
                {
                    case "Employees":
                        LoadUsersData(connectionString);
                        break;
                    case "Teams":
                        LoadTeamsData(connectionString);
                        break;
                    case "Projets":
                        LoadProjectsData(connectionString);
                        break;
                    case "Tâches":
                        LoadTasksData(connectionString);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du rafraîchissement: {ex.Message}", "Erreur",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            string selectedNode = treeView.SelectedNode.Text;
            string query = string.Empty;

            if (selectedNode == "Projets")
            {
                query = "SELECT ProjectID, Title, Description, StartDate, EndDate, Status FROM Projects";
            }
            else if (selectedNode == "Tâches")
            {
                query = "SELECT TaskID, Title, Description, StartDate, DueDate, Status FROM Tasks";
            }
            else if (selectedNode == "Employees")
            {
                query = "SELECT UserID, Username, Email, Role, PhoneNumber FROM Users";
            }
            else if (selectedNode == "Groups")
            {
                query = "SELECT TeamID, Name, LeaderID FROM Teams";
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
                }
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Employees")
            {
                LoadUsersData(connectionString);
            }
            else if (e.Node.Text == "Teams")
            {
                LoadTeamsData(connectionString);
            }
            else if (e.Node.Text == "Projets")
            {
                LoadProjectsData(connectionString);
            }
            else if (e.Node.Text == "Tâches")
            {
                LoadTasksData(connectionString);
            }

            UpdateTreeView();
        }

        private void LoadUsersData(string connectionString)
        {
            string query = "SELECT UserID, Username, Email, Role, IsActive FROM Users";
            FillDataGridView(query, connectionString);
        }

        private void LoadTeamsData(string connectionString)
        {
            string query = @"SELECT t.TeamID, t.Name, u.Username AS LeaderName 
                            FROM Teams t
                            LEFT JOIN Users u ON t.LeaderID = u.UserID";
            FillDataGridView(query, connectionString);
        }

        private void LoadProjectsData(string connectionString)
        {
            string query = @"SELECT p.ProjectID, p.Title, p.Description, p.StartDate, p.EndDate, p.Status, 
                           u.Username AS ManagerName 
                           FROM Projects p
                           LEFT JOIN Users u ON p.ManagerID = u.UserID";
            FillDataGridView(query, connectionString);
        }

        private void LoadTasksData(string connectionString)
        {
            string query = @"SELECT t.TaskID, t.Title, t.Description, t.StartDate, t.DueDate, t.Status, 
                           p.Title AS ProjectName, u.Username AS TeamLeadName
                           FROM Tasks t
                           LEFT JOIN Projects p ON t.ProjectID = p.ProjectID
                           LEFT JOIN Users u ON t.TeamLeadID = u.UserID";
            FillDataGridView(query, connectionString);
        }

        private void FillDataGridView(string query, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView.DataSource = dt;

                    // Ajuster la largeur des colonnes automatiquement
                    dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des données: " + ex.Message);
                }
            }
        }

        private void UpdateTreeView()
        {
            // Récupérer les comptes depuis la base de données
            Dictionary<string, int> counts = GetDatabaseCounts();

            treeView.Nodes.Clear();

            TreeNode employees = new TreeNode("Employees");
            employees.Nodes.Add($"All ({counts["AllEmployees"]})");
            employees.Nodes.Add($"On leave ({counts["OnLeaveEmployees"]})");

            TreeNode projets = new TreeNode("Projets");
            projets.Nodes.Add($"En cours ({counts["ActiveProjects"]})");
            projets.Nodes.Add($"Terminés ({counts["CompletedProjects"]})");

            TreeNode groups = new TreeNode("Teams");
            groups.Nodes.Add($"Actives ({counts["ActiveTeams"]})");

            TreeNode taches = new TreeNode("Tâches");
            taches.Nodes.Add($"À faire ({counts["TodoTasks"]})");
            taches.Nodes.Add($"En cours ({counts["InProgressTasks"]})");
            taches.Nodes.Add($"Terminées ({counts["CompletedTasks"]})");

            treeView.Nodes.Add(employees);
            treeView.Nodes.Add(projets);
            treeView.Nodes.Add(groups);
            treeView.Nodes.Add(taches);

            treeView.ExpandAll();
        }

        private Dictionary<string, int> GetDatabaseCounts()
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Compter les employés
                string employeeQuery = @"SELECT 
                              COUNT(*) AS AllEmployees,
                              SUM(CASE WHEN IsActive = 0 THEN 1 ELSE 0 END) AS OnLeaveEmployees
                              FROM Users";

                using (SqlCommand cmd = new SqlCommand(employeeQuery, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            counts["AllEmployees"] = reader.GetInt32(0);
                            counts["OnLeaveEmployees"] = reader.GetInt32(1);
                        }
                    }
                }

                // Compter les projets (en utilisant les statuts de votre base)
                string projectQuery = @"SELECT 
                             SUM(CASE WHEN Status = 'En cours' THEN 1 ELSE 0 END) AS ActiveProjects,
                             SUM(CASE WHEN Status = 'Terminé' THEN 1 ELSE 0 END) AS CompletedProjects
                             FROM Projects";

                using (SqlCommand cmd = new SqlCommand(projectQuery, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            counts["ActiveProjects"] = reader.GetInt32(0);
                            counts["CompletedProjects"] = reader.GetInt32(1);
                        }
                    }
                }

                // Compter les équipes
                string teamQuery = "SELECT COUNT(*) FROM Teams";
                using (SqlCommand cmd = new SqlCommand(teamQuery, conn))
                {
                    counts["ActiveTeams"] = (int)cmd.ExecuteScalar();
                }

                // Compter les tâches (en utilisant les statuts de votre base)
                string taskQuery = @"SELECT 
                           SUM(CASE WHEN Status = 'En attente' THEN 1 ELSE 0 END) AS TodoTasks,
                           SUM(CASE WHEN Status = 'En cours' THEN 1 ELSE 0 END) AS InProgressTasks,
                           SUM(CASE WHEN Status = 'Terminée' THEN 1 ELSE 0 END) AS CompletedTasks
                           FROM Tasks";

                using (SqlCommand cmd = new SqlCommand(taskQuery, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            counts["TodoTasks"] = reader.GetInt32(0);
                            counts["InProgressTasks"] = reader.GetInt32(1);
                            counts["CompletedTasks"] = reader.GetInt32(2);
                        }
                    }
                }
            }

            return counts;
        }
        #endregion

        #region Fonctions de Rapport et Notification


        #endregion

        #region Fonctions d'Accès aux Données
        private List<Project> GetAllProjects()
        {
            List<Project> projects = new List<Project>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ProjectID, Title, Description, StartDate, EndDate, Status, ManagerID FROM Projects";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            projects.Add(new Project
                            {
                                ProjectID = reader.GetInt32(0),
                                Title = reader.GetString(1),
                                Description = reader.GetString(2),
                                StartDate = reader.GetDateTime(3),
                                EndDate = reader.GetDateTime(4),
                                Status = reader.GetString(5),
                                ManagerID = reader.GetInt32(6)
                            });
                        }
                    }
                }
            }

            return projects;
        }

        private dynamic GetProjectInfo(int projectId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Title, Description, StartDate, EndDate, Status FROM Projects WHERE ProjectID = @ProjectID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProjectID", projectId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new
                            {
                                Title = reader["Title"].ToString(),
                                Description = reader["Description"].ToString(),
                                StartDate = Convert.ToDateTime(reader["StartDate"]),
                                EndDate = Convert.ToDateTime(reader["EndDate"]),
                                Status = reader["Status"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        private List<dynamic> GetProjectTasks(int projectId)
        {
            var list = new List<dynamic>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Title, Status, DueDate FROM Tasks WHERE ProjectID = @ProjectID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProjectID", projectId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new
                            {
                                Title = reader["Title"].ToString(),
                                Status = reader["Status"].ToString(),
                                DueDate = Convert.ToDateTime(reader["DueDate"])
                            });
                        }
                    }
                }
            }
            return list;
        }

        private List<dynamic> GetProjectUsers(int projectId)
        {
            var list = new List<dynamic>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT u.Username, u.Email, u.Role
                    FROM Task_Assignments ta
                    JOIN Tasks t ON ta.TaskID = t.TaskID
                    JOIN Users u ON ta.UserID = u.UserID
                    WHERE t.ProjectID = @ProjectID
                    GROUP BY u.Username, u.Email, u.Role";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProjectID", projectId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new
                            {
                                Username = reader["Username"].ToString(),
                                Email = reader["Email"].ToString(),
                                Role = reader["Role"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }
        #endregion

        #region Classes Internes
        internal class FormDashboardProgress : Form
        {
            // Implémentation de la classe FormDashboardProgress
            public FormDashboardProgress()
            {
                this.Text = "Tableau de Bord de Progression";
                this.Size = new Size(800, 600);

                // Ajoutez ici les contrôles pour votre tableau de bord de progression
            }
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private class AddEmployeeControl : Control { }
        private class AddGroupControl : Control { }
        private class EditformControl : Control { }

        public class Project
        {
            public int ProjectID { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string Status { get; set; }
            public int ManagerID { get; set; }
        }
        #endregion

        private void editProjectInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Vérifier qu'une ligne est sélectionnée
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un projet à modifier",
                              "Aucune sélection",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            // Vérifier que la colonne ProjectID existe
            if (!dataGridView.Columns.Contains("ProjectID"))
            {
                MessageBox.Show("La colonne ProjectID est introuvable dans la vue",
                              "Erreur de configuration",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Récupérer l'ID du projet
                var selectedRow = dataGridView.SelectedRows[0];
                var projectIdCell = selectedRow.Cells["ProjectID"];

                if (projectIdCell.Value == null || projectIdCell.Value == DBNull.Value)
                {
                    MessageBox.Show("L'ID du projet est invalide",
                                  "Donnée corrompue",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                    return;
                }

                int projectId = Convert.ToInt32(projectIdCell.Value);

                // Ouvrir le formulaire d'édition
                using (FormEditProject form = new FormEditProject(projectId))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        RefreshCurrentView(); // Méthode pour rafraîchir la vue
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ouverture de l'éditeur : {ex.Message}",
                              "Erreur",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void cuiButtonProgress_Click(object sender, EventArgs e)
        {
            try
            {
                FormTaskStatistics statsForm = new FormTaskStatistics();
                statsForm.Show(); // Ou ShowDialog() pour une fenêtre modale
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}");
            }
        }
        private void RemplirInfosUtilisateur()
        {
            try
            {
                int userID = SessionUtilisateur.UserID;
                string query = @"
            SELECT 
                u.Username, 
                u.Email, 
                u.PhoneNumber, 
                u.Role,
                u.IsActive,
                COUNT(DISTINCT ta.TaskID) AS ActiveTaskCount,
                COUNT(DISTINCT CASE WHEN p.ManagerID = u.UserID THEN p.ProjectID END) AS ManagedProjectCount,
                COUNT(DISTINCT CASE WHEN t.LeaderID = u.UserID THEN t.TeamID END) AS TeamCount,
                CONVERT(VARCHAR, u.LastLogin, 103) AS LastLoginFormatted
            FROM Users u
            LEFT JOIN Task_Assignments ta ON u.UserID = ta.UserID
                AND EXISTS (SELECT 1 FROM Tasks t WHERE t.TaskID = ta.TaskID AND t.Status != 'Terminée')
            LEFT JOIN Projects p ON u.UserID = p.ManagerID
            LEFT JOIN Teams t ON u.UserID = t.LeaderID
            WHERE u.UserID = @UserID
            GROUP BY u.Username, u.Email, u.PhoneNumber, u.Role, u.IsActive, u.LastLogin";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Traitement du nom complet
                            string fullName = reader["Username"].ToString();
                            string[] nameParts = fullName.Split(' ');

                            labelNom.Text = nameParts.Length > 0 ? nameParts[0].ToUpper() : "";
                            labelPrenom.Text = nameParts.Length > 1 ? nameParts[1] : "";

                            // Formatage des informations étendues
                            string status = Convert.ToBoolean(reader["IsActive"]) ? "🟢 Actif" : "🔴 Inactif";

                            labelRole.Text = $@"{status}
                                      📱 {reader["PhoneNumber"]?.ToString() ?? "Non renseigné"}
                                      ✉ {reader["Email"]}
                                      🔧 Tâches actives: {reader["ActiveTaskCount"]}
                                      🏗 Projets gérés: {reader["ManagedProjectCount"]}
                                      👥 Équipes dirigées: {reader["TeamCount"]}
                                      ⏳ Dernière connexion: {reader["LastLoginFormatted"]}
                                      🔑 Rôle: {reader["Role"]?.ToString().Replace("_", " ")}";
                        }
                        else
                        {
                            SetDefaultUserInfo("Utilisateur non trouvé");
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                SetDefaultUserInfo("Erreur base de données");
                LogError($"Erreur SQL (n°{sqlEx.Number}): {sqlEx.Message}", sqlEx);
            }
            catch (Exception ex)
            {
                SetDefaultUserInfo("Erreur système");
                LogError($"Erreur: {ex.Message}", ex);
            }
        }

        private void SetDefaultUserInfo(string message)
        {
            labelNom.Text = "Erreur";
            labelPrenom.Text = "";
            labelRole.Text = message;
            labelRole.ForeColor = Color.Red;
        }
        private void editUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Vérifier qu'une ligne est sélectionnée
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un employé à modifier",
                              "Aucune sélection",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            // Vérifier que la colonne UserID existe
            if (!dataGridView.Columns.Contains("UserID"))
            {
                MessageBox.Show("La colonne UserID est introuvable dans la vue",
                              "Erreur de configuration",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Récupérer l'ID de l'utilisateur
                var selectedRow = dataGridView.SelectedRows[0];
                var userIdCell = selectedRow.Cells["UserID"];

                if (userIdCell.Value == null || userIdCell.Value == DBNull.Value)
                {
                    MessageBox.Show("L'ID de l'utilisateur est invalide",
                                  "Donnée corrompue",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                    return;
                }

                int userId = Convert.ToInt32(userIdCell.Value);

                // Ouvrir le formulaire d'édition
                using (FormEditEmployee form = new FormEditEmployee(userId))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        RefreshCurrentView(); // Méthode pour rafraîchir la vue

                        // Optionnel: Resélectionner l'utilisateur modifié
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            if (Convert.ToInt32(row.Cells["UserID"].Value) == userId)
                            {
                                row.Selected = true;
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ouverture de l'éditeur : {ex.Message}",
                              "Erreur",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void editTeamInfoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Vérifier qu'une ligne est sélectionnée dans le DataGridView
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une équipe à modifier",
                              "Aucune sélection",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            // Vérifier que la colonne TeamID existe
            if (!dataGridView.Columns.Contains("TeamID"))
            {
                MessageBox.Show("La colonne TeamID est introuvable dans la vue",
                              "Erreur de configuration",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Récupérer l'ID de l'équipe sélectionnée
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                var teamIdCell = selectedRow.Cells["TeamID"];

                if (teamIdCell.Value == null || teamIdCell.Value == DBNull.Value)
                {
                    MessageBox.Show("L'ID de l'équipe est invalide",
                                  "Donnée corrompue",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                    return;
                }

                int teamId = Convert.ToInt32(teamIdCell.Value);

                // Ouvrir le formulaire d'édition
                using (FormEditTeam editForm = new FormEditTeam(teamId))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        // Rafraîchir la vue après modification
                        RefreshCurrentView();

                        // Resélectionner l'équipe modifiée
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            if (Convert.ToInt32(row.Cells["TeamID"].Value) == teamId)
                            {
                                row.Selected = true;
                                dataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'édition de l'équipe : {ex.Message}",
                              "Erreur",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void cuiButtonDelete_Click_1(object sender, EventArgs e)
        {
            contextMenuDelete.Show(cuiButtonDelete, new Point(cuiButtonDelete.Width, 0));
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Vérifier qu'une ligne est sélectionnée dans le DataGridView
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un employé à supprimer.",
                                "Aucune sélection",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Récupérer les valeurs sélectionnées
            DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

            if (selectedRow.Cells["UserID"].Value == null || selectedRow.Cells["Username"].Value == null)
            {
                MessageBox.Show("L'utilisateur sélectionné est invalide.",
                                "Erreur de données",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            int userId = Convert.ToInt32(selectedRow.Cells["UserID"].Value);
            string username = selectedRow.Cells["Username"].Value.ToString();

            // Confirmation utilisateur
            DialogResult result = MessageBox.Show($"Êtes-vous sûr de vouloir supprimer définitivement l'employé '{username}' ?",
                                                  "Confirmation de suppression",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Vérifier toutes les relations qui pourraient empêcher la suppression
                    string checkRelationsQuery = @"
                SELECT 
                    (SELECT COUNT(*) FROM Teams WHERE LeaderID = @UserID) +
                    (SELECT COUNT(*) FROM Projects WHERE ManagerID = @UserID) +
                    (SELECT COUNT(*) FROM Task_Assignments WHERE UserID = @UserID) +
                    (SELECT COUNT(*) FROM TeamMembers WHERE UserID = @UserID) +
                    (SELECT COUNT(*) FROM TaskAssignmentHistory WHERE UserID = @UserID) +
                    (SELECT COUNT(*) FROM MessageLog WHERE SenderID = @UserID OR RecipientID = @UserID) +
                    (SELECT COUNT(*) FROM Notifications WHERE UserID = @UserID) +
                    (SELECT COUNT(*) FROM ProgressReports WHERE UserID = @UserID)";

                    using (SqlCommand checkCmd = new SqlCommand(checkRelationsQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@UserID", userId);
                        int totalReferences = (int)checkCmd.ExecuteScalar();

                        if (totalReferences > 0)
                        {



                            // Supprimer d'abord toutes les références
                            string deleteReferencesQuery = @"
                                DELETE FROM Task_Assignments WHERE UserID = @UserID;
                                DELETE FROM TeamMembers WHERE UserID = @UserID;
                                DELETE FROM TaskAssignmentHistory WHERE UserID = @UserID;
                                DELETE FROM MessageLog WHERE SenderID = @UserID OR RecipientID = @UserID;
                                DELETE FROM Notifications WHERE UserID = @UserID;
                                DELETE FROM ProgressReports WHERE UserID = @UserID;";

                            using (SqlCommand deleteRefCmd = new SqlCommand(deleteReferencesQuery, conn))
                            {
                                deleteRefCmd.Parameters.AddWithValue("@UserID", userId);
                                deleteRefCmd.ExecuteNonQuery();
                            }

                        }
                    }

                    // Supprimer définitivement l'utilisateur
                    string deleteQuery = "DELETE FROM Users WHERE UserID = @UserID";

                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@UserID", userId);
                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("L'employé a été supprimé définitivement.",
                                            "Succès",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                            RefreshCurrentView();
                        }
                        else
                        {
                            MessageBox.Show("Aucune modification effectuée. L'utilisateur pourrait déjà être supprimé.",
                                            "Information",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression de l'employé :\n{ex.Message}",
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }




        private void contextMenuDelete_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un projet à supprimer",
                                "Aucune sélection",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Vérification des colonnes nécessaires
            if (!dataGridView.Columns.Contains("ProjectID") || !dataGridView.Columns.Contains("Title"))
            {
                MessageBox.Show("Les colonnes nécessaires (ProjectID, Title) sont manquantes.",
                                "Erreur de configuration",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            int projectId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["ProjectID"].Value);
            string projectTitle = dataGridView.SelectedRows[0].Cells["Title"].Value.ToString();

            // Vérifier s'il y a des tâches non terminées
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand checkCmd = new SqlCommand(
                        "SELECT COUNT(*) FROM Tasks WHERE ProjectID = @ProjectID AND Status != 'Terminée'", conn))
                    {
                        checkCmd.Parameters.AddWithValue("@ProjectID", projectId);
                        int activeTasks = (int)checkCmd.ExecuteScalar();

                        if (activeTasks > 0)
                        {
                            MessageBox.Show("Ce projet contient des tâches actives.\n" +
                                            "Veuillez terminer ou réaffecter les tâches avant de supprimer le projet.",
                                            "Suppression impossible",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la vérification des tâches actives :\n{ex.Message}",
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Confirmation de suppression
            DialogResult result = MessageBox.Show($"Êtes-vous sûr de vouloir supprimer le projet '{projectTitle}' ?",
                                                  "Confirmation de suppression",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1. Supprimer d'abord tous les rapports liés au projet
                            using (SqlCommand deleteReports = new SqlCommand(
                                "DELETE FROM Reports WHERE ProjectID = @ProjectID", conn, transaction))
                            {
                                deleteReports.Parameters.AddWithValue("@ProjectID", projectId);
                                deleteReports.ExecuteNonQuery();
                            }

                            // 2. Supprimer les tâches sous-traitées liées au projet
                            using (SqlCommand deleteSubcontractedTasks = new SqlCommand(
                                "DELETE FROM SubcontractedTasks WHERE TaskID IN (SELECT TaskID FROM Tasks WHERE ProjectID = @ProjectID)",
                                conn, transaction))
                            {
                                deleteSubcontractedTasks.Parameters.AddWithValue("@ProjectID", projectId);
                                deleteSubcontractedTasks.ExecuteNonQuery();
                            }

                            // 3. Supprimer les assignations de tâches liées au projet
                            using (SqlCommand deleteTaskAssignments = new SqlCommand(
                                "DELETE FROM Task_Assignments WHERE TaskID IN (SELECT TaskID FROM Tasks WHERE ProjectID = @ProjectID)",
                                conn, transaction))
                            {
                                deleteTaskAssignments.Parameters.AddWithValue("@ProjectID", projectId);
                                deleteTaskAssignments.ExecuteNonQuery();
                            }

                            // 4. Supprimer les tâches du projet
                            using (SqlCommand deleteTasks = new SqlCommand(
                                "DELETE FROM Tasks WHERE ProjectID = @ProjectID", conn, transaction))
                            {
                                deleteTasks.Parameters.AddWithValue("@ProjectID", projectId);
                                deleteTasks.ExecuteNonQuery();
                            }

                            // 5. Supprimer les équipes liées à ce projet
                            using (SqlCommand deleteTeams = new SqlCommand(
                                "DELETE FROM Teams WHERE ProjectID = @ProjectID", conn, transaction))
                            {
                                deleteTeams.Parameters.AddWithValue("@ProjectID", projectId);
                                deleteTeams.ExecuteNonQuery();
                            }

                            // 6. Supprimer le projet lui-même
                            using (SqlCommand deleteProject = new SqlCommand(
                                "DELETE FROM Projects WHERE ProjectID = @ProjectID", conn, transaction))
                            {
                                deleteProject.Parameters.AddWithValue("@ProjectID", projectId);
                                int rowsAffected = deleteProject.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    transaction.Commit();
                                    MessageBox.Show("Projet supprimé avec succès !",
                                                    "Succès",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);
                                    RefreshCurrentView();
                                }
                                else
                                {
                                    transaction.Rollback();
                                    MessageBox.Show("Aucun projet n'a été supprimé. Le projet est peut-être déjà supprimé.",
                                                    "Information",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);
                                }
                            }
                        }
                        catch (SqlException sqlEx)
                        {
                            transaction.Rollback();
                            string errorMessage = "Erreur lors de la suppression du projet:\n";

                            if (sqlEx.Number == 547) // Violation de contrainte de clé étrangère
                            {
                                errorMessage += "Il reste des dépendances non gérées pour ce projet.\n";
                                errorMessage += "Message technique: " + sqlEx.Message;
                            }
                            else
                            {
                                errorMessage += sqlEx.Message;
                            }

                            MessageBox.Show(errorMessage,
                                          "Erreur",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Erreur lors de la suppression :\n{ex.Message}",
                                            "Erreur",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de connexion :\n{ex.Message}",
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        private void deleteTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une tâche à supprimer",
                                "Aucune sélection",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Vérification des colonnes nécessaires
            if (!dataGridView.Columns.Contains("TaskID") || !dataGridView.Columns.Contains("Title"))
            {
                MessageBox.Show("Les colonnes nécessaires (TaskID, Title) sont manquantes.",
                                "Erreur de configuration",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            int taskId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["TaskID"].Value);
            string taskTitle = dataGridView.SelectedRows[0].Cells["Title"].Value.ToString();

            DialogResult result = MessageBox.Show($"Êtes-vous sûr de vouloir supprimer la tâche '{taskTitle}' ?",
                                                  "Confirmation de suppression",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Supprimer les assignations de la tâche
                            using (SqlCommand deleteAssignments = new SqlCommand(
                                "DELETE FROM Task_Assignments WHERE TaskID = @TaskID", conn, transaction))
                            {
                                deleteAssignments.Parameters.AddWithValue("@TaskID", taskId);
                                deleteAssignments.ExecuteNonQuery();
                            }

                            // Supprimer les sous-tâches sous-traitées (le cas échéant)
                            using (SqlCommand deleteSubcontracted = new SqlCommand(
                                "DELETE FROM SubcontractedTasks WHERE TaskID = @TaskID", conn, transaction))
                            {
                                deleteSubcontracted.Parameters.AddWithValue("@TaskID", taskId);
                                deleteSubcontracted.ExecuteNonQuery();
                            }

                            // Supprimer la tâche principale
                            using (SqlCommand deleteTask = new SqlCommand(
                                "DELETE FROM Tasks WHERE TaskID = @TaskID", conn, transaction))
                            {
                                deleteTask.Parameters.AddWithValue("@TaskID", taskId);
                                int rowsAffected = deleteTask.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    transaction.Commit();
                                    MessageBox.Show("Tâche supprimée avec succès !",
                                                    "Succès",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);
                                    RefreshCurrentView();
                                }
                                else
                                {
                                    transaction.Rollback();
                                    MessageBox.Show("Aucune tâche n’a été supprimée. La tâche est peut-être déjà supprimée.",
                                                    "Échec",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Warning);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Erreur lors de la suppression de la tâche :\n{ex.Message}",
                                            "Erreur",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de connexion ou de transaction :\n{ex.Message}",
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }



        private void deleteTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une équipe à supprimer",
                                "Aucune sélection",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Vérifier que les colonnes existent
            if (!dataGridView.Columns.Contains("TeamID") || !dataGridView.Columns.Contains("Name"))
            {
                MessageBox.Show("Les colonnes nécessaires (TeamID, Name) sont manquantes.",
                                "Erreur de configuration",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            int teamId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["TeamID"].Value);
            string teamName = dataGridView.SelectedRows[0].Cells["Name"].Value.ToString();

            // Vérifier s’il y a des tâches actives liées à cette équipe
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand checkCmd = new SqlCommand(@"
                SELECT COUNT(*) FROM Task_Assignments ta
                JOIN TeamMembers tm ON ta.UserID = tm.UserID
                JOIN Tasks t ON ta.TaskID = t.TaskID
                WHERE tm.TeamID = @TeamID AND t.Status != 'Terminée'", conn))
                    {
                        checkCmd.Parameters.AddWithValue("@TeamID", teamId);
                        int activeTasks = (int)checkCmd.ExecuteScalar();

                        if (activeTasks > 0)
                        {
                            MessageBox.Show("Cette équipe est affectée à des tâches non terminées. " +
                                            "Veuillez réaffecter ou clôturer ces tâches avant de supprimer l'équipe.",
                                            "Suppression impossible",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la vérification des tâches actives :\n{ex.Message}",
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show($"Êtes-vous sûr de vouloir supprimer l'équipe '{teamName}' ?",
                                                  "Confirmation de suppression",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            // Suppression de l'équipe et de ses membres
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Supprimer les membres de l’équipe
                            using (SqlCommand deleteMembers = new SqlCommand(
                                "DELETE FROM TeamMembers WHERE TeamID = @TeamID", conn, transaction))
                            {
                                deleteMembers.Parameters.AddWithValue("@TeamID", teamId);
                                deleteMembers.ExecuteNonQuery();
                            }

                            // Supprimer l’équipe elle-même
                            using (SqlCommand deleteTeam = new SqlCommand(
                                "DELETE FROM Teams WHERE TeamID = @TeamID", conn, transaction))
                            {
                                deleteTeam.Parameters.AddWithValue("@TeamID", teamId);
                                int rowsAffected = deleteTeam.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    transaction.Commit();
                                    MessageBox.Show("Équipe supprimée avec succès !",
                                                    "Succès",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);
                                    RefreshCurrentView();
                                }
                                else
                                {
                                    transaction.Rollback();
                                    MessageBox.Show("Aucune équipe n’a été supprimée. Elle est peut-être déjà supprimée.",
                                                    "Échec",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Warning);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Erreur lors de la suppression de l’équipe :\n{ex.Message}",
                                            "Erreur",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de connexion ou de transaction :\n{ex.Message}",
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir vous déconnecter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Ferme l'application ou revient à la page de connexion selon ton design
                Application.Exit();
            }
            else
            {
                // Ne rien faire, l'utilisateur reste sur la page actuelle
            }
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir vous déconnecter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Ferme l'application ou revient à la page de connexion selon ton design
                Application.Exit();
            }
            else
            {
                // Ne rien faire, l'utilisateur reste sur la page actuelle
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
using FatiIkhlassYoun.NewFolder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
namespace FatiIkhlassYoun
{
    public partial class ModifierTacheViaMenu : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementSystem"].ConnectionString;

        private int userIdChefEquipe;

        public event EventHandler TaskUpdated;

        public ModifierTacheViaMenu(int userId)
        {
            InitializeComponent();
            userIdChefEquipe = userId;
            this.Load += ModifierTacheViaMenu_Load;
        }

        private void ModifierTacheViaMenu_Load(object sender, EventArgs e)
        {
            // Remplir le ComboBox avec les tâches
            RemplirComboTaches();

            // Configurer les statuts
            comboStatus.Items.AddRange(new object[] { "En attente", "En cours", "Terminée" });
        }

        private void RemplirComboTaches()
        {
            comboBoxTaches.Items.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                    SELECT t.TaskID, t.Title, p.Title AS ProjectTitle
                    FROM Tasks t
                    INNER JOIN Projects p ON t.ProjectID = p.ProjectID
                    WHERE p.ManagerID = @ManagerID
                    ORDER BY t.DueDate DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ManagerID", userIdChefEquipe);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int taskId = reader.GetInt32(0);
                        string taskTitle = reader.GetString(1);
                        string projectTitle = reader.GetString(2);

                        comboBoxTaches.Items.Add(new TaskItem(taskId, $"{taskTitle} ({projectTitle})"));
                    }
                }

                if (comboBoxTaches.Items.Count > 0)
                {
                    comboBoxTaches.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Aucune tâche disponible pour modification.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des tâches: {ex.Message}");
            }
        }

        private void comboBoxTaches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTaches.SelectedItem is TaskItem selectedTask)
            {
                ChargerDetailsTache(selectedTask.Id);
            }
        }

        private void ChargerDetailsTache(int taskId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Charger les détails de la tâche
                    string taskQuery = "SELECT * FROM Tasks WHERE TaskID = @TaskID";
                    SqlCommand taskCmd = new SqlCommand(taskQuery, conn);
                    taskCmd.Parameters.AddWithValue("@TaskID", taskId);

                    // Charger les membres affectés
                    string memberQuery = "SELECT UserID FROM Task_Assignments WHERE TaskID = @TaskID";
                    SqlCommand memberCmd = new SqlCommand(memberQuery, conn);
                    memberCmd.Parameters.AddWithValue("@TaskID", taskId);

                    conn.Open();

                    // Remplir les champs de la tâche
                    SqlDataReader taskReader = taskCmd.ExecuteReader();
                    if (taskReader.Read())
                    {
                        txtTitre.Text = taskReader["Title"].ToString();
                        txtDescription.Text = taskReader["Description"].ToString();
                        dtpDebut.Value = Convert.ToDateTime(taskReader["StartDate"]);
                        dtpFin.Value = Convert.ToDateTime(taskReader["DueDate"]);

                        string status = taskReader["Status"].ToString();
                        comboStatus.SelectedItem = status;

                        numTemps.Value = Convert.ToInt32(taskReader["EstimatedTime"]);
                    }
                    taskReader.Close();

                    // Charger les membres disponibles et cocher ceux affectés
                    ChargerMembresDisponibles(taskId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des détails: {ex.Message}");
            }
        }

        private void ChargerMembresDisponibles(int taskId)
        {
            checkedListBoxMembres.Items.Clear();
            List<int> membresAffectes = new List<int>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Récupérer les membres affectés à cette tâche
                    string assignedQuery = "SELECT UserID FROM Task_Assignments WHERE TaskID = @TaskID";
                    SqlCommand assignedCmd = new SqlCommand(assignedQuery, conn);
                    assignedCmd.Parameters.AddWithValue("@TaskID", taskId);

                    conn.Open();
                    using (SqlDataReader assignedReader = assignedCmd.ExecuteReader())
                    {
                        while (assignedReader.Read())
                        {
                            membresAffectes.Add(assignedReader.GetInt32(0));
                        }
                    }

                    // Récupérer tous les membres disponibles
                    string membersQuery = @"
                    SELECT u.UserID, u.Username 
                    FROM Users u
                    INNER JOIN TeamMembers tm ON u.UserID = tm.UserID
                    INNER JOIN Teams t ON tm.TeamID = t.TeamID
                    WHERE t.LeaderID = @LeaderID 
                    AND u.Role = 'membre'";

                    SqlCommand membersCmd = new SqlCommand(membersQuery, conn);
                    membersCmd.Parameters.AddWithValue("@LeaderID", userIdChefEquipe);

                    using (SqlDataReader membersReader = membersCmd.ExecuteReader())
                    {
                        while (membersReader.Read())
                        {
                            int memberId = membersReader.GetInt32(0);
                            string username = membersReader.GetString(1);

                            var item = new MembreEquipe
                            {
                                UserID = memberId,
                                Username = username
                            };

                            checkedListBoxMembres.Items.Add(
                                item,
                                membresAffectes.Contains(memberId)
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des membres: {ex.Message}");
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (!(comboBoxTaches.SelectedItem is TaskItem selectedTask))
            {
                MessageBox.Show("Veuillez sélectionner une tâche à modifier.");
                return;
            }

            // Validation des champs
            if (string.IsNullOrEmpty(txtTitre.Text.Trim()) ||
                comboStatus.SelectedItem == null ||
                checkedListBoxMembres.CheckedItems.Count == 0)
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.");
                return;
            }

            // Récupérer les membres sélectionnés
            List<int> nouveauxMembres = new List<int>();
            foreach (var item in checkedListBoxMembres.CheckedItems)
            {
                if (item is MembreEquipe membre)
                {
                    nouveauxMembres.Add(membre.UserID);
                }
            }

            // Demander confirmation avec authentification
            FormAuthConfirmation authForm = new FormAuthConfirmation(userIdChefEquipe, "chef_equipe","update", selectedTask.Id );

            if (authForm.ShowDialog() == DialogResult.OK)
            {
                ModifierTache(
                    selectedTask.Id,
                    txtTitre.Text.Trim(),
                    txtDescription.Text.Trim(),
                    dtpDebut.Value,
                    dtpFin.Value,
                    comboStatus.SelectedItem.ToString(),
                    (int)numTemps.Value,
                    nouveauxMembres
                );
            }
        }

        private void ModifierTache(int taskId, string titre, string description,
                                DateTime dateDebut, DateTime dateFin, string statut,
                                int tempsEstime, List<int> membresIds)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // 1. Mettre à jour la tâche
                        string updateQuery = @"
                        UPDATE Tasks 
                        SET Title = @Title,
                            Description = @Description,
                            StartDate = @StartDate,
                            DueDate = @DueDate,
                            Status = @Status,
                            EstimatedTime = @EstimatedTime
                        WHERE TaskID = @TaskID";

                        SqlCommand cmd = new SqlCommand(updateQuery, conn, transaction);
                        cmd.Parameters.AddWithValue("@Title", titre);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@StartDate", dateDebut);
                        cmd.Parameters.AddWithValue("@DueDate", dateFin);
                        cmd.Parameters.AddWithValue("@Status", statut);
                        cmd.Parameters.AddWithValue("@EstimatedTime", tempsEstime);
                        cmd.Parameters.AddWithValue("@TaskID", taskId);
                        cmd.ExecuteNonQuery();

                        // 2. Mettre à jour les affectations
                        // Supprimer les anciennes
                        string deleteQuery = "DELETE FROM Task_Assignments WHERE TaskID = @TaskID";
                        SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn, transaction);
                        deleteCmd.Parameters.AddWithValue("@TaskID", taskId);
                        deleteCmd.ExecuteNonQuery();

                        // Ajouter les nouvelles
                        foreach (int membreId in membresIds)
                        {
                            string insertQuery =
                                "INSERT INTO Task_Assignments (TaskID, UserID) VALUES (@TaskID, @UserID)";
                            SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction);
                            insertCmd.Parameters.AddWithValue("@TaskID", taskId);
                            insertCmd.Parameters.AddWithValue("@UserID", membreId);
                            insertCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Tâche modifiée avec succès !");
                        TaskUpdated?.Invoke(this, EventArgs.Empty);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Erreur lors de la modification: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de connexion: {ex.Message}");
            }
        }

        private class TaskItem
        {
            public int Id { get; }
            public string DisplayText { get; }

            public TaskItem(int id, string displayText)
            {
                Id = id;
                DisplayText = displayText;
            }

            public override string ToString()
            {
                return DisplayText;
            }
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class MembreEquipe
    {
        public int UserID { get; set; }
        public string Username { get; set; }

        public override string ToString()
        {
            return Username;
        }
    }
}
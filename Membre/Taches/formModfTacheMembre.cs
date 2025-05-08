using FatiIkhlassYoun.NewFolder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;     
namespace FatiIkhlassYoun.membreFolder
{
    public partial class formModfTacheMembre : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementSystem"].ConnectionString;
        private int userId;
        private int selectedTaskId = -1;

        public formModfTacheMembre(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.Load += FormModfTacheMembre_Load;
        }

        private void FormModfTacheMembre_Load(object sender, EventArgs e)
        {
            // Remplir les statuts
            comboStatus.Items.Clear();
            comboStatus.Items.Add("En attente");
            comboStatus.Items.Add("En cours");
            comboStatus.Items.Add("Terminée");

            // Charger les projets, équipes et tâches
            ChargerProjets();
        }

        private void ChargerProjets()
        {
            comboProjet.Items.Clear();
            comboEquipe.Items.Clear();
            comboTache.Items.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                    SELECT DISTINCT p.ProjectID, p.Title 
                    FROM Projects p
                    INNER JOIN Tasks t ON p.ProjectID = t.ProjectID
                    INNER JOIN Task_Assignments ta ON t.TaskID = ta.TaskID
                    WHERE ta.UserID = @UserID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboProjet.Items.Add(new KeyValuePair<int, string>(
                            reader.GetInt32(0),
                            reader.GetString(1)));
                    }
                    reader.Close();
                }

                comboProjet.DisplayMember = "Value";
                comboProjet.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des projets: {ex.Message}");
            }
        }

        private void comboProjet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboProjet.SelectedItem == null) return;

            int projectId = ((KeyValuePair<int, string>)comboProjet.SelectedItem).Key;
            ChargerEquipes(projectId);
        }

        private void ChargerEquipes(int projectId)
        {
            comboEquipe.Items.Clear();
            comboTache.Items.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                    SELECT DISTINCT t.TeamID, t.Name 
                    FROM Teams t
                    INNER JOIN TeamMembers tm ON t.TeamID = tm.TeamID
                    INNER JOIN Tasks ts ON ts.TeamLeadID = t.LeaderID
                    INNER JOIN Task_Assignments ta ON ts.TaskID = ta.TaskID
                    WHERE ta.UserID = @UserID AND ts.ProjectID = @ProjectID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@ProjectID", projectId);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboEquipe.Items.Add(new KeyValuePair<int, string>(
                            reader.GetInt32(0),
                            reader.GetString(1)));
                    }
                    reader.Close();
                }

                comboEquipe.DisplayMember = "Value";
                comboEquipe.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des équipes: {ex.Message}");
            }
        }

        private void comboEquipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboEquipe.SelectedItem == null || comboProjet.SelectedItem == null) return;

            int teamId = ((KeyValuePair<int, string>)comboEquipe.SelectedItem).Key;
            int projectId = ((KeyValuePair<int, string>)comboProjet.SelectedItem).Key;
            ChargerTaches(projectId, teamId);
        }

        private void ChargerTaches(int projectId, int teamId)
        {
            comboTache.Items.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                    SELECT t.TaskID, t.Title, t.Status 
                    FROM Tasks t
                    INNER JOIN Task_Assignments ta ON t.TaskID = ta.TaskID
                    WHERE ta.UserID = @UserID 
                    AND t.ProjectID = @ProjectID
                    AND t.TeamLeadID IN (SELECT LeaderID FROM Teams WHERE TeamID = @TeamID)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@ProjectID", projectId);
                    cmd.Parameters.AddWithValue("@TeamID", teamId);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboTache.Items.Add(new KeyValuePair<int, string>(
                            reader.GetInt32(0),
                            $"{reader.GetString(1)} ({reader.GetString(2)})"));
                    }
                    reader.Close();
                }

                comboTache.DisplayMember = "Value";
                comboTache.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des tâches: {ex.Message}");
            }
        }

        private void comboTache_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTache.SelectedItem == null) return;

            selectedTaskId = ((KeyValuePair<int, string>)comboTache.SelectedItem).Key;
            ChargerDetailsTache(selectedTaskId);
        }

        private void ChargerDetailsTache(int taskId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Title, Description, Status FROM Tasks WHERE TaskID = @TaskID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TaskID", taskId);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtTitre.Text = reader["Title"].ToString();
                        txtDescription.Text = reader["Description"].ToString();

                        string status = reader["Status"].ToString();
                        if (comboStatus.Items.Contains(status))
                        {
                            comboStatus.SelectedItem = status;
                        }
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des détails de la tâche: {ex.Message}");
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (selectedTaskId == -1)
            {
                MessageBox.Show("Veuillez sélectionner une tâche à modifier.");
                return;
            }

            string nouveauStatut = comboStatus.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(nouveauStatut))
            {
                MessageBox.Show("Veuillez sélectionner un statut.");
                return;
            }

            // Vérifier d'abord si le statut a changé
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Status FROM Tasks WHERE TaskID = @TaskID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TaskID", selectedTaskId);

                    conn.Open();
                    string ancienStatut = cmd.ExecuteScalar()?.ToString();

                    if (ancienStatut == nouveauStatut)
                    {
                        MessageBox.Show("Aucune modification n'a été apportée.");
                        return;
                    }

                    // Si le statut a changé, demander l'authentification
                    FormAuthConfirmation authForm = new FormAuthConfirmation(userId, "membre", "update", selectedTaskId);
                    if (authForm.ShowDialog() == DialogResult.OK)
                    {
                        // Si l'authentification est réussie, procéder à la modification
                        ModifierStatutTache(nouveauStatut);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la vérification: {ex.Message}");
            }
        }

        private void ModifierStatutTache(string nouveauStatut)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Tasks SET Status = @Status WHERE TaskID = @TaskID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Status", nouveauStatut);
                    cmd.Parameters.AddWithValue("@TaskID", selectedTaskId);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Statut de la tâche mis à jour avec succès !");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification: {ex.Message}");
            }
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
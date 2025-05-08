using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration; 
namespace FatiIkhlassYoun.NewFolder
{
    public partial class SupprimerTacheViaMenu : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementSystem"].ConnectionString;
        private int userIdChefEquipe;

        public event EventHandler TaskDeleted;

        public SupprimerTacheViaMenu(int userId)
        {
            InitializeComponent();
            userIdChefEquipe = userId;
            this.Load += SupprimerTacheViaMenu_Load;
        }

        private void SupprimerTacheViaMenu_Load(object sender, EventArgs e)
        {
            RemplirComboTaches();
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
                    ChargerDetailsTache((comboBoxTaches.SelectedItem as TaskItem).Id);
                }
                else
                {
                    MessageBox.Show("Aucune tâche disponible pour suppression.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des tâches: {ex.Message}");
            }
        }

        private void ChargerDetailsTache(int taskId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Title, Description FROM Tasks WHERE TaskID = @TaskID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TaskID", taskId);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtTitre.Text = reader["Title"].ToString();
                        txtDescription.Text = reader["Description"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des détails: {ex.Message}");
            }
        }

        private void comboBoxTaches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTaches.SelectedItem is TaskItem selectedTask)
            {
                ChargerDetailsTache(selectedTask.Id);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (!(comboBoxTaches.SelectedItem is TaskItem selectedTask))
            {
                MessageBox.Show("Veuillez sélectionner une tâche à supprimer.");
                return;
            }

            FormAuthConfirmation authForm = new FormAuthConfirmation(
                userIdChefEquipe, "chef_equipe",
                "delete",
                selectedTask.Id
            );

            if (authForm.ShowDialog() == DialogResult.OK)
            {
                SupprimerTacheDeLaBase(selectedTask.Id);
            }
        }

        private void SupprimerTacheDeLaBase(int taskId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. D'abord supprimer les assignations de tâche
                    string deleteAssignmentsQuery = "DELETE FROM Task_Assignments WHERE TaskID = @TaskID";
                    SqlCommand deleteAssignmentsCmd = new SqlCommand(deleteAssignmentsQuery, conn, transaction);
                    deleteAssignmentsCmd.Parameters.AddWithValue("@TaskID", taskId);
                    deleteAssignmentsCmd.ExecuteNonQuery();

                    // 2. Ensuite supprimer la tâche elle-même
                    string deleteTaskQuery = "DELETE FROM Tasks WHERE TaskID = @TaskID";
                    SqlCommand deleteTaskCmd = new SqlCommand(deleteTaskQuery, conn, transaction);
                    deleteTaskCmd.Parameters.AddWithValue("@TaskID", taskId);
                    int rowsAffected = deleteTaskCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        transaction.Commit();
                        MessageBox.Show("Tâche supprimée avec succès.");
                        TaskDeleted?.Invoke(this, EventArgs.Empty);
                        this.Close();
                    }
                    else
                    {
                        transaction.Rollback();
                        MessageBox.Show("Aucune tâche trouvée avec cet ID.");
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Erreur lors de la suppression de la tâche: {ex.Message}");
                }
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
    }
}
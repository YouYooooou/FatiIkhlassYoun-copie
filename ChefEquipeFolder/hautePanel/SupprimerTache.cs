using Microsoft.VisualBasic.ApplicationServices;
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

namespace FatiIkhlassYoun.NewFolder
{
    public partial class SupprimerTache : Form
    {

        private string connectionString = @"Data Source=YOUNES\SQLEXPRESS;Initial Catalog=ProjectManagementSystem;Integrated Security=True";
        private int userIdChefEquipe;
        private int taskId;

        public SupprimerTache(int userId, int selectedTaskId)
        {
            InitializeComponent();
            userIdChefEquipe = userId;
            taskId = selectedTaskId;

            this.Load += SupprimerTache_Load;
            btnSupprimer.Click += btnSupprimer_Click;
            btnAnnuler.Click += (s, e) => this.Close();
        }


        private void SupprimerTache_Load(object sender, EventArgs e)
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



        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            FormAuthConfirmation authForm = new FormAuthConfirmation(userIdChefEquipe, "delete", taskId);
            if (authForm.ShowDialog() == DialogResult.OK)
            {
                // Si authentification réussie, supprimer la tâche
                SupprimerTacheDeLaBase(taskId);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

        }
    }
}

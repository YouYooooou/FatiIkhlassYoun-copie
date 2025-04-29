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


      



        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Ouvre le formulaire d'authentification pour confirmer l'identité
            FormAuthConfirmation authForm = new FormAuthConfirmation(userIdChefEquipe, "delete", taskId);
            authForm.ShowDialog();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

        }
    }
}

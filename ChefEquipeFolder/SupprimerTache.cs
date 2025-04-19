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
        public SupprimerTache(int userId)
        {
            InitializeComponent();
            userIdChefEquipe = userId;
            this.Load += SupprimerTache_Load;
            comboTache.SelectedIndexChanged += comboTache_SelectedIndexChanged;
            btnSupprimer.Click += btnSupprimer_Click;
            btnAnnuler.Click += (s, e) => this.Close();
        }

        private void SupprimerTache_Load(object sender, EventArgs e)
        {
            ChargerTaches();

        }

        private void ChargerTaches()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TaskID, Title FROM Tasks WHERE TeamLeadID = @TeamLeadID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TeamLeadID", userIdChefEquipe);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboTache.DisplayMember = "Title";
                comboTache.ValueMember = "TaskID";
                comboTache.DataSource = dt;
            }
        }

        private void comboTache_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTache.SelectedValue != null)
            {
                int taskId = (int)comboTache.SelectedValue;
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
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (comboTache.SelectedValue == null || comboTache.SelectedValue == DBNull.Value)
            {
                MessageBox.Show("Veuillez sélectionner une tâche à supprimer.");
                return;
            }

            int taskId;
            if (!int.TryParse(comboTache.SelectedValue.ToString(), out taskId))
            {
                MessageBox.Show("Sélection invalide de tâche.");
                return;
            }

            // Ouvre le formulaire d'authentification pour confirmer l'identité
            FormAuthConfirmation authForm = new FormAuthConfirmation(userIdChefEquipe, "delete", taskId);
            authForm.ShowDialog();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

        }
    }
}

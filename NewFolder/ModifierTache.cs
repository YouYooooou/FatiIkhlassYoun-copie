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

namespace FatiIkhlassYoun
{
    public partial class ModifierTache: Form
    {
        private string connectionString = @"Data Source=YOUNES\SQLEXPRESS;Initial Catalog=ProjectManagementSystem;Integrated Security=True";
        private int userIdChefEquipe;

        // ✅ Constructeur AVEC paramètre userId
        public ModifierTache(int userId)
        {
            InitializeComponent();
            userIdChefEquipe = userId;
            this.Load += ModifierTache_Load; // ← Ajoute cette ligne si elle manque
        }

        // ✅ Événement Load du formulaire (à associer dans le Designer)
       

        private void ModifierTache_Load(object sender, EventArgs e)
        {
            // Remplir les statuts manuellement
            comboStatus.Items.Clear();
            comboStatus.Items.Add("En attente");
            comboStatus.Items.Add("En cours");
            comboStatus.Items.Add("Terminée");
            // Charger les tâches
            ChargerTaches();
        }

        private void ChargerTaches()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT TaskID, Title 
                FROM Tasks 
                WHERE TeamLeadID = @TeamLeadID";

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
                // Récupérer l'objet sélectionné, qui est une ligne DataRowView
                DataRowView selectedRow = (DataRowView)comboTache.SelectedItem;

                // Accéder au TaskID de cette ligne
                int taskId = (int)selectedRow["TaskID"];

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Tasks WHERE TaskID = @taskId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@taskId", taskId);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtTitre.Text = reader["Title"].ToString();
                        txtDescription.Text = reader["Description"].ToString();
                        dtpDebut.Value = Convert.ToDateTime(reader["StartDate"]);
                        dtpFin.Value = Convert.ToDateTime(reader["DueDate"]);
                        comboStatus.SelectedItem = reader["Status"].ToString();
                        numTemps.Value = Convert.ToInt32(reader["EstimatedTime"]);
                    }
                }
            }

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int taskId = (int)comboTache.SelectedValue;

            string titre = txtTitre.Text.Trim();
            string description = txtDescription.Text.Trim();
            DateTime dateDebut = dtpDebut.Value.Date;
            DateTime dateFin = dtpFin.Value.Date;
            string statut = comboStatus.SelectedItem?.ToString();
            int tempsEstime = (int)numTemps.Value;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        UPDATE Tasks
        SET Title = @Title,
            Description = @Description,
            StartDate = @StartDate,
            DueDate = @DueDate,
            Status = @Status,
            EstimatedTime = @EstimatedTime
        WHERE TaskID = @TaskID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", titre);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@StartDate", dateDebut);
                cmd.Parameters.AddWithValue("@DueDate", dateFin);
                cmd.Parameters.AddWithValue("@Status", statut);
                cmd.Parameters.AddWithValue("@EstimatedTime", tempsEstime);
                cmd.Parameters.AddWithValue("@TaskID", taskId);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Tâche modifiée avec succès !");
                    this.Close();  // Ferme le formulaire après le message
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification.");
                }
            }
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            // Ferme le formulaire sans rien faire
            this.Close();
        }
    }
}

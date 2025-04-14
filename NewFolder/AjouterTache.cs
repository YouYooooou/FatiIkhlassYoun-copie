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
    public partial class AjouterTache : Form
    {
        private string connectionString = @"Data Source=YOUNES\SQLEXPRESS;Initial Catalog=ProjectManagementSystem;Integrated Security=True";



        // 🔄 Charger les projets dans le ComboBox
        private int userIdChefEquipe;
        public AjouterTache(int userId)
        {
            InitializeComponent();
            userIdChefEquipe = userId;
        }

        private void ChargerProjets()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ProjectID, Title FROM Projects";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboProjet.DataSource = dt;
                comboProjet.DisplayMember = "Title";
                comboProjet.ValueMember = "ProjectID";
            }
        }

        // 🔄 Charger les statuts possibles
        private void ChargerStatus()
        {
            comboStatus.Items.Add("En attente");
            comboStatus.Items.Add("En cours");
            comboStatus.Items.Add("Terminée");
        }
        private void cmbProjet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // 🔢 Générer un ID aléatoire (exemple : TSK-4573)
            string codeTache = "TSK-" + new Random().Next(1000, 9999);
            textBox1.Text = codeTache; // Affiche dans le TextBox en lecture seule

            if (comboProjet.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un projet.");
                return;
            }
            int projectId = (int)comboProjet.SelectedValue;
            string titre = txtTitre.Text.Trim();
            string description = txtDescription.Text.Trim();
            DateTime dateDebut = dtpDebut.Value.Date;
            DateTime dateFin = dtpFin.Value.Date;
            string statut = comboStatus.SelectedItem?.ToString();
            int tempsEstime = (int)numTemps.Value;

            if (string.IsNullOrEmpty(titre) || string.IsNullOrEmpty(statut))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.");
                return;
            }

            // 🔍 Récupérer automatiquement l'ID du chef de projet à partir du projet sélectionné
            int managerId = GetManagerIdByProject(projectId);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    INSERT INTO Tasks (ProjectID, Title, Description, StartDate, DueDate, Status, EstimatedTime, TeamLeadID, CodeTache)
                    VALUES (@ProjectID, @Title, @Description, @StartDate, @DueDate, @Status, @EstimatedTime, @TeamLeadID, @CodeTache);";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProjectID", projectId);
                    cmd.Parameters.AddWithValue("@Title", titre);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@StartDate", dateDebut);
                    cmd.Parameters.AddWithValue("@DueDate", dateFin);
                    cmd.Parameters.AddWithValue("@Status", statut);
                    cmd.Parameters.AddWithValue("@EstimatedTime", tempsEstime);
                    cmd.Parameters.AddWithValue("@TeamLeadID", userIdChefEquipe);
                    cmd.Parameters.AddWithValue("@CodeTache", codeTache);

                    try
                    {
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (rows > 0)
                        {
                            textBox1.Text = codeTache; // ✅ Affiche le code généré seulement si succès
                            MessageBox.Show("Tâche ajoutée avec succès !");
                            this.Close(); // Ferme le formulaire
                        }
                        else
                        {
                            MessageBox.Show("⚠️ La tâche n'a pas été ajoutée !");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("❌ Erreur SQL : " + ex.Message);
                    }

                }

                MessageBox.Show("Tâche ajoutée avec succès !");
                this.Close(); // Ferme le formulaire
            }
        }
        // 🔍 Méthode pour obtenir le ManagerID (chef de projet) à partir du projet
        private int GetManagerIdByProject(int projectId)
        {
            int managerId = -1;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ManagerID FROM Projects WHERE ProjectID = @ProjectID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProjectID", projectId);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        managerId = Convert.ToInt32(result);
                }
            }
            return managerId;
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

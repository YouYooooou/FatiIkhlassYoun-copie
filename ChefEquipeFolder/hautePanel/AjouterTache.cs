using FatiIkhlassYoun.NewFolder;
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
        public event EventHandler TaskAdded;
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
            if (comboProjet.SelectedValue == null || comboStatus.SelectedItem == null || string.IsNullOrEmpty(txtTitre.Text.Trim()))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.");
                return;
            }

            int projectId = (int)comboProjet.SelectedValue;
            string titre = txtTitre.Text.Trim();
            string description = txtDescription.Text.Trim();
            DateTime dateDebut = dtpDebut.Value.Date;
            DateTime dateFin = dtpFin.Value.Date;
            string statut = comboStatus.SelectedItem.ToString();
            int tempsEstime = (int)numTemps.Value;

            if (dateDebut >= dateFin)
            {
                MessageBox.Show("❌ La date de début doit être antérieure à la date limite.");
                return;
            }

            FormAuthConfirmation authForm = new FormAuthConfirmation(userIdChefEquipe, "add", 0);
            authForm.ShowDialog();

            if (authForm.DialogResult == DialogResult.OK)
            {
                if (AjouterTacheDansLaBase(projectId, titre, description, dateDebut, dateFin, statut, tempsEstime))
                {
                    // Déclencher l'événement seulement si l'ajout a réussi
                    TaskAdded?.Invoke(this, EventArgs.Empty);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("❌ Vérification annulée. L'ajout de la tâche a été annulé.");
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

        public bool AjouterTacheDansLaBase(int projectId, string titre, string description,
                                  DateTime dateDebut, DateTime dateFin,
                                  string statut, int tempsEstime)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                INSERT INTO Tasks (ProjectID, Title, Description, StartDate, DueDate, Status, EstimatedTime, TeamLeadID)
                VALUES (@ProjectID, @Title, @Description, @StartDate, @DueDate, @Status, @EstimatedTime, @TeamLeadID);
                SELECT SCOPE_IDENTITY();";

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

                        // Exécuter la commande et récupérer l'ID
                        int newTaskId = Convert.ToInt32(cmd.ExecuteScalar());

                        // Optionnel: Afficher un message de succès
                        MessageBox.Show($"✅ Tâche ajoutée avec succès. ID généré : {newTaskId}");

                        return true; // Retourne true si l'insertion a réussi
                    }
                }
            }
            catch (Exception ex)
            {
                // Afficher l'erreur (optionnel)
                MessageBox.Show($"❌ Erreur lors de l'ajout de la tâche: {ex.Message}");
                return false; // Retourne false en cas d'erreur
            }
        }


    }
}

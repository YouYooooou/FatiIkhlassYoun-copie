using FatiIkhlassYoun.NewFolder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FatiIkhlassYoun
{
    public partial class AjouterTache : Form
    {
        private string connectionString = @"Data Source=YOUNES\SQLEXPRESS;Initial Catalog=ProjectManagementSystem;Integrated Security=True";
        private int userIdChefEquipe;
        private CheckedListBox checkedListBoxMembres;

        public AjouterTache(int userId)
        {
            InitializeComponent(); // Cette méthode crée déjà la CheckedListBox via le designer
            userIdChefEquipe = userId;

            ChargerProjets();
            ChargerStatus();
            ChargerTousLesMembresEquipe();
        }
        private void ChargerTousLesMembresEquipe()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
            SELECT u.UserID, u.Username 
            FROM Users u
            INNER JOIN TeamMembers tm ON u.UserID = tm.UserID
            INNER JOIN Teams t ON tm.TeamID = t.TeamID
            WHERE t.LeaderID = @LeaderID
            ORDER BY u.Username";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@LeaderID", userIdChefEquipe);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Créez une liste pour stocker les membres
                    var membres = new List<MembreEquipe>();

                    while (reader.Read())
                    {
                        membres.Add(new MembreEquipe
                        {
                            UserID = reader.GetInt32(0),
                            Username = reader.GetString(1)
                        });
                    }

                    // Liez les données à la CheckedListBox
                    checkedListBoxMembres.DataSource = membres;
                    checkedListBoxMembres.DisplayMember = "Username";
                    checkedListBoxMembres.ValueMember = "UserID";

                    // Debug: Affichez le nombre de membres chargés
                    Debug.WriteLine($"Nombre de membres chargés: {membres.Count}");
                    if (membres.Count == 0)
                    {
                        MessageBox.Show("Aucun membre trouvé dans votre équipe. Vérifiez que:\n" +
                                      "1. Vous êtes bien chef d'équipe\n" +
                                      "2. Votre équipe a des membres\n" +
                                      "3. La requête SQL retourne des résultats");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur technique:\n{ex.Message}\n\nStack Trace:\n{ex.StackTrace}");
            }
        }
        private void ChargerProjets()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Requête corrigée pour utiliser les bons noms de colonnes
                    string query = @"SELECT ProjectID, Title AS ProjectName 
                           FROM Projects 
                           WHERE ManagerID = @ManagerID";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@ManagerID", userIdChefEquipe);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    comboProjet.DataSource = dt;
                    comboProjet.DisplayMember = "ProjectName"; // Utilisation de l'alias
                    comboProjet.ValueMember = "ProjectID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des projets: {ex.Message}");
            }
        }

        private void ChargerStatus()
        {
            // Vous pouvez soit charger depuis la base de données, soit utiliser des valeurs fixes
            comboStatus.Items.AddRange(new string[] { "En attente", "En cours"});
            comboStatus.SelectedIndex = 0; // Sélectionner le premier élément par défaut
        }

       

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            // Code pour le bouton Annuler
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        public event EventHandler TaskAdded;

        // Classe utilitaire pour faciliter le binding
        public class MembreEquipe
        {
            public int UserID { get; set; }
            public string Username { get; set; }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            List<int> membresIds = new List<int>();

            // Correction du casting ici
            foreach (var item in checkedListBoxMembres.CheckedItems)
            {
                membresIds.Add(((MembreEquipe)item).UserID);
            }

            // Validation des champs obligatoires
            if (comboProjet.SelectedValue == null || comboStatus.SelectedItem == null ||
                string.IsNullOrEmpty(txtTitre.Text.Trim()) || checkedListBoxMembres.CheckedItems.Count == 0)
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires et sélectionner au moins un membre.");
                return;
            }


            // Récupération des autres valeurs
            int projectId = (int)comboProjet.SelectedValue;
            string titre = txtTitre.Text.Trim();
            string description = txtDescription.Text.Trim();
            DateTime dateDebut = dtpDebut.Value.Date;
            DateTime dateFin = dtpFin.Value.Date;
            string statut = comboStatus.SelectedItem.ToString();
            int tempsEstime = (int)numTemps.Value;

            // Validation des dates
            if (dateDebut >= dateFin)
            {
                MessageBox.Show("❌ La date de début doit être antérieure à la date limite.");
                return;
            }

            // Confirmation d'authentification
            FormAuthConfirmation authForm = new FormAuthConfirmation(userIdChefEquipe, "add", 0);
            if (authForm.ShowDialog() == DialogResult.OK)
            {
                if (AjouterTacheDansLaBase(projectId, titre, description, dateDebut, dateFin, statut, tempsEstime, membresIds))
                {
                    TaskAdded?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public bool AjouterTacheDansLaBase(int projectId, string titre, string description,
                              DateTime dateDebut, DateTime dateFin,
                              string statut, int tempsEstime, List<int> membresIds)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Insertion de la tâche
                        string query = @"
                        INSERT INTO Tasks (ProjectID, Title, Description, StartDate, DueDate, Status, EstimatedTime, TeamLeadID)
                        VALUES (@ProjectID, @Title, @Description, @StartDate, @DueDate, @Status, @EstimatedTime, @TeamLeadID);
                        SELECT SCOPE_IDENTITY();";

                        SqlCommand cmd = new SqlCommand(query, conn, transaction);
                        cmd.Parameters.AddWithValue("@ProjectID", projectId);
                        cmd.Parameters.AddWithValue("@Title", titre);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@StartDate", dateDebut);
                        cmd.Parameters.AddWithValue("@DueDate", dateFin);
                        cmd.Parameters.AddWithValue("@Status", statut);
                        cmd.Parameters.AddWithValue("@EstimatedTime", tempsEstime);
                        cmd.Parameters.AddWithValue("@TeamLeadID", userIdChefEquipe);

                        int newTaskId = Convert.ToInt32(cmd.ExecuteScalar());

                        // Affectation des membres à la tâche
                        foreach (int membreId in membresIds)
                        {
                            string assignQuery = "INSERT INTO Task_Assignments (TaskID, UserID) VALUES (@TaskID, @UserID)";
                            cmd = new SqlCommand(assignQuery, conn, transaction);
                            cmd.Parameters.AddWithValue("@TaskID", newTaskId);
                            cmd.Parameters.AddWithValue("@UserID", membreId);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show($"✅ Tâche ajoutée avec succès. ID généré : {newTaskId}");
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"❌ Erreur lors de l'ajout de la tâche: {ex.Message}");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Erreur de connexion: {ex.Message}");
                return false;
            }
        }

        private void checkedListBoxMembres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // ... [Les autres méthodes restent inchangées] ...
    }
}
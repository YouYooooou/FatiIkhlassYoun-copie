using FatiIkhlassYoun.ChefEquipeFolder.hautePanel;
using FatiIkhlassYoun.NewFolder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace FatiIkhlassYoun
{
    public partial class ModifierTache : Form
    {
        private string connectionString = @"Data Source=YOUNES\SQLEXPRESS;Initial Catalog=ProjectManagementSystem;Integrated Security=True";
        private int userIdChefEquipe;
        private int taskId;
        private List<int> currentMemberIds = new List<int>();

        public ModifierTache(int userId, int selectedTaskId)
        {
            InitializeComponent();
            userIdChefEquipe = userId;
            taskId = selectedTaskId;
            this.Load += ModifierTache_Load;
        }

        private void ModifierTache_Load(object sender, EventArgs e)
        {
            // Remplir les statuts
            comboStatus.Items.Clear();
            comboStatus.Items.Add("En attente");
            comboStatus.Items.Add("En cours");
            comboStatus.Items.Add("Terminée");

            // Charger les données dans le bon ordre
            RemplirChampsDepuisTaskId(); // D'abord charger les membres actuels
            ChargerMembresDisponibles(); // Puis charger tous les membres

        }

        private void ChargerMembresDisponibles()
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
                    AND u.Role = 'membre'";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@LeaderID", userIdChefEquipe);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    checkedListBoxMembres.Items.Clear();

                    // Ajouter un élément de débogage
                    Debug.WriteLine($"Nombre de membres trouvés: {dt.Rows.Count}");
                    Debug.WriteLine($"Membres actuels: {string.Join(",", currentMemberIds)}");

                    foreach (DataRow row in dt.Rows)
                    {
                        int memberId = Convert.ToInt32(row["UserID"]);
                        string username = row["Username"].ToString();

                        // Créer un nouvel objet MembreEquipe
                        var membre = new MembreEquipe
                        {
                            UserID = memberId,
                            Username = username
                        };

                        // Ajouter à la CheckedListBox et cocher si présent dans currentMemberIds
                        checkedListBoxMembres.Items.Add(membre, currentMemberIds.Contains(memberId));
                    }

                    // Forcer le rafraîchissement de l'affichage
                    checkedListBoxMembres.DisplayMember = "Username";
                    checkedListBoxMembres.ValueMember = "UserID";
                    checkedListBoxMembres.Refresh();

                    // Message de débogage
                    Debug.WriteLine($"Nombre d'éléments dans CheckedListBox: {checkedListBoxMembres.Items.Count}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des membres: {ex.Message}\n\nDétails: {ex.StackTrace}");
            }
        }

        private void RemplirChampsDepuisTaskId()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Requête pour la tâche
                string taskQuery = "SELECT * FROM Tasks WHERE TaskID = @taskId";
                SqlCommand taskCmd = new SqlCommand(taskQuery, conn);
                taskCmd.Parameters.AddWithValue("@taskId", taskId);

                // Requête pour les membres affectés
                string memberQuery = "SELECT UserID FROM Task_Assignments WHERE TaskID = @taskId";
                SqlCommand memberCmd = new SqlCommand(memberQuery, conn);
                memberCmd.Parameters.AddWithValue("@taskId", taskId);

                conn.Open();

                // Remplir les champs de la tâche
                SqlDataReader taskReader = taskCmd.ExecuteReader();
                if (taskReader.Read())
                {
                    txtTitre.Text = taskReader["Title"].ToString();
                    txtDescription.Text = taskReader["Description"].ToString();
                    dtpDebut.Value = Convert.ToDateTime(taskReader["StartDate"]);
                    dtpFin.Value = Convert.ToDateTime(taskReader["DueDate"]);

                    // Gestion plus robuste du statut
                    string status = taskReader["Status"].ToString();
                    if (comboStatus.Items.Contains(status))
                    {
                        comboStatus.SelectedItem = status;
                    }

                    numTemps.Value = Convert.ToInt32(taskReader["EstimatedTime"]);
                }
                taskReader.Close();

                // Récupérer les membres actuels
                currentMemberIds.Clear();
                using (SqlDataReader memberReader = memberCmd.ExecuteReader())
                {
                    while (memberReader.Read())
                    {
                        currentMemberIds.Add(memberReader.GetInt32(0));
                    }
                }

                // Message de débogage
                Debug.WriteLine($"Membres actuels chargés: {string.Join(",", currentMemberIds)}");
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            // Récupération des membres sélectionnés
            List<int> nouveauxMembresIds = new List<int>();
            foreach (var item in checkedListBoxMembres.CheckedItems)
            {
                if (item is MembreEquipe membre)
                {
                    nouveauxMembresIds.Add(membre.UserID);
                }
            }

            // Validation des champs
            if (string.IsNullOrEmpty(txtTitre.Text.Trim()) ||
                comboStatus.SelectedItem == null ||
                nouveauxMembresIds.Count == 0)
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires et sélectionner au moins un membre.");
                return;
            }

            // Récupération des valeurs
            string titre = txtTitre.Text.Trim();
            string description = txtDescription.Text.Trim();
            DateTime dateDebut = dtpDebut.Value.Date;
            DateTime dateFin = dtpFin.Value.Date;
            string statut = comboStatus.SelectedItem.ToString();
            int tempsEstime = (int)numTemps.Value;

            // Validation des dates
            if (dateDebut >= dateFin)
            {
                MessageBox.Show("La date de début doit être antérieure à la date limite.");
                return;
            }

            // Confirmation d'authentification
            FormAuthConfirmation authForm = new FormAuthConfirmation(userIdChefEquipe, "update", taskId);
            if (authForm.ShowDialog() == DialogResult.OK)
            {
                ModifierTacheDansLaBase(titre, description, dateDebut, dateFin, statut, tempsEstime, nouveauxMembresIds);
            }
        }

        private void ModifierTacheDansLaBase(string titre, string description,
                                           DateTime dateDebut, DateTime dateFin,
                                           string statut, int tempsEstime,
                                           List<int> nouveauxMembresIds)
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
                        string taskQuery = @"
                        UPDATE Tasks
                        SET Title = @Title,
                            Description = @Description,
                            StartDate = @StartDate,
                            DueDate = @DueDate,
                            Status = @Status,
                            EstimatedTime = @EstimatedTime
                        WHERE TaskID = @TaskID";

                        SqlCommand taskCmd = new SqlCommand(taskQuery, conn, transaction);
                        taskCmd.Parameters.AddWithValue("@Title", titre);
                        taskCmd.Parameters.AddWithValue("@Description", description);
                        taskCmd.Parameters.AddWithValue("@StartDate", dateDebut);
                        taskCmd.Parameters.AddWithValue("@DueDate", dateFin);
                        taskCmd.Parameters.AddWithValue("@Status", statut);
                        taskCmd.Parameters.AddWithValue("@EstimatedTime", tempsEstime);
                        taskCmd.Parameters.AddWithValue("@TaskID", taskId);
                        taskCmd.ExecuteNonQuery();

                        // 2. Mettre à jour les affectations
                        // Supprimer les anciennes affectations
                        string deleteQuery = "DELETE FROM Task_Assignments WHERE TaskID = @TaskID";
                        SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn, transaction);
                        deleteCmd.Parameters.AddWithValue("@TaskID", taskId);
                        deleteCmd.ExecuteNonQuery();

                        // Ajouter les nouvelles affectations
                        foreach (int membreId in nouveauxMembresIds)
                        {
                            string insertQuery = "INSERT INTO Task_Assignments (TaskID, UserID) VALUES (@TaskID, @UserID)";
                            SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction);
                            insertCmd.Parameters.AddWithValue("@TaskID", taskId);
                            insertCmd.Parameters.AddWithValue("@UserID", membreId);
                            insertCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Tâche modifiée avec succès !");
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

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Classe utilitaire pour le binding
        public class MembreEquipe
{
    public int UserID { get; set; }
    public string Username { get; set; }

    public override string ToString()
    {
        return Username;
    }

    public override bool Equals(object obj)
    {
        if (obj is MembreEquipe other)
        {
            return this.UserID == other.UserID;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return UserID.GetHashCode();
    }
}

    }
}
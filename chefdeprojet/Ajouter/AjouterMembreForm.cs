using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AjouterMembreForm : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementSystem"].ConnectionString;
        public AjouterMembreForm()
        {
            InitializeComponent();
            RemplirComboEquipes();
            RemplirComboTaches();
        }

        private void AjouterMembreForm_Load(object sender, EventArgs e)
        {
            // Exemple de remplissage dynamique d'une ComboBox pour les rôles
            comboRole.Items.Add("Membre");
            comboRole.Items.Add("ChefEquipe");
            comboRole.SelectedIndex = 0;
        }

        private void RemplirComboEquipes()
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();
                string query = "SELECT TeamID, Name FROM Teams";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboEquipe.Items.Add(new ComboBoxItem
                    {
                        Text = reader["Name"].ToString(),
                        Value = reader["TeamID"]
                    });
                }
            }
        }

        private void RemplirComboTaches()
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();
                string query = "SELECT TaskID, Title FROM Tasks";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboTache.Items.Add(new ComboBoxItem
                    {
                        Text = reader["Title"].ToString(),
                        Value = reader["TaskID"]
                    });
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string phone = txtPhone.Text.Trim();
            string role = comboRole.SelectedItem?.ToString();

            // ✅ Validation de l'e-mail
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Adresse email invalide !");
                return;
            }

            // ✅ Validation du numéro marocain
            if (!Regex.IsMatch(phone, @"^(06|07)[0-9]{8}$"))
            {
                MessageBox.Show("Numéro de téléphone marocain invalide !");
                return;
            }

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.");
                return;
            }

            string hashedPassword = HashPassword(password);

            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();

                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    // ✅ Insérer dans Users
                    string insertUserQuery = @"
INSERT INTO Users (Username, Password, Email, Role, IsActive, Phone)
VALUES (@Username, @Password, @Email, @Role, 1, @Phone);
SELECT SCOPE_IDENTITY();
";
                    SqlCommand cmdUser = new SqlCommand(insertUserQuery, con, transaction);
                    cmdUser.Parameters.AddWithValue("@Username", username);
                    cmdUser.Parameters.AddWithValue("@Password", hashedPassword);
                    cmdUser.Parameters.AddWithValue("@Email", email);
                    cmdUser.Parameters.AddWithValue("@Role", role);
                    cmdUser.Parameters.AddWithValue("@Phone", phone);

                    int userId = Convert.ToInt32(cmdUser.ExecuteScalar());

                    // ✅ Récupérer les IDs sélectionnés
                    int teamId = (int)((ComboBoxItem)comboEquipe.SelectedItem).Value;
                    int taskId = (int)((ComboBoxItem)comboTache.SelectedItem).Value;
                    DateTime dateAffectation = dateAffectationPicker.Value;

                    // ✅ Insérer dans TeamMembers
                    string insertTeamMemberQuery = @"INSERT INTO TeamMembers (UserID, TeamID, AssignedDate, Role)
                 VALUES (@UserID, @TeamID, @AssignedDate, @Role); ";

                    SqlCommand cmdMember = new SqlCommand(insertTeamMemberQuery, con, transaction);
                    cmdMember.Parameters.AddWithValue("@UserID", userId);
                    cmdMember.Parameters.AddWithValue("@TeamID", teamId);
                    cmdMember.Parameters.AddWithValue("@AssignedDate", dateAffectation);
                    cmdMember.Parameters.AddWithValue("@Role", role);

                    cmdMember.ExecuteNonQuery();

                    // ✅ Vérifier si une tâche a été sélectionnée
                    if (taskId > 0)
                    {
                        // ✅ Vérification que la tâche n'a pas déjà été assignée à ce membre
                        string checkAssignmentQuery = "SELECT COUNT(*) FROM Task_Assignments WHERE TaskID = @TaskID AND UserID = @UserID";
                        SqlCommand cmdCheckAssignment = new SqlCommand(checkAssignmentQuery, con, transaction);
                        cmdCheckAssignment.Parameters.AddWithValue("@TaskID", taskId);
                        cmdCheckAssignment.Parameters.AddWithValue("@UserID", userId);
                        int count = (int)cmdCheckAssignment.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Cette tâche est déjà assignée à ce membre.");
                        }
                        else
                        {
                            // ✅ Insérer dans Task_Assignments pour affecter la tâche au membre spécifié
                            string insertAssignmentQuery = @"INSERT INTO Task_Assignments (TaskID, UserID, Progression)
                 VALUES (@TaskID, @UserID, @Progression)";

                            SqlCommand cmdAssign = new SqlCommand(insertAssignmentQuery, con, transaction);
                            cmdAssign.Parameters.AddWithValue("@TaskID", taskId);
                            cmdAssign.Parameters.AddWithValue("@UserID", userId);

                            // Définir la progression en fonction du statut de la tâche
                            string getStatusQuery = "SELECT Status FROM Tasks WHERE TaskID = @TaskID";
                            SqlCommand cmdStatus = new SqlCommand(getStatusQuery, con, transaction);
                            cmdStatus.Parameters.AddWithValue("@TaskID", taskId);
                            string status = cmdStatus.ExecuteScalar()?.ToString();

                            int progression = 0;
                            if (status == "En attente") progression = 0;
                            else if (status == "En cours") progression = 50;
                            else if (status == "Terminée") progression = 100;

                            cmdAssign.Parameters.AddWithValue("@Progression", progression);
                            cmdAssign.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Membre ajouté et tâche affectée avec succès !");
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }



        // Méthode pour hasher le mot de passe
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }

        // Méthode pour valider l'email
        private bool EmailValide(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Méthode pour valider le numéro marocain
        private bool NumeroMarocainValide(string phone)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phone, @"^(\+212|0)(\d{9})$");
        }

        // Méthode pour vider les champs après ajout
        private void ViderChamps()
        {
            txtUsername.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            comboEquipe.SelectedIndex = -1;
            comboRole.SelectedIndex = 0;
            comboTache.SelectedIndex = -1;
        }

        // Classe pour gérer les éléments du ComboBox (Equipe et Tâches)
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        private void AffecterTacheAMembre(int userId, int taskId)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();

                try
                {
                    string getStatusQuery = "SELECT Status FROM Tasks WHERE TaskID = @TaskID";
                    SqlCommand cmdStatus = new SqlCommand(getStatusQuery, con);
                    cmdStatus.Parameters.AddWithValue("@TaskID", taskId);
                    string status = cmdStatus.ExecuteScalar()?.ToString();

                    if (status == null)
                    {
                        MessageBox.Show("Tâche introuvable.");
                        return;
                    }

                    string checkQuery = "SELECT COUNT(*) FROM Task_Assignments WHERE TaskID = @TaskID AND UserID = @UserID";
                    SqlCommand cmdCheck = new SqlCommand(checkQuery, con);
                    cmdCheck.Parameters.AddWithValue("@TaskID", taskId);
                    cmdCheck.Parameters.AddWithValue("@UserID", userId);
                    int count = (int)cmdCheck.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Tâche déjà affectée à ce membre.");
                        return;
                    }

                    int progression = 0;
                    if (status == "En attente") progression = 0;
                    else if (status == "En cours") progression = 50;
                    else if (status == "Terminée") progression = 100;

                    string insertQuery = @"INSERT INTO Task_Assignments (TaskID, UserID, Progression)
                                   VALUES (@TaskID, @UserID, @Progression)";
                    SqlCommand cmdInsert = new SqlCommand(insertQuery, con);
                    cmdInsert.Parameters.AddWithValue("@TaskID", taskId);
                    cmdInsert.Parameters.AddWithValue("@UserID", userId);
                    cmdInsert.Parameters.AddWithValue("@Progression", progression);
                    cmdInsert.ExecuteNonQuery();

                    MessageBox.Show("Tâche affectée avec succès !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void comboTache_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
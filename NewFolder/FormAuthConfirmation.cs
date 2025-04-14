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
    public partial class FormAuthConfirmation : Form
    {
        private int userIdChefEquipe;  // 🔄 Charger les projets dans le ComboBox
        private string action;
        private int taskId;
        public FormAuthConfirmation(int userId, string actionType, int taskId)
        {
            InitializeComponent();
            userIdChefEquipe = userId;
            action = actionType;
            this.taskId = taskId;
        }
        private string connectionString = @"Data Source=YOUNES\SQLEXPRESS;Initial Catalog=ProjectManagementSystem;Integrated Security=True";



      
        

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Veuillez entrer votre nom d'utilisateur et mot de passe.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users WHERE Username = @Username AND PasswordHash = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@PasswordHash", password); // Assure-toi de hasher le mot de passe en production

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int userId = (int)reader["UserID"];
                    if (userId == userIdChefEquipe) // Vérifie si l'utilisateur correspond à celui qui est connecté
                    {
                        MessageBox.Show("Identité vérifiée avec succès !");
                        // 1. Générer un code à 6 chiffres
                        Random rnd = new Random();
                        int codeVerification = rnd.Next(100000, 999999);

                        // 2. Stocker ce code dans une variable statique ou passer à un autre formulaire
                        CodeVerificationManager.Code = codeVerification;

                        // 3. Récupérer l'email depuis la base de données
                        string email = reader["Email"].ToString(); // Assure-toi que le champ "Email" existe

                        // 4. Envoyer le mail
                        EnvoyerEmailVerification(email, codeVerification);

                        // 5. Ouvrir le formulaire de vérification du code
                        FormCodeVerification codeForm = new FormCodeVerification(codeVerification, action, taskId);
                        codeForm.ShowDialog();

                        if (codeForm.IsCodeValid)
                        {
                            if (action == "delete")
                            {
                                SupprimerTacheDeLaBase(taskId);
                            }
                            // Tu peux ajouter ici d'autres actions si besoin ("add", "update", etc.)
                        }
                        else
                        {
                            MessageBox.Show("Action annulée : code incorrect.");
                        }

                        this.Close(); // Ferme le formulaire d'authentification
                                      // Procède à l'action (ajouter, modifier, supprimer)
                                      // Par exemple, appeler la méthode de suppression ici
                    }
                    else
                    {
                        MessageBox.Show("L'utilisateur ou le mot de passe est incorrect.");
                    }
                }
                else
                {
                    MessageBox.Show("L'utilisateur ou le mot de passe est incorrect.");
                }
            }
        }

        private void EnvoyerEmailVerification(string email, int code)
        {
            try
            {
                System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential("tonemail@gmail.com", "tonmotdepasse"); // ⚠️ Crée un mot de passe d'application

                System.Net.Mail.MailMessage mailMessage = new System.Net.Mail.MailMessage();
                mailMessage.From = new System.Net.Mail.MailAddress("tonemail@gmail.com");
                mailMessage.To.Add(email);
                mailMessage.Subject = "Code de vérification";
                mailMessage.Body = $"Votre code de vérification est : {code}";

                client.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'envoi de l'e-mail : " + ex.Message);
            }
        }

        private void SupprimerTacheDeLaBase(int taskId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Tasks WHERE TaskID = @TaskID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TaskID", taskId);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Tâche supprimée avec succès.");
                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression de la tâche.");
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close(); // Ferme le formulaire sans rien faire
        }

    }
}

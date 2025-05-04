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
using System.Security.Cryptography;
using System.Text;
using FatiIkhlassYoun.ChefEquipeFolder.hautePanel;

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




        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convertir le mot de passe en tableau de bytes
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convertir le tableau de bytes en une chaîne hexadécimale
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string hashedPassword = HashPassword(password);
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Veuillez entrer votre nom d'utilisateur et mot de passe.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users WHERE UserID = @UserID AND PasswordHash = @PasswordHash";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userIdChefEquipe); // On utilise directement l'ID de l'utilisateur connecté
                cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);


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
                        EnvoyerEmailVerification(email, codeVerification.ToString());

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
                            else if (action == "add")
                            {
                                // ✅ Retourne au formulaire parent avec succès
                                this.DialogResult = DialogResult.OK;
                            }
                            else if (action == "update")
                            {
                                this.DialogResult = DialogResult.OK;
                            }
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Action annulée : code incorrect.");
                            this.DialogResult = DialogResult.Cancel;
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

        private void EnvoyerEmailVerification(string email, string code)
        {
            try
            {
                System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential("extrosyounes2018@gmail.com", "frsurxsftwoyuuzh");

                System.Net.Mail.MailMessage mailMessage = new System.Net.Mail.MailMessage();
                mailMessage.From = new System.Net.Mail.MailAddress("extrosyounes2018@gmail.com");
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
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.WhiteSmoke;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.WhiteSmoke;
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            this.Close(); // Ferme le formulaire sans rien faire
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

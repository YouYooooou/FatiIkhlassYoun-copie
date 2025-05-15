using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using FatiIkhlassYoun.ChefEquipeFolder.hautePanel;
using FatiIkhlassYoun.membreFolder;
using System.Configuration; 
namespace FatiIkhlassYoun.NewFolder
{
    public partial class FormAuthConfirmation : Form
    {
        private int userId;
        private string userRole;
        private string action;
        private int taskId;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementSystem"].ConnectionString;

        public FormAuthConfirmation(int userId, string userRole, string actionType, int taskId)
        {
            InitializeComponent();
            this.userId = userId;
            this.userRole = userRole;
            this.action = actionType;
            this.taskId = taskId;

            // Personnaliser le titre selon le rôle
            lblTitle.Text = userRole == "chef_equipe" ?
                "Authentification Chef d'Équipe" :
                "Authentification Membre";
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
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
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string dbRole = reader["Role"].ToString();
                    if (dbRole != userRole) // Vérification générique du rôle
                    {
                        MessageBox.Show("Vous n'avez pas les permissions nécessaires.");
                        return;
                    }

                    // Génération et envoi du code
                    Random rnd = new Random();
                    int codeVerification = rnd.Next(100000, 999999);
                    CodeVerificationManager.Code = codeVerification;
                    string email = reader["Email"].ToString();

                    EnvoyerEmailVerification(email, codeVerification.ToString());

                    // Formulaire de vérification du code
                    using (FormCodeVerification codeForm = new FormCodeVerification(codeVerification, action, taskId))
                    {
                        if (codeForm.ShowDialog() == DialogResult.OK && codeForm.IsCodeValid)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
                }
            }
        }

        private void FermerFormulaireParent()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (userRole == "chef_equipe" && form is ModifierTache)
                {
                    form.DialogResult = DialogResult.OK;
                    form.Close();
                    break;
                }
                else if (userRole == "membre" && form is formModfTacheMembre)
                {
                    form.DialogResult = DialogResult.OK;
                    form.Close();
                    break;
                }
            }
        }

        private void RetourAuDashboard()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (userRole == "chef_equipe" && form is MenuDeChefEquipe)
                {
                    form.Show();
                    form.BringToFront();
                    ((MenuDeChefEquipe)form).LoadContent(new DashboardControl());
                    break;
                }
                else if (userRole == "membre" && form is MenudeMembre)
                {
                    form.Show();
                    form.BringToFront();
                    ((MenudeMembre)form).LoadContent(new ctrlMembre());
                    break;
                }
            }
        }

        private void EnvoyerEmailVerification(string email, string code)
        {
            try
            {
                var client = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587)
                {
                    EnableSsl = true,
                    Credentials = new System.Net.NetworkCredential("extrosyounes2018@gmail.com", "frsurxsftwoyuuzh")
                };

                var mailMessage = new System.Net.Mail.MailMessage
                {
                    From = new System.Net.Mail.MailAddress("extrosyounes2018@gmail.com", "Project Management System"),
                    Subject = "Votre code de vérification - Système de Gestion de Projets",
                    IsBodyHtml = true,
                    Body = $@"
                <html>
                    <head>
                        <style>
                            body {{ font-family: Arial, sans-serif; line-height: 1.6; color: #333; }}
                            .container {{ max-width: 600px; margin: 0 auto; padding: 20px; }}
                            .header {{ background-color: #4a6baf; color: white; padding: 10px 20px; text-align: center; }}
                            .content {{ padding: 20px; background-color: #f9f9f9; }}
                            .code {{ font-size: 24px; font-weight: bold; color: #4a6baf; text-align: center; margin: 20px 0; }}
                            .footer {{ margin-top: 20px; font-size: 12px; color: #777; text-align: center; }}
                            .button {{ background-color: #4a6baf; color: white; padding: 10px 20px; text-decoration: none; border-radius: 5px; display: inline-block; }}
                        </style>
                    </head>
                    <body>
                        <div class='container'>
                            <div class='header'>
                                <h2>Vérification de sécurité</h2>
                            </div>
                            <div class='content'>
                                <p>Bonjour,</p>
                                <p>Une action nécessitant une vérification de sécurité a été initiée sur votre compte.</p>
                                
                                <p>Voici votre code de vérification :</p>
                                <div class='code'>{code}</div>
                                
                                <p>Ce code est valable pendant 10 minutes. Ne le partagez avec personne.</p>
                                
                                <p>Si vous n'avez pas initié cette action, veuillez contacter immédiatement l'administrateur du système.</p>
                                
                                <p>Cordialement,<br>L'équipe Project Management System</p>
                            </div>
                            <div class='footer'>
                                <p>Cet email a été envoyé automatiquement. Merci de ne pas y répondre.</p>
                                <p>© {DateTime.Now.Year} Project Management System. Tous droits réservés.</p>
                            </div>
                        </div>
                    </body>
                </html>"
                };

                mailMessage.To.Add(email);

                // Ajout d'une version texte alternative pour les clients mail ne supportant pas HTML
                var plainTextView = System.Net.Mail.AlternateView.CreateAlternateViewFromString(
                    $"Code de vérification\n\n" +
                    $"Bonjour,\n\n" +
                    $"Une action nécessitant une vérification de sécurité a été initiée sur votre compte.\n\n" +
                    $"Voici votre code de vérification : {code}\n\n" +
                    $"Ce code est valable pendant 10 minutes. Ne le partagez avec personne.\n\n" +
                    $"Si vous n'avez pas initié cette action, veuillez contacter immédiatement l'administrateur du système.\n\n" +
                    $"Cordialement,\n" +
                    $"L'équipe Project Management System",
                    null, "text/plain");

                mailMessage.AlternateViews.Add(plainTextView);

                // Envoi asynchrone pour ne pas bloquer l'interface utilisateur
                Task.Run(() => client.Send(mailMessage));

                // Optionnel: journalisation
                Console.WriteLine($"Email de vérification envoyé à {email}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'envoi de l'e-mail : " + ex.Message);
                // Journalisation de l'erreur
                Console.WriteLine($"Erreur d'envoi d'email: {ex}");
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Méthodes pour l'interface
        private void txtUsername_Enter(object sender, EventArgs e) => txtUsername.BackColor = Color.White;
        private void txtUsername_Leave(object sender, EventArgs e) => txtUsername.BackColor = Color.WhiteSmoke;
        private void txtPassword_Enter(object sender, EventArgs e) => txtPassword.BackColor = Color.White;
        private void txtPassword_Leave(object sender, EventArgs e) => txtPassword.BackColor = Color.WhiteSmoke;
    }

    public static class CodeVerificationManager
    {
        public static int Code { get; set; }
    }
}
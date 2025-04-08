using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace FatiIkhlassYoun
{
    public partial class FormMotDePasseOublie : Form
    {
        public FormMotDePasseOublie()
        {
            InitializeComponent();
        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Veuillez entrer votre email.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Paramètres de l'envoi d'email
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("fatimazahrabendoukali2@gmail.com"); 
                mail.To.Add(email);
                mail.Subject = "Réinitialisation de votre mot de passe";
                mail.Body = "Cliquez sur ce lien pour réinitialiser votre mot de passe : ";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("fatimazahrabendoukali2@gmail.com", "yfxu enxi ioos yxem");
                smtp.EnableSsl = true;
                smtp.Send(mail);

                MessageBox.Show("Email envoyé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'envoi de l'email : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


        }
        private void label2_Click(object sender, EventArgs e)
        {
           
        }
    }

    }


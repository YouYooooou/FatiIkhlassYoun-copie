using CuoreUI.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FatiIkhlassYoun
{
    public partial class formAuthentification : Form
    {
        private string action; // Stocke l'action pour l'utiliser plus tard

        // Constructeur sans paramètre requis pour le Designer
        public formAuthentification()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(30, 42, 56);


        }

        // Constructeur avec paramètre qui réutilise le premier
        public formAuthentification(string action) : this()
        {
            this.action = action; // Assigne l'action à la variable
            MessageBox.Show($"Fenêtre d'authentification ouverte pour : {action}");
        }


        private void formAuthentification_Load(object sender, EventArgs e)
        {

        }

        private void cuiBorder1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cuiCheckbox1_Click(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textPass.Text.Trim();
            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Authentification réussie !");
                this.DialogResult = DialogResult.OK; // Ferme le formulaire avec succès
                this.Close();
            }
            else
            {
                lblMessage.Text = "Nom d'utilisateur ou mot de passe incorrect !";
            }
        }

        private void cuiCheckbox2_Click(object sender, EventArgs e)
        {

            if(textPass.PasswordChar == '●') // Remplace par '*' si besoin
            {
                textPass.PasswordChar = '\0'; // Afficher le texte
            }
            else
            {
                textPass.PasswordChar = '●'; // Remettre le masque
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


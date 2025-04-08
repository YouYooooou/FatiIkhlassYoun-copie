namespace FatiIkhlassYoun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cuiTextBox21_ContentChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userNameTxtBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void passwordTxtBox_ContentChanged(object sender, EventArgs e)
        {

        }
        private void cuiButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showPassbtn_Click(object sender, EventArgs e)
        {
            // Vérifier si le mot de passe est actuellement masqué
            if (textBox2.PasswordChar == '●') // Remplace par '*' si besoin
            {
                textBox2.PasswordChar = '\0'; // Afficher le texte
            }
            else
            {
                textBox2.PasswordChar = '●'; // Remettre le masque
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Vérification des identifiants (remplace par ta vraie logique)
            bool isAuthenticated = true; // Exemple : vérifie les credentials

            if (isAuthenticated)
            {
                // Ouvre le Menu
                MenuDeApp menu = new MenuDeApp();
                menu.Show();

                // Cacher la fenêtre de login
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect !");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            FormMotDePasseOublie formMdp = new FormMotDePasseOublie();
            formMdp.ShowDialog(); 
        }
    }
}

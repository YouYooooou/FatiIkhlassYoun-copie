using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using FatiIkhlassYoun.ChefEquipeFolder.hautePanel;

namespace FatiIkhlassYoun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(GetBtnForgotPassword());
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
            if (textBox2.PasswordChar == '●')
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '●';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = HashPassword(textBox2.Text.Trim());

            string connectionString = @"Data Source=YOUNES\SQLEXPRESS;Initial Catalog=ProjectManagementSystem;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
            SELECT UserID, Username, Role 
            FROM Users 
            WHERE Username COLLATE SQL_Latin1_General_CP1_CS_AS = @username 
            AND PasswordHash COLLATE SQL_Latin1_General_CP1_CS_AS = @password 
            AND IsActive = 1";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                    if (reader.Read())
                    {
                        // 🧠 On remplit la session avec les données du user connecté
                        SessionUtilisateur.UserID = Convert.ToInt32(reader["UserID"]);
                        SessionUtilisateur.Username = reader["Username"].ToString();
                        SessionUtilisateur.Role = reader["Role"].ToString();

                        reader.Close();

                        // 👨‍💼 On ouvre le menu correspondant au rôle
                        if (SessionUtilisateur.Role == "chef_equipe")
                        {
                            MenuDeChefEquipe menu = new MenuDeChefEquipe();
                            menu.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Votre rôle n'est pas autorisé à accéder à cette interface.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la connexion : " + ex.Message);
                }
            }

        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2")); // Conversion en hexa
                }
                return builder.ToString();
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

        

        private void labelTitre_Click(object sender, EventArgs e)
        {

        }
    }
}

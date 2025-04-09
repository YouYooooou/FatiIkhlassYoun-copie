using System.Data.SqlClient;
using System.Data;
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
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            //---------------------------                                  ---------------------------
            //---------------------------                                  ---------------------------
            //---------------------------                                  ---------------------------
            //---------------------------                                  ---------------------------
            //---------------------------                                  ---------------------------
            string connectionString = @"Data Source=YOUNES\SQLEXPRESS;Initial Catalog=ProjectManagementSystem;Integrated Security=True";
            //---------------------------                                  ---------------------------
            //---------------------------                                  ---------------------------
            //---------------------------                                  ---------------------------
            //---------------------------                                  ---------------------------
            //---------------------------                                  ---------------------------

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                            SELECT * 
                            FROM Users 
                            WHERE Username COLLATE SQL_Latin1_General_CP1_CS_AS = @username 
                            AND PasswordHash COLLATE SQL_Latin1_General_CP1_CS_AS = @password 
                            AND IsActive = 1";


                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password); // à sécuriser plus tard

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read()) // ⚠️ ici on consomme le reader correctement
                    {
                        string role = reader["Role"].ToString();

                        reader.Close(); // très important de fermer le reader avant d’ouvrir une nouvelle form

                        // Authentification réussie
                        MenuDeApp menu = new MenuDeApp();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la connexion : " + ex.Message);
                }
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

        private void cuiBorder1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

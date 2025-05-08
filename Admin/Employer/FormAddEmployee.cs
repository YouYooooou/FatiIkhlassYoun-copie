using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Configuration;
namespace FatiIkhlassYoun
{
    public partial class FormAddEmployee : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementSystem"].ConnectionString;

        public FormAddEmployee()
        {
            InitializeComponent();
        }

        // ✅ Fonction de hachage SHA256
        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void FormAddEmployee_Load(object sender, EventArgs e)
        {
            if (cmbRole.Items.Count == 0)
            {
                cmbRole.Items.Add("membre");
                cmbRole.Items.Add("chef_equipe");
                cmbRole.Items.Add("chef_projet");
                cmbRole.Items.Add("admin");

                cmbRole.SelectedIndex = 0;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string rawPassword = txtPassword.Text.Trim();
            string password = ComputeSha256Hash(rawPassword);
            string email = txtEmail.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString();
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Veuillez sélectionner un rôle.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Vérification si Username ou Email existe déjà
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username OR Email = @Email";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Username", username);
                    checkCmd.Parameters.AddWithValue("@Email", email);

                    int userCount = (int)checkCmd.ExecuteScalar();
                    if (userCount > 0)
                    {
                        MessageBox.Show("Un utilisateur avec ce nom ou cet email existe déjà.");
                        return;
                    }
                }

                // Insertion
                string insertQuery = "INSERT INTO Users (Username, PasswordHash, Email, Role, PhoneNumber) " +
                                     "VALUES (@Username, @PasswordHash, @Email, @Role, @PhoneNumber)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@Username", username);
                    insertCmd.Parameters.AddWithValue("@PasswordHash", password);
                    insertCmd.Parameters.AddWithValue("@Email", email);
                    insertCmd.Parameters.AddWithValue("@Role", role);
                    insertCmd.Parameters.AddWithValue("@PhoneNumber", phone);

                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("Employé ajouté avec succès !");
                    this.Close();
                }
            }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Facultatif : tu peux mettre du code ici si besoin
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


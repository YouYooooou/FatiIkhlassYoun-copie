using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Configuration;
using FatiIkhlassYoun.NewFolder;
using System.Windows.Forms;

namespace FatiIkhlassYoun
{
    public partial class FormAddEmployee : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementSystem"].ConnectionString;
        private int currentUserId;

        public FormAddEmployee(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

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
                cmbRole.Items.AddRange(new[] { "membre", "chef_equipe", "chef_projet", "admin" });
                cmbRole.SelectedIndex = 0;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!ValiderFormulaire())
                return;

            // Récupération des valeurs du formulaire
            string username = txtUsername.Text.Trim();
            string rawPassword = txtPassword.Text.Trim();
            string email = txtEmail.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString();
            string phone = txtPhone.Text.Trim();

            // Authentification en deux étapes
            FormAuthConfirmation authForm = new FormAuthConfirmation(
                currentUserId,
                "admin",  // Rôle requis
                "add_employee",
                0);

            if (authForm.ShowDialog() == DialogResult.OK)
            {
                // Seulement si l'authentification est réussie
                AjouterEmploye(username, ComputeSha256Hash(rawPassword), email, role, phone);
            }
        }

        private bool ValiderFormulaire()
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                MessageBox.Show("Le nom d'utilisateur est obligatoire");
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("Le mot de passe est obligatoire");
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                MessageBox.Show("L'email est obligatoire");
                return false;
            }
            if (cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un rôle");
                return false;
            }
            return true;
        }

        private void AjouterEmploye(string username, string password, string email, string role, string phone)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Vérification des doublons
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username OR Email = @Email";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn, transaction))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", username);
                        checkCmd.Parameters.AddWithValue("@Email", email);

                        if ((int)checkCmd.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("Un utilisateur avec ce nom ou cet email existe déjà.");
                            transaction.Rollback();
                            return;
                        }
                    }

                    // Insertion
                    string insertQuery = @"INSERT INTO Users 
                        (Username, PasswordHash, Email, Role, PhoneNumber, IsActive, CreatedBy, CreationDate) 
                        VALUES 
                        (@Username, @PasswordHash, @Email, @Role, @PhoneNumber, 1, @CreatedBy, GETDATE())";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction))
                    {
                        insertCmd.Parameters.AddWithValue("@Username", username);
                        insertCmd.Parameters.AddWithValue("@PasswordHash", password);
                        insertCmd.Parameters.AddWithValue("@Email", email);
                        insertCmd.Parameters.AddWithValue("@Role", role);
                        insertCmd.Parameters.AddWithValue("@PhoneNumber", phone);
                        insertCmd.Parameters.AddWithValue("@CreatedBy", currentUserId);

                        int rowsAffected = insertCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            transaction.Commit();
                            MessageBox.Show("Employé ajouté avec succès !");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Erreur lors de l'ajout : {ex.Message}");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
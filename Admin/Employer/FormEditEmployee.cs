using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Configuration;
namespace FatiIkhlassYoun
{
    public partial class FormEditEmployee : Form
    {
        private readonly int _userId;
        private string connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementSystem"].ConnectionString;

        public FormEditEmployee(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void FormEditEmployee_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void LoadUserData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Username, Email, Role, IsActive, PhoneNumber FROM Users WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", _userId);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtUsername.Text = reader["Username"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                        cbRole.SelectedItem = reader["Role"].ToString();
                        chkActive.Checked = Convert.ToBoolean(reader["IsActive"]);
                        txtPhone.Text = reader["PhoneNumber"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors du chargement des données: {ex.Message}");
                }
            }

            // Configurer les rôles (identique à FormAddEmployee)
            if (cbRole.Items.Count == 0)
            {
                cbRole.Items.AddRange(new object[] { "membre", "chef_equipe", "chef_projet", "admin" });
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string oldPassword = txtOldPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string role = cbRole.SelectedItem?.ToString();
            bool isActive = chkActive.Checked;

            if (!ValidateInput(username, oldPassword, newPassword, confirmPassword, role))
                return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Vérifier l'ancien mot de passe si on veut le changer
                    if (!string.IsNullOrEmpty(newPassword))
                    {
                        if (!VerifyOldPassword(conn, transaction, oldPassword))
                        {
                            MessageBox.Show("Ancien mot de passe incorrect");
                            return;
                        }
                    }

                    // Mettre à jour les informations de base
                    string updateQuery = @"UPDATE Users SET 
                                        Username = @Username,
                                        Role = @Role,
                                        IsActive = @IsActive,
                                        PhoneNumber = @PhoneNumber
                                        WHERE UserID = @UserID";

                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction);
                    updateCmd.Parameters.AddWithValue("@Username", username);
                    updateCmd.Parameters.AddWithValue("@Role", role);
                    updateCmd.Parameters.AddWithValue("@IsActive", isActive);
                    updateCmd.Parameters.AddWithValue("@PhoneNumber", phone);
                    updateCmd.Parameters.AddWithValue("@UserID", _userId);
                    updateCmd.ExecuteNonQuery();

                    // Mettre à jour le mot de passe si nécessaire
                    if (!string.IsNullOrEmpty(newPassword))
                    {
                        string newHash = ComputeSha256Hash(newPassword);
                        string pwdQuery = "UPDATE Users SET PasswordHash = @PasswordHash WHERE UserID = @UserID";
                        SqlCommand pwdCmd = new SqlCommand(pwdQuery, conn, transaction);
                        pwdCmd.Parameters.AddWithValue("@PasswordHash", newHash);
                        pwdCmd.Parameters.AddWithValue("@UserID", _userId);
                        pwdCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Modifications enregistrées avec succès");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Erreur lors de la mise à jour: {ex.Message}");
                }
            }
        }

        private bool VerifyOldPassword(SqlConnection conn, SqlTransaction transaction, string oldPassword)
        {
            string query = "SELECT PasswordHash FROM Users WHERE UserID = @UserID";
            SqlCommand cmd = new SqlCommand(query, conn, transaction);
            cmd.Parameters.AddWithValue("@UserID", _userId);

            string storedHash = cmd.ExecuteScalar()?.ToString();
            string enteredHash = ComputeSha256Hash(oldPassword);

            return storedHash == enteredHash;
        }

        private bool ValidateInput(string username, string oldPassword, string newPassword,
                                 string confirmPassword, string role)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Le nom d'utilisateur est requis");
                return false;
            }

            // Validation mot de passe seulement si on veut le changer
            if (!string.IsNullOrWhiteSpace(newPassword))
            {
                if (string.IsNullOrWhiteSpace(oldPassword))
                {
                    MessageBox.Show("Vous devez entrer l'ancien mot de passe pour le changer");
                    return false;
                }

                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Les nouveaux mots de passe ne correspondent pas");
                    return false;
                }

                if (newPassword.Length < 6)
                {
                    MessageBox.Show("Le mot de passe doit contenir au moins 6 caractères");
                    return false;
                }
            }

            if (string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Veuillez sélectionner un rôle");
                return false;
            }

            return true;
        }

        // Identique à FormAddEmployee
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
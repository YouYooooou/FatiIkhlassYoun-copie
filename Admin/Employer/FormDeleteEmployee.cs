using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;             
namespace FatiIkhlassYoun
{
    public partial class FormDeleteEmployee : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementSystem"].ConnectionString;

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        public FormDeleteEmployee()
        {
            InitializeComponent();
            this.connectionString = ConfigurationManager.ConnectionStrings["cnx"].ConnectionString;
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            cmbEmployees.Items.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT UserID, Username FROM Users WHERE IsActive = 1", con);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbEmployees.Items.Add(new ComboboxItem
                        {
                            Value = reader.GetInt32(0),
                            Text = reader.GetString(1)
                        });
                    }
                }
            }
        }

        private bool IsEmployeeLeader(int employeeId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmdTeam = new SqlCommand(
                    "SELECT COUNT(*) FROM Teams WHERE LeaderID = @UserID", con);
                cmdTeam.Parameters.AddWithValue("@UserID", employeeId);
                int teamCount = (int)cmdTeam.ExecuteScalar();

                SqlCommand cmdProject = new SqlCommand(
                    "SELECT COUNT(*) FROM Projects WHERE ManagerID = @UserID", con);
                cmdProject.Parameters.AddWithValue("@UserID", employeeId);
                int projectCount = (int)cmdProject.ExecuteScalar();

                return teamCount > 0 || projectCount > 0;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbEmployees.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un employé.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedEmployee = (ComboboxItem)cmbEmployees.SelectedItem;
            int employeeId = (int)selectedEmployee.Value;

            if (IsEmployeeLeader(employeeId))
            {
                MessageBox.Show("Cet employé est un chef d'équipe ou chef de projet. " +
                    "Vous devez d'abord réaffecter ses responsabilités.",
                    "Opération impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Êtes-vous sûr de vouloir supprimer l'employé {selectedEmployee.Text} ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlTransaction transaction = con.BeginTransaction();

                        try
                        {
                            // Désactiver l'employé plutôt que de le supprimer
                            SqlCommand cmd = new SqlCommand(
                                "UPDATE Users SET IsActive = 0 WHERE UserID = @UserID",
                                con, transaction);
                            cmd.Parameters.AddWithValue("@UserID", employeeId);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                transaction.Commit();
                                MessageBox.Show("Employé supprimé avec succès !",
                                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadEmployees();
                            }
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la suppression : {ex.Message}",
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
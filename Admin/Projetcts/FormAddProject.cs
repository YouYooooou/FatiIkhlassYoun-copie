using System.Configuration;
using System.Data.SqlClient;
using System.Configuration;
namespace FatiIkhlassYoun
{
    public partial class FormAddProject : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementSystem"].ConnectionString;

        public FormAddProject()
        {
            InitializeComponent();
        }

       

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string description = txtDescription.Text.Trim();
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            string status = cbStatus.SelectedItem?.ToString(); // Ici on utilise comboBoxStatus

            if (cbManager.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un manager.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int managerID = (int)cbManager.SelectedValue;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["cnx"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Projects (Title, Description, StartDate, EndDate, Status, ManagerID)
                         VALUES (@Title, @Description, @StartDate, @EndDate, @Status, @ManagerID)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@ManagerID", managerID);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Projet ajouté avec succès !");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout du projet : " + ex.Message);
                }
            }
        }

      

        private void comboBoxManager_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

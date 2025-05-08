using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FatiIkhlassYoun
{
    public partial class FormDeleteProject : Form
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

        public FormDeleteProject()
        {
            InitializeComponent();
            LoadProjects();
        }

        private void LoadProjects()
        {
            cmbProjects.Items.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT ProjectID, Title FROM Projects WHERE Status != 'Terminé'", con);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbProjects.Items.Add(new ComboboxItem
                        {
                            Value = reader.GetInt32(0),
                            Text = reader.GetString(1)
                        });
                    }
                }
            }
        }

        private bool HasActiveTasks(int projectId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Tasks WHERE ProjectID = @ProjectID AND Status != 'Terminée'",
                    con);
                cmd.Parameters.AddWithValue("@ProjectID", projectId);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbProjects.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un projet.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedProject = (ComboboxItem)cmbProjects.SelectedItem;
            int projectId = (int)selectedProject.Value;

            if (HasActiveTasks(projectId))
            {
                MessageBox.Show("Ce projet contient des tâches actives. " +
                    "Vous devez d'abord les supprimer ou les réaffecter.",
                    "Opération impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Êtes-vous sûr de vouloir supprimer le projet : {selectedProject.Text} ?",
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
                            // Supprimer les équipes associées
                            SqlCommand cmdTeams = new SqlCommand(
                                "DELETE FROM Teams WHERE ProjectID = @ProjectID",
                                con, transaction);
                            cmdTeams.Parameters.AddWithValue("@ProjectID", projectId);
                            cmdTeams.ExecuteNonQuery();

                            // Supprimer le projet
                            SqlCommand cmdProject = new SqlCommand(
                                "DELETE FROM Projects WHERE ProjectID = @ProjectID",
                                con, transaction);
                            cmdProject.Parameters.AddWithValue("@ProjectID", projectId);

                            int rowsAffected = cmdProject.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                transaction.Commit();
                                MessageBox.Show("Projet supprimé avec succès !",
                                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadProjects();
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
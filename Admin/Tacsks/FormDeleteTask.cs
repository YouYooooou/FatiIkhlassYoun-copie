using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FatiIkhlassYoun
{
    public partial class FormDeleteTask : Form
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

        public FormDeleteTask()
        {
            InitializeComponent();
            LoadTasks();
        }

        private void LoadTasks()
        {
            cmbTasks.Items.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT TaskID, Title FROM Tasks WHERE Status != 'Terminée'", con);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbTasks.Items.Add(new ComboboxItem
                        {
                            Value = reader.GetInt32(0),
                            Text = reader.GetString(1)
                        });
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbTasks.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une tâche.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedTask = (ComboboxItem)cmbTasks.SelectedItem;
            int taskId = (int)selectedTask.Value;

            DialogResult confirm = MessageBox.Show(
                $"Êtes-vous sûr de vouloir supprimer la tâche : {selectedTask.Text} ?",
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
                            // Supprimer les assignations de tâche
                            SqlCommand cmdAssignments = new SqlCommand(
                                "DELETE FROM Task_Assignments WHERE TaskID = @TaskID",
                                con, transaction);
                            cmdAssignments.Parameters.AddWithValue("@TaskID", taskId);
                            cmdAssignments.ExecuteNonQuery();

                            // Supprimer les sous-tâches sous-traitées
                            SqlCommand cmdSubcontracted = new SqlCommand(
                                "DELETE FROM SubcontractedTasks WHERE TaskID = @TaskID",
                                con, transaction);
                            cmdSubcontracted.Parameters.AddWithValue("@TaskID", taskId);
                            cmdSubcontracted.ExecuteNonQuery();

                            // Supprimer la tâche
                            SqlCommand cmdTask = new SqlCommand(
                                "DELETE FROM Tasks WHERE TaskID = @TaskID",
                                con, transaction);
                            cmdTask.Parameters.AddWithValue("@TaskID", taskId);

                            int rowsAffected = cmdTask.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                transaction.Commit();
                                MessageBox.Show("Tâche supprimée avec succès !",
                                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadTasks();
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
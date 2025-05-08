using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FatiIkhlassYoun
{
    public partial class FormDeleteTeam : Form
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

        public FormDeleteTeam()
        {
            InitializeComponent();
            LoadTeams();
        }

        private void LoadTeams()
        {
            cmbTeams.Items.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT TeamID, Name FROM Teams", con);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbTeams.Items.Add(new ComboboxItem
                        {
                            Value = reader.GetInt32(0),
                            Text = reader.GetString(1)
                        });
                    }
                }
            }
        }

        private bool HasActiveTasks(int teamId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    @"SELECT COUNT(*) FROM Tasks t
                      JOIN Task_Assignments ta ON t.TaskID = ta.TaskID
                      JOIN TeamMembers tm ON ta.UserID = tm.UserID
                      WHERE tm.TeamID = @TeamID AND t.Status != 'Terminée'",
                    con);
                cmd.Parameters.AddWithValue("@TeamID", teamId);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbTeams.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une équipe.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedTeam = (ComboboxItem)cmbTeams.SelectedItem;
            int teamId = (int)selectedTeam.Value;

            if (HasActiveTasks(teamId))
            {
                MessageBox.Show("Cette équipe a des tâches actives. " +
                    "Vous devez d'abord les réaffecter.",
                    "Opération impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Êtes-vous sûr de vouloir supprimer l'équipe : {selectedTeam.Text} ?",
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
                            // Supprimer les membres de l'équipe
                            SqlCommand cmdMembers = new SqlCommand(
                                "DELETE FROM TeamMembers WHERE TeamID = @TeamID",
                                con, transaction);
                            cmdMembers.Parameters.AddWithValue("@TeamID", teamId);
                            cmdMembers.ExecuteNonQuery();

                            // Supprimer l'équipe
                            SqlCommand cmdTeam = new SqlCommand(
                                "DELETE FROM Teams WHERE TeamID = @TeamID",
                                con, transaction);
                            cmdTeam.Parameters.AddWithValue("@TeamID", teamId);

                            int rowsAffected = cmdTeam.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                transaction.Commit();
                                MessageBox.Show("Équipe supprimée avec succès !",
                                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadTeams();
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
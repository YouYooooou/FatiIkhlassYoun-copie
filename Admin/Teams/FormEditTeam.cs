using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FatiIkhlassYoun
{
    public partial class FormEditTeam : Form
    {
        private readonly int teamId;
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

        public FormEditTeam(int teamId)
        {
            InitializeComponent();
            this.teamId = teamId;
        }

        private void FormEditTeam_Load(object sender, EventArgs e)
        {
            LoadTeamData();
            LoadProjects();
            LoadLeaders();
            LoadMembers();
        }

        private void LoadTeamData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Charger les infos de base de l'équipe
                    SqlCommand cmd = new SqlCommand(
                        "SELECT Name, ProjectID, LeaderID FROM Teams WHERE TeamID = @TeamID", con);
                    cmd.Parameters.AddWithValue("@TeamID", teamId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtTeamName.Text = reader["Name"].ToString();
                            this.Text = "Modifier l'équipe: " + reader["Name"].ToString();
                        }
                    }

                    // Charger les membres actuels
                    SqlCommand membersCmd = new SqlCommand(
                        "SELECT UserID FROM TeamMembers WHERE TeamID = @TeamID", con);
                    membersCmd.Parameters.AddWithValue("@TeamID", teamId);

                    var currentMembers = new System.Collections.ArrayList();
                    using (SqlDataReader reader = membersCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            currentMembers.Add(reader.GetInt32(0));
                        }
                    }

                    // Cocher les membres actuels
                    for (int i = 0; i < clbMembers.Items.Count; i++)
                    {
                        var item = (ComboboxItem)clbMembers.Items[i];
                        if (currentMembers.Contains(item.Value))
                        {
                            clbMembers.SetItemChecked(i, true);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données: " + ex.Message);
            }
        }

        private void LoadProjects()
        {
            cmbProject.Items.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ProjectID, Title FROM Projects", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbProject.Items.Add(new ComboboxItem
                    {
                        Value = reader.GetInt32(0),
                        Text = reader.GetString(1)
                    });
                }
                reader.Close();

                // Sélectionner le projet actuel de l'équipe
                cmd = new SqlCommand("SELECT ProjectID FROM Teams WHERE TeamID = @TeamID", con);
                cmd.Parameters.AddWithValue("@TeamID", teamId);
                object projectId = cmd.ExecuteScalar();

                if (projectId != null)
                {
                    foreach (ComboboxItem item in cmbProject.Items)
                    {
                        if (item.Value.Equals(projectId))
                        {
                            cmbProject.SelectedItem = item;
                            break;
                        }
                    }
                }
            }
        }

        private void LoadLeaders()
        {
            cmbLeader.Items.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT UserID, Username FROM Users WHERE Role = 'chef_equipe'", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbLeader.Items.Add(new ComboboxItem
                    {
                        Value = reader.GetInt32(0),
                        Text = reader.GetString(1)
                    });
                }
                reader.Close();

                // Sélectionner le leader actuel de l'équipe
                cmd = new SqlCommand("SELECT LeaderID FROM Teams WHERE TeamID = @TeamID", con);
                cmd.Parameters.AddWithValue("@TeamID", teamId);
                object leaderId = cmd.ExecuteScalar();

                if (leaderId != null)
                {
                    foreach (ComboboxItem item in cmbLeader.Items)
                    {
                        if (item.Value.Equals(leaderId))
                        {
                            cmbLeader.SelectedItem = item;
                            break;
                        }
                    }
                }
            }
        }

        private void LoadMembers()
        {
            clbMembers.Items.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT UserID, Username FROM Users WHERE Role = 'membre'", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    clbMembers.Items.Add(new ComboboxItem
                    {
                        Value = reader.GetInt32(0),
                        Text = reader.GetString(1)
                    });
                }
                reader.Close();
            }
        }

      

        private void UpdateTeamMembers(SqlConnection con, SqlTransaction transaction)
        {
            // Supprimer tous les membres actuels
            SqlCommand deleteCmd = new SqlCommand(
                "DELETE FROM TeamMembers WHERE TeamID = @TeamID", con, transaction);
            deleteCmd.Parameters.AddWithValue("@TeamID", teamId);
            deleteCmd.ExecuteNonQuery();

            // Ajouter les nouveaux membres sélectionnés
            foreach (var item in clbMembers.CheckedItems)
            {
                var member = (ComboboxItem)item;
                SqlCommand insertCmd = new SqlCommand(
                    "INSERT INTO TeamMembers (TeamID, UserID) VALUES (@TeamID, @UserID)",
                    con, transaction);

                insertCmd.Parameters.AddWithValue("@TeamID", teamId);
                insertCmd.Parameters.AddWithValue("@UserID", member.Value);
                insertCmd.ExecuteNonQuery();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTeamName.Text))
            {
                MessageBox.Show("Veuillez saisir un nom pour l'équipe");
                return false;
            }

            if (cmbProject.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un projet");
                return false;
            }

            if (cmbLeader.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un chef d'équipe");
                return false;
            }

            if (clbMembers.CheckedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner au moins un membre");
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        // Mettre à jour l'équipe
                        SqlCommand cmd = new SqlCommand(
                            "UPDATE Teams SET Name = @Name, ProjectID = @ProjectID, LeaderID = @LeaderID " +
                            "WHERE TeamID = @TeamID", con, transaction);

                        cmd.Parameters.AddWithValue("@Name", txtTeamName.Text.Trim());
                        cmd.Parameters.AddWithValue("@ProjectID", ((ComboboxItem)cmbProject.SelectedItem).Value);
                        cmd.Parameters.AddWithValue("@LeaderID", ((ComboboxItem)cmbLeader.SelectedItem).Value);
                        cmd.Parameters.AddWithValue("@TeamID", teamId);
                        cmd.ExecuteNonQuery();

                        // Mettre à jour les membres
                        UpdateTeamMembers(con, transaction);

                        transaction.Commit();
                        MessageBox.Show("L'équipe a été modifiée avec succès !");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Erreur lors de la modification: " + ex.Message);
                    }
                }
            }

        }
    }
}
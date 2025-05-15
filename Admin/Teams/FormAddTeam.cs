using System.Configuration;
using System.Data.SqlClient;

namespace FatiIkhlassYoun
{
    public partial class FormAddTeam : Form
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

        public FormAddTeam()
        {
            InitializeComponent();
        }

        private void FormAddTeam_Load(object sender, EventArgs e)
        {
            LoadLeaders();
            LoadProjects();
            LoadMembers();
        }

        private void LoadLeaders()
        {
            comboBoxLeader.Items.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT UserID, Username FROM Users WHERE Role = 'chef_equipe'", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxLeader.Items.Add(new ComboboxItem
                    {
                        Value = reader.GetInt32(0),
                        Text = reader.GetString(1)
                    });
                }

                reader.Close();
            }
        }

        private void LoadProjects()
        {
            comboBoxProject.Items.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ProjectID, Title FROM Projects", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxProject.Items.Add(new ComboboxItem
                    {
                        Value = reader.GetInt32(0),
                        Text = reader.GetString(1)
                    });
                }

                reader.Close();
            }
        }

        private void LoadMembers()
        {
            checkedListBoxMembers.Items.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT UserID, Username FROM Users WHERE Role = 'membre'", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    checkedListBoxMembers.Items.Add(new ComboboxItem
                    {
                        Value = reader.GetInt32(0),
                        Text = reader.GetString(1)
                    });
                }

                reader.Close();
            }
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Vérifie que tous les champs obligatoires sont remplis
            if (string.IsNullOrWhiteSpace(txtTeamName.Text) || comboBoxLeader.SelectedItem == null || comboBoxProject.SelectedItem == null)
            {
                MessageBox.Show("Veuillez remplir les champs obligatoires.");
                return;
            }

            // Récupère les valeurs sélectionnées
            var selectedLeader = comboBoxLeader.SelectedItem as ComboboxItem;
            var selectedProject = comboBoxProject.SelectedItem as ComboboxItem;

            if (selectedLeader == null || selectedProject == null)
            {
                MessageBox.Show("Veuillez sélectionner un chef d'équipe et un projet.");
                return;
            }

            int newTeamID = 0;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Crée la commande SQL pour insérer l'équipe
                    SqlCommand cmdTeam = new SqlCommand(@"
                INSERT INTO Teams (Name, LeaderID, ProjectID) 
                VALUES (@Name, @LeaderID, @ProjectID);
                SELECT SCOPE_IDENTITY();", con);

                    // Ajoute les paramètres à la commande SQL
                    cmdTeam.Parameters.AddWithValue("@Name", txtTeamName.Text.Trim());
                    cmdTeam.Parameters.AddWithValue("@LeaderID", selectedLeader?.Value ?? DBNull.Value);
                    cmdTeam.Parameters.AddWithValue("@ProjectID", selectedProject?.Value ?? DBNull.Value);

                    // Exécute la commande pour obtenir l'ID de l'équipe insérée
                    object result = cmdTeam.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out newTeamID))
                    {
                        // Ajoute les membres à l'équipe
                        foreach (var item in checkedListBoxMembers.CheckedItems)
                        {
                            var selectedMember = item as ComboboxItem;
                            SqlCommand cmdMember = new SqlCommand(
                                "INSERT INTO TeamMembers (TeamID, UserID) VALUES (@TeamID, @UserID)", con);
                            cmdMember.Parameters.AddWithValue("@TeamID", newTeamID);
                            cmdMember.Parameters.AddWithValue("@UserID", selectedMember?.Value ?? DBNull.Value);
                            cmdMember.ExecuteNonQuery();
                        }

                        MessageBox.Show("Équipe ajoutée avec succès !");
                        this.DialogResult = DialogResult.OK; // Ferme le formulaire avec OK
                        this.Close(); // Ferme le formulaire
                    }
                    else
                    {
                        MessageBox.Show("Erreur : l'équipe n'a pas été enregistrée.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message);
            }
        }




        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxProject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

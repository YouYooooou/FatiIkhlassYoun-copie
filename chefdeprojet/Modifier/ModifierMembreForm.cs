using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ModifierMembreForm : Form
    {


        public ModifierMembreForm()
        {
            InitializeComponent();
        }

        private int userId;

        public void SetMembreInfo(int id, string nom)
        {
            this.userId = id;
            this.Text = "Modifier le membre : " + nom;
            ChargerInfosMembre();
        }

        private void ChargerInfosMembre()
        {
            if (userId > 0)
            {
                using (SqlConnection con = DbConnection.GetConnection())
                {
                    con.Open();

                    // Requête corrigée avec jointure sur TeamMembers
                    string query = @"
            SELECT U.Username, U.Email, U.Role, TM.TeamID, TM.AssignedDate
            FROM Users U
            LEFT JOIN TeamMembers TM ON U.UserID = TM.UserID
            WHERE U.UserID = @UserID";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtNom.Text = reader["Username"].ToString();
                        txtEmail.Text = reader["Email"].ToString();

                        // Sélection de l’équipe
                        if (reader["TeamID"] != DBNull.Value)
                            comboEquipes.SelectedValue = Convert.ToInt32(reader["TeamID"]);

                        // Sélection du rôle
                        string role = reader["Role"].ToString();
                        comboRole.SelectedItem = role;

                        // Date d’affectation
                        if (reader["AssignedDate"] != DBNull.Value)
                            dateAffectation.Value = Convert.ToDateTime(reader["AssignedDate"]);
                    }
                }
            }


        }






        private void ModifierMembreForm_Load(object sender, EventArgs e)
        {
            // Initialisation des ComboBox
            comboRole.Items.Clear();
            comboRole.Items.Add(new ComboBoxItem("-- Sélectionnez un rôle --", ""));
            comboRole.Items.Add(new ComboBoxItem("Membre", "membre"));
            comboRole.Items.Add(new ComboBoxItem("Chef d'équipe", "chef_equipe"));
            comboRole.SelectedIndex = 0;

            ChargerMembres();
            ChargerEquipes();
            ChargerTaches();
        }

        private void ChargerMembres()
        {
            comboMembres.Items.Clear();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT UserID, Username FROM Users", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboMembres.Items.Add(new ComboBoxItem(reader["Username"].ToString(), reader["UserID"].ToString()));
                }
            }
        }

        private void ChargerEquipes()
        {
            comboEquipes.Items.Clear();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT TeamID, Name FROM Teams", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboEquipes.Items.Add(new ComboBoxItem(reader["Name"].ToString(), reader["TeamID"].ToString()));
                }
            }
        }

        private void ChargerTaches()
        {
            comboTaches.Items.Clear();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT TaskID, Title FROM Tasks", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboTaches.Items.Add(new ComboBoxItem(reader["Title"].ToString(), reader["TaskID"].ToString()));
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            // Vérification des champs
            if (comboEquipes.SelectedIndex == -1 || string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            var selectedMembre = comboMembres.SelectedItem as ComboBoxItem;
            if (selectedMembre == null)
            {
                MessageBox.Show("Veuillez sélectionner un membre.");
                return;
            }

            var selectedRole = comboRole.SelectedItem as ComboBoxItem;
            if (selectedRole == null || string.IsNullOrWhiteSpace(selectedRole.Value))
            {
                MessageBox.Show("Veuillez sélectionner un rôle valide.");
                return;
            }

            string userId = selectedMembre.Value; // ID du membre sélectionné
            string username = txtNom.Text;
            string email = txtEmail.Text;
            string role = selectedRole.Value;

            // Mise à jour des informations du membre
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();
                string query = "UPDATE Users SET Username = @Username, Email = @Email, Role = @Role WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Role", role);
                cmd.Parameters.AddWithValue("@UserID", userId);

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Membre modifié avec succès !");
                    }
                    else
                    {
                        MessageBox.Show("Une erreur est survenue lors de la modification.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }

            // Affectation du membre à la tâche
            AffecterMembreATache(userId);
        }

        private void AffecterMembreATache(string userId)
        {
            var selectedTask = comboTaches.SelectedItem as ComboBoxItem;
            if (selectedTask == null)
            {
                MessageBox.Show("Veuillez sélectionner une tâche.");
                return;
            }

            string taskId = selectedTask.Value;

            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();

                string query = "INSERT INTO Task_Assignments (TaskID, UserID) VALUES (@TaskID, @UserID)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TaskID", taskId);
                cmd.Parameters.AddWithValue("@UserID", userId);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Membre affecté à la tâche avec succès !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void comboMembres_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedMembre = comboMembres.SelectedItem as ComboBoxItem;
            if (selectedMembre == null) return;

            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();

                // Récupère les informations du membre sélectionné
                SqlCommand cmd = new SqlCommand(@"SELECT u.Username, u.Email, u.Role, tm.TeamID, ta.TaskID
                                                  FROM Users u
                                                  LEFT JOIN TeamMembers tm ON u.UserID = tm.UserID
                                                  LEFT JOIN Task_Assignments ta ON u.UserID = ta.UserID
                                                  WHERE u.UserID = @UserID", con);

                cmd.Parameters.AddWithValue("@UserID", selectedMembre.Value);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Remplir les champs avec les informations du membre
                    txtNom.Text = reader["Username"].ToString();
                    txtEmail.Text = reader["Email"].ToString();

                    // Sélectionner le rôle
                    string role = reader["Role"].ToString();
                    for (int i = 0; i < comboRole.Items.Count; i++)
                    {
                        var item = comboRole.Items[i] as ComboBoxItem;
                        if (item != null && item.Value == role)
                        {
                            comboRole.SelectedIndex = i;
                            break;
                        }
                    }

                    // Sélectionner l'équipe
                    string teamID = reader["TeamID"]?.ToString();
                    if (!string.IsNullOrEmpty(teamID))
                    {
                        for (int i = 0; i < comboEquipes.Items.Count; i++)
                        {
                            var item = comboEquipes.Items[i] as ComboBoxItem;
                            if (item != null && item.Value == teamID)
                            {
                                comboEquipes.SelectedIndex = i;
                                break;
                            }
                        }
                    }

                    // Sélectionner la tâche
                    string taskID = reader["TaskID"]?.ToString();
                    if (!string.IsNullOrEmpty(taskID))
                    {
                        for (int i = 0; i < comboTaches.Items.Count; i++)
                        {
                            var item = comboTaches.Items[i] as ComboBoxItem;
                            if (item != null && item.Value == taskID)
                            {
                                comboTaches.SelectedIndex = i;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // Classe utilitaire pour afficher texte/valeur dans les ComboBox
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public ComboBoxItem(string text, string value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString() => Text;
        }

        private void comboRole_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}


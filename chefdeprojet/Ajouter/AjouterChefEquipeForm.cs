using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AjouterChefEquipeForm : Form
    {
        public AjouterChefEquipeForm()
        {
            InitializeComponent();
            ChargerMembres();
            ChargerEquipes();
        }

        // Charger les membres qui ont le rôle "Membre"
        private void ChargerMembres()
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT UserID, Username FROM Users WHERE Role = 'Membre'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboMembre.Items.Add(new ComboBoxItem
                    {
                        Text = reader["Username"].ToString(),
                        Value = reader["UserID"]
                    });
                }
            }
        }

        // Charger les équipes existantes
        private void ChargerEquipes()
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT TeamID, Name FROM Teams", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboEquipeExistante.Items.Add(new ComboBoxItem
                    {
                        Text = reader["Name"].ToString(),
                        Value = reader["TeamID"]
                    });
                }
            }
        }

        // Lorsque l'utilisateur sélectionne "Nouvelle équipe" ou "Équipe existante"
        private void radioNouvelleEquipe_CheckedChanged(object sender, EventArgs e)
        {
            txtNouvelleEquipe.Enabled = radioNouvelleEquipe.Checked;
            comboEquipeExistante.Enabled = !radioNouvelleEquipe.Checked;
        }

        // Ajouter un chef d'équipe
        private void btnAjouterChefEquipe_Click(object sender, EventArgs e)
        {
            if (comboMembre.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un membre.");
                return;
            }

            int userId = (int)((ComboBoxItem)comboMembre.SelectedItem).Value;
            int teamId = -1;

            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();

                // Créer une nouvelle équipe avec le chef sélectionné
                if (radioNouvelleEquipe.Checked)
                {
                    if (string.IsNullOrWhiteSpace(txtNouvelleEquipe.Text))
                    {
                        MessageBox.Show("Veuillez entrer un nom pour la nouvelle équipe.");
                        return;
                    }

                    SqlCommand insertEquipeCmd = new SqlCommand(
                        "INSERT INTO Teams (Name, LeaderID) OUTPUT INSERTED.TeamID VALUES (@name, @leaderId)", con);
                    insertEquipeCmd.Parameters.AddWithValue("@name", txtNouvelleEquipe.Text);
                    insertEquipeCmd.Parameters.AddWithValue("@leaderId", userId);
                    teamId = (int)insertEquipeCmd.ExecuteScalar();
                }
                else
                {
                    if (comboEquipeExistante.SelectedItem == null)
                    {
                        MessageBox.Show("Veuillez sélectionner une équipe existante.");
                        return;
                    }

                    teamId = (int)((ComboBoxItem)comboEquipeExistante.SelectedItem).Value;

                    // Mise à jour du chef d'équipe dans l'équipe existante
                    SqlCommand updateEquipeCmd = new SqlCommand(
                        "UPDATE Teams SET LeaderID = @leaderId WHERE TeamID = @teamId", con);
                    updateEquipeCmd.Parameters.AddWithValue("@leaderId", userId);
                    updateEquipeCmd.Parameters.AddWithValue("@teamId", teamId);
                    updateEquipeCmd.ExecuteNonQuery();
                }

                // Mettre à jour le rôle dans la table Users
                SqlCommand updateRoleCmd = new SqlCommand(
                    "UPDATE Users SET Role = 'chef_equipe' WHERE UserID = @userId", con);
                updateRoleCmd.Parameters.AddWithValue("@userId", userId);
                updateRoleCmd.ExecuteNonQuery();

                // ❌ NE PAS AJOUTER DANS TeamMembers
                // car LeaderID suffit et évite la duplication dans le TreeView
            }

            MessageBox.Show("Chef d’équipe ajouté avec succès !");
        }



        // Classe pour gérer les éléments du ComboBox
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString() => Text;
        }

        // Chargement du formulaire
        private void AjouterChefEquipeForm_Load(object sender, EventArgs e) { }

        // Méthode pour ajouter une nouvelle équipe si nécessaire
        private int AjouterNouvelleEquipe(string newTeamName)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();
                string query = "INSERT INTO Teams (Name) OUTPUT INSERTED.TeamID VALUES (@Name)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", newTeamName);
                return (int)cmd.ExecuteScalar();
            }
        }

        // Bouton de fermeture du formulaire
        private void cuiButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboEquipeExistante_SelectedIndexChanged(object sender, EventArgs e) { }

        private void radioNouvelleEquipe_CheckedChanged_1(object sender, EventArgs e) { }

        private void comboMembre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SupprimerMembre: Form
    {
        public SupprimerMembre()
        {
            InitializeComponent();
            Load += SupprimerMembre_Load;
        }

        private int userId;

        public void SetMembreInfo(int id, string nom)
        {
            this.userId = id;
            this.Text = "Supprimer le membre : " + nom;
            ChargerInfosMembre();
        }

        private void ChargerInfosMembre()
        {
            if (userId > 0)
            {
                using (SqlConnection con = DbConnection.GetConnection())
                {
                    con.Open();
                    // On fait une jointure avec TeamMembers pour récupérer le TeamID
                    SqlCommand cmd = new SqlCommand(@"
                SELECT u.Username, u.Email, t.Name AS TeamName
                FROM Users u
                LEFT JOIN TeamMembers tm ON u.UserID = tm.UserID
                LEFT JOIN Teams t ON tm.TeamID = t.TeamID
                WHERE u.UserID = @UserID", con);

                    cmd.Parameters.AddWithValue("@UserID", userId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        comboUtilisateurs.SelectedItem = reader["Username"].ToString(); // Utilisation de Username
                        txtEmail.Text = reader["Email"].ToString();
                        txtEquipe.Text = reader["TeamName"].ToString();
                    }
                }
            }
        }


        private void SupprimerMembre_Load(object sender, EventArgs e)
        {
            comboUtilisateurs.Items.Clear();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();
                var cmd = new SqlCommand(@"SELECT u.UserID, u.Username 
                  FROM Users u
                  INNER JOIN TeamMembers tm ON u.UserID = tm.UserID", con);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboUtilisateurs.Items.Add(new ComboBoxItem(reader["Username"].ToString(), reader["UserID"].ToString()));
                }
            }

            comboUtilisateurs.SelectedIndexChanged += comboUtilisateurs_SelectedIndexChanged;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            var selectedUser = comboUtilisateurs.SelectedItem as ComboBoxItem;
            if (selectedUser == null)
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur.");
                return;
            }

            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir retirer ce membre de l'équipe ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();

                // Supprimer la liaison entre le membre et son équipe
                var cmdDeleteRefs = new SqlCommand("DELETE FROM TeamMembers WHERE UserID = @UserID", con);
                cmdDeleteRefs.Parameters.AddWithValue("@UserID", selectedUser.Value);
                cmdDeleteRefs.ExecuteNonQuery();
            }

            MessageBox.Show("Membre retiré de l'équipe avec succès !");
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboUtilisateurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedUser = comboUtilisateurs.SelectedItem as ComboBoxItem;
            if (selectedUser == null) return;

            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();

                // Email
                var cmdEmail = new SqlCommand("SELECT Email FROM Users WHERE UserID = @UserID", con);
                cmdEmail.Parameters.AddWithValue("@UserID", selectedUser.Value);
                var reader = cmdEmail.ExecuteReader();
                if (reader.Read())
                {
                    txtEmail.Text = reader["Email"].ToString();
                }
                reader.Close();

                // Équipe
                var cmdTeam = new SqlCommand(@"
            SELECT t.Name 
            FROM Teams t
            INNER JOIN TeamMembers tm ON t.TeamID = tm.TeamID
            WHERE tm.UserID = @UserID", con);
                cmdTeam.Parameters.AddWithValue("@UserID", selectedUser.Value);
                var readerTeam = cmdTeam.ExecuteReader();
                if (readerTeam.Read())
                {
                    txtEquipe.Text = readerTeam["Name"].ToString();
                }
                else
                {
                    txtEquipe.Text = "Aucune équipe";
                }
            }
        }

        private void txtNouvelleEquipe_TextChanged(object sender, EventArgs e)
        {

        }

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
    }
}

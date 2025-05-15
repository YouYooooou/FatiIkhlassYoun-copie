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
    public partial class SupprimerEquipe : Form
    {
        public SupprimerEquipe()
        {
            InitializeComponent();
            Load += SupprimerEquipe_Load;
        }

        private void SupprimerEquipe_Load(object sender, EventArgs e)
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

        private int equipeId;

        public void SetEquipeInfo(int id, string nomEquipe)
        {
            this.equipeId = id;
            this.Text = "Supprimer l'équipe : " + nomEquipe;
            ChargerInfosEquipe();
        }

        private void ChargerInfosEquipe()
        {
            if (equipeId > 0)
            {
                using (SqlConnection con = DbConnection.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"
                SELECT t.Name AS TeamName, u.Username AS LeaderUsername
                FROM Teams t
                LEFT JOIN Users u ON t.LeaderID = u.UserID
                WHERE t.TeamID = @TeamID", con);

                    cmd.Parameters.AddWithValue("@TeamID", equipeId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        comboEquipes.SelectedItem = reader["TeamName"].ToString(); // Remplir combo avec le nom de l'équipe
                        txtNomEquipe.Text = reader["TeamName"].ToString(); // Remplir le champ Nom de l'équipe
                        txtChefEquipe.Text = reader["LeaderUsername"].ToString(); // Remplir le champ Chef de l'équipe avec le Username du leader
                    }
                }
            }
        }

















        private void comboEquipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = comboEquipes.SelectedItem as ComboBoxItem;
            if (selectedItem == null) return;

            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();

                // On utilise une jointure pour obtenir le Username du Leader
                SqlCommand cmd = new SqlCommand(@"
                    SELECT T.Name, U.Username AS LeaderUsername
                    FROM Teams T
                    JOIN Users U ON T.LeaderID = U.UserID
                    WHERE T.TeamID = @TeamID", con);
                cmd.Parameters.AddWithValue("@TeamID", selectedItem.Value);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtNomEquipe.Text = reader["Name"].ToString();
                    txtChefEquipe.Text = reader["LeaderUsername"].ToString(); // Affiche le username du leader
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            var selectedItem = comboEquipes.SelectedItem as ComboBoxItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une équipe.");
                return;
            }

            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette équipe ?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = DbConnection.GetConnection())
                {
                    con.Open();

                    // Supprimer les membres associés
                    var cmdDeleteMembers = new SqlCommand("DELETE FROM TeamMembers WHERE TeamID = @TeamID", con);
                    cmdDeleteMembers.Parameters.AddWithValue("@TeamID", selectedItem.Value);
                    cmdDeleteMembers.ExecuteNonQuery();

                    // Détacher les tâches associées
                    var cmdDetachTasks = new SqlCommand("UPDATE Tasks SET TeamID = NULL WHERE TeamID = @TeamID", con);
                    cmdDetachTasks.Parameters.AddWithValue("@TeamID", selectedItem.Value);
                    cmdDetachTasks.ExecuteNonQuery();

                    // Supprimer l'équipe
                    var cmdDeleteTeam = new SqlCommand("DELETE FROM Teams WHERE TeamID = @TeamID", con);
                    cmdDeleteTeam.Parameters.AddWithValue("@TeamID", selectedItem.Value);
                    cmdDeleteTeam.ExecuteNonQuery();

                    MessageBox.Show("Équipe supprimée avec succès !");
                    this.Close();
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtNomEquipe_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtChefEquipe_TextChanged(object sender, EventArgs e)
        {
           
        }

    }
}

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
    public partial class ModifierEquipeForm: Form
    {

        private int equipeId;

        public ModifierEquipeForm()
        {
            InitializeComponent();
            Load += ModifierEquipeForm_Load;
        }

        

        public void SetEquipeInfo(int id, string nomEquipe)
        {
            this.equipeId = id;
            this.Text = "Modifier l'équipe : " + nomEquipe;
            ChargerInfosEquipe();
        }

        private void ChargerInfosEquipe()
        {
            if (equipeId > 0)
            {
                using (SqlConnection con = DbConnection.GetConnection())
                {
                    con.Open();

                    // Charger les infos de base de l’équipe
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Teams WHERE TeamID = @TeamID", con);
                    cmd.Parameters.AddWithValue("@TeamID", equipeId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtNomEquipe.Text = reader["Name"].ToString(); // <== CHANGÉ ICI
                        int chefId = Convert.ToInt32(reader["LeaderID"]);
                        comboChefEquipe.SelectedValue = chefId;
                    }
                    reader.Close();

                    // Charger les membres de l’équipe
                    SqlCommand cmdMembres = new SqlCommand(
                        "SELECT UserID FROM TeamMembers WHERE TeamID = @TeamID", con);
                    cmdMembres.Parameters.AddWithValue("@TeamID", equipeId);
                    SqlDataReader readerMembres = cmdMembres.ExecuteReader();
                    HashSet<int> membresActuels = new HashSet<int>();
                    while (readerMembres.Read())
                    {
                        membresActuels.Add(Convert.ToInt32(readerMembres["UserID"]));
                    }
                    readerMembres.Close();

                    // Cocher les membres correspondants dans checkedMembres
                    for (int i = 0; i < checkedMembres.Items.Count; i++)
                    {
                        var item = checkedMembres.Items[i] as ComboBoxItem;
                        if (item != null && membresActuels.Contains(Convert.ToInt32(item.Value)))
                        {
                            checkedMembres.SetItemChecked(i, true);
                        }
                    }

                    // Charger les tâches de l’équipe
                    SqlCommand cmdTaches = new SqlCommand(
                        "SELECT TaskID FROM Tasks WHERE TeamID = @TeamID", con);
                    cmdTaches.Parameters.AddWithValue("@TeamID", equipeId);
                    SqlDataReader readerTaches = cmdTaches.ExecuteReader();
                    HashSet<int> tachesActuelles = new HashSet<int>();
                    while (readerTaches.Read())
                    {
                        tachesActuelles.Add(Convert.ToInt32(readerTaches["TaskID"]));
                    }
                    readerTaches.Close();

                    // Cocher les tâches correspondantes dans checkedTaches
                    for (int i = 0; i < checkedTaches.Items.Count; i++)
                    {
                        var item = checkedTaches.Items[i] as ComboBoxItem;
                        if (item != null && tachesActuelles.Contains(Convert.ToInt32(item.Value)))
                        {
                            checkedTaches.SetItemChecked(i, true);
                        }
                    }
                }
            }
        }


        private void ModifierEquipeForm_Load(object sender, EventArgs e)
        {
            ChargerEquipes();
            ChargerUtilisateurs();
            ChargerTaches();
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

        private void ChargerUtilisateurs()
        {
            comboChefEquipe.Items.Clear();
            checkedMembres.Items.Clear();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();
                var cmd = new SqlCommand("SELECT UserID,Username FROM Users", con);
                var reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    var item = new ComboBoxItem(reader["Username"].ToString(), reader["UserID"].ToString());
                    comboChefEquipe.Items.Add(item);
                    checkedMembres.Items.Add(item);

                }

            }
        }

        private void ChargerTaches()
        {
            checkedTaches.Items.Clear();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();
                var cmd = new SqlCommand("SELECT TaskID, Title FROM Tasks", con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    checkedTaches.Items.Add(new ComboBoxItem(reader["Title"].ToString(), reader["TaskID"].ToString()));
                }
            }
        }

        private void comboEquipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEquipe = comboEquipes.SelectedItem as ComboBoxItem;
            if (selectedEquipe == null) return;

            string teamId = selectedEquipe.Value;

            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();

                // Nom de l'équipe
                var cmdNom = new SqlCommand("SELECT Name, LeaderID FROM Teams WHERE TeamID = @TeamID", con);
                cmdNom.Parameters.AddWithValue("@TeamID", teamId);
                var reader = cmdNom.ExecuteReader();
                if (reader.Read())
                {
                    txtNomEquipe.Text = reader["Name"].ToString();
                    string chefId = reader["LeaderID"].ToString();

                    // Sélectionner le chef
                    foreach (ComboBoxItem item in comboChefEquipe.Items)
                    {
                        if (item.Value == chefId)
                        {
                            comboChefEquipe.SelectedItem = item;
                            break;
                        }
                    }
                }
                reader.Close();

                // Membres
                var cmdMembres = new SqlCommand("SELECT UserID FROM TeamMembers WHERE TeamID = @TeamID", con);
                cmdMembres.Parameters.AddWithValue("@TeamID", teamId);
                var membresReader = cmdMembres.ExecuteReader();
                List<string> membresIds = new List<string>();
                while (membresReader.Read())
                {
                    membresIds.Add(membresReader["UserID"].ToString());
                }
                membresReader.Close();

                for (int i = 0; i < checkedMembres.Items.Count; i++)
                {
                    var item = (ComboBoxItem)checkedMembres.Items[i];
                    checkedMembres.SetItemChecked(i, membresIds.Contains(item.Value));
                }

                // Tâches
                var cmdTaches = new SqlCommand("SELECT TaskID FROM Tasks WHERE TeamID = @TeamID", con);
                cmdTaches.Parameters.AddWithValue("@TeamID", teamId);
                var tachesReader = cmdTaches.ExecuteReader();
                List<string> tachesIds = new List<string>();
                while (tachesReader.Read())
                {
                    tachesIds.Add(tachesReader["TaskID"].ToString());
                }
                tachesReader.Close();

                for (int i = 0; i < checkedTaches.Items.Count; i++)
                {
                    var item = (ComboBoxItem)checkedTaches.Items[i];
                    checkedTaches.SetItemChecked(i, tachesIds.Contains(item.Value));
                }
            }
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

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

         
            private void btnModifier_Click_1(object sender, EventArgs e)
        {
            var selectedEquipe = comboEquipes.SelectedItem as ComboBoxItem;
            var selectedChef = comboChefEquipe.SelectedItem as ComboBoxItem;

            if (selectedEquipe == null)
            {
                MessageBox.Show("Veuillez sélectionner une équipe.");
                return;
            }

            if (selectedChef == null)
            {
                MessageBox.Show("Veuillez sélectionner un chef d'équipe.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNomEquipe.Text))
            {
                MessageBox.Show("Veuillez saisir le nom de l'équipe.");
                return;
            }

            string teamId = selectedEquipe.Value;
            string nomEquipe = txtNomEquipe.Text;
            string leaderId = selectedChef.Value;

            try
            {
                using (SqlConnection con = DbConnection.GetConnection())
                {
                    con.Open();

                    // Mettre à jour le nom de l'équipe et le chef d'équipe
                    using (var cmdUpdate = new SqlCommand("UPDATE Teams SET Name = @Name, LeaderID = @LeaderID WHERE TeamID = @TeamID", con))
                    {
                        cmdUpdate.Parameters.AddWithValue("@Name", nomEquipe);
                        cmdUpdate.Parameters.AddWithValue("@LeaderID", leaderId);
                        cmdUpdate.Parameters.AddWithValue("@TeamID", teamId);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    // Réinitialiser les membres de l'équipe
                    using (var cmdDeleteMembres = new SqlCommand("DELETE FROM TeamMembers WHERE TeamID = @TeamID", con))
                    {
                        cmdDeleteMembres.Parameters.AddWithValue("@TeamID", teamId);
                        cmdDeleteMembres.ExecuteNonQuery();
                    }

                    foreach (ComboBoxItem item in checkedMembres.CheckedItems)
                    {
                        using (var cmdAddMembre = new SqlCommand("INSERT INTO TeamMembers (TeamID, UserID) VALUES (@TeamID, @UserID)", con))
                        {
                            cmdAddMembre.Parameters.AddWithValue("@TeamID", teamId);
                            cmdAddMembre.Parameters.AddWithValue("@UserID", item.Value);
                            cmdAddMembre.ExecuteNonQuery();
                        }
                    }

                    // Détacher les tâches actuelles de l'équipe
                    using (var cmdResetTaches = new SqlCommand("UPDATE Tasks SET TeamID = NULL WHERE TeamID = @TeamID", con))
                    {
                        cmdResetTaches.Parameters.AddWithValue("@TeamID", teamId);
                        cmdResetTaches.ExecuteNonQuery();
                    }

                    // Réaffecter les tâches sélectionnées
                    foreach (ComboBoxItem item in checkedTaches.CheckedItems)
                    {
                        using (var cmdAssignTache = new SqlCommand("UPDATE Tasks SET TeamID = @TeamID WHERE TaskID = @TaskID", con))
                        {
                            cmdAssignTache.Parameters.AddWithValue("@TeamID", teamId);
                            cmdAssignTache.Parameters.AddWithValue("@TaskID", item.Value);
                            cmdAssignTache.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Équipe modifiée avec succès !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification : " + ex.Message);
            }
        }

    }


}

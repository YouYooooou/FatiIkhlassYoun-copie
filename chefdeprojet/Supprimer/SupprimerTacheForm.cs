using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class SupprimerTacheForm: Form
    {
        public SupprimerTacheForm()
        {
            InitializeComponent();
         
        }

        private string nomTache;

        public SupprimerTacheForm(string nomTache)
        {
            InitializeComponent();
            this.nomTache = nomTache;
            Load += SupprimerTacheForm_Load;
        }


        private void SupprimerTacheForm_Load(object sender, EventArgs e)
        {
            ChargerTaches();


        }

        private void ChargerTaches()
        {
            comboTaches.Items.Clear();
            ComboBoxItem itemToSelect = null;

            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();
                var cmd = new SqlCommand("SELECT TaskID, Title FROM Tasks", con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var title = reader["Title"].ToString();
                    var id = reader["TaskID"].ToString();
                    var item = new ComboBoxItem(title, id);
                    comboTaches.Items.Add(item);

                    if (!string.IsNullOrEmpty(nomTache) && title.Equals(nomTache, StringComparison.OrdinalIgnoreCase))
                    {
                        itemToSelect = item;
                    }
                }
            }

            if (itemToSelect != null)
            {
                comboTaches.SelectedItem = itemToSelect;
                // Cela déclenchera automatiquement comboTaches_SelectedIndexChanged
            }
        }






        private int taskId;

        public void SetTacheInfo(int id, string nom)
        {
            this.taskId = id;
            this.Text = "Supprimer la tâche : " + nom;
            ChargerInfosTache();
        }

        private void ChargerInfosTache()
        {
            if (taskId > 0)
            {
                using (SqlConnection con = DbConnection.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Tasks WHERE TaskID = @TaskID", con);
                    cmd.Parameters.AddWithValue("@TaskID", taskId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        comboTaches.SelectedItem = reader["Title"].ToString();
                        txtDescription.Text = reader["Description"].ToString();
                    }
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

        private void comboTaches_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = comboTaches.SelectedItem as ComboBoxItem;
            if (selectedItem == null) return;

            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();
                var cmd = new SqlCommand("SELECT Description FROM Tasks WHERE TaskID = @TaskID", con);
                cmd.Parameters.AddWithValue("@TaskID", selectedItem.Value);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtDescription.Text = reader["Description"].ToString();
                }
                else
                {
                    txtDescription.Clear();
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            var selectedItem = comboTaches.SelectedItem as ComboBoxItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une tâche à supprimer.");
                return;
            }

            var result = MessageBox.Show("Voulez-vous vraiment supprimer cette tâche ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;

            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();

                // Supprimer d'abord les assignments de la tâche dans Task_Assignments
                var cmdDeleteAssignments = new SqlCommand("DELETE FROM Task_Assignments WHERE TaskID = @TaskID", con);
                cmdDeleteAssignments.Parameters.AddWithValue("@TaskID", selectedItem.Value);
                cmdDeleteAssignments.ExecuteNonQuery();

                // Ensuite, supprimer la tâche de la table Tasks
                var cmdDeleteTask = new SqlCommand("DELETE FROM Tasks WHERE TaskID = @TaskID", con);
                cmdDeleteTask.Parameters.AddWithValue("@TaskID", selectedItem.Value);
                cmdDeleteTask.ExecuteNonQuery();
            }

            MessageBox.Show("Tâche supprimée avec succès !");
            ChargerTaches(); // Recharger la liste des tâches
        }


        private void cuiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    


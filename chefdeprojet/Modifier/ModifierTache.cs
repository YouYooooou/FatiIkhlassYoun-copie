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
    public partial class ModifierTache : Form
    {
        private int taskId;
        public ModifierTache()
        {
            InitializeComponent();
        }

        public void SetTacheInfo(int id, string nomTache)
        {
            this.taskId = id;
            this.Text = "Modifier la tâche: " + nomTache;
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
                        txtTitre.Text = reader["Title"].ToString();
                        txtDescription.Text = reader["Description"].ToString();
                        dateDebutPicker.Value = Convert.ToDateTime(reader["StartDate"]);
                        dateFinPicker.Value = Convert.ToDateTime(reader["DueDate"]);

                        // Sélection du statut dans le ComboBox
                        string statut = reader["Status"].ToString();
                        comboStatut.SelectedItem = statut;

                       
                        
                    }
                }
            }
        }





        private void ModifierTache_Load(object sender, EventArgs e)
        {
            RemplirComboTaches();
            RemplirComboStatuts();
        }

        private void RemplirComboTaches()
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT TaskID, Title FROM Tasks", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboTacheAModifier.Items.Add(new ComboBoxItem
                    {
                        Text = reader["Title"].ToString(),
                        Value = reader["TaskID"]
                    });
                }
            }
        }

        private void RemplirComboStatuts()
        {
            comboStatut.Items.Clear();
            comboStatut.Items.Add("En attente");
            comboStatut.Items.Add("En cours");
            comboStatut.Items.Add("Terminée");
        }

        private void comboTacheAModifier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTacheAModifier.SelectedItem is ComboBoxItem selected)
            {
                int taskId = (int)selected.Value;

                using (SqlConnection con = DbConnection.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Tasks WHERE TaskID = @TaskID", con);
                    cmd.Parameters.AddWithValue("@TaskID", taskId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtTitre.Text = reader["Title"].ToString();
                        txtDescription.Text = reader["Description"].ToString();
                        dateDebutPicker.Value = Convert.ToDateTime(reader["StartDate"]);
                        dateFinPicker.Value = Convert.ToDateTime(reader["DueDate"]);
                        comboStatut.SelectedItem = reader["Status"].ToString();
                        numericEstimatedTime.Value = Convert.ToInt32(reader["EstimatedTime"]);
                    }
                }
            }
        }


       

        // Classe ComboBoxItem
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            // Récupérer les nouvelles valeurs et mettre à jour la tâche dans la base de données
            var selectedTask = (ComboBoxItem)comboTacheAModifier.SelectedItem;
            if (selectedTask != null)
            {
                int taskId = (int)selectedTask.Value;

                string titre = txtTitre.Text;
                string description = txtDescription.Text;
                DateTime dateDebut = dateDebutPicker.Value;
                DateTime dateFin = dateFinPicker.Value;
                string statut = comboStatut.SelectedItem.ToString();
                int tempsEstime = int.Parse(numericEstimatedTime.Text);

                // Update the task
                using (SqlConnection con = DbConnection.GetConnection())
                {
                    con.Open();
                    string query = "UPDATE Tasks SET Title = @Title, Description = @Description, StartDate = @StartDate, DueDate = @DueDate, Status = @Status, EstimatedTime = @EstimatedTime WHERE TaskID = @TaskID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Title", titre);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@StartDate", dateDebut);
                    cmd.Parameters.AddWithValue("@DueDate", dateFin);
                    cmd.Parameters.AddWithValue("@Status", statut);
                    cmd.Parameters.AddWithValue("@EstimatedTime", tempsEstime);
                    cmd.Parameters.AddWithValue("@TaskID", taskId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Tâche modifiée avec succès.");
            }
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            this.Close(); // ou : this.Hide();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

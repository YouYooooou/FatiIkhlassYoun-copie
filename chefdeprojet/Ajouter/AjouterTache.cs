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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WindowsFormsApp1.AjouterMembreForm;

namespace WindowsFormsApp1
{
    public partial class AjouterTache : Form
    {
        public AjouterTache()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(600, 500);
            this.AutoSize = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Size = new System.Drawing.Size(600, 500);
        }

        private void AjouterTache_Load(object sender, EventArgs e)
        {
            RemplirComboEquipes();  // Remplir le ComboBox avec les équipes
            RemplirComboStatuts();
         

        }

        private void RemplirComboEquipes()
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();
                string query = "SELECT TeamID, Name FROM Teams";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboEquipe.Items.Add(new ComboBoxItem(
                        reader["Name"].ToString(),
                        (int)reader["TeamID"]
                    ));
                }

                reader.Close();
            }
        }


        private void RemplirComboStatuts()
        {
            comboStatut.Items.Add("En attente");
            comboStatut.Items.Add("En cours");
            comboStatut.Items.Add("Terminée");
            comboStatut.SelectedIndex = 0; // Par défaut
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Vérifie que tous les champs nécessaires sont remplis
            if (comboEquipe.SelectedIndex == -1 || string.IsNullOrEmpty(txtTitre.Text) || string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            // Récupère les données du formulaire
            int teamId = (int)((ComboBoxItem)comboEquipe.SelectedItem).Value;  // Utilisation de l'équipe au lieu du projet
            string title = txtTitre.Text;
            string description = txtDescription.Text;
            string status = comboStatut.SelectedItem.ToString();
            DateTime startDate = dateDebutPicker.Value;
            DateTime dueDate = dateFinPicker.Value;
            int estimatedTime = (int)numericEstimatedTime.Value;

            // Insertion dans la base de données
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();
                try
                {
                    // On remplace la requête par une version qui retourne l’ID
                    string query = "INSERT INTO Tasks (TeamID, Title, Description, StartDate, DueDate, Status, EstimatedTime) " +
                                   "VALUES (@TeamID, @Title, @Description, @StartDate, @DueDate, @Status, @EstimatedTime); " +
                                   "SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@TeamID", teamId);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@DueDate", dueDate);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@EstimatedTime", estimatedTime);

                    int taskId = (int)cmd.ExecuteScalar();

                    if (taskId > 0)
                    {
                        MessageBox.Show("Tâche ajoutée avec succès !");

                        

                    }
                    else
                    {
                        MessageBox.Show("Une erreur est survenue lors de l'ajout de la tâche.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public ComboBoxItem(string text, int value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }


}

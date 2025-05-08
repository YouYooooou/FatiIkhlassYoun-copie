using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FatiIkhlassYoun
{
    public partial class FormEditProject : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementSystem"].ConnectionString;
        public int ProjectId { get; set; }

        public FormEditProject(int projectId)
        {
            InitializeComponent();
            this.ProjectId = projectId;
            LoadProjectData();
        }

        private void LoadProjectData()
        {
            try
            {
                // Initialiser les ComboBox
                comboBoxStatus.Items.AddRange(new string[] { "En attente", "En cours", "Terminé" });

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Charger la liste des managers
                    string managersQuery = @"SELECT UserID, Username FROM Users 
                                       WHERE Role IN ('chef_projet', 'chef_equipe', 'admin')";
                    SqlDataAdapter managersAdapter = new SqlDataAdapter(managersQuery, conn);
                    DataTable managersTable = new DataTable();
                    managersAdapter.Fill(managersTable);

                    comboBoxManager.DisplayMember = "Username";
                    comboBoxManager.ValueMember = "UserID";
                    comboBoxManager.DataSource = managersTable;

                    // Charger les données du projet
                    string projectQuery = @"SELECT Title, Description, StartDate, EndDate, Status, ManagerID 
                                      FROM Projects WHERE ProjectID = @ProjectID";
                    SqlCommand projectCmd = new SqlCommand(projectQuery, conn);
                    projectCmd.Parameters.AddWithValue("@ProjectID", ProjectId);

                    using (SqlDataReader reader = projectCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtTitle.Text = reader["Title"].ToString();
                            txtDescription.Text = reader["Description"].ToString();
                            dateTimeStartDate.Value = Convert.ToDateTime(reader["StartDate"]);
                            dateTimeEndDate.Value = Convert.ToDateTime(reader["EndDate"]);
                            comboBoxStatus.SelectedItem = reader["Status"].ToString();

                            if (reader["ManagerID"] != DBNull.Value)
                            {
                                int managerId = Convert.ToInt32(reader["ManagerID"]);

                                // Vérifie si la valeur existe dans la liste
                                if (comboBoxManager.Items.Cast<DataRowView>().Any(item => (int)item["UserID"] == managerId))
                                {
                                    comboBoxManager.SelectedValue = managerId;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message,
                              "Erreur",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Validation des champs
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Veuillez saisir un titre pour le projet",
                              "Champ requis",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxManager.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un manager",
                              "Champ requis",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            if (dateTimeEndDate.Value < dateTimeStartDate.Value)
            {
                MessageBox.Show("La date de fin doit être postérieure à la date de début",
                              "Dates invalides",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Mise à jour du projet
                    string updateQuery = @"
                        UPDATE Projects SET 
                            Title = @Title,
                            Description = @Description,
                            StartDate = @StartDate,
                            EndDate = @EndDate,
                            Status = @Status,
                            ManagerID = @ManagerID
                        WHERE ProjectID = @ProjectID";

                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@Title", txtTitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
                    cmd.Parameters.AddWithValue("@StartDate", dateTimeStartDate.Value);
                    cmd.Parameters.AddWithValue("@EndDate", dateTimeEndDate.Value);
                    cmd.Parameters.AddWithValue("@Status", comboBoxStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ManagerID", ((DataRowView)comboBoxManager.SelectedItem)["UserID"]);
                    cmd.Parameters.AddWithValue("@ProjectID", ProjectId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Le projet a été mis à jour avec succès !",
                                     "Succès",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Aucune modification n'a été apportée",
                                     "Information",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour du projet : " + ex.Message,
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FatiIkhlassYoun
{
    public partial class FormAddProject : Form
    {
        private readonly string _connectionString;
        private const string ProjectManagerRole = "chef_projet";

        public FormAddProject()
        {
            InitializeComponent();

            // Initialisation de la chaîne de connexion avec le nom correct
            _connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementSystem"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
            {
                MessageBox.Show("La configuration de connexion à la base de données est manquante ou incorrecte.\nVeuillez vérifier le fichier App.config.",
                    "Erreur de configuration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FormAddProject_Load_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_connectionString))
            {
                this.Close();
                return;
            }

            InitializeControls();
        }

        private void InitializeControls()
        {
            // Configuration des dates par défaut
            dateTimeStartDate.Value = DateTime.Today;
            dateTimeEndDate.Value = DateTime.Today.AddDays(7);

            // Initialisation de la ComboBox des statuts
            comboBoxStatus.Items.Clear();
            comboBoxStatus.Items.AddRange(new object[] { "En attente", "En cours", "Terminé" });
            comboBoxStatus.SelectedIndex = 0;

            // Chargement des chefs de projet
            LoadProjectManagers();
        }

        private void LoadProjectManagers()
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand(
                    "SELECT UserID, Username FROM Users WHERE Role = @Role AND IsActive = 1",
                    connection))
                {
                    command.Parameters.AddWithValue("@Role", ProjectManagerRole);
                    connection.Open();

                    var managers = new Dictionary<int, string>();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            managers.Add(reader.GetInt32(0), reader.GetString(1));
                        }
                    }

                    comboBoxManager.DataSource = new BindingSource(managers, null);
                    comboBoxManager.DisplayMember = "Value";
                    comboBoxManager.ValueMember = "Key";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des chefs de projet:\n{ex.Message}",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateProjectData()) return;

            try
            {
                int projectId = SaveProject();
                if (projectId > 0)
                {
                    MessageBox.Show($"Projet créé avec succès! (ID: {projectId})",
                        "Succès",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erreur SQL lors de la sauvegarde:\n{ex.Message}",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur inattendue:\n{ex.Message}",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool ValidateProjectData()
        {
            // Validation du titre
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Le titre du projet est obligatoire.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtTitle.Focus();
                return false;
            }

            // Validation des dates
            if (dateTimeEndDate.Value < dateTimeStartDate.Value)
            {
                MessageBox.Show("La date de fin doit être postérieure à la date de début.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                dateTimeEndDate.Focus();
                return false;
            }

            // Validation du manager
            if (comboBoxManager.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un chef de projet.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                comboBoxManager.Focus();
                return false;
            }

            return true;
        }

        private int SaveProject()
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(
                @"INSERT INTO Projects 
                (Title, Description, StartDate, EndDate, Status, ManagerID) 
                OUTPUT INSERTED.ProjectID
                VALUES 
                (@Title, @Description, @StartDate, @EndDate, @Status, @ManagerID)",
                connection))
            {
                command.Parameters.AddWithValue("@Title", txtTitle.Text.Trim());
                command.Parameters.AddWithValue("@Description",
                    string.IsNullOrWhiteSpace(txtDescription.Text) ? DBNull.Value : (object)txtDescription.Text.Trim());
                command.Parameters.AddWithValue("@StartDate", dateTimeStartDate.Value.Date);
                command.Parameters.AddWithValue("@EndDate", dateTimeEndDate.Value.Date);
                command.Parameters.AddWithValue("@Status", comboBoxStatus.SelectedItem.ToString());
                command.Parameters.AddWithValue("@ManagerID", (int)comboBoxManager.SelectedValue);

                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void comboBoxManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Événement laissé vide mais conservé pour compatibilité
        }
    }
}
using System.Configuration;
using System.Data.SqlClient;

namespace FatiIkhlassYoun
{
    public partial class FormAddTask : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["cnx"].ConnectionString;

        public int TaskId { get; internal set; }

        public FormAddTask()
        {
            InitializeComponent();
        }

        private void FormAddTask_Load(object sender, EventArgs e)
        {
            try
            {
                // Statut
                cmbStatus.Items.AddRange(new string[] { "En attente", "En cours", "Terminée" });
                cmbStatus.SelectedIndex = 0;

                // Priorité
                cmbPriority.Items.AddRange(new string[] { "Basse", "Moyenne", "Haute" });
                cmbPriority.SelectedIndex = 1;

                List<ComboboxItem> projectList = new List<ComboboxItem>();
                List<ComboboxItem> teamLeadList = new List<ComboboxItem>();
                List<ComboboxItem> userList = new List<ComboboxItem>();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Projets
                    SqlCommand cmdProject = new SqlCommand("SELECT ProjectID, Title FROM Projects", conn);
                    using (SqlDataReader reader = cmdProject.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            projectList.Add(new ComboboxItem(reader["Title"].ToString(), reader["ProjectID"]));
                        }
                    }

                    // Chefs d'équipe
                    SqlCommand cmdTeamLead = new SqlCommand("SELECT UserID, Username FROM Users WHERE Role = 'chef_equipe'", conn);
                    using (SqlDataReader reader = cmdTeamLead.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            teamLeadList.Add(new ComboboxItem(reader["Username"].ToString(), reader["UserID"]));
                        }
                    }

                    // Tous les utilisateurs
                    SqlCommand cmdUsers = new SqlCommand("SELECT UserID, Username FROM Users", conn);
                    using (SqlDataReader reader = cmdUsers.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            userList.Add(new ComboboxItem(reader["Username"].ToString(), reader["UserID"]));
                        }
                    }
                }

                // Ajout aux listes
                cmbProject.Items.AddRange(projectList.ToArray());
                if (cmbProject.Items.Count > 0) cmbProject.SelectedIndex = 0;

                cmbTeamLead.Items.AddRange(teamLeadList.ToArray());
                if (cmbTeamLead.Items.Count > 0) cmbTeamLead.SelectedIndex = 0;

                clbAssignedUsers.Items.AddRange(userList.ToArray());

                // Debug : voir combien de chefs d'équipe ont été trouvés
                MessageBox.Show($"Nombre de chefs d'équipe trouvés : {teamLeadList.Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
            }
        }

      

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreateTask_Click(object sender, EventArgs e)
        {


        }






        private void clbAssignedUsers_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            if (cmbProject.SelectedItem == null || string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Veuillez remplir les champs obligatoires.");
                return;
            }

            // Récupère les valeurs sélectionnées
            var selectedProject = cmbProject.SelectedItem as ComboboxItem;
            var selectedTeamLead = cmbTeamLead.SelectedItem as ComboboxItem;

            if (selectedProject == null || selectedTeamLead == null)
            {
                MessageBox.Show("Veuillez sélectionner un projet et un chef d'équipe.");
                return;
            }

            int taskId = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Crée la commande SQL pour insérer la tâche
                    SqlCommand cmd = new SqlCommand(@"
                INSERT INTO Tasks 
                (ProjectID, Title, Description, StartDate, DueDate, Status, EstimatedTime, TeamLeadID, Priority) 
                VALUES 
                (@ProjectID, @Title, @Description, @StartDate, @DueDate, @Status, @EstimatedTime, @TeamLeadID, @Priority);
                SELECT SCOPE_IDENTITY();", conn);

                    // Ajoute les paramètres à la commande SQL
                    cmd.Parameters.AddWithValue("@ProjectID", selectedProject?.Value ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Title", txtTitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
                    cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value);
                    cmd.Parameters.AddWithValue("@DueDate", dtpDueDate.Value);
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EstimatedTime", (int)numEstimatedTime.Value);
                    cmd.Parameters.AddWithValue("@TeamLeadID", selectedTeamLead?.Value ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Priority", cmbPriority.SelectedItem.ToString());

                    // Exécute la commande pour obtenir l'ID de la tâche insérée
                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out taskId))
                    {
                        // Ajoute les utilisateurs assignés à la tâche
                        foreach (var item in clbAssignedUsers.CheckedItems)
                        {
                            var user = item as ComboboxItem;
                            SqlCommand assignCmd = new SqlCommand(
                                "INSERT INTO Task_Assignments (TaskID, UserID) VALUES (@TaskID, @UserID)", conn);
                            assignCmd.Parameters.AddWithValue("@TaskID", taskId);
                            assignCmd.Parameters.AddWithValue("@UserID", user.Value);
                            assignCmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Tâche ajoutée avec succès !");
                        this.DialogResult = DialogResult.OK; // Ferme le formulaire avec OK
                        this.Close(); // Ferme le formulaire
                    }
                    else
                    {
                        MessageBox.Show("Erreur : la tâche n'a pas été enregistrée.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message);
            }

        }
    }
}

public class ComboboxItem
{
    public string Text { get; set; }
    public object Value { get; set; }

    public ComboboxItem(string text, object value)
    {
        Text = text;
        Value = value;
    }

    public override string ToString()
    {
        return Text;
    }
}
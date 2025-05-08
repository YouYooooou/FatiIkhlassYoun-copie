using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace FatiIkhlassYoun
{
    public partial class FormEditTask : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementSystem"].ConnectionString;

        public int TaskId { get; set; }

        public FormEditTask(int taskId)
        {
            InitializeComponent();
            this.TaskId = taskId;
            LoadTaskData();
        }

        private void LoadTaskData()
        {
            try
            {
                // Initialiser les ComboBox
                cmbStatus.Items.AddRange(new string[] { "Terminée", "En cours", "En attente" });
                cmbPriority.Items.AddRange(new string[] { "Basse", "Moyenne", "Haute" });

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Charger la liste des projets
                    string projectsQuery = "SELECT ProjectID, Title FROM Projects";
                    SqlDataAdapter projectsAdapter = new SqlDataAdapter(projectsQuery, conn);
                    DataTable projectsTable = new DataTable();
                    projectsAdapter.Fill(projectsTable);

                    cmbProject.DisplayMember = "Title";
                    cmbProject.ValueMember = "ProjectID";
                    cmbProject.DataSource = projectsTable;

                    // Charger la liste des chefs d'équipe
                    string leadsQuery = "SELECT UserID, Username FROM Users WHERE Role = 'chef_equipe' ";
                    SqlDataAdapter leadsAdapter = new SqlDataAdapter(leadsQuery, conn);
                    DataTable leadsTable = new DataTable();
                    leadsAdapter.Fill(leadsTable);

                    cmbTeamLead.DisplayMember = "Username";
                    cmbTeamLead.ValueMember = "UserID";
                    cmbTeamLead.DataSource = leadsTable;

                    // Charger la liste des utilisateurs
                    string usersQuery = "SELECT UserID, Username FROM Users";
                    SqlDataAdapter usersAdapter = new SqlDataAdapter(usersQuery, conn);
                    DataTable usersTable = new DataTable();
                    usersAdapter.Fill(usersTable);

                    clbAssignedUsers.Items.Clear();
                    foreach (DataRow row in usersTable.Rows)
                    {
                        clbAssignedUsers.Items.Add(
                            new ComboboxItem(
                                row["Username"].ToString(),
                                Convert.ToInt32(row["UserID"])
                            ),
                            false // Non coché par défaut
                        );
                    }
                    // Charger les données de la tâche
                    string taskQuery = "SELECT * FROM Tasks WHERE TaskID = @TaskID";
                    SqlCommand taskCmd = new SqlCommand(taskQuery, conn);
                    taskCmd.Parameters.AddWithValue("@TaskID", TaskId);

                    using (SqlDataReader reader = taskCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtTitle.Text = reader["Title"].ToString();
                            txtDescription.Text = reader["Description"].ToString();
                            dtpStartDate.Value = Convert.ToDateTime(reader["StartDate"]);
                            dtpDueDate.Value = Convert.ToDateTime(reader["DueDate"]);
                            cmbStatus.SelectedItem = reader["Status"].ToString();
                            cmbPriority.SelectedItem = reader["Priority"].ToString();
                            numEstimatedTime.Value = Convert.ToDecimal(reader["EstimatedTime"]);
                            if (reader["TeamLeadID"] != DBNull.Value)
                            {
                                int teamLeadId = Convert.ToInt32(reader["TeamLeadID"]);

                                // Vérifie si la valeur existe dans la liste
                                if (cmbTeamLead.Items.Cast<DataRowView>().Any(item => (int)item["UserID"] == teamLeadId))
                                {
                                    cmbTeamLead.SelectedValue = teamLeadId;
                                }
                            }

                            // Sélectionner le projet et le chef d'équipe
                            cmbProject.SelectedValue = reader["ProjectID"];
                            cmbTeamLead.SelectedValue = reader["TeamLeadID"];
                        }
                    }

                    // Charger les utilisateurs assignés
                    string assignedQuery = "SELECT UserID FROM Task_Assignments WHERE TaskID = @TaskID";
                    SqlCommand assignedCmd = new SqlCommand(assignedQuery, conn);
                    assignedCmd.Parameters.AddWithValue("@TaskID", TaskId);

                    DataTable assignedTable = new DataTable();
                    SqlDataAdapter assignedAdapter = new SqlDataAdapter(assignedCmd);
                    assignedAdapter.Fill(assignedTable);

                    // Cocher les utilisateurs assignés
                    foreach (DataRow row in assignedTable.Rows)
                    {
                        int userId = Convert.ToInt32(row["UserID"]);
                        for (int i = 0; i < clbAssignedUsers.Items.Count; i++)
                        {
                            var item = (ComboboxItem)clbAssignedUsers.Items[i];
                            if ((int)item.Value == userId)
                            {
                                clbAssignedUsers.SetItemChecked(i, true);
                                break;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation des champs
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Veuillez saisir un titre pour la tâche",
                              "Champ requis",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            if (cmbProject.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un projet",
                              "Champ requis",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Mise à jour de la tâche
                    string updateQuery = @"
                        UPDATE Tasks SET 
                            Title = @Title,
                            Description = @Description,
                            StartDate = @StartDate,
                            DueDate = @DueDate,
                            Status = @Status,
                            Priority = @Priority,
                            EstimatedTime = @EstimatedTime,
                            ProjectID = @ProjectID,
                            TeamLeadID = @TeamLeadID
                        WHERE TaskID = @TaskID";

                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@Title", txtTitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
                    cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value);
                    cmd.Parameters.AddWithValue("@DueDate", dtpDueDate.Value);
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Priority", cmbPriority.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EstimatedTime", numEstimatedTime.Value);
                    cmd.Parameters.AddWithValue("@ProjectID", ((DataRowView)cmbProject.SelectedItem)["ProjectID"]);
                    cmd.Parameters.AddWithValue("@TeamLeadID", ((DataRowView)cmbTeamLead.SelectedItem)["UserID"]);
                    cmd.Parameters.AddWithValue("@TaskID", TaskId);

                    cmd.ExecuteNonQuery();

                    // Mise à jour des affectations
                    UpdateTaskAssignments(conn);

                    MessageBox.Show("La tâche a été mise à jour avec succès !",
                                   "Succès",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour de la tâche : " + ex.Message,
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void UpdateTaskAssignments(SqlConnection conn)
        {
            // Supprimer toutes les affectations existantes
            string deleteQuery = "DELETE FROM Task_Assignments WHERE TaskID = @TaskID";
            SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
            deleteCmd.Parameters.AddWithValue("@TaskID", TaskId);
            deleteCmd.ExecuteNonQuery();

            // Ajouter les nouvelles affectations
            string insertQuery = "INSERT INTO Task_Assignments (TaskID, UserID) VALUES (@TaskID, @UserID)";

            foreach (var item in clbAssignedUsers.CheckedItems)
            {
                var userItem = (ComboboxItem)item;
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@TaskID", TaskId);
                insertCmd.Parameters.AddWithValue("@UserID", userItem.Value);
                insertCmd.ExecuteNonQuery();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clbAssignedUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void buttonUpdateTask_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender, e); // Réutilise la logique existante
        }

        private void FormEditTask_Load(object sender, EventArgs e)
        {

        }

        private void dtpDueDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
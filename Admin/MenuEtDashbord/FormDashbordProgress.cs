using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace FatiIkhlassYoun
{
    public partial class FormDashbordProgress : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementSystem"].ConnectionString;

        public FormDashbordProgress()
        {
            InitializeComponent();
        }

        private void FormDashbordProgress_Load(object sender, EventArgs e)
        {
            LoadTeams();
            LoadProjects();
            dtpStart.Value = DateTime.Today.AddMonths(-1);
            dtpEnd.Value = DateTime.Today;
            RefreshDashboard();
        }

        private void LoadTeams()
        {
            if (cmbTeams != null)
            {
                cmbTeams.Items = new string[0];  // Clear items by resetting the array
                cmbTeams.AddItem("Toutes les équipes"); // Use AddItem to add items

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT TeamID, Name FROM Teams", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbTeams.AddItem(reader["Name"].ToString());  // Add each team to the combo box
                    }
                }

                if (cmbTeams.Items.Length > 0)
                {
                    cmbTeams.SelectedItem = cmbTeams.Items[0];  // Select the first item
                }
            }
        }

        private void LoadProjects()
        {
            if (cmbProjects != null)
            {
                cmbProjects.Items = new string[0];  // Clear items by resetting the array
                cmbProjects.AddItem("Tous les projets"); // Add the default item

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT ProjectID, Title FROM Projects", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbProjects.AddItem(new ComboboxItem(reader["Title"].ToString(), reader["ProjectID"]).ToString());
                    }
                }

                if (cmbProjects.Items.Length > 0)
                {
                    cmbProjects.SelectedItem = cmbProjects.Items[0];  // Select the first project
                }
            }
        }



        private void RefreshDashboard()
        {
            LoadTeamDetails();
            UpdateProgressBars();
            UpdateChart();
            LoadAlerts();
        }

        private void LoadTeamDetails()
        {
            string query = @"SELECT T.Name AS TeamName, COUNT(DISTINCT TA.TaskID) AS TotalTasks, 
                            SUM(CASE WHEN K.Status = 'Terminée' THEN 1 ELSE 0 END) AS CompletedTasks
                            FROM Teams T
                            LEFT JOIN TeamMembers TM ON T.TeamID = TM.TeamID
                            LEFT JOIN Task_Assignments TA ON TM.UserID = TA.UserID
                            LEFT JOIN Tasks K ON TA.TaskID = K.TaskID
                            WHERE K.StartDate >= @StartDate AND K.DueDate <= @EndDate
                            GROUP BY T.Name";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@StartDate", dtpStart.Value.Date);
                cmd.Parameters.AddWithValue("@EndDate", dtpEnd.Value.Date);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTeamDetails.DataSource = dt;
            }
        }

        private void UpdateProgressBars()
        {
            string query = @"SELECT 
                COUNT(*) AS TotalTasks,
                SUM(CASE WHEN Status = 'Terminée' THEN 1 ELSE 0 END) AS Completed,
                SUM(CASE WHEN Status = 'En cours' THEN 1 ELSE 0 END) AS InProgress
                FROM Tasks
                WHERE StartDate >= @StartDate AND DueDate <= @EndDate";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@StartDate", dtpStart.Value.Date);
                cmd.Parameters.AddWithValue("@EndDate", dtpEnd.Value.Date);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int total = Convert.ToInt32(reader["TotalTasks"]);
                    int done = Convert.ToInt32(reader["Completed"]);
                    int inProgress = Convert.ToInt32(reader["InProgress"]);

                    progressTaskCompletion.Value = total > 0 ? done * 100 / total : 0;
                    progressProjectAdvancement.Value = total > 0 ? inProgress * 100 / total : 0;
                    cuiProgressProjet2.Value = total > 0 ? (done + inProgress) * 100 / total : 0;
                }
            }
        }

        private void UpdateChart()
        {
            // Initializing the chart with CuoreUI controls
            var chart = new CuiChartPie
            {
                DataPoints = new string[0] // Reset the data points
            };

            string query = @"SELECT Status, COUNT(*) AS Count
                             FROM Tasks
                             WHERE StartDate >= @StartDate AND DueDate <= @EndDate
                             GROUP BY Status";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@StartDate", dtpStart.Value.Date);
                cmd.Parameters.AddWithValue("@EndDate", dtpEnd.Value.Date);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                List<string> dataPoints = new List<string>();
                while (reader.Read())
                {
                    string status = reader["Status"].ToString();
                    int count = Convert.ToInt32(reader["Count"]);
                    dataPoints.Add($"{status}: {count}");
                }
                chart.DataPoints = dataPoints.ToArray(); // Add data points to the chart
            }

            // Optionally, you can add the chart to the form's controls
            this.Controls.Add(chart); // If needed
        }

        private void LoadAlerts()
        {
            listBoxAlerts.Items.Clear();

            string query = @"SELECT Title, DueDate
                             FROM Tasks
                             WHERE DueDate < GETDATE() AND Status != 'Terminée'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string alert = $"⚠️ {reader["Title"]} (Échéance : {Convert.ToDateTime(reader["DueDate"]).ToShortDateString()})";
                    listBoxAlerts.Items.Add(alert);
                }
            }
        }

        private void cuiButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form
        }

        private void cuiChartPie_Load(object sender, EventArgs e)
        {

        }

        private void progressProjectAdvancement_Load(object sender, EventArgs e)
        {

        }

        private void cuiProgressProjet2_Load(object sender, EventArgs e)
        {

        }

        private void cmbTeams_Load(object sender, EventArgs e)
        {

        }

        private void cmbProjects_Load(object sender, EventArgs e)
        {

        }

        private void dtpStart_Load(object sender, EventArgs e)
        {

        }

        private void dtpEnd_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            RefreshDashboard();
        }

        private void dgvTeamDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBoxAlerts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    internal class CuiChartPie : Control
    {
        public string[] DataPoints { get; set; }
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
}

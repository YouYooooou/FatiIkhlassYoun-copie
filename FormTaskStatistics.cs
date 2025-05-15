using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FatiIkhlassYoun
{
    public partial class FormTaskStatistics : Form
    {
        private string connectionString = "Data Source=DESKTOP-78OLGDN;Initial Catalog=ProjectManagementSystem;Integrated Security=True";

        public FormTaskStatistics()
        {
            InitializeComponent();
        }

        private void FormTaskStatistics_Load(object sender, EventArgs e)
        {
            LoadTeams();
            LoadProjects();
            dtpStart.Value = DateTime.Today.AddMonths(-1);
            dtpEnd.Value = DateTime.Today;

            // Initialize charts
            InitializeCharts();
        }

        private void InitializeCharts()
        {
            // Task Status Chart
            chartTaskStatus.Palette = ChartColorPalette.Pastel;
            chartTaskStatus.Titles.Add("Task Status Distribution");

            // Task Priority Chart
            chartTaskPriority.Palette = ChartColorPalette.EarthTones;
            chartTaskPriority.Titles.Add("Task Priority Distribution");
        }

        private void LoadTeams()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT TeamID, Name FROM Teams";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbTeams.DataSource = dt;
                    cmbTeams.DisplayMember = "Name";
                    cmbTeams.ValueMember = "TeamID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading teams: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProjects()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT ProjectID, Title FROM Projects";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbProjects.DataSource = dt;
                    cmbProjects.DisplayMember = "Title";
                    cmbProjects.ValueMember = "ProjectID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading projects: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTeams.SelectedValue != null)
            {
                LoadPerformanceData();
            }
        }

        private void cmbProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProjects.SelectedValue != null)
            {
                LoadPerformanceData();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPerformanceData();
        }

        private void LoadPerformanceData()
        {
            if (cmbTeams.SelectedValue == null || cmbProjects.SelectedValue == null)
                return;

            int selectedTeamId = Convert.ToInt32(cmbTeams.SelectedValue);
            int selectedProjectId = Convert.ToInt32(cmbProjects.SelectedValue);
            DateTime startDate = dtpStart.Value;
            DateTime endDate = dtpEnd.Value;

            LoadTaskProgress(selectedTeamId, selectedProjectId, startDate, endDate);
            LoadProjectProgress(selectedProjectId);
            LoadTeamPerformance(selectedTeamId, selectedProjectId, startDate, endDate);
            LoadProjectStatistics(selectedProjectId);
            LoadAlerts(selectedProjectId);
            LoadTaskDistributionCharts(selectedProjectId);
        }

        private void LoadTaskProgress(int teamId, int projectId, DateTime startDate, DateTime endDate)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT 
                            COUNT(*) AS TotalTasks,
                            SUM(CASE WHEN Status = 'Terminée' THEN 1 ELSE 0 END) AS CompletedTasks
                        FROM Tasks
                        WHERE ProjectID = @ProjectID
                          AND TaskID IN (
                              SELECT TaskID FROM Task_Assignments
                              WHERE UserID IN (
                                  SELECT UserID FROM TeamMembers WHERE TeamID = @TeamID
                              )
                          )
                          AND StartDate >= @StartDate AND DueDate <= @EndDate";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TeamID", teamId);
                    cmd.Parameters.AddWithValue("@ProjectID", projectId);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int totalTasks = reader.GetInt32(0);
                        int completedTasks = reader.GetInt32(1);

                        progressTasks.Maximum = totalTasks > 0 ? totalTasks : 1;
                        progressTasks.Value = completedTasks;

                        double percentage = totalTasks > 0 ? (completedTasks * 100.0 / totalTasks) : 0;
                        lblTaskPercentage.Text = $"{percentage:0}%";
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading task progress: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProjectProgress(int projectId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT 
                            COUNT(*) AS TotalTasks,
                            SUM(CASE WHEN Status = 'Terminée' THEN 1 ELSE 0 END) AS CompletedTasks
                        FROM Tasks
                        WHERE ProjectID = @ProjectID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProjectID", projectId);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int totalTasks = reader.GetInt32(0);
                        int completedTasks = reader.GetInt32(1);

                        progressProject.Maximum = totalTasks > 0 ? totalTasks : 1;
                        progressProject.Value = completedTasks;

                        double percentage = totalTasks > 0 ? (completedTasks * 100.0 / totalTasks) : 0;
                        lblProjectPercentage.Text = $"{percentage:0}%";
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading project progress: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTeamPerformance(int teamId, int projectId, DateTime startDate, DateTime endDate)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT 
                            u.UserID,
                            u.Username,
                            COUNT(ta.TaskID) AS TotalTasks,
                            SUM(CASE WHEN t.Status = 'Terminée' THEN 1 ELSE 0 END) AS CompletedTasks,
                            ROUND(100.0 * SUM(CASE WHEN t.Status = 'Terminée' THEN 1 ELSE 0 END) / COUNT(ta.TaskID), 2) AS CompletionRate,
                            SUM(CASE WHEN t.Status = 'Terminée' AND t.CompletionDate <= t.DueDate THEN 1 ELSE 0 END) AS OnTimeTasks,
                            ROUND(100.0 * SUM(CASE WHEN t.Status = 'Terminée' AND t.CompletionDate <= t.DueDate THEN 1 ELSE 0 END) / 
                                NULLIF(SUM(CASE WHEN t.Status = 'Terminée' THEN 1 ELSE 0 END), 0), 2) AS PunctualityRate
                        FROM Users u
                        JOIN Task_Assignments ta ON u.UserID = ta.UserID
                        JOIN Tasks t ON ta.TaskID = t.TaskID
                        WHERE u.UserID IN (SELECT UserID FROM TeamMembers WHERE TeamID = @TeamID)
                          AND t.ProjectID = @ProjectID
                          AND t.StartDate >= @StartDate AND t.DueDate <= @EndDate
                        GROUP BY u.UserID, u.Username";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@TeamID", teamId);
                    adapter.SelectCommand.Parameters.AddWithValue("@ProjectID", projectId);
                    adapter.SelectCommand.Parameters.AddWithValue("@StartDate", startDate);
                    adapter.SelectCommand.Parameters.AddWithValue("@EndDate", endDate);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvTeamStats.DataSource = dt;
                    FormatTeamPerformanceGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading team performance: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatTeamPerformanceGrid()
        {
            dgvTeamStats.Columns["UserID"].Visible = false;
            dgvTeamStats.Columns["Username"].HeaderText = "Team Member";
            dgvTeamStats.Columns["TotalTasks"].HeaderText = "Total Tasks";
            dgvTeamStats.Columns["CompletedTasks"].HeaderText = "Completed";
            dgvTeamStats.Columns["CompletionRate"].HeaderText = "Completion %";
            dgvTeamStats.Columns["OnTimeTasks"].HeaderText = "On Time";
            dgvTeamStats.Columns["PunctualityRate"].HeaderText = "Punctuality %";

            foreach (DataGridViewColumn column in dgvTeamStats.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void LoadProjectStatistics(int projectId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT 
                            p.Title AS Project,
                            COUNT(t.TaskID) AS TotalTasks,
                            SUM(CASE WHEN t.Status = 'Terminée' THEN 1 ELSE 0 END) AS CompletedTasks,
                            SUM(CASE WHEN t.Status = 'En cours' THEN 1 ELSE 0 END) AS InProgressTasks,
                            SUM(CASE WHEN t.Status = 'En attente' THEN 1 ELSE 0 END) AS PendingTasks,
                            COUNT(DISTINCT tm.UserID) AS TeamMembers,
                            COUNT(DISTINCT t.TeamLeadID) AS TeamLeads,
                            MIN(t.StartDate) AS EarliestStart,
                            MAX(t.DueDate) AS LatestDue
                        FROM Projects p
                        LEFT JOIN Tasks t ON p.ProjectID = t.ProjectID
                        LEFT JOIN Task_Assignments ta ON t.TaskID = ta.TaskID
                        LEFT JOIN TeamMembers tm ON ta.UserID = tm.UserID
                        WHERE p.ProjectID = @ProjectID
                        GROUP BY p.Title";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@ProjectID", projectId);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvProjectStats.DataSource = dt;
                    FormatProjectStatsGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading project statistics: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatProjectStatsGrid()
        {
            foreach (DataGridViewColumn column in dgvProjectStats.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void LoadAlerts(int projectId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT 
                            'Overdue Task: ' + t.Title AS AlertMessage
                        FROM Tasks t
                        WHERE t.ProjectID = @ProjectID
                          AND t.Status <> 'Terminée'
                          AND t.DueDate < GETDATE()
                        
                        UNION ALL
                        
                        SELECT 
                            'Task without assignee: ' + t.Title AS AlertMessage
                        FROM Tasks t
                        LEFT JOIN Task_Assignments ta ON t.TaskID = ta.TaskID
                        WHERE t.ProjectID = @ProjectID
                          AND ta.TaskID IS NULL";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProjectID", projectId);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    listBoxAlerts.Items.Clear();
                    while (reader.Read())
                    {
                        listBoxAlerts.Items.Add(reader.GetString(0));
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading alerts: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTaskDistributionCharts(int projectId)
        {
            LoadTaskStatusChart(projectId);
            LoadTaskPriorityChart(projectId);
        }

        private void LoadTaskStatusChart(int projectId)
        {
            try
            {
                chartTaskStatus.Series["Status"].Points.Clear();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT 
                            Status,
                            COUNT(*) AS TaskCount
                        FROM Tasks
                        WHERE ProjectID = @ProjectID
                        GROUP BY Status";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProjectID", projectId);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string status = reader.GetString(0);
                        int count = reader.GetInt32(1);
                        chartTaskStatus.Series["Status"].Points.AddXY(status, count);
                    }

                    reader.Close();
                }

                chartTaskStatus.Series["Status"].ChartType = SeriesChartType.Pie;
                chartTaskStatus.Series["Status"]["PieLabelStyle"] = "Outside";
                chartTaskStatus.Series["Status"]["PieLineColor"] = "Black";
                chartTaskStatus.Series["Status"].Label = "#PERCENT{P0}";
                chartTaskStatus.Series["Status"].LegendText = "#VALX (#VALY)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading task status chart: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTaskPriorityChart(int projectId)
        {
            try
            {
                chartTaskPriority.Series["Priority"].Points.Clear();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT 
                            Priority,
                            COUNT(*) AS TaskCount
                        FROM Tasks
                        WHERE ProjectID = @ProjectID
                        GROUP BY Priority";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProjectID", projectId);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string priority = reader.GetString(0);
                        int count = reader.GetInt32(1);
                        chartTaskPriority.Series["Priority"].Points.AddXY(priority, count);
                    }

                    reader.Close();
                }

                chartTaskPriority.Series["Priority"].ChartType = SeriesChartType.Doughnut;
                chartTaskPriority.Series["Priority"]["DoughnutRadius"] = "60";
                chartTaskPriority.Series["Priority"]["PieLabelStyle"] = "Outside";
                chartTaskPriority.Series["Priority"]["PieLineColor"] = "Black";
                chartTaskPriority.Series["Priority"].Label = "#PERCENT{P0}";
                chartTaskPriority.Series["Priority"].LegendText = "#VALX (#VALY)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading task priority chart: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel File|*.xlsx";
                saveFileDialog.Title = "Save Statistics Report";
                saveFileDialog.FileName = $"ProjectStatistics_{DateTime.Now:yyyyMMdd}.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // TODO: Implement export to Excel functionality
                    MessageBox.Show("Export functionality will be implemented here", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
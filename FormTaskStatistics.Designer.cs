namespace FatiIkhlassYoun
{
    partial class FormTaskStatistics
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelMain;
        private Panel panelFilters;
        private ComboBox cmbTeams;
        private ComboBox cmbProjects;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Button btnRefresh;
        private Button btnExport;
        private Panel panelStats;
        private Panel panelTaskProgress;
        private Label lblTaskProgress;
        private ProgressBar progressTasks;
        private Label lblTaskPercentage;
        private Panel panelProjectProgress;
        private Label lblProjectProgress;
        private ProgressBar progressProject;
        private Label lblProjectPercentage;
        private Panel panelTeamStats;
        private Label lblTeamPerformance;
        private DataGridView dgvTeamStats;
        private Panel panelAlerts;
        private Label lblAlerts;
        private ListBox listBoxAlerts;
        private Panel panelProjectStats;
        private Label lblProjectStats;
        private DataGridView dgvProjectStats;
        private Panel panelTaskDistribution;
        private Label lblTaskDistribution;
        private Chart chartTaskStatus;
        private Chart chartTaskPriority;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTaskDistribution = new System.Windows.Forms.Panel();
            this.chartTaskPriority = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTaskStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTaskDistribution = new System.Windows.Forms.Label();
            this.panelProjectStats = new System.Windows.Forms.Panel();
            this.dgvProjectStats = new System.Windows.Forms.DataGridView();
            this.lblProjectStats = new System.Windows.Forms.Label();
            this.panelAlerts = new System.Windows.Forms.Panel();
            this.listBoxAlerts = new System.Windows.Forms.ListBox();
            this.lblAlerts = new System.Windows.Forms.Label();
            this.panelTeamStats = new System.Windows.Forms.Panel();
            this.dgvTeamStats = new System.Windows.Forms.DataGridView();
            this.lblTeamPerformance = new System.Windows.Forms.Label();
            this.panelProjectProgress = new System.Windows.Forms.Panel();
            this.lblProjectPercentage = new System.Windows.Forms.Label();
            this.progressProject = new System.Windows.Forms.ProgressBar();
            this.lblProjectProgress = new System.Windows.Forms.Label();
            this.panelTaskProgress = new System.Windows.Forms.Panel();
            this.lblTaskPercentage = new System.Windows.Forms.Label();
            this.progressTasks = new System.Windows.Forms.ProgressBar();
            this.lblTaskProgress = new System.Windows.Forms.Label();
            this.panelStats = new System.Windows.Forms.Panel();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.cmbProjects = new System.Windows.Forms.ComboBox();
            this.cmbTeams = new System.Windows.Forms.ComboBox();
            this.btnCancel = new CuoreUI.Controls.cuiButton();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelTaskDistribution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTaskPriority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTaskStatus)).BeginInit();
            this.panelProjectStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectStats)).BeginInit();
            this.panelAlerts.SuspendLayout();
            this.panelTeamStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamStats)).BeginInit();
            this.panelProjectProgress.SuspendLayout();
            this.panelTaskProgress.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.panelFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41))), ((int)(((byte)(53))), ((int)(((byte)(65)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1350, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(415, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Project & Task Statistics Dashboard";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelTaskDistribution);
            this.panelMain.Controls.Add(this.panelProjectStats);
            this.panelMain.Controls.Add(this.panelAlerts);
            this.panelMain.Controls.Add(this.panelTeamStats);
            this.panelMain.Controls.Add(this.panelProjectProgress);
            this.panelMain.Controls.Add(this.panelTaskProgress);
            this.panelMain.Controls.Add(this.panelStats);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 80);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(1350, 770);
            this.panelMain.TabIndex = 1;
            // 
            // panelTaskDistribution
            // 
            this.panelTaskDistribution.BackColor = System.Drawing.Color.White;
            this.panelTaskDistribution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTaskDistribution.Controls.Add(this.chartTaskPriority);
            this.panelTaskDistribution.Controls.Add(this.chartTaskStatus);
            this.panelTaskDistribution.Controls.Add(this.lblTaskDistribution);
            this.panelTaskDistribution.Location = new System.Drawing.Point(23, 403);
            this.panelTaskDistribution.Name = "panelTaskDistribution";
            this.panelTaskDistribution.Size = new System.Drawing.Size(650, 344);
            this.panelTaskDistribution.TabIndex = 6;
            // 
            // chartTaskPriority
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTaskPriority.ChartAreas.Add(chartArea1);
            this.chartTaskPriority.Dock = System.Windows.Forms.DockStyle.Right;
            legend1.Name = "Legend1";
            this.chartTaskPriority.Legends.Add(legend1);
            this.chartTaskPriority.Location = new System.Drawing.Point(323, 40);
            this.chartTaskPriority.Name = "chartTaskPriority";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Priority";
            this.chartTaskPriority.Series.Add(series1);
            this.chartTaskPriority.Size = new System.Drawing.Size(325, 302);
            this.chartTaskPriority.TabIndex = 2;
            this.chartTaskPriority.Text = "chart2";
            // 
            // chartTaskStatus
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTaskStatus.ChartAreas.Add(chartArea2);
            this.chartTaskStatus.Dock = System.Windows.Forms.DockStyle.Left;
            legend2.Name = "Legend1";
            this.chartTaskStatus.Legends.Add(legend2);
            this.chartTaskStatus.Location = new System.Drawing.Point(0, 40);
            this.chartTaskStatus.Name = "chartTaskStatus";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Status";
            this.chartTaskStatus.Series.Add(series2);
            this.chartTaskStatus.Size = new System.Drawing.Size(325, 302);
            this.chartTaskStatus.TabIndex = 1;
            this.chartTaskStatus.Text = "chart1";
            // 
            // lblTaskDistribution
            // 
            this.lblTaskDistribution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41))), ((int)(((byte)(53))), ((int)(((byte)(65)))));
            this.lblTaskDistribution.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTaskDistribution.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskDistribution.ForeColor = System.Drawing.Color.White;
            this.lblTaskDistribution.Location = new System.Drawing.Point(0, 0);
            this.lblTaskDistribution.Name = "lblTaskDistribution";
            this.lblTaskDistribution.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTaskDistribution.Size = new System.Drawing.Size(650, 40);
            this.lblTaskDistribution.TabIndex = 0;
            this.lblTaskDistribution.Text = "Task Distribution";
            this.lblTaskDistribution.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelProjectStats
            // 
            this.panelProjectStats.BackColor = System.Drawing.Color.White;
            this.panelProjectStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProjectStats.Controls.Add(this.dgvProjectStats);
            this.panelProjectStats.Controls.Add(this.lblProjectStats);
            this.panelProjectStats.Location = new System.Drawing.Point(679, 403);
            this.panelProjectStats.Name = "panelProjectStats";
            this.panelProjectStats.Size = new System.Drawing.Size(648, 344);
            this.panelProjectStats.TabIndex = 5;
            // 
            // dgvProjectStats
            // 
            this.dgvProjectStats.BackgroundColor = System.Drawing.Color.White;
            this.dgvProjectStats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProjectStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProjectStats.Location = new System.Drawing.Point(0, 40);
            this.dgvProjectStats.Name = "dgvProjectStats";
            this.dgvProjectStats.ReadOnly = true;
            this.dgvProjectStats.RowHeadersVisible = false;
            this.dgvProjectStats.Size = new System.Drawing.Size(648, 302);
            this.dgvProjectStats.TabIndex = 1;
            // 
            // lblProjectStats
            // 
            this.lblProjectStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41))), ((int)(((byte)(53))), ((int)(((byte)(65)))));
            this.lblProjectStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProjectStats.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectStats.ForeColor = System.Drawing.Color.White;
            this.lblProjectStats.Location = new System.Drawing.Point(0, 0);
            this.lblProjectStats.Name = "lblProjectStats";
            this.lblProjectStats.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblProjectStats.Size = new System.Drawing.Size(648, 40);
            this.lblProjectStats.TabIndex = 0;
            this.lblProjectStats.Text = "Project Statistics";
            this.lblProjectStats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelAlerts
            // 
            this.panelAlerts.BackColor = System.Drawing.Color.White;
            this.panelAlerts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAlerts.Controls.Add(this.listBoxAlerts);
            this.panelAlerts.Controls.Add(this.lblAlerts);
            this.panelAlerts.Location = new System.Drawing.Point(679, 203);
            this.panelAlerts.Name = "panelAlerts";
            this.panelAlerts.Size = new System.Drawing.Size(648, 194);
            this.panelAlerts.TabIndex = 4;
            // 
            // listBoxAlerts
            // 
            this.listBoxAlerts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxAlerts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxAlerts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAlerts.FormattingEnabled = true;
            this.listBoxAlerts.ItemHeight = 17;
            this.listBoxAlerts.Location = new System.Drawing.Point(0, 40);
            this.listBoxAlerts.Name = "listBoxAlerts";
            this.listBoxAlerts.Size = new System.Drawing.Size(648, 154);
            this.listBoxAlerts.TabIndex = 1;
            // 
            // lblAlerts
            // 
            this.lblAlerts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41))), ((int)(((byte)(53))), ((int)(((byte)(65)))));
            this.lblAlerts.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAlerts.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlerts.ForeColor = System.Drawing.Color.White;
            this.lblAlerts.Location = new System.Drawing.Point(0, 0);
            this.lblAlerts.Name = "lblAlerts";
            this.lblAlerts.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblAlerts.Size = new System.Drawing.Size(648, 40);
            this.lblAlerts.TabIndex = 0;
            this.lblAlerts.Text = "Alerts & Notifications";
            this.lblAlerts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTeamStats
            // 
            this.panelTeamStats.BackColor = System.Drawing.Color.White;
            this.panelTeamStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTeamStats.Controls.Add(this.dgvTeamStats);
            this.panelTeamStats.Controls.Add(this.lblTeamPerformance);
            this.panelTeamStats.Location = new System.Drawing.Point(23, 203);
            this.panelTeamStats.Name = "panelTeamStats";
            this.panelTeamStats.Size = new System.Drawing.Size(650, 194);
            this.panelTeamStats.TabIndex = 3;
            // 
            // dgvTeamStats
            // 
            this.dgvTeamStats.BackgroundColor = System.Drawing.Color.White;
            this.dgvTeamStats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTeamStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeamStats.Location = new System.Drawing.Point(0, 40);
            this.dgvTeamStats.Name = "dgvTeamStats";
            this.dgvTeamStats.ReadOnly = true;
            this.dgvTeamStats.RowHeadersVisible = false;
            this.dgvTeamStats.Size = new System.Drawing.Size(650, 154);
            this.dgvTeamStats.TabIndex = 1;
            // 
            // lblTeamPerformance
            // 
            this.lblTeamPerformance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41))), ((int)(((byte)(53))), ((int)(((byte)(65)))));
            this.lblTeamPerformance.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTeamPerformance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamPerformance.ForeColor = System.Drawing.Color.White;
            this.lblTeamPerformance.Location = new System.Drawing.Point(0, 0);
            this.lblTeamPerformance.Name = "lblTeamPerformance";
            this.lblTeamPerformance.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTeamPerformance.Size = new System.Drawing.Size(650, 40);
            this.lblTeamPerformance.TabIndex = 0;
            this.lblTeamPerformance.Text = "Team Performance";
            this.lblTeamPerformance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelProjectProgress
            // 
            this.panelProjectProgress.BackColor = System.Drawing.Color.White;
            this.panelProjectProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProjectProgress.Controls.Add(this.lblProjectPercentage);
            this.panelProjectProgress.Controls.Add(this.progressProject);
            this.panelProjectProgress.Controls.Add(this.lblProjectProgress);
            this.panelProjectProgress.Location = new System.Drawing.Point(679, 23);
            this.panelProjectProgress.Name = "panelProjectProgress";
            this.panelProjectProgress.Size = new System.Drawing.Size(648, 174);
            this.panelProjectProgress.TabIndex = 2;
            // 
            // lblProjectPercentage
            // 
            this.lblProjectPercentage.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41))), ((int)(((byte)(53))), ((int)(((byte)(65)))));
            this.lblProjectPercentage.Location = new System.Drawing.Point(20, 80);
            this.lblProjectPercentage.Name = "lblProjectPercentage";
            this.lblProjectPercentage.Size = new System.Drawing.Size(120, 50);
            this.lblProjectPercentage.TabIndex = 2;
            this.lblProjectPercentage.Text = "0%";
            this.lblProjectPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressProject
            // 
            this.progressProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76))), ((int)(((byte)(175))), ((int)(((byte)(80)))));
            this.progressProject.Location = new System.Drawing.Point(160, 80);
            this.progressProject.Name = "progressProject";
            this.progressProject.Size = new System.Drawing.Size(460, 50);
            this.progressProject.TabIndex = 1;
            // 
            // lblProjectProgress
            // 
            this.lblProjectProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41))), ((int)(((byte)(53))), ((int)(((byte)(65)))));
            this.lblProjectProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProjectProgress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectProgress.ForeColor = System.Drawing.Color.White;
            this.lblProjectProgress.Location = new System.Drawing.Point(0, 0);
            this.lblProjectProgress.Name = "lblProjectProgress";
            this.lblProjectProgress.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblProjectProgress.Size = new System.Drawing.Size(648, 40);
            this.lblProjectProgress.TabIndex = 0;
            this.lblProjectProgress.Text = "Project Progress";
            this.lblProjectProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTaskProgress
            // 
            this.panelTaskProgress.BackColor = System.Drawing.Color.White;
            this.panelTaskProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTaskProgress.Controls.Add(this.lblTaskPercentage);
            this.panelTaskProgress.Controls.Add(this.progressTasks);
            this.panelTaskProgress.Controls.Add(this.lblTaskProgress);
            this.panelTaskProgress.Location = new System.Drawing.Point(23, 23);
            this.panelTaskProgress.Name = "panelTaskProgress";
            this.panelTaskProgress.Size = new System.Drawing.Size(650, 174);
            this.panelTaskProgress.TabIndex = 1;
            // 
            // lblTaskPercentage
            // 
            this.lblTaskPercentage.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41))), ((int)(((byte)(53))), ((int)(((byte)(65)))));
            this.lblTaskPercentage.Location = new System.Drawing.Point(20, 80);
            this.lblTaskPercentage.Name = "lblTaskPercentage";
            this.lblTaskPercentage.Size = new System.Drawing.Size(120, 50);
            this.lblTaskPercentage.TabIndex = 2;
            this.lblTaskPercentage.Text = "0%";
            this.lblTaskPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressTasks
            // 
            this.progressTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33))), ((int)(((byte)(150))), ((int)(((byte)(243)))));
            this.progressTasks.Location = new System.Drawing.Point(160, 80);
            this.progressTasks.Name = "progressTasks";
            this.progressTasks.Size = new System.Drawing.Size(460, 50);
            this.progressTasks.TabIndex = 1;
            // 
            // lblTaskProgress
            // 
            this.lblTaskProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41))), ((int)(((byte)(53))), ((int)(((byte)(65)))));
            this.lblTaskProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTaskProgress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskProgress.ForeColor = System.Drawing.Color.White;
            this.lblTaskProgress.Location = new System.Drawing.Point(0, 0);
            this.lblTaskProgress.Name = "lblTaskProgress";
            this.lblTaskProgress.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTaskProgress.Size = new System.Drawing.Size(650, 40);
            this.lblTaskProgress.TabIndex = 0;
            this.lblTaskProgress.Text = "Task Progress";
            this.lblTaskProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelStats
            // 
            this.panelStats.BackColor = System.Drawing.Color.White;
            this.panelStats.Controls.Add(this.panelFilters);
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStats.Location = new System.Drawing.Point(20, 20);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(1310, 0);
            this.panelStats.TabIndex = 0;
            // 
            // panelFilters
            // 
            this.panelFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250))), ((int)(((byte)(250))), ((int)(((byte)(250)))));
            this.panelFilters.Controls.Add(this.btnExport);
            this.panelFilters.Controls.Add(this.btnRefresh);
            this.panelFilters.Controls.Add(this.label4);
            this.panelFilters.Controls.Add(this.label3);
            this.panelFilters.Controls.Add(this.label2);
            this.panelFilters.Controls.Add(this.label1);
            this.panelFilters.Controls.Add(this.dtpEnd);
            this.panelFilters.Controls.Add(this.dtpStart);
            this.panelFilters.Controls.Add(this.cmbProjects);
            this.panelFilters.Controls.Add(this.cmbTeams);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Location = new System.Drawing.Point(0, 0);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(1310, 100);
            this.panelFilters.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41))), ((int)(((byte)(53))), ((int)(((byte)(65)))));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Image = global::FatiIkhlassYoun.Properties.Resources.icons8_export_24;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(1150, 30);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 40);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33))), ((int)(((byte)(150))), ((int)(((byte)(243)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::FatiIkhlassYoun.Properties.Resources.icons8_refresh_24;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(1020, 30);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 40);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(880, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(600, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Project";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Team";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpEnd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(880, 30);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(120, 25);
            this.dtpEnd.TabIndex = 3;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "dd/MM/yyyy";
            this.dtpStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(600, 30);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(120, 25);
            this.dtpStart.TabIndex = 2;
            // 
            // cmbProjects
            // 
            this.cmbProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjects.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProjects.FormattingEnabled = true;
            this.cmbProjects.Location = new System.Drawing.Point(300, 30);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(280, 25);
            this.cmbProjects.TabIndex = 1;
            this.cmbProjects.SelectedIndexChanged += new System.EventHandler(this.cmbProjects_SelectedIndexChanged);
            // 
            // cmbTeams
            // 
            this.cmbTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeams.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTeams.FormattingEnabled = true;
            this.cmbTeams.Location = new System.Drawing.Point(20, 30);
            this.cmbTeams.Name = "cmbTeams";
            this.cmbTeams.Size = new System.Drawing.Size(260, 25);
            this.cmbTeams.TabIndex = 0;
            this.cmbTeams.SelectedIndexChanged += new System.EventHandler(this.cmbTeams_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.CheckButton = false;
            this.btnCancel.Checked = false;
            this.btnCancel.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200))), ((int)(((byte)(35))), ((int)(((byte)(51)))));
            this.btnCancel.CheckedForeColor = System.Drawing.Color.White;
            this.btnCancel.CheckedImageTint = System.Drawing.Color.White;
            this.btnCancel.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(200))), ((int)(((byte)(35))), ((int)(((byte)(51)))));
            this.btnCancel.Content = "Close";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200))), ((int)(((byte)(35))), ((int)(((byte)(51)))));
            this.btnCancel.HoveredImageTint = System.Drawing.Color.White;
            this.btnCancel.HoverForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverOutline = System.Drawing.Color.Empty;
            this.btnCancel.Image = null;
            this.btnCancel.ImageAutoCenter = true;
            this.btnCancel.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnCancel.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCancel.Location = new System.Drawing.Point(1200, 820);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(223))), ((int)(((byte)(53))), ((int)(((byte)(69)))));
            this.btnCancel.NormalForeColor = System.Drawing.Color.White;
            this.btnCancel.NormalImageTint = System.Drawing.Color.White;
            this.btnCancel.NormalOutline = System.Drawing.Color.Empty;
            this.btnCancel.OutlineThickness = 1.6F;
            this.btnCancel.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(210))), ((int)(((byte)(35))), ((int)(((byte)(51)))));
            this.btnCancel.PressedForeColor = System.Drawing.Color.White;
            this.btnCancel.PressedImageTint = System.Drawing.Color.White;
            this.btnCancel.PressedOutline = System.Drawing.Color.Empty;
            this.btnCancel.Rounding = new System.Windows.Forms.Padding(8);
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.TextOffset = new System.Drawing.Point(0, 0);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormTaskStatistics
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 880);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTaskStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Statistics Dashboard";
            this.Load += new System.EventHandler(this.FormTaskStatistics_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelTaskDistribution.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTaskPriority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTaskStatus)).EndInit();
            this.panelProjectStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectStats)).EndInit();
            this.panelAlerts.ResumeLayout(false);
            this.panelTeamStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamStats)).EndInit();
            this.panelProjectProgress.ResumeLayout(false);
            this.panelTaskProgress.ResumeLayout(false);
            this.panelStats.ResumeLayout(false);
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTaskStatus;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTaskPriority;
        private System.Windows.Forms.DataGridView dgvProjectStats;
        private System.Windows.Forms.DataGridView dgvTeamStats;
    }
}
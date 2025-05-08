namespace FatiIkhlassYoun
{
    partial class FormDashbordProgress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashbordProgress));
            panelSup = new Panel();
            cuiButtonCancel = new CuoreUI.Controls.cuiButton();
            button1 = new Button();
            label1 = new Label();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cmbTeams = new CuoreUI.Controls.cuiComboBox();
            cmbProjects = new CuoreUI.Controls.cuiComboBox();
            dtpStart = new CuoreUI.Controls.cuiCalendarDatePicker();
            dtpEnd = new CuoreUI.Controls.cuiCalendarDatePicker();
            btnRefresh = new CuoreUI.Controls.cuiButton();
            progressTaskCompletion = new CuoreUI.Controls.cuiProgressBarHorizontal();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            Statuts = new Label();
            cuiChartPie = new CuoreUI.Controls.Charts.cuiChartPie();
            panel3 = new Panel();
            label5 = new Label();
            label4 = new Label();
            cuiProgressProjet2 = new CuoreUI.Controls.cuiProgressBarHorizontal();
            progressProjectAdvancement = new CuoreUI.Controls.cuiProgressBarHorizontal();
            label3 = new Label();
            panel4 = new Panel();
            label6 = new Label();
            dgvTeamDetails = new DataGridView();
            panel5 = new Panel();
            listBoxAlerts = new CuoreUI.Controls.cuiListbox();
            label7 = new Label();
            panelSup.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeamDetails).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panelSup
            // 
            panelSup.BackColor = SystemColors.HotTrack;
            panelSup.Controls.Add(cuiButtonCancel);
            panelSup.Controls.Add(button1);
            panelSup.Controls.Add(label1);
            panelSup.Dock = DockStyle.Top;
            panelSup.Location = new Point(0, 0);
            panelSup.Name = "panelSup";
            panelSup.Size = new Size(2267, 92);
            panelSup.TabIndex = 1;
            // 
            // cuiButtonCancel
            // 
            cuiButtonCancel.CheckButton = false;
            cuiButtonCancel.Checked = false;
            cuiButtonCancel.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButtonCancel.CheckedForeColor = Color.White;
            cuiButtonCancel.CheckedImageTint = Color.White;
            cuiButtonCancel.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButtonCancel.Content = "";
            cuiButtonCancel.DialogResult = DialogResult.None;
            cuiButtonCancel.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButtonCancel.ForeColor = Color.White;
            cuiButtonCancel.HoverBackground = SystemColors.HotTrack;
            cuiButtonCancel.HoveredImageTint = Color.White;
            cuiButtonCancel.HoverForeColor = Color.White;
            cuiButtonCancel.HoverOutline = Color.Empty;
            cuiButtonCancel.Image = Properties.Resources.icons8_cancel_50;
            cuiButtonCancel.ImageAutoCenter = true;
            cuiButtonCancel.ImageExpand = new Point(0, 0);
            cuiButtonCancel.ImageOffset = new Point(0, 0);
            cuiButtonCancel.NormalImageTint = Color.White;
            cuiButtonCancel.Location = new Point(2215, 3);
            cuiButtonCancel.Name = "cuiButtonCancel";
            cuiButtonCancel.NormalBackground = SystemColors.HotTrack;
            cuiButtonCancel.NormalOutline = Color.Empty;
            cuiButtonCancel.OutlineThickness = 1.6F;
            cuiButtonCancel.PressedBackground = Color.FromArgb(224, 224, 224);
            cuiButtonCancel.PressedForeColor = Color.White;
            cuiButtonCancel.PressedImageTint = Color.White;
            cuiButtonCancel.PressedOutline = Color.Empty;
            cuiButtonCancel.Rounding = new Padding(8);
            cuiButtonCancel.Size = new Size(52, 63);
            cuiButtonCancel.TabIndex = 2;
            cuiButtonCancel.TextOffset = new Point(0, 0);
            cuiButtonCancel.Click += cuiButtonCancel_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(489, 25);
            button1.Name = "button1";
            button1.Size = new Size(56, 56);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            label1.Location = new Point(71, 19);
            label1.Name = "label1";
            label1.Size = new Size(412, 65);
            label1.TabIndex = 0;
            label1.Text = "Admin Dashbord";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = SystemColors.Control;
            cuiLabel1.Content = "Suivi\\ des\\ Tâches\\ &\\ Projets\\ \\(Team\\ Overview\\)";
            cuiLabel1.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel1.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            cuiLabel1.Location = new Point(617, 106);
            cuiLabel1.Margin = new Padding(10, 11, 10, 11);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(1012, 90);
            cuiLabel1.TabIndex = 2;
            // 
            // cmbTeams
            // 
            cmbTeams.BackgroundColor = Color.Gainsboro;
            cmbTeams.ButtonHoverBackground = Color.FromArgb(224, 224, 224);
            cmbTeams.ButtonHoverOutline = Color.FromArgb(224, 224, 224);
            cmbTeams.ButtonNormalBackground = Color.LightGray;
            cmbTeams.ButtonNormalOutline = Color.LightGray;
            cmbTeams.ButtonPressedBackground = Color.LightGray;
            cmbTeams.ButtonPressedOutline = Color.LightGray;
            cmbTeams.DropDownBackgroundColor = Color.LightGray;
            cmbTeams.DropDownOutlineColor = Color.FromArgb(30, 255, 255, 255);
            cmbTeams.ExpandArrowColor = Color.White;
            cmbTeams.ForeColor = SystemColors.Control;
            cmbTeams.Location = new Point(46, 218);
            cmbTeams.Margin = new Padding(10, 11, 10, 11);
            cmbTeams.Name = "cmbTeams";
            cmbTeams.OutlineColor = Color.FromArgb(35, 255, 255, 255);
            cmbTeams.OutlineThickness = 1F;
            cmbTeams.Rounding = 8;
            cmbTeams.Size = new Size(367, 99);
            cmbTeams.TabIndex = 4;
            cmbTeams.Load += cmbTeams_Load;
            // 
            // cmbProjects
            // 
            cmbProjects.BackgroundColor = Color.Gainsboro;
            cmbProjects.ButtonHoverBackground = Color.FromArgb(224, 224, 224);
            cmbProjects.ButtonHoverOutline = Color.FromArgb(224, 224, 224);
            cmbProjects.ButtonNormalBackground = Color.LightGray;
            cmbProjects.ButtonNormalOutline = Color.LightGray;
            cmbProjects.ButtonPressedBackground = Color.LightGray;
            cmbProjects.ButtonPressedOutline = Color.LightGray;
            cmbProjects.DropDownBackgroundColor = Color.LightGray;
            cmbProjects.DropDownOutlineColor = Color.FromArgb(30, 255, 255, 255);
            cmbProjects.ExpandArrowColor = Color.White;
            cmbProjects.ForeColor = SystemColors.Control;
            cmbProjects.Location = new Point(489, 218);
            cmbProjects.Margin = new Padding(10, 11, 10, 11);
            cmbProjects.Name = "cmbProjects";
            cmbProjects.OutlineColor = Color.FromArgb(35, 255, 255, 255);
            cmbProjects.OutlineThickness = 1F;
            cmbProjects.Rounding = 8;
            cmbProjects.Size = new Size(349, 99);
            cmbProjects.TabIndex = 5;
            cmbProjects.Load += cmbProjects_Load;
            // 
            // dtpStart
            // 
            dtpStart.EnableThemeChangeButton = true;
            dtpStart.Font = new Font("Segoe UI", 9.75F);
            dtpStart.ForeColor = Color.Gray;
            dtpStart.HoverBackground = Color.FromArgb(50, 128, 128, 128);
            dtpStart.HoverOutline = Color.FromArgb(180, 128, 128, 128);
            dtpStart.Icon = (Image)resources.GetObject("dtpStart.Icon");
            dtpStart.IconTint = Color.Gray;
            dtpStart.Location = new Point(939, 218);
            dtpStart.Margin = new Padding(10, 11, 10, 11);
            dtpStart.Name = "dtpStart";
            dtpStart.NormalBackground = Color.FromArgb(32, 128, 128, 128);
            dtpStart.NormalOutline = Color.FromArgb(150, 128, 128, 128);
            dtpStart.OutlineThickness = 1.5F;
            dtpStart.PressedBackground = Color.FromArgb(80, 128, 128, 128);
            dtpStart.PressedOutline = Color.FromArgb(210, 128, 128, 128);
            dtpStart.Rounding = 8;
            dtpStart.ShowIcon = true;
            dtpStart.Size = new Size(368, 99);
            dtpStart.TabIndex = 6;
            dtpStart.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Dark;
            dtpStart.Value = new DateTime(2025, 5, 3, 0, 0, 0, 0);
            dtpStart.Load += dtpStart_Load;
            // 
            // dtpEnd
            // 
            dtpEnd.EnableThemeChangeButton = true;
            dtpEnd.Font = new Font("Segoe UI", 9.75F);
            dtpEnd.ForeColor = Color.Gray;
            dtpEnd.HoverBackground = Color.FromArgb(50, 128, 128, 128);
            dtpEnd.HoverOutline = Color.FromArgb(180, 128, 128, 128);
            dtpEnd.Icon = (Image)resources.GetObject("dtpEnd.Icon");
            dtpEnd.IconTint = Color.Gray;
            dtpEnd.Location = new Point(1385, 218);
            dtpEnd.Margin = new Padding(10, 11, 10, 11);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.NormalBackground = Color.FromArgb(32, 128, 128, 128);
            dtpEnd.NormalOutline = Color.FromArgb(150, 128, 128, 128);
            dtpEnd.OutlineThickness = 1.5F;
            dtpEnd.PressedBackground = Color.FromArgb(80, 128, 128, 128);
            dtpEnd.PressedOutline = Color.FromArgb(210, 128, 128, 128);
            dtpEnd.Rounding = 8;
            dtpEnd.ShowIcon = true;
            dtpEnd.Size = new Size(350, 99);
            dtpEnd.TabIndex = 7;
            dtpEnd.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Dark;
            dtpEnd.Value = new DateTime(2025, 5, 3, 0, 0, 0, 0);
            dtpEnd.Load += dtpEnd_Load;
            // 
            // btnRefresh
            // 
            btnRefresh.CheckButton = false;
            btnRefresh.Checked = false;
            btnRefresh.CheckedBackground = Color.FromArgb(224, 224, 224);
            btnRefresh.CheckedForeColor = Color.White;
            btnRefresh.CheckedImageTint = Color.White;
            btnRefresh.CheckedOutline = Color.FromArgb(224, 224, 224);
            btnRefresh.Content = "Refresh";
            btnRefresh.DialogResult = DialogResult.None;
            btnRefresh.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.HoverBackground = Color.Azure;
            btnRefresh.HoveredImageTint = Color.White;
            btnRefresh.HoverForeColor = Color.White;
            btnRefresh.HoverOutline = Color.Empty;
            btnRefresh.Image = Properties.Resources.icons8_refresh_321;
            btnRefresh.ImageAutoCenter = true;
            btnRefresh.ImageExpand = new Point(0, 0);
            btnRefresh.ImageOffset = new Point(0, 0);
            btnRefresh.NormalImageTint = Color.White;
            btnRefresh.Location = new Point(1880, 211);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.NormalBackground = Color.LightSteelBlue;
            btnRefresh.NormalOutline = Color.Empty;
            btnRefresh.OutlineThickness = 1.6F;
            btnRefresh.PressedBackground = Color.LightSteelBlue;
            btnRefresh.PressedForeColor = Color.White;
            btnRefresh.PressedImageTint = Color.White;
            btnRefresh.PressedOutline = Color.Empty;
            btnRefresh.Rounding = new Padding(8);
            btnRefresh.Size = new Size(306, 99);
            btnRefresh.TabIndex = 8;
            btnRefresh.TextOffset = new Point(0, 0);
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // progressTaskCompletion
            // 
            progressTaskCompletion.Background = SystemColors.Control;
            progressTaskCompletion.Flipped = false;
            progressTaskCompletion.Foreground = Color.FromArgb(0, 192, 0);
            progressTaskCompletion.Location = new Point(27, 226);
            progressTaskCompletion.MaxValue = 100;
            progressTaskCompletion.Name = "progressTaskCompletion";
            progressTaskCompletion.Rounding = 8;
            progressTaskCompletion.Size = new Size(740, 61);
            progressTaskCompletion.TabIndex = 9;
            progressTaskCompletion.Value = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 33);
            label2.Name = "label2";
            label2.Size = new Size(347, 51);
            label2.TabIndex = 10;
            label2.Text = "Tâches terminées";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(progressTaskCompletion);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(44, 366);
            panel1.Name = "panel1";
            panel1.Size = new Size(788, 340);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(cuiChartPie);
            panel2.Controls.Add(Statuts);
            panel2.Location = new Point(44, 768);
            panel2.Name = "panel2";
            panel2.Size = new Size(788, 456);
            panel2.TabIndex = 12;
            // 
            // Statuts
            // 
            Statuts.AutoSize = true;
            Statuts.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Statuts.Location = new Point(27, 22);
            Statuts.Name = "Statuts";
            Statuts.Size = new Size(252, 51);
            Statuts.TabIndex = 1;
            Statuts.Text = "Task Statuts";
            // 
            // cuiChartPie
            // 
            cuiChartPie.ChartBorderColor = Color.LightSteelBlue;
            cuiChartPie.ChartBorderThickness = 1.6F;
            cuiChartPie.ChartPadding = 30;
            cuiChartPie.DataPoints = new string[]
    {
    "data1_100",
    "data2_90",
    "data3_50",
    "data4_50",
    "data5_300"
    };
            cuiChartPie.Font = new Font("Microsoft YaHei UI", 8.25F);
            cuiChartPie.ForeColor = Color.White;
            cuiChartPie.Location = new Point(179, 84);
            cuiChartPie.Margin = new Padding(10, 11, 10, 11);
            cuiChartPie.MinimumSize = new Size(120, 120);
            cuiChartPie.Name = "cuiChartPie";
            cuiChartPie.SegmentBorderColor = Color.SteelBlue;
            cuiChartPie.SegmentColor = Color.RoyalBlue;
            cuiChartPie.ShowPopup = true;
            cuiChartPie.Size = new Size(495, 339);
            cuiChartPie.SliceBorderColor = Color.FromArgb(64, 255, 255, 255);
            cuiChartPie.SliceBorderThickness = 1F;
            cuiChartPie.TabIndex = 0;
            cuiChartPie.Load += cuiChartPie_Load;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(cuiProgressProjet2);
            panel3.Controls.Add(progressProjectAdvancement);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(928, 366);
            panel3.Name = "panel3";
            panel3.Size = new Size(1298, 447);
            panel3.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Location = new Point(95, 312);
            label5.Name = "label5";
            label5.Size = new Size(161, 48);
            label5.TabIndex = 13;
            label5.Text = "Projet 2 :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Location = new Point(95, 179);
            label4.Name = "label4";
            label4.Size = new Size(161, 48);
            label4.TabIndex = 12;
            label4.Text = "Projet 1 :";
            // 
            // cuiProgressProjet2
            // 
            cuiProgressProjet2.Background = SystemColors.Control;
            cuiProgressProjet2.Flipped = false;
            cuiProgressProjet2.Foreground = Color.Blue;
            cuiProgressProjet2.Location = new Point(334, 312);
            cuiProgressProjet2.MaxValue = 100;
            cuiProgressProjet2.Name = "cuiProgressProjet2";
            cuiProgressProjet2.Rounding = 8;
            cuiProgressProjet2.Size = new Size(740, 48);
            cuiProgressProjet2.TabIndex = 11;
            cuiProgressProjet2.Value = 50;
            cuiProgressProjet2.Load += cuiProgressProjet2_Load;
            // 
            // progressProjectAdvancement
            // 
            progressProjectAdvancement.Background = SystemColors.Control;
            progressProjectAdvancement.Flipped = false;
            progressProjectAdvancement.Foreground = Color.RoyalBlue;
            progressProjectAdvancement.Location = new Point(334, 179);
            progressProjectAdvancement.MaxValue = 100;
            progressProjectAdvancement.Name = "progressProjectAdvancement";
            progressProjectAdvancement.Rounding = 8;
            progressProjectAdvancement.Size = new Size(740, 48);
            progressProjectAdvancement.TabIndex = 9;
            progressProjectAdvancement.Value = 50;
            progressProjectAdvancement.Load += progressProjectAdvancement_Load;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 24);
            label3.Name = "label3";
            label3.Size = new Size(408, 51);
            label3.TabIndex = 10;
            label3.Text = "Avancement Projets.";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLight;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(dgvTeamDetails);
            panel4.Location = new Point(928, 883);
            panel4.Name = "panel4";
            panel4.Size = new Size(1298, 951);
            panel4.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 28);
            label6.Name = "label6";
            label6.Size = new Size(362, 51);
            label6.TabIndex = 1;
            label6.Text = "Détails par équipe";
            // 
            // dgvTeamDetails
            // 
            dgvTeamDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeamDetails.EnableHeadersVisualStyles = false;
            dgvTeamDetails.Location = new Point(27, 116);
            dgvTeamDetails.Name = "dgvTeamDetails";
            dgvTeamDetails.RowHeadersWidth = 123;
            dgvTeamDetails.Size = new Size(1251, 732);
            dgvTeamDetails.TabIndex = 2;
            dgvTeamDetails.CellContentClick += dgvTeamDetails_CellContentClick;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLight;
            panel5.Controls.Add(listBoxAlerts);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(50, 1282);
            panel5.Name = "panel5";
            panel5.Size = new Size(788, 552);
            panel5.TabIndex = 15;
            // 
            // listBoxAlerts
            // 
            listBoxAlerts.BackgroundColor = Color.LightGray;
            listBoxAlerts.BorderStyle = BorderStyle.None;
            listBoxAlerts.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxAlerts.Font = new Font("Microsoft YaHei UI", 9F);
            listBoxAlerts.ForeColor = Color.LightGray;
            listBoxAlerts.ForegroundColor = Color.LightGray;
            listBoxAlerts.FormattingEnabled = true;
            listBoxAlerts.ItemHeight = 34;
            listBoxAlerts.ItemHoveredBackgroundColor = Color.LightGray;
            listBoxAlerts.ItemHoveredForegroundColor = Color.LightGray;
            listBoxAlerts.ItemRounding = 8;
            listBoxAlerts.ItemSelectedBackgroundColor = Color.LightGray;
            listBoxAlerts.Location = new Point(62, 107);
            listBoxAlerts.Name = "listBoxAlerts";
            listBoxAlerts.Rounding = 8;
            listBoxAlerts.SelectedForegroundColor = Color.LightGray;
            listBoxAlerts.Size = new Size(673, 408);
            listBoxAlerts.TabIndex = 2;
            listBoxAlerts.SelectedIndexChanged += listBoxAlerts_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Image = Properties.Resources.icons8_notification_50;
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(30, 21);
            label7.Name = "label7";
            label7.Size = new Size(262, 60);
            label7.TabIndex = 1;
            label7.Text = "Alertes";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormDashbordProgress
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2267, 1881);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnRefresh);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(cmbProjects);
            Controls.Add(cmbTeams);
            Controls.Add(cuiLabel1);
            Controls.Add(panelSup);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDashbordProgress";
            Text = "FormDashbordProgress";
            Load += FormDashbordProgress_Load;
            panelSup.ResumeLayout(false);
            panelSup.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeamDetails).EndInit();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSup;
        private Button button1;
        private Label label1;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiComboBox cmbTeams;
        private CuoreUI.Controls.cuiComboBox cmbProjects;
        private CuoreUI.Controls.cuiCalendarDatePicker dtpStart;
        private CuoreUI.Controls.cuiCalendarDatePicker dtpEnd;
        private CuoreUI.Controls.cuiButton btnRefresh;
        private CuoreUI.Controls.cuiProgressBarHorizontal progressTaskCompletion;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Label Statuts;
        private CuoreUI.Controls.Charts.cuiChartPie cuiChartPie;
        private Panel panel3;
        private Label label5;
        private Label label4;
        private CuoreUI.Controls.cuiProgressBarHorizontal cuiProgressProjet2;
        private CuoreUI.Controls.cuiProgressBarHorizontal progressProjectAdvancement;
        private Label label3;
        private Panel panel4;
        private Label label6;
        private DataGridView dgvTeamDetails;
        private Panel panel5;
        private Label label7;
        private CuoreUI.Controls.cuiListbox listBoxAlerts;
        private CuoreUI.Controls.cuiButton cuiButtonCancel;
    }
}
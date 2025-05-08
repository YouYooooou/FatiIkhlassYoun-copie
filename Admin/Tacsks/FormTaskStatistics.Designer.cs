using FatiIkhlassYoun.Admin.AutresChose.CUI;

namespace FatiIkhlassYoun
{
    partial class FormTaskStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaskStatistics));
            panelSup = new Panel();
            cuiButtonCancel = new CuoreUI.Controls.cuiButton();
            button1 = new Button();
            label1 = new Label();
            cmbTeams = new ComboBox();
            cmbProjects = new ComboBox();
            btnRefresh = new Button();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            label2 = new Label();
            cuiChartPie1 = new CuoreUI.Controls.Charts.cuiChartPie();
            panelSup.SuspendLayout();
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
            panelSup.Size = new Size(2688, 92);
            panelSup.TabIndex = 2;
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
            cuiButtonCancel.ImageAutoCenter = true;
            cuiButtonCancel.ImageExpand = new Point(0, 0);
            cuiButtonCancel.ImageOffset = new Point(0, 0);
            cuiButtonCancel.NormalImageTint = Color.White;
            cuiButtonCancel.Location = new Point(2548, 0);
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
            // cmbTeams
            // 
            cmbTeams.FormattingEnabled = true;
            cmbTeams.Location = new Point(432, 276);
            cmbTeams.Name = "cmbTeams";
            cmbTeams.Size = new Size(363, 56);
            cmbTeams.TabIndex = 3;
            cmbTeams.SelectedIndexChanged += cmbTeams_SelectedIndexChanged;
            // 
            // cmbProjects
            // 
            cmbProjects.FormattingEnabled = true;
            cmbProjects.Location = new Point(23, 276);
            cmbProjects.Name = "cmbProjects";
            cmbProjects.Size = new Size(363, 56);
            cmbProjects.TabIndex = 4;
            cmbProjects.SelectedIndexChanged += cmbProjects_SelectedIndexChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(2058, 276);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(225, 55);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = SystemColors.Control;
            cuiLabel1.Content = "Suivi\\ des\\ Tâches\\ &\\ Projets\\ \\(Team\\ Overview\\)";
            cuiLabel1.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel1.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            cuiLabel1.Location = new Point(664, 97);
            cuiLabel1.Margin = new Padding(10, 11, 10, 11);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(1012, 90);
            cuiLabel1.TabIndex = 6;
            cuiLabel1.Load += cuiLabel1_Load_1;
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(864, 276);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(540, 55);
            dtpStart.TabIndex = 7;
            dtpStart.ValueChanged += dtpStart_ValueChanged;
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(1424, 276);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(549, 55);
            dtpEnd.TabIndex = 8;
            dtpEnd.ValueChanged += dtpEnd_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(71, 412);
            label2.Name = "label2";
            label2.Size = new Size(347, 51);
            label2.TabIndex = 11;
            label2.Text = "Tâches terminées";
            // 
            // cuiChartPie1
            // 
            cuiChartPie1.ChartBorderColor = Color.FromArgb(255, 106, 0);
            cuiChartPie1.ChartBorderThickness = 1.6F;
            cuiChartPie1.ChartPadding = 30;
            cuiChartPie1.DataPoints = new string[]
    {
    "data1_100",
    "data2_90",
    "data3_50",
    "data4_50",
    "data5_300"
    };
            cuiChartPie1.Font = new Font("Microsoft YaHei UI", 8.25F);
            cuiChartPie1.ForeColor = Color.White;
            cuiChartPie1.Location = new Point(115, 520);
            cuiChartPie1.Margin = new Padding(10, 11, 10, 11);
            cuiChartPie1.MinimumSize = new Size(120, 120);
            cuiChartPie1.Name = "cuiChartPie1";
            cuiChartPie1.SegmentBorderColor = Color.FromArgb(255, 106, 0);
            cuiChartPie1.SegmentColor = Color.FromArgb(64, 255, 106, 0);
            cuiChartPie1.ShowPopup = true;
            cuiChartPie1.Size = new Size(552, 401);
            cuiChartPie1.SliceBorderColor = Color.FromArgb(64, 255, 255, 255);
            cuiChartPie1.SliceBorderThickness = 1F;
            cuiChartPie1.TabIndex = 12;
            ;
            // 
            // FormTaskStatistics
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2688, 1251);
            Controls.Add(cuiChartPie1);
            Controls.Add(label2);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(cuiLabel1);
            Controls.Add(btnRefresh);
            Controls.Add(cmbProjects);
            Controls.Add(cmbTeams);
            Controls.Add(panelSup);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTaskStatistics";
            Text = "FormTaskStatistics";
            Load += FormTaskStatistics_Load;
            panelSup.ResumeLayout(false);
            panelSup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSup;
        private CuoreUI.Controls.cuiButton cuiButtonCancel;
        private Button button1;
        private Label label1;
        private ComboBox cmbTeams;
        private ComboBox cmbProjects;
        private Button btnRefresh;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private CUIChartPie cuiChartPieStatuts;
        private Label label2;
        private CuoreUI.Controls.Charts.cuiChartPie cuiChartPie1;
    }
}
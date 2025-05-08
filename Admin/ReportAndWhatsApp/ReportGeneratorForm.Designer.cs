namespace FatiIkhlassYoun
{
    partial class ReportGeneratorForm
    {
        private System.ComponentModel.IContainer components = null;

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
            panelHeader = new Panel();
            lblTitle = new Label();
            panelMain = new Panel();
            gbPerformance = new GroupBox();
            numTopTeams = new NumericUpDown();
            chkIncludeTopTeam = new CheckBox();
            gbReportType = new GroupBox();
            rbDetailed = new RadioButton();
            rbSummary = new RadioButton();
            gbDateRange = new GroupBox();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            gbStatus = new GroupBox();
            chkSelectAllStatus = new CheckBox();
            clbStatus = new CheckedListBox();
            gbTeams = new GroupBox();
            chkSelectAllTeams = new CheckBox();
            clbTeams = new CheckedListBox();
            gbProjects = new GroupBox();
            chkSelectAllProjects = new CheckBox();
            clbProjects = new CheckedListBox();
            panelButtons = new Panel();
            btnCancel = new CuoreUI.Controls.cuiButton();
            btnGenerate = new CuoreUI.Controls.cuiButton();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            gbPerformance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTopTeams).BeginInit();
            gbReportType.SuspendLayout();
            gbDateRange.SuspendLayout();
            gbStatus.SuspendLayout();
            gbTeams.SuspendLayout();
            gbProjects.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(51, 51, 76);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1200, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(306, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Générer un Rapport";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(gbPerformance);
            panelMain.Controls.Add(gbReportType);
            panelMain.Controls.Add(gbDateRange);
            panelMain.Controls.Add(gbStatus);
            panelMain.Controls.Add(gbTeams);
            panelMain.Controls.Add(gbProjects);
            panelMain.Controls.Add(panelButtons);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 80);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(1200, 920);
            panelMain.TabIndex = 1;
            // 
            // gbPerformance
            // 
            gbPerformance.Controls.Add(numTopTeams);
            gbPerformance.Controls.Add(chkIncludeTopTeam);
            gbPerformance.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbPerformance.ForeColor = Color.FromArgb(64, 64, 64);
            gbPerformance.Location = new Point(800, 600);
            gbPerformance.Name = "gbPerformance";
            gbPerformance.Size = new Size(380, 200);
            gbPerformance.TabIndex = 9;
            gbPerformance.TabStop = false;
            gbPerformance.Text = "6. Performance des Équipes";
            // 
            // numTopTeams
            // 
            numTopTeams.BackColor = Color.WhiteSmoke;
            numTopTeams.BorderStyle = BorderStyle.None;
            numTopTeams.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numTopTeams.Location = new Point(30, 120);
            numTopTeams.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numTopTeams.Name = "numTopTeams";
            numTopTeams.Size = new Size(100, 30);
            numTopTeams.TabIndex = 1;
            numTopTeams.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // chkIncludeTopTeam
            // 
            chkIncludeTopTeam.AutoSize = true;
            chkIncludeTopTeam.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkIncludeTopTeam.Location = new Point(30, 60);
            chkIncludeTopTeam.Name = "chkIncludeTopTeam";
            chkIncludeTopTeam.Size = new Size(300, 29);
            chkIncludeTopTeam.TabIndex = 0;
            chkIncludeTopTeam.Text = "Inclure les équipes performantes";
            chkIncludeTopTeam.UseVisualStyleBackColor = true;
            // 
            // gbReportType
            // 
            gbReportType.Controls.Add(rbDetailed);
            gbReportType.Controls.Add(rbSummary);
            gbReportType.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbReportType.ForeColor = Color.FromArgb(64, 64, 64);
            gbReportType.Location = new Point(800, 380);
            gbReportType.Name = "gbReportType";
            gbReportType.Size = new Size(380, 200);
            gbReportType.TabIndex = 7;
            gbReportType.TabStop = false;
            gbReportType.Text = "5. Type de Rapport";
            // 
            // rbDetailed
            // 
            rbDetailed.AutoSize = true;
            rbDetailed.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbDetailed.Location = new Point(30, 120);
            rbDetailed.Name = "rbDetailed";
            rbDetailed.Size = new Size(180, 29);
            rbDetailed.TabIndex = 1;
            rbDetailed.Text = "Détaillé (PDF)";
            rbDetailed.UseVisualStyleBackColor = true;
            // 
            // rbSummary
            // 
            rbSummary.AutoSize = true;
            rbSummary.Checked = true;
            rbSummary.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbSummary.Location = new Point(30, 60);
            rbSummary.Name = "rbSummary";
            rbSummary.Size = new Size(200, 29);
            rbSummary.TabIndex = 0;
            rbSummary.TabStop = true;
            rbSummary.Text = "Synthèse (Excel)";
            rbSummary.UseVisualStyleBackColor = true;
            // 
            // gbDateRange
            // 
            gbDateRange.Controls.Add(dtpEndDate);
            gbDateRange.Controls.Add(dtpStartDate);
            gbDateRange.Controls.Add(label2);
            gbDateRange.Controls.Add(label1);
            gbDateRange.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbDateRange.ForeColor = Color.FromArgb(64, 64, 64);
            gbDateRange.Location = new Point(20, 600);
            gbDateRange.Name = "gbDateRange";
            gbDateRange.Size = new Size(760, 200);
            gbDateRange.TabIndex = 4;
            gbDateRange.TabStop = false;
            gbDateRange.Text = "4. Période du Rapport";
            // 
            // dtpEndDate
            // 
            dtpEndDate.CalendarMonthBackground = Color.WhiteSmoke;
            dtpEndDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEndDate.Location = new Point(200, 120);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(300, 34);
            dtpEndDate.TabIndex = 3;
            // 
            // dtpStartDate
            // 
            dtpStartDate.CalendarMonthBackground = Color.WhiteSmoke;
            dtpStartDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStartDate.Location = new Point(200, 60);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(300, 34);
            dtpStartDate.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 125);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 1;
            label2.Text = "Date Fin :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 65);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 0;
            label1.Text = "Date Début :";
            // 
            // gbStatus
            // 
            gbStatus.Controls.Add(chkSelectAllStatus);
            gbStatus.Controls.Add(clbStatus);
            gbStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbStatus.ForeColor = Color.FromArgb(64, 64, 64);
            gbStatus.Location = new Point(800, 20);
            gbStatus.Name = "gbStatus";
            gbStatus.Size = new Size(380, 340);
            gbStatus.TabIndex = 3;
            gbStatus.TabStop = false;
            gbStatus.Text = "3. Statut des Tâches";
            // 
            // chkSelectAllStatus
            // 
            chkSelectAllStatus.AutoSize = true;
            chkSelectAllStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkSelectAllStatus.Location = new Point(30, 40);
            chkSelectAllStatus.Name = "chkSelectAllStatus";
            chkSelectAllStatus.Size = new Size(180, 29);
            chkSelectAllStatus.TabIndex = 1;
            chkSelectAllStatus.Text = "Sélectionner tous";
            chkSelectAllStatus.UseVisualStyleBackColor = true;
            chkSelectAllStatus.CheckedChanged += chkSelectAllStatus_CheckedChanged;
            // 
            // clbStatus
            // 
            clbStatus.BackColor = Color.WhiteSmoke;
            clbStatus.BorderStyle = BorderStyle.None;
            clbStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clbStatus.FormattingEnabled = true;
            clbStatus.Items.AddRange(new object[] { "En attente", "En cours", "Terminée" });
            clbStatus.Location = new Point(30, 80);
            clbStatus.Name = "clbStatus";
            clbStatus.Size = new Size(320, 240);
            clbStatus.TabIndex = 0;
            // 
            // gbTeams
            // 
            gbTeams.Controls.Add(chkSelectAllTeams);
            gbTeams.Controls.Add(clbTeams);
            gbTeams.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbTeams.ForeColor = Color.FromArgb(64, 64, 64);
            gbTeams.Location = new Point(410, 20);
            gbTeams.Name = "gbTeams";
            gbTeams.Size = new Size(370, 560);
            gbTeams.TabIndex = 2;
            gbTeams.TabStop = false;
            gbTeams.Text = "2. Sélection des Équipes";
            // 
            // chkSelectAllTeams
            // 
            chkSelectAllTeams.AutoSize = true;
            chkSelectAllTeams.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkSelectAllTeams.Location = new Point(30, 40);
            chkSelectAllTeams.Name = "chkSelectAllTeams";
            chkSelectAllTeams.Size = new Size(180, 29);
            chkSelectAllTeams.TabIndex = 1;
            chkSelectAllTeams.Text = "Sélectionner tous";
            chkSelectAllTeams.UseVisualStyleBackColor = true;
            chkSelectAllTeams.CheckedChanged += chkSelectAllTeams_CheckedChanged;
            // 
            // clbTeams
            // 
            clbTeams.BackColor = Color.WhiteSmoke;
            clbTeams.BorderStyle = BorderStyle.None;
            clbTeams.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clbTeams.FormattingEnabled = true;
            clbTeams.Location = new Point(30, 80);
            clbTeams.Name = "clbTeams";
            clbTeams.Size = new Size(320, 460);
            clbTeams.TabIndex = 0;
            // 
            // gbProjects
            // 
            gbProjects.Controls.Add(chkSelectAllProjects);
            gbProjects.Controls.Add(clbProjects);
            gbProjects.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbProjects.ForeColor = Color.FromArgb(64, 64, 64);
            gbProjects.Location = new Point(20, 20);
            gbProjects.Name = "gbProjects";
            gbProjects.Size = new Size(370, 560);
            gbProjects.TabIndex = 1;
            gbProjects.TabStop = false;
            gbProjects.Text = "1. Sélection des Projets";
            // 
            // chkSelectAllProjects
            // 
            chkSelectAllProjects.AutoSize = true;
            chkSelectAllProjects.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkSelectAllProjects.Location = new Point(30, 40);
            chkSelectAllProjects.Name = "chkSelectAllProjects";
            chkSelectAllProjects.Size = new Size(180, 29);
            chkSelectAllProjects.TabIndex = 1;
            chkSelectAllProjects.Text = "Sélectionner tous";
            chkSelectAllProjects.UseVisualStyleBackColor = true;
            chkSelectAllProjects.CheckedChanged += chkSelectAllProjects_CheckedChanged;
            // 
            // clbProjects
            // 
            clbProjects.BackColor = Color.WhiteSmoke;
            clbProjects.BorderStyle = BorderStyle.None;
            clbProjects.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clbProjects.FormattingEnabled = true;
            clbProjects.Location = new Point(30, 80);
            clbProjects.Name = "clbProjects";
            clbProjects.Size = new Size(320, 460);
            clbProjects.TabIndex = 0;
            clbProjects.ItemCheck += clbProjects_ItemCheck;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnCancel);
            panelButtons.Controls.Add(btnGenerate);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(20, 820);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(1160, 80);
            panelButtons.TabIndex = 10;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.CheckButton = false;
            btnCancel.Checked = false;
            btnCancel.CheckedBackground = Color.FromArgb(200, 35, 51);
            btnCancel.CheckedForeColor = Color.White;
            btnCancel.CheckedImageTint = Color.White;
            btnCancel.CheckedOutline = Color.FromArgb(200, 35, 51);
            btnCancel.Content = "Annuler";
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.DialogResult = DialogResult.None;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.HoverBackground = Color.FromArgb(200, 35, 51);
            btnCancel.HoveredImageTint = Color.White;
            btnCancel.HoverForeColor = Color.White;
            btnCancel.HoverOutline = Color.Empty;
            btnCancel.Image = null;
            btnCancel.ImageAutoCenter = true;
            btnCancel.ImageExpand = new Point(0, 0);
            btnCancel.ImageOffset = new Point(0, 0);
            btnCancel.Location = new Point(860, 10);
            btnCancel.Name = "btnCancel";
            btnCancel.NormalBackground = Color.FromArgb(223, 53, 69);
            btnCancel.NormalForeColor = Color.White;
            btnCancel.NormalImageTint = Color.White;
            btnCancel.NormalOutline = Color.Empty;
            btnCancel.OutlineThickness = 1.6F;
            btnCancel.PressedBackground = Color.FromArgb(210, 35, 51);
            btnCancel.PressedForeColor = Color.White;
            btnCancel.PressedImageTint = Color.White;
            btnCancel.PressedOutline = Color.Empty;
            btnCancel.Rounding = new Padding(8);
            btnCancel.Size = new Size(150, 60);
            btnCancel.TabIndex = 1;
            btnCancel.TextOffset = new Point(0, 0);
            btnCancel.Click += btnCancel_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerate.CheckButton = false;
            btnGenerate.Checked = false;
            btnGenerate.CheckedBackground = Color.FromArgb(40, 167, 69);
            btnGenerate.CheckedForeColor = Color.White;
            btnGenerate.CheckedImageTint = Color.White;
            btnGenerate.CheckedOutline = Color.FromArgb(40, 167, 69);
            btnGenerate.Content = "Générer";
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.DialogResult = DialogResult.None;
            btnGenerate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.HoverBackground = Color.FromArgb(33, 136, 56);
            btnGenerate.HoveredImageTint = Color.White;
            btnGenerate.HoverForeColor = Color.White;
            btnGenerate.HoverOutline = Color.Empty;
            btnGenerate.Image = null;
            btnGenerate.ImageAutoCenter = true;
            btnGenerate.ImageExpand = new Point(0, 0);
            btnGenerate.ImageOffset = new Point(0, 0);
            btnGenerate.Location = new Point(1010, 10);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.NormalBackground = Color.FromArgb(40, 167, 69);
            btnGenerate.NormalForeColor = Color.White;
            btnGenerate.NormalImageTint = Color.White;
            btnGenerate.NormalOutline = Color.Empty;
            btnGenerate.OutlineThickness = 1.6F;
            btnGenerate.PressedBackground = Color.FromArgb(43, 168, 75);
            btnGenerate.PressedForeColor = Color.White;
            btnGenerate.PressedImageTint = Color.White;
            btnGenerate.PressedOutline = Color.Empty;
            btnGenerate.Rounding = new Padding(8);
            btnGenerate.Size = new Size(150, 60);
            btnGenerate.TabIndex = 0;
            btnGenerate.TextOffset = new Point(0, 0);
            btnGenerate.Click += btnGenerate_Click;
            // 
            // ReportGeneratorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 1000);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportGeneratorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Générateur de Rapports";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            gbPerformance.ResumeLayout(false);
            gbPerformance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTopTeams).EndInit();
            gbReportType.ResumeLayout(false);
            gbReportType.PerformLayout();
            gbDateRange.ResumeLayout(false);
            gbDateRange.PerformLayout();
            gbStatus.ResumeLayout(false);
            gbStatus.PerformLayout();
            gbTeams.ResumeLayout(false);
            gbTeams.PerformLayout();
            gbProjects.ResumeLayout(false);
            gbProjects.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelMain;
        private GroupBox gbProjects;
        private CheckBox chkSelectAllProjects;
        private CheckedListBox clbProjects;
        private GroupBox gbTeams;
        private CheckBox chkSelectAllTeams;
        private CheckedListBox clbTeams;
        private GroupBox gbStatus;
        private CheckBox chkSelectAllStatus;
        private CheckedListBox clbStatus;
        private GroupBox gbDateRange;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Label label2;
        private Label label1;
        private GroupBox gbReportType;
        private RadioButton rbDetailed;
        private RadioButton rbSummary;
        private GroupBox gbPerformance;
        private NumericUpDown numTopTeams;
        private CheckBox chkIncludeTopTeam;
        private Panel panelButtons;
        private CuoreUI.Controls.cuiButton btnGenerate;
        private CuoreUI.Controls.cuiButton btnCancel;
    }
}
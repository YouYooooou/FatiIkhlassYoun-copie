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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbProjects = new System.Windows.Forms.GroupBox();
            this.chkSelectAllProjects = new System.Windows.Forms.CheckBox();
            this.clbProjects = new System.Windows.Forms.CheckedListBox();
            this.gbTeams = new System.Windows.Forms.GroupBox();
            this.chkSelectAllTeams = new System.Windows.Forms.CheckBox();
            this.clbTeams = new System.Windows.Forms.CheckedListBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.chkSelectAllStatus = new System.Windows.Forms.CheckBox();
            this.clbStatus = new System.Windows.Forms.CheckedListBox();
            this.gbDateRange = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbReportType = new System.Windows.Forms.GroupBox();
            this.rbDetailed = new System.Windows.Forms.RadioButton();
            this.rbSummary = new System.Windows.Forms.RadioButton();
            this.gbPerformance = new System.Windows.Forms.GroupBox();
            this.numTopTeams = new System.Windows.Forms.NumericUpDown();
            this.chkIncludeTopTeam = new System.Windows.Forms.CheckBox();
            this.gbProjects.SuspendLayout();
            this.gbTeams.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbDateRange.SuspendLayout();
            this.gbReportType.SuspendLayout();
            this.gbPerformance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTopTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(209, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Générer un Rapport";
            // 
            // gbProjects
            // 
            this.gbProjects.Controls.Add(this.chkSelectAllProjects);
            this.gbProjects.Controls.Add(this.clbProjects);
            this.gbProjects.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProjects.Location = new System.Drawing.Point(12, 50);
            this.gbProjects.Name = "gbProjects";
            this.gbProjects.Size = new System.Drawing.Size(300, 300);
            this.gbProjects.TabIndex = 1;
            this.gbProjects.TabStop = false;
            this.gbProjects.Text = "1. Sélection des Projets";
            // 
            // chkSelectAllProjects
            // 
            this.chkSelectAllProjects.AutoSize = true;
            this.chkSelectAllProjects.Location = new System.Drawing.Point(15, 25);
            this.chkSelectAllProjects.Name = "chkSelectAllProjects";
            this.chkSelectAllProjects.Size = new System.Drawing.Size(118, 19);
            this.chkSelectAllProjects.TabIndex = 1;
            this.chkSelectAllProjects.Text = "Sélectionner tous";
            this.chkSelectAllProjects.UseVisualStyleBackColor = true;
            this.chkSelectAllProjects.CheckedChanged += new System.EventHandler(this.chkSelectAllProjects_CheckedChanged);
            // 
            // clbProjects
            // 
            this.clbProjects.FormattingEnabled = true;
            this.clbProjects.Location = new System.Drawing.Point(15, 50);
            this.clbProjects.Name = "clbProjects";
            this.clbProjects.Size = new System.Drawing.Size(270, 229);
            this.clbProjects.TabIndex = 0;
            this.clbProjects.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbProjects_ItemCheck);
            // 
            // gbTeams
            // 
            this.gbTeams.Controls.Add(this.chkSelectAllTeams);
            this.gbTeams.Controls.Add(this.clbTeams);
            this.gbTeams.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTeams.Location = new System.Drawing.Point(318, 50);
            this.gbTeams.Name = "gbTeams";
            this.gbTeams.Size = new System.Drawing.Size(300, 300);
            this.gbTeams.TabIndex = 2;
            this.gbTeams.TabStop = false;
            this.gbTeams.Text = "2. Sélection des Équipes";
            // 
            // chkSelectAllTeams
            // 
            this.chkSelectAllTeams.AutoSize = true;
            this.chkSelectAllTeams.Location = new System.Drawing.Point(15, 25);
            this.chkSelectAllTeams.Name = "chkSelectAllTeams";
            this.chkSelectAllTeams.Size = new System.Drawing.Size(118, 19);
            this.chkSelectAllTeams.TabIndex = 1;
            this.chkSelectAllTeams.Text = "Sélectionner tous";
            this.chkSelectAllTeams.UseVisualStyleBackColor = true;
            this.chkSelectAllTeams.CheckedChanged += new System.EventHandler(this.chkSelectAllTeams_CheckedChanged);
            // 
            // clbTeams
            // 
            this.clbTeams.FormattingEnabled = true;
            this.clbTeams.Location = new System.Drawing.Point(15, 50);
            this.clbTeams.Name = "clbTeams";
            this.clbTeams.Size = new System.Drawing.Size(270, 229);
            this.clbTeams.TabIndex = 0;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.chkSelectAllStatus);
            this.gbStatus.Controls.Add(this.clbStatus);
            this.gbStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.Location = new System.Drawing.Point(624, 50);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(300, 300);
            this.gbStatus.TabIndex = 3;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "3. Statut des Tâches";
            // 
            // chkSelectAllStatus
            // 
            this.chkSelectAllStatus.AutoSize = true;
            this.chkSelectAllStatus.Location = new System.Drawing.Point(15, 25);
            this.chkSelectAllStatus.Name = "chkSelectAllStatus";
            this.chkSelectAllStatus.Size = new System.Drawing.Size(118, 19);
            this.chkSelectAllStatus.TabIndex = 1;
            this.chkSelectAllStatus.Text = "Sélectionner tous";
            this.chkSelectAllStatus.UseVisualStyleBackColor = true;
            this.chkSelectAllStatus.CheckedChanged += new System.EventHandler(this.chkSelectAllStatus_CheckedChanged);
            // 
            // clbStatus
            // 
            this.clbStatus.FormattingEnabled = true;
            this.clbStatus.Items.AddRange(new object[] {
            "En attente",
            "En cours",
            "Terminée"});
            this.clbStatus.Location = new System.Drawing.Point(15, 50);
            this.clbStatus.Name = "clbStatus";
            this.clbStatus.Size = new System.Drawing.Size(270, 229);
            this.clbStatus.TabIndex = 0;
            // 
            // gbDateRange
            // 
            this.gbDateRange.Controls.Add(this.dtpEndDate);
            this.gbDateRange.Controls.Add(this.dtpStartDate);
            this.gbDateRange.Controls.Add(this.label2);
            this.gbDateRange.Controls.Add(this.label1);
            this.gbDateRange.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDateRange.Location = new System.Drawing.Point(12, 356);
            this.gbDateRange.Name = "gbDateRange";
            this.gbDateRange.Size = new System.Drawing.Size(300, 150);
            this.gbDateRange.TabIndex = 4;
            this.gbDateRange.TabStop = false;
            this.gbDateRange.Text = "4. Période du Rapport";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(100, 90);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(180, 23);
            this.dtpEndDate.TabIndex = 3;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(100, 40);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(180, 23);
            this.dtpStartDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Fin :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date Début :";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Location = new System.Drawing.Point(624, 456);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(300, 50);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Générer le Rapport";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(624, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(300, 50);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbReportType
            // 
            this.gbReportType.Controls.Add(this.rbDetailed);
            this.gbReportType.Controls.Add(this.rbSummary);
            this.gbReportType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReportType.Location = new System.Drawing.Point(318, 356);
            this.gbReportType.Name = "gbReportType";
            this.gbReportType.Size = new System.Drawing.Size(300, 150);
            this.gbReportType.TabIndex = 7;
            this.gbReportType.TabStop = false;
            this.gbReportType.Text = "5. Type de Rapport";
            // 
            // rbDetailed
            // 
            this.rbDetailed.AutoSize = true;
            this.rbDetailed.Location = new System.Drawing.Point(15, 70);
            this.rbDetailed.Name = "rbDetailed";
            this.rbDetailed.Size = new System.Drawing.Size(110, 19);
            this.rbDetailed.TabIndex = 1;
            this.rbDetailed.Text = "Détaillé (PDF)";
            this.rbDetailed.UseVisualStyleBackColor = true;
            // 
            // rbSummary
            // 
            this.rbSummary.AutoSize = true;
            this.rbSummary.Checked = true;
            this.rbSummary.Location = new System.Drawing.Point(15, 40);
            this.rbSummary.Name = "rbSummary";
            this.rbSummary.Size = new System.Drawing.Size(120, 19);
            this.rbSummary.TabIndex = 0;
            this.rbSummary.TabStop = true;
            this.rbSummary.Text = "Synthèse (Excel)";
            this.rbSummary.UseVisualStyleBackColor = true;
            // 
            // gbPerformance
            // 
            this.gbPerformance.Controls.Add(this.numTopTeams);
            this.gbPerformance.Controls.Add(this.chkIncludeTopTeam);
            this.gbPerformance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPerformance.Location = new System.Drawing.Point(12, 512);
            this.gbPerformance.Name = "gbPerformance";
            this.gbPerformance.Size = new System.Drawing.Size(300, 150);
            this.gbPerformance.TabIndex = 9;
            this.gbPerformance.TabStop = false;
            this.gbPerformance.Text = "6. Performance des Équipes";
            // 
            // numTopTeams
            // 
            this.numTopTeams.Location = new System.Drawing.Point(15, 70);
            this.numTopTeams.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTopTeams.Name = "numTopTeams";
            this.numTopTeams.Size = new System.Drawing.Size(50, 23);
            this.numTopTeams.TabIndex = 1;
            this.numTopTeams.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // chkIncludeTopTeam
            // 
            this.chkIncludeTopTeam.AutoSize = true;
            this.chkIncludeTopTeam.Location = new System.Drawing.Point(15, 40);
            this.chkIncludeTopTeam.Name = "chkIncludeTopTeam";
            this.chkIncludeTopTeam.Size = new System.Drawing.Size(180, 19);
            this.chkIncludeTopTeam.TabIndex = 0;
            this.chkIncludeTopTeam.Text = "Inclure les équipes performantes";
            this.chkIncludeTopTeam.UseVisualStyleBackColor = true;
            // 
            // ReportGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.gbPerformance);
            this.Controls.Add(this.gbReportType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.gbDateRange);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbTeams);
            this.Controls.Add(this.gbProjects);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportGeneratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Générateur de Rapports";
            this.Load += new System.EventHandler(this.ReportGeneratorForm_Load);
            this.gbProjects.ResumeLayout(false);
            this.gbProjects.PerformLayout();
            this.gbTeams.ResumeLayout(false);
            this.gbTeams.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbDateRange.ResumeLayout(false);
            this.gbDateRange.PerformLayout();
            this.gbReportType.ResumeLayout(false);
            this.gbReportType.PerformLayout();
            this.gbPerformance.ResumeLayout(false);
            this.gbPerformance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTopTeams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbProjects;
        private System.Windows.Forms.CheckedListBox clbProjects;
        private System.Windows.Forms.GroupBox gbTeams;
        private System.Windows.Forms.CheckedListBox clbTeams;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.CheckedListBox clbStatus;
        private System.Windows.Forms.GroupBox gbDateRange;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkSelectAllProjects;
        private System.Windows.Forms.CheckBox chkSelectAllTeams;
        private System.Windows.Forms.CheckBox chkSelectAllStatus;
        private System.Windows.Forms.GroupBox gbReportType;
        private System.Windows.Forms.RadioButton rbDetailed;
        private System.Windows.Forms.RadioButton rbSummary;
        private System.Windows.Forms.GroupBox gbPerformance;
        private System.Windows.Forms.NumericUpDown numTopTeams;
        private System.Windows.Forms.CheckBox chkIncludeTopTeam;
    }
}
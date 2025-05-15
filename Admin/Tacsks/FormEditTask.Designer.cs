namespace FatiIkhlassYoun
{
    partial class FormEditTask
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
            panelForm = new Panel();
            cmbProject = new ComboBox();
            label2 = new Label();
            buttonAnnuler = new CuoreUI.Controls.cuiButton();
            clbAssignedUsers = new CheckedListBox();
            Membreasignedlabel = new Label();
            cmbPriority = new ComboBox();
            cmbTeamLead = new ComboBox();
            numEstimatedTime = new NumericUpDown();
            Prioritylabel = new Label();
            TeamLeaderlabel = new Label();
            EstimatedtimeLabel = new Label();
            desclabel = new Label();
            Startdatelabel = new Label();
            cmbStatus = new ComboBox();
            dtpStartDate = new DateTimePicker();
            dtpDueDate = new DateTimePicker();
            buttonUpdateTask = new CuoreUI.Controls.cuiButton();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            Statuslabel = new Label();
            DueTimelabel = new Label();
            Titlelabel = new Label();
            panel1 = new Panel();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEstimatedTime).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(51, 51, 76);
            panelHeader.Controls.Add(panel1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(6, 6, 6, 6);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(2400, 115);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(60, 25);
            lblTitle.Margin = new Padding(6, 0, 6, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(515, 74);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Modifier une tâche";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(cmbProject);
            panelForm.Controls.Add(label2);
            panelForm.Controls.Add(buttonAnnuler);
            panelForm.Controls.Add(clbAssignedUsers);
            panelForm.Controls.Add(Membreasignedlabel);
            panelForm.Controls.Add(cmbPriority);
            panelForm.Controls.Add(cmbTeamLead);
            panelForm.Controls.Add(numEstimatedTime);
            panelForm.Controls.Add(Prioritylabel);
            panelForm.Controls.Add(TeamLeaderlabel);
            panelForm.Controls.Add(EstimatedtimeLabel);
            panelForm.Controls.Add(desclabel);
            panelForm.Controls.Add(Startdatelabel);
            panelForm.Controls.Add(cmbStatus);
            panelForm.Controls.Add(dtpStartDate);
            panelForm.Controls.Add(dtpDueDate);
            panelForm.Controls.Add(buttonUpdateTask);
            panelForm.Controls.Add(txtTitle);
            panelForm.Controls.Add(txtDescription);
            panelForm.Controls.Add(Statuslabel);
            panelForm.Controls.Add(DueTimelabel);
            panelForm.Controls.Add(Titlelabel);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 115);
            panelForm.Margin = new Padding(6, 6, 6, 6);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(60, 58, 60, 58);
            panelForm.Size = new Size(2400, 1728);
            panelForm.TabIndex = 1;
            // 
            // cmbProject
            // 
            cmbProject.BackColor = Color.WhiteSmoke;
            cmbProject.FlatStyle = FlatStyle.Flat;
            cmbProject.Font = new Font("Segoe UI", 10F);
            cmbProject.FormattingEnabled = true;
            cmbProject.Location = new Point(600, 58);
            cmbProject.Margin = new Padding(6, 6, 6, 6);
            cmbProject.Name = "cmbProject";
            cmbProject.Size = new Size(1196, 62);
            cmbProject.TabIndex = 77;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(60, 58);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(136, 48);
            label2.TabIndex = 76;
            label2.Text = "Projet :";
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAnnuler.CheckButton = false;
            buttonAnnuler.Checked = false;
            buttonAnnuler.CheckedBackground = Color.FromArgb(200, 35, 51);
            buttonAnnuler.CheckedForeColor = Color.White;
            buttonAnnuler.CheckedImageTint = Color.White;
            buttonAnnuler.CheckedOutline = Color.FromArgb(200, 35, 51);
            buttonAnnuler.Content = "Annuler";
            buttonAnnuler.Cursor = Cursors.Hand;
            buttonAnnuler.DialogResult = DialogResult.None;
            buttonAnnuler.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonAnnuler.ForeColor = Color.White;
            buttonAnnuler.HoverBackground = Color.FromArgb(200, 35, 51);
            buttonAnnuler.HoveredImageTint = Color.White;
            buttonAnnuler.HoverForeColor = Color.White;
            buttonAnnuler.HoverOutline = Color.Empty;
            buttonAnnuler.Image = null;
            buttonAnnuler.ImageAutoCenter = true;
            buttonAnnuler.ImageExpand = new Point(0, 0);
            buttonAnnuler.ImageOffset = new Point(0, 0);
            buttonAnnuler.Location = new Point(714, 1497);
            buttonAnnuler.Margin = new Padding(6, 6, 6, 6);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.NormalBackground = Color.FromArgb(223, 53, 69);
            buttonAnnuler.NormalForeColor = Color.White;
            buttonAnnuler.NormalImageTint = Color.White;
            buttonAnnuler.NormalOutline = Color.Empty;
            buttonAnnuler.OutlineThickness = 1.6F;
            buttonAnnuler.PressedBackground = Color.FromArgb(210, 35, 51);
            buttonAnnuler.PressedForeColor = Color.White;
            buttonAnnuler.PressedImageTint = Color.White;
            buttonAnnuler.PressedOutline = Color.Empty;
            buttonAnnuler.Rounding = new Padding(8);
            buttonAnnuler.Size = new Size(500, 129);
            buttonAnnuler.TabIndex = 75;
            buttonAnnuler.TextOffset = new Point(0, 0);
            buttonAnnuler.Click += buttonAnnuler_Click;
            // 
            // clbAssignedUsers
            // 
            clbAssignedUsers.BackColor = Color.WhiteSmoke;
            clbAssignedUsers.BorderStyle = BorderStyle.None;
            clbAssignedUsers.Font = new Font("Segoe UI", 10F);
            clbAssignedUsers.FormattingEnabled = true;
            clbAssignedUsers.Location = new Point(600, 1248);
            clbAssignedUsers.Margin = new Padding(6, 6, 6, 6);
            clbAssignedUsers.Name = "clbAssignedUsers";
            clbAssignedUsers.Size = new Size(1200, 120);
            clbAssignedUsers.TabIndex = 74;
            // 
            // Membreasignedlabel
            // 
            Membreasignedlabel.AutoSize = true;
            Membreasignedlabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Membreasignedlabel.ForeColor = Color.FromArgb(64, 64, 64);
            Membreasignedlabel.Location = new Point(60, 1248);
            Membreasignedlabel.Margin = new Padding(6, 0, 6, 0);
            Membreasignedlabel.Name = "Membreasignedlabel";
            Membreasignedlabel.Size = new Size(341, 48);
            Membreasignedlabel.TabIndex = 73;
            Membreasignedlabel.Text = "Membres assignés :";
            // 
            // cmbPriority
            // 
            cmbPriority.BackColor = Color.WhiteSmoke;
            cmbPriority.FlatStyle = FlatStyle.Flat;
            cmbPriority.Font = new Font("Segoe UI", 10F);
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(600, 995);
            cmbPriority.Margin = new Padding(6, 6, 6, 6);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(596, 62);
            cmbPriority.TabIndex = 72;
            // 
            // cmbTeamLead
            // 
            cmbTeamLead.BackColor = Color.WhiteSmoke;
            cmbTeamLead.FlatStyle = FlatStyle.Flat;
            cmbTeamLead.Font = new Font("Segoe UI", 10F);
            cmbTeamLead.FormattingEnabled = true;
            cmbTeamLead.Location = new Point(600, 842);
            cmbTeamLead.Margin = new Padding(6, 6, 6, 6);
            cmbTeamLead.Name = "cmbTeamLead";
            cmbTeamLead.Size = new Size(596, 62);
            cmbTeamLead.TabIndex = 71;
            // 
            // numEstimatedTime
            // 
            numEstimatedTime.BackColor = Color.WhiteSmoke;
            numEstimatedTime.BorderStyle = BorderStyle.None;
            numEstimatedTime.Font = new Font("Segoe UI", 10F);
            numEstimatedTime.Location = new Point(600, 688);
            numEstimatedTime.Margin = new Padding(6, 6, 6, 6);
            numEstimatedTime.Name = "numEstimatedTime";
            numEstimatedTime.Size = new Size(300, 57);
            numEstimatedTime.TabIndex = 70;
            // 
            // Prioritylabel
            // 
            Prioritylabel.AutoSize = true;
            Prioritylabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Prioritylabel.ForeColor = Color.FromArgb(64, 64, 64);
            Prioritylabel.Location = new Point(60, 995);
            Prioritylabel.Margin = new Padding(6, 0, 6, 0);
            Prioritylabel.Name = "Prioritylabel";
            Prioritylabel.Size = new Size(158, 48);
            Prioritylabel.TabIndex = 69;
            Prioritylabel.Text = "Priorité :";
            // 
            // TeamLeaderlabel
            // 
            TeamLeaderlabel.AutoSize = true;
            TeamLeaderlabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            TeamLeaderlabel.ForeColor = Color.FromArgb(64, 64, 64);
            TeamLeaderlabel.Location = new Point(60, 842);
            TeamLeaderlabel.Margin = new Padding(6, 0, 6, 0);
            TeamLeaderlabel.Name = "TeamLeaderlabel";
            TeamLeaderlabel.Size = new Size(266, 48);
            TeamLeaderlabel.TabIndex = 68;
            TeamLeaderlabel.Text = "Chef d'équipe :";
            // 
            // EstimatedtimeLabel
            // 
            EstimatedtimeLabel.AutoSize = true;
            EstimatedtimeLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            EstimatedtimeLabel.ForeColor = Color.FromArgb(64, 64, 64);
            EstimatedtimeLabel.Location = new Point(60, 688);
            EstimatedtimeLabel.Margin = new Padding(6, 0, 6, 0);
            EstimatedtimeLabel.Name = "EstimatedtimeLabel";
            EstimatedtimeLabel.Size = new Size(263, 48);
            EstimatedtimeLabel.TabIndex = 67;
            EstimatedtimeLabel.Text = "Temps estimé :";
            // 
            // desclabel
            // 
            desclabel.AutoSize = true;
            desclabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            desclabel.ForeColor = Color.FromArgb(64, 64, 64);
            desclabel.Location = new Point(60, 280);
            desclabel.Margin = new Padding(6, 0, 6, 0);
            desclabel.Name = "desclabel";
            desclabel.Size = new Size(226, 48);
            desclabel.TabIndex = 66;
            desclabel.Text = "Description :";
            // 
            // Startdatelabel
            // 
            Startdatelabel.AutoSize = true;
            Startdatelabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Startdatelabel.ForeColor = Color.FromArgb(64, 64, 64);
            Startdatelabel.Location = new Point(60, 563);
            Startdatelabel.Margin = new Padding(6, 0, 6, 0);
            Startdatelabel.Name = "Startdatelabel";
            Startdatelabel.Size = new Size(223, 48);
            Startdatelabel.TabIndex = 65;
            Startdatelabel.Text = "Date début :";
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.WhiteSmoke;
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.Font = new Font("Segoe UI", 10F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(600, 1094);
            cmbStatus.Margin = new Padding(6, 6, 6, 6);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(596, 62);
            cmbStatus.TabIndex = 64;
            // 
            // dtpStartDate
            // 
            dtpStartDate.CalendarMonthBackground = Color.WhiteSmoke;
            dtpStartDate.Font = new Font("Segoe UI", 10F);
            dtpStartDate.Location = new Point(600, 563);
            dtpStartDate.Margin = new Padding(6, 6, 6, 6);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(596, 61);
            dtpStartDate.TabIndex = 63;
            // 
            // dtpDueDate
            // 
            dtpDueDate.CalendarMonthBackground = Color.WhiteSmoke;
            dtpDueDate.Font = new Font("Segoe UI", 10F);
            dtpDueDate.Location = new Point(1665, 563);
            dtpDueDate.Margin = new Padding(6, 6, 6, 6);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(596, 61);
            dtpDueDate.TabIndex = 62;
            dtpDueDate.ValueChanged += dtpDueDate_ValueChanged;
            // 
            // buttonUpdateTask
            // 
            buttonUpdateTask.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonUpdateTask.CheckButton = false;
            buttonUpdateTask.Checked = false;
            buttonUpdateTask.CheckedBackground = Color.FromArgb(40, 167, 69);
            buttonUpdateTask.CheckedForeColor = Color.White;
            buttonUpdateTask.CheckedImageTint = Color.White;
            buttonUpdateTask.CheckedOutline = Color.FromArgb(40, 167, 69);
            buttonUpdateTask.Content = "Mettre à jour";
            buttonUpdateTask.Cursor = Cursors.Hand;
            buttonUpdateTask.DialogResult = DialogResult.None;
            buttonUpdateTask.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonUpdateTask.ForeColor = Color.White;
            buttonUpdateTask.HoverBackground = Color.FromArgb(33, 136, 56);
            buttonUpdateTask.HoveredImageTint = Color.White;
            buttonUpdateTask.HoverForeColor = Color.White;
            buttonUpdateTask.HoverOutline = Color.Empty;
            buttonUpdateTask.Image = null;
            buttonUpdateTask.ImageAutoCenter = true;
            buttonUpdateTask.ImageExpand = new Point(0, 0);
            buttonUpdateTask.ImageOffset = new Point(0, 0);
            buttonUpdateTask.Location = new Point(1316, 1497);
            buttonUpdateTask.Margin = new Padding(6, 6, 6, 6);
            buttonUpdateTask.Name = "buttonUpdateTask";
            buttonUpdateTask.NormalBackground = Color.FromArgb(40, 167, 69);
            buttonUpdateTask.NormalForeColor = Color.White;
            buttonUpdateTask.NormalImageTint = Color.White;
            buttonUpdateTask.NormalOutline = Color.Empty;
            buttonUpdateTask.OutlineThickness = 1.6F;
            buttonUpdateTask.PressedBackground = Color.FromArgb(43, 168, 75);
            buttonUpdateTask.PressedForeColor = Color.White;
            buttonUpdateTask.PressedImageTint = Color.White;
            buttonUpdateTask.PressedOutline = Color.Empty;
            buttonUpdateTask.Rounding = new Padding(8);
            buttonUpdateTask.Size = new Size(500, 129);
            buttonUpdateTask.TabIndex = 61;
            buttonUpdateTask.TextOffset = new Point(0, 0);
            buttonUpdateTask.Click += buttonUpdateTask_Click;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.WhiteSmoke;
            txtTitle.BorderStyle = BorderStyle.None;
            txtTitle.Font = new Font("Segoe UI", 10F);
            txtTitle.Location = new Point(600, 173);
            txtTitle.Margin = new Padding(6, 6, 6, 6);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(1200, 54);
            txtTitle.TabIndex = 60;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.WhiteSmoke;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.Location = new Point(600, 280);
            txtDescription.Margin = new Padding(6, 6, 6, 6);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(1200, 200);
            txtDescription.TabIndex = 59;
            // 
            // Statuslabel
            // 
            Statuslabel.AutoSize = true;
            Statuslabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Statuslabel.ForeColor = Color.FromArgb(64, 64, 64);
            Statuslabel.Location = new Point(60, 1094);
            Statuslabel.Margin = new Padding(6, 0, 6, 0);
            Statuslabel.Name = "Statuslabel";
            Statuslabel.Size = new Size(137, 48);
            Statuslabel.TabIndex = 58;
            Statuslabel.Text = "Statut :";
            // 
            // DueTimelabel
            // 
            DueTimelabel.AutoSize = true;
            DueTimelabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            DueTimelabel.ForeColor = Color.FromArgb(64, 64, 64);
            DueTimelabel.Location = new Point(1329, 563);
            DueTimelabel.Margin = new Padding(6, 0, 6, 0);
            DueTimelabel.Name = "DueTimelabel";
            DueTimelabel.Size = new Size(168, 48);
            DueTimelabel.TabIndex = 57;
            DueTimelabel.Text = "Date fin :";
            // 
            // Titlelabel
            // 
            Titlelabel.AutoSize = true;
            Titlelabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Titlelabel.ForeColor = Color.FromArgb(64, 64, 64);
            Titlelabel.Location = new Point(60, 173);
            Titlelabel.Margin = new Padding(6, 0, 6, 0);
            Titlelabel.Name = "Titlelabel";
            Titlelabel.Size = new Size(113, 48);
            Titlelabel.TabIndex = 56;
            Titlelabel.Text = "Titre :";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(2400, 115);
            panel1.TabIndex = 38;
            // 
            // FormEditTask
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2400, 1843);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 6, 6, 6);
            Name = "FormEditTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modifier une tâche";
            panelHeader.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numEstimatedTime).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelForm;
        private ComboBox cmbProject;
        private Label label2;
        private CuoreUI.Controls.cuiButton buttonAnnuler;
        private CheckedListBox clbAssignedUsers;
        private Label Membreasignedlabel;
        private ComboBox cmbPriority;
        private ComboBox cmbTeamLead;
        private NumericUpDown numEstimatedTime;
        private Label Prioritylabel;
        private Label TeamLeaderlabel;
        private Label EstimatedtimeLabel;
        private Label desclabel;
        private Label Startdatelabel;
        private ComboBox cmbStatus;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpDueDate;
        private CuoreUI.Controls.cuiButton buttonUpdateTask;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private Label Statuslabel;
        private Label DueTimelabel;
        private Label Titlelabel;
        private Panel panel1;
    }
}
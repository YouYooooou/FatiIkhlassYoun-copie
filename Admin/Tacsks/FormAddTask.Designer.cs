namespace FatiIkhlassYoun
{
    partial class FormAddTask
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
            buttonCreateTask = new CuoreUI.Controls.cuiButton();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            Statuslabel = new Label();
            DueTimelabel = new Label();
            Titlelabel = new Label();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEstimatedTime).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(51, 51, 76);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(980, 60);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(358, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Ajouter une nouvelle tâche";
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
            panelForm.Controls.Add(buttonCreateTask);
            panelForm.Controls.Add(txtTitle);
            panelForm.Controls.Add(txtDescription);
            panelForm.Controls.Add(Statuslabel);
            panelForm.Controls.Add(DueTimelabel);
            panelForm.Controls.Add(Titlelabel);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 60);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(30);
            panelForm.Size = new Size(980, 900);
            panelForm.TabIndex = 1;
            // 
            // cmbProject
            // 
            cmbProject.BackColor = Color.WhiteSmoke;
            cmbProject.FlatStyle = FlatStyle.Flat;
            cmbProject.Font = new Font("Segoe UI", 10F);
            cmbProject.FormattingEnabled = true;
            cmbProject.Location = new Point(300, 30);
            cmbProject.Name = "cmbProject";
            cmbProject.Size = new Size(600, 36);
            cmbProject.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(30, 30);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 53;
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
            buttonAnnuler.Location = new Point(380, 800);
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
            buttonAnnuler.Size = new Size(250, 50);
            buttonAnnuler.TabIndex = 52;
            buttonAnnuler.TextOffset = new Point(0, 0);
            buttonAnnuler.Click += buttonAnnuler_Click;
            // 
            // clbAssignedUsers
            // 
            clbAssignedUsers.BackColor = Color.WhiteSmoke;
            clbAssignedUsers.BorderStyle = BorderStyle.None;
            clbAssignedUsers.Font = new Font("Segoe UI", 10F);
            clbAssignedUsers.FormattingEnabled = true;
            clbAssignedUsers.Location = new Point(300, 650);
            clbAssignedUsers.Name = "clbAssignedUsers";
            clbAssignedUsers.Size = new Size(600, 93);
            clbAssignedUsers.TabIndex = 51;
            // 
            // Membreasignedlabel
            // 
            Membreasignedlabel.AutoSize = true;
            Membreasignedlabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Membreasignedlabel.ForeColor = Color.FromArgb(64, 64, 64);
            Membreasignedlabel.Location = new Point(30, 650);
            Membreasignedlabel.Name = "Membreasignedlabel";
            Membreasignedlabel.Size = new Size(175, 25);
            Membreasignedlabel.TabIndex = 50;
            Membreasignedlabel.Text = "Membres assignés :";
            // 
            // cmbPriority
            // 
            cmbPriority.BackColor = Color.WhiteSmoke;
            cmbPriority.FlatStyle = FlatStyle.Flat;
            cmbPriority.Font = new Font("Segoe UI", 10F);
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(150, 570);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(300, 36);
            cmbPriority.TabIndex = 49;
            // 
            // cmbTeamLead
            // 
            cmbTeamLead.BackColor = Color.WhiteSmoke;
            cmbTeamLead.FlatStyle = FlatStyle.Flat;
            cmbTeamLead.Font = new Font("Segoe UI", 10F);
            cmbTeamLead.FormattingEnabled = true;
            cmbTeamLead.Location = new Point(300, 490);
            cmbTeamLead.Name = "cmbTeamLead";
            cmbTeamLead.Size = new Size(300, 36);
            cmbTeamLead.TabIndex = 48;
            // 
            // numEstimatedTime
            // 
            numEstimatedTime.BackColor = Color.WhiteSmoke;
            numEstimatedTime.BorderStyle = BorderStyle.None;
            numEstimatedTime.Font = new Font("Segoe UI", 10F);
            numEstimatedTime.Location = new Point(300, 410);
            numEstimatedTime.Name = "numEstimatedTime";
            numEstimatedTime.Size = new Size(150, 30);
            numEstimatedTime.TabIndex = 47;
            // 
            // Prioritylabel
            // 
            Prioritylabel.AutoSize = true;
            Prioritylabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Prioritylabel.ForeColor = Color.FromArgb(64, 64, 64);
            Prioritylabel.Location = new Point(30, 570);
            Prioritylabel.Name = "Prioritylabel";
            Prioritylabel.Size = new Size(84, 25);
            Prioritylabel.TabIndex = 46;
            Prioritylabel.Text = "Priorité :";
            // 
            // TeamLeaderlabel
            // 
            TeamLeaderlabel.AutoSize = true;
            TeamLeaderlabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            TeamLeaderlabel.ForeColor = Color.FromArgb(64, 64, 64);
            TeamLeaderlabel.Location = new Point(30, 490);
            TeamLeaderlabel.Name = "TeamLeaderlabel";
            TeamLeaderlabel.Size = new Size(137, 25);
            TeamLeaderlabel.TabIndex = 45;
            TeamLeaderlabel.Text = "Chef d'équipe :";
            // 
            // EstimatedtimeLabel
            // 
            EstimatedtimeLabel.AutoSize = true;
            EstimatedtimeLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            EstimatedtimeLabel.ForeColor = Color.FromArgb(64, 64, 64);
            EstimatedtimeLabel.Location = new Point(30, 410);
            EstimatedtimeLabel.Name = "EstimatedtimeLabel";
            EstimatedtimeLabel.Size = new Size(135, 25);
            EstimatedtimeLabel.TabIndex = 43;
            EstimatedtimeLabel.Text = "Temps estimé :";
            // 
            // desclabel
            // 
            desclabel.AutoSize = true;
            desclabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            desclabel.ForeColor = Color.FromArgb(64, 64, 64);
            desclabel.Location = new Point(30, 150);
            desclabel.Name = "desclabel";
            desclabel.Size = new Size(117, 25);
            desclabel.TabIndex = 42;
            desclabel.Text = "Description :";
            // 
            // Startdatelabel
            // 
            Startdatelabel.AutoSize = true;
            Startdatelabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Startdatelabel.ForeColor = Color.FromArgb(64, 64, 64);
            Startdatelabel.Location = new Point(30, 330);
            Startdatelabel.Name = "Startdatelabel";
            Startdatelabel.Size = new Size(115, 25);
            Startdatelabel.TabIndex = 41;
            Startdatelabel.Text = "Date début :";
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.WhiteSmoke;
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.Font = new Font("Segoe UI", 10F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(600, 570);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(300, 36);
            cmbStatus.TabIndex = 40;
            // 
            // dtpStartDate
            // 
            dtpStartDate.CalendarMonthBackground = Color.WhiteSmoke;
            dtpStartDate.Font = new Font("Segoe UI", 10F);
            dtpStartDate.Location = new Point(300, 330);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(300, 34);
            dtpStartDate.TabIndex = 39;
            // 
            // dtpDueDate
            // 
            dtpDueDate.CalendarMonthBackground = Color.WhiteSmoke;
            dtpDueDate.Font = new Font("Segoe UI", 10F);
            dtpDueDate.Location = new Point(600, 330);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(300, 34);
            dtpDueDate.TabIndex = 38;
            // 
            // buttonCreateTask
            // 
            buttonCreateTask.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCreateTask.CheckButton = false;
            buttonCreateTask.Checked = false;
            buttonCreateTask.CheckedBackground = Color.FromArgb(40, 167, 69);
            buttonCreateTask.CheckedForeColor = Color.White;
            buttonCreateTask.CheckedImageTint = Color.White;
            buttonCreateTask.CheckedOutline = Color.FromArgb(40, 167, 69);
            buttonCreateTask.Content = "Créer la tâche";
            buttonCreateTask.Cursor = Cursors.Hand;
            buttonCreateTask.DialogResult = DialogResult.None;
            buttonCreateTask.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonCreateTask.ForeColor = Color.White;
            buttonCreateTask.HoverBackground = Color.FromArgb(33, 136, 56);
            buttonCreateTask.HoveredImageTint = Color.White;
            buttonCreateTask.HoverForeColor = Color.White;
            buttonCreateTask.HoverOutline = Color.Empty;
            buttonCreateTask.Image = null;
            buttonCreateTask.ImageAutoCenter = true;
            buttonCreateTask.ImageExpand = new Point(0, 0);
            buttonCreateTask.ImageOffset = new Point(0, 0);
            buttonCreateTask.Location = new Point(680, 800);
            buttonCreateTask.Name = "buttonCreateTask";
            buttonCreateTask.NormalBackground = Color.FromArgb(40, 167, 69);
            buttonCreateTask.NormalForeColor = Color.White;
            buttonCreateTask.NormalImageTint = Color.White;
            buttonCreateTask.NormalOutline = Color.Empty;
            buttonCreateTask.OutlineThickness = 1.6F;
            buttonCreateTask.PressedBackground = Color.FromArgb(43, 168, 75);
            buttonCreateTask.PressedForeColor = Color.White;
            buttonCreateTask.PressedImageTint = Color.White;
            buttonCreateTask.PressedOutline = Color.Empty;
            buttonCreateTask.Rounding = new Padding(8);
            buttonCreateTask.Size = new Size(250, 50);
            buttonCreateTask.TabIndex = 37;
            buttonCreateTask.TextOffset = new Point(0, 0);
            buttonCreateTask.Click += buttonCreateTask_Click;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.WhiteSmoke;
            txtTitle.BorderStyle = BorderStyle.None;
            txtTitle.Font = new Font("Segoe UI", 10F);
            txtTitle.Location = new Point(300, 90);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(600, 27);
            txtTitle.TabIndex = 36;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.WhiteSmoke;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.Location = new Point(300, 150);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(600, 154);
            txtDescription.TabIndex = 35;
            // 
            // Statuslabel
            // 
            Statuslabel.AutoSize = true;
            Statuslabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Statuslabel.ForeColor = Color.FromArgb(64, 64, 64);
            Statuslabel.Location = new Point(497, 576);
            Statuslabel.Name = "Statuslabel";
            Statuslabel.Size = new Size(71, 25);
            Statuslabel.TabIndex = 34;
            Statuslabel.Text = "Statut :";
            // 
            // DueTimelabel
            // 
            DueTimelabel.AutoSize = true;
            DueTimelabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            DueTimelabel.ForeColor = Color.FromArgb(64, 64, 64);
            DueTimelabel.Location = new Point(600, 330);
            DueTimelabel.Name = "DueTimelabel";
            DueTimelabel.Size = new Size(87, 25);
            DueTimelabel.TabIndex = 33;
            DueTimelabel.Text = "Date fin :";
            // 
            // Titlelabel
            // 
            Titlelabel.AutoSize = true;
            Titlelabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Titlelabel.ForeColor = Color.FromArgb(64, 64, 64);
            Titlelabel.Location = new Point(30, 90);
            Titlelabel.Name = "Titlelabel";
            Titlelabel.Size = new Size(60, 25);
            Titlelabel.TabIndex = 32;
            Titlelabel.Text = "Titre :";
            // 
            // FormAddTask
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(980, 960);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ajouter une tâche";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numEstimatedTime).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelForm;
        private Label EstimatedtimeLabel;
        private Label desclabel;
        private Label Startdatelabel;
        private ComboBox cmbStatus;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpDueDate;
        private CuoreUI.Controls.cuiButton buttonCreateTask;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private Label Statuslabel;
        private Label DueTimelabel;
        private Label Titlelabel;
        private Label TeamLeaderlabel;
        private Label Prioritylabel;
        private NumericUpDown numEstimatedTime;
        private ComboBox cmbTeamLead;
        private ComboBox cmbPriority;
        private Label Membreasignedlabel;
        private CheckedListBox clbAssignedUsers;
        private CuoreUI.Controls.cuiButton buttonAnnuler;
        private ComboBox cmbProject;
        private Label label2;
    }
}
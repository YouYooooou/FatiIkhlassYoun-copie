using System.Data;
using System.Data.SqlClient;

namespace FatiIkhlassYoun
{
    partial class FormAddTask
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
            EstimatedtimeLabel = new Label();
            desclabel = new Label();
            Startdatelabel = new Label();
            cmbStatus = new ComboBox();
            dtpStartDate = new DateTimePicker();
            dtpDueDate = new DateTimePicker();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            Statuslabel = new Label();
            DueTimelabel = new Label();
            Titlelabel = new Label();
            label1 = new Label();
            TeamLeaderlabel = new Label();
            Prioritylabel = new Label();
            numEstimatedTime = new NumericUpDown();
            cmbTeamLead = new ComboBox();
            cmbPriority = new ComboBox();
            Membreasignedlabel = new Label();
            clbAssignedUsers = new CheckedListBox();
            cmbProject = new ComboBox();
            label2 = new Label();
            panelHeader = new Panel();
            btnSave = new CuoreUI.Controls.cuiButton();
            btnCancel = new CuoreUI.Controls.cuiButton();
            ((System.ComponentModel.ISupportInitialize)numEstimatedTime).BeginInit();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // EstimatedtimeLabel
            // 
            EstimatedtimeLabel.AutoSize = true;
            EstimatedtimeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EstimatedtimeLabel.Location = new Point(939, 296);
            EstimatedtimeLabel.Name = "EstimatedtimeLabel";
            EstimatedtimeLabel.Size = new Size(299, 48);
            EstimatedtimeLabel.TabIndex = 43;
            EstimatedtimeLabel.Text = "Estimated Time :";
            // 
            // desclabel
            // 
            desclabel.AutoSize = true;
            desclabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            desclabel.Location = new Point(42, 385);
            desclabel.Name = "desclabel";
            desclabel.Size = new Size(233, 48);
            desclabel.TabIndex = 42;
            desclabel.Text = "Description :";
            // 
            // Startdatelabel
            // 
            Startdatelabel.AutoSize = true;
            Startdatelabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Startdatelabel.Location = new Point(56, 620);
            Startdatelabel.Name = "Startdatelabel";
            Startdatelabel.Size = new Size(210, 48);
            Startdatelabel.TabIndex = 41;
            Startdatelabel.Text = "Start Date :";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(1284, 166);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(528, 56);
            cmbStatus.TabIndex = 40;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(298, 620);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(528, 55);
            dtpStartDate.TabIndex = 39;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(298, 731);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(528, 55);
            dtpDueDate.TabIndex = 38;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(298, 271);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(528, 55);
            txtTitle.TabIndex = 36;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(298, 356);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(528, 157);
            txtDescription.TabIndex = 35;
            // 
            // Statuslabel
            // 
            Statuslabel.AutoSize = true;
            Statuslabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Statuslabel.Location = new Point(939, 166);
            Statuslabel.Name = "Statuslabel";
            Statuslabel.Size = new Size(144, 48);
            Statuslabel.TabIndex = 34;
            Statuslabel.Text = "Status :";
            // 
            // DueTimelabel
            // 
            DueTimelabel.AutoSize = true;
            DueTimelabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DueTimelabel.Location = new Point(42, 738);
            DueTimelabel.Name = "DueTimelabel";
            DueTimelabel.Size = new Size(197, 48);
            DueTimelabel.TabIndex = 33;
            DueTimelabel.Text = "Due Date :";
            // 
            // Titlelabel
            // 
            Titlelabel.AutoSize = true;
            Titlelabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Titlelabel.Location = new Point(65, 278);
            Titlelabel.Name = "Titlelabel";
            Titlelabel.Size = new Size(114, 48);
            Titlelabel.TabIndex = 32;
            Titlelabel.Text = "Title :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(95, 28);
            label1.Name = "label1";
            label1.Size = new Size(510, 63);
            label1.TabIndex = 31;
            label1.Text = "Ajouter Une Tache :";
            // 
            // TeamLeaderlabel
            // 
            TeamLeaderlabel.AutoSize = true;
            TeamLeaderlabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TeamLeaderlabel.Location = new Point(939, 426);
            TeamLeaderlabel.Name = "TeamLeaderlabel";
            TeamLeaderlabel.Size = new Size(250, 48);
            TeamLeaderlabel.TabIndex = 45;
            TeamLeaderlabel.Text = "Team Leader :";
            // 
            // Prioritylabel
            // 
            Prioritylabel.AutoSize = true;
            Prioritylabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Prioritylabel.Location = new Point(939, 556);
            Prioritylabel.Name = "Prioritylabel";
            Prioritylabel.Size = new Size(165, 48);
            Prioritylabel.TabIndex = 46;
            Prioritylabel.Text = "Priority :";
            // 
            // numEstimatedTime
            // 
            numEstimatedTime.Location = new Point(1284, 296);
            numEstimatedTime.Name = "numEstimatedTime";
            numEstimatedTime.Size = new Size(528, 55);
            numEstimatedTime.TabIndex = 47;
            // 
            // cmbTeamLead
            // 
            cmbTeamLead.FormattingEnabled = true;
            cmbTeamLead.Location = new Point(1284, 426);
            cmbTeamLead.Name = "cmbTeamLead";
            cmbTeamLead.Size = new Size(528, 56);
            cmbTeamLead.TabIndex = 48;
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(1284, 535);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(528, 56);
            cmbPriority.TabIndex = 49;
            // 
            // Membreasignedlabel
            // 
            Membreasignedlabel.AutoSize = true;
            Membreasignedlabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Membreasignedlabel.Location = new Point(928, 692);
            Membreasignedlabel.Name = "Membreasignedlabel";
            Membreasignedlabel.Size = new Size(347, 48);
            Membreasignedlabel.TabIndex = 50;
            Membreasignedlabel.Text = "Membres assignés :";
            // 
            // clbAssignedUsers
            // 
            clbAssignedUsers.FormattingEnabled = true;
            clbAssignedUsers.Location = new Point(1284, 646);
            clbAssignedUsers.Name = "clbAssignedUsers";
            clbAssignedUsers.Size = new Size(534, 166);
            clbAssignedUsers.TabIndex = 51;
            clbAssignedUsers.SelectedIndexChanged += clbAssignedUsers_SelectedIndexChanged_1;
            // 
            // cmbProject
            // 
            cmbProject.FormattingEnabled = true;
            cmbProject.Location = new Point(298, 166);
            cmbProject.Name = "cmbProject";
            cmbProject.Size = new Size(528, 56);
            cmbProject.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(42, 166);
            label2.Name = "label2";
            label2.Size = new Size(168, 48);
            label2.TabIndex = 53;
            label2.Text = " Project :";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.HotTrack;
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(6);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1906, 115);
            panelHeader.TabIndex = 55;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.CheckButton = false;
            btnSave.Checked = false;
            btnSave.CheckedBackground = Color.FromArgb(40, 167, 69);
            btnSave.CheckedForeColor = Color.White;
            btnSave.CheckedImageTint = Color.White;
            btnSave.CheckedOutline = Color.FromArgb(40, 167, 69);
            btnSave.Content = "Enregistrer";
            btnSave.Cursor = Cursors.Hand;
            btnSave.DialogResult = DialogResult.None;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.HoverBackground = Color.FromArgb(33, 136, 56);
            btnSave.HoveredImageTint = Color.White;
            btnSave.HoverForeColor = Color.White;
            btnSave.HoverOutline = Color.Empty;
            btnSave.Image = null;
            btnSave.ImageAutoCenter = true;
            btnSave.ImageExpand = new Point(0, 0);
            btnSave.ImageOffset = new Point(0, 0);
            btnSave.Location = new Point(1031, 938);
            btnSave.Margin = new Padding(6);
            btnSave.Name = "btnSave";
            btnSave.NormalBackground = Color.FromArgb(40, 167, 69);
            btnSave.NormalForeColor = Color.White;
            btnSave.NormalImageTint = Color.White;
            btnSave.NormalOutline = Color.Empty;
            btnSave.OutlineThickness = 1.6F;
            btnSave.PressedBackground = Color.FromArgb(43, 168, 75);
            btnSave.PressedForeColor = Color.White;
            btnSave.PressedImageTint = Color.White;
            btnSave.PressedOutline = Color.Empty;
            btnSave.Rounding = new Padding(8);
            btnSave.Size = new Size(329, 122);
            btnSave.TabIndex = 56;
            btnSave.TextOffset = new Point(0, 0);
            btnSave.Click += btnSave_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            btnCancel.Location = new Point(588, 938);
            btnCancel.Margin = new Padding(6);
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
            btnCancel.Size = new Size(319, 122);
            btnCancel.TabIndex = 57;
            btnCancel.TextOffset = new Point(0, 0);
            btnCancel.Click += btnCancel_Click_1;
            // 
            // FormAddTask
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1906, 1086);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(panelHeader);
            Controls.Add(cmbProject);
            Controls.Add(label2);
            Controls.Add(clbAssignedUsers);
            Controls.Add(Membreasignedlabel);
            Controls.Add(cmbPriority);
            Controls.Add(cmbTeamLead);
            Controls.Add(numEstimatedTime);
            Controls.Add(Prioritylabel);
            Controls.Add(TeamLeaderlabel);
            Controls.Add(EstimatedtimeLabel);
            Controls.Add(desclabel);
            Controls.Add(Startdatelabel);
            Controls.Add(cmbStatus);
            Controls.Add(dtpStartDate);
            Controls.Add(dtpDueDate);
            Controls.Add(txtTitle);
            Controls.Add(txtDescription);
            Controls.Add(Statuslabel);
            Controls.Add(DueTimelabel);
            Controls.Add(Titlelabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddTask";
            Text = "FormAddTask";
            Load += FormAddTask_Load;
            ((System.ComponentModel.ISupportInitialize)numEstimatedTime).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        // Update the LoadTasks method to use the corrected type.  
        public void LoadTasks()
        {
            // Ouvre le formulaire d'ajout de tâche
            FormAddTask formAddTask = new FormAddTask();
            formAddTask.Show(); // Ouverture du formulaire sans avoir besoin de rafraîchir les tâches

            // Il n'est pas nécessaire de gérer les DataGridView ou de recharger les tâches ici
        }




        #endregion
        private Label EstimatedtimeLabel;
        private Label desclabel;
        private Label Startdatelabel;
        private ComboBox cmbStatus;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpDueDate;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private Label Statuslabel;
        private Label DueTimelabel;
        private Label Titlelabel;
        private Label label1;
        private Label TeamLeaderlabel;
        private Label Prioritylabel;
        private NumericUpDown numEstimatedTime;
        private ComboBox cmbTeamLead;
        private ComboBox cmbPriority;
        private Label Membreasignedlabel;
        private CheckedListBox clbAssignedUsers;
        private ComboBox cmbProject;
        private Label label2;
        // Fix for CS1061: Ensure that 'dgvTasks' is properly declared as a DataGridView instead of an object.  
        private DataGridView dgvTasks;
        private Panel panelHeader;
        private CuoreUI.Controls.cuiButton btnSave;
        private CuoreUI.Controls.cuiButton btnCancel;
    }
}
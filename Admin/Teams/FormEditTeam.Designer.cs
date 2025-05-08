namespace FatiIkhlassYoun
{
    partial class FormEditTeam
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
            panelHeader = new Panel();
            lblTitle = new Label();
            panelForm = new Panel();
            clbMembers = new CheckedListBox();
            cmbLeader = new ComboBox();
            cmbProject = new ComboBox();
            lblMembers = new Label();
            lblLeader = new Label();
            lblProject = new Label();
            txtTeamName = new TextBox();
            lblTeamName = new Label();
            btnCancel = new CuoreUI.Controls.cuiButton();
            buttonSave = new CuoreUI.Controls.cuiButton();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(51, 51, 76);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1000, 60);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(262, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Modifier l'équipe";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(clbMembers);
            panelForm.Controls.Add(cmbLeader);
            panelForm.Controls.Add(cmbProject);
            panelForm.Controls.Add(lblMembers);
            panelForm.Controls.Add(lblLeader);
            panelForm.Controls.Add(lblProject);
            panelForm.Controls.Add(txtTeamName);
            panelForm.Controls.Add(lblTeamName);
            panelForm.Controls.Add(btnCancel);
            panelForm.Controls.Add(buttonSave);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 60);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(30);
            panelForm.Size = new Size(1000, 700);
            panelForm.TabIndex = 1;
            // 
            // clbMembers
            // 
            clbMembers.BackColor = Color.WhiteSmoke;
            clbMembers.BorderStyle = BorderStyle.None;
            clbMembers.Font = new Font("Segoe UI", 10F);
            clbMembers.FormattingEnabled = true;
            clbMembers.Location = new Point(300, 400);
            clbMembers.Name = "clbMembers";
            clbMembers.Size = new Size(600, 150);
            clbMembers.TabIndex = 8;
            // 
            // cmbLeader
            // 
            cmbLeader.BackColor = Color.WhiteSmoke;
            cmbLeader.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLeader.FlatStyle = FlatStyle.Flat;
            cmbLeader.Font = new Font("Segoe UI", 10F);
            cmbLeader.FormattingEnabled = true;
            cmbLeader.Location = new Point(300, 300);
            cmbLeader.Name = "cmbLeader";
            cmbLeader.Size = new Size(600, 36);
            cmbLeader.TabIndex = 6;
            // 
            // cmbProject
            // 
            cmbProject.BackColor = Color.WhiteSmoke;
            cmbProject.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProject.FlatStyle = FlatStyle.Flat;
            cmbProject.Font = new Font("Segoe UI", 10F);
            cmbProject.FormattingEnabled = true;
            cmbProject.Location = new Point(300, 200);
            cmbProject.Name = "cmbProject";
            cmbProject.Size = new Size(600, 36);
            cmbProject.TabIndex = 4;
            // 
            // lblMembers
            // 
            lblMembers.AutoSize = true;
            lblMembers.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMembers.ForeColor = Color.FromArgb(64, 64, 64);
            lblMembers.Location = new Point(30, 400);
            lblMembers.Name = "lblMembers";
            lblMembers.Size = new Size(182, 25);
            lblMembers.TabIndex = 7;
            lblMembers.Text = "Membres d'équipe :";
            // 
            // lblLeader
            // 
            lblLeader.AutoSize = true;
            lblLeader.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblLeader.ForeColor = Color.FromArgb(64, 64, 64);
            lblLeader.Location = new Point(30, 300);
            lblLeader.Name = "lblLeader";
            lblLeader.Size = new Size(131, 25);
            lblLeader.TabIndex = 5;
            lblLeader.Text = "Chef d'équipe :";
            // 
            // lblProject
            // 
            lblProject.AutoSize = true;
            lblProject.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblProject.ForeColor = Color.FromArgb(64, 64, 64);
            lblProject.Location = new Point(30, 200);
            lblProject.Name = "lblProject";
            lblProject.Size = new Size(176, 25);
            lblProject.TabIndex = 3;
            lblProject.Text = "Projet associé :";
            // 
            // txtTeamName
            // 
            txtTeamName.BackColor = Color.WhiteSmoke;
            txtTeamName.BorderStyle = BorderStyle.None;
            txtTeamName.Font = new Font("Segoe UI", 10F);
            txtTeamName.Location = new Point(300, 100);
            txtTeamName.Name = "txtTeamName";
            txtTeamName.Size = new Size(600, 27);
            txtTeamName.TabIndex = 2;
            // 
            // lblTeamName
            // 
            lblTeamName.AutoSize = true;
            lblTeamName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTeamName.ForeColor = Color.FromArgb(64, 64, 64);
            lblTeamName.Location = new Point(30, 100);
            lblTeamName.Name = "lblTeamName";
            lblTeamName.Size = new Size(59, 25);
            lblTeamName.TabIndex = 1;
            lblTeamName.Text = "Nom :";
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
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.HoverBackground = Color.FromArgb(200, 35, 51);
            btnCancel.HoveredImageTint = Color.White;
            btnCancel.HoverForeColor = Color.White;
            btnCancel.HoverOutline = Color.Empty;
            btnCancel.Image = null;
            btnCancel.ImageAutoCenter = true;
            btnCancel.ImageExpand = new Point(0, 0);
            btnCancel.ImageOffset = new Point(0, 0);
            btnCancel.Location = new Point(350, 600);
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
            btnCancel.Size = new Size(250, 50);
            btnCancel.TabIndex = 49;
            btnCancel.TextOffset = new Point(0, 0);
            btnCancel.Click += btnCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave.CheckButton = false;
            buttonSave.Checked = false;
            buttonSave.CheckedBackground = Color.FromArgb(40, 167, 69);
            buttonSave.CheckedForeColor = Color.White;
            buttonSave.CheckedImageTint = Color.White;
            buttonSave.CheckedOutline = Color.FromArgb(40, 167, 69);
            buttonSave.Content = "Mettre à jour";
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.DialogResult = DialogResult.None;
            buttonSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonSave.ForeColor = Color.White;
            buttonSave.HoverBackground = Color.FromArgb(33, 136, 56);
            buttonSave.HoveredImageTint = Color.White;
            buttonSave.HoverForeColor = Color.White;
            buttonSave.HoverOutline = Color.Empty;
            buttonSave.Image = null;
            buttonSave.ImageAutoCenter = true;
            buttonSave.ImageExpand = new Point(0, 0);
            buttonSave.ImageOffset = new Point(0, 0);
            buttonSave.Location = new Point(650, 600);
            buttonSave.Name = "buttonSave";
            buttonSave.NormalBackground = Color.FromArgb(40, 167, 69);
            buttonSave.NormalForeColor = Color.White;
            buttonSave.NormalImageTint = Color.White;
            buttonSave.NormalOutline = Color.Empty;
            buttonSave.OutlineThickness = 1.6F;
            buttonSave.PressedBackground = Color.FromArgb(43, 168, 75);
            buttonSave.PressedForeColor = Color.White;
            buttonSave.PressedImageTint = Color.White;
            buttonSave.PressedOutline = Color.Empty;
            buttonSave.Rounding = new Padding(8);
            buttonSave.Size = new Size(250, 50);
            buttonSave.TabIndex = 48;
            buttonSave.TextOffset = new Point(0, 0);
            buttonSave.Click += buttonSave_Click;
            // 
            // FormEditTeam
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 760);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditTeam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modifier l'équipe";
            Load += FormEditTeam_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelForm;
        private CheckedListBox clbMembers;
        private ComboBox cmbLeader;
        private ComboBox cmbProject;
        private Label lblMembers;
        private Label lblLeader;
        private Label lblProject;
        private TextBox txtTeamName;
        private Label lblTeamName;
        private CuoreUI.Controls.cuiButton btnCancel;
        private CuoreUI.Controls.cuiButton buttonSave;

    }
}
       

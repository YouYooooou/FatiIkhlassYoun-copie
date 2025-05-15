namespace FatiIkhlassYoun
{
    partial class FormAddTeam
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
            checkedListBoxMembers = new CheckedListBox();
            comboBoxProject = new ComboBox();
            comboBoxLeader = new ComboBox();
            label3 = new Label();
            label7 = new Label();
            label2 = new Label();
            buttonSave = new CuoreUI.Controls.cuiButton();
            txtTeamName = new TextBox();
            Title = new Label();
            btnCancel = new CuoreUI.Controls.cuiButton();
            panel1 = new Panel();
            label1 = new Label();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(51, 51, 76);
            panelHeader.Controls.Add(panel1);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(6, 6, 6, 6);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1509, 115);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(40, 29);
            lblTitle.Margin = new Padding(6, 0, 6, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(524, 74);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Ajouter une équipe";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(checkedListBoxMembers);
            panelForm.Controls.Add(comboBoxProject);
            panelForm.Controls.Add(comboBoxLeader);
            panelForm.Controls.Add(label3);
            panelForm.Controls.Add(label7);
            panelForm.Controls.Add(label2);
            panelForm.Controls.Add(buttonSave);
            panelForm.Controls.Add(txtTeamName);
            panelForm.Controls.Add(Title);
            panelForm.Controls.Add(btnCancel);
            panelForm.Location = new Point(0, 109);
            panelForm.Margin = new Padding(6, 6, 6, 6);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(60, 58, 60, 58);
            panelForm.Size = new Size(1503, 1350);
            panelForm.TabIndex = 1;
            // 
            // checkedListBoxMembers
            // 
            checkedListBoxMembers.BackColor = Color.WhiteSmoke;
            checkedListBoxMembers.BorderStyle = BorderStyle.None;
            checkedListBoxMembers.Font = new Font("Segoe UI", 10F);
            checkedListBoxMembers.FormattingEnabled = true;
            checkedListBoxMembers.Location = new Point(600, 672);
            checkedListBoxMembers.Margin = new Padding(6, 6, 6, 6);
            checkedListBoxMembers.Name = "checkedListBoxMembers";
            checkedListBoxMembers.Size = new Size(622, 180);
            checkedListBoxMembers.TabIndex = 46;
            // 
            // comboBoxProject
            // 
            comboBoxProject.BackColor = Color.WhiteSmoke;
            comboBoxProject.FlatStyle = FlatStyle.Flat;
            comboBoxProject.Font = new Font("Segoe UI", 10F);
            comboBoxProject.FormattingEnabled = true;
            comboBoxProject.Location = new Point(600, 173);
            comboBoxProject.Margin = new Padding(6, 6, 6, 6);
            comboBoxProject.Name = "comboBoxProject";
            comboBoxProject.Size = new Size(602, 62);
            comboBoxProject.TabIndex = 45;
            comboBoxProject.SelectedIndexChanged += comboBoxProject_SelectedIndexChanged;
            // 
            // comboBoxLeader
            // 
            comboBoxLeader.BackColor = Color.WhiteSmoke;
            comboBoxLeader.FlatStyle = FlatStyle.Flat;
            comboBoxLeader.Font = new Font("Segoe UI", 10F);
            comboBoxLeader.FormattingEnabled = true;
            comboBoxLeader.Location = new Point(600, 518);
            comboBoxLeader.Margin = new Padding(6, 6, 6, 6);
            comboBoxLeader.Name = "comboBoxLeader";
            comboBoxLeader.Size = new Size(602, 62);
            comboBoxLeader.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(60, 173);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(270, 48);
            label3.TabIndex = 43;
            label3.Text = "Projet associé :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(60, 518);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(274, 48);
            label7.TabIndex = 42;
            label7.Text = "Chef d'équipe :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(60, 672);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(354, 48);
            label2.TabIndex = 41;
            label2.Text = "Membres d'équipe :";
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
            buttonSave.Content = "Enregistrer";
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
            buttonSave.Location = new Point(377, 1130);
            buttonSave.Margin = new Padding(6, 6, 6, 6);
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
            buttonSave.Size = new Size(373, 113);
            buttonSave.TabIndex = 37;
            buttonSave.TextOffset = new Point(0, 0);
            buttonSave.Click += buttonSave_Click;
            // 
            // txtTeamName
            // 
            txtTeamName.BackColor = Color.WhiteSmoke;
            txtTeamName.BorderStyle = BorderStyle.None;
            txtTeamName.Font = new Font("Segoe UI", 10F);
            txtTeamName.Location = new Point(600, 346);
            txtTeamName.Margin = new Padding(6, 6, 6, 6);
            txtTeamName.Name = "txtTeamName";
            txtTeamName.Size = new Size(602, 54);
            txtTeamName.TabIndex = 36;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.FromArgb(64, 64, 64);
            Title.Location = new Point(60, 346);
            Title.Margin = new Padding(6, 0, 6, 0);
            Title.Name = "Title";
            Title.Size = new Size(123, 48);
            Title.TabIndex = 32;
            Title.Text = "Nom :";
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
            btnCancel.Location = new Point(-252, 1130);
            btnCancel.Margin = new Padding(6, 6, 6, 6);
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
            btnCancel.Size = new Size(373, 113);
            btnCancel.TabIndex = 47;
            btnCancel.TextOffset = new Point(0, 0);
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1509, 115);
            panel1.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(39, 21);
            label1.Name = "label1";
            label1.Size = new Size(283, 60);
            label1.TabIndex = 21;
            label1.Text = "Add Team :";
            // 
            // FormAddTeam
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1509, 1459);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 6, 6, 6);
            Name = "FormAddTeam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ajouter une équipe";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelForm;
        private CheckedListBox checkedListBoxMembers;
        private ComboBox comboBoxProject;
        private ComboBox comboBoxLeader;
        private Label label3;
        private Label label7;
        private Label label2;
        private CuoreUI.Controls.cuiButton buttonSave;
        private TextBox txtTeamName;
        private Label Title;
        private CuoreUI.Controls.cuiButton btnCancel;
        private Panel panel1;
        private Label label1;
    }
}
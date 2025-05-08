namespace FatiIkhlassYoun
{
    partial class FormEditEmployee
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
            label1 = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblOldPassword = new Label();
            txtOldPassword = new TextBox();
            lblNewPassword = new Label();
            txtNewPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblRole = new Label();
            cbRole = new ComboBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblActive = new Label();
            chkActive = new CheckBox();
            btnSave = new CuoreUI.Controls.cuiButton();
            btnCancel = new CuoreUI.Controls.cuiButton();
            panelHeader = new Panel();
            lblTitle = new Label();
            panelForm = new Panel();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(251, 13);
            label1.Name = "label1";
            label1.Size = new Size(255, 32);
            label1.TabIndex = 0;
            label1.Text = "Modifier un employé";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(64, 64, 64);
            lblUsername.Location = new Point(33, 66);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(105, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username :";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.WhiteSmoke;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(33, 96);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(400, 27);
            txtUsername.TabIndex = 2;
            // 
            // lblOldPassword
            // 
            lblOldPassword.AutoSize = true;
            lblOldPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOldPassword.ForeColor = Color.FromArgb(64, 64, 64);
            lblOldPassword.Location = new Point(33, 136);
            lblOldPassword.Name = "lblOldPassword";
            lblOldPassword.Size = new Size(134, 25);
            lblOldPassword.TabIndex = 3;
            lblOldPassword.Text = "Old Password :";
            // 
            // txtOldPassword
            // 
            txtOldPassword.BackColor = Color.WhiteSmoke;
            txtOldPassword.BorderStyle = BorderStyle.None;
            txtOldPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOldPassword.Location = new Point(33, 166);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '*';
            txtOldPassword.Size = new Size(400, 27);
            txtOldPassword.TabIndex = 4;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewPassword.ForeColor = Color.FromArgb(64, 64, 64);
            lblNewPassword.Location = new Point(33, 206);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(142, 25);
            lblNewPassword.TabIndex = 5;
            lblNewPassword.Text = "New Password :";
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = Color.WhiteSmoke;
            txtNewPassword.BorderStyle = BorderStyle.None;
            txtNewPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(33, 236);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(400, 27);
            txtNewPassword.TabIndex = 6;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmPassword.ForeColor = Color.FromArgb(64, 64, 64);
            lblConfirmPassword.Location = new Point(33, 276);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(171, 25);
            lblConfirmPassword.TabIndex = 7;
            lblConfirmPassword.Text = "Confirm Password :";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.WhiteSmoke;
            txtConfirmPassword.BorderStyle = BorderStyle.None;
            txtConfirmPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(33, 306);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(400, 27);
            txtConfirmPassword.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(64, 64, 64);
            lblEmail.Location = new Point(467, 66);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 25);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.WhiteSmoke;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(467, 96);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(300, 27);
            txtEmail.TabIndex = 10;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.FromArgb(64, 64, 64);
            lblRole.Location = new Point(467, 136);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(58, 25);
            lblRole.TabIndex = 11;
            lblRole.Text = "Role :";
            // 
            // cbRole
            // 
            cbRole.BackColor = Color.WhiteSmoke;
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.FlatStyle = FlatStyle.Flat;
            cbRole.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "admin", "chef_projet", "chef_equipe", "membre" });
            cbRole.Location = new Point(467, 166);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(300, 36);
            cbRole.TabIndex = 12;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.FromArgb(64, 64, 64);
            lblPhone.Location = new Point(467, 216);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(148, 25);
            lblPhone.TabIndex = 13;
            lblPhone.Text = "Phone Number :";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.WhiteSmoke;
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(467, 246);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(300, 27);
            txtPhone.TabIndex = 14;
            // 
            // lblActive
            // 
            lblActive.AutoSize = true;
            lblActive.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActive.ForeColor = Color.FromArgb(64, 64, 64);
            lblActive.Location = new Point(467, 286);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(90, 25);
            lblActive.TabIndex = 15;
            lblActive.Text = "Is Active :";
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Location = new Point(467, 316);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(22, 21);
            chkActive.TabIndex = 16;
            chkActive.UseVisualStyleBackColor = true;
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
            btnSave.Location = new Point(590, 397);
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
            btnSave.Size = new Size(177, 83);
            btnSave.TabIndex = 17;
            btnSave.TextOffset = new Point(0, 0);
            btnSave.Click += btnSave_Click;
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
            btnCancel.Location = new Point(373, 397);
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
            btnCancel.Size = new Size(172, 83);
            btnCancel.TabIndex = 18;
            btnCancel.TextOffset = new Point(0, 0);
            btnCancel.Click += btnCancel_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(51, 51, 76);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 60);
            panelHeader.TabIndex = 36;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(284, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Modifier un employé";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(label1);
            panelForm.Controls.Add(lblUsername);
            panelForm.Controls.Add(txtUsername);
            panelForm.Controls.Add(lblOldPassword);
            panelForm.Controls.Add(txtOldPassword);
            panelForm.Controls.Add(lblNewPassword);
            panelForm.Controls.Add(txtNewPassword);
            panelForm.Controls.Add(lblConfirmPassword);
            panelForm.Controls.Add(txtConfirmPassword);
            panelForm.Controls.Add(lblEmail);
            panelForm.Controls.Add(txtEmail);
            panelForm.Controls.Add(lblRole);
            panelForm.Controls.Add(cbRole);
            panelForm.Controls.Add(lblPhone);
            panelForm.Controls.Add(txtPhone);
            panelForm.Controls.Add(lblActive);
            panelForm.Controls.Add(chkActive);
            panelForm.Controls.Add(btnSave);
            panelForm.Controls.Add(btnCancel);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 60);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(30);
            panelForm.Size = new Size(800, 531);
            panelForm.TabIndex = 37;
            // 
            // FormEditEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 591);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modifier un employé";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblOldPassword;
        private TextBox txtOldPassword;
        private Label lblNewPassword;
        private TextBox txtNewPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblRole;
        private ComboBox cbRole;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblActive;
        private CheckBox chkActive;
        private CuoreUI.Controls.cuiButton btnSave;
        private CuoreUI.Controls.cuiButton btnCancel;
        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelForm;
    }
}
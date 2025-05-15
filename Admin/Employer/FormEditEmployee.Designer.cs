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
            label1 = new Label();
            panelHeader = new Panel();
            btnSend = new CuoreUI.Controls.cuiButton();
            btnCancel = new CuoreUI.Controls.cuiButton();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(19, 222);
            lblUsername.Margin = new Padding(10, 0, 10, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(198, 48);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username :";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(371, 219);
            txtUsername.Margin = new Padding(10, 11, 10, 11);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(571, 55);
            txtUsername.TabIndex = 2;
            // 
            // lblOldPassword
            // 
            lblOldPassword.AutoSize = true;
            lblOldPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOldPassword.Location = new Point(19, 333);
            lblOldPassword.Margin = new Padding(10, 0, 10, 0);
            lblOldPassword.Name = "lblOldPassword";
            lblOldPassword.Size = new Size(253, 48);
            lblOldPassword.TabIndex = 3;
            lblOldPassword.Text = "Old Password :";
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(371, 330);
            txtOldPassword.Margin = new Padding(10, 11, 10, 11);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '*';
            txtOldPassword.Size = new Size(571, 55);
            txtOldPassword.TabIndex = 4;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewPassword.Location = new Point(19, 444);
            lblNewPassword.Margin = new Padding(10, 0, 10, 0);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(268, 48);
            lblNewPassword.TabIndex = 5;
            lblNewPassword.Text = "New Password :";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(371, 440);
            txtNewPassword.Margin = new Padding(10, 11, 10, 11);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(571, 55);
            txtNewPassword.TabIndex = 6;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.Location = new Point(19, 555);
            lblConfirmPassword.Margin = new Padding(10, 0, 10, 0);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(323, 48);
            lblConfirmPassword.TabIndex = 7;
            lblConfirmPassword.Text = "Confirm Password :";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(371, 552);
            txtConfirmPassword.Margin = new Padding(10, 11, 10, 11);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(571, 55);
            txtConfirmPassword.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(1040, 222);
            lblEmail.Margin = new Padding(10, 0, 10, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(113, 48);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(1343, 222);
            txtEmail.Margin = new Padding(10, 11, 10, 11);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(552, 55);
            txtEmail.TabIndex = 10;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(1040, 332);
            lblRole.Margin = new Padding(10, 0, 10, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(108, 48);
            lblRole.TabIndex = 11;
            lblRole.Text = "Role :";
            // 
            // cbRole
            // 
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "admin", "chef_projet", "chef_equipe", "membre" });
            cbRole.Location = new Point(1343, 333);
            cbRole.Margin = new Padding(10, 11, 10, 11);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(552, 56);
            cbRole.TabIndex = 12;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(1040, 443);
            lblPhone.Margin = new Padding(10, 0, 10, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(279, 48);
            lblPhone.TabIndex = 13;
            lblPhone.Text = "Phone Number :";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(1343, 437);
            txtPhone.Margin = new Padding(10, 11, 10, 11);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(552, 55);
            txtPhone.TabIndex = 14;
            // 
            // lblActive
            // 
            lblActive.AutoSize = true;
            lblActive.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblActive.Location = new Point(1040, 554);
            lblActive.Margin = new Padding(10, 0, 10, 0);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(170, 48);
            lblActive.TabIndex = 15;
            lblActive.Text = "Is Active :";
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Location = new Point(1354, 562);
            chkActive.Margin = new Padding(10, 11, 10, 11);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(42, 41);
            chkActive.TabIndex = 16;
            chkActive.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(39, 21);
            label1.Name = "label1";
            label1.Size = new Size(485, 60);
            label1.TabIndex = 21;
            label1.Text = "Edit Employee Info :";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.HotTrack;
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(6);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(2030, 115);
            panelHeader.TabIndex = 38;
            // 
            // btnSend
            // 
            btnSend.CheckButton = false;
            btnSend.Checked = false;
            btnSend.CheckedBackground = Color.FromArgb(40, 167, 69);
            btnSend.CheckedForeColor = Color.White;
            btnSend.CheckedImageTint = Color.White;
            btnSend.CheckedOutline = Color.FromArgb(40, 167, 69);
            btnSend.Content = "Send";
            btnSend.Cursor = Cursors.Hand;
            btnSend.DialogResult = DialogResult.None;
            btnSend.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSend.ForeColor = Color.White;
            btnSend.HoverBackground = Color.FromArgb(33, 136, 56);
            btnSend.HoveredImageTint = Color.White;
            btnSend.HoverForeColor = Color.White;
            btnSend.HoverOutline = Color.Empty;
            btnSend.Image = null;
            btnSend.ImageAutoCenter = true;
            btnSend.ImageExpand = new Point(0, 0);
            btnSend.ImageOffset = new Point(0, 0);
            btnSend.Location = new Point(1117, 739);
            btnSend.Margin = new Padding(6);
            btnSend.Name = "btnSend";
            btnSend.NormalBackground = Color.FromArgb(40, 167, 69);
            btnSend.NormalForeColor = Color.White;
            btnSend.NormalImageTint = Color.White;
            btnSend.NormalOutline = Color.Empty;
            btnSend.OutlineThickness = 1.6F;
            btnSend.PressedBackground = Color.FromArgb(43, 168, 75);
            btnSend.PressedForeColor = Color.White;
            btnSend.PressedImageTint = Color.White;
            btnSend.PressedOutline = Color.Empty;
            btnSend.Rounding = new Padding(8);
            btnSend.Size = new Size(279, 112);
            btnSend.TabIndex = 40;
            btnSend.TextOffset = new Point(0, 0);
            btnSend.Click += btnSend_Click;
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
            btnCancel.Location = new Point(683, 739);
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
            btnCancel.Size = new Size(264, 112);
            btnCancel.TabIndex = 41;
            btnCancel.TextOffset = new Point(0, 0);
            btnCancel.Click += btnCancel_Click_1;
            // 
            // FormEditEmployee
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(2030, 935);
            Controls.Add(btnSend);
            Controls.Add(btnCancel);
            Controls.Add(panelHeader);
            Controls.Add(chkActive);
            Controls.Add(lblActive);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(cbRole);
            Controls.Add(lblRole);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(txtOldPassword);
            Controls.Add(lblOldPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(10, 11, 10, 11);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEditEmployee";
            StartPosition = FormStartPosition.CenterParent;
            Load += FormEditEmployee_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.CheckBox chkActive;
        private Label label1;
        private Panel panelHeader;
        private CuoreUI.Controls.cuiButton btnSend;
        private CuoreUI.Controls.cuiButton btnCancel;
    }



}
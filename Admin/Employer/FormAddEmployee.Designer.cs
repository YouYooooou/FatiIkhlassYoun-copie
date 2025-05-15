namespace FatiIkhlassYoun
{
    partial class FormAddEmployee
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
            label3 = new Label();
            txtUsername = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtPhone = new TextBox();
            label8 = new Label();
            cmbRole = new ComboBox();
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
            label1.Location = new Point(502, 25);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(643, 65);
            label1.TabIndex = 0;
            label1.Text = "Ajouter un nouvel employé";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(66, 127);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(203, 48);
            label3.TabIndex = 3;
            label3.Text = "Username :";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.WhiteSmoke;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(66, 184);
            txtUsername.Margin = new Padding(6);
            txtUsername.MaxLength = 20;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(800, 54);
            txtUsername.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(66, 300);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(194, 48);
            label4.TabIndex = 5;
            label4.Text = "Password :";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(66, 357);
            txtPassword.Margin = new Padding(6);
            txtPassword.MaxLength = 20;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(800, 54);
            txtPassword.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(66, 434);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(127, 48);
            label5.TabIndex = 7;
            label5.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.WhiteSmoke;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(66, 492);
            txtEmail.Margin = new Padding(6);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(800, 54);
            txtEmail.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(66, 609);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(143, 48);
            label6.TabIndex = 9;
            label6.Text = "Phone :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(66, 781);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(110, 48);
            label7.TabIndex = 11;
            label7.Text = "Role :";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.WhiteSmoke;
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(66, 666);
            txtPhone.Margin = new Padding(6);
            txtPhone.MaxLength = 15;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(600, 54);
            txtPhone.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(66, 588);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(0, 48);
            label8.TabIndex = 13;
            // 
            // cmbRole
            // 
            cmbRole.BackColor = Color.WhiteSmoke;
            cmbRole.FlatStyle = FlatStyle.Flat;
            cmbRole.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "admin", "chef_projet", "chef_equipe", "membre" });
            cmbRole.Location = new Point(66, 839);
            cmbRole.Margin = new Padding(6);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(596, 62);
            cmbRole.TabIndex = 14;
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
            btnSave.Location = new Point(814, 1006);
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
            btnSave.Size = new Size(354, 159);
            btnSave.TabIndex = 17;
            btnSave.TextOffset = new Point(0, 0);
            btnSave.Click += buttonSave_Click;
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
            btnCancel.Location = new Point(380, 1006);
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
            btnCancel.Size = new Size(344, 159);
            btnCancel.TabIndex = 18;
            btnCancel.TextOffset = new Point(0, 0);
            btnCancel.Click += btnCancel_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.HotTrack;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(6);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1404, 115);
            panelHeader.TabIndex = 36;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(40, 29);
            lblTitle.Margin = new Padding(6, 0, 6, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(503, 63);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Ajouter un employé";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(label1);
            panelForm.Controls.Add(label3);
            panelForm.Controls.Add(txtUsername);
            panelForm.Controls.Add(label4);
            panelForm.Controls.Add(txtPassword);
            panelForm.Controls.Add(label5);
            panelForm.Controls.Add(txtEmail);
            panelForm.Controls.Add(label6);
            panelForm.Controls.Add(label7);
            panelForm.Controls.Add(txtPhone);
            panelForm.Controls.Add(label8);
            panelForm.Controls.Add(cmbRole);
            panelForm.Controls.Add(btnSave);
            panelForm.Controls.Add(btnCancel);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 115);
            panelForm.Margin = new Padding(6);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(60, 58, 60, 58);
            panelForm.Size = new Size(1404, 1229);
            panelForm.TabIndex = 37;
            // 
            // FormAddEmployee
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1404, 1344);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "FormAddEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ajouter un employé";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox txtUsername;
        private Label label4;
        private TextBox txtPassword;
        private Label label5;
        private TextBox txtEmail;
        private Label label6;
        private Label label7;
        private TextBox txtPhone;
        private Label label8;
        private ComboBox cmbRole;
        private CuoreUI.Controls.cuiButton btnSave;
        private CuoreUI.Controls.cuiButton btnCancel;
        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelForm;
    }
}
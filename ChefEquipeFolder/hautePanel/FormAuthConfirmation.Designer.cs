namespace FatiIkhlassYoun.NewFolder
{
    partial class FormAuthConfirmation
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
            lblInstruction = new Label();
            lblPassword = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnAnnuler = new CuoreUI.Controls.cuiButton();
            btnConfirmer = new CuoreUI.Controls.cuiButton();
            panelHeader = new Panel();
            lblTitle = new Label();
            panelForm = new Panel();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            SuspendLayout();
            // 
            // lblInstruction
            // 
            lblInstruction.AutoSize = true;
            lblInstruction.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstruction.ForeColor = Color.FromArgb(64, 64, 64);
            lblInstruction.Location = new Point(117, 32);
            lblInstruction.Margin = new Padding(4, 0, 4, 0);
            lblInstruction.MaximumSize = new Size(400, 0);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(343, 56);
            lblInstruction.TabIndex = 0;
            lblInstruction.Text = "Veuillez confirmer votre identité avant d'effectuer cette action";
            lblInstruction.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(64, 64, 64);
            lblPassword.Location = new Point(40, 180);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(124, 25);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Mot de passe";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(64, 64, 64);
            lblUsername.Location = new Point(40, 120);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(159, 25);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Nom d'utilisateur";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.WhiteSmoke;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(40, 150);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(400, 27);
            txtUsername.TabIndex = 3;
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(40, 210);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(400, 27);
            txtPassword.TabIndex = 4;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnnuler.CheckButton = false;
            btnAnnuler.Checked = false;
            btnAnnuler.CheckedBackground = Color.FromArgb(200, 35, 51);
            btnAnnuler.CheckedForeColor = Color.White;
            btnAnnuler.CheckedImageTint = Color.White;
            btnAnnuler.CheckedOutline = Color.FromArgb(200, 35, 51);
            btnAnnuler.Content = "Annuler";
            btnAnnuler.Cursor = Cursors.Hand;
            btnAnnuler.DialogResult = DialogResult.None;
            btnAnnuler.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnnuler.ForeColor = Color.White;
            btnAnnuler.HoverBackground = Color.FromArgb(200, 35, 51);
            btnAnnuler.HoveredImageTint = Color.White;
            btnAnnuler.HoverForeColor = Color.White;
            btnAnnuler.HoverOutline = Color.Empty;
            btnAnnuler.Image = null;
            btnAnnuler.ImageAutoCenter = true;
            btnAnnuler.ImageExpand = new Point(0, 0);
            btnAnnuler.ImageOffset = new Point(0, 0);
            btnAnnuler.Location = new Point(256, 299);
            btnAnnuler.Margin = new Padding(4);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.NormalBackground = Color.FromArgb(223, 53, 69);
            btnAnnuler.NormalForeColor = Color.White;
            btnAnnuler.NormalImageTint = Color.White;
            btnAnnuler.NormalOutline = Color.Empty;
            btnAnnuler.OutlineThickness = 1.6F;
            btnAnnuler.PressedBackground = Color.FromArgb(210, 35, 51);
            btnAnnuler.PressedForeColor = Color.White;
            btnAnnuler.PressedImageTint = Color.White;
            btnAnnuler.PressedOutline = Color.Empty;
            btnAnnuler.Rounding = new Padding(8);
            btnAnnuler.Size = new Size(133, 54);
            btnAnnuler.TabIndex = 33;
            btnAnnuler.TextOffset = new Point(0, 0);
            btnAnnuler.Click += btnAnnuler_Click_1;
            // 
            // btnConfirmer
            // 
            btnConfirmer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmer.CheckButton = false;
            btnConfirmer.Checked = false;
            btnConfirmer.CheckedBackground = Color.FromArgb(40, 167, 69);
            btnConfirmer.CheckedForeColor = Color.White;
            btnConfirmer.CheckedImageTint = Color.White;
            btnConfirmer.CheckedOutline = Color.FromArgb(40, 167, 69);
            btnConfirmer.Content = "Confirmer";
            btnConfirmer.Cursor = Cursors.Hand;
            btnConfirmer.DialogResult = DialogResult.None;
            btnConfirmer.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmer.ForeColor = Color.White;
            btnConfirmer.HoverBackground = Color.FromArgb(33, 136, 56);
            btnConfirmer.HoveredImageTint = Color.White;
            btnConfirmer.HoverForeColor = Color.White;
            btnConfirmer.HoverOutline = Color.Empty;
            btnConfirmer.Image = null;
            btnConfirmer.ImageAutoCenter = true;
            btnConfirmer.ImageExpand = new Point(0, 0);
            btnConfirmer.ImageOffset = new Point(0, 0);
            btnConfirmer.Location = new Point(411, 299);
            btnConfirmer.Margin = new Padding(4);
            btnConfirmer.Name = "btnConfirmer";
            btnConfirmer.NormalBackground = Color.FromArgb(40, 167, 69);
            btnConfirmer.NormalForeColor = Color.White;
            btnConfirmer.NormalImageTint = Color.White;
            btnConfirmer.NormalOutline = Color.Empty;
            btnConfirmer.OutlineThickness = 1.6F;
            btnConfirmer.PressedBackground = Color.FromArgb(43, 168, 75);
            btnConfirmer.PressedForeColor = Color.White;
            btnConfirmer.PressedImageTint = Color.White;
            btnConfirmer.PressedOutline = Color.Empty;
            btnConfirmer.Rounding = new Padding(8);
            btnConfirmer.Size = new Size(133, 54);
            btnConfirmer.TabIndex = 32;
            btnConfirmer.TextOffset = new Point(0, 0);
            btnConfirmer.Click += btnConfirmer_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(51, 51, 76);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(600, 60);
            panelHeader.TabIndex = 34;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(221, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Authentification";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(lblInstruction);
            panelForm.Controls.Add(btnConfirmer);
            panelForm.Controls.Add(lblUsername);
            panelForm.Controls.Add(btnAnnuler);
            panelForm.Controls.Add(lblPassword);
            panelForm.Controls.Add(txtPassword);
            panelForm.Controls.Add(txtUsername);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 60);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(600, 390);
            panelForm.TabIndex = 35;
            panelForm.Paint += panelForm_Paint;
            // 
            // FormAuthConfirmation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 450);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAuthConfirmation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Authentification";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Label lblInstruction;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private CuoreUI.Controls.cuiButton btnAnnuler;
        private CuoreUI.Controls.cuiButton btnConfirmer;
        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelForm;
    }
}
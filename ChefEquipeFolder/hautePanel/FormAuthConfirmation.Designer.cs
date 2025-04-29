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
            SuspendLayout();
            // 
            // lblInstruction
            // 
            lblInstruction.AutoSize = true;
            lblInstruction.Location = new Point(139, 20);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(494, 25);
            lblInstruction.TabIndex = 0;
            lblInstruction.Text = "Veuillez confirmer votre identité avant d’effectuer cette action";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 154);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(129, 25);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Mot de passe :";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(12, 91);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(157, 25);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Nom d’utilisateur :";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(203, 91);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(150, 31);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(203, 154);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 4;
            // 
            // btnAnnuler
            // 
            btnAnnuler.CheckButton = false;
            btnAnnuler.Checked = false;
            btnAnnuler.CheckedBackground = Color.FromArgb(200, 35, 51);
            btnAnnuler.CheckedForeColor = Color.White;
            btnAnnuler.CheckedImageTint = Color.White;
            btnAnnuler.CheckedOutline = Color.FromArgb(200, 35, 51);
            btnAnnuler.Content = "Annuler";
            btnAnnuler.DialogResult = DialogResult.None;
            btnAnnuler.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnnuler.ForeColor = Color.White;
            btnAnnuler.HoverBackground = Color.FromArgb(200, 35, 51);
            btnAnnuler.HoveredImageTint = Color.White;
            btnAnnuler.HoverForeColor = Color.White;
            btnAnnuler.HoverOutline = Color.Empty;
            btnAnnuler.Image = null;
            btnAnnuler.ImageAutoCenter = true;
            btnAnnuler.ImageExpand = new Point(0, 0);
            btnAnnuler.ImageOffset = new Point(0, 0);
            btnAnnuler.NormalImageTint = Color.White;
            btnAnnuler.Location = new Point(170, 302);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.NormalBackground = Color.FromArgb(223, 53, 69);
            btnAnnuler.NormalOutline = Color.Empty;
            btnAnnuler.OutlineThickness = 1.6F;
            btnAnnuler.PressedBackground = Color.FromArgb(210, 35, 51);
            btnAnnuler.PressedForeColor = Color.White;
            btnAnnuler.PressedImageTint = Color.White;
            btnAnnuler.PressedOutline = Color.Empty;
            btnAnnuler.Rounding = new Padding(8);
            btnAnnuler.Size = new Size(206, 73);
            btnAnnuler.TabIndex = 33;
            btnAnnuler.TextOffset = new Point(0, 0);
            // 
            // btnConfirmer
            // 
            btnConfirmer.CheckButton = false;
            btnConfirmer.Checked = false;
            btnConfirmer.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnConfirmer.CheckedForeColor = Color.White;
            btnConfirmer.CheckedImageTint = Color.White;
            btnConfirmer.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnConfirmer.Content = "Confirmer";
            btnConfirmer.DialogResult = DialogResult.None;
            btnConfirmer.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmer.ForeColor = Color.White;
            btnConfirmer.HoverBackground = Color.FromArgb(33, 136, 56);
            btnConfirmer.HoveredImageTint = Color.White;
            btnConfirmer.HoverForeColor = Color.White;
            btnConfirmer.HoverOutline = Color.Empty;
            btnConfirmer.Image = null;
            btnConfirmer.ImageAutoCenter = true;
            btnConfirmer.ImageExpand = new Point(0, 0);
            btnConfirmer.ImageOffset = new Point(0, 0);
            btnConfirmer.NormalImageTint = Color.White;
            btnConfirmer.Location = new Point(427, 302);
            btnConfirmer.Name = "btnConfirmer";
            btnConfirmer.NormalBackground = Color.FromArgb(40, 167, 69);
            btnConfirmer.NormalOutline = Color.Empty;
            btnConfirmer.OutlineThickness = 1.6F;
            btnConfirmer.PressedBackground = Color.FromArgb(43, 168, 75);
            btnConfirmer.PressedForeColor = Color.White;
            btnConfirmer.PressedImageTint = Color.White;
            btnConfirmer.PressedOutline = Color.Empty;
            btnConfirmer.Rounding = new Padding(8);
            btnConfirmer.Size = new Size(206, 73);
            btnConfirmer.TabIndex = 32;
            btnConfirmer.TextOffset = new Point(0, 0);
            btnConfirmer.Click += btnConfirmer_Click;
            // 
            // FormAuthConfirmation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAnnuler);
            Controls.Add(btnConfirmer);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblInstruction);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAuthConfirmation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAuthConfirmation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInstruction;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private CuoreUI.Controls.cuiButton btnAnnuler;
        private CuoreUI.Controls.cuiButton btnConfirmer;
    }
}
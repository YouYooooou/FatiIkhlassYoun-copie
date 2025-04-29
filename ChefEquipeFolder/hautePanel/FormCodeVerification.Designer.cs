namespace FatiIkhlassYoun.NewFolder
{
    partial class FormCodeVerification
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
            txtCode = new TextBox();
            btnAnnuler = new CuoreUI.Controls.cuiButton();
            btnVerifier = new CuoreUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // lblInstruction
            // 
            lblInstruction.AutoSize = true;
            lblInstruction.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstruction.Location = new Point(12, 46);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(286, 28);
            lblInstruction.TabIndex = 0;
            lblInstruction.Text = "Entrez le code reçu par email :\n";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(362, 46);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(212, 31);
            txtCode.TabIndex = 1;
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
            btnAnnuler.Location = new Point(93, 166);
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
            btnAnnuler.TabIndex = 20;
            btnAnnuler.TextOffset = new Point(0, 0);
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // btnVerifier
            // 
            btnVerifier.CheckButton = false;
            btnVerifier.Checked = false;
            btnVerifier.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnVerifier.CheckedForeColor = Color.White;
            btnVerifier.CheckedImageTint = Color.White;
            btnVerifier.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnVerifier.Content = "Verifier";
            btnVerifier.DialogResult = DialogResult.None;
            btnVerifier.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerifier.ForeColor = Color.White;
            btnVerifier.HoverBackground = Color.FromArgb(33, 136, 56);
            btnVerifier.HoveredImageTint = Color.White;
            btnVerifier.HoverForeColor = Color.White;
            btnVerifier.HoverOutline = Color.Empty;
            btnVerifier.Image = null;
            btnVerifier.ImageAutoCenter = true;
            btnVerifier.ImageExpand = new Point(0, 0);
            btnVerifier.ImageOffset = new Point(0, 0);
            btnVerifier.NormalImageTint = Color.White;
            btnVerifier.Location = new Point(350, 166);
            btnVerifier.Name = "btnVerifier";
            btnVerifier.NormalBackground = Color.FromArgb(40, 167, 69);
            btnVerifier.NormalOutline = Color.Empty;
            btnVerifier.OutlineThickness = 1.6F;
            btnVerifier.PressedBackground = Color.FromArgb(43, 168, 75);
            btnVerifier.PressedForeColor = Color.White;
            btnVerifier.PressedImageTint = Color.White;
            btnVerifier.PressedOutline = Color.Empty;
            btnVerifier.Rounding = new Padding(8);
            btnVerifier.Size = new Size(206, 73);
            btnVerifier.TabIndex = 19;
            btnVerifier.TextOffset = new Point(0, 0);
            btnVerifier.Click += btnVerifier_Click;
            // 
            // FormCodeVerification
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 311);
            Controls.Add(btnAnnuler);
            Controls.Add(btnVerifier);
            Controls.Add(txtCode);
            Controls.Add(lblInstruction);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCodeVerification";
            Text = "FormCodeVerification";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInstruction;
        private TextBox txtCode;
        private CuoreUI.Controls.cuiButton btnAnnuler;
        private CuoreUI.Controls.cuiButton btnVerifier;
    }
}
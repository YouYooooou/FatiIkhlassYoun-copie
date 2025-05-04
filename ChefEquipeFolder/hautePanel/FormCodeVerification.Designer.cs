namespace FatiIkhlassYoun.NewFolder
{
    partial class FormCodeVerification
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
            lblTitle = new Label();
            panelHeader = new Panel();
            lblInstruction = new Label();
            txtCode = new TextBox();
            btnAnnuler = new CuoreUI.Controls.cuiButton();
            btnVerifier = new CuoreUI.Controls.cuiButton();
            panelForm = new Panel();
            lblEmailInfo = new Label();
            lblTentatives = new Label();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(271, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Vérification du code";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(51, 51, 76);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(500, 60);
            panelHeader.TabIndex = 0;
            // 
            // lblInstruction
            // 
            lblInstruction.AutoSize = true;
            lblInstruction.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblInstruction.ForeColor = Color.FromArgb(64, 64, 64);
            lblInstruction.Location = new Point(35, 93);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(205, 28);
            lblInstruction.TabIndex = 0;
            lblInstruction.Text = "Code de vérification :";
            // 
            // txtCode
            // 
            txtCode.BackColor = Color.WhiteSmoke;
            txtCode.BorderStyle = BorderStyle.None;
            txtCode.Font = new Font("Segoe UI", 12F);
            txtCode.Location = new Point(246, 93);
            txtCode.MaxLength = 6;
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(200, 32);
            txtCode.TabIndex = 1;
            txtCode.TextAlign = HorizontalAlignment.Center;
            txtCode.Enter += txtCode_Enter;
            txtCode.Leave += txtCode_Leave;
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
            btnAnnuler.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAnnuler.ForeColor = Color.White;
            btnAnnuler.HoverBackground = Color.FromArgb(200, 35, 51);
            btnAnnuler.HoveredImageTint = Color.White;
            btnAnnuler.HoverForeColor = Color.White;
            btnAnnuler.HoverOutline = Color.Empty;
            btnAnnuler.Image = null;
            btnAnnuler.ImageAutoCenter = true;
            btnAnnuler.ImageExpand = new Point(0, 0);
            btnAnnuler.ImageOffset = new Point(0, 0);
            btnAnnuler.Location = new Point(103, 162);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.NormalBackground = Color.FromArgb(223, 53, 69);
            btnAnnuler.NormalForeColor = Color.White;
            btnAnnuler.NormalImageTint = Color.White;
            btnAnnuler.NormalOutline = Color.Empty;
            btnAnnuler.OutlineThickness = 1.6F;
            btnAnnuler.PressedBackground = Color.FromArgb(255, 106, 0);
            btnAnnuler.PressedForeColor = Color.White;
            btnAnnuler.PressedImageTint = Color.White;
            btnAnnuler.PressedOutline = Color.Empty;
            btnAnnuler.Rounding = new Padding(8);
            btnAnnuler.Size = new Size(120, 48);
            btnAnnuler.TabIndex = 20;
            btnAnnuler.TextOffset = new Point(0, 0);
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // btnVerifier
            // 
            btnVerifier.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVerifier.CheckButton = false;
            btnVerifier.Checked = false;
            btnVerifier.CheckedBackground = Color.FromArgb(40, 167, 69);
            btnVerifier.CheckedForeColor = Color.White;
            btnVerifier.CheckedImageTint = Color.White;
            btnVerifier.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnVerifier.Content = "Vérifier";
            btnVerifier.Cursor = Cursors.Hand;
            btnVerifier.DialogResult = DialogResult.None;
            btnVerifier.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVerifier.ForeColor = Color.White;
            btnVerifier.HoverBackground = Color.FromArgb(33, 136, 56);
            btnVerifier.HoveredImageTint = Color.White;
            btnVerifier.HoverForeColor = Color.White;
            btnVerifier.HoverOutline = Color.Empty;
            btnVerifier.Image = null;
            btnVerifier.ImageAutoCenter = true;
            btnVerifier.ImageExpand = new Point(0, 0);
            btnVerifier.ImageOffset = new Point(0, 0);
            btnVerifier.Location = new Point(283, 162);
            btnVerifier.Name = "btnVerifier";
            btnVerifier.NormalBackground = Color.FromArgb(40, 167, 69);
            btnVerifier.NormalForeColor = Color.White;
            btnVerifier.NormalImageTint = Color.White;
            btnVerifier.NormalOutline = Color.Empty;
            btnVerifier.OutlineThickness = 1.6F;
            btnVerifier.PressedBackground = Color.FromArgb(255, 106, 0);
            btnVerifier.PressedForeColor = Color.White;
            btnVerifier.PressedImageTint = Color.White;
            btnVerifier.PressedOutline = Color.Empty;
            btnVerifier.Rounding = new Padding(8);
            btnVerifier.Size = new Size(120, 48);
            btnVerifier.TabIndex = 19;
            btnVerifier.TextOffset = new Point(0, 0);
            btnVerifier.Click += btnVerifier_Click;
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(lblEmailInfo);
            panelForm.Controls.Add(lblInstruction);
            panelForm.Controls.Add(txtCode);
            panelForm.Controls.Add(btnVerifier);
            panelForm.Controls.Add(btnAnnuler);
            panelForm.Controls.Add(lblTentatives);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 60);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(500, 240);
            panelForm.TabIndex = 1;
            // 
            // lblEmailInfo
            // 
            lblEmailInfo.AutoSize = true;
            lblEmailInfo.Font = new Font("Segoe UI", 9F);
            lblEmailInfo.ForeColor = Color.FromArgb(64, 64, 64);
            lblEmailInfo.Location = new Point(100, 32);
            lblEmailInfo.Name = "lblEmailInfo";
            lblEmailInfo.Size = new Size(290, 25);
            lblEmailInfo.TabIndex = 4;
            lblEmailInfo.Text = "Un code a été envoyé à votre email";
            lblEmailInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTentatives
            // 
            lblTentatives.AutoSize = true;
            lblTentatives.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblTentatives.ForeColor = Color.FromArgb(64, 64, 64);
            lblTentatives.Location = new Point(283, 128);
            lblTentatives.Name = "lblTentatives";
            lblTentatives.Size = new Size(166, 21);
            lblTentatives.TabIndex = 6;
            lblTentatives.Text = "Tentatives restantes : 3";
            // 
            // FormCodeVerification
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 300);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCodeVerification";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vérification du code";
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
        private Label lblInstruction;
        private TextBox txtCode;
        private CuoreUI.Controls.cuiButton btnVerifier;
        private CuoreUI.Controls.cuiButton btnAnnuler;
        private Label lblEmailInfo;
        private Label lblTentatives;

    }
}
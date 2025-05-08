namespace FatiIkhlassYoun.membreFolder
{
    partial class formModfTacheMembre
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
            cuiButton2 = new CuoreUI.Controls.cuiButton();
            btnModifier = new CuoreUI.Controls.cuiButton();
            comboStatus = new ComboBox();
            label6 = new Label();
            txtDescription = new TextBox();
            label5 = new Label();
            txtTitre = new TextBox();
            label4 = new Label();
            comboTache = new ComboBox();
            label3 = new Label();
            comboEquipe = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            comboProjet = new ComboBox();
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
            panelHeader.Size = new Size(781, 60);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(288, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Modifier Statut Tâche";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(cuiButton2);
            panelForm.Controls.Add(btnModifier);
            panelForm.Controls.Add(comboStatus);
            panelForm.Controls.Add(label6);
            panelForm.Controls.Add(txtDescription);
            panelForm.Controls.Add(label5);
            panelForm.Controls.Add(txtTitre);
            panelForm.Controls.Add(label4);
            panelForm.Controls.Add(comboTache);
            panelForm.Controls.Add(label3);
            panelForm.Controls.Add(comboEquipe);
            panelForm.Controls.Add(label2);
            panelForm.Controls.Add(label1);
            panelForm.Controls.Add(comboProjet);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 60);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(20);
            panelForm.Size = new Size(781, 756);
            panelForm.TabIndex = 1;
            // 
            // cuiButton2
            // 
            cuiButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cuiButton2.CheckButton = false;
            cuiButton2.Checked = false;
            cuiButton2.CheckedBackground = Color.FromArgb(200, 35, 51);
            cuiButton2.CheckedForeColor = Color.White;
            cuiButton2.CheckedImageTint = Color.White;
            cuiButton2.CheckedOutline = Color.FromArgb(200, 35, 51);
            cuiButton2.Content = "Annuler";
            cuiButton2.Cursor = Cursors.Hand;
            cuiButton2.DialogResult = DialogResult.None;
            cuiButton2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiButton2.ForeColor = Color.White;
            cuiButton2.HoverBackground = Color.FromArgb(200, 35, 51);
            cuiButton2.HoveredImageTint = Color.White;
            cuiButton2.HoverForeColor = Color.White;
            cuiButton2.HoverOutline = Color.Empty;
            cuiButton2.Image = null;
            cuiButton2.ImageAutoCenter = true;
            cuiButton2.ImageExpand = new Point(0, 0);
            cuiButton2.ImageOffset = new Point(0, 0);
            cuiButton2.Location = new Point(348, 664);
            cuiButton2.Name = "cuiButton2";
            cuiButton2.NormalBackground = Color.FromArgb(223, 53, 69);
            cuiButton2.NormalForeColor = Color.White;
            cuiButton2.NormalImageTint = Color.White;
            cuiButton2.NormalOutline = Color.Empty;
            cuiButton2.OutlineThickness = 1.6F;
            cuiButton2.PressedBackground = Color.FromArgb(210, 35, 51);
            cuiButton2.PressedForeColor = Color.White;
            cuiButton2.PressedImageTint = Color.White;
            cuiButton2.PressedOutline = Color.Empty;
            cuiButton2.Rounding = new Padding(8);
            cuiButton2.Size = new Size(173, 69);
            cuiButton2.TabIndex = 13;
            cuiButton2.TextOffset = new Point(0, 0);
            cuiButton2.Click += cuiButton2_Click;
            // 
            // btnModifier
            // 
            btnModifier.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnModifier.CheckButton = false;
            btnModifier.Checked = false;
            btnModifier.CheckedBackground = Color.FromArgb(40, 167, 69);
            btnModifier.CheckedForeColor = Color.White;
            btnModifier.CheckedImageTint = Color.White;
            btnModifier.CheckedOutline = Color.FromArgb(40, 167, 69);
            btnModifier.Content = "Modifier";
            btnModifier.Cursor = Cursors.Hand;
            btnModifier.DialogResult = DialogResult.None;
            btnModifier.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifier.ForeColor = Color.White;
            btnModifier.HoverBackground = Color.FromArgb(33, 136, 56);
            btnModifier.HoveredImageTint = Color.White;
            btnModifier.HoverForeColor = Color.White;
            btnModifier.HoverOutline = Color.Empty;
            btnModifier.Image = null;
            btnModifier.ImageAutoCenter = true;
            btnModifier.ImageExpand = new Point(0, 0);
            btnModifier.ImageOffset = new Point(0, 0);
            btnModifier.Location = new Point(557, 664);
            btnModifier.Name = "btnModifier";
            btnModifier.NormalBackground = Color.FromArgb(40, 167, 69);
            btnModifier.NormalForeColor = Color.White;
            btnModifier.NormalImageTint = Color.White;
            btnModifier.NormalOutline = Color.Empty;
            btnModifier.OutlineThickness = 1.6F;
            btnModifier.PressedBackground = Color.FromArgb(43, 168, 75);
            btnModifier.PressedForeColor = Color.White;
            btnModifier.PressedImageTint = Color.White;
            btnModifier.PressedOutline = Color.Empty;
            btnModifier.Rounding = new Padding(8);
            btnModifier.Size = new Size(170, 69);
            btnModifier.TabIndex = 12;
            btnModifier.TextOffset = new Point(0, 0);
            btnModifier.Click += btnModifier_Click;
            // 
            // comboStatus
            // 
            comboStatus.BackColor = Color.WhiteSmoke;
            comboStatus.FlatStyle = FlatStyle.Flat;
            comboStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboStatus.FormattingEnabled = true;
            comboStatus.Location = new Point(307, 400);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(420, 36);
            comboStatus.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(36, 407);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 10;
            label6.Text = "Statut :";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.WhiteSmoke;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(307, 237);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(420, 150);
            txtDescription.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(36, 237);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 8;
            label5.Text = "Description :";
            // 
            // txtTitre
            // 
            txtTitre.BackColor = Color.WhiteSmoke;
            txtTitre.BorderStyle = BorderStyle.None;
            txtTitre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitre.Location = new Point(307, 187);
            txtTitre.Name = "txtTitre";
            txtTitre.ReadOnly = true;
            txtTitre.Size = new Size(420, 27);
            txtTitre.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(36, 187);
            label4.Name = "label4";
            label4.Size = new Size(135, 25);
            label4.TabIndex = 6;
            label4.Text = "Titre de tâche :";
            // 
            // comboTache
            // 
            comboTache.BackColor = Color.WhiteSmoke;
            comboTache.FlatStyle = FlatStyle.Flat;
            comboTache.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboTache.FormattingEnabled = true;
            comboTache.Location = new Point(307, 130);
            comboTache.Name = "comboTache";
            comboTache.Size = new Size(420, 36);
            comboTache.TabIndex = 5;
            comboTache.SelectedIndexChanged += comboTache_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(36, 137);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 4;
            label3.Text = "Tâche :";
            // 
            // comboEquipe
            // 
            comboEquipe.BackColor = Color.WhiteSmoke;
            comboEquipe.FlatStyle = FlatStyle.Flat;
            comboEquipe.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboEquipe.FormattingEnabled = true;
            comboEquipe.Location = new Point(307, 80);
            comboEquipe.Name = "comboEquipe";
            comboEquipe.Size = new Size(420, 36);
            comboEquipe.TabIndex = 3;
            comboEquipe.SelectedIndexChanged += comboEquipe_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(36, 87);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 2;
            label2.Text = "Équipe :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(36, 37);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 1;
            label1.Text = "Projet :";
            // 
            // comboProjet
            // 
            comboProjet.BackColor = Color.WhiteSmoke;
            comboProjet.FlatStyle = FlatStyle.Flat;
            comboProjet.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboProjet.FormattingEnabled = true;
            comboProjet.Location = new Point(307, 30);
            comboProjet.Name = "comboProjet";
            comboProjet.Size = new Size(420, 36);
            comboProjet.TabIndex = 0;
            comboProjet.SelectedIndexChanged += comboProjet_SelectedIndexChanged;
            // 
            // formModfTacheMembre
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 816);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formModfTacheMembre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modifier Tâche (Membre)";
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
        private ComboBox comboProjet;
        private Label label1;
        private Label label2;
        private ComboBox comboEquipe;
        private Label label3;
        private ComboBox comboTache;
        private Label label4;
        private TextBox txtTitre;
        private Label label5;
        private TextBox txtDescription;
        private Label label6;
        private ComboBox comboStatus;
        private CuoreUI.Controls.cuiButton btnModifier;
        private CuoreUI.Controls.cuiButton cuiButton2;
    }
}
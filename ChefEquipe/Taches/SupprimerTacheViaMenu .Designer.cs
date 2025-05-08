namespace FatiIkhlassYoun.NewFolder
{
    partial class SupprimerTacheViaMenu
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
            label1 = new Label();
            txtDescription = new TextBox();
            txtTitre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnAnnuler = new CuoreUI.Controls.cuiButton();
            btnSupprimer = new CuoreUI.Controls.cuiButton();
            label9 = new Label();
            comboBoxTaches = new ComboBox();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(51, 51, 76);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(624, 60);
            panelHeader.TabIndex = 32;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(228, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Supprimer Tâche";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(192, 86);
            label1.Name = "label1";
            label1.Size = new Size(252, 32);
            label1.TabIndex = 33;
            label1.Text = "Supprimer une tâche";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.WhiteSmoke;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(52, 286);
            txtDescription.MaxLength = 200;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(520, 100);
            txtDescription.TabIndex = 37;
            // 
            // txtTitre
            // 
            txtTitre.BackColor = Color.WhiteSmoke;
            txtTitre.BorderStyle = BorderStyle.None;
            txtTitre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitre.Location = new Point(52, 206);
            txtTitre.MaxLength = 20;
            txtTitre.Name = "txtTitre";
            txtTitre.ReadOnly = true;
            txtTitre.Size = new Size(520, 27);
            txtTitre.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(52, 256);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 35;
            label4.Text = "Description :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(52, 176);
            label3.Name = "label3";
            label3.Size = new Size(135, 25);
            label3.TabIndex = 34;
            label3.Text = "Titre de tâche :";
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
            btnAnnuler.Location = new Point(272, 427);
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
            btnAnnuler.Size = new Size(134, 59);
            btnAnnuler.TabIndex = 39;
            btnAnnuler.TextOffset = new Point(0, 0);
            btnAnnuler.Click += (s, e) => this.Close();
            // 
            // btnSupprimer
            // 
            btnSupprimer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSupprimer.CheckButton = false;
            btnSupprimer.Checked = false;
            btnSupprimer.CheckedBackground = Color.FromArgb(200, 35, 51);
            btnSupprimer.CheckedForeColor = Color.White;
            btnSupprimer.CheckedImageTint = Color.White;
            btnSupprimer.CheckedOutline = Color.FromArgb(200, 35, 51);
            btnSupprimer.Content = "Supprimer";
            btnSupprimer.Cursor = Cursors.Hand;
            btnSupprimer.DialogResult = DialogResult.None;
            btnSupprimer.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupprimer.ForeColor = Color.White;
            btnSupprimer.HoverBackground = Color.FromArgb(200, 35, 51);
            btnSupprimer.HoveredImageTint = Color.White;
            btnSupprimer.HoverForeColor = Color.White;
            btnSupprimer.HoverOutline = Color.Empty;
            btnSupprimer.Image = null;
            btnSupprimer.ImageAutoCenter = true;
            btnSupprimer.ImageExpand = new Point(0, 0);
            btnSupprimer.ImageOffset = new Point(0, 0);
            btnSupprimer.Location = new Point(438, 427);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.NormalBackground = Color.FromArgb(223, 53, 69);
            btnSupprimer.NormalForeColor = Color.White;
            btnSupprimer.NormalImageTint = Color.White;
            btnSupprimer.NormalOutline = Color.Empty;
            btnSupprimer.OutlineThickness = 1.6F;
            btnSupprimer.PressedBackground = Color.FromArgb(210, 35, 51);
            btnSupprimer.PressedForeColor = Color.White;
            btnSupprimer.PressedImageTint = Color.White;
            btnSupprimer.PressedOutline = Color.Empty;
            btnSupprimer.Rounding = new Padding(8);
            btnSupprimer.Size = new Size(134, 59);
            btnSupprimer.TabIndex = 38;
            btnSupprimer.TextOffset = new Point(0, 0);
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(52, 136);
            label9.Name = "label9";
            label9.Size = new Size(135, 25);
            label9.TabIndex = 41;
            label9.Text = "Sélectionner :";
            // 
            // comboBoxTaches
            // 
            comboBoxTaches.BackColor = Color.WhiteSmoke;
            comboBoxTaches.FlatStyle = FlatStyle.Flat;
            comboBoxTaches.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxTaches.FormattingEnabled = true;
            comboBoxTaches.Location = new Point(307, 133);
            comboBoxTaches.Name = "comboBoxTaches";
            comboBoxTaches.Size = new Size(265, 36);
            comboBoxTaches.TabIndex = 40;
            comboBoxTaches.SelectedIndexChanged += comboBoxTaches_SelectedIndexChanged;
            // 
            // SupprimerTacheViaMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(624, 527);
            Controls.Add(label9);
            Controls.Add(comboBoxTaches);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(txtTitre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnAnnuler);
            Controls.Add(btnSupprimer);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SupprimerTacheViaMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SupprimerTacheViaMenu";
            Load += SupprimerTacheViaMenu_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelHeader;
        private Label lblTitle;
        private Label label1;
        private TextBox txtDescription;
        private TextBox txtTitre;
        private Label label4;
        private Label label3;
        private CuoreUI.Controls.cuiButton btnAnnuler;
        private CuoreUI.Controls.cuiButton btnSupprimer;
        private Label label9;
        private ComboBox comboBoxTaches;
    }
}
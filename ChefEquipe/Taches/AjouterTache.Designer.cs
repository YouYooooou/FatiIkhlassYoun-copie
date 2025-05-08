
namespace FatiIkhlassYoun
{
    partial class AjouterTache
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
            comboProjet = new ComboBox();
            label4 = new Label();
            txtTitre = new TextBox();
            label5 = new Label();
            txtDescription = new TextBox();
            label6 = new Label();
            dtpDebut = new DateTimePicker();
            label7 = new Label();
            dtpFin = new DateTimePicker();
            label8 = new Label();
            comboStatus = new ComboBox();
            label9 = new Label();
            numTemps = new NumericUpDown();
            btnAjouter = new CuoreUI.Controls.cuiButton();
            cuiButton2 = new CuoreUI.Controls.cuiButton();
            label2 = new Label();
            panelHeader = new Panel();
            lblTitle = new Label();
            panelForm = new Panel();
            checkedListBoxMembres = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)numTemps).BeginInit();
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
            label1.Size = new Size(298, 32);
            label1.TabIndex = 0;
            label1.Text = "Créer une nouvelle tâche";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(33, 66);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 3;
            label3.Text = "Projet :";
            // 
            // comboProjet
            // 
            comboProjet.BackColor = Color.WhiteSmoke;
            comboProjet.DropDownStyle = ComboBoxStyle.DropDownList;
            comboProjet.FlatStyle = FlatStyle.Flat;
            comboProjet.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboProjet.FormattingEnabled = true;
            comboProjet.Location = new Point(33, 96);
            comboProjet.Name = "comboProjet";
            comboProjet.Size = new Size(400, 36);
            comboProjet.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(33, 156);
            label4.Name = "label4";
            label4.Size = new Size(135, 25);
            label4.TabIndex = 5;
            label4.Text = "Titre de tâche :";
            // 
            // txtTitre
            // 
            txtTitre.BackColor = Color.WhiteSmoke;
            txtTitre.BorderStyle = BorderStyle.None;
            txtTitre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitre.Location = new Point(33, 186);
            txtTitre.MaxLength = 20;
            txtTitre.Name = "txtTitre";
            txtTitre.Size = new Size(400, 27);
            txtTitre.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(33, 226);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 7;
            label5.Text = "Description :";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.WhiteSmoke;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(33, 256);
            txtDescription.MaxLength = 200;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(400, 198);
            txtDescription.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(467, 306);
            label6.Name = "label6";
            label6.Size = new Size(141, 25);
            label6.TabIndex = 9;
            label6.Text = "Date de début :";
            // 
            // dtpDebut
            // 
            dtpDebut.CalendarMonthBackground = Color.WhiteSmoke;
            dtpDebut.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDebut.Location = new Point(467, 336);
            dtpDebut.Name = "dtpDebut";
            dtpDebut.Size = new Size(300, 34);
            dtpDebut.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(467, 383);
            label7.Name = "label7";
            label7.Size = new Size(113, 25);
            label7.TabIndex = 11;
            label7.Text = "Date limite :";
            // 
            // dtpFin
            // 
            dtpFin.CalendarMonthBackground = Color.WhiteSmoke;
            dtpFin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFin.Location = new Point(467, 413);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(300, 34);
            dtpFin.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(467, 226);
            label8.Name = "label8";
            label8.Size = new Size(71, 25);
            label8.TabIndex = 13;
            label8.Text = "Statut :";
            // 
            // comboStatus
            // 
            comboStatus.BackColor = Color.WhiteSmoke;
            comboStatus.FlatStyle = FlatStyle.Flat;
            comboStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboStatus.FormattingEnabled = true;
            comboStatus.Location = new Point(467, 256);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(300, 36);
            comboStatus.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(33, 475);
            label9.Name = "label9";
            label9.Size = new Size(157, 25);
            label9.TabIndex = 15;
            label9.Text = "Temps estimé (h):";
            // 
            // numTemps
            // 
            numTemps.BackColor = Color.WhiteSmoke;
            numTemps.BorderStyle = BorderStyle.None;
            numTemps.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numTemps.Location = new Point(33, 505);
            numTemps.Name = "numTemps";
            numTemps.Size = new Size(150, 30);
            numTemps.TabIndex = 16;
            // 
            // btnAjouter
            // 
            btnAjouter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAjouter.CheckButton = false;
            btnAjouter.Checked = false;
            btnAjouter.CheckedBackground = Color.FromArgb(40, 167, 69);
            btnAjouter.CheckedForeColor = Color.White;
            btnAjouter.CheckedImageTint = Color.White;
            btnAjouter.CheckedOutline = Color.FromArgb(40, 167, 69);
            btnAjouter.Content = "Ajouter";
            btnAjouter.Cursor = Cursors.Hand;
            btnAjouter.DialogResult = DialogResult.None;
            btnAjouter.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjouter.ForeColor = Color.White;
            btnAjouter.HoverBackground = Color.FromArgb(33, 136, 56);
            btnAjouter.HoveredImageTint = Color.White;
            btnAjouter.HoverForeColor = Color.White;
            btnAjouter.HoverOutline = Color.Empty;
            btnAjouter.Image = null;
            btnAjouter.ImageAutoCenter = true;
            btnAjouter.ImageExpand = new Point(0, 0);
            btnAjouter.ImageOffset = new Point(0, 0);
            btnAjouter.Location = new Point(583, 524);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.NormalBackground = Color.FromArgb(40, 167, 69);
            btnAjouter.NormalForeColor = Color.White;
            btnAjouter.NormalImageTint = Color.White;
            btnAjouter.NormalOutline = Color.Empty;
            btnAjouter.OutlineThickness = 1.6F;
            btnAjouter.PressedBackground = Color.FromArgb(43, 168, 75);
            btnAjouter.PressedForeColor = Color.White;
            btnAjouter.PressedImageTint = Color.White;
            btnAjouter.PressedOutline = Color.Empty;
            btnAjouter.Rounding = new Padding(8);
            btnAjouter.Size = new Size(177, 83);
            btnAjouter.TabIndex = 17;
            btnAjouter.TextOffset = new Point(0, 0);
            btnAjouter.Click += btnAjouter_Click;
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
            cuiButton2.Location = new Point(366, 524);
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
            cuiButton2.Size = new Size(172, 83);
            cuiButton2.TabIndex = 18;
            cuiButton2.TextOffset = new Point(0, 0);
            cuiButton2.Click += cuiButton2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(467, 90);
            label2.Name = "label2";
            label2.Size = new Size(226, 25);
            label2.TabIndex = 21;
            label2.Text = "Membre affecté à la tâche";
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
            lblTitle.Size = new Size(243, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Ajouter une tâche";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(checkedListBoxMembres);
            panelForm.Controls.Add(label1);
            panelForm.Controls.Add(label3);
            panelForm.Controls.Add(comboProjet);
            panelForm.Controls.Add(label4);
            panelForm.Controls.Add(txtTitre);
            panelForm.Controls.Add(label5);
            panelForm.Controls.Add(txtDescription);
            panelForm.Controls.Add(label6);
            panelForm.Controls.Add(dtpDebut);
            panelForm.Controls.Add(label7);
            panelForm.Controls.Add(dtpFin);
            panelForm.Controls.Add(label8);
            panelForm.Controls.Add(comboStatus);
            panelForm.Controls.Add(label9);
            panelForm.Controls.Add(numTemps);
            panelForm.Controls.Add(btnAjouter);
            panelForm.Controls.Add(cuiButton2);
            panelForm.Controls.Add(label2);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 60);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(30);
            panelForm.Size = new Size(800, 640);
            panelForm.TabIndex = 37;
            // 
            // checkedListBoxMembres
            // 
            checkedListBoxMembres.BackColor = Color.WhiteSmoke;
            checkedListBoxMembres.Font = new Font("Segoe UI", 10F);
            checkedListBoxMembres.FormattingEnabled = true;
            checkedListBoxMembres.Location = new Point(467, 66);
            checkedListBoxMembres.Name = "checkedListBoxMembres";
            checkedListBoxMembres.Size = new Size(300, 159);
            checkedListBoxMembres.TabIndex = 22;
            // 
            // AjouterTache
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 700);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AjouterTache";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ajouter une tache";
            ((System.ComponentModel.ISupportInitialize)numTemps).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private Label label1;
        private Label label3;
        private ComboBox comboProjet;
        private Label label4;
        private TextBox txtTitre;
        private Label label5;
        private TextBox txtDescription;
        private Label label6;
        private DateTimePicker dtpDebut;
        private Label label7;
        private DateTimePicker dtpFin;
        private Label label8;
        private ComboBox comboStatus;
        private Label label9;
        private NumericUpDown numTemps;
        private CuoreUI.Controls.cuiButton btnAjouter;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private Label label2;
        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelForm;
    }
}
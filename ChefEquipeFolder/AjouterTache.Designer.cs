
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
            textBox1 = new TextBox();
            text_box1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numTemps).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 9);
            label1.Name = "label1";
            label1.Size = new Size(293, 45);
            label1.TabIndex = 0;
            label1.Text = "Create a New Task";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 147);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 3;
            label3.Text = "Projet : ";
            // 
            // comboProjet
            // 
            comboProjet.DropDownStyle = ComboBoxStyle.DropDownList;
            comboProjet.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboProjet.FormattingEnabled = true;
            comboProjet.Location = new Point(315, 147);
            comboProjet.Name = "comboProjet";
            comboProjet.Size = new Size(372, 36);
            comboProjet.TabIndex = 4;
            comboProjet.SelectedIndexChanged += cmbProjet_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 210);
            label4.Name = "label4";
            label4.Size = new Size(184, 28);
            label4.TabIndex = 5;
            label4.Text = "Titre de la tache : ";
            // 
            // txtTitre
            // 
            txtTitre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitre.Location = new Point(315, 210);
            txtTitre.MaxLength = 20;
            txtTitre.Name = "txtTitre";
            txtTitre.Size = new Size(372, 34);
            txtTitre.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 272);
            label5.Name = "label5";
            label5.Size = new Size(138, 28);
            label5.TabIndex = 7;
            label5.Text = "Description : ";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(315, 269);
            txtDescription.MaxLength = 200;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(372, 158);
            txtDescription.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(41, 463);
            label6.Name = "label6";
            label6.Size = new Size(164, 28);
            label6.TabIndex = 9;
            label6.Text = "Date de début : ";
            // 
            // dtpDebut
            // 
            dtpDebut.Location = new Point(315, 461);
            dtpDebut.Name = "dtpDebut";
            dtpDebut.Size = new Size(372, 31);
            dtpDebut.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(41, 518);
            label7.Name = "label7";
            label7.Size = new Size(135, 28);
            label7.TabIndex = 11;
            label7.Text = "Date limite : ";
            // 
            // dtpFin
            // 
            dtpFin.Location = new Point(315, 516);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(372, 31);
            dtpFin.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(44, 575);
            label8.Name = "label8";
            label8.Size = new Size(90, 28);
            label8.TabIndex = 13;
            label8.Text = "Statue : ";
            // 
            // comboStatus
            // 
            comboStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboStatus.FormattingEnabled = true;
            comboStatus.Items.AddRange(new object[] { "En attente", "En cours", "Terminée" });
            comboStatus.Location = new Point(315, 575);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(372, 36);
            comboStatus.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(44, 635);
            label9.Name = "label9";
            label9.Size = new Size(190, 28);
            label9.TabIndex = 15;
            label9.Text = "Temps estimé (h) : ";
            // 
            // numTemps
            // 
            numTemps.Location = new Point(315, 636);
            numTemps.Name = "numTemps";
            numTemps.Size = new Size(127, 31);
            numTemps.TabIndex = 16;
            // 
            // btnAjouter
            // 
            btnAjouter.CheckButton = false;
            btnAjouter.Checked = false;
            btnAjouter.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnAjouter.CheckedForeColor = Color.White;
            btnAjouter.CheckedImageTint = Color.White;
            btnAjouter.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnAjouter.Content = "Ajouter";
            btnAjouter.DialogResult = DialogResult.None;
            btnAjouter.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjouter.ForeColor = Color.White;
            btnAjouter.HoverBackground = Color.FromArgb(33, 136, 56);
            btnAjouter.HoveredImageTint = Color.White;
            btnAjouter.HoverForeColor = Color.White;
            btnAjouter.HoverOutline = Color.Empty;
            btnAjouter.Image = null;
            btnAjouter.ImageAutoCenter = true;
            btnAjouter.ImageExpand = new Point(0, 0);
            btnAjouter.ImageOffset = new Point(0, 0);
            btnAjouter.ImageTint = Color.White;
            btnAjouter.Location = new Point(470, 728);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.NormalBackground = Color.FromArgb(40, 167, 69);
            btnAjouter.NormalOutline = Color.Empty;
            btnAjouter.OutlineThickness = 1.6F;
            btnAjouter.PressedBackground = Color.FromArgb(43, 168, 75);
            btnAjouter.PressedForeColor = Color.White;
            btnAjouter.PressedImageTint = Color.White;
            btnAjouter.PressedOutline = Color.Empty;
            btnAjouter.Rounding = new Padding(8);
            btnAjouter.Size = new Size(206, 73);
            btnAjouter.TabIndex = 17;
            btnAjouter.TextOffset = new Point(0, 0);
            btnAjouter.Click += btnAjouter_Click;
            // 
            // cuiButton2
            // 
            cuiButton2.CheckButton = false;
            cuiButton2.Checked = false;
            cuiButton2.CheckedBackground = Color.FromArgb(200, 35, 51);
            cuiButton2.CheckedForeColor = Color.White;
            cuiButton2.CheckedImageTint = Color.White;
            cuiButton2.CheckedOutline = Color.FromArgb(200, 35, 51);
            cuiButton2.Content = "Annuler";
            cuiButton2.DialogResult = DialogResult.None;
            cuiButton2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiButton2.ForeColor = Color.White;
            cuiButton2.HoverBackground = Color.FromArgb(200, 35, 51);
            cuiButton2.HoveredImageTint = Color.White;
            cuiButton2.HoverForeColor = Color.White;
            cuiButton2.HoverOutline = Color.Empty;
            cuiButton2.Image = null;
            cuiButton2.ImageAutoCenter = true;
            cuiButton2.ImageExpand = new Point(0, 0);
            cuiButton2.ImageOffset = new Point(0, 0);
            cuiButton2.ImageTint = Color.White;
            cuiButton2.Location = new Point(213, 728);
            cuiButton2.Name = "cuiButton2";
            cuiButton2.NormalBackground = Color.FromArgb(223, 53, 69);
            cuiButton2.NormalOutline = Color.Empty;
            cuiButton2.OutlineThickness = 1.6F;
            cuiButton2.PressedBackground = Color.FromArgb(210, 35, 51);
            cuiButton2.PressedForeColor = Color.White;
            cuiButton2.PressedImageTint = Color.White;
            cuiButton2.PressedOutline = Color.Empty;
            cuiButton2.Rounding = new Padding(8);
            cuiButton2.Size = new Size(206, 73);
            cuiButton2.TabIndex = 18;
            cuiButton2.TextOffset = new Point(0, 0);
            cuiButton2.Click += cuiButton2_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(315, 90);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(372, 31);
            textBox1.TabIndex = 19;
            // 
            // text_box1
            // 
            text_box1.AutoSize = true;
            text_box1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text_box1.Location = new Point(41, 90);
            text_box1.Name = "text_box1";
            text_box1.Size = new Size(160, 28);
            text_box1.TabIndex = 20;
            text_box1.Text = "ID de la tache : ";
            // 
            // AjouterTache
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(732, 847);
            Controls.Add(text_box1);
            Controls.Add(textBox1);
            Controls.Add(cuiButton2);
            Controls.Add(btnAjouter);
            Controls.Add(numTemps);
            Controls.Add(label9);
            Controls.Add(comboStatus);
            Controls.Add(label8);
            Controls.Add(dtpFin);
            Controls.Add(label7);
            Controls.Add(dtpDebut);
            Controls.Add(label6);
            Controls.Add(txtDescription);
            Controls.Add(label5);
            Controls.Add(txtTitre);
            Controls.Add(label4);
            Controls.Add(comboProjet);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AjouterTache";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ajouter une tache";
            Load += AjouterTache_Load;
            ((System.ComponentModel.ISupportInitialize)numTemps).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AjouterTache_Load(object sender, EventArgs e)
        {
            ChargerProjets();
            ChargerStatus();
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
        private TextBox textBox1;
        private Label text_box1;
    }
}
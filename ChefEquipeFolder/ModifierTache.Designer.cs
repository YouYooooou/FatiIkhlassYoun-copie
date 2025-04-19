namespace FatiIkhlassYoun
{
    partial class ModifierTache
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            cuiButton2 = new CuoreUI.Controls.cuiButton();
            btnModifier = new CuoreUI.Controls.cuiButton();
            comboTache = new ComboBox();
            txtTitre = new TextBox();
            txtDescription = new TextBox();
            dtpDebut = new DateTimePicker();
            dtpFin = new DateTimePicker();
            comboStatus = new ComboBox();
            numTemps = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numTemps).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(193, 19);
            label1.Name = "label1";
            label1.Size = new Size(341, 45);
            label1.TabIndex = 1;
            label1.Text = "Edite an existing Task";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 100);
            label2.Name = "label2";
            label2.Size = new Size(297, 28);
            label2.TabIndex = 2;
            label2.Text = "Choisir une tache a modifier : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 168);
            label3.Name = "label3";
            label3.Size = new Size(167, 28);
            label3.TabIndex = 3;
            label3.Text = "Titre de la tâche";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 227);
            label4.Name = "label4";
            label4.Size = new Size(138, 28);
            label4.TabIndex = 4;
            label4.Text = "Description : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 415);
            label5.Name = "label5";
            label5.Size = new Size(158, 28);
            label5.TabIndex = 5;
            label5.Text = "Date de début :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 515);
            label7.Name = "label7";
            label7.Size = new Size(81, 28);
            label7.TabIndex = 7;
            label7.Text = "Statut :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 465);
            label6.Name = "label6";
            label6.Size = new Size(129, 56);
            label6.TabIndex = 8;
            label6.Text = "Date de fin :\r\n\r\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 566);
            label8.Name = "label8";
            label8.Size = new Size(152, 28);
            label8.TabIndex = 9;
            label8.Text = "Temps estimé :";
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
            cuiButton2.Cursor = Cursors.Hand;
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
            cuiButton2.Location = new Point(204, 677);
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
            cuiButton2.TabIndex = 20;
            cuiButton2.TextOffset = new Point(0, 0);
            cuiButton2.Click += cuiButton2_Click;
            // 
            // btnModifier
            // 
            btnModifier.CheckButton = false;
            btnModifier.Checked = false;
            btnModifier.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnModifier.CheckedForeColor = Color.White;
            btnModifier.CheckedImageTint = Color.White;
            btnModifier.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnModifier.Content = "Modifier";
            btnModifier.Cursor = Cursors.Hand;
            btnModifier.DialogResult = DialogResult.None;
            btnModifier.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifier.ForeColor = Color.White;
            btnModifier.HoverBackground = Color.FromArgb(33, 136, 56);
            btnModifier.HoveredImageTint = Color.White;
            btnModifier.HoverForeColor = Color.White;
            btnModifier.HoverOutline = Color.Empty;
            btnModifier.Image = null;
            btnModifier.ImageAutoCenter = true;
            btnModifier.ImageExpand = new Point(0, 0);
            btnModifier.ImageOffset = new Point(0, 0);
            btnModifier.ImageTint = Color.White;
            btnModifier.Location = new Point(461, 677);
            btnModifier.Name = "btnModifier";
            btnModifier.NormalBackground = Color.FromArgb(40, 167, 69);
            btnModifier.NormalOutline = Color.Empty;
            btnModifier.OutlineThickness = 1.6F;
            btnModifier.PressedBackground = Color.FromArgb(43, 168, 75);
            btnModifier.PressedForeColor = Color.White;
            btnModifier.PressedImageTint = Color.White;
            btnModifier.PressedOutline = Color.Empty;
            btnModifier.Rounding = new Padding(8);
            btnModifier.Size = new Size(206, 73);
            btnModifier.TabIndex = 19;
            btnModifier.TextOffset = new Point(0, 0);
            btnModifier.Click += btnModifier_Click;
            // 
            // comboTache
            // 
            comboTache.FormattingEnabled = true;
            comboTache.Location = new Point(315, 100);
            comboTache.Name = "comboTache";
            comboTache.Size = new Size(352, 33);
            comboTache.TabIndex = 21;
            comboTache.SelectedIndexChanged += comboTache_SelectedIndexChanged;
            // 
            // txtTitre
            // 
            txtTitre.Location = new Point(315, 165);
            txtTitre.MaxLength = 20;
            txtTitre.Name = "txtTitre";
            txtTitre.Size = new Size(352, 31);
            txtTitre.TabIndex = 22;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(315, 227);
            txtDescription.MaxLength = 200;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(352, 141);
            txtDescription.TabIndex = 23;
            // 
            // dtpDebut
            // 
            dtpDebut.Location = new Point(315, 413);
            dtpDebut.Name = "dtpDebut";
            dtpDebut.Size = new Size(352, 31);
            dtpDebut.TabIndex = 24;
            // 
            // dtpFin
            // 
            dtpFin.Location = new Point(315, 463);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(352, 31);
            dtpFin.TabIndex = 25;
            // 
            // comboStatus
            // 
            comboStatus.FormattingEnabled = true;
            comboStatus.Location = new Point(315, 515);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(352, 33);
            comboStatus.TabIndex = 26;
            // 
            // numTemps
            // 
            numTemps.Location = new Point(315, 567);
            numTemps.Name = "numTemps";
            numTemps.Size = new Size(170, 31);
            numTemps.TabIndex = 27;
            // 
            // ModifierTache
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(710, 791);
            Controls.Add(numTemps);
            Controls.Add(comboStatus);
            Controls.Add(dtpFin);
            Controls.Add(dtpDebut);
            Controls.Add(txtDescription);
            Controls.Add(txtTitre);
            Controls.Add(comboTache);
            Controls.Add(cuiButton2);
            Controls.Add(btnModifier);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModifierTache";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModifierTache";
            Load += ModifierTache_Load;
            ((System.ComponentModel.ISupportInitialize)numTemps).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label8;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private CuoreUI.Controls.cuiButton btnModifier;
        private ComboBox comboTache;
        private TextBox txtTitre;
        private TextBox txtDescription;
        private DateTimePicker dtpDebut;
        private DateTimePicker dtpFin;
        private ComboBox comboStatus;
        private NumericUpDown numTemps;
    }
}
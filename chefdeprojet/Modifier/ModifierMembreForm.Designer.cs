namespace WindowsFormsApp1
{
    partial class ModifierMembreForm
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
            this.comboTaches = new System.Windows.Forms.ComboBox();
            this.comboMembres = new System.Windows.Forms.ComboBox();
            this.comboEquipes = new System.Windows.Forms.ComboBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.dateAffectation = new System.Windows.Forms.DateTimePicker();
            this.btnAnnuler = new CuoreUI.Controls.cuiButton();
            this.btnModifier = new CuoreUI.Controls.cuiButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboRole = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboTaches
            // 
            this.comboTaches.FormattingEnabled = true;
            this.comboTaches.Location = new System.Drawing.Point(323, 333);
            this.comboTaches.Name = "comboTaches";
            this.comboTaches.Size = new System.Drawing.Size(222, 28);
            this.comboTaches.TabIndex = 0;
            // 
            // comboMembres
            // 
            this.comboMembres.FormattingEnabled = true;
            this.comboMembres.Location = new System.Drawing.Point(323, 91);
            this.comboMembres.Name = "comboMembres";
            this.comboMembres.Size = new System.Drawing.Size(222, 28);
            this.comboMembres.TabIndex = 1;
            this.comboMembres.SelectedIndexChanged += new System.EventHandler(this.comboMembres_SelectedIndexChanged);
            // 
            // comboEquipes
            // 
            this.comboEquipes.FormattingEnabled = true;
            this.comboEquipes.Location = new System.Drawing.Point(323, 272);
            this.comboEquipes.Name = "comboEquipes";
            this.comboEquipes.Size = new System.Drawing.Size(222, 28);
            this.comboEquipes.TabIndex = 2;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(0, 0);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(100, 26);
            this.txtRole.TabIndex = 15;
            // 
            // dateAffectation
            // 
            this.dateAffectation.Location = new System.Drawing.Point(323, 487);
            this.dateAffectation.Name = "dateAffectation";
            this.dateAffectation.Size = new System.Drawing.Size(222, 26);
            this.dateAffectation.TabIndex = 4;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.CheckButton = false;
            this.btnAnnuler.Checked = false;
            this.btnAnnuler.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAnnuler.CheckedForeColor = System.Drawing.Color.White;
            this.btnAnnuler.CheckedImageTint = System.Drawing.Color.White;
            this.btnAnnuler.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAnnuler.Content = "Annuler";
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnAnnuler.HoveredImageTint = System.Drawing.Color.White;
            this.btnAnnuler.HoverForeColor = System.Drawing.Color.White;
            this.btnAnnuler.HoverOutline = System.Drawing.Color.Empty;
            this.btnAnnuler.Image = null;
            this.btnAnnuler.ImageAutoCenter = true;
            this.btnAnnuler.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnAnnuler.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAnnuler.Location = new System.Drawing.Point(223, 558);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnAnnuler.NormalForeColor = System.Drawing.Color.White;
            this.btnAnnuler.NormalImageTint = System.Drawing.Color.White;
            this.btnAnnuler.NormalOutline = System.Drawing.Color.Empty;
            this.btnAnnuler.OutlineThickness = 1.6F;
            this.btnAnnuler.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnAnnuler.PressedForeColor = System.Drawing.Color.White;
            this.btnAnnuler.PressedImageTint = System.Drawing.Color.White;
            this.btnAnnuler.PressedOutline = System.Drawing.Color.Empty;
            this.btnAnnuler.Rounding = new System.Windows.Forms.Padding(8);
            this.btnAnnuler.Size = new System.Drawing.Size(138, 42);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.TextOffset = new System.Drawing.Point(0, 0);
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click_1);
            // 
            // btnModifier
            // 
            this.btnModifier.CheckButton = false;
            this.btnModifier.Checked = false;
            this.btnModifier.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnModifier.CheckedForeColor = System.Drawing.Color.White;
            this.btnModifier.CheckedImageTint = System.Drawing.Color.White;
            this.btnModifier.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnModifier.Content = "Modifier";
            this.btnModifier.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(168)))), ((int)(((byte)(75)))));
            this.btnModifier.HoveredImageTint = System.Drawing.Color.White;
            this.btnModifier.HoverForeColor = System.Drawing.Color.White;
            this.btnModifier.HoverOutline = System.Drawing.Color.Empty;
            this.btnModifier.Image = null;
            this.btnModifier.ImageAutoCenter = true;
            this.btnModifier.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnModifier.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnModifier.Location = new System.Drawing.Point(385, 558);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(168)))), ((int)(((byte)(75)))));
            this.btnModifier.NormalForeColor = System.Drawing.Color.White;
            this.btnModifier.NormalImageTint = System.Drawing.Color.White;
            this.btnModifier.NormalOutline = System.Drawing.Color.Empty;
            this.btnModifier.OutlineThickness = 1.6F;
            this.btnModifier.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(168)))), ((int)(((byte)(75)))));
            this.btnModifier.PressedForeColor = System.Drawing.Color.White;
            this.btnModifier.PressedImageTint = System.Drawing.Color.White;
            this.btnModifier.PressedOutline = System.Drawing.Color.Empty;
            this.btnModifier.Rounding = new System.Windows.Forms.Padding(8);
            this.btnModifier.Size = new System.Drawing.Size(142, 45);
            this.btnModifier.TabIndex = 6;
            this.btnModifier.TextOffset = new System.Drawing.Point(0, 0);
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Membres :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Equipes :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Taches :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Role :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date Affectation :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Edit Member Info :";
            // 
            // comboRole
            // 
            this.comboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRole.FormattingEnabled = true;
            this.comboRole.Items.AddRange(new object[] {
            "Chef d\'équipe",
            "Membre"});
            this.comboRole.Location = new System.Drawing.Point(323, 407);
            this.comboRole.Name = "comboRole";
            this.comboRole.Size = new System.Drawing.Size(222, 28);
            this.comboRole.TabIndex = 14;
            this.comboRole.SelectedIndexChanged += new System.EventHandler(this.comboRole_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nom :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 28);
            this.label8.TabIndex = 17;
            this.label8.Text = "Email :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(323, 151);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(222, 26);
            this.txtNom.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(323, 211);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(222, 26);
            this.txtEmail.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 44);
            this.panel1.TabIndex = 22;
            // 
            // ModifierMembreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 631);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboRole);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.dateAffectation);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.comboEquipes);
            this.Controls.Add(this.comboMembres);
            this.Controls.Add(this.comboTaches);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifierMembreForm";
            this.Text = "ModifierMembreForm";
            this.Load += new System.EventHandler(this.ModifierMembreForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTaches;
        private System.Windows.Forms.ComboBox comboMembres;
        private System.Windows.Forms.ComboBox comboEquipes;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.DateTimePicker dateAffectation;
        private CuoreUI.Controls.cuiButton btnAnnuler;
        private CuoreUI.Controls.cuiButton btnModifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboRole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel1;
    }
}
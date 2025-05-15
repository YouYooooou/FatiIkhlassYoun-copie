namespace WindowsFormsApp1
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
            this.text_box1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dateDebutPicker = new System.Windows.Forms.DateTimePicker();
            this.dateFinPicker = new System.Windows.Forms.DateTimePicker();
            this.comboStatut = new System.Windows.Forms.ComboBox();
            this.numericEstimatedTime = new System.Windows.Forms.NumericUpDown();
            this.btnAnnuler = new CuoreUI.Controls.cuiButton();
            this.btnModifier = new CuoreUI.Controls.cuiButton();
            this.label7 = new System.Windows.Forms.Label();
            this.comboTacheAModifier = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericEstimatedTime)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_box1
            // 
            this.text_box1.AutoSize = true;
            this.text_box1.BackColor = System.Drawing.Color.White;
            this.text_box1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_box1.Location = new System.Drawing.Point(15, 195);
            this.text_box1.Name = "text_box1";
            this.text_box1.Size = new System.Drawing.Size(178, 28);
            this.text_box1.TabIndex = 21;
            this.text_box1.Text = "Titre de la tache :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 28);
            this.label3.TabIndex = 23;
            this.label3.Text = "Date de début :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 532);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 28);
            this.label4.TabIndex = 24;
            this.label4.Text = "Date de fin :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 604);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 28);
            this.label5.TabIndex = 25;
            this.label5.Text = "Statut :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 671);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 28);
            this.label6.TabIndex = 26;
            this.label6.Text = "Temps estimé :";
            // 
            // txtTitre
            // 
            this.txtTitre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitre.Location = new System.Drawing.Point(270, 189);
            this.txtTitre.MaxLength = 20;
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(303, 34);
            this.txtTitre.TabIndex = 27;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(270, 276);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(303, 158);
            this.txtDescription.TabIndex = 28;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // dateDebutPicker
            // 
            this.dateDebutPicker.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDebutPicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDebutPicker.Location = new System.Drawing.Point(270, 470);
            this.dateDebutPicker.Name = "dateDebutPicker";
            this.dateDebutPicker.Size = new System.Drawing.Size(303, 31);
            this.dateDebutPicker.TabIndex = 29;
            this.dateDebutPicker.Value = new System.DateTime(2025, 4, 20, 13, 58, 0, 0);
            // 
            // dateFinPicker
            // 
            this.dateFinPicker.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFinPicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFinPicker.Location = new System.Drawing.Point(270, 529);
            this.dateFinPicker.Name = "dateFinPicker";
            this.dateFinPicker.Size = new System.Drawing.Size(303, 31);
            this.dateFinPicker.TabIndex = 30;
            this.dateFinPicker.Value = new System.DateTime(2025, 4, 20, 13, 58, 0, 0);
            // 
            // comboStatut
            // 
            this.comboStatut.DropDownWidth = 372;
            this.comboStatut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStatut.FormattingEnabled = true;
            this.comboStatut.Location = new System.Drawing.Point(270, 596);
            this.comboStatut.Name = "comboStatut";
            this.comboStatut.Size = new System.Drawing.Size(303, 36);
            this.comboStatut.TabIndex = 31;
            // 
            // numericEstimatedTime
            // 
            this.numericEstimatedTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericEstimatedTime.Location = new System.Drawing.Point(270, 668);
            this.numericEstimatedTime.Name = "numericEstimatedTime";
            this.numericEstimatedTime.Size = new System.Drawing.Size(127, 31);
            this.numericEstimatedTime.TabIndex = 32;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.CheckButton = false;
            this.btnAnnuler.Checked = false;
            this.btnAnnuler.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnAnnuler.CheckedForeColor = System.Drawing.Color.White;
            this.btnAnnuler.CheckedImageTint = System.Drawing.Color.White;
            this.btnAnnuler.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnAnnuler.Content = "Annuler";
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnAnnuler.HoveredImageTint = System.Drawing.Color.White;
            this.btnAnnuler.HoverForeColor = System.Drawing.Color.White;
            this.btnAnnuler.HoverOutline = System.Drawing.Color.Empty;
            this.btnAnnuler.Image = null;
            this.btnAnnuler.ImageAutoCenter = true;
            this.btnAnnuler.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnAnnuler.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAnnuler.Location = new System.Drawing.Point(270, 722);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnAnnuler.NormalForeColor = System.Drawing.Color.White;
            this.btnAnnuler.NormalImageTint = System.Drawing.Color.White;
            this.btnAnnuler.NormalOutline = System.Drawing.Color.Empty;
            this.btnAnnuler.OutlineThickness = 1.6F;
            this.btnAnnuler.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnAnnuler.PressedForeColor = System.Drawing.Color.White;
            this.btnAnnuler.PressedImageTint = System.Drawing.Color.White;
            this.btnAnnuler.PressedOutline = System.Drawing.Color.Empty;
            this.btnAnnuler.Rounding = new System.Windows.Forms.Padding(8);
            this.btnAnnuler.Size = new System.Drawing.Size(127, 51);
            this.btnAnnuler.TabIndex = 33;
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
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnModifier.HoveredImageTint = System.Drawing.Color.White;
            this.btnModifier.HoverForeColor = System.Drawing.Color.White;
            this.btnModifier.HoverOutline = System.Drawing.Color.Empty;
            this.btnModifier.Image = null;
            this.btnModifier.ImageAutoCenter = true;
            this.btnModifier.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnModifier.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnModifier.Location = new System.Drawing.Point(421, 722);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnModifier.NormalForeColor = System.Drawing.Color.White;
            this.btnModifier.NormalImageTint = System.Drawing.Color.White;
            this.btnModifier.NormalOutline = System.Drawing.Color.Empty;
            this.btnModifier.OutlineThickness = 1.6F;
            this.btnModifier.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(168)))), ((int)(((byte)(75)))));
            this.btnModifier.PressedForeColor = System.Drawing.Color.White;
            this.btnModifier.PressedImageTint = System.Drawing.Color.White;
            this.btnModifier.PressedOutline = System.Drawing.Color.Empty;
            this.btnModifier.Rounding = new System.Windows.Forms.Padding(8);
            this.btnModifier.Size = new System.Drawing.Size(125, 51);
            this.btnModifier.TabIndex = 34;
            this.btnModifier.TextOffset = new System.Drawing.Point(0, 0);
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 28);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tache à modifier :";
            // 
            // comboTacheAModifier
            // 
            this.comboTacheAModifier.DropDownWidth = 372;
            this.comboTacheAModifier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTacheAModifier.FormattingEnabled = true;
            this.comboTacheAModifier.Location = new System.Drawing.Point(270, 113);
            this.comboTacheAModifier.Name = "comboTacheAModifier";
            this.comboTacheAModifier.Size = new System.Drawing.Size(303, 36);
            this.comboTacheAModifier.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 44);
            this.panel1.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 28);
            this.label8.TabIndex = 12;
            this.label8.Text = "Edit Task Info :";
            // 
            // ModifierTache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 802);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboTacheAModifier);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.numericEstimatedTime);
            this.Controls.Add(this.comboStatut);
            this.Controls.Add(this.dateFinPicker);
            this.Controls.Add(this.dateDebutPicker);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_box1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifierTache";
            this.Text = "ModifierTache";
            this.Load += new System.EventHandler(this.ModifierTache_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericEstimatedTime)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label text_box1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dateDebutPicker;
        private System.Windows.Forms.DateTimePicker dateFinPicker;
        private System.Windows.Forms.ComboBox comboStatut;
        private System.Windows.Forms.NumericUpDown numericEstimatedTime;
        private CuoreUI.Controls.cuiButton btnAnnuler;
        private CuoreUI.Controls.cuiButton btnModifier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboTacheAModifier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}
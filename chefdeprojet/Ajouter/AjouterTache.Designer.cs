namespace WindowsFormsApp1
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
            this.text_box1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateDebutPicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateFinPicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.comboStatut = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericEstimatedTime = new System.Windows.Forms.NumericUpDown();
            this.cuiButton2 = new CuoreUI.Controls.cuiButton();
            this.btnAjouter = new CuoreUI.Controls.cuiButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboEquipe = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericEstimatedTime)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_box1
            // 
            this.text_box1.AutoSize = true;
            this.text_box1.BackColor = System.Drawing.Color.White;
            this.text_box1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_box1.Location = new System.Drawing.Point(28, 89);
            this.text_box1.Name = "text_box1";
            this.text_box1.Size = new System.Drawing.Size(154, 28);
            this.text_box1.TabIndex = 20;
            this.text_box1.Text = "ID de la tache :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 149);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(87, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Equipe :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Description :";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(315, 276);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(303, 158);
            this.txtDescription.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Date de début :";
            // 
            // dateDebutPicker
            // 
            this.dateDebutPicker.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDebutPicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDebutPicker.Location = new System.Drawing.Point(315, 458);
            this.dateDebutPicker.Name = "dateDebutPicker";
            this.dateDebutPicker.Size = new System.Drawing.Size(303, 31);
            this.dateDebutPicker.TabIndex = 10;
            this.dateDebutPicker.Value = new System.DateTime(2025, 4, 20, 13, 58, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 511);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 28);
            this.label7.TabIndex = 11;
            this.label7.Text = "Date limite :";
            // 
            // dateFinPicker
            // 
            this.dateFinPicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFinPicker.Location = new System.Drawing.Point(315, 508);
            this.dateFinPicker.Name = "dateFinPicker";
            this.dateFinPicker.Size = new System.Drawing.Size(303, 31);
            this.dateFinPicker.TabIndex = 12;
            this.dateFinPicker.Value = new System.DateTime(2025, 4, 20, 13, 58, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 572);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 28);
            this.label8.TabIndex = 13;
            this.label8.Text = "Statut :";
            // 
            // comboStatut
            // 
            this.comboStatut.DropDownWidth = 372;
            this.comboStatut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStatut.FormattingEnabled = true;
            this.comboStatut.Location = new System.Drawing.Point(315, 564);
            this.comboStatut.Name = "comboStatut";
            this.comboStatut.Size = new System.Drawing.Size(303, 36);
            this.comboStatut.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 626);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 28);
            this.label9.TabIndex = 15;
            this.label9.Text = "Temps estimé (h)  :";
            // 
            // numericEstimatedTime
            // 
            this.numericEstimatedTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericEstimatedTime.Location = new System.Drawing.Point(315, 626);
            this.numericEstimatedTime.Name = "numericEstimatedTime";
            this.numericEstimatedTime.Size = new System.Drawing.Size(127, 31);
            this.numericEstimatedTime.TabIndex = 16;
            // 
            // cuiButton2
            // 
            this.cuiButton2.CheckButton = false;
            this.cuiButton2.Checked = false;
            this.cuiButton2.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.cuiButton2.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton2.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton2.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.cuiButton2.Content = "Annuler";
            this.cuiButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiButton2.ForeColor = System.Drawing.Color.White;
            this.cuiButton2.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.cuiButton2.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton2.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton2.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton2.Image = null;
            this.cuiButton2.ImageAutoCenter = true;
            this.cuiButton2.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton2.Location = new System.Drawing.Point(343, 677);
            this.cuiButton2.Name = "cuiButton2";
            this.cuiButton2.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.cuiButton2.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton2.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton2.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton2.OutlineThickness = 1.6F;
            this.cuiButton2.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.cuiButton2.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton2.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton2.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton2.Size = new System.Drawing.Size(120, 40);
            this.cuiButton2.TabIndex = 18;
            this.cuiButton2.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton2.Click += new System.EventHandler(this.cuiButton2_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.CheckButton = false;
            this.btnAjouter.Checked = false;
            this.btnAjouter.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAjouter.CheckedForeColor = System.Drawing.Color.White;
            this.btnAjouter.CheckedImageTint = System.Drawing.Color.White;
            this.btnAjouter.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAjouter.Content = "Ajouter";
            this.btnAjouter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnAjouter.HoveredImageTint = System.Drawing.Color.White;
            this.btnAjouter.HoverForeColor = System.Drawing.Color.White;
            this.btnAjouter.HoverOutline = System.Drawing.Color.Empty;
            this.btnAjouter.Image = null;
            this.btnAjouter.ImageAutoCenter = true;
            this.btnAjouter.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnAjouter.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAjouter.Location = new System.Drawing.Point(498, 677);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAjouter.NormalForeColor = System.Drawing.Color.White;
            this.btnAjouter.NormalImageTint = System.Drawing.Color.White;
            this.btnAjouter.NormalOutline = System.Drawing.Color.Empty;
            this.btnAjouter.OutlineThickness = 1.6F;
            this.btnAjouter.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(168)))), ((int)(((byte)(75)))));
            this.btnAjouter.PressedForeColor = System.Drawing.Color.White;
            this.btnAjouter.PressedImageTint = System.Drawing.Color.White;
            this.btnAjouter.PressedOutline = System.Drawing.Color.Empty;
            this.btnAjouter.Rounding = new System.Windows.Forms.Padding(8);
            this.btnAjouter.Size = new System.Drawing.Size(120, 40);
            this.btnAjouter.TabIndex = 17;
            this.btnAjouter.TextOffset = new System.Drawing.Point(0, 0);
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(315, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(303, 31);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboEquipe
            // 
            this.comboEquipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEquipe.DropDownWidth = 372;
            this.comboEquipe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEquipe.FormattingEnabled = true;
            this.comboEquipe.Location = new System.Drawing.Point(315, 141);
            this.comboEquipe.Name = "comboEquipe";
            this.comboEquipe.Size = new System.Drawing.Size(303, 36);
            this.comboEquipe.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 218);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(178, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Titre de la tâche :";
            // 
            // txtTitre
            // 
            this.txtTitre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitre.Location = new System.Drawing.Point(315, 212);
            this.txtTitre.MaxLength = 20;
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(303, 34);
            this.txtTitre.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 44);
            this.panel1.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Add Task :";
            // 
            // AjouterTache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 752);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboEquipe);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cuiButton2);
            this.Controls.Add(this.numericEstimatedTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboStatut);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateFinPicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateDebutPicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_box1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AjouterTache";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter une tache";
            this.Load += new System.EventHandler(this.AjouterTache_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericEstimatedTime)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label text_box1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateDebutPicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateFinPicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboStatut;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericEstimatedTime;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private CuoreUI.Controls.cuiButton btnAjouter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboEquipe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
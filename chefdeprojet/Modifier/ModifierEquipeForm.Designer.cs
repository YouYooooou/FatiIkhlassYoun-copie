namespace WindowsFormsApp1
{
    partial class ModifierEquipeForm
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
            this.comboEquipes = new System.Windows.Forms.ComboBox();
            this.comboChefEquipe = new System.Windows.Forms.ComboBox();
            this.checkedMembres = new System.Windows.Forms.CheckedListBox();
            this.checkedTaches = new System.Windows.Forms.CheckedListBox();
            this.btnAnnuler = new CuoreUI.Controls.cuiButton();
            this.btnModifier = new CuoreUI.Controls.cuiButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomEquipe = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboEquipes
            // 
            this.comboEquipes.FormattingEnabled = true;
            this.comboEquipes.Location = new System.Drawing.Point(318, 88);
            this.comboEquipes.Name = "comboEquipes";
            this.comboEquipes.Size = new System.Drawing.Size(201, 28);
            this.comboEquipes.TabIndex = 0;
            // 
            // comboChefEquipe
            // 
            this.comboChefEquipe.FormattingEnabled = true;
            this.comboChefEquipe.Location = new System.Drawing.Point(317, 229);
            this.comboChefEquipe.Name = "comboChefEquipe";
            this.comboChefEquipe.Size = new System.Drawing.Size(202, 28);
            this.comboChefEquipe.TabIndex = 1;
            // 
            // checkedMembres
            // 
            this.checkedMembres.FormattingEnabled = true;
            this.checkedMembres.Location = new System.Drawing.Point(317, 297);
            this.checkedMembres.Name = "checkedMembres";
            this.checkedMembres.Size = new System.Drawing.Size(201, 96);
            this.checkedMembres.TabIndex = 2;
            // 
            // checkedTaches
            // 
            this.checkedTaches.FormattingEnabled = true;
            this.checkedTaches.Location = new System.Drawing.Point(317, 424);
            this.checkedTaches.Name = "checkedTaches";
            this.checkedTaches.Size = new System.Drawing.Size(201, 96);
            this.checkedTaches.TabIndex = 3;
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
            this.btnAnnuler.Location = new System.Drawing.Point(196, 565);
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
            this.btnAnnuler.Size = new System.Drawing.Size(153, 45);
            this.btnAnnuler.TabIndex = 4;
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
            this.btnModifier.Location = new System.Drawing.Point(376, 565);
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
            this.btnModifier.Size = new System.Drawing.Size(153, 45);
            this.btnModifier.TabIndex = 5;
            this.btnModifier.TextOffset = new System.Drawing.Point(0, 0);
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Equipes :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Chef Equipe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Membres :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Taches :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nouveau Nom :";
            // 
            // txtNomEquipe
            // 
            this.txtNomEquipe.Location = new System.Drawing.Point(318, 150);
            this.txtNomEquipe.Name = "txtNomEquipe";
            this.txtNomEquipe.Size = new System.Drawing.Size(201, 26);
            this.txtNomEquipe.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 44);
            this.panel1.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "Edit Team Info :";
            // 
            // ModifierEquipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(585, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNomEquipe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.checkedTaches);
            this.Controls.Add(this.checkedMembres);
            this.Controls.Add(this.comboChefEquipe);
            this.Controls.Add(this.comboEquipes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifierEquipeForm";
            this.Text = "ModifierEquipeForm";
            this.Load += new System.EventHandler(this.ModifierEquipeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboEquipes;
        private System.Windows.Forms.ComboBox comboChefEquipe;
        private System.Windows.Forms.CheckedListBox checkedMembres;
        private System.Windows.Forms.CheckedListBox checkedTaches;
        private CuoreUI.Controls.cuiButton btnAnnuler;
        private CuoreUI.Controls.cuiButton btnModifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomEquipe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
    }
}
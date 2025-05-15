namespace WindowsFormsApp1
{
    partial class SupprimerEquipe
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
            this.txtNomEquipe = new System.Windows.Forms.TextBox();
            this.txtChefEquipe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSupprimer = new CuoreUI.Controls.cuiButton();
            this.btnAnnuler = new CuoreUI.Controls.cuiButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboEquipes
            // 
            this.comboEquipes.FormattingEnabled = true;
            this.comboEquipes.Location = new System.Drawing.Point(387, 78);
            this.comboEquipes.Name = "comboEquipes";
            this.comboEquipes.Size = new System.Drawing.Size(261, 28);
            this.comboEquipes.TabIndex = 2;
            this.comboEquipes.SelectedIndexChanged += new System.EventHandler(this.comboEquipes_SelectedIndexChanged);
            // 
            // txtNomEquipe
            // 
            this.txtNomEquipe.Location = new System.Drawing.Point(387, 147);
            this.txtNomEquipe.Name = "txtNomEquipe";
            this.txtNomEquipe.Size = new System.Drawing.Size(261, 26);
            this.txtNomEquipe.TabIndex = 3;
            this.txtNomEquipe.TextChanged += new System.EventHandler(this.txtNomEquipe_TextChanged);
            // 
            // txtChefEquipe
            // 
            this.txtChefEquipe.Location = new System.Drawing.Point(387, 219);
            this.txtChefEquipe.Name = "txtChefEquipe";
            this.txtChefEquipe.Size = new System.Drawing.Size(261, 26);
            this.txtChefEquipe.TabIndex = 4;
            this.txtChefEquipe.TextChanged += new System.EventHandler(this.txtChefEquipe_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Equipes :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nom de l\'équipe :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chef d\'équipe :";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.CheckButton = false;
            this.btnSupprimer.Checked = false;
            this.btnSupprimer.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSupprimer.CheckedForeColor = System.Drawing.Color.White;
            this.btnSupprimer.CheckedImageTint = System.Drawing.Color.White;
            this.btnSupprimer.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSupprimer.Content = "Supprimer";
            this.btnSupprimer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSupprimer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnSupprimer.HoveredImageTint = System.Drawing.Color.White;
            this.btnSupprimer.HoverForeColor = System.Drawing.Color.White;
            this.btnSupprimer.HoverOutline = System.Drawing.Color.Empty;
            this.btnSupprimer.Image = null;
            this.btnSupprimer.ImageAutoCenter = true;
            this.btnSupprimer.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnSupprimer.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSupprimer.Location = new System.Drawing.Point(487, 332);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSupprimer.NormalForeColor = System.Drawing.Color.White;
            this.btnSupprimer.NormalImageTint = System.Drawing.Color.White;
            this.btnSupprimer.NormalOutline = System.Drawing.Color.Empty;
            this.btnSupprimer.OutlineThickness = 1.6F;
            this.btnSupprimer.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(168)))), ((int)(((byte)(75)))));
            this.btnSupprimer.PressedForeColor = System.Drawing.Color.White;
            this.btnSupprimer.PressedImageTint = System.Drawing.Color.White;
            this.btnSupprimer.PressedOutline = System.Drawing.Color.Empty;
            this.btnSupprimer.Rounding = new System.Windows.Forms.Padding(8);
            this.btnSupprimer.Size = new System.Drawing.Size(142, 40);
            this.btnSupprimer.TabIndex = 19;
            this.btnSupprimer.TextOffset = new System.Drawing.Point(0, 0);
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
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
            this.btnAnnuler.Location = new System.Drawing.Point(313, 332);
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
            this.btnAnnuler.Size = new System.Drawing.Size(128, 40);
            this.btnAnnuler.TabIndex = 20;
            this.btnAnnuler.TextOffset = new System.Drawing.Point(0, 0);
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 44);
            this.panel1.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 28);
            this.label8.TabIndex = 12;
            this.label8.Text = "Delete Team :";
            // 
            // SupprimerEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 401);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChefEquipe);
            this.Controls.Add(this.txtNomEquipe);
            this.Controls.Add(this.comboEquipes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupprimerEquipe";
            this.Text = "SupprimerEquipe";
            this.Load += new System.EventHandler(this.SupprimerEquipe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboEquipes;
        private System.Windows.Forms.TextBox txtNomEquipe;
        private System.Windows.Forms.TextBox txtChefEquipe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CuoreUI.Controls.cuiButton btnSupprimer;
        private CuoreUI.Controls.cuiButton btnAnnuler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}
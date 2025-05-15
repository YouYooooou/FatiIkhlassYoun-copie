namespace WindowsFormsApp1
{
    partial class SupprimerMembre
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboUtilisateurs = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSupprimer = new CuoreUI.Controls.cuiButton();
            this.btnAnnuler = new CuoreUI.Controls.cuiButton();
            this.txtEquipe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Membre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email :";
            // 
            // comboUtilisateurs
            // 
            this.comboUtilisateurs.FormattingEnabled = true;
            this.comboUtilisateurs.Location = new System.Drawing.Point(360, 78);
            this.comboUtilisateurs.Name = "comboUtilisateurs";
            this.comboUtilisateurs.Size = new System.Drawing.Size(276, 28);
            this.comboUtilisateurs.TabIndex = 4;
            this.comboUtilisateurs.SelectedIndexChanged += new System.EventHandler(this.comboUtilisateurs_SelectedIndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(360, 154);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(276, 26);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtNouvelleEquipe_TextChanged);
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
            this.btnSupprimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnSupprimer.HoveredImageTint = System.Drawing.Color.White;
            this.btnSupprimer.HoverForeColor = System.Drawing.Color.White;
            this.btnSupprimer.HoverOutline = System.Drawing.Color.Empty;
            this.btnSupprimer.Image = null;
            this.btnSupprimer.ImageAutoCenter = true;
            this.btnSupprimer.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnSupprimer.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSupprimer.Location = new System.Drawing.Point(471, 330);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnSupprimer.NormalForeColor = System.Drawing.Color.White;
            this.btnSupprimer.NormalImageTint = System.Drawing.Color.White;
            this.btnSupprimer.NormalOutline = System.Drawing.Color.Empty;
            this.btnSupprimer.OutlineThickness = 1.6F;
            this.btnSupprimer.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnSupprimer.PressedForeColor = System.Drawing.Color.White;
            this.btnSupprimer.PressedImageTint = System.Drawing.Color.White;
            this.btnSupprimer.PressedOutline = System.Drawing.Color.Empty;
            this.btnSupprimer.Rounding = new System.Windows.Forms.Padding(8);
            this.btnSupprimer.Size = new System.Drawing.Size(153, 45);
            this.btnSupprimer.TabIndex = 12;
            this.btnSupprimer.TextOffset = new System.Drawing.Point(0, 0);
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
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
            this.btnAnnuler.Location = new System.Drawing.Point(285, 330);
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
            this.btnAnnuler.Size = new System.Drawing.Size(143, 45);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.TextOffset = new System.Drawing.Point(0, 0);
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // txtEquipe
            // 
            this.txtEquipe.Location = new System.Drawing.Point(360, 231);
            this.txtEquipe.Name = "txtEquipe";
            this.txtEquipe.Size = new System.Drawing.Size(276, 26);
            this.txtEquipe.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "Equipe :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 44);
            this.panel1.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 28);
            this.label8.TabIndex = 12;
            this.label8.Text = "Delete Member";
            // 
            // SupprimerMembre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 407);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEquipe);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.comboUtilisateurs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupprimerMembre";
            this.Text = "SupprimerMembre";
            this.Load += new System.EventHandler(this.SupprimerMembre_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboUtilisateurs;
        private System.Windows.Forms.TextBox txtEmail;
        private CuoreUI.Controls.cuiButton btnSupprimer;
        private CuoreUI.Controls.cuiButton btnAnnuler;
        private System.Windows.Forms.TextBox txtEquipe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}
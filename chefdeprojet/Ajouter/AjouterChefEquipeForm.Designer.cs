namespace WindowsFormsApp1
{
    partial class AjouterChefEquipeForm
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
            this.comboMembre = new System.Windows.Forms.ComboBox();
            this.comboEquipeExistante = new System.Windows.Forms.ComboBox();
            this.radioEquipeExistante = new System.Windows.Forms.RadioButton();
            this.txtNouvelleEquipe = new System.Windows.Forms.TextBox();
            this.radioNouvelleEquipe = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAjouterChefEquipe = new CuoreUI.Controls.cuiButton();
            this.btnAnnuler = new CuoreUI.Controls.cuiButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboMembre
            // 
            this.comboMembre.FormattingEnabled = true;
            this.comboMembre.Location = new System.Drawing.Point(317, 78);
            this.comboMembre.Name = "comboMembre";
            this.comboMembre.Size = new System.Drawing.Size(276, 28);
            this.comboMembre.TabIndex = 0;
            this.comboMembre.SelectedIndexChanged += new System.EventHandler(this.comboMembre_SelectedIndexChanged);
            // 
            // comboEquipeExistante
            // 
            this.comboEquipeExistante.FormattingEnabled = true;
            this.comboEquipeExistante.Location = new System.Drawing.Point(317, 256);
            this.comboEquipeExistante.Name = "comboEquipeExistante";
            this.comboEquipeExistante.Size = new System.Drawing.Size(276, 28);
            this.comboEquipeExistante.TabIndex = 1;
            this.comboEquipeExistante.SelectedIndexChanged += new System.EventHandler(this.comboEquipeExistante_SelectedIndexChanged);
            // 
            // radioEquipeExistante
            // 
            this.radioEquipeExistante.AutoSize = true;
            this.radioEquipeExistante.Location = new System.Drawing.Point(484, 125);
            this.radioEquipeExistante.Name = "radioEquipeExistante";
            this.radioEquipeExistante.Size = new System.Drawing.Size(150, 24);
            this.radioEquipeExistante.TabIndex = 3;
            this.radioEquipeExistante.TabStop = true;
            this.radioEquipeExistante.Text = "équipe existante";
            this.radioEquipeExistante.UseVisualStyleBackColor = true;
            // 
            // txtNouvelleEquipe
            // 
            this.txtNouvelleEquipe.Location = new System.Drawing.Point(317, 182);
            this.txtNouvelleEquipe.Name = "txtNouvelleEquipe";
            this.txtNouvelleEquipe.Size = new System.Drawing.Size(276, 26);
            this.txtNouvelleEquipe.TabIndex = 4;
            // 
            // radioNouvelleEquipe
            // 
            this.radioNouvelleEquipe.AutoSize = true;
            this.radioNouvelleEquipe.Location = new System.Drawing.Point(317, 125);
            this.radioNouvelleEquipe.Name = "radioNouvelleEquipe";
            this.radioNouvelleEquipe.Size = new System.Drawing.Size(146, 24);
            this.radioNouvelleEquipe.TabIndex = 7;
            this.radioNouvelleEquipe.TabStop = true;
            this.radioNouvelleEquipe.Text = "Nouvelle équipe";
            this.radioNouvelleEquipe.UseVisualStyleBackColor = true;
            this.radioNouvelleEquipe.CheckedChanged += new System.EventHandler(this.radioNouvelleEquipe_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Membres :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nouvelle équipe :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Equipe existante :";
            // 
            // btnAjouterChefEquipe
            // 
            this.btnAjouterChefEquipe.CheckButton = false;
            this.btnAjouterChefEquipe.Checked = false;
            this.btnAjouterChefEquipe.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAjouterChefEquipe.CheckedForeColor = System.Drawing.Color.White;
            this.btnAjouterChefEquipe.CheckedImageTint = System.Drawing.Color.White;
            this.btnAjouterChefEquipe.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAjouterChefEquipe.Content = "Ajouter";
            this.btnAjouterChefEquipe.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAjouterChefEquipe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterChefEquipe.ForeColor = System.Drawing.Color.White;
            this.btnAjouterChefEquipe.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnAjouterChefEquipe.HoveredImageTint = System.Drawing.Color.White;
            this.btnAjouterChefEquipe.HoverForeColor = System.Drawing.Color.White;
            this.btnAjouterChefEquipe.HoverOutline = System.Drawing.Color.Empty;
            this.btnAjouterChefEquipe.Image = null;
            this.btnAjouterChefEquipe.ImageAutoCenter = true;
            this.btnAjouterChefEquipe.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnAjouterChefEquipe.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAjouterChefEquipe.Location = new System.Drawing.Point(504, 363);
            this.btnAjouterChefEquipe.Name = "btnAjouterChefEquipe";
            this.btnAjouterChefEquipe.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnAjouterChefEquipe.NormalForeColor = System.Drawing.Color.White;
            this.btnAjouterChefEquipe.NormalImageTint = System.Drawing.Color.White;
            this.btnAjouterChefEquipe.NormalOutline = System.Drawing.Color.Empty;
            this.btnAjouterChefEquipe.OutlineThickness = 1.6F;
            this.btnAjouterChefEquipe.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnAjouterChefEquipe.PressedForeColor = System.Drawing.Color.White;
            this.btnAjouterChefEquipe.PressedImageTint = System.Drawing.Color.White;
            this.btnAjouterChefEquipe.PressedOutline = System.Drawing.Color.Empty;
            this.btnAjouterChefEquipe.Rounding = new System.Windows.Forms.Padding(8);
            this.btnAjouterChefEquipe.Size = new System.Drawing.Size(153, 45);
            this.btnAjouterChefEquipe.TabIndex = 11;
            this.btnAjouterChefEquipe.TextOffset = new System.Drawing.Point(0, 0);
            this.btnAjouterChefEquipe.Click += new System.EventHandler(this.btnAjouterChefEquipe_Click);
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
            this.btnAnnuler.Location = new System.Drawing.Point(317, 363);
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
            this.btnAnnuler.TabIndex = 12;
            this.btnAnnuler.TextOffset = new System.Drawing.Point(0, 0);
            this.btnAnnuler.Click += new System.EventHandler(this.cuiButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 44);
            this.panel1.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Add Team Leader :";
            // 
            // AjouterChefEquipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(743, 449);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouterChefEquipe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioNouvelleEquipe);
            this.Controls.Add(this.txtNouvelleEquipe);
            this.Controls.Add(this.radioEquipeExistante);
            this.Controls.Add(this.comboEquipeExistante);
            this.Controls.Add(this.comboMembre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjouterChefEquipeForm";
            this.Text = "AjouterChefEquipeForm";
            this.Load += new System.EventHandler(this.AjouterChefEquipeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboMembre;
        private System.Windows.Forms.ComboBox comboEquipeExistante;
        private System.Windows.Forms.RadioButton radioEquipeExistante;
        private System.Windows.Forms.TextBox txtNouvelleEquipe;
        private System.Windows.Forms.RadioButton radioNouvelleEquipe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CuoreUI.Controls.cuiButton btnAjouterChefEquipe;
        private CuoreUI.Controls.cuiButton btnAnnuler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}
namespace FatiIkhlassYoun.NewFolder
{
    partial class SupprimerTache
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
            txtDescription = new TextBox();
            txtTitre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnAnnuler = new CuoreUI.Controls.cuiButton();
            btnSupprimer = new CuoreUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 22);
            label1.Name = "label1";
            label1.Size = new Size(216, 45);
            label1.TabIndex = 4;
            label1.Text = "Deleat a Task";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(343, 253);
            txtDescription.MaxLength = 200;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(352, 141);
            txtDescription.TabIndex = 29;
            // 
            // txtTitre
            // 
            txtTitre.Location = new Point(343, 176);
            txtTitre.MaxLength = 20;
            txtTitre.Name = "txtTitre";
            txtTitre.ReadOnly = true;
            txtTitre.Size = new Size(352, 31);
            txtTitre.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 253);
            label4.Name = "label4";
            label4.Size = new Size(138, 28);
            label4.TabIndex = 26;
            label4.Text = "Description : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 179);
            label3.Name = "label3";
            label3.Size = new Size(167, 28);
            label3.TabIndex = 25;
            label3.Text = "Titre de la tâche";
            // 
            // btnAnnuler
            // 
            btnAnnuler.CheckButton = false;
            btnAnnuler.Checked = false;
            btnAnnuler.CheckedBackground = Color.FromArgb(200, 35, 51);
            btnAnnuler.CheckedForeColor = Color.White;
            btnAnnuler.CheckedImageTint = Color.White;
            btnAnnuler.CheckedOutline = Color.FromArgb(200, 35, 51);
            btnAnnuler.Content = "Annuler";
            btnAnnuler.DialogResult = DialogResult.None;
            btnAnnuler.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnnuler.ForeColor = Color.White;
            btnAnnuler.HoverBackground = Color.FromArgb(200, 35, 51);
            btnAnnuler.HoveredImageTint = Color.White;
            btnAnnuler.HoverForeColor = Color.White;
            btnAnnuler.HoverOutline = Color.Empty;
            btnAnnuler.Image = null;
            btnAnnuler.ImageAutoCenter = true;
            btnAnnuler.ImageExpand = new Point(0, 0);
            btnAnnuler.ImageOffset = new Point(0, 0);
            btnAnnuler.Location = new Point(232, 450);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.NormalBackground = Color.FromArgb(223, 53, 69);
            btnAnnuler.NormalForeColor = Color.White;
            btnAnnuler.NormalImageTint = Color.White;
            btnAnnuler.NormalOutline = Color.Empty;
            btnAnnuler.OutlineThickness = 1.6F;
            btnAnnuler.PressedBackground = Color.FromArgb(210, 35, 51);
            btnAnnuler.PressedForeColor = Color.White;
            btnAnnuler.PressedImageTint = Color.White;
            btnAnnuler.PressedOutline = Color.Empty;
            btnAnnuler.Rounding = new Padding(8);
            btnAnnuler.Size = new Size(206, 73);
            btnAnnuler.TabIndex = 31;
            btnAnnuler.TextOffset = new Point(0, 0);
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.CheckButton = false;
            btnSupprimer.Checked = false;
            btnSupprimer.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnSupprimer.CheckedForeColor = Color.White;
            btnSupprimer.CheckedImageTint = Color.White;
            btnSupprimer.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnSupprimer.Content = "Supprimer";
            btnSupprimer.DialogResult = DialogResult.None;
            btnSupprimer.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupprimer.ForeColor = Color.White;
            btnSupprimer.HoverBackground = Color.FromArgb(33, 136, 56);
            btnSupprimer.HoveredImageTint = Color.White;
            btnSupprimer.HoverForeColor = Color.White;
            btnSupprimer.HoverOutline = Color.Empty;
            btnSupprimer.Image = null;
            btnSupprimer.ImageAutoCenter = true;
            btnSupprimer.ImageExpand = new Point(0, 0);
            btnSupprimer.ImageOffset = new Point(0, 0);
            btnSupprimer.Location = new Point(489, 450);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.NormalBackground = Color.FromArgb(40, 167, 69);
            btnSupprimer.NormalForeColor = Color.White;
            btnSupprimer.NormalImageTint = Color.White;
            btnSupprimer.NormalOutline = Color.Empty;
            btnSupprimer.OutlineThickness = 1.6F;
            btnSupprimer.PressedBackground = Color.FromArgb(43, 168, 75);
            btnSupprimer.PressedForeColor = Color.White;
            btnSupprimer.PressedImageTint = Color.White;
            btnSupprimer.PressedOutline = Color.Empty;
            btnSupprimer.Rounding = new Padding(8);
            btnSupprimer.Size = new Size(206, 73);
            btnSupprimer.TabIndex = 30;
            btnSupprimer.TextOffset = new Point(0, 0);
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // SupprimerTache
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 562);
            Controls.Add(btnAnnuler);
            Controls.Add(btnSupprimer);
            Controls.Add(txtDescription);
            Controls.Add(txtTitre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SupprimerTache";
            Text = "SupprimerTache";
            Load += SupprimerTache_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDescription;
        private TextBox txtTitre;
        private Label label4;
        private Label label3;
        private CuoreUI.Controls.cuiButton btnAnnuler;
        private CuoreUI.Controls.cuiButton btnSupprimer;
    }
}
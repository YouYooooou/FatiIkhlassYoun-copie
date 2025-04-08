namespace FatiIkhlassYoun
{
    partial class formGestionDesEquipes
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
            panel1 = new Panel();
            btnAjouter = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(182, 797);
            panel1.TabIndex = 0;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(250, 181);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(148, 60);
            btnAjouter.TabIndex = 1;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(386, 181);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(136, 60);
            btnModifier.TabIndex = 1;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(515, 181);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(163, 60);
            btnSupprimer.TabIndex = 1;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(255, 34);
            label1.Name = "label1";
            label1.Size = new Size(437, 60);
            label1.TabIndex = 2;
            label1.Text = "Gestion des Equipes";
            label1.Click += label1_Click;
            // 
            // formGestionDesEquipes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 42, 56);
            ClientSize = new Size(1096, 797);
            Controls.Add(label1);
            Controls.Add(btnSupprimer);
            Controls.Add(panel1);
            Controls.Add(btnAjouter);
            Controls.Add(btnModifier);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formGestionDesEquipes";
            Text = "formGestionDesEquipes";
            Load += formGestionDesEquipes_Load;
            Click += btnAjouter_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnAjouter;
        private Button btnModifier;
        private Button btnSupprimer;
        private Label label1;
    }
}
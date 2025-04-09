namespace FatiIkhlassYoun
{
    partial class FormMotDePasseOublie
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
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnEnvoyer = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(172, 207);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(486, 31);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(172, 31);
            label1.Name = "label1";
            label1.Size = new Size(434, 48);
            label1.TabIndex = 1;
            label1.Text = "Problème de connexion?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(46, 144);
            label2.Name = "label2";
            label2.Size = new Size(704, 25);
            label2.TabIndex = 2;
            label2.Text = "Entrez votre adresse e-mail, et nous enverrons un lien pour récupérer votre compte";
            label2.Click += label2_Click;
            // 
            // btnEnvoyer
            // 
            btnEnvoyer.BackColor = Color.Brown;
            btnEnvoyer.ForeColor = Color.White;
            btnEnvoyer.Location = new Point(251, 265);
            btnEnvoyer.Name = "btnEnvoyer";
            btnEnvoyer.Size = new Size(307, 54);
            btnEnvoyer.TabIndex = 3;
            btnEnvoyer.Text = "Envoyez un lien de connexion";
            btnEnvoyer.UseVisualStyleBackColor = false;
            btnEnvoyer.Click += btnEnvoyer_Click;
            // 
            // FormMotDePasseOublie
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnvoyer);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Name = "FormMotDePasseOublie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMotDePasseOublie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private Button btnEnvoyer;
    }
}
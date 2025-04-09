namespace FatiIkhlassYoun
{
    partial class formAuthentification
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
            cuiBorder1 = new CuoreUI.Controls.cuiBorder();
            btnShowP = new CuoreUI.Controls.cuiCheckbox();
            txtPassword = new Label();
            txtUsername = new Label();
            lblMessage = new Label();
            btnValider = new Button();
            Authentification = new Label();
            textPass = new TextBox();
            textBox1 = new TextBox();
            cuiBorder1.SuspendLayout();
            SuspendLayout();
            // 
            // cuiBorder1
            // 
            cuiBorder1.Controls.Add(btnShowP);
            cuiBorder1.Controls.Add(txtPassword);
            cuiBorder1.Controls.Add(txtUsername);
            cuiBorder1.Controls.Add(lblMessage);
            cuiBorder1.Controls.Add(btnValider);
            cuiBorder1.Controls.Add(Authentification);
            cuiBorder1.Controls.Add(textPass);
            cuiBorder1.Controls.Add(textBox1);
            cuiBorder1.Location = new Point(182, 31);
            cuiBorder1.Name = "cuiBorder1";
            cuiBorder1.OutlineThickness = 1F;
            cuiBorder1.PanelColor = Color.WhiteSmoke;
            cuiBorder1.PanelOutlineColor = Color.WhiteSmoke;
            cuiBorder1.Rounding = new Padding(8);
            cuiBorder1.Size = new Size(594, 443);
            cuiBorder1.TabIndex = 0;
            cuiBorder1.Paint += cuiBorder1_Paint_1;
            // 
            // btnShowP
            // 
            btnShowP.Checked = false;
            btnShowP.CheckedForeground = Color.White;
            btnShowP.CheckedOutlineColor = Color.White;
            btnShowP.CheckedSymbolColor = Color.White;
            btnShowP.Content = "Show Password";
            btnShowP.ForeColor = Color.Black;
            btnShowP.Location = new Point(390, 271);
            btnShowP.MinimumSize = new Size(16, 16);
            btnShowP.Name = "btnShowP";
            btnShowP.OutlineStyle = true;
            btnShowP.OutlineThickness = 1F;
            btnShowP.Rounding = 5;
            btnShowP.ShowSymbols = true;
            btnShowP.Size = new Size(172, 30);
            btnShowP.TabIndex = 8;
            btnShowP.Text = "cuiCheckbox2";
            btnShowP.UncheckedForeground = Color.FromArgb(34, 34, 34);
            btnShowP.UncheckedOutlineColor = Color.FromArgb(34, 34, 34);
            btnShowP.UncheckedSymbolColor = Color.FromArgb(64, 255, 255, 255);
            btnShowP.Click += cuiCheckbox2_Click;
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(35, 213);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(139, 38);
            txtPassword.TabIndex = 7;
            txtPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.AutoSize = true;
            txtUsername.BackColor = Color.WhiteSmoke;
            txtUsername.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(35, 135);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(148, 38);
            txtUsername.TabIndex = 6;
            txtUsername.Text = "Username";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.BackColor = Color.WhiteSmoke;
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(35, 373);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(101, 25);
            lblMessage.TabIndex = 5;
            lblMessage.Text = "Plus d'Info!";
            // 
            // btnValider
            // 
            btnValider.BackColor = Color.ForestGreen;
            btnValider.ForeColor = Color.White;
            btnValider.Location = new Point(400, 355);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(137, 60);
            btnValider.TabIndex = 4;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = false;
            btnValider.Click += btnValider_Click;
            // 
            // Authentification
            // 
            Authentification.AutoSize = true;
            Authentification.BackColor = Color.WhiteSmoke;
            Authentification.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Authentification.ForeColor = Color.Black;
            Authentification.Location = new Point(119, 27);
            Authentification.Name = "Authentification";
            Authentification.Size = new Size(330, 54);
            Authentification.TabIndex = 3;
            Authentification.Text = "Authentification";
            Authentification.Click += label1_Click;
            // 
            // textPass
            // 
            textPass.ForeColor = SystemColors.Desktop;
            textPass.Location = new Point(287, 220);
            textPass.Name = "textPass";
            textPass.PasswordChar = '●';
            textPass.Size = new Size(275, 31);
            textPass.TabIndex = 1;
            textPass.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(287, 135);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(275, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // formAuthentification
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(944, 514);
            Controls.Add(cuiBorder1);
            Name = "formAuthentification";
            Text = "formAuthentification";
            Load += formAuthentification_Load;
            cuiBorder1.ResumeLayout(false);
            cuiBorder1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiBorder cuiBorder1;
        private TextBox textPass;
        private TextBox textBox1;
        private Label Authentification;
        private CuoreUI.Controls.cuiCheckbox cuiCheckbox1;
        private Button btnValider;
        private Label lblMessage;
        private Label txtPassword;
        private Label txtUsername;
        private CuoreUI.Controls.cuiCheckbox btnShowP;
    }
}
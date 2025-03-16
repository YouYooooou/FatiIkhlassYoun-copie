namespace FatiIkhlassYoun
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitre = new Label();
            tabPage2 = new TabPage();
            txtPassword = new Label();
            cuiBorder1 = new CuoreUI.Controls.cuiBorder();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            showPassbtn = new CuoreUI.Controls.cuiCheckbox();
            btnForgotPassword = new CuoreUI.Controls.cuiButton();
            txtUsername = new Label();
            cuiButton2 = new CuoreUI.Controls.cuiButton();
            cuiBorder1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitre
            // 
            labelTitre.AutoSize = true;
            labelTitre.BackColor = Color.FromArgb(44, 62, 80);
            labelTitre.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitre.ForeColor = SystemColors.ButtonHighlight;
            labelTitre.Location = new Point(152, 26);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(291, 70);
            labelTitre.TabIndex = 0;
            labelTitre.Text = "Connexion";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(292, 100);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.BackColor = Color.FromArgb(44, 62, 80);
            txtPassword.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = SystemColors.ButtonHighlight;
            txtPassword.Location = new Point(48, 237);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(136, 38);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "Password";
            txtPassword.Click += label1_Click;
            // 
            // cuiBorder1
            // 
            cuiBorder1.Controls.Add(textBox2);
            cuiBorder1.Controls.Add(textBox1);
            cuiBorder1.Controls.Add(button1);
            cuiBorder1.Controls.Add(showPassbtn);
            cuiBorder1.Controls.Add(btnForgotPassword);
            cuiBorder1.Controls.Add(txtUsername);
            cuiBorder1.Controls.Add(txtPassword);
            cuiBorder1.Controls.Add(labelTitre);
            cuiBorder1.Location = new Point(240, 91);
            cuiBorder1.Name = "cuiBorder1";
            cuiBorder1.OutlineThickness = 1F;
            cuiBorder1.PanelColor = Color.FromArgb(44, 62, 80);
            cuiBorder1.PanelOutlineColor = Color.FromArgb(44, 62, 80);
            cuiBorder1.Rounding = new Padding(8);
            cuiBorder1.Size = new Size(576, 474);
            cuiBorder1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(255, 241);
            textBox2.Margin = new Padding(8);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '●';
            textBox2.Size = new Size(283, 34);
            textBox2.TabIndex = 11;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(255, 154);
            textBox1.Margin = new Padding(8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 34);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(30, 42, 56);
            button1.Location = new Point(305, 346);
            button1.Name = "button1";
            button1.Size = new Size(161, 57);
            button1.TabIndex = 9;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // showPassbtn
            // 
            showPassbtn.Checked = false;
            showPassbtn.CheckedForeground = Color.FromArgb(30, 42, 56);
            showPassbtn.CheckedOutlineColor = Color.FromArgb(30, 42, 56);
            showPassbtn.CheckedSymbolColor = Color.White;
            showPassbtn.Content = "Show password";
            showPassbtn.Cursor = Cursors.Hand;
            showPassbtn.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showPassbtn.ForeColor = SystemColors.ButtonHighlight;
            showPassbtn.Location = new Point(377, 282);
            showPassbtn.Margin = new Padding(8);
            showPassbtn.MinimumSize = new Size(16, 16);
            showPassbtn.Name = "showPassbtn";
            showPassbtn.OutlineStyle = true;
            showPassbtn.OutlineThickness = 1F;
            showPassbtn.Rounding = 5;
            showPassbtn.ShowSymbols = true;
            showPassbtn.Size = new Size(161, 32);
            showPassbtn.TabIndex = 8;
            showPassbtn.Text = "cuiCheckbox1";
            showPassbtn.UncheckedForeground = Color.FromArgb(34, 34, 34);
            showPassbtn.UncheckedOutlineColor = Color.FromArgb(34, 34, 34);
            showPassbtn.UncheckedSymbolColor = Color.FromArgb(64, 255, 255, 255);
            showPassbtn.Click += showPassbtn_Click;
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.BackColor = Color.FromArgb(44, 62, 80);
            btnForgotPassword.CausesValidation = false;
            btnForgotPassword.CheckButton = false;
            btnForgotPassword.Checked = false;
            btnForgotPassword.CheckedBackground = Color.FromArgb(44, 62, 80);
            btnForgotPassword.CheckedForeColor = Color.FromArgb(44, 62, 80);
            btnForgotPassword.CheckedImageTint = Color.Gainsboro;
            btnForgotPassword.CheckedOutline = Color.Silver;
            btnForgotPassword.Content = "Forgot password";
            btnForgotPassword.Cursor = Cursors.Hand;
            btnForgotPassword.DialogResult = DialogResult.None;
            btnForgotPassword.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnForgotPassword.ForeColor = Color.White;
            btnForgotPassword.HoverBackground = Color.FromArgb(44, 62, 80);
            btnForgotPassword.HoveredImageTint = Color.DarkGray;
            btnForgotPassword.HoverForeColor = Color.LightGray;
            btnForgotPassword.HoverOutline = Color.Empty;
            btnForgotPassword.Image = null;
            btnForgotPassword.ImageAutoCenter = true;
            btnForgotPassword.ImageExpand = new Point(0, 0);
            btnForgotPassword.ImageOffset = new Point(0, 0);
            btnForgotPassword.ImageTint = Color.WhiteSmoke;
            btnForgotPassword.Location = new Point(83, 363);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.NormalBackground = Color.FromArgb(44, 62, 80);
            btnForgotPassword.NormalOutline = Color.Empty;
            btnForgotPassword.OutlineThickness = 1.6F;
            btnForgotPassword.PressedBackground = Color.FromArgb(44, 62, 80);
            btnForgotPassword.PressedForeColor = Color.White;
            btnForgotPassword.PressedImageTint = Color.FromArgb(44, 62, 80);
            btnForgotPassword.PressedOutline = Color.Empty;
            btnForgotPassword.Rounding = new Padding(8);
            btnForgotPassword.Size = new Size(154, 28);
            btnForgotPassword.TabIndex = 7;
            btnForgotPassword.TextOffset = new Point(0, 0);
            // 
            // txtUsername
            // 
            txtUsername.AutoSize = true;
            txtUsername.BackColor = Color.FromArgb(44, 62, 80);
            txtUsername.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = SystemColors.ButtonHighlight;
            txtUsername.Location = new Point(48, 150);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(145, 38);
            txtUsername.TabIndex = 3;
            txtUsername.Text = "Username";
            // 
            // cuiButton2
            // 
            cuiButton2.CheckButton = false;
            cuiButton2.Checked = false;
            cuiButton2.CheckedBackground = Color.Gray;
            cuiButton2.CheckedForeColor = Color.DimGray;
            cuiButton2.CheckedImageTint = Color.Gainsboro;
            cuiButton2.CheckedOutline = Color.Silver;
            cuiButton2.Content = "x";
            cuiButton2.Cursor = Cursors.Hand;
            cuiButton2.DialogResult = DialogResult.None;
            cuiButton2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiButton2.ForeColor = SystemColors.ButtonHighlight;
            cuiButton2.HoverBackground = Color.FromArgb(30, 42, 56);
            cuiButton2.HoveredImageTint = Color.DarkGray;
            cuiButton2.HoverForeColor = Color.LightGray;
            cuiButton2.HoverOutline = Color.Empty;
            cuiButton2.Image = null;
            cuiButton2.ImageAutoCenter = true;
            cuiButton2.ImageExpand = new Point(0, 0);
            cuiButton2.ImageOffset = new Point(0, 0);
            cuiButton2.ImageTint = Color.FromArgb(30, 42, 56);
            cuiButton2.Location = new Point(1042, 2);
            cuiButton2.Name = "cuiButton2";
            cuiButton2.NormalBackground = Color.FromArgb(30, 42, 56);
            cuiButton2.NormalOutline = Color.Empty;
            cuiButton2.OutlineThickness = 1.6F;
            cuiButton2.PressedBackground = Color.FromArgb(30, 42, 56);
            cuiButton2.PressedForeColor = Color.White;
            cuiButton2.PressedImageTint = Color.FromArgb(30, 42, 56);
            cuiButton2.PressedOutline = Color.Empty;
            cuiButton2.Rounding = new Padding(8);
            cuiButton2.Size = new Size(36, 32);
            cuiButton2.TabIndex = 9;
            cuiButton2.TextOffset = new Point(0, 0);
            cuiButton2.Click += cuiButton2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 42, 56);
            ClientSize = new Size(1078, 644);
            Controls.Add(cuiButton2);
            Controls.Add(cuiBorder1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ikhlasse";
            Load += Form1_Load;
            cuiBorder1.ResumeLayout(false);
            cuiBorder1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label labelTitre;
        private TabPage tabPage2;
        private Label txtPassword;
        private CuoreUI.Controls.cuiBorder cuiBorder1;
        private Label txtUsername;
        private CuoreUI.Controls.cuiButton btnForgotPassword;
        private CuoreUI.Controls.cuiCheckbox showPassbtn;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}

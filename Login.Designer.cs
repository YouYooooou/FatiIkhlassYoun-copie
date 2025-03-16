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
            cuiFormRounder1 = new CuoreUI.Components.cuiFormRounder();
            tabPage2 = new TabPage();
            txtPassword = new Label();
            cuiBorder1 = new CuoreUI.Controls.cuiBorder();
            showPassbtn = new CuoreUI.Controls.cuiCheckbox();
            btnForgotPassword = new CuoreUI.Controls.cuiButton();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            passwordTxtBox = new CuoreUI.Controls.cuiTextBox2();
            userNameTxtBox = new CuoreUI.Controls.cuiTextBox2();
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
            // cuiFormRounder1
            // 
            cuiFormRounder1.EnhanceCorners = true;
            cuiFormRounder1.OutlineColor = Color.FromArgb(30, 255, 255, 255);
            cuiFormRounder1.Rounding = 5;
            cuiFormRounder1.TargetForm = this;
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
            cuiBorder1.Controls.Add(showPassbtn);
            cuiBorder1.Controls.Add(btnForgotPassword);
            cuiBorder1.Controls.Add(cuiButton1);
            cuiBorder1.Controls.Add(passwordTxtBox);
            cuiBorder1.Controls.Add(userNameTxtBox);
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
            // cuiButton1
            // 
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.Gray;
            cuiButton1.CheckedForeColor = Color.DimGray;
            cuiButton1.CheckedImageTint = Color.Gainsboro;
            cuiButton1.CheckedOutline = Color.Silver;
            cuiButton1.Content = "Login";
            cuiButton1.Cursor = Cursors.Hand;
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiButton1.ForeColor = Color.FromArgb(30, 42, 56);
            cuiButton1.HoverBackground = Color.FromArgb(30, 42, 56);
            cuiButton1.HoveredImageTint = Color.DarkGray;
            cuiButton1.HoverForeColor = Color.LightGray;
            cuiButton1.HoverOutline = Color.Empty;
            cuiButton1.Image = null;
            cuiButton1.ImageAutoCenter = true;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.ImageOffset = new Point(0, 0);
            cuiButton1.ImageTint = Color.FromArgb(30, 42, 56);
            cuiButton1.Location = new Point(290, 349);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.White;
            cuiButton1.NormalOutline = Color.Empty;
            cuiButton1.OutlineThickness = 1.6F;
            cuiButton1.PressedBackground = Color.FromArgb(30, 42, 56);
            cuiButton1.PressedForeColor = Color.White;
            cuiButton1.PressedImageTint = Color.FromArgb(30, 42, 56);
            cuiButton1.PressedOutline = Color.Empty;
            cuiButton1.Rounding = new Padding(8);
            cuiButton1.Size = new Size(205, 61);
            cuiButton1.TabIndex = 6;
            cuiButton1.TextOffset = new Point(0, 0);
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.BackColor = Color.White;
            passwordTxtBox.BorderColor = Color.FromArgb(64, 64, 64);
            passwordTxtBox.BorderFocusColor = Color.FromArgb(255, 106, 0);
            passwordTxtBox.BorderSize = 1;
            passwordTxtBox.Content = "";
            passwordTxtBox.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTxtBox.ForeColor = Color.Gray;
            passwordTxtBox.Location = new Point(228, 237);
            passwordTxtBox.Margin = new Padding(4);
            passwordTxtBox.Multiline = false;
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.Padding = new Padding(22, 8, 22, 0);
            passwordTxtBox.PasswordChar = true;
            passwordTxtBox.PlaceholderColor = Color.DimGray;
            passwordTxtBox.PlaceholderText = "";
            passwordTxtBox.Rounding = 8;
            passwordTxtBox.Size = new Size(310, 38);
            passwordTxtBox.TabIndex = 5;
            passwordTxtBox.TextOffset = new Size(0, 0);
            passwordTxtBox.UnderlinedStyle = false;
            passwordTxtBox.ContentChanged += passwordTxtBox_ContentChanged;
            // 
            // userNameTxtBox
            // 
            userNameTxtBox.BackColor = Color.White;
            userNameTxtBox.BorderColor = Color.FromArgb(64, 64, 64);
            userNameTxtBox.BorderFocusColor = Color.FromArgb(255, 106, 0);
            userNameTxtBox.BorderSize = 1;
            userNameTxtBox.Content = "";
            userNameTxtBox.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameTxtBox.ForeColor = Color.Gray;
            userNameTxtBox.Location = new Point(228, 150);
            userNameTxtBox.Margin = new Padding(4);
            userNameTxtBox.Multiline = false;
            userNameTxtBox.Name = "userNameTxtBox";
            userNameTxtBox.Padding = new Padding(22, 8, 22, 0);
            userNameTxtBox.PasswordChar = false;
            userNameTxtBox.PlaceholderColor = Color.DimGray;
            userNameTxtBox.PlaceholderText = "";
            userNameTxtBox.Rounding = 8;
            userNameTxtBox.Size = new Size(310, 38);
            userNameTxtBox.TabIndex = 4;
            userNameTxtBox.TextOffset = new Size(0, 0);
            userNameTxtBox.UnderlinedStyle = false;
            userNameTxtBox.ContentChanged += userNameTxtBox_ContentChanged;
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
            cuiButton2.Click += this.cuiButton2_Click;
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
            cuiBorder1.ResumeLayout(false);
            cuiBorder1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CuoreUI.Components.cuiFormRounder cuiFormRounder1;
        private Label labelTitre;
        private TabPage tabPage2;
        private Label txtPassword;
        private CuoreUI.Controls.cuiBorder cuiBorder1;
        private Label txtUsername;
        private CuoreUI.Controls.cuiTextBox2 userNameTxtBox;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiTextBox2 passwordTxtBox;
        private CuoreUI.Controls.cuiButton btnForgotPassword;
        private CuoreUI.Controls.cuiCheckbox showPassbtn;
        private CuoreUI.Controls.cuiButton cuiButton2;
    }
}

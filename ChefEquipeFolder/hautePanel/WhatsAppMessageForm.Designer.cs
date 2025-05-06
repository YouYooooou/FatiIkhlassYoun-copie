namespace FatiIkhlassYoun.ChefEquipeFolder.hautePanel
{
    partial class WhatsAppMessageForm
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
            checkedListBoxMembers = new CheckedListBox();
            btnSelectAll = new CuoreUI.Controls.cuiButton();
            groupBoxType = new GroupBox();
            rbAlert = new RadioButton();
            rbReminder = new RadioButton();
            rbCustom = new RadioButton();
            txtSubject = new TextBox();
            txtCustomMessage = new TextBox();
            btnSend = new CuoreUI.Controls.cuiButton();
            panelHeader = new Panel();
            lblTitle = new Label();
            panelForm = new Panel();
            cuiButton2 = new CuoreUI.Controls.cuiButton();
            groupBoxType.SuspendLayout();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            SuspendLayout();
            // 
            // checkedListBoxMembers
            // 
            checkedListBoxMembers.BackColor = Color.WhiteSmoke;
            checkedListBoxMembers.BorderStyle = BorderStyle.None;
            checkedListBoxMembers.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBoxMembers.FormattingEnabled = true;
            checkedListBoxMembers.Location = new Point(383, 23);
            checkedListBoxMembers.Name = "checkedListBoxMembers";
            checkedListBoxMembers.Size = new Size(300, 280);
            checkedListBoxMembers.TabIndex = 0;
            // 
            // btnSelectAll
            // 
            btnSelectAll.CheckButton = false;
            btnSelectAll.Checked = false;
            btnSelectAll.CheckedBackground = Color.FromArgb(40, 167, 69);
            btnSelectAll.CheckedForeColor = Color.White;
            btnSelectAll.CheckedImageTint = Color.White;
            btnSelectAll.CheckedOutline = Color.FromArgb(40, 167, 69);
            btnSelectAll.Content = "Tout sélectionner";
            btnSelectAll.Cursor = Cursors.Hand;
            btnSelectAll.DialogResult = DialogResult.None;
            btnSelectAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectAll.ForeColor = Color.White;
            btnSelectAll.HoverBackground = Color.FromArgb(33, 136, 56);
            btnSelectAll.HoveredImageTint = Color.White;
            btnSelectAll.HoverForeColor = Color.White;
            btnSelectAll.HoverOutline = Color.Empty;
            btnSelectAll.Image = null;
            btnSelectAll.ImageAutoCenter = true;
            btnSelectAll.ImageExpand = new Point(0, 0);
            btnSelectAll.ImageOffset = new Point(0, 0);
            btnSelectAll.Location = new Point(494, 321);
            btnSelectAll.Name = "btnSelectAll";
            btnSelectAll.NormalBackground = Color.FromArgb(40, 167, 69);
            btnSelectAll.NormalForeColor = Color.White;
            btnSelectAll.NormalImageTint = Color.White;
            btnSelectAll.NormalOutline = Color.Empty;
            btnSelectAll.OutlineThickness = 1.6F;
            btnSelectAll.PressedBackground = Color.FromArgb(43, 168, 75);
            btnSelectAll.PressedForeColor = Color.White;
            btnSelectAll.PressedImageTint = Color.White;
            btnSelectAll.PressedOutline = Color.Empty;
            btnSelectAll.Rounding = new Padding(8);
            btnSelectAll.Size = new Size(189, 46);
            btnSelectAll.TabIndex = 1;
            btnSelectAll.TextOffset = new Point(0, 0);
            btnSelectAll.Click += btnSelectAll_Click;
            // 
            // groupBoxType
            // 
            groupBoxType.Controls.Add(rbAlert);
            groupBoxType.Controls.Add(rbReminder);
            groupBoxType.Controls.Add(rbCustom);
            groupBoxType.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxType.ForeColor = Color.FromArgb(64, 64, 64);
            groupBoxType.Location = new Point(23, 23);
            groupBoxType.Name = "groupBoxType";
            groupBoxType.Size = new Size(300, 120);
            groupBoxType.TabIndex = 2;
            groupBoxType.TabStop = false;
            groupBoxType.Text = "Type de message";
            // 
            // rbAlert
            // 
            rbAlert.AutoSize = true;
            rbAlert.Checked = true;
            rbAlert.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbAlert.ForeColor = Color.FromArgb(64, 64, 64);
            rbAlert.Location = new Point(20, 30);
            rbAlert.Name = "rbAlert";
            rbAlert.Size = new Size(83, 29);
            rbAlert.TabIndex = 0;
            rbAlert.TabStop = true;
            rbAlert.Text = "Alerte";
            rbAlert.UseVisualStyleBackColor = true;
            // 
            // rbReminder
            // 
            rbReminder.AutoSize = true;
            rbReminder.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbReminder.ForeColor = Color.FromArgb(64, 64, 64);
            rbReminder.Location = new Point(20, 60);
            rbReminder.Name = "rbReminder";
            rbReminder.Size = new Size(92, 29);
            rbReminder.TabIndex = 1;
            rbReminder.Text = "Rappel";
            rbReminder.UseVisualStyleBackColor = true;
            // 
            // rbCustom
            // 
            rbCustom.AutoSize = true;
            rbCustom.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbCustom.ForeColor = Color.FromArgb(64, 64, 64);
            rbCustom.Location = new Point(20, 90);
            rbCustom.Name = "rbCustom";
            rbCustom.Size = new Size(134, 29);
            rbCustom.TabIndex = 2;
            rbCustom.Text = "Personnalisé";
            rbCustom.UseVisualStyleBackColor = true;
            rbCustom.CheckedChanged += rbCustom_CheckedChanged;
            // 
            // txtSubject
            // 
            txtSubject.BackColor = Color.WhiteSmoke;
            txtSubject.BorderStyle = BorderStyle.None;
            txtSubject.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubject.Location = new Point(23, 163);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(300, 24);
            txtSubject.TabIndex = 3;
            txtSubject.Text = "Sujet du message";
            // 
            // txtCustomMessage
            // 
            txtCustomMessage.BackColor = Color.WhiteSmoke;
            txtCustomMessage.BorderStyle = BorderStyle.None;
            txtCustomMessage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomMessage.Location = new Point(20, 213);
            txtCustomMessage.Multiline = true;
            txtCustomMessage.Name = "txtCustomMessage";
            txtCustomMessage.Size = new Size(300, 237);
            txtCustomMessage.TabIndex = 4;
            txtCustomMessage.Visible = false;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSend.CheckButton = false;
            btnSend.Checked = false;
            btnSend.CheckedBackground = Color.FromArgb(40, 167, 69);
            btnSend.CheckedForeColor = Color.White;
            btnSend.CheckedImageTint = Color.White;
            btnSend.CheckedOutline = Color.FromArgb(40, 167, 69);
            btnSend.Content = "Envoyer";
            btnSend.Cursor = Cursors.Hand;
            btnSend.DialogResult = DialogResult.None;
            btnSend.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSend.ForeColor = Color.White;
            btnSend.HoverBackground = Color.FromArgb(33, 136, 56);
            btnSend.HoveredImageTint = Color.White;
            btnSend.HoverForeColor = Color.White;
            btnSend.HoverOutline = Color.Empty;
            btnSend.Image = null;
            btnSend.ImageAutoCenter = true;
            btnSend.ImageExpand = new Point(0, 0);
            btnSend.ImageOffset = new Point(0, 0);
            btnSend.Location = new Point(524, 455);
            btnSend.Name = "btnSend";
            btnSend.NormalBackground = Color.FromArgb(40, 167, 69);
            btnSend.NormalForeColor = Color.White;
            btnSend.NormalImageTint = Color.White;
            btnSend.NormalOutline = Color.Empty;
            btnSend.OutlineThickness = 1.6F;
            btnSend.PressedBackground = Color.FromArgb(43, 168, 75);
            btnSend.PressedForeColor = Color.White;
            btnSend.PressedImageTint = Color.White;
            btnSend.PressedOutline = Color.Empty;
            btnSend.Rounding = new Padding(8);
            btnSend.Size = new Size(159, 62);
            btnSend.TabIndex = 5;
            btnSend.TextOffset = new Point(0, 0);
            btnSend.Click += btnSend_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(51, 51, 76);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(706, 60);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(378, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Envoyer message WhatsApp";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(cuiButton2);
            panelForm.Controls.Add(checkedListBoxMembers);
            panelForm.Controls.Add(btnSelectAll);
            panelForm.Controls.Add(groupBoxType);
            panelForm.Controls.Add(txtSubject);
            panelForm.Controls.Add(txtCustomMessage);
            panelForm.Controls.Add(btnSend);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 60);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(20);
            panelForm.Size = new Size(706, 540);
            panelForm.TabIndex = 1;
            panelForm.Paint += panelForm_Paint;
            // 
            // cuiButton2
            // 
            cuiButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cuiButton2.CheckButton = false;
            cuiButton2.Checked = false;
            cuiButton2.CheckedBackground = Color.FromArgb(200, 35, 51);
            cuiButton2.CheckedForeColor = Color.White;
            cuiButton2.CheckedImageTint = Color.White;
            cuiButton2.CheckedOutline = Color.FromArgb(200, 35, 51);
            cuiButton2.Content = "Annuler";
            cuiButton2.Cursor = Cursors.Hand;
            cuiButton2.DialogResult = DialogResult.None;
            cuiButton2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiButton2.ForeColor = Color.White;
            cuiButton2.HoverBackground = Color.FromArgb(200, 35, 51);
            cuiButton2.HoveredImageTint = Color.White;
            cuiButton2.HoverForeColor = Color.White;
            cuiButton2.HoverOutline = Color.Empty;
            cuiButton2.Image = null;
            cuiButton2.ImageAutoCenter = true;
            cuiButton2.ImageExpand = new Point(0, 0);
            cuiButton2.ImageOffset = new Point(0, 0);
            cuiButton2.Location = new Point(342, 455);
            cuiButton2.Name = "cuiButton2";
            cuiButton2.NormalBackground = Color.FromArgb(223, 53, 69);
            cuiButton2.NormalForeColor = Color.White;
            cuiButton2.NormalImageTint = Color.White;
            cuiButton2.NormalOutline = Color.Empty;
            cuiButton2.OutlineThickness = 1.6F;
            cuiButton2.PressedBackground = Color.FromArgb(210, 35, 51);
            cuiButton2.PressedForeColor = Color.White;
            cuiButton2.PressedImageTint = Color.White;
            cuiButton2.PressedOutline = Color.Empty;
            cuiButton2.Rounding = new Padding(8);
            cuiButton2.Size = new Size(159, 62);
            cuiButton2.TabIndex = 19;
            cuiButton2.TextOffset = new Point(0, 0);
            cuiButton2.Click += cuiButton2_Click;
            // 
            // WhatsAppMessageForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(706, 600);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WhatsAppMessageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Envoyer message WhatsApp";
            groupBoxType.ResumeLayout(false);
            groupBoxType.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox checkedListBoxMembers;
        private CuoreUI.Controls.cuiButton btnSelectAll;
        private GroupBox groupBoxType;
        private RadioButton rbAlert;
        private RadioButton rbReminder;
        private RadioButton rbCustom;
        private TextBox txtSubject;
        private TextBox txtCustomMessage;
        private CuoreUI.Controls.cuiButton btnSend;
        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelForm;
        private CuoreUI.Controls.cuiButton cuiButton2;
    }
}
namespace FatiIkhlassYoun
{
    partial class WhatsAppForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            panelForm = new Panel();
            lblRecipients = new Label();
            clbRecipients = new CheckedListBox();
            lblMessageType = new Label();
            cbMessageType = new ComboBox();
            panelAlert = new Panel();
            cbAlertType = new ComboBox();
            lblAlertType = new Label();
            panelReminder = new Panel();
            cbReminderType = new ComboBox();
            lblReminderType = new Label();
            panelCustom = new Panel();
            txtCustomMessage = new TextBox();
            lblCustomMessage = new Label();
            lblGeneratedMessage = new Label();
            txtGeneratedMessage = new TextBox();
            btnSend = new CuoreUI.Controls.cuiButton();
            btnCancel = new CuoreUI.Controls.cuiButton();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            panelAlert.SuspendLayout();
            panelReminder.SuspendLayout();
            panelCustom.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(51, 51, 76);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1000, 60);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(418, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Envoyer un message WhatsApp";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(lblRecipients);
            panelForm.Controls.Add(clbRecipients);
            panelForm.Controls.Add(lblMessageType);
            panelForm.Controls.Add(cbMessageType);
            panelForm.Controls.Add(panelAlert);
            panelForm.Controls.Add(panelReminder);
            panelForm.Controls.Add(panelCustom);
            panelForm.Controls.Add(lblGeneratedMessage);
            panelForm.Controls.Add(txtGeneratedMessage);
            panelForm.Controls.Add(btnSend);
            panelForm.Controls.Add(btnCancel);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 60);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(30);
            panelForm.Size = new Size(1000, 800);
            panelForm.TabIndex = 1;
            // 
            // lblRecipients
            // 
            lblRecipients.AutoSize = true;
            lblRecipients.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblRecipients.ForeColor = Color.FromArgb(64, 64, 64);
            lblRecipients.Location = new Point(33, 20);
            lblRecipients.Name = "lblRecipients";
            lblRecipients.Size = new Size(266, 25);
            lblRecipients.TabIndex = 0;
            lblRecipients.Text = "Sélectionner les destinataires :";
            // 
            // clbRecipients
            // 
            clbRecipients.BackColor = Color.WhiteSmoke;
            clbRecipients.BorderStyle = BorderStyle.None;
            clbRecipients.Font = new Font("Segoe UI", 10F);
            clbRecipients.FormattingEnabled = true;
            clbRecipients.Location = new Point(33, 50);
            clbRecipients.Name = "clbRecipients";
            clbRecipients.Size = new Size(934, 155);
            clbRecipients.TabIndex = 1;
            clbRecipients.SelectedIndexChanged += clbRecipients_SelectedIndexChanged;
            // 
            // lblMessageType
            // 
            lblMessageType.AutoSize = true;
            lblMessageType.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMessageType.ForeColor = Color.FromArgb(64, 64, 64);
            lblMessageType.Location = new Point(33, 240);
            lblMessageType.Name = "lblMessageType";
            lblMessageType.Size = new Size(163, 25);
            lblMessageType.TabIndex = 2;
            lblMessageType.Text = "Type de message :";
            // 
            // cbMessageType
            // 
            cbMessageType.BackColor = Color.WhiteSmoke;
            cbMessageType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMessageType.FlatStyle = FlatStyle.Flat;
            cbMessageType.Font = new Font("Segoe UI", 10F);
            cbMessageType.FormattingEnabled = true;
            cbMessageType.Location = new Point(33, 270);
            cbMessageType.Name = "cbMessageType";
            cbMessageType.Size = new Size(500, 36);
            cbMessageType.TabIndex = 3;
            cbMessageType.SelectedIndexChanged += cbMessageType_SelectedIndexChanged;
            // 
            // panelAlert
            // 
            panelAlert.Controls.Add(cbAlertType);
            panelAlert.Controls.Add(lblAlertType);
            panelAlert.Location = new Point(33, 320);
            panelAlert.Name = "panelAlert";
            panelAlert.Size = new Size(934, 120);
            panelAlert.TabIndex = 4;
            panelAlert.Visible = false;
            // 
            // cbAlertType
            // 
            cbAlertType.BackColor = Color.WhiteSmoke;
            cbAlertType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAlertType.FlatStyle = FlatStyle.Flat;
            cbAlertType.Font = new Font("Segoe UI", 10F);
            cbAlertType.FormattingEnabled = true;
            cbAlertType.Items.AddRange(new object[] { "Urgent Task", "System Maintenance", "Security Alert", "Project Deadline" });
            cbAlertType.Location = new Point(0, 40);
            cbAlertType.Name = "cbAlertType";
            cbAlertType.Size = new Size(500, 36);
            cbAlertType.TabIndex = 1;
            cbAlertType.SelectedIndexChanged += cbAlertType_SelectedIndexChanged;
            // 
            // lblAlertType
            // 
            lblAlertType.AutoSize = true;
            lblAlertType.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblAlertType.ForeColor = Color.FromArgb(64, 64, 64);
            lblAlertType.Location = new Point(0, 10);
            lblAlertType.Name = "lblAlertType";
            lblAlertType.Size = new Size(130, 25);
            lblAlertType.TabIndex = 0;
            lblAlertType.Text = "Type d'alerte :";
            // 
            // panelReminder
            // 
            panelReminder.Controls.Add(cbReminderType);
            panelReminder.Controls.Add(lblReminderType);
            panelReminder.Location = new Point(33, 320);
            panelReminder.Name = "panelReminder";
            panelReminder.Size = new Size(934, 120);
            panelReminder.TabIndex = 5;
            panelReminder.Visible = false;
            // 
            // cbReminderType
            // 
            cbReminderType.BackColor = Color.WhiteSmoke;
            cbReminderType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbReminderType.FlatStyle = FlatStyle.Flat;
            cbReminderType.Font = new Font("Segoe UI", 10F);
            cbReminderType.FormattingEnabled = true;
            cbReminderType.Items.AddRange(new object[] { "Meeting", "Task Deadline", "Project Review", "Status Update" });
            cbReminderType.Location = new Point(0, 40);
            cbReminderType.Name = "cbReminderType";
            cbReminderType.Size = new Size(500, 36);
            cbReminderType.TabIndex = 1;
            cbReminderType.SelectedIndexChanged += cbReminderType_SelectedIndexChanged;
            // 
            // lblReminderType
            // 
            lblReminderType.AutoSize = true;
            lblReminderType.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblReminderType.ForeColor = Color.FromArgb(64, 64, 64);
            lblReminderType.Location = new Point(0, 10);
            lblReminderType.Name = "lblReminderType";
            lblReminderType.Size = new Size(144, 25);
            lblReminderType.TabIndex = 0;
            lblReminderType.Text = "Type de rappel :";
            // 
            // panelCustom
            // 
            panelCustom.Controls.Add(txtCustomMessage);
            panelCustom.Controls.Add(lblCustomMessage);
            panelCustom.Location = new Point(33, 320);
            panelCustom.Name = "panelCustom";
            panelCustom.Size = new Size(934, 200);
            panelCustom.TabIndex = 6;
            panelCustom.Visible = false;
            // 
            // txtCustomMessage
            // 
            txtCustomMessage.BackColor = Color.WhiteSmoke;
            txtCustomMessage.BorderStyle = BorderStyle.None;
            txtCustomMessage.Font = new Font("Segoe UI", 10F);
            txtCustomMessage.Location = new Point(0, 40);
            txtCustomMessage.Multiline = true;
            txtCustomMessage.Name = "txtCustomMessage";
            txtCustomMessage.Size = new Size(934, 150);
            txtCustomMessage.TabIndex = 1;
            txtCustomMessage.TextChanged += txtCustomMessage_TextChanged;
            // 
            // lblCustomMessage
            // 
            lblCustomMessage.AutoSize = true;
            lblCustomMessage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCustomMessage.ForeColor = Color.FromArgb(64, 64, 64);
            lblCustomMessage.Location = new Point(0, 10);
            lblCustomMessage.Name = "lblCustomMessage";
            lblCustomMessage.Size = new Size(205, 25);
            lblCustomMessage.TabIndex = 0;
            lblCustomMessage.Text = "Message personnalisé :";
            // 
            // lblGeneratedMessage
            // 
            lblGeneratedMessage.AutoSize = true;
            lblGeneratedMessage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblGeneratedMessage.ForeColor = Color.FromArgb(64, 64, 64);
            lblGeneratedMessage.Location = new Point(33, 450);
            lblGeneratedMessage.Name = "lblGeneratedMessage";
            lblGeneratedMessage.Size = new Size(158, 25);
            lblGeneratedMessage.TabIndex = 7;
            lblGeneratedMessage.Text = "Message généré :";
            // 
            // txtGeneratedMessage
            // 
            txtGeneratedMessage.BackColor = Color.WhiteSmoke;
            txtGeneratedMessage.BorderStyle = BorderStyle.None;
            txtGeneratedMessage.Font = new Font("Segoe UI", 10F);
            txtGeneratedMessage.Location = new Point(33, 480);
            txtGeneratedMessage.Multiline = true;
            txtGeneratedMessage.Name = "txtGeneratedMessage";
            txtGeneratedMessage.ReadOnly = true;
            txtGeneratedMessage.Size = new Size(934, 150);
            txtGeneratedMessage.TabIndex = 8;
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
            btnSend.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSend.ForeColor = Color.White;
            btnSend.HoverBackground = Color.FromArgb(33, 136, 56);
            btnSend.HoveredImageTint = Color.White;
            btnSend.HoverForeColor = Color.White;
            btnSend.HoverOutline = Color.Empty;
            btnSend.Image = null;
            btnSend.ImageAutoCenter = true;
            btnSend.ImageExpand = new Point(0, 0);
            btnSend.ImageOffset = new Point(0, 0);
            btnSend.Location = new Point(753, 682);
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
            btnSend.Size = new Size(214, 85);
            btnSend.TabIndex = 9;
            btnSend.TextOffset = new Point(0, 0);
            btnSend.Click += btnSend_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.CheckButton = false;
            btnCancel.Checked = false;
            btnCancel.CheckedBackground = Color.FromArgb(200, 35, 51);
            btnCancel.CheckedForeColor = Color.White;
            btnCancel.CheckedImageTint = Color.White;
            btnCancel.CheckedOutline = Color.FromArgb(200, 35, 51);
            btnCancel.Content = "Annuler";
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.DialogResult = DialogResult.None;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.HoverBackground = Color.FromArgb(200, 35, 51);
            btnCancel.HoveredImageTint = Color.White;
            btnCancel.HoverForeColor = Color.White;
            btnCancel.HoverOutline = Color.Empty;
            btnCancel.Image = null;
            btnCancel.ImageAutoCenter = true;
            btnCancel.ImageExpand = new Point(0, 0);
            btnCancel.ImageOffset = new Point(0, 0);
            btnCancel.Location = new Point(504, 682);
            btnCancel.Name = "btnCancel";
            btnCancel.NormalBackground = Color.FromArgb(223, 53, 69);
            btnCancel.NormalForeColor = Color.White;
            btnCancel.NormalImageTint = Color.White;
            btnCancel.NormalOutline = Color.Empty;
            btnCancel.OutlineThickness = 1.6F;
            btnCancel.PressedBackground = Color.FromArgb(210, 35, 51);
            btnCancel.PressedForeColor = Color.White;
            btnCancel.PressedImageTint = Color.White;
            btnCancel.PressedOutline = Color.Empty;
            btnCancel.Rounding = new Padding(8);
            btnCancel.Size = new Size(214, 85);
            btnCancel.TabIndex = 10;
            btnCancel.TextOffset = new Point(0, 0);
            btnCancel.Click += btnCancel_Click;
            // 
            // WhatsAppForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 860);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WhatsAppForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Envoyer un message WhatsApp";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelAlert.ResumeLayout(false);
            panelAlert.PerformLayout();
            panelReminder.ResumeLayout(false);
            panelReminder.PerformLayout();
            panelCustom.ResumeLayout(false);
            panelCustom.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelForm;
        private Label lblRecipients;
        private CheckedListBox clbRecipients;
        private Label lblMessageType;
        private ComboBox cbMessageType;
        private Panel panelAlert;
        private ComboBox cbAlertType;
        private Label lblAlertType;
        private Panel panelReminder;
        private ComboBox cbReminderType;
        private Label lblReminderType;
        private Panel panelCustom;
        private TextBox txtCustomMessage;
        private Label lblCustomMessage;
        private Label lblGeneratedMessage;
        private TextBox txtGeneratedMessage;
        private CuoreUI.Controls.cuiButton btnSend;
        private CuoreUI.Controls.cuiButton btnCancel;
    }
}
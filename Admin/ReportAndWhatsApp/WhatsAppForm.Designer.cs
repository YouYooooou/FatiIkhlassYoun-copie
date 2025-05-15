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
            lblRecipients = new Label();
            clbRecipients = new CheckedListBox();
            lblMessageType = new Label();
            cbMessageType = new ComboBox();
            lblAlertType = new Label();
            cbAlertType = new ComboBox();
            lblReminderType = new Label();
            cbReminderType = new ComboBox();
            lblCustomMessage = new Label();
            txtCustomMessage = new TextBox();
            panelAlert = new Panel();
            panelReminder = new Panel();
            panelCustom = new Panel();
            lblGeneratedMessage = new Label();
            txtGeneratedMessage = new TextBox();
            label1 = new Label();
            panelHeader = new Panel();
            btnSend = new CuoreUI.Controls.cuiButton();
            btnCancel = new CuoreUI.Controls.cuiButton();
            panelAlert.SuspendLayout();
            panelReminder.SuspendLayout();
            panelCustom.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // lblRecipients
            // 
            lblRecipients.AutoSize = true;
            lblRecipients.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRecipients.Location = new Point(35, 155);
            lblRecipients.Margin = new Padding(9, 0, 9, 0);
            lblRecipients.Name = "lblRecipients";
            lblRecipients.Size = new Size(311, 48);
            lblRecipients.TabIndex = 0;
            lblRecipients.Text = "Select Recipients:";
            // 
            // clbRecipients
            // 
            clbRecipients.BackColor = SystemColors.InactiveBorder;
            clbRecipients.FormattingEnabled = true;
            clbRecipients.Location = new Point(35, 219);
            clbRecipients.Margin = new Padding(9, 10, 9, 10);
            clbRecipients.Name = "clbRecipients";
            clbRecipients.Size = new Size(993, 220);
            clbRecipients.TabIndex = 1;
            clbRecipients.SelectedIndexChanged += clbRecipients_SelectedIndexChanged;
            // 
            // lblMessageType
            // 
            lblMessageType.AutoSize = true;
            lblMessageType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMessageType.Location = new Point(1120, 319);
            lblMessageType.Margin = new Padding(9, 0, 9, 0);
            lblMessageType.Name = "lblMessageType";
            lblMessageType.Size = new Size(264, 48);
            lblMessageType.TabIndex = 2;
            lblMessageType.Text = "Message Type:";
            // 
            // cbMessageType
            // 
            cbMessageType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMessageType.FormattingEnabled = true;
            cbMessageType.Location = new Point(1120, 383);
            cbMessageType.Margin = new Padding(9, 10, 9, 10);
            cbMessageType.Name = "cbMessageType";
            cbMessageType.Size = new Size(564, 56);
            cbMessageType.TabIndex = 3;
            cbMessageType.SelectedIndexChanged += cbMessageType_SelectedIndexChanged;
            // 
            // lblAlertType
            // 
            lblAlertType.AutoSize = true;
            lblAlertType.Location = new Point(9, 32);
            lblAlertType.Margin = new Padding(9, 0, 9, 0);
            lblAlertType.Name = "lblAlertType";
            lblAlertType.Size = new Size(188, 48);
            lblAlertType.TabIndex = 0;
            lblAlertType.Text = "Alert Type:";
            // 
            // cbAlertType
            // 
            cbAlertType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAlertType.FormattingEnabled = true;
            cbAlertType.Items.AddRange(new object[] { "Urgent Task", "System Maintenance", "Security Alert", "Project Deadline" });
            cbAlertType.Location = new Point(9, 96);
            cbAlertType.Margin = new Padding(9, 10, 9, 10);
            cbAlertType.Name = "cbAlertType";
            cbAlertType.Size = new Size(564, 56);
            cbAlertType.TabIndex = 1;
            cbAlertType.SelectedIndexChanged += cbAlertType_SelectedIndexChanged;
            // 
            // lblReminderType
            // 
            lblReminderType.AutoSize = true;
            lblReminderType.Location = new Point(9, 32);
            lblReminderType.Margin = new Padding(9, 0, 9, 0);
            lblReminderType.Name = "lblReminderType";
            lblReminderType.Size = new Size(265, 48);
            lblReminderType.TabIndex = 0;
            lblReminderType.Text = "Reminder Type:";
            // 
            // cbReminderType
            // 
            cbReminderType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbReminderType.FormattingEnabled = true;
            cbReminderType.Items.AddRange(new object[] { "Meeting", "Task Deadline", "Project Review", "Status Update" });
            cbReminderType.Location = new Point(9, 96);
            cbReminderType.Margin = new Padding(9, 10, 9, 10);
            cbReminderType.Name = "cbReminderType";
            cbReminderType.Size = new Size(564, 56);
            cbReminderType.TabIndex = 1;
            cbReminderType.SelectedIndexChanged += cbReminderType_SelectedIndexChanged;
            // 
            // lblCustomMessage
            // 
            lblCustomMessage.AutoSize = true;
            lblCustomMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCustomMessage.Location = new Point(9, 32);
            lblCustomMessage.Margin = new Padding(9, 0, 9, 0);
            lblCustomMessage.Name = "lblCustomMessage";
            lblCustomMessage.Size = new Size(314, 48);
            lblCustomMessage.TabIndex = 0;
            lblCustomMessage.Text = "Custom Message:";
            // 
            // txtCustomMessage
            // 
            txtCustomMessage.BackColor = Color.WhiteSmoke;
            txtCustomMessage.Location = new Point(9, 96);
            txtCustomMessage.Margin = new Padding(9, 10, 9, 10);
            txtCustomMessage.Multiline = true;
            txtCustomMessage.Name = "txtCustomMessage";
            txtCustomMessage.Size = new Size(964, 214);
            txtCustomMessage.TabIndex = 1;
            txtCustomMessage.TextChanged += txtCustomMessage_TextChanged;
            // 
            // panelAlert
            // 
            panelAlert.Controls.Add(cbAlertType);
            panelAlert.Controls.Add(lblAlertType);
            panelAlert.Location = new Point(1120, 500);
            panelAlert.Margin = new Padding(9, 10, 9, 10);
            panelAlert.Name = "panelAlert";
            panelAlert.Size = new Size(1000, 256);
            panelAlert.TabIndex = 4;
            panelAlert.Visible = false;
            // 
            // panelReminder
            // 
            panelReminder.Controls.Add(cbReminderType);
            panelReminder.Controls.Add(lblReminderType);
            panelReminder.Location = new Point(1120, 500);
            panelReminder.Margin = new Padding(9, 10, 9, 10);
            panelReminder.Name = "panelReminder";
            panelReminder.Size = new Size(1000, 256);
            panelReminder.TabIndex = 5;
            panelReminder.Visible = false;
            // 
            // panelCustom
            // 
            panelCustom.Controls.Add(txtCustomMessage);
            panelCustom.Controls.Add(lblCustomMessage);
            panelCustom.Location = new Point(1120, 500);
            panelCustom.Margin = new Padding(9, 10, 9, 10);
            panelCustom.Name = "panelCustom";
            panelCustom.Size = new Size(1000, 355);
            panelCustom.TabIndex = 6;
            panelCustom.Visible = false;
            // 
            // lblGeneratedMessage
            // 
            lblGeneratedMessage.AutoSize = true;
            lblGeneratedMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGeneratedMessage.Location = new Point(35, 484);
            lblGeneratedMessage.Margin = new Padding(9, 0, 9, 0);
            lblGeneratedMessage.Name = "lblGeneratedMessage";
            lblGeneratedMessage.Size = new Size(359, 48);
            lblGeneratedMessage.TabIndex = 7;
            lblGeneratedMessage.Text = "Generated Message:";
            // 
            // txtGeneratedMessage
            // 
            txtGeneratedMessage.Location = new Point(35, 548);
            txtGeneratedMessage.Margin = new Padding(9, 10, 9, 10);
            txtGeneratedMessage.Multiline = true;
            txtGeneratedMessage.Name = "txtGeneratedMessage";
            txtGeneratedMessage.ReadOnly = true;
            txtGeneratedMessage.Size = new Size(993, 311);
            txtGeneratedMessage.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(35, 33);
            label1.Margin = new Padding(9, 0, 9, 0);
            label1.Name = "label1";
            label1.Size = new Size(677, 55);
            label1.TabIndex = 11;
            label1.Text = "Send a message via  Whatsapp :";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.HotTrack;
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(6);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(2199, 115);
            panelHeader.TabIndex = 37;
            // 
            // btnSend
            // 
            btnSend.CheckButton = false;
            btnSend.Checked = false;
            btnSend.CheckedBackground = Color.FromArgb(40, 167, 69);
            btnSend.CheckedForeColor = Color.White;
            btnSend.CheckedImageTint = Color.White;
            btnSend.CheckedOutline = Color.FromArgb(40, 167, 69);
            btnSend.Content = "Send";
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
            btnSend.Location = new Point(1142, 969);
            btnSend.Margin = new Padding(6);
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
            btnSend.Size = new Size(301, 134);
            btnSend.TabIndex = 38;
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
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.HoverBackground = Color.FromArgb(200, 35, 51);
            btnCancel.HoveredImageTint = Color.White;
            btnCancel.HoverForeColor = Color.White;
            btnCancel.HoverOutline = Color.Empty;
            btnCancel.Image = null;
            btnCancel.ImageAutoCenter = true;
            btnCancel.ImageExpand = new Point(0, 0);
            btnCancel.ImageOffset = new Point(0, 0);
            btnCancel.Location = new Point(708, 969);
            btnCancel.Margin = new Padding(6);
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
            btnCancel.Size = new Size(286, 134);
            btnCancel.TabIndex = 39;
            btnCancel.TextOffset = new Point(0, 0);
            btnCancel.Click += btnCancel_Click_1;
            // 
            // WhatsAppForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(2199, 1164);
            Controls.Add(btnSend);
            Controls.Add(btnCancel);
            Controls.Add(panelHeader);
            Controls.Add(txtGeneratedMessage);
            Controls.Add(lblGeneratedMessage);
            Controls.Add(panelCustom);
            Controls.Add(panelReminder);
            Controls.Add(panelAlert);
            Controls.Add(cbMessageType);
            Controls.Add(lblMessageType);
            Controls.Add(clbRecipients);
            Controls.Add(lblRecipients);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(9, 10, 9, 10);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WhatsAppForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Send WhatsApp Message";
            Load += WhatsAppForm_Load;
            panelAlert.ResumeLayout(false);
            panelAlert.PerformLayout();
            panelReminder.ResumeLayout(false);
            panelReminder.PerformLayout();
            panelCustom.ResumeLayout(false);
            panelCustom.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblRecipients;
        private System.Windows.Forms.CheckedListBox clbRecipients;
        private System.Windows.Forms.Label lblMessageType;
        private System.Windows.Forms.ComboBox cbMessageType;
        private System.Windows.Forms.Label lblAlertType;
        private System.Windows.Forms.ComboBox cbAlertType;
        private System.Windows.Forms.Label lblReminderType;
        private System.Windows.Forms.ComboBox cbReminderType;
        private System.Windows.Forms.Label lblCustomMessage;
        private System.Windows.Forms.TextBox txtCustomMessage;
        private System.Windows.Forms.Panel panelAlert;
        private System.Windows.Forms.Panel panelReminder;
        private System.Windows.Forms.Panel panelCustom;
        private System.Windows.Forms.Label lblGeneratedMessage;
        private System.Windows.Forms.TextBox txtGeneratedMessage;
        private Label label1;
        private Panel panelHeader;
        private CuoreUI.Controls.cuiButton btnSend;
        private CuoreUI.Controls.cuiButton btnCancel;
    }
}
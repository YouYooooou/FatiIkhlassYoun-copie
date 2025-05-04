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
            this.checkedListBoxMembers = new System.Windows.Forms.CheckedListBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.rbAlert = new System.Windows.Forms.RadioButton();
            this.rbReminder = new System.Windows.Forms.RadioButton();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtCustomMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBoxType.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBoxMembers
            // 
            this.checkedListBoxMembers.FormattingEnabled = true;
            this.checkedListBoxMembers.Location = new System.Drawing.Point(20, 20);
            this.checkedListBoxMembers.Name = "checkedListBoxMembers";
            this.checkedListBoxMembers.Size = new System.Drawing.Size(300, 200);
            this.checkedListBoxMembers.TabIndex = 0;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(330, 20);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(120, 30);
            this.btnSelectAll.TabIndex = 1;
            this.btnSelectAll.Text = "Tout sélectionner";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.rbAlert);
            this.groupBoxType.Controls.Add(this.rbReminder);
            this.groupBoxType.Controls.Add(this.rbCustom);
            this.groupBoxType.Location = new System.Drawing.Point(20, 230);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(300, 100);
            this.groupBoxType.TabIndex = 2;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Type de message";
            // 
            // rbAlert
            // 
            this.rbAlert.AutoSize = true;
            this.rbAlert.Checked = true;
            this.rbAlert.Location = new System.Drawing.Point(10, 20);
            this.rbAlert.Name = "rbAlert";
            this.rbAlert.Size = new System.Drawing.Size(50, 17);
            this.rbAlert.TabIndex = 0;
            this.rbAlert.TabStop = true;
            this.rbAlert.Text = "Alerte";
            this.rbAlert.UseVisualStyleBackColor = true;
            // 
            // rbReminder
            // 
            this.rbReminder.AutoSize = true;
            this.rbReminder.Location = new System.Drawing.Point(10, 45);
            this.rbReminder.Name = "rbReminder";
            this.rbReminder.Size = new System.Drawing.Size(60, 17);
            this.rbReminder.TabIndex = 1;
            this.rbReminder.Text = "Rappel";
            this.rbReminder.UseVisualStyleBackColor = true;
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Location = new System.Drawing.Point(10, 70);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(80, 17);
            this.rbCustom.TabIndex = 2;
            this.rbCustom.Text = "Personnalisé";
            this.rbCustom.UseVisualStyleBackColor = true;
            this.rbCustom.CheckedChanged += new System.EventHandler(this.rbCustom_CheckedChanged);
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(20, 340);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(300, 20);
            this.txtSubject.TabIndex = 3;
            this.txtSubject.Text = "Sujet du message";
            // 
            // txtCustomMessage
            // 
            this.txtCustomMessage.Location = new System.Drawing.Point(20, 370);
            this.txtCustomMessage.Multiline = true;
            this.txtCustomMessage.Name = "txtCustomMessage";
            this.txtCustomMessage.Size = new System.Drawing.Size(300, 100);
            this.txtCustomMessage.TabIndex = 4;
            this.txtCustomMessage.Visible = false;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(330, 340);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(120, 30);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Envoyer";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // WhatsAppMessageForm
            // 
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtCustomMessage);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.groupBoxType);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.checkedListBoxMembers);
            this.Name = "WhatsAppMessageForm";
            this.Text = "Envoyer message WhatsApp";
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxMembers;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.RadioButton rbAlert;
        private System.Windows.Forms.RadioButton rbReminder;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtCustomMessage;
        private System.Windows.Forms.Button btnSend;
    }
}
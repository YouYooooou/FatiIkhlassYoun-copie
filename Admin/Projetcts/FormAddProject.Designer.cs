namespace FatiIkhlassYoun
{
    partial class FormAddProject
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
            label2 = new Label();
            txtTitle = new TextBox();
            label3 = new Label();
            txtDescription = new TextBox();
            label4 = new Label();
            dtpStartDate = new DateTimePicker();
            label5 = new Label();
            dtpEndDate = new DateTimePicker();
            label6 = new Label();
            cbStatus = new ComboBox();
            label7 = new Label();
            cbManager = new ComboBox();
            btnSave = new CuoreUI.Controls.cuiButton();
            btnCancel = new CuoreUI.Controls.cuiButton();
            panelHeader = new Panel();
            lblTitle = new Label();
            panelForm = new Panel();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(251, 13);
            label1.Name = "label1";
            label1.Size = new Size(294, 32);
            label1.TabIndex = 0;
            label1.Text = "Créer un nouveau projet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(33, 66);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 1;
            label2.Text = "Titre :";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.WhiteSmoke;
            txtTitle.BorderStyle = BorderStyle.None;
            txtTitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(33, 96);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(400, 27);
            txtTitle.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(33, 136);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 3;
            label3.Text = "Description :";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.WhiteSmoke;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(33, 166);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(400, 198);
            txtDescription.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(467, 66);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 5;
            label4.Text = "Date de début :";
            // 
            // dtpStartDate
            // 
            dtpStartDate.CalendarMonthBackground = Color.WhiteSmoke;
            dtpStartDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStartDate.Location = new Point(467, 96);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(300, 34);
            dtpStartDate.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(467, 143);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 7;
            label5.Text = "Date limite :";
            // 
            // dtpEndDate
            // 
            dtpEndDate.CalendarMonthBackground = Color.WhiteSmoke;
            dtpEndDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEndDate.Location = new Point(467, 173);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(300, 34);
            dtpEndDate.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(467, 220);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 9;
            label6.Text = "Statut :";
            // 
            // cbStatus
            // 
            cbStatus.BackColor = Color.WhiteSmoke;
            cbStatus.FlatStyle = FlatStyle.Flat;
            cbStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(467, 250);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(300, 36);
            cbStatus.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(467, 299);
            label7.Name = "label7";
            label7.Size = new Size(95, 25);
            label7.TabIndex = 11;
            label7.Text = "Manager :";
            // 
            // cbManager
            // 
            cbManager.BackColor = Color.WhiteSmoke;
            cbManager.FlatStyle = FlatStyle.Flat;
            cbManager.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbManager.FormattingEnabled = true;
            cbManager.Location = new Point(467, 329);
            cbManager.Name = "cbManager";
            cbManager.Size = new Size(300, 36);
            cbManager.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.CheckButton = false;
            btnSave.Checked = false;
            btnSave.CheckedBackground = Color.FromArgb(40, 167, 69);
            btnSave.CheckedForeColor = Color.White;
            btnSave.CheckedImageTint = Color.White;
            btnSave.CheckedOutline = Color.FromArgb(40, 167, 69);
            btnSave.Content = "Enregistrer";
            btnSave.Cursor = Cursors.Hand;
            btnSave.DialogResult = DialogResult.None;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.HoverBackground = Color.FromArgb(33, 136, 56);
            btnSave.HoveredImageTint = Color.White;
            btnSave.HoverForeColor = Color.White;
            btnSave.HoverOutline = Color.Empty;
            btnSave.Image = null;
            btnSave.ImageAutoCenter = true;
            btnSave.ImageExpand = new Point(0, 0);
            btnSave.ImageOffset = new Point(0, 0);
            btnSave.Location = new Point(583, 452);
            btnSave.Name = "btnSave";
            btnSave.NormalBackground = Color.FromArgb(40, 167, 69);
            btnSave.NormalForeColor = Color.White;
            btnSave.NormalImageTint = Color.White;
            btnSave.NormalOutline = Color.Empty;
            btnSave.OutlineThickness = 1.6F;
            btnSave.PressedBackground = Color.FromArgb(43, 168, 75);
            btnSave.PressedForeColor = Color.White;
            btnSave.PressedImageTint = Color.White;
            btnSave.PressedOutline = Color.Empty;
            btnSave.Rounding = new Padding(8);
            btnSave.Size = new Size(177, 83);
            btnSave.TabIndex = 13;
            btnSave.TextOffset = new Point(0, 0);
            btnSave.Click += buttonSave_Click;
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
            btnCancel.Location = new Point(366, 452);
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
            btnCancel.Size = new Size(172, 83);
            btnCancel.TabIndex = 14;
            btnCancel.TextOffset = new Point(0, 0);
            btnCancel.Click += btnCancel_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(51, 51, 76);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 60);
            panelHeader.TabIndex = 15;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(215, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Nouveau projet";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(label1);
            panelForm.Controls.Add(label2);
            panelForm.Controls.Add(txtTitle);
            panelForm.Controls.Add(label3);
            panelForm.Controls.Add(txtDescription);
            panelForm.Controls.Add(label4);
            panelForm.Controls.Add(dtpStartDate);
            panelForm.Controls.Add(label5);
            panelForm.Controls.Add(dtpEndDate);
            panelForm.Controls.Add(label6);
            panelForm.Controls.Add(cbStatus);
            panelForm.Controls.Add(label7);
            panelForm.Controls.Add(cbManager);
            panelForm.Controls.Add(btnSave);
            panelForm.Controls.Add(btnCancel);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 60);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(30);
            panelForm.Size = new Size(800, 568);
            panelForm.TabIndex = 16;
            // 
            // FormAddProject
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 628);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddProject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nouveau projet";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTitle;
        private Label label3;
        private TextBox txtDescription;
        private Label label4;
        private DateTimePicker dtpStartDate;
        private Label label5;
        private DateTimePicker dtpEndDate;
        private Label label6;
        private ComboBox cbStatus;
        private Label label7;
        private ComboBox cbManager;
        private CuoreUI.Controls.cuiButton btnSave;
        private CuoreUI.Controls.cuiButton btnCancel;
        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelForm;
    }
}
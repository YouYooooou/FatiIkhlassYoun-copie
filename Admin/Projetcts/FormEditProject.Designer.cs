namespace FatiIkhlassYoun
{
    partial class FormEditProject
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
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblStartDate = new Label();
            dateTimeStartDate = new DateTimePicker();
            lblEndDate = new Label();
            dateTimeEndDate = new DateTimePicker();
            lblStatus = new Label();
            comboBoxStatus = new ComboBox();
            lblManager = new Label();
            comboBoxManager = new ComboBox();
            btnSave = new CuoreUI.Controls.cuiButton();
            btnCancel = new CuoreUI.Controls.cuiButton();
            panelHeader = new Panel();
            lblFormTitle = new Label();
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
            label1.Size = new Size(298, 32);
            label1.TabIndex = 0;
            label1.Text = "Modifier le projet";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(33, 66);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(56, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Titre :";
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
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.FromArgb(64, 64, 64);
            lblDescription.Location = new Point(33, 136);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(117, 25);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description :";
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
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStartDate.ForeColor = Color.FromArgb(64, 64, 64);
            lblStartDate.Location = new Point(467, 66);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(132, 25);
            lblStartDate.TabIndex = 5;
            lblStartDate.Text = "Date de début :";
            // 
            // dateTimeStartDate
            // 
            dateTimeStartDate.CalendarMonthBackground = Color.WhiteSmoke;
            dateTimeStartDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimeStartDate.Location = new Point(467, 96);
            dateTimeStartDate.Name = "dateTimeStartDate";
            dateTimeStartDate.Size = new Size(300, 34);
            dateTimeStartDate.TabIndex = 6;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndDate.ForeColor = Color.FromArgb(64, 64, 64);
            lblEndDate.Location = new Point(467, 143);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(113, 25);
            lblEndDate.TabIndex = 7;
            lblEndDate.Text = "Date limite :";
            // 
            // dateTimeEndDate
            // 
            dateTimeEndDate.CalendarMonthBackground = Color.WhiteSmoke;
            dateTimeEndDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimeEndDate.Location = new Point(467, 173);
            dateTimeEndDate.Name = "dateTimeEndDate";
            dateTimeEndDate.Size = new Size(300, 34);
            dateTimeEndDate.TabIndex = 8;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.FromArgb(64, 64, 64);
            lblStatus.Location = new Point(467, 220);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(71, 25);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Statut :";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.BackColor = Color.WhiteSmoke;
            comboBoxStatus.FlatStyle = FlatStyle.Flat;
            comboBoxStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(467, 250);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(300, 36);
            comboBoxStatus.TabIndex = 10;
            // 
            // lblManager
            // 
            lblManager.AutoSize = true;
            lblManager.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManager.ForeColor = Color.FromArgb(64, 64, 64);
            lblManager.Location = new Point(467, 299);
            lblManager.Name = "lblManager";
            lblManager.Size = new Size(93, 25);
            lblManager.TabIndex = 11;
            lblManager.Text = "Manager :";
            // 
            // comboBoxManager
            // 
            comboBoxManager.BackColor = Color.WhiteSmoke;
            comboBoxManager.FlatStyle = FlatStyle.Flat;
            comboBoxManager.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxManager.FormattingEnabled = true;
            comboBoxManager.Location = new Point(467, 329);
            comboBoxManager.Name = "comboBoxManager";
            comboBoxManager.Size = new Size(300, 36);
            comboBoxManager.TabIndex = 12;
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
            btnSave.Location = new Point(583, 524);
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
            btnCancel.Location = new Point(366, 524);
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
            btnCancel.Click += buttonCancel_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(51, 51, 76);
            panelHeader.Controls.Add(lblFormTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 60);
            panelHeader.TabIndex = 15;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = Color.White;
            lblFormTitle.Location = new Point(20, 15);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(211, 38);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Modifier projet";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(label1);
            panelForm.Controls.Add(lblTitle);
            panelForm.Controls.Add(txtTitle);
            panelForm.Controls.Add(lblDescription);
            panelForm.Controls.Add(txtDescription);
            panelForm.Controls.Add(lblStartDate);
            panelForm.Controls.Add(dateTimeStartDate);
            panelForm.Controls.Add(lblEndDate);
            panelForm.Controls.Add(dateTimeEndDate);
            panelForm.Controls.Add(lblStatus);
            panelForm.Controls.Add(comboBoxStatus);
            panelForm.Controls.Add(lblManager);
            panelForm.Controls.Add(comboBoxManager);
            panelForm.Controls.Add(btnSave);
            panelForm.Controls.Add(btnCancel);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 60);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(30);
            panelForm.Size = new Size(800, 640);
            panelForm.TabIndex = 16;
            // 
            // FormEditProject
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 700);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditProject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modifier projet";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblStartDate;
        private DateTimePicker dateTimeStartDate;
        private Label lblEndDate;
        private DateTimePicker dateTimeEndDate;
        private Label lblStatus;
        private ComboBox comboBoxStatus;
        private Label lblManager;
        private ComboBox comboBoxManager;
        private CuoreUI.Controls.cuiButton btnSave;
        private CuoreUI.Controls.cuiButton btnCancel;
        private Panel panelHeader;
        private Label lblFormTitle;
        private Panel panelForm;
    }
}
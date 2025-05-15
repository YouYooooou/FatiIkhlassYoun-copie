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
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            label6 = new Label();
            label5 = new Label();
            Title = new Label();
            dateTimeEndDate = new DateTimePicker();
            dateTimeStartDate = new DateTimePicker();
            comboBoxStatus = new ComboBox();
            label2 = new Label();
            label7 = new Label();
            label8 = new Label();
            comboBoxManager = new ComboBox();
            panel1 = new Panel();
            lblFormTitle = new Label();
            btnSave = new CuoreUI.Controls.cuiButton();
            btnCancel = new CuoreUI.Controls.cuiButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(301, 249);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(549, 55);
            txtTitle.TabIndex = 20;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(301, 363);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(549, 145);
            txtDescription.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(937, 432);
            label6.Name = "label6";
            label6.Size = new Size(144, 48);
            label6.TabIndex = 17;
            label6.Text = "Status :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(930, 261);
            label5.Name = "label5";
            label5.Size = new Size(192, 48);
            label5.TabIndex = 16;
            label5.Text = "End Date :";
            label5.Click += label5_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Title.Location = new Point(47, 256);
            Title.Name = "Title";
            Title.Size = new Size(114, 48);
            Title.TabIndex = 13;
            Title.Text = "Title :";
            // 
            // dateTimeEndDate
            // 
            dateTimeEndDate.Location = new Point(1210, 256);
            dateTimeEndDate.Name = "dateTimeEndDate";
            dateTimeEndDate.Size = new Size(549, 55);
            dateTimeEndDate.TabIndex = 24;
            // 
            // dateTimeStartDate
            // 
            dateTimeStartDate.Location = new Point(301, 540);
            dateTimeStartDate.Name = "dateTimeStartDate";
            dateTimeStartDate.Size = new Size(549, 55);
            dateTimeStartDate.TabIndex = 25;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(1196, 419);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(549, 56);
            comboBoxStatus.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(19, 547);
            label2.Name = "label2";
            label2.Size = new Size(210, 48);
            label2.TabIndex = 27;
            label2.Text = "Start Date :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(19, 426);
            label7.Name = "label7";
            label7.Size = new Size(233, 48);
            label7.TabIndex = 28;
            label7.Text = "Description :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(930, 536);
            label8.Name = "label8";
            label8.Size = new Size(199, 48);
            label8.TabIndex = 29;
            label8.Text = " Manager :";
            // 
            // comboBoxManager
            // 
            comboBoxManager.FormattingEnabled = true;
            comboBoxManager.Location = new Point(1210, 528);
            comboBoxManager.Name = "comboBoxManager";
            comboBoxManager.Size = new Size(549, 56);
            comboBoxManager.TabIndex = 30;
            comboBoxManager.SelectedIndexChanged += comboBoxManager_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(lblFormTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1925, 143);
            panel1.TabIndex = 39;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = Color.White;
            lblFormTitle.Location = new Point(37, 22);
            lblFormTitle.Margin = new Padding(6, 0, 6, 0);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(424, 63);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Ajouter Projet : ";
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
            btnSave.Location = new Point(1022, 789);
            btnSave.Margin = new Padding(6);
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
            btnSave.Size = new Size(329, 122);
            btnSave.TabIndex = 58;
            btnSave.TextOffset = new Point(0, 0);
            btnSave.Click += btnSave_Click;
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
            btnCancel.Location = new Point(579, 789);
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
            btnCancel.Size = new Size(319, 122);
            btnCancel.TabIndex = 59;
            btnCancel.TextOffset = new Point(0, 0);
            btnCancel.Click += btnCancel_Click_1;
            // 
            // FormAddProject
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1925, 1066);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(panel1);
            Controls.Add(comboBoxManager);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(comboBoxStatus);
            Controls.Add(dateTimeStartDate);
            Controls.Add(dateTimeEndDate);
            Controls.Add(txtTitle);
            Controls.Add(txtDescription);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddProject";
            Load += FormAddProject_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private ComboBox cmbRole;
        private TextBox txtPhone;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private TextBox txtEmail;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label Title;
        private DateTimePicker dateTimeEndDate;
        private DateTimePicker dateTimeStartDate;
        private ComboBox comboBoxStatus;
        private Label label2;
        private Label label7;
        private Label label8;
        private ComboBox comboBoxManager;
        private Panel panel1;
        private Label lblFormTitle;
        private CuoreUI.Controls.cuiButton btnSave;
        private CuoreUI.Controls.cuiButton btnCancel;

        public object StartDate { get; private set; }
        public Label Description { get; private set; }
    }
}
namespace FatiIkhlassYoun.ChefEquipeFolder.hautePanel
{
    partial class ExporterTachesForm
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
            labelProjets = new Label();
            checkedListBoxProjets = new CheckedListBox();
            checkedListBoxStatuts = new CheckedListBox();
            label1 = new Label();
            label2 = new Label();
            dateDebutPicker = new DateTimePicker();
            dateFinPicker = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            btnExporter = new CuoreUI.Controls.cuiButton();
            cuiButton2 = new CuoreUI.Controls.cuiButton();
            panelHeader = new Panel();
            lblTitle = new Label();
            panelForm = new Panel();
            groupBoxFormat = new GroupBox();
            radioPDF = new RadioButton();
            radioCSV = new RadioButton();
            lblCommentaire = new Label();
            txtCommentaire = new TextBox();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            groupBoxFormat.SuspendLayout();
            SuspendLayout();
            // 
            // labelProjets
            // 
            labelProjets.AutoSize = true;
            labelProjets.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProjets.ForeColor = Color.FromArgb(64, 64, 64);
            labelProjets.Location = new Point(40, 70);
            labelProjets.Name = "labelProjets";
            labelProjets.Size = new Size(80, 25);
            labelProjets.TabIndex = 0;
            labelProjets.Text = "Projets :";
            // 
            // checkedListBoxProjets
            // 
            checkedListBoxProjets.BackColor = Color.WhiteSmoke;
            checkedListBoxProjets.BorderStyle = BorderStyle.None;
            checkedListBoxProjets.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBoxProjets.FormattingEnabled = true;
            checkedListBoxProjets.Location = new Point(40, 100);
            checkedListBoxProjets.Name = "checkedListBoxProjets";
            checkedListBoxProjets.Size = new Size(300, 112);
            checkedListBoxProjets.TabIndex = 1;
            // 
            // checkedListBoxStatuts
            // 
            checkedListBoxStatuts.BackColor = Color.WhiteSmoke;
            checkedListBoxStatuts.BorderStyle = BorderStyle.None;
            checkedListBoxStatuts.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBoxStatuts.FormattingEnabled = true;
            checkedListBoxStatuts.Location = new Point(40, 245);
            checkedListBoxStatuts.Name = "checkedListBoxStatuts";
            checkedListBoxStatuts.Size = new Size(300, 112);
            checkedListBoxStatuts.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(230, 20);
            label1.Name = "label1";
            label1.Size = new Size(230, 32);
            label1.TabIndex = 3;
            label1.Text = "Exporter les tâches";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(40, 215);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 4;
            label2.Text = "Statuts :";
            // 
            // dateDebutPicker
            // 
            dateDebutPicker.CalendarMonthBackground = Color.WhiteSmoke;
            dateDebutPicker.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateDebutPicker.Location = new Point(40, 399);
            dateDebutPicker.Name = "dateDebutPicker";
            dateDebutPicker.Size = new Size(300, 31);
            dateDebutPicker.TabIndex = 5;
            // 
            // dateFinPicker
            // 
            dateFinPicker.CalendarMonthBackground = Color.WhiteSmoke;
            dateFinPicker.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateFinPicker.Location = new Point(40, 469);
            dateFinPicker.Name = "dateFinPicker";
            dateFinPicker.Size = new Size(300, 31);
            dateFinPicker.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(40, 369);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 7;
            label3.Text = "Date de début :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(40, 439);
            label4.Name = "label4";
            label4.Size = new Size(113, 25);
            label4.TabIndex = 8;
            label4.Text = "Date de fin :";
            // 
            // btnExporter
            // 
            btnExporter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExporter.CheckButton = false;
            btnExporter.Checked = false;
            btnExporter.CheckedBackground = Color.FromArgb(40, 167, 69);
            btnExporter.CheckedForeColor = Color.White;
            btnExporter.CheckedImageTint = Color.White;
            btnExporter.CheckedOutline = Color.FromArgb(40, 167, 69);
            btnExporter.Content = "Exporter";
            btnExporter.Cursor = Cursors.Hand;
            btnExporter.DialogResult = DialogResult.None;
            btnExporter.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExporter.ForeColor = Color.White;
            btnExporter.HoverBackground = Color.FromArgb(33, 136, 56);
            btnExporter.HoveredImageTint = Color.White;
            btnExporter.HoverForeColor = Color.White;
            btnExporter.HoverOutline = Color.Empty;
            btnExporter.Image = null;
            btnExporter.ImageAutoCenter = true;
            btnExporter.ImageExpand = new Point(0, 0);
            btnExporter.ImageOffset = new Point(0, 0);
            btnExporter.Location = new Point(496, 538);
            btnExporter.Name = "btnExporter";
            btnExporter.NormalBackground = Color.FromArgb(40, 167, 69);
            btnExporter.NormalForeColor = Color.White;
            btnExporter.NormalImageTint = Color.White;
            btnExporter.NormalOutline = Color.Empty;
            btnExporter.OutlineThickness = 1.6F;
            btnExporter.PressedBackground = Color.FromArgb(43, 168, 75);
            btnExporter.PressedForeColor = Color.White;
            btnExporter.PressedImageTint = Color.White;
            btnExporter.PressedOutline = Color.Empty;
            btnExporter.Rounding = new Padding(8);
            btnExporter.Size = new Size(155, 70);
            btnExporter.TabIndex = 20;
            btnExporter.TextOffset = new Point(0, 0);
            btnExporter.Click += btnExporter_Click;
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
            cuiButton2.Location = new Point(305, 538);
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
            cuiButton2.Size = new Size(155, 70);
            cuiButton2.TabIndex = 21;
            cuiButton2.TextOffset = new Point(0, 0);
            cuiButton2.Click += cuiButton2_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(51, 51, 76);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(700, 60);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(217, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Exporter Tâches";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(label1);
            panelForm.Controls.Add(labelProjets);
            panelForm.Controls.Add(checkedListBoxProjets);
            panelForm.Controls.Add(checkedListBoxStatuts);
            panelForm.Controls.Add(label2);
            panelForm.Controls.Add(dateDebutPicker);
            panelForm.Controls.Add(dateFinPicker);
            panelForm.Controls.Add(label3);
            panelForm.Controls.Add(label4);
            panelForm.Controls.Add(groupBoxFormat);
            panelForm.Controls.Add(lblCommentaire);
            panelForm.Controls.Add(txtCommentaire);
            panelForm.Controls.Add(btnExporter);
            panelForm.Controls.Add(cuiButton2);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 60);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(20);
            panelForm.Size = new Size(700, 640);
            panelForm.TabIndex = 1;
            // 
            // groupBoxFormat
            // 
            groupBoxFormat.Controls.Add(radioPDF);
            groupBoxFormat.Controls.Add(radioCSV);
            groupBoxFormat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxFormat.ForeColor = Color.FromArgb(64, 64, 64);
            groupBoxFormat.Location = new Point(371, 70);
            groupBoxFormat.Name = "groupBoxFormat";
            groupBoxFormat.Size = new Size(280, 142);
            groupBoxFormat.TabIndex = 22;
            groupBoxFormat.TabStop = false;
            groupBoxFormat.Text = "Format d'export";
            // 
            // radioPDF
            // 
            radioPDF.AutoSize = true;
            radioPDF.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioPDF.Location = new Point(20, 81);
            radioPDF.Name = "radioPDF";
            radioPDF.Size = new Size(223, 29);
            radioPDF.TabIndex = 1;
            radioPDF.Text = "PDF (Rapport structuré)";
            radioPDF.UseVisualStyleBackColor = true;
            radioPDF.CheckedChanged += RadioFormat_CheckedChanged;
            // 
            // radioCSV
            // 
            radioCSV.AutoSize = true;
            radioCSV.Checked = true;
            radioCSV.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioCSV.Location = new Point(20, 30);
            radioCSV.Name = "radioCSV";
            radioCSV.Size = new Size(122, 29);
            radioCSV.TabIndex = 0;
            radioCSV.TabStop = true;
            radioCSV.Text = "CSV (Excel)";
            radioCSV.UseVisualStyleBackColor = true;
            radioCSV.CheckedChanged += RadioFormat_CheckedChanged;
            // 
            // lblCommentaire
            // 
            lblCommentaire.AutoSize = true;
            lblCommentaire.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCommentaire.ForeColor = Color.FromArgb(64, 64, 64);
            lblCommentaire.Location = new Point(371, 215);
            lblCommentaire.Name = "lblCommentaire";
            lblCommentaire.Size = new Size(134, 25);
            lblCommentaire.TabIndex = 23;
            lblCommentaire.Text = "Commentaire :";
            lblCommentaire.Visible = false;
            // 
            // txtCommentaire
            // 
            txtCommentaire.BackColor = Color.WhiteSmoke;
            txtCommentaire.BorderStyle = BorderStyle.None;
            txtCommentaire.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCommentaire.Location = new Point(371, 245);
            txtCommentaire.Multiline = true;
            txtCommentaire.Name = "txtCommentaire";
            txtCommentaire.ScrollBars = ScrollBars.Vertical;
            txtCommentaire.Size = new Size(280, 219);
            txtCommentaire.TabIndex = 24;
            txtCommentaire.Visible = false;
            // 
            // ExporterTachesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 700);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ExporterTachesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExporterTachesForm";
            Load += ExporterTachesForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            groupBoxFormat.ResumeLayout(false);
            groupBoxFormat.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelProjets;
        private CheckedListBox checkedListBoxProjets;
        private CheckedListBox checkedListBoxStatuts;
        private Label label1;
        private Label label2;
        private DateTimePicker dateDebutPicker;
        private DateTimePicker dateFinPicker;
        private Label label3;
        private Label label4;
        private CuoreUI.Controls.cuiButton btnExporter;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelForm;
        private GroupBox groupBoxFormat;
        private RadioButton radioPDF;
        private RadioButton radioCSV;
        private Label lblCommentaire;
        private TextBox txtCommentaire;

        private void RadioFormat_CheckedChanged(object sender, EventArgs e)
        {
            bool isPDFSelected = radioPDF.Checked;
            lblCommentaire.Visible = isPDFSelected;
            txtCommentaire.Visible = isPDFSelected;

            // Ajustez la taille du formulaire si nécessaire
            this.ClientSize = new Size(700, isPDFSelected ? 750 : 700);
            panelForm.Height = isPDFSelected ? 690 : 640;
        }
    }
}
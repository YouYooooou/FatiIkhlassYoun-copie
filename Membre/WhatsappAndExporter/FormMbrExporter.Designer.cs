namespace FatiIkhlassYoun.membreFolder
{
    partial class FormMbrExporter
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            labelTitre = new Label();
            panelContenu = new Panel();
            textBoxCommentaire = new TextBox();
            labelCommentaire = new Label();
            groupBoxFormat = new GroupBox();
            radioButtonPDF = new RadioButton();
            radioButtonCSV = new RadioButton();
            btnAnnuler = new Button();
            btnExporter = new Button();
            btnSelectAllTasks = new Button();
            btnSelectAllTeams = new Button();
            dateTimePickerFin = new DateTimePicker();
            dateTimePickerDebut = new DateTimePicker();
            labelDateFin = new Label();
            labelDateDebut = new Label();
            checkedListBoxStatuts = new CheckedListBox();
            labelStatuts = new Label();
            checkedListBoxTaches = new CheckedListBox();
            labelTaches = new Label();
            checkedListBoxEquipes = new CheckedListBox();
            labelEquipes = new Label();
            panelHeader.SuspendLayout();
            panelContenu.SuspendLayout();
            groupBoxFormat.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(51, 51, 76);
            panelHeader.Controls.Add(labelTitre);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(889, 75);
            panelHeader.TabIndex = 0;
            // 
            // labelTitre
            // 
            labelTitre.AutoSize = true;
            labelTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitre.ForeColor = Color.White;
            labelTitre.Location = new Point(22, 19);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(224, 38);
            labelTitre.TabIndex = 0;
            labelTitre.Text = "Exporter Tâches";
            // 
            // panelContenu
            // 
            panelContenu.BackColor = Color.White;
            panelContenu.Controls.Add(textBoxCommentaire);
            panelContenu.Controls.Add(labelCommentaire);
            panelContenu.Controls.Add(groupBoxFormat);
            panelContenu.Controls.Add(btnAnnuler);
            panelContenu.Controls.Add(btnExporter);
            panelContenu.Controls.Add(btnSelectAllTasks);
            panelContenu.Controls.Add(btnSelectAllTeams);
            panelContenu.Controls.Add(dateTimePickerFin);
            panelContenu.Controls.Add(dateTimePickerDebut);
            panelContenu.Controls.Add(labelDateFin);
            panelContenu.Controls.Add(labelDateDebut);
            panelContenu.Controls.Add(checkedListBoxStatuts);
            panelContenu.Controls.Add(labelStatuts);
            panelContenu.Controls.Add(checkedListBoxTaches);
            panelContenu.Controls.Add(labelTaches);
            panelContenu.Controls.Add(checkedListBoxEquipes);
            panelContenu.Controls.Add(labelEquipes);
            panelContenu.Dock = DockStyle.Fill;
            panelContenu.Location = new Point(0, 75);
            panelContenu.Margin = new Padding(3, 4, 3, 4);
            panelContenu.Name = "panelContenu";
            panelContenu.Padding = new Padding(22, 25, 22, 25);
            panelContenu.Size = new Size(889, 800);
            panelContenu.TabIndex = 1;
            // 
            // textBoxCommentaire
            // 
            textBoxCommentaire.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxCommentaire.BackColor = Color.WhiteSmoke;
            textBoxCommentaire.BorderStyle = BorderStyle.None;
            textBoxCommentaire.Location = new Point(490, 282);
            textBoxCommentaire.Margin = new Padding(3, 4, 3, 4);
            textBoxCommentaire.Multiline = true;
            textBoxCommentaire.Name = "textBoxCommentaire";
            textBoxCommentaire.ScrollBars = ScrollBars.Vertical;
            textBoxCommentaire.Size = new Size(363, 368);
            textBoxCommentaire.TabIndex = 17;
            textBoxCommentaire.Visible = false;
            // 
            // labelCommentaire
            // 
            labelCommentaire.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCommentaire.AutoSize = true;
            labelCommentaire.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCommentaire.Location = new Point(490, 239);
            labelCommentaire.Name = "labelCommentaire";
            labelCommentaire.Size = new Size(136, 25);
            labelCommentaire.TabIndex = 16;
            labelCommentaire.Text = "Commentaire :";
            labelCommentaire.Visible = false;
            // 
            // groupBoxFormat
            // 
            groupBoxFormat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxFormat.Controls.Add(radioButtonPDF);
            groupBoxFormat.Controls.Add(radioButtonCSV);
            groupBoxFormat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxFormat.Location = new Point(490, 38);
            groupBoxFormat.Margin = new Padding(3, 4, 3, 4);
            groupBoxFormat.Name = "groupBoxFormat";
            groupBoxFormat.Padding = new Padding(3, 4, 3, 4);
            groupBoxFormat.Size = new Size(354, 162);
            groupBoxFormat.TabIndex = 15;
            groupBoxFormat.TabStop = false;
            groupBoxFormat.Text = "Format d'export";
            // 
            // radioButtonPDF
            // 
            radioButtonPDF.AutoSize = true;
            radioButtonPDF.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonPDF.Location = new Point(56, 99);
            radioButtonPDF.Margin = new Padding(3, 4, 3, 4);
            radioButtonPDF.Name = "radioButtonPDF";
            radioButtonPDF.Size = new Size(223, 29);
            radioButtonPDF.TabIndex = 1;
            radioButtonPDF.Text = "PDF (Rapport structuré)";
            radioButtonPDF.UseVisualStyleBackColor = true;
            radioButtonPDF.CheckedChanged += radioButtonFormat_CheckedChanged;
            // 
            // radioButtonCSV
            // 
            radioButtonCSV.AutoSize = true;
            radioButtonCSV.Checked = true;
            radioButtonCSV.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonCSV.Location = new Point(56, 37);
            radioButtonCSV.Margin = new Padding(3, 4, 3, 4);
            radioButtonCSV.Name = "radioButtonCSV";
            radioButtonCSV.Size = new Size(122, 29);
            radioButtonCSV.TabIndex = 0;
            radioButtonCSV.TabStop = true;
            radioButtonCSV.Text = "CSV (Excel)";
            radioButtonCSV.UseVisualStyleBackColor = true;
            radioButtonCSV.CheckedChanged += radioButtonFormat_CheckedChanged;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnnuler.BackColor = Color.FromArgb(223, 53, 69);
            btnAnnuler.FlatAppearance.BorderSize = 0;
            btnAnnuler.FlatStyle = FlatStyle.Flat;
            btnAnnuler.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnnuler.ForeColor = Color.White;
            btnAnnuler.Location = new Point(556, 688);
            btnAnnuler.Margin = new Padding(3, 4, 3, 4);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(133, 62);
            btnAnnuler.TabIndex = 14;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = false;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // btnExporter
            // 
            btnExporter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExporter.BackColor = Color.FromArgb(40, 167, 69);
            btnExporter.FlatAppearance.BorderSize = 0;
            btnExporter.FlatStyle = FlatStyle.Flat;
            btnExporter.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExporter.ForeColor = Color.White;
            btnExporter.Location = new Point(711, 688);
            btnExporter.Margin = new Padding(3, 4, 3, 4);
            btnExporter.Name = "btnExporter";
            btnExporter.Size = new Size(133, 62);
            btnExporter.TabIndex = 13;
            btnExporter.Text = "Exporter";
            btnExporter.UseVisualStyleBackColor = false;
            btnExporter.Click += btnExporter_Click;
            // 
            // btnSelectAllTasks
            // 
            btnSelectAllTasks.BackColor = Color.FromArgb(51, 51, 76);
            btnSelectAllTasks.FlatAppearance.BorderSize = 0;
            btnSelectAllTasks.FlatStyle = FlatStyle.Flat;
            btnSelectAllTasks.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelectAllTasks.ForeColor = Color.White;
            btnSelectAllTasks.Location = new Point(266, 343);
            btnSelectAllTasks.Margin = new Padding(3, 4, 3, 4);
            btnSelectAllTasks.Name = "btnSelectAllTasks";
            btnSelectAllTasks.Size = new Size(111, 38);
            btnSelectAllTasks.TabIndex = 12;
            btnSelectAllTasks.Text = "Tout cocher";
            btnSelectAllTasks.UseVisualStyleBackColor = false;
            btnSelectAllTasks.Click += btnSelectAllTasks_Click;
            // 
            // btnSelectAllTeams
            // 
            btnSelectAllTeams.BackColor = Color.FromArgb(51, 51, 76);
            btnSelectAllTeams.FlatAppearance.BorderSize = 0;
            btnSelectAllTeams.FlatStyle = FlatStyle.Flat;
            btnSelectAllTeams.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelectAllTeams.ForeColor = Color.White;
            btnSelectAllTeams.Location = new Point(266, 167);
            btnSelectAllTeams.Margin = new Padding(3, 4, 3, 4);
            btnSelectAllTeams.Name = "btnSelectAllTeams";
            btnSelectAllTeams.Size = new Size(111, 38);
            btnSelectAllTeams.TabIndex = 11;
            btnSelectAllTeams.Text = "Tout cocher";
            btnSelectAllTeams.UseVisualStyleBackColor = false;
            btnSelectAllTeams.Click += btnSelectAllTeams_Click;
            // 
            // dateTimePickerFin
            // 
            dateTimePickerFin.Location = new Point(44, 662);
            dateTimePickerFin.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerFin.Name = "dateTimePickerFin";
            dateTimePickerFin.Size = new Size(333, 31);
            dateTimePickerFin.TabIndex = 10;
            // 
            // dateTimePickerDebut
            // 
            dateTimePickerDebut.Location = new Point(44, 588);
            dateTimePickerDebut.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerDebut.Name = "dateTimePickerDebut";
            dateTimePickerDebut.Size = new Size(333, 31);
            dateTimePickerDebut.TabIndex = 9;
            // 
            // labelDateFin
            // 
            labelDateFin.AutoSize = true;
            labelDateFin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDateFin.Location = new Point(44, 625);
            labelDateFin.Name = "labelDateFin";
            labelDateFin.Size = new Size(116, 25);
            labelDateFin.TabIndex = 8;
            labelDateFin.Text = "Date de fin :";
            // 
            // labelDateDebut
            // 
            labelDateDebut.AutoSize = true;
            labelDateDebut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDateDebut.Location = new Point(44, 550);
            labelDateDebut.Name = "labelDateDebut";
            labelDateDebut.Size = new Size(143, 25);
            labelDateDebut.TabIndex = 7;
            labelDateDebut.Text = "Date de début :";
            // 
            // checkedListBoxStatuts
            // 
            checkedListBoxStatuts.BackColor = Color.WhiteSmoke;
            checkedListBoxStatuts.BorderStyle = BorderStyle.None;
            checkedListBoxStatuts.FormattingEnabled = true;
            checkedListBoxStatuts.Location = new Point(44, 430);
            checkedListBoxStatuts.Margin = new Padding(3, 4, 3, 4);
            checkedListBoxStatuts.Name = "checkedListBoxStatuts";
            checkedListBoxStatuts.Size = new Size(333, 84);
            checkedListBoxStatuts.TabIndex = 6;
            // 
            // labelStatuts
            // 
            labelStatuts.AutoSize = true;
            labelStatuts.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStatuts.Location = new Point(44, 392);
            labelStatuts.Name = "labelStatuts";
            labelStatuts.Size = new Size(82, 25);
            labelStatuts.TabIndex = 5;
            labelStatuts.Text = "Statuts :";
            // 
            // checkedListBoxTaches
            // 
            checkedListBoxTaches.BackColor = Color.WhiteSmoke;
            checkedListBoxTaches.BorderStyle = BorderStyle.None;
            checkedListBoxTaches.FormattingEnabled = true;
            checkedListBoxTaches.Location = new Point(44, 251);
            checkedListBoxTaches.Margin = new Padding(3, 4, 3, 4);
            checkedListBoxTaches.Name = "checkedListBoxTaches";
            checkedListBoxTaches.Size = new Size(333, 84);
            checkedListBoxTaches.TabIndex = 4;
            // 
            // labelTaches
            // 
            labelTaches.AutoSize = true;
            labelTaches.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTaches.Location = new Point(44, 213);
            labelTaches.Name = "labelTaches";
            labelTaches.Size = new Size(79, 25);
            labelTaches.TabIndex = 3;
            labelTaches.Text = "Tâches :";
            // 
            // checkedListBoxEquipes
            // 
            checkedListBoxEquipes.BackColor = Color.WhiteSmoke;
            checkedListBoxEquipes.BorderStyle = BorderStyle.None;
            checkedListBoxEquipes.FormattingEnabled = true;
            checkedListBoxEquipes.Location = new Point(44, 75);
            checkedListBoxEquipes.Margin = new Padding(3, 4, 3, 4);
            checkedListBoxEquipes.Name = "checkedListBoxEquipes";
            checkedListBoxEquipes.Size = new Size(333, 84);
            checkedListBoxEquipes.TabIndex = 2;
            checkedListBoxEquipes.ItemCheck += checkedListBoxEquipes_ItemCheck;
            // 
            // labelEquipes
            // 
            labelEquipes.AutoSize = true;
            labelEquipes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEquipes.Location = new Point(44, 38);
            labelEquipes.Name = "labelEquipes";
            labelEquipes.Size = new Size(88, 25);
            labelEquipes.TabIndex = 1;
            labelEquipes.Text = "Équipes :";
            // 
            // FormMbrExporter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 875);
            Controls.Add(panelContenu);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMbrExporter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMbrExporter";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContenu.ResumeLayout(false);
            panelContenu.PerformLayout();
            groupBoxFormat.ResumeLayout(false);
            groupBoxFormat.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Panel panelContenu;
        private System.Windows.Forms.Label labelEquipes;
        private System.Windows.Forms.CheckedListBox checkedListBoxEquipes;
        private System.Windows.Forms.CheckedListBox checkedListBoxTaches;
        private System.Windows.Forms.Label labelTaches;
        private System.Windows.Forms.CheckedListBox checkedListBoxStatuts;
        private System.Windows.Forms.Label labelStatuts;
        private System.Windows.Forms.Label labelDateDebut;
        private System.Windows.Forms.Label labelDateFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerDebut;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.Button btnSelectAllTeams;
        private System.Windows.Forms.Button btnSelectAllTasks;
        private System.Windows.Forms.Button btnExporter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.GroupBox groupBoxFormat;
        private System.Windows.Forms.RadioButton radioButtonPDF;
        private System.Windows.Forms.RadioButton radioButtonCSV;
        private System.Windows.Forms.Label labelCommentaire;
        private System.Windows.Forms.TextBox textBoxCommentaire;
    }
}
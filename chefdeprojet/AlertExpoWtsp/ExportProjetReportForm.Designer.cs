namespace ProjectManagementSystem.ChefProjetFolder.Reports
{
    partial class ExportProjetReportForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageParametres = new System.Windows.Forms.TabPage();
            this.checkAllProjects = new System.Windows.Forms.CheckBox();
            this.checkAllStatus = new System.Windows.Forms.CheckBox();
            this.groupBoxCommentaire = new System.Windows.Forms.GroupBox();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.groupBoxFormat = new System.Windows.Forms.GroupBox();
            this.radioPDF = new System.Windows.Forms.RadioButton();
            this.radioCSV = new System.Windows.Forms.RadioButton();
            this.groupBoxStatuts = new System.Windows.Forms.GroupBox();
            this.checkedListBoxStatuts = new System.Windows.Forms.CheckedListBox();
            this.groupBoxProjets = new System.Windows.Forms.GroupBox();
            this.checkedListBoxProjets = new System.Windows.Forms.CheckedListBox();
            this.groupBoxPeriode = new System.Windows.Forms.GroupBox();
            this.dateFinPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateDebutPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageApercu = new System.Windows.Forms.TabPage();
            this.dataGridPreview = new System.Windows.Forms.DataGridView();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnExporter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.labelTitre = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPageParametres.SuspendLayout();
            this.groupBoxCommentaire.SuspendLayout();
            this.groupBoxFormat.SuspendLayout();
            this.groupBoxStatuts.SuspendLayout();
            this.groupBoxProjets.SuspendLayout();
            this.groupBoxPeriode.SuspendLayout();
            this.tabPageApercu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPreview)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageParametres);
            this.tabControl1.Controls.Add(this.tabPageApercu);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 52);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 977);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageParametres
            // 
            this.tabPageParametres.Controls.Add(this.checkAllProjects);
            this.tabPageParametres.Controls.Add(this.checkAllStatus);
            this.tabPageParametres.Controls.Add(this.groupBoxCommentaire);
            this.tabPageParametres.Controls.Add(this.groupBoxFormat);
            this.tabPageParametres.Controls.Add(this.groupBoxStatuts);
            this.tabPageParametres.Controls.Add(this.groupBoxProjets);
            this.tabPageParametres.Controls.Add(this.groupBoxPeriode);
            this.tabPageParametres.Location = new System.Drawing.Point(4, 29);
            this.tabPageParametres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageParametres.Name = "tabPageParametres";
            this.tabPageParametres.Padding = new System.Windows.Forms.Padding(15);
            this.tabPageParametres.Size = new System.Drawing.Size(1192, 944);
            this.tabPageParametres.TabIndex = 0;
            this.tabPageParametres.Text = "Paramètres";
            this.tabPageParametres.UseVisualStyleBackColor = true;
            // 
            // checkAllProjects
            // 
            this.checkAllProjects.AutoSize = true;
            this.checkAllProjects.Checked = true;
            this.checkAllProjects.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAllProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAllProjects.Location = new System.Drawing.Point(28, 115);
            this.checkAllProjects.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkAllProjects.Name = "checkAllProjects";
            this.checkAllProjects.Size = new System.Drawing.Size(164, 24);
            this.checkAllProjects.TabIndex = 1;
            this.checkAllProjects.Text = "Tout sélectionner";
            this.checkAllProjects.UseVisualStyleBackColor = true;
            this.checkAllProjects.CheckedChanged += new System.EventHandler(this.CheckAllProjects_CheckedChanged);
            // 
            // checkAllStatus
            // 
            this.checkAllStatus.AutoSize = true;
            this.checkAllStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAllStatus.Location = new System.Drawing.Point(28, 309);
            this.checkAllStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkAllStatus.Name = "checkAllStatus";
            this.checkAllStatus.Size = new System.Drawing.Size(164, 24);
            this.checkAllStatus.TabIndex = 1;
            this.checkAllStatus.Text = "Tout sélectionner";
            this.checkAllStatus.UseVisualStyleBackColor = true;
            this.checkAllStatus.CheckedChanged += new System.EventHandler(this.CheckAllStatus_CheckedChanged);
            // 
            // groupBoxCommentaire
            // 
            this.groupBoxCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCommentaire.Controls.Add(this.txtCommentaire);
            this.groupBoxCommentaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCommentaire.Location = new System.Drawing.Point(24, 630);
            this.groupBoxCommentaire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxCommentaire.Name = "groupBoxCommentaire";
            this.groupBoxCommentaire.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxCommentaire.Size = new System.Drawing.Size(1149, 185);
            this.groupBoxCommentaire.TabIndex = 4;
            this.groupBoxCommentaire.TabStop = false;
            this.groupBoxCommentaire.Text = "Commentaire (optionnel)";
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCommentaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentaire.Location = new System.Drawing.Point(4, 24);
            this.txtCommentaire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCommentaire.Multiline = true;
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCommentaire.Size = new System.Drawing.Size(1141, 156);
            this.txtCommentaire.TabIndex = 0;
            // 
            // groupBoxFormat
            // 
            this.groupBoxFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFormat.Controls.Add(this.radioPDF);
            this.groupBoxFormat.Controls.Add(this.radioCSV);
            this.groupBoxFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFormat.Location = new System.Drawing.Point(20, 515);
            this.groupBoxFormat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFormat.Name = "groupBoxFormat";
            this.groupBoxFormat.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFormat.Size = new System.Drawing.Size(1149, 83);
            this.groupBoxFormat.TabIndex = 3;
            this.groupBoxFormat.TabStop = false;
            this.groupBoxFormat.Text = "Format d\'export";
            // 
            // radioPDF
            // 
            this.radioPDF.AutoSize = true;
            this.radioPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPDF.Location = new System.Drawing.Point(180, 29);
            this.radioPDF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioPDF.Name = "radioPDF";
            this.radioPDF.Size = new System.Drawing.Size(68, 24);
            this.radioPDF.TabIndex = 1;
            this.radioPDF.Text = "PDF";
            this.radioPDF.UseVisualStyleBackColor = true;
            // 
            // radioCSV
            // 
            this.radioCSV.AutoSize = true;
            this.radioCSV.Checked = true;
            this.radioCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCSV.Location = new System.Drawing.Point(30, 29);
            this.radioCSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioCSV.Name = "radioCSV";
            this.radioCSV.Size = new System.Drawing.Size(68, 24);
            this.radioCSV.TabIndex = 0;
            this.radioCSV.TabStop = true;
            this.radioCSV.Text = "CSV";
            this.radioCSV.UseVisualStyleBackColor = true;
            // 
            // groupBoxStatuts
            // 
            this.groupBoxStatuts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStatuts.Controls.Add(this.checkedListBoxStatuts);
            this.groupBoxStatuts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStatuts.Location = new System.Drawing.Point(20, 343);
            this.groupBoxStatuts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxStatuts.Name = "groupBoxStatuts";
            this.groupBoxStatuts.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxStatuts.Size = new System.Drawing.Size(1149, 145);
            this.groupBoxStatuts.TabIndex = 2;
            this.groupBoxStatuts.TabStop = false;
            this.groupBoxStatuts.Text = "Statuts des tâches";
            // 
            // checkedListBoxStatuts
            // 
            this.checkedListBoxStatuts.CheckOnClick = true;
            this.checkedListBoxStatuts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkedListBoxStatuts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxStatuts.FormattingEnabled = true;
            this.checkedListBoxStatuts.Location = new System.Drawing.Point(4, 44);
            this.checkedListBoxStatuts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkedListBoxStatuts.Name = "checkedListBoxStatuts";
            this.checkedListBoxStatuts.Size = new System.Drawing.Size(1141, 96);
            this.checkedListBoxStatuts.TabIndex = 0;
            // 
            // groupBoxProjets
            // 
            this.groupBoxProjets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxProjets.Controls.Add(this.checkedListBoxProjets);
            this.groupBoxProjets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProjets.Location = new System.Drawing.Point(16, 154);
            this.groupBoxProjets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxProjets.Name = "groupBoxProjets";
            this.groupBoxProjets.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxProjets.Size = new System.Drawing.Size(1149, 145);
            this.groupBoxProjets.TabIndex = 1;
            this.groupBoxProjets.TabStop = false;
            this.groupBoxProjets.Text = "Projets";
            // 
            // checkedListBoxProjets
            // 
            this.checkedListBoxProjets.CheckOnClick = true;
            this.checkedListBoxProjets.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkedListBoxProjets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxProjets.FormattingEnabled = true;
            this.checkedListBoxProjets.Location = new System.Drawing.Point(4, 44);
            this.checkedListBoxProjets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkedListBoxProjets.Name = "checkedListBoxProjets";
            this.checkedListBoxProjets.Size = new System.Drawing.Size(1141, 96);
            this.checkedListBoxProjets.TabIndex = 0;
            // 
            // groupBoxPeriode
            // 
            this.groupBoxPeriode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPeriode.Controls.Add(this.dateFinPicker);
            this.groupBoxPeriode.Controls.Add(this.label2);
            this.groupBoxPeriode.Controls.Add(this.dateDebutPicker);
            this.groupBoxPeriode.Controls.Add(this.label1);
            this.groupBoxPeriode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPeriode.Location = new System.Drawing.Point(20, 20);
            this.groupBoxPeriode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxPeriode.Name = "groupBoxPeriode";
            this.groupBoxPeriode.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxPeriode.Size = new System.Drawing.Size(1149, 85);
            this.groupBoxPeriode.TabIndex = 0;
            this.groupBoxPeriode.TabStop = false;
            this.groupBoxPeriode.Text = "Période";
            // 
            // dateFinPicker
            // 
            this.dateFinPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFinPicker.Location = new System.Drawing.Point(705, 29);
            this.dateFinPicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateFinPicker.Name = "dateFinPicker";
            this.dateFinPicker.Size = new System.Drawing.Size(298, 26);
            this.dateFinPicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(600, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date de fin :";
            // 
            // dateDebutPicker
            // 
            this.dateDebutPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDebutPicker.Location = new System.Drawing.Point(180, 29);
            this.dateDebutPicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateDebutPicker.Name = "dateDebutPicker";
            this.dateDebutPicker.Size = new System.Drawing.Size(298, 26);
            this.dateDebutPicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date de début :";
            // 
            // tabPageApercu
            // 
            this.tabPageApercu.Controls.Add(this.dataGridPreview);
            this.tabPageApercu.Location = new System.Drawing.Point(4, 29);
            this.tabPageApercu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageApercu.Name = "tabPageApercu";
            this.tabPageApercu.Padding = new System.Windows.Forms.Padding(15);
            this.tabPageApercu.Size = new System.Drawing.Size(1192, 844);
            this.tabPageApercu.TabIndex = 1;
            this.tabPageApercu.Text = "Aperçu";
            this.tabPageApercu.UseVisualStyleBackColor = true;
            // 
            // dataGridPreview
            // 
            this.dataGridPreview.AllowUserToAddRows = false;
            this.dataGridPreview.AllowUserToDeleteRows = false;
            this.dataGridPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPreview.BackgroundColor = System.Drawing.Color.White;
            this.dataGridPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridPreview.Location = new System.Drawing.Point(15, 15);
            this.dataGridPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridPreview.Name = "dataGridPreview";
            this.dataGridPreview.ReadOnly = true;
            this.dataGridPreview.RowHeadersWidth = 62;
            this.dataGridPreview.Size = new System.Drawing.Size(1162, 814);
            this.dataGridPreview.TabIndex = 0;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelFooter.Controls.Add(this.btnExporter);
            this.panelFooter.Controls.Add(this.btnAnnuler);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 1029);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1200, 77);
            this.panelFooter.TabIndex = 2;
            // 
            // btnExporter
            // 
            this.btnExporter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExporter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnExporter.FlatAppearance.BorderSize = 0;
            this.btnExporter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExporter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExporter.ForeColor = System.Drawing.Color.White;
            this.btnExporter.Location = new System.Drawing.Point(975, 15);
            this.btnExporter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExporter.Name = "btnExporter";
            this.btnExporter.Size = new System.Drawing.Size(180, 46);
            this.btnExporter.TabIndex = 1;
            this.btnExporter.Text = "Exporter";
            this.btnExporter.UseVisualStyleBackColor = false;
            this.btnExporter.Click += new System.EventHandler(this.btnExporter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(780, 15);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(180, 46);
            this.btnAnnuler.TabIndex = 0;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.White;
            this.labelTitre.Location = new System.Drawing.Point(4, 9);
            this.labelTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(195, 32);
            this.labelTitre.TabIndex = 1;
            this.labelTitre.Text = "Exporter Taches";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelHeader.Controls.Add(this.labelTitre);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1200, 52);
            this.panelHeader.TabIndex = 0;
            // 
            // ExportProjetReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 1106);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ExportProjetReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exporter Rapport Projet";
            this.tabControl1.ResumeLayout(false);
            this.tabPageParametres.ResumeLayout(false);
            this.tabPageParametres.PerformLayout();
            this.groupBoxCommentaire.ResumeLayout(false);
            this.groupBoxCommentaire.PerformLayout();
            this.groupBoxFormat.ResumeLayout(false);
            this.groupBoxFormat.PerformLayout();
            this.groupBoxStatuts.ResumeLayout(false);
            this.groupBoxProjets.ResumeLayout(false);
            this.groupBoxPeriode.ResumeLayout(false);
            this.groupBoxPeriode.PerformLayout();
            this.tabPageApercu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPreview)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageParametres;
        private System.Windows.Forms.GroupBox groupBoxCommentaire;
        private System.Windows.Forms.TextBox txtCommentaire;
        private System.Windows.Forms.GroupBox groupBoxFormat;
        private System.Windows.Forms.RadioButton radioPDF;
        private System.Windows.Forms.RadioButton radioCSV;
        private System.Windows.Forms.GroupBox groupBoxStatuts;
        private System.Windows.Forms.CheckBox checkAllStatus;
        private System.Windows.Forms.CheckedListBox checkedListBoxStatuts;
        private System.Windows.Forms.GroupBox groupBoxProjets;
        private System.Windows.Forms.CheckBox checkAllProjects;
        private System.Windows.Forms.CheckedListBox checkedListBoxProjets;
        private System.Windows.Forms.GroupBox groupBoxPeriode;
        private System.Windows.Forms.DateTimePicker dateFinPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateDebutPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageApercu;
        private System.Windows.Forms.DataGridView dataGridPreview;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnExporter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Panel panelHeader;
    }
}
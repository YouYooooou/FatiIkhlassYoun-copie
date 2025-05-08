namespace FatiIkhlassYoun.membreFolder
{
    partial class ctrlMembre
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            splitContainerMain = new SplitContainer();
            dataGridViewTaches = new DataGridView();
            panelRight = new Panel();
            panelTeamProgress = new FlowLayoutPanel();
            groupBoxStats = new GroupBox();
            labelTachesTerminees = new Label();
            labelTachesEnCours = new Label();
            labelTacheEnAttende = new Label();
            labelEquipes = new Label();
            panelHeader = new Panel();
            labelTitre = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaches).BeginInit();
            panelRight.SuspendLayout();
            groupBoxStats.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainerMain
            // 
            splitContainerMain.Dock = DockStyle.Fill;
            splitContainerMain.FixedPanel = FixedPanel.Panel2;
            splitContainerMain.Location = new Point(0, 0);
            splitContainerMain.Margin = new Padding(3, 4, 3, 4);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.Controls.Add(dataGridViewTaches);
            splitContainerMain.Panel1.Padding = new Padding(11, 12, 11, 12);
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.Controls.Add(panelRight);
            splitContainerMain.Size = new Size(1333, 812);
            splitContainerMain.SplitterDistance = 889;
            splitContainerMain.TabIndex = 0;
            // 
            // dataGridViewTaches
            // 
            dataGridViewTaches.AllowUserToAddRows = false;
            dataGridViewTaches.AllowUserToDeleteRows = false;
            dataGridViewTaches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTaches.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewTaches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTaches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewTaches.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTaches.Dock = DockStyle.Fill;
            dataGridViewTaches.Location = new Point(11, 12);
            dataGridViewTaches.Margin = new Padding(3, 4, 3, 4);
            dataGridViewTaches.Name = "dataGridViewTaches";
            dataGridViewTaches.ReadOnly = true;
            dataGridViewTaches.RowHeadersVisible = false;
            dataGridViewTaches.RowHeadersWidth = 62;
            dataGridViewTaches.Size = new Size(867, 788);
            dataGridViewTaches.TabIndex = 0;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(panelTeamProgress);
            panelRight.Controls.Add(groupBoxStats);
            panelRight.Controls.Add(panelHeader);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(0, 0);
            panelRight.Margin = new Padding(3, 4, 3, 4);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(11, 12, 11, 12);
            panelRight.Size = new Size(440, 812);
            panelRight.TabIndex = 0;
            // 
            // panelTeamProgress
            // 
            panelTeamProgress.AutoScroll = true;
            panelTeamProgress.BackColor = Color.WhiteSmoke;
            panelTeamProgress.Dock = DockStyle.Fill;
            panelTeamProgress.Location = new Point(11, 276);
            panelTeamProgress.Margin = new Padding(3, 4, 3, 4);
            panelTeamProgress.Name = "panelTeamProgress";
            panelTeamProgress.Padding = new Padding(0, 12, 0, 0);
            panelTeamProgress.Size = new Size(418, 524);
            panelTeamProgress.TabIndex = 2;
            // 
            // groupBoxStats
            // 
            groupBoxStats.Controls.Add(labelTachesTerminees);
            groupBoxStats.Controls.Add(labelTachesEnCours);
            groupBoxStats.Controls.Add(labelTacheEnAttende);
            groupBoxStats.Controls.Add(labelEquipes);
            groupBoxStats.Dock = DockStyle.Top;
            groupBoxStats.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxStats.Location = new Point(11, 137);
            groupBoxStats.Margin = new Padding(3, 4, 3, 4);
            groupBoxStats.Name = "groupBoxStats";
            groupBoxStats.Padding = new Padding(3, 4, 3, 4);
            groupBoxStats.Size = new Size(418, 139);
            groupBoxStats.TabIndex = 1;
            groupBoxStats.TabStop = false;
            groupBoxStats.Text = "Statistiques Globales";
            // 
            // labelTachesTerminees
            // 
            labelTachesTerminees.AutoSize = true;
            labelTachesTerminees.Font = new Font("Segoe UI", 10F);
            labelTachesTerminees.Location = new Point(22, 50);
            labelTachesTerminees.Name = "labelTachesTerminees";
            labelTachesTerminees.Size = new Size(183, 28);
            labelTachesTerminees.TabIndex = 0;
            labelTachesTerminees.Text = "Tâches terminées : 0";
            // 
            // labelTachesEnCours
            // 
            labelTachesEnCours.AutoSize = true;
            labelTachesEnCours.Font = new Font("Segoe UI", 10F);
            labelTachesEnCours.Location = new Point(226, 50);
            labelTachesEnCours.Name = "labelTachesEnCours";
            labelTachesEnCours.Size = new Size(171, 28);
            labelTachesEnCours.TabIndex = 1;
            labelTachesEnCours.Text = "Tâches en cours : 0";
            // 
            // labelTacheEnAttende
            // 
            labelTacheEnAttende.AutoSize = true;
            labelTacheEnAttende.Font = new Font("Segoe UI", 10F);
            labelTacheEnAttende.Location = new Point(19, 92);
            labelTacheEnAttende.Name = "labelTacheEnAttende";
            labelTacheEnAttende.Size = new Size(186, 28);
            labelTacheEnAttende.TabIndex = 2;
            labelTacheEnAttende.Text = "Tâches en attente : 0";
            // 
            // labelEquipes
            // 
            labelEquipes.AutoSize = true;
            labelEquipes.Font = new Font("Segoe UI", 10F);
            labelEquipes.Location = new Point(227, 92);
            labelEquipes.Name = "labelEquipes";
            labelEquipes.Size = new Size(105, 28);
            labelEquipes.TabIndex = 3;
            labelEquipes.Text = "Équipes : 0";
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(labelTitre);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(11, 12);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(418, 125);
            panelHeader.TabIndex = 0;
            // 
            // labelTitre
            // 
            labelTitre.AutoSize = true;
            labelTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitre.Location = new Point(89, 38);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(243, 38);
            labelTitre.TabIndex = 0;
            labelTitre.Text = "Équipe Principale";
            // 
            // ctrlMembre
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainerMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ctrlMembre";
            Size = new Size(1333, 812);
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaches).EndInit();
            panelRight.ResumeLayout(false);
            groupBoxStats.ResumeLayout(false);
            groupBoxStats.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.DataGridView dataGridViewTaches;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.GroupBox groupBoxStats;
        private System.Windows.Forms.Label labelTachesTerminees;
        private System.Windows.Forms.Label labelTachesEnCours;
        private System.Windows.Forms.Label labelTacheEnAttende;
        private System.Windows.Forms.Label labelEquipes;
        private System.Windows.Forms.FlowLayoutPanel panelTeamProgress;
        private System.Windows.Forms.Panel panelHeader;
    }
}
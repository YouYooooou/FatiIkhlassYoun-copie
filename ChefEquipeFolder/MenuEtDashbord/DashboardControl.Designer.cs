namespace FatiIkhlassYoun
{
    partial class DashboardControl
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
            labelTitre = new Label();
            groupBoxStats = new GroupBox();
            labelEquipes = new Label();
            labelMembresActifs = new Label();
            labelTachesEnCours = new Label();
            labelTachesTerminees = new Label();
            dataGridViewTaches = new DataGridView();
            groupBoxStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaches).BeginInit();
            SuspendLayout();
            // 
            // labelTitre
            // 
            labelTitre.AutoSize = true;
            labelTitre.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitre.Location = new Point(249, 18);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(290, 48);
            labelTitre.TabIndex = 0;
            labelTitre.Text = "Tableau de bord";
            labelTitre.Click += labelTitre_Click;
            // 
            // groupBoxStats
            // 
            groupBoxStats.AutoSize = true;
            groupBoxStats.Controls.Add(labelEquipes);
            groupBoxStats.Controls.Add(labelMembresActifs);
            groupBoxStats.Controls.Add(labelTachesEnCours);
            groupBoxStats.Controls.Add(labelTachesTerminees);
            groupBoxStats.Enabled = false;
            groupBoxStats.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxStats.Location = new Point(78, 152);
            groupBoxStats.Name = "groupBoxStats";
            groupBoxStats.Size = new Size(578, 143);
            groupBoxStats.TabIndex = 1;
            groupBoxStats.TabStop = false;
            groupBoxStats.Text = "Statistiques";
            groupBoxStats.Enter += groupBoxStats_Enter;
            // 
            // labelEquipes
            // 
            labelEquipes.AutoSize = true;
            labelEquipes.Font = new Font("Segoe UI", 10F);
            labelEquipes.Location = new Point(389, 80);
            labelEquipes.Name = "labelEquipes";
            labelEquipes.Size = new Size(105, 28);
            labelEquipes.TabIndex = 3;
            labelEquipes.Text = "Équipes : 0";
            // 
            // labelMembresActifs
            // 
            labelMembresActifs.AutoSize = true;
            labelMembresActifs.Font = new Font("Segoe UI", 10F);
            labelMembresActifs.Location = new Point(24, 80);
            labelMembresActifs.Name = "labelMembresActifs";
            labelMembresActifs.Size = new Size(191, 28);
            labelMembresActifs.TabIndex = 2;
            labelMembresActifs.Text = "Tâches en attende : 0";
            // 
            // labelTachesEnCours
            // 
            labelTachesEnCours.AutoSize = true;
            labelTachesEnCours.Font = new Font("Segoe UI", 10F);
            labelTachesEnCours.Location = new Point(389, 27);
            labelTachesEnCours.Name = "labelTachesEnCours";
            labelTachesEnCours.Size = new Size(171, 28);
            labelTachesEnCours.TabIndex = 1;
            labelTachesEnCours.Text = "Tâches en cours : 0";
            labelTachesEnCours.Click += labelTachesEnCours_Click;
            // 
            // labelTachesTerminees
            // 
            labelTachesTerminees.AutoSize = true;
            labelTachesTerminees.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTachesTerminees.Location = new Point(24, 27);
            labelTachesTerminees.Name = "labelTachesTerminees";
            labelTachesTerminees.Size = new Size(183, 28);
            labelTachesTerminees.TabIndex = 0;
            labelTachesTerminees.Text = "Tâches terminées : 0";
            // 
            // dataGridViewTaches
            // 
            dataGridViewTaches.AllowUserToAddRows = false;
            dataGridViewTaches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTaches.Location = new Point(38, 322);
            dataGridViewTaches.Name = "dataGridViewTaches";
            dataGridViewTaches.ReadOnly = true;
            dataGridViewTaches.RowHeadersWidth = 62;
            dataGridViewTaches.Size = new Size(693, 231);
            dataGridViewTaches.TabIndex = 2;
            dataGridViewTaches.CellContentClick += dataGridViewTaches_CellContentClick;
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewTaches);
            Controls.Add(groupBoxStats);
            Controls.Add(labelTitre);
            Name = "DashboardControl";
            Size = new Size(766, 673);
            Load += DashboardControl_Load;
            groupBoxStats.ResumeLayout(false);
            groupBoxStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaches).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitre;
        private GroupBox groupBoxStats;
        private Label labelEquipes;
        private Label labelMembresActifs;
        private Label labelTachesEnCours;
        private Label labelTachesTerminees;
        private DataGridView dataGridViewTaches;
    }
}

namespace FatiIkhlassYoun.membreFolder
{
    partial class ctrlMbrMembresequipes
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
            this.dataGridViewTeams = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTeams
            // 
            this.dataGridViewTeams.AllowUserToAddRows = false;
            this.dataGridViewTeams.AllowUserToDeleteRows = false;
            this.dataGridViewTeams.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTeams.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTeams.Name = "dataGridViewTeams";
            this.dataGridViewTeams.ReadOnly = true;
            this.dataGridViewTeams.RowHeadersVisible = false;
            this.dataGridViewTeams.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewTeams.TabIndex = 0;
            // 
            // ctrlMbrMembresequipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewTeams);
            this.Name = "ctrlMbrMembresequipes";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeams)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewTeams;

    }
}

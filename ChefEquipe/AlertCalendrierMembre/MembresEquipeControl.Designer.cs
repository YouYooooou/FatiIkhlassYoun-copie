namespace FatiIkhlassYoun
{
    partial class MembresEquipeControl
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

            this.dataGridViewMembres = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembres)).BeginInit();
            this.SuspendLayout();

            // dataGridViewMembres
            this.dataGridViewMembres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMembres.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMembres.Name = "dataGridViewMembres";
            this.dataGridViewMembres.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewMembres.TabIndex = 0;

            // MembresEquipeControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewMembres);
            this.Name = "MembresEquipeControl";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembres)).EndInit();
            this.ResumeLayout(false);
        }


        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMembres;
    }
}

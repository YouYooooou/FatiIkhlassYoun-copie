namespace FatiIkhlassYoun.MemberEquipeFolder.hautePanel
{
    partial class AlertControlMember
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
            this.dataGridViewAlerts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlerts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAlerts
            // 
            this.dataGridViewAlerts.AllowUserToAddRows = false;
            this.dataGridViewAlerts.AllowUserToDeleteRows = false;
            this.dataGridViewAlerts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlerts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAlerts.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAlerts.Name = "dataGridViewAlerts";
            this.dataGridViewAlerts.ReadOnly = true;
            this.dataGridViewAlerts.RowHeadersWidth = 51;
            this.dataGridViewAlerts.RowTemplate.Height = 24;
            this.dataGridViewAlerts.Size = new System.Drawing.Size(766, 633);
            this.dataGridViewAlerts.TabIndex = 0;
            this.dataGridViewAlerts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlerts_CellContentClick);
            // 
            // AlertControlMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewAlerts);
            this.Name = "AlertControlMember";
            this.Size = new System.Drawing.Size(766, 633);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlerts)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAlerts;
    }
}
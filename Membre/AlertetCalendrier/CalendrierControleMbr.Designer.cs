namespace FatiIkhlassYoun.Membre.AlertetCalendrier
{
    partial class CalendrierControleMbr
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
            this.monthCalendarMbr = new System.Windows.Forms.MonthCalendar();
            this.listBoxTasksMbr = new System.Windows.Forms.ListBox();
            this.labelDateMbr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendarMbr
            // 
            this.monthCalendarMbr.Location = new System.Drawing.Point(20, 20);
            this.monthCalendarMbr.Name = "monthCalendarMbr";
            this.monthCalendarMbr.TabIndex = 0;
            this.monthCalendarMbr.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarMbr_DateChanged);
            // 
            // listBoxTasksMbr
            // 
            this.listBoxTasksMbr.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxTasksMbr.FormattingEnabled = true;
            this.listBoxTasksMbr.ItemHeight = 20;
            this.listBoxTasksMbr.Location = new System.Drawing.Point(20, 200);
            this.listBoxTasksMbr.Name = "listBoxTasksMbr";
            this.listBoxTasksMbr.Size = new System.Drawing.Size(400, 164);
            this.listBoxTasksMbr.TabIndex = 1;
            this.listBoxTasksMbr.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxTasksMbr_DrawItem);
            // 
            // labelDateMbr
            // 
            this.labelDateMbr.AutoSize = true;
            this.labelDateMbr.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelDateMbr.Location = new System.Drawing.Point(20, 180);
            this.labelDateMbr.Name = "labelDateMbr";
            this.labelDateMbr.Size = new System.Drawing.Size(0, 23);
            this.labelDateMbr.TabIndex = 2;
            // 
            // CalendrierControleMbr
            // 
            this.Controls.Add(this.labelDateMbr);
            this.Controls.Add(this.listBoxTasksMbr);
            this.Controls.Add(this.monthCalendarMbr);
            this.Name = "CalendrierControleMbr";
            this.Size = new System.Drawing.Size(450, 400);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendarMbr;
        private System.Windows.Forms.ListBox listBoxTasksMbr;
        private System.Windows.Forms.Label labelDateMbr;
    }
}

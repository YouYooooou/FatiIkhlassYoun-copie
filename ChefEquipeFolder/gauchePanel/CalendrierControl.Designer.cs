namespace FatiIkhlassYoun
{
    partial class CalendrierControl
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
            monthCalendar1 = new MonthCalendar();
            label1 = new Label();
            CalendarTasksList = new ListBox();
            labelDate = new Label();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(2, 1);
            monthCalendar1.Location = new Point(70, 92);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(287, 29);
            label1.Name = "label1";
            label1.Size = new Size(190, 54);
            label1.TabIndex = 2;
            label1.Text = "Calendar";
            // 
            // CalendarTasksList
            // 
            CalendarTasksList.DrawMode = DrawMode.OwnerDrawFixed;
            CalendarTasksList.FormattingEnabled = true;
            CalendarTasksList.ItemHeight = 25;
            CalendarTasksList.Location = new Point(70, 431);
            CalendarTasksList.Name = "CalendarTasksList";
            CalendarTasksList.Size = new Size(627, 204);
            CalendarTasksList.TabIndex = 3;
            CalendarTasksList.DrawItem += CalendarTasksList_DrawItem;
            CalendarTasksList.SelectedIndexChanged += CalendarTasksList_SelectedIndexChanged;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDate.Location = new Point(227, 387);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(368, 32);
            labelDate.TabIndex = 4;
            labelDate.Text = "Tâches pour le [jour sélectionné]";
            // 
            // CalendrierControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelDate);
            Controls.Add(CalendarTasksList);
            Controls.Add(label1);
            Controls.Add(monthCalendar1);
            Name = "CalendrierControl";
            Size = new Size(766, 673);
            Load += CalendrierControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MonthCalendar monthCalendar1;
        private Label label1;
        private ListBox CalendarTasksList;
        private Label labelDate;
    }
}

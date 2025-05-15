namespace ProjectManagementSystem
{
    partial class FormTaskStatistics
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTotalTasks = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTerminée = new System.Windows.Forms.Label();
            this.progressTerminée = new System.Windows.Forms.ProgressBar();
            this.lblEnCours = new System.Windows.Forms.Label();
            this.progressEnCours = new System.Windows.Forms.ProgressBar();
            this.lblEnAttente = new System.Windows.Forms.Label();
            this.progressEnAttente = new System.Windows.Forms.ProgressBar();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            // lblTotalTasks
            this.lblTotalTasks.AutoSize = true;
            this.lblTotalTasks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalTasks.Location = new System.Drawing.Point(30, 20);
            this.lblTotalTasks.Name = "lblTotalTasks";
            this.lblTotalTasks.Size = new System.Drawing.Size(180, 28);
            this.lblTotalTasks.Text = "Total des tâches : 0";

            // groupBox1
            this.groupBox1.Controls.Add(this.lblTerminée);
            this.groupBox1.Controls.Add(this.progressTerminée);
            this.groupBox1.Controls.Add(this.lblEnCours);
            this.groupBox1.Controls.Add(this.progressEnCours);
            this.groupBox1.Controls.Add(this.lblEnAttente);
            this.groupBox1.Controls.Add(this.progressEnAttente);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(30, 60);
            this.groupBox1.Size = new System.Drawing.Size(500, 200);
            this.groupBox1.Text = "Statut des tâches";

            // lblTerminée
            this.lblTerminée.AutoSize = true;
            this.lblTerminée.Location = new System.Drawing.Point(20, 35);
            this.lblTerminée.Text = "Terminée : 0%";

            // progressTerminée
            this.progressTerminée.Location = new System.Drawing.Point(150, 30);
            this.progressTerminée.Size = new System.Drawing.Size(300, 25);

            // lblEnCours
            this.lblEnCours.AutoSize = true;
            this.lblEnCours.Location = new System.Drawing.Point(20, 85);
            this.lblEnCours.Text = "En cours : 0%";

            // progressEnCours
            this.progressEnCours.Location = new System.Drawing.Point(150, 80);
            this.progressEnCours.Size = new System.Drawing.Size(300, 25);

            // lblEnAttente
            this.lblEnAttente.AutoSize = true;
            this.lblEnAttente.Location = new System.Drawing.Point(20, 135);
            this.lblEnAttente.Text = "En attente : 0%";

            // progressEnAttente
            this.progressEnAttente.Location = new System.Drawing.Point(150, 130);
            this.progressEnAttente.Size = new System.Drawing.Size(300, 25);

            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(400, 270);
            this.btnRefresh.Size = new System.Drawing.Size(130, 35);
            this.btnRefresh.Text = "Actualiser";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // FormProgressAdmin
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.ClientSize = new System.Drawing.Size(580, 330);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTotalTasks);
            this.Controls.Add(this.btnRefresh);
            this.Name = "FormProgressAdmin";
            this.Text = "Progression des Tâches - Admin";
            this.Load += new System.EventHandler(this.FormProgressAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTotalTasks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTerminée;
        private System.Windows.Forms.ProgressBar progressTerminée;
        private System.Windows.Forms.Label lblEnCours;
        private System.Windows.Forms.ProgressBar progressEnCours;
        private System.Windows.Forms.Label lblEnAttente;
        private System.Windows.Forms.ProgressBar progressEnAttente;
        private System.Windows.Forms.Button btnRefresh;
    }
}

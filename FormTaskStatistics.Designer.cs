namespace FatiIkhlassYoun
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
            lblTotalTasks = new Label();
            groupBox1 = new GroupBox();
            lblTerminée = new Label();
            progressTerminée = new ProgressBar();
            lblEnCours = new Label();
            progressEnCours = new ProgressBar();
            lblEnAttente = new Label();
            progressEnAttente = new ProgressBar();
            btnRefresh = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTotalTasks
            // 
            lblTotalTasks.AutoSize = true;
            lblTotalTasks.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalTasks.Location = new Point(1, 9);
            lblTotalTasks.Name = "lblTotalTasks";
            lblTotalTasks.Size = new Size(454, 65);
            lblTotalTasks.TabIndex = 1;
            lblTotalTasks.Text = "Total des tâches : 0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTerminée);
            groupBox1.Controls.Add(progressTerminée);
            groupBox1.Controls.Add(lblEnCours);
            groupBox1.Controls.Add(progressEnCours);
            groupBox1.Controls.Add(lblEnAttente);
            groupBox1.Controls.Add(progressEnAttente);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(30, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1274, 370);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Statut des tâches";
            // 
            // lblTerminée
            // 
            lblTerminée.AutoSize = true;
            lblTerminée.Location = new Point(28, 110);
            lblTerminée.Name = "lblTerminée";
            lblTerminée.Size = new Size(287, 54);
            lblTerminée.TabIndex = 0;
            lblTerminée.Text = "Terminée : 0%";
            // 
            // progressTerminée
            // 
            progressTerminée.Location = new Point(477, 119);
            progressTerminée.Name = "progressTerminée";
            progressTerminée.Size = new Size(528, 45);
            progressTerminée.TabIndex = 1;
            // 
            // lblEnCours
            // 
            lblEnCours.AutoSize = true;
            lblEnCours.Location = new Point(44, 183);
            lblEnCours.Name = "lblEnCours";
            lblEnCours.Size = new Size(271, 54);
            lblEnCours.TabIndex = 2;
            lblEnCours.Text = "En cours : 0%";
            // 
            // progressEnCours
            // 
            progressEnCours.Location = new Point(477, 183);
            progressEnCours.Name = "progressEnCours";
            progressEnCours.Size = new Size(528, 54);
            progressEnCours.TabIndex = 3;
            // 
            // lblEnAttente
            // 
            lblEnAttente.AutoSize = true;
            lblEnAttente.Location = new Point(44, 256);
            lblEnAttente.Name = "lblEnAttente";
            lblEnAttente.Size = new Size(308, 54);
            lblEnAttente.TabIndex = 4;
            lblEnAttente.Text = "En attente : 0%";
            // 
            // progressEnAttente
            // 
            progressEnAttente.Location = new Point(477, 256);
            progressEnAttente.Name = "progressEnAttente";
            progressEnAttente.Size = new Size(528, 60);
            progressEnAttente.TabIndex = 5;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1153, 472);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(229, 87);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Actualiser";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // FormTaskStatistics
            // 
            ClientSize = new Size(1489, 678);
            Controls.Add(groupBox1);
            Controls.Add(lblTotalTasks);
            Controls.Add(btnRefresh);
            Name = "FormTaskStatistics";
            Text = "Progression des Tâches - Admin";
            Load += FormProgressAdmin_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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

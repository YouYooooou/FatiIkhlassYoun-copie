namespace FatiIkhlassYoun
{
    partial class FormDeleteTask
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            cmbTasks = new ComboBox();
            btnDelete = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(40, 55);
            label1.Margin = new Padding(10, 0, 10, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 48);
            label1.TabIndex = 0;
            label1.Text = "Tâche :";
            // 
            // cmbTasks
            // 
            cmbTasks.FormattingEnabled = true;
            cmbTasks.Location = new Point(263, 44);
            cmbTasks.Margin = new Padding(10, 11, 10, 11);
            cmbTasks.Name = "cmbTasks";
            cmbTasks.Size = new Size(657, 56);
            cmbTasks.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(410, 144);
            btnDelete.Margin = new Padding(10, 11, 10, 11);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(250, 85);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Supprimer";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonShadow;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(680, 144);
            btnCancel.Margin = new Padding(10, 11, 10, 11);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(250, 85);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Annuler";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormDeleteTask
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1160, 273);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(cmbTasks);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(10, 11, 10, 11);
            Name = "FormDeleteTask";
            Text = "Supprimer une tâche";
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTasks;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
    }
}
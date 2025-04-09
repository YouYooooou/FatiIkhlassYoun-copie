namespace FatiIkhlassYoun
{
    partial class formDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDashboard));
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            toolStrip1 = new ToolStrip();
            btnNewEmployee = new ToolStripSplitButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(885, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 692);
            panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(297, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(591, 692);
            dataGridView1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 692);
            panel2.TabIndex = 3;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNewEmployee });
            toolStrip1.Location = new Point(1, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1160, 34);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNewEmployee
            // 
            btnNewEmployee.Image = (Image)resources.GetObject("btnNewEmployee.Image");
            btnNewEmployee.ImageTransparentColor = Color.Magenta;
            btnNewEmployee.Name = "btnNewEmployee";
            btnNewEmployee.Size = new Size(175, 29);
            btnNewEmployee.Text = "New Employee";
            // 
            // formDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1160, 755);
            Controls.Add(toolStrip1);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formDashboard";
            Load += formDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private ToolStrip toolStrip1;
        private ToolStripSplitButton btnNewEmployee;
    }
}
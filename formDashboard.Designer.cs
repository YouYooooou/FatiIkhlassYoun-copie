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
            label2 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(335, 352);
            label2.Name = "label2";
            label2.Size = new Size(503, 117);
            label2.TabIndex = 1;
            label2.Text = "Dashboard";
            // 
            // formDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 42, 56);
            ClientSize = new Size(1160, 755);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formDashboard";
            Load += formDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
    }
}
namespace WindowsFormsApp1
{
    partial class TacheStatistiquesForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartTaches = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTerminees = new System.Windows.Forms.Label();
            this.lblEnCours = new System.Windows.Forms.Label();
            this.lblEnAttente = new System.Windows.Forms.Label();
            this.comboEquipes = new System.Windows.Forms.ComboBox();
            this.btnFiltrerEquipe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cuiButton1 = new CuoreUI.Controls.cuiButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartTaches)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartTaches
            // 
            chartArea4.Name = "ChartArea1";
            this.chartTaches.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartTaches.Legends.Add(legend4);
            this.chartTaches.Location = new System.Drawing.Point(68, 114);
            this.chartTaches.Name = "chartTaches";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartTaches.Series.Add(series4);
            this.chartTaches.Size = new System.Drawing.Size(539, 322);
            this.chartTaches.TabIndex = 1;
            this.chartTaches.Text = "chart1";
            this.chartTaches.Click += new System.EventHandler(this.chartTaches_Click);
            // 
            // lblTerminees
            // 
            this.lblTerminees.AutoSize = true;
            this.lblTerminees.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerminees.ForeColor = System.Drawing.Color.Green;
            this.lblTerminees.Location = new System.Drawing.Point(64, 477);
            this.lblTerminees.Name = "lblTerminees";
            this.lblTerminees.Size = new System.Drawing.Size(57, 21);
            this.lblTerminees.TabIndex = 2;
            this.lblTerminees.Text = "label2";
            this.lblTerminees.Click += new System.EventHandler(this.lblTerminees_Click);
            // 
            // lblEnCours
            // 
            this.lblEnCours.AutoSize = true;
            this.lblEnCours.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnCours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblEnCours.Location = new System.Drawing.Point(296, 477);
            this.lblEnCours.Name = "lblEnCours";
            this.lblEnCours.Size = new System.Drawing.Size(57, 21);
            this.lblEnCours.TabIndex = 3;
            this.lblEnCours.Text = "label3";
            // 
            // lblEnAttente
            // 
            this.lblEnAttente.AutoSize = true;
            this.lblEnAttente.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnAttente.ForeColor = System.Drawing.Color.Red;
            this.lblEnAttente.Location = new System.Drawing.Point(570, 477);
            this.lblEnAttente.Name = "lblEnAttente";
            this.lblEnAttente.Size = new System.Drawing.Size(57, 21);
            this.lblEnAttente.TabIndex = 4;
            this.lblEnAttente.Text = "label4";
            // 
            // comboEquipes
            // 
            this.comboEquipes.FormattingEnabled = true;
            this.comboEquipes.Location = new System.Drawing.Point(633, 172);
            this.comboEquipes.Name = "comboEquipes";
            this.comboEquipes.Size = new System.Drawing.Size(286, 28);
            this.comboEquipes.TabIndex = 5;
            // 
            // btnFiltrerEquipe
            // 
            this.btnFiltrerEquipe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFiltrerEquipe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrerEquipe.Location = new System.Drawing.Point(633, 218);
            this.btnFiltrerEquipe.Name = "btnFiltrerEquipe";
            this.btnFiltrerEquipe.Size = new System.Drawing.Size(286, 37);
            this.btnFiltrerEquipe.TabIndex = 6;
            this.btnFiltrerEquipe.Text = "Afficher les statistiques";
            this.btnFiltrerEquipe.UseVisualStyleBackColor = false;
            this.btnFiltrerEquipe.Click += new System.EventHandler(this.btnFiltrerEquipe_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 44);
            this.panel1.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 28);
            this.label8.TabIndex = 12;
            this.label8.Text = "Avancement des taches :";
            // 
            // cuiButton1
            // 
            this.cuiButton1.CheckButton = false;
            this.cuiButton1.Checked = false;
            this.cuiButton1.CheckedBackground = System.Drawing.Color.Gray;
            this.cuiButton1.CheckedForeColor = System.Drawing.Color.DimGray;
            this.cuiButton1.CheckedImageTint = System.Drawing.Color.Gainsboro;
            this.cuiButton1.CheckedOutline = System.Drawing.Color.Silver;
            this.cuiButton1.Content = "x";
            this.cuiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiButton1.ForeColor = System.Drawing.Color.Black;
            this.cuiButton1.HoverBackground = System.Drawing.Color.DimGray;
            this.cuiButton1.HoveredImageTint = System.Drawing.Color.DarkGray;
            this.cuiButton1.HoverForeColor = System.Drawing.Color.LightGray;
            this.cuiButton1.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton1.Image = null;
            this.cuiButton1.ImageAutoCenter = true;
            this.cuiButton1.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton1.Location = new System.Drawing.Point(877, 50);
            this.cuiButton1.Name = "cuiButton1";
            this.cuiButton1.NormalBackground = System.Drawing.Color.White;
            this.cuiButton1.NormalForeColor = System.Drawing.Color.Black;
            this.cuiButton1.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton1.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton1.OutlineThickness = 1.6F;
            this.cuiButton1.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.cuiButton1.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton1.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton1.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton1.Size = new System.Drawing.Size(42, 45);
            this.cuiButton1.TabIndex = 40;
            this.cuiButton1.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton1.Click += new System.EventHandler(this.cuiButton1_Click);
            // 
            // TacheStatistiquesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(931, 610);
            this.Controls.Add(this.cuiButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFiltrerEquipe);
            this.Controls.Add(this.comboEquipes);
            this.Controls.Add(this.lblEnAttente);
            this.Controls.Add(this.lblEnCours);
            this.Controls.Add(this.lblTerminees);
            this.Controls.Add(this.chartTaches);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TacheStatistiquesForm";
            this.Text = "StatistiquesForm";
            this.Load += new System.EventHandler(this.StatistiquesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTaches)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTaches;
        private System.Windows.Forms.Label lblTerminees;
        private System.Windows.Forms.Label lblEnCours;
        private System.Windows.Forms.Label lblEnAttente;
        private System.Windows.Forms.ComboBox comboEquipes;
        private System.Windows.Forms.Button btnFiltrerEquipe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private CuoreUI.Controls.cuiButton cuiButton1;
    }
}
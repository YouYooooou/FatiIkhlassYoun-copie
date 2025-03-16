namespace FatiIkhlassYoun
{
    partial class MenuDeApp
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuDeApp));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            cuiButton2 = new CuoreUI.Controls.cuiButton();
            sidebar = new FlowLayoutPanel();
            panel4 = new Panel();
            pnDashboard = new Button();
            button6 = new Button();
            panel2 = new Panel();
            pnGestionDesProjets = new Button();
            button2 = new Button();
            panel3 = new Panel();
            pnGestionDesEquipes = new Button();
            button4 = new Button();
            panel5 = new Panel();
            pnGestionDesUtilisateurs = new Button();
            button8 = new Button();
            panel6 = new Panel();
            pnLogout = new Button();
            button10 = new Button();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sidebar.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 62, 80);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(cuiButton2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1247, 45);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(80, 9);
            label1.Name = "label1";
            label1.Size = new Size(274, 25);
            label1.TabIndex = 13;
            label1.Text = "Systeme de gestion de projets";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // cuiButton2
            // 
            cuiButton2.CheckButton = false;
            cuiButton2.Checked = false;
            cuiButton2.CheckedBackground = Color.Gray;
            cuiButton2.CheckedForeColor = Color.DimGray;
            cuiButton2.CheckedImageTint = Color.Gainsboro;
            cuiButton2.CheckedOutline = Color.Silver;
            cuiButton2.Content = "x";
            cuiButton2.Cursor = Cursors.Hand;
            cuiButton2.DialogResult = DialogResult.None;
            cuiButton2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiButton2.ForeColor = SystemColors.ButtonHighlight;
            cuiButton2.HoverBackground = Color.FromArgb(44, 62, 80);
            cuiButton2.HoveredImageTint = Color.FromArgb(44, 62, 80);
            cuiButton2.HoverForeColor = Color.White;
            cuiButton2.HoverOutline = Color.Empty;
            cuiButton2.Image = null;
            cuiButton2.ImageAutoCenter = true;
            cuiButton2.ImageExpand = new Point(0, 0);
            cuiButton2.ImageOffset = new Point(0, 0);
            cuiButton2.ImageTint = Color.FromArgb(30, 42, 56);
            cuiButton2.Location = new Point(1210, 0);
            cuiButton2.Name = "cuiButton2";
            cuiButton2.NormalBackground = Color.FromArgb(44, 62, 80);
            cuiButton2.NormalOutline = Color.Empty;
            cuiButton2.OutlineThickness = 1.6F;
            cuiButton2.PressedBackground = Color.FromArgb(44, 62, 80);
            cuiButton2.PressedForeColor = SystemColors.ButtonHighlight;
            cuiButton2.PressedImageTint = Color.White;
            cuiButton2.PressedOutline = Color.Empty;
            cuiButton2.Rounding = new Padding(8);
            cuiButton2.Size = new Size(36, 32);
            cuiButton2.TabIndex = 11;
            cuiButton2.TextOffset = new Point(0, 0);
            cuiButton2.Click += cuiButton2_Click_1;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(44, 62, 80);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel6);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 45);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(365, 780);
            sidebar.TabIndex = 12;
            sidebar.Paint += sidebar_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pnDashboard);
            panel4.Controls.Add(button6);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(375, 71);
            panel4.TabIndex = 17;
            // 
            // pnDashboard
            // 
            pnDashboard.BackColor = Color.FromArgb(44, 62, 80);
            pnDashboard.Cursor = Cursors.Hand;
            pnDashboard.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnDashboard.ForeColor = SystemColors.ButtonHighlight;
            pnDashboard.Image = (Image)resources.GetObject("pnDashboard.Image");
            pnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            pnDashboard.Location = new Point(-16, -40);
            pnDashboard.Margin = new Padding(8);
            pnDashboard.Name = "pnDashboard";
            pnDashboard.Padding = new Padding(25, 0, 0, 0);
            pnDashboard.Size = new Size(434, 153);
            pnDashboard.TabIndex = 14;
            pnDashboard.Text = "             Dashboard";
            pnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            pnDashboard.UseVisualStyleBackColor = false;
            pnDashboard.Click += pnDashboard_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(55, 70, 86);
            button6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-16, -10);
            button6.Margin = new Padding(8);
            button6.Name = "button6";
            button6.Padding = new Padding(25, 0, 0, 0);
            button6.Size = new Size(303, 55);
            button6.TabIndex = 13;
            button6.Text = "Dashboard";
            button6.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pnGestionDesProjets);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(3, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(375, 71);
            panel2.TabIndex = 18;
            // 
            // pnGestionDesProjets
            // 
            pnGestionDesProjets.BackColor = Color.FromArgb(44, 62, 80);
            pnGestionDesProjets.Cursor = Cursors.Hand;
            pnGestionDesProjets.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnGestionDesProjets.ForeColor = SystemColors.ButtonHighlight;
            pnGestionDesProjets.Image = (Image)resources.GetObject("pnGestionDesProjets.Image");
            pnGestionDesProjets.ImageAlign = ContentAlignment.MiddleLeft;
            pnGestionDesProjets.Location = new Point(-16, -40);
            pnGestionDesProjets.Margin = new Padding(8);
            pnGestionDesProjets.Name = "pnGestionDesProjets";
            pnGestionDesProjets.Padding = new Padding(25, 0, 0, 0);
            pnGestionDesProjets.Size = new Size(434, 153);
            pnGestionDesProjets.TabIndex = 14;
            pnGestionDesProjets.Text = "             Gestion des projets";
            pnGestionDesProjets.TextAlign = ContentAlignment.MiddleLeft;
            pnGestionDesProjets.UseVisualStyleBackColor = false;
            pnGestionDesProjets.Click += pnGestionDesProjets_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(55, 70, 86);
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-16, -10);
            button2.Margin = new Padding(8);
            button2.Name = "button2";
            button2.Padding = new Padding(25, 0, 0, 0);
            button2.Size = new Size(303, 55);
            button2.TabIndex = 13;
            button2.Text = "Dashboard";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pnGestionDesEquipes);
            panel3.Controls.Add(button4);
            panel3.Location = new Point(3, 157);
            panel3.Name = "panel3";
            panel3.Size = new Size(375, 71);
            panel3.TabIndex = 19;
            // 
            // pnGestionDesEquipes
            // 
            pnGestionDesEquipes.BackColor = Color.FromArgb(44, 62, 80);
            pnGestionDesEquipes.Cursor = Cursors.Hand;
            pnGestionDesEquipes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnGestionDesEquipes.ForeColor = SystemColors.ButtonHighlight;
            pnGestionDesEquipes.Image = (Image)resources.GetObject("pnGestionDesEquipes.Image");
            pnGestionDesEquipes.ImageAlign = ContentAlignment.MiddleLeft;
            pnGestionDesEquipes.Location = new Point(-16, -40);
            pnGestionDesEquipes.Margin = new Padding(8);
            pnGestionDesEquipes.Name = "pnGestionDesEquipes";
            pnGestionDesEquipes.Padding = new Padding(25, 0, 0, 0);
            pnGestionDesEquipes.Size = new Size(434, 153);
            pnGestionDesEquipes.TabIndex = 14;
            pnGestionDesEquipes.Text = "             Gestion des equipes";
            pnGestionDesEquipes.TextAlign = ContentAlignment.MiddleLeft;
            pnGestionDesEquipes.UseVisualStyleBackColor = false;
            pnGestionDesEquipes.Click += pnGestionDesEquipes_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(55, 70, 86);
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-16, -10);
            button4.Margin = new Padding(8);
            button4.Name = "button4";
            button4.Padding = new Padding(25, 0, 0, 0);
            button4.Size = new Size(303, 55);
            button4.TabIndex = 13;
            button4.Text = "Dashboard";
            button4.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(pnGestionDesUtilisateurs);
            panel5.Controls.Add(button8);
            panel5.Location = new Point(3, 234);
            panel5.Name = "panel5";
            panel5.Size = new Size(375, 71);
            panel5.TabIndex = 20;
            // 
            // pnGestionDesUtilisateurs
            // 
            pnGestionDesUtilisateurs.BackColor = Color.FromArgb(44, 62, 80);
            pnGestionDesUtilisateurs.Cursor = Cursors.Hand;
            pnGestionDesUtilisateurs.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnGestionDesUtilisateurs.ForeColor = SystemColors.ButtonHighlight;
            pnGestionDesUtilisateurs.Image = (Image)resources.GetObject("pnGestionDesUtilisateurs.Image");
            pnGestionDesUtilisateurs.ImageAlign = ContentAlignment.MiddleLeft;
            pnGestionDesUtilisateurs.Location = new Point(-16, -40);
            pnGestionDesUtilisateurs.Margin = new Padding(8);
            pnGestionDesUtilisateurs.Name = "pnGestionDesUtilisateurs";
            pnGestionDesUtilisateurs.Padding = new Padding(25, 0, 0, 0);
            pnGestionDesUtilisateurs.Size = new Size(434, 153);
            pnGestionDesUtilisateurs.TabIndex = 14;
            pnGestionDesUtilisateurs.Text = "             Gestion des utilisateurs";
            pnGestionDesUtilisateurs.TextAlign = ContentAlignment.MiddleLeft;
            pnGestionDesUtilisateurs.UseVisualStyleBackColor = false;
            pnGestionDesUtilisateurs.Click += pnGestionDesUtilisateurs_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(55, 70, 86);
            button8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(-16, -10);
            button8.Margin = new Padding(8);
            button8.Name = "button8";
            button8.Padding = new Padding(25, 0, 0, 0);
            button8.Size = new Size(303, 55);
            button8.TabIndex = 13;
            button8.Text = "Dashboard";
            button8.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(pnLogout);
            panel6.Controls.Add(button10);
            panel6.Location = new Point(3, 311);
            panel6.Name = "panel6";
            panel6.Size = new Size(375, 71);
            panel6.TabIndex = 21;
            // 
            // pnLogout
            // 
            pnLogout.BackColor = Color.FromArgb(44, 62, 80);
            pnLogout.Cursor = Cursors.Hand;
            pnLogout.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnLogout.ForeColor = SystemColors.ButtonHighlight;
            pnLogout.Image = (Image)resources.GetObject("pnLogout.Image");
            pnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            pnLogout.Location = new Point(-16, -40);
            pnLogout.Margin = new Padding(8);
            pnLogout.Name = "pnLogout";
            pnLogout.Padding = new Padding(25, 0, 0, 0);
            pnLogout.Size = new Size(434, 153);
            pnLogout.TabIndex = 14;
            pnLogout.Text = "             Logout";
            pnLogout.TextAlign = ContentAlignment.MiddleLeft;
            pnLogout.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(55, 70, 86);
            button10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.ButtonHighlight;
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(-16, -10);
            button10.Margin = new Padding(8);
            button10.Name = "button10";
            button10.Padding = new Padding(25, 0, 0, 0);
            button10.Size = new Size(303, 55);
            button10.TabIndex = 13;
            button10.Text = "Dashboard";
            button10.UseVisualStyleBackColor = false;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 5;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // MenuDeApp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 42, 56);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1247, 825);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            ForeColor = Color.Coral;
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "MenuDeApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuDeApp";
            Load += MenuDeApp_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sidebar.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private PictureBox pictureBox1;
        private Label label1;
        private FlowLayoutPanel sidebar;
        private Panel panel4;
        private Button pnDashboard;
        private Button button6;
        private Panel panel2;
        private Button pnGestionDesProjets;
        private Button button2;
        private Panel panel3;
        private Button pnGestionDesEquipes;
        private Button button4;
        private Panel panel5;
        private Button pnGestionDesUtilisateurs;
        private Button button8;
        private Panel panel6;
        private Button pnLogout;
        private Button button10;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}
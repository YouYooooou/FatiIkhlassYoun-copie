namespace WindowsFormsApp1
{
    partial class MenuduChefDeProjet
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuduChefDeProjet));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierUneTacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUnMembreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUneÉquipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelInfos = new System.Windows.Forms.Panel();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.contextMenuAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterUneTacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnMembreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnChefDéquipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuiControlAnimator1 = new CuoreUI.Components.cuiControlAnimator();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerUneTacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnMembreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUneÉquipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMilieu = new System.Windows.Forms.Panel();
            this.labelPourcentageGlobal = new System.Windows.Forms.Label();
            this.progressBarGlobal = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuiButton1 = new CuoreUI.Controls.cuiButton();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuAdd.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.panelMilieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.labelRole);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1167, 45);
            this.panelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 45);
            this.panel1.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Systeme de gestion de projets";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.BackColor = System.Drawing.Color.Transparent;
            this.labelRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.ForeColor = System.Drawing.Color.White;
            this.labelRole.Location = new System.Drawing.Point(429, 9);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(176, 32);
            this.labelRole.TabIndex = 0;
            this.labelRole.Text = "Chef de Projet";
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.White;
            this.panelButtons.Controls.Add(this.cuiButton1);
            this.panelButtons.Controls.Add(this.button5);
            this.panelButtons.Controls.Add(this.btnEdit);
            this.panelButtons.Controls.Add(this.button10);
            this.panelButtons.Controls.Add(this.button9);
            this.panelButtons.Controls.Add(this.button4);
            this.panelButtons.Controls.Add(this.button3);
            this.panelButtons.Controls.Add(this.button2);
            this.panelButtons.Controls.Add(this.btnAdd);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelButtons.Location = new System.Drawing.Point(0, 45);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1167, 147);
            this.panelButtons.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(304, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 92);
            this.button5.TabIndex = 0;
            this.button5.Text = "Delete";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ContextMenuStrip = this.contextMenuStrip1;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(172, 21);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(81, 92);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierUneTacheToolStripMenuItem,
            this.modifierUnMembreToolStripMenuItem,
            this.modifierUneÉquipeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(249, 100);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // modifierUneTacheToolStripMenuItem
            // 
            this.modifierUneTacheToolStripMenuItem.Name = "modifierUneTacheToolStripMenuItem";
            this.modifierUneTacheToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.modifierUneTacheToolStripMenuItem.Text = "Modifier une tache";
            this.modifierUneTacheToolStripMenuItem.Click += new System.EventHandler(this.modifierUneTacheToolStripMenuItem_Click);
            // 
            // modifierUnMembreToolStripMenuItem
            // 
            this.modifierUnMembreToolStripMenuItem.Name = "modifierUnMembreToolStripMenuItem";
            this.modifierUnMembreToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.modifierUnMembreToolStripMenuItem.Text = "Modifier un membre";
            this.modifierUnMembreToolStripMenuItem.Click += new System.EventHandler(this.modifierUnMembreToolStripMenuItem_Click);
            // 
            // modifierUneÉquipeToolStripMenuItem
            // 
            this.modifierUneÉquipeToolStripMenuItem.Name = "modifierUneÉquipeToolStripMenuItem";
            this.modifierUneÉquipeToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.modifierUneÉquipeToolStripMenuItem.Text = "Modifier une équipe";
            this.modifierUneÉquipeToolStripMenuItem.Click += new System.EventHandler(this.modifierUneÉquipeToolStripMenuItem_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(1004, 6);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(122, 117);
            this.button10.TabIndex = 5;
            this.button10.Text = "Log Out";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(874, 6);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(124, 117);
            this.button9.TabIndex = 4;
            this.button9.Text = "WhatsApp";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(735, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 123);
            this.button4.TabIndex = 3;
            this.button4.Text = "Alert";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(575, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 129);
            this.button3.TabIndex = 2;
            this.button3.Text = "Generate report";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(435, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 144);
            this.button2.TabIndex = 1;
            this.button2.Text = "Tasks";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 147);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAjtProjet_Click);
            // 
            // panelInfos
            // 
            this.panelInfos.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelInfos.Location = new System.Drawing.Point(908, 192);
            this.panelInfos.Name = "panelInfos";
            this.panelInfos.Size = new System.Drawing.Size(259, 508);
            this.panelInfos.TabIndex = 3;
            // 
            // panelSidebar
            // 
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 192);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(279, 508);
            this.panelSidebar.TabIndex = 4;
            this.panelSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSidebar_Paint);
            // 
            // contextMenuAdd
            // 
            this.contextMenuAdd.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneTacheToolStripMenuItem,
            this.ajouterUnMembreToolStripMenuItem,
            this.ajouterUnChefDéquipeToolStripMenuItem});
            this.contextMenuAdd.Name = "contextMenuAdd";
            this.contextMenuAdd.Size = new System.Drawing.Size(280, 100);
            // 
            // ajouterUneTacheToolStripMenuItem
            // 
            this.ajouterUneTacheToolStripMenuItem.Name = "ajouterUneTacheToolStripMenuItem";
            this.ajouterUneTacheToolStripMenuItem.Size = new System.Drawing.Size(279, 32);
            this.ajouterUneTacheToolStripMenuItem.Text = "Ajouter une tache";
            this.ajouterUneTacheToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneTacheToolStripMenuItem_Click);
            // 
            // ajouterUnMembreToolStripMenuItem
            // 
            this.ajouterUnMembreToolStripMenuItem.Name = "ajouterUnMembreToolStripMenuItem";
            this.ajouterUnMembreToolStripMenuItem.Size = new System.Drawing.Size(279, 32);
            this.ajouterUnMembreToolStripMenuItem.Text = "Ajouter un membre";
            this.ajouterUnMembreToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnMembreToolStripMenuItem_Click);
            // 
            // ajouterUnChefDéquipeToolStripMenuItem
            // 
            this.ajouterUnChefDéquipeToolStripMenuItem.Name = "ajouterUnChefDéquipeToolStripMenuItem";
            this.ajouterUnChefDéquipeToolStripMenuItem.Size = new System.Drawing.Size(279, 32);
            this.ajouterUnChefDéquipeToolStripMenuItem.Text = "Ajouter un chef d\'équipe";
            this.ajouterUnChefDéquipeToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnChefDéquipeToolStripMenuItem_Click);
            // 
            // cuiControlAnimator1
            // 
            this.cuiControlAnimator1.AnimateLocation = true;
            this.cuiControlAnimator1.AnimateOnStart = true;
            this.cuiControlAnimator1.AnimateOpacity = false;
            this.cuiControlAnimator1.Duration = 1000;
            this.cuiControlAnimator1.EasingType = CuoreUI.Drawing.EasingTypes.QuadInOut;
            this.cuiControlAnimator1.TargetControl = null;
            this.cuiControlAnimator1.TargetLocation = new System.Drawing.Point(0, 0);
            this.cuiControlAnimator1.TargetOpacity = CuoreUI.Components.cuiControlAnimator.OpacityEnum.Visible;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerUneTacheToolStripMenuItem,
            this.supprimerUnMembreToolStripMenuItem,
            this.supprimerUneÉquipeToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(265, 100);
            // 
            // supprimerUneTacheToolStripMenuItem
            // 
            this.supprimerUneTacheToolStripMenuItem.Name = "supprimerUneTacheToolStripMenuItem";
            this.supprimerUneTacheToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
            this.supprimerUneTacheToolStripMenuItem.Text = "Supprimer une tache";
            this.supprimerUneTacheToolStripMenuItem.Click += new System.EventHandler(this.supprimerUneTacheToolStripMenuItem_Click);
            // 
            // supprimerUnMembreToolStripMenuItem
            // 
            this.supprimerUnMembreToolStripMenuItem.Name = "supprimerUnMembreToolStripMenuItem";
            this.supprimerUnMembreToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
            this.supprimerUnMembreToolStripMenuItem.Text = "Supprimer un membre";
            this.supprimerUnMembreToolStripMenuItem.Click += new System.EventHandler(this.supprimerUnMembreToolStripMenuItem_Click);
            // 
            // supprimerUneÉquipeToolStripMenuItem
            // 
            this.supprimerUneÉquipeToolStripMenuItem.Name = "supprimerUneÉquipeToolStripMenuItem";
            this.supprimerUneÉquipeToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
            this.supprimerUneÉquipeToolStripMenuItem.Text = "Supprimer une équipe";
            this.supprimerUneÉquipeToolStripMenuItem.Click += new System.EventHandler(this.supprimerUneÉquipeToolStripMenuItem_Click);
            // 
            // panelMilieu
            // 
            this.panelMilieu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMilieu.Controls.Add(this.labelPourcentageGlobal);
            this.panelMilieu.Controls.Add(this.progressBarGlobal);
            this.panelMilieu.Controls.Add(this.label1);
            this.panelMilieu.Controls.Add(this.dataGridView1);
            this.panelMilieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMilieu.Location = new System.Drawing.Point(279, 192);
            this.panelMilieu.Name = "panelMilieu";
            this.panelMilieu.Size = new System.Drawing.Size(629, 508);
            this.panelMilieu.TabIndex = 5;
            this.panelMilieu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelPourcentageGlobal
            // 
            this.labelPourcentageGlobal.AutoSize = true;
            this.labelPourcentageGlobal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPourcentageGlobal.Location = new System.Drawing.Point(34, 422);
            this.labelPourcentageGlobal.Name = "labelPourcentageGlobal";
            this.labelPourcentageGlobal.Size = new System.Drawing.Size(315, 28);
            this.labelPourcentageGlobal.TabIndex = 3;
            this.labelPourcentageGlobal.Text = "Progression globale des taches :";
            // 
            // progressBarGlobal
            // 
            this.progressBarGlobal.Location = new System.Drawing.Point(39, 463);
            this.progressBarGlobal.Name = "progressBarGlobal";
            this.progressBarGlobal.Size = new System.Drawing.Size(547, 23);
            this.progressBarGlobal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tableau de bord";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamName,
            this.LeaderName,
            this.MemberCount,
            this.TaskCount});
            this.dataGridView1.Location = new System.Drawing.Point(0, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(629, 308);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TeamName
            // 
            this.TeamName.HeaderText = "Nom de l\'équipe ";
            this.TeamName.MinimumWidth = 8;
            this.TeamName.Name = "TeamName";
            this.TeamName.Width = 150;
            // 
            // LeaderName
            // 
            this.LeaderName.HeaderText = "Chef de l\'équipe";
            this.LeaderName.MinimumWidth = 8;
            this.LeaderName.Name = "LeaderName";
            this.LeaderName.Width = 150;
            // 
            // MemberCount
            // 
            this.MemberCount.HeaderText = "Nombre de membres";
            this.MemberCount.MinimumWidth = 8;
            this.MemberCount.Name = "MemberCount";
            this.MemberCount.Width = 150;
            // 
            // TaskCount
            // 
            this.TaskCount.HeaderText = "Nombre de tâches";
            this.TaskCount.MinimumWidth = 8;
            this.TaskCount.Name = "TaskCount";
            this.TaskCount.Width = 150;
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
            this.cuiButton1.Location = new System.Drawing.Point(1118, 6);
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
            this.cuiButton1.TabIndex = 10;
            this.cuiButton1.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton1.Click += new System.EventHandler(this.cuiButton1_Click);
            // 
            // InterfaceChefDeProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 700);
            this.Controls.Add(this.panelMilieu);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelInfos);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterfaceChefDeProjet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InterfaceChefDeProjet_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuAdd.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.panelMilieu.ResumeLayout(false);
            this.panelMilieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelInfos;
    
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.ContextMenuStrip contextMenuAdd;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneTacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnMembreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnChefDéquipeToolStripMenuItem;
        private CuoreUI.Components.cuiControlAnimator cuiControlAnimator1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modifierUneTacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUnMembreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUneÉquipeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem supprimerUneTacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnMembreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUneÉquipeToolStripMenuItem;
        private System.Windows.Forms.Panel panelMilieu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPourcentageGlobal;
        private System.Windows.Forms.ProgressBar progressBarGlobal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private CuoreUI.Controls.cuiButton cuiButton1;
    }
}


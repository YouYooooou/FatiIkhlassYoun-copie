
namespace FatiIkhlassYoun
{
    partial class MenuAdmin

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            TreeNode treeNode1 = new TreeNode("All ");
            TreeNode treeNode2 = new TreeNode("On leave");
            TreeNode treeNode3 = new TreeNode("Employees", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("Chef de projets ");
            TreeNode treeNode5 = new TreeNode("Projets", new TreeNode[] { treeNode4 });
            TreeNode treeNode6 = new TreeNode("Chef d'équipes");
            TreeNode treeNode7 = new TreeNode("Groups", new TreeNode[] { treeNode6 });
            TreeNode treeNode8 = new TreeNode("Tâches sous-traitants");
            TreeNode treeNode9 = new TreeNode("Tâches internes ");
            TreeNode treeNode10 = new TreeNode("Tâches externes");
            TreeNode treeNode11 = new TreeNode("Tâches", new TreeNode[] { treeNode8, treeNode9, treeNode10 });
            panelSup = new Panel();
            btnLower = new Label();
            lblLogOut = new Label();
            label1 = new Label();
            panelsup2 = new Panel();
            panel1 = new Panel();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            cuiButtonWtsp = new CuoreUI.Controls.cuiButton();
            cuiButtonDelete = new CuoreUI.Controls.cuiButton();
            cuiButtonGenerateReport = new CuoreUI.Controls.cuiButton();
            cuiButtonEdit = new CuoreUI.Controls.cuiButton();
            cuiButtonADD = new CuoreUI.Controls.cuiButton();
            cuiButtonProgress = new CuoreUI.Controls.cuiButton();
            panelleft = new Panel();
            treeView = new TreeView();
            panelRight = new Panel();
            panel2 = new Panel();
            labelRole = new Label();
            labelPrenom = new Label();
            labelNom = new Label();
            dataGridView1 = new DataGridView();
            contextMenuAdd = new ContextMenuStrip(components);
            addEmployeeToolStripMenuItem = new ToolStripMenuItem();
            addTeamToolStripMenuItem = new ToolStripMenuItem();
            AddTasktoolStripMenuItem = new ToolStripMenuItem();
            AddProjettoolStripMenuItem = new ToolStripMenuItem();
            dataGridView = new DataGridView();
            textDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contextMenuEdit = new ContextMenuStrip(components);
            editTaskInfoToolStripMenuItem = new ToolStripMenuItem();
            editTeamInfoToolStripMenuItem = new ToolStripMenuItem();
            editUserInfoToolStripMenuItem = new ToolStripMenuItem();
            editProjectInfoToolStripMenuItem = new ToolStripMenuItem();
            contextMenuDelete = new ContextMenuStrip(components);
            deleteEmployeeToolStripMenuItem = new ToolStripMenuItem();
            deleteTeamToolStripMenuItem = new ToolStripMenuItem();
            deleteTaskToolStripMenuItem = new ToolStripMenuItem();
            deleteProjectToolStripMenuItem = new ToolStripMenuItem();
            panelSup.SuspendLayout();
            panelsup2.SuspendLayout();
            panel1.SuspendLayout();
            panelleft.SuspendLayout();
            panelRight.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            contextMenuEdit.SuspendLayout();
            contextMenuDelete.SuspendLayout();
            SuspendLayout();
            // 
            // panelSup
            // 
            panelSup.BackColor = SystemColors.HotTrack;
            panelSup.Controls.Add(btnLower);
            panelSup.Controls.Add(lblLogOut);
            panelSup.Controls.Add(label1);
            panelSup.Dock = DockStyle.Top;
            panelSup.Location = new Point(0, 0);
            panelSup.Margin = new Padding(4);
            panelSup.Name = "panelSup";
            panelSup.Size = new Size(3040, 79);
            panelSup.TabIndex = 0;
            panelSup.Paint += panelSup_Paint;
            // 
            // btnLower
            // 
            btnLower.AutoSize = true;
            btnLower.Cursor = Cursors.Hand;
            btnLower.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLower.Location = new Point(2890, -27);
            btnLower.Margin = new Padding(6, 0, 6, 0);
            btnLower.Name = "btnLower";
            btnLower.Size = new Size(64, 86);
            btnLower.TabIndex = 4;
            btnLower.Text = "_";
            // 
            // lblLogOut
            // 
            lblLogOut.AutoSize = true;
            lblLogOut.Cursor = Cursors.Hand;
            lblLogOut.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogOut.Location = new Point(2970, 0);
            lblLogOut.Margin = new Padding(6, 0, 6, 0);
            lblLogOut.Name = "lblLogOut";
            lblLogOut.Size = new Size(63, 74);
            lblLogOut.TabIndex = 3;
            lblLogOut.Text = "x";
            lblLogOut.Click += lblLogOut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 9);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(571, 51);
            label1.TabIndex = 1;
            label1.Text = "Système de gestion de projets";
            // 
            // panelsup2
            // 
            panelsup2.BackColor = Color.WhiteSmoke;
            panelsup2.Controls.Add(panel1);
            panelsup2.Dock = DockStyle.Top;
            panelsup2.Location = new Point(0, 79);
            panelsup2.Margin = new Padding(4);
            panelsup2.Name = "panelsup2";
            panelsup2.Size = new Size(3040, 286);
            panelsup2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(cuiButton1);
            panel1.Controls.Add(cuiButtonWtsp);
            panel1.Controls.Add(cuiButtonDelete);
            panel1.Controls.Add(cuiButtonGenerateReport);
            panel1.Controls.Add(cuiButtonEdit);
            panel1.Controls.Add(cuiButtonADD);
            panel1.Controls.Add(cuiButtonProgress);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(3040, 276);
            panel1.TabIndex = 0;
            // 
            // cuiButton1
            // 
            cuiButton1.BackColor = Color.WhiteSmoke;
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton1.Content = "LogOut";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Dock = DockStyle.Left;
            cuiButton1.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButton1.ForeColor = Color.Black;
            cuiButton1.HoverBackground = Color.PowderBlue;
            cuiButton1.HoveredImageTint = Color.White;
            cuiButton1.HoverForeColor = Color.White;
            cuiButton1.HoverOutline = Color.Empty;
            cuiButton1.Image = (Image)resources.GetObject("cuiButton1.Image");
            cuiButton1.ImageAutoCenter = true;
            cuiButton1.ImageExpand = new Point(17, 17);
            cuiButton1.ImageOffset = new Point(80, 0);
            cuiButton1.Location = new Point(2052, 0);
            cuiButton1.Margin = new Padding(4);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.WhiteSmoke;
            cuiButton1.NormalForeColor = Color.Black;
            cuiButton1.NormalImageTint = Color.White;
            cuiButton1.NormalOutline = Color.Empty;
            cuiButton1.OutlineThickness = 1.6F;
            cuiButton1.PressedBackground = Color.LightSkyBlue;
            cuiButton1.PressedForeColor = Color.White;
            cuiButton1.PressedImageTint = Color.White;
            cuiButton1.PressedOutline = Color.Empty;
            cuiButton1.Rounding = new Padding(8);
            cuiButton1.Size = new Size(342, 276);
            cuiButton1.TabIndex = 14;
            cuiButton1.TextOffset = new Point(-25, 55);
            cuiButton1.Click += cuiButton1_Click;
            // 
            // cuiButtonWtsp
            // 
            cuiButtonWtsp.CheckButton = false;
            cuiButtonWtsp.Checked = false;
            cuiButtonWtsp.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButtonWtsp.CheckedForeColor = Color.White;
            cuiButtonWtsp.CheckedImageTint = Color.White;
            cuiButtonWtsp.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButtonWtsp.Content = "WhatsApp";
            cuiButtonWtsp.DialogResult = DialogResult.None;
            cuiButtonWtsp.Dock = DockStyle.Left;
            cuiButtonWtsp.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButtonWtsp.ForeColor = Color.Black;
            cuiButtonWtsp.HoverBackground = Color.PowderBlue;
            cuiButtonWtsp.HoveredImageTint = Color.White;
            cuiButtonWtsp.HoverForeColor = Color.WhiteSmoke;
            cuiButtonWtsp.HoverOutline = Color.Empty;
            cuiButtonWtsp.Image = (Image)resources.GetObject("cuiButtonWtsp.Image");
            cuiButtonWtsp.ImageAutoCenter = true;
            cuiButtonWtsp.ImageExpand = new Point(17, 17);
            cuiButtonWtsp.ImageOffset = new Point(95, 0);
            cuiButtonWtsp.Location = new Point(1710, 0);
            cuiButtonWtsp.Margin = new Padding(4);
            cuiButtonWtsp.Name = "cuiButtonWtsp";
            cuiButtonWtsp.NormalBackground = Color.WhiteSmoke;
            cuiButtonWtsp.NormalForeColor = Color.Black;
            cuiButtonWtsp.NormalImageTint = Color.White;
            cuiButtonWtsp.NormalOutline = Color.Empty;
            cuiButtonWtsp.OutlineThickness = 1.6F;
            cuiButtonWtsp.PressedBackground = Color.LightSkyBlue;
            cuiButtonWtsp.PressedForeColor = Color.White;
            cuiButtonWtsp.PressedImageTint = Color.White;
            cuiButtonWtsp.PressedOutline = Color.Empty;
            cuiButtonWtsp.Rounding = new Padding(8);
            cuiButtonWtsp.Size = new Size(342, 276);
            cuiButtonWtsp.TabIndex = 12;
            cuiButtonWtsp.TextOffset = new Point(-25, 55);
            cuiButtonWtsp.Click += cuiButtonWtsp_Click;
            // 
            // cuiButtonDelete
            // 
            cuiButtonDelete.CheckButton = false;
            cuiButtonDelete.Checked = false;
            cuiButtonDelete.CheckedBackground = Color.DarkSlateBlue;
            cuiButtonDelete.CheckedForeColor = Color.White;
            cuiButtonDelete.CheckedImageTint = Color.White;
            cuiButtonDelete.CheckedOutline = Color.CornflowerBlue;
            cuiButtonDelete.Content = "Delete";
            cuiButtonDelete.DialogResult = DialogResult.None;
            cuiButtonDelete.Dock = DockStyle.Left;
            cuiButtonDelete.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButtonDelete.ForeColor = Color.Black;
            cuiButtonDelete.HoverBackground = Color.PowderBlue;
            cuiButtonDelete.HoveredImageTint = Color.White;
            cuiButtonDelete.HoverForeColor = Color.White;
            cuiButtonDelete.HoverOutline = Color.Empty;
            cuiButtonDelete.Image = (Image)resources.GetObject("cuiButtonDelete.Image");
            cuiButtonDelete.ImageAutoCenter = true;
            cuiButtonDelete.ImageExpand = new Point(17, 17);
            cuiButtonDelete.ImageOffset = new Point(65, 0);
            cuiButtonDelete.Location = new Point(1368, 0);
            cuiButtonDelete.Margin = new Padding(4);
            cuiButtonDelete.Name = "cuiButtonDelete";
            cuiButtonDelete.NormalBackground = Color.WhiteSmoke;
            cuiButtonDelete.NormalForeColor = Color.Black;
            cuiButtonDelete.NormalImageTint = Color.WhiteSmoke;
            cuiButtonDelete.NormalOutline = Color.Empty;
            cuiButtonDelete.OutlineThickness = 1.6F;
            cuiButtonDelete.PressedBackground = Color.Silver;
            cuiButtonDelete.PressedForeColor = Color.White;
            cuiButtonDelete.PressedImageTint = Color.White;
            cuiButtonDelete.PressedOutline = Color.Empty;
            cuiButtonDelete.Rounding = new Padding(8);
            cuiButtonDelete.Size = new Size(342, 276);
            cuiButtonDelete.TabIndex = 15;
            cuiButtonDelete.TextOffset = new Point(-25, 55);
            cuiButtonDelete.Click += cuiButtonDelete_Click_1;
            // 
            // cuiButtonGenerateReport
            // 
            cuiButtonGenerateReport.CheckButton = false;
            cuiButtonGenerateReport.Checked = false;
            cuiButtonGenerateReport.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButtonGenerateReport.CheckedForeColor = Color.White;
            cuiButtonGenerateReport.CheckedImageTint = Color.White;
            cuiButtonGenerateReport.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButtonGenerateReport.Content = "Generate report";
            cuiButtonGenerateReport.DialogResult = DialogResult.None;
            cuiButtonGenerateReport.Dock = DockStyle.Left;
            cuiButtonGenerateReport.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButtonGenerateReport.ForeColor = Color.Black;
            cuiButtonGenerateReport.HoverBackground = Color.PowderBlue;
            cuiButtonGenerateReport.HoveredImageTint = Color.Transparent;
            cuiButtonGenerateReport.HoverForeColor = Color.White;
            cuiButtonGenerateReport.HoverOutline = Color.Empty;
            cuiButtonGenerateReport.Image = (Image)resources.GetObject("cuiButtonGenerateReport.Image");
            cuiButtonGenerateReport.ImageAutoCenter = true;
            cuiButtonGenerateReport.ImageExpand = new Point(17, 17);
            cuiButtonGenerateReport.ImageOffset = new Point(150, 0);
            cuiButtonGenerateReport.Location = new Point(1026, 0);
            cuiButtonGenerateReport.Margin = new Padding(4);
            cuiButtonGenerateReport.Name = "cuiButtonGenerateReport";
            cuiButtonGenerateReport.NormalBackground = Color.WhiteSmoke;
            cuiButtonGenerateReport.NormalForeColor = Color.Black;
            cuiButtonGenerateReport.NormalImageTint = Color.Azure;
            cuiButtonGenerateReport.NormalOutline = Color.Empty;
            cuiButtonGenerateReport.OutlineThickness = 1.6F;
            cuiButtonGenerateReport.PressedBackground = Color.FromArgb(255, 106, 0);
            cuiButtonGenerateReport.PressedForeColor = Color.White;
            cuiButtonGenerateReport.PressedImageTint = Color.White;
            cuiButtonGenerateReport.PressedOutline = Color.Empty;
            cuiButtonGenerateReport.Rounding = new Padding(8);
            cuiButtonGenerateReport.Size = new Size(342, 276);
            cuiButtonGenerateReport.TabIndex = 10;
            cuiButtonGenerateReport.TextOffset = new Point(-35, 55);
            cuiButtonGenerateReport.Click += cuiButtonReport_Click;
            // 
            // cuiButtonEdit
            // 
            cuiButtonEdit.CheckButton = false;
            cuiButtonEdit.Checked = false;
            cuiButtonEdit.CheckedBackground = Color.DarkSlateBlue;
            cuiButtonEdit.CheckedForeColor = Color.White;
            cuiButtonEdit.CheckedImageTint = Color.White;
            cuiButtonEdit.CheckedOutline = Color.CornflowerBlue;
            cuiButtonEdit.Content = "Edit";
            cuiButtonEdit.DialogResult = DialogResult.None;
            cuiButtonEdit.Dock = DockStyle.Left;
            cuiButtonEdit.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButtonEdit.ForeColor = Color.Black;
            cuiButtonEdit.HoverBackground = Color.PowderBlue;
            cuiButtonEdit.HoveredImageTint = Color.White;
            cuiButtonEdit.HoverForeColor = Color.White;
            cuiButtonEdit.HoverOutline = Color.Empty;
            cuiButtonEdit.Image = (Image)resources.GetObject("cuiButtonEdit.Image");
            cuiButtonEdit.ImageAutoCenter = true;
            cuiButtonEdit.ImageExpand = new Point(17, 17);
            cuiButtonEdit.ImageOffset = new Point(45, 0);
            cuiButtonEdit.Location = new Point(684, 0);
            cuiButtonEdit.Margin = new Padding(4);
            cuiButtonEdit.Name = "cuiButtonEdit";
            cuiButtonEdit.NormalBackground = Color.WhiteSmoke;
            cuiButtonEdit.NormalForeColor = Color.Black;
            cuiButtonEdit.NormalImageTint = Color.WhiteSmoke;
            cuiButtonEdit.NormalOutline = Color.Empty;
            cuiButtonEdit.OutlineThickness = 1.6F;
            cuiButtonEdit.PressedBackground = Color.Silver;
            cuiButtonEdit.PressedForeColor = Color.White;
            cuiButtonEdit.PressedImageTint = Color.White;
            cuiButtonEdit.PressedOutline = Color.Empty;
            cuiButtonEdit.Rounding = new Padding(8);
            cuiButtonEdit.Size = new Size(342, 276);
            cuiButtonEdit.TabIndex = 16;
            cuiButtonEdit.TextOffset = new Point(-25, 55);
            cuiButtonEdit.Click += cuiButtonEdit_Click;
            // 
            // cuiButtonADD
            // 
            cuiButtonADD.CheckButton = false;
            cuiButtonADD.Checked = false;
            cuiButtonADD.CheckedBackground = Color.DarkSlateBlue;
            cuiButtonADD.CheckedForeColor = Color.White;
            cuiButtonADD.CheckedImageTint = Color.White;
            cuiButtonADD.CheckedOutline = Color.CornflowerBlue;
            cuiButtonADD.Content = "Add ";
            cuiButtonADD.DialogResult = DialogResult.None;
            cuiButtonADD.Dock = DockStyle.Left;
            cuiButtonADD.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButtonADD.ForeColor = Color.Black;
            cuiButtonADD.HoverBackground = Color.PowderBlue;
            cuiButtonADD.HoveredImageTint = Color.White;
            cuiButtonADD.HoverForeColor = Color.White;
            cuiButtonADD.HoverOutline = Color.Empty;
            cuiButtonADD.Image = Properties.Resources.icons8_add;
            cuiButtonADD.ImageAutoCenter = true;
            cuiButtonADD.ImageExpand = new Point(17, 17);
            cuiButtonADD.ImageOffset = new Point(55, 0);
            cuiButtonADD.Location = new Point(342, 0);
            cuiButtonADD.Margin = new Padding(4);
            cuiButtonADD.Name = "cuiButtonADD";
            cuiButtonADD.NormalBackground = Color.WhiteSmoke;
            cuiButtonADD.NormalForeColor = Color.Black;
            cuiButtonADD.NormalImageTint = Color.WhiteSmoke;
            cuiButtonADD.NormalOutline = Color.Empty;
            cuiButtonADD.OutlineThickness = 1.6F;
            cuiButtonADD.PressedBackground = Color.Silver;
            cuiButtonADD.PressedForeColor = Color.White;
            cuiButtonADD.PressedImageTint = Color.White;
            cuiButtonADD.PressedOutline = Color.Empty;
            cuiButtonADD.Rounding = new Padding(8);
            cuiButtonADD.Size = new Size(342, 276);
            cuiButtonADD.TabIndex = 6;
            cuiButtonADD.TextOffset = new Point(-25, 55);
            cuiButtonADD.Click += cuiButtonADD_Click;
            // 
            // cuiButtonProgress
            // 
            cuiButtonProgress.CheckButton = false;
            cuiButtonProgress.Checked = false;
            cuiButtonProgress.CheckedBackground = Color.DarkSlateBlue;
            cuiButtonProgress.CheckedForeColor = Color.White;
            cuiButtonProgress.CheckedImageTint = Color.White;
            cuiButtonProgress.CheckedOutline = Color.CornflowerBlue;
            cuiButtonProgress.Content = "Progress";
            cuiButtonProgress.DialogResult = DialogResult.None;
            cuiButtonProgress.Dock = DockStyle.Left;
            cuiButtonProgress.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButtonProgress.ForeColor = Color.Black;
            cuiButtonProgress.HoverBackground = Color.PowderBlue;
            cuiButtonProgress.HoveredImageTint = Color.White;
            cuiButtonProgress.HoverForeColor = Color.White;
            cuiButtonProgress.HoverOutline = Color.Empty;
            cuiButtonProgress.Image = (Image)resources.GetObject("cuiButtonProgress.Image");
            cuiButtonProgress.ImageAutoCenter = true;
            cuiButtonProgress.ImageExpand = new Point(17, 17);
            cuiButtonProgress.ImageOffset = new Point(90, 0);
            cuiButtonProgress.Location = new Point(0, 0);
            cuiButtonProgress.Margin = new Padding(4);
            cuiButtonProgress.Name = "cuiButtonProgress";
            cuiButtonProgress.NormalBackground = Color.WhiteSmoke;
            cuiButtonProgress.NormalForeColor = Color.Black;
            cuiButtonProgress.NormalImageTint = Color.WhiteSmoke;
            cuiButtonProgress.NormalOutline = Color.Empty;
            cuiButtonProgress.OutlineThickness = 1.6F;
            cuiButtonProgress.PressedBackground = Color.Silver;
            cuiButtonProgress.PressedForeColor = Color.White;
            cuiButtonProgress.PressedImageTint = Color.White;
            cuiButtonProgress.PressedOutline = Color.Empty;
            cuiButtonProgress.Rounding = new Padding(8);
            cuiButtonProgress.Size = new Size(342, 276);
            cuiButtonProgress.TabIndex = 17;
            cuiButtonProgress.TextOffset = new Point(-25, 55);
            cuiButtonProgress.Click += cuiButtonProgress_Click;
            // 
            // panelleft
            // 
            panelleft.BackColor = Color.WhiteSmoke;
            panelleft.Controls.Add(treeView);
            panelleft.Dock = DockStyle.Left;
            panelleft.Location = new Point(0, 365);
            panelleft.Margin = new Padding(4);
            panelleft.Name = "panelleft";
            panelleft.Size = new Size(508, 1263);
            panelleft.TabIndex = 2;
            // 
            // treeView
            // 
            treeView.Cursor = Cursors.Hand;
            treeView.Dock = DockStyle.Left;
            treeView.Location = new Point(0, 0);
            treeView.Margin = new Padding(4);
            treeView.Name = "treeView";
            treeNode1.Name = "All ";
            treeNode1.Text = "All ";
            treeNode2.Name = "On leave";
            treeNode2.Text = "On leave";
            treeNode3.Name = "Employees";
            treeNode3.Text = "Employees";
            treeNode4.Name = "Chef de projets ";
            treeNode4.Text = "Chef de projets ";
            treeNode5.Name = "Projets";
            treeNode5.Text = "Projets";
            treeNode6.Name = "Chef d'équipes";
            treeNode6.Text = "Chef d'équipes";
            treeNode7.Name = "Teams";
            treeNode7.Text = "Groups";
            treeNode8.Name = "Tâches sous-traitants";
            treeNode8.Text = "Tâches sous-traitants";
            treeNode9.Name = "Tâches internes ";
            treeNode9.Text = "Tâches internes ";
            treeNode10.Name = "Tâches externes";
            treeNode10.Text = "Tâches externes";
            treeNode11.Name = "Tâches";
            treeNode11.Text = "Tâches";
            treeView.Nodes.AddRange(new TreeNode[] { treeNode3, treeNode5, treeNode7, treeNode11 });
            treeView.Size = new Size(516, 1263);
            treeView.TabIndex = 0;
            treeView.AfterSelect += treeView_AfterSelect;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.WhiteSmoke;
            panelRight.Controls.Add(panel2);
            panelRight.Controls.Add(dataGridView1);
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(2600, 365);
            panelRight.Margin = new Padding(4);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(440, 1263);
            panelRight.TabIndex = 0;
            panelRight.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(labelRole);
            panel2.Controls.Add(labelPrenom);
            panel2.Controls.Add(labelNom);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(6);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 363);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelRole.Location = new Point(50, 196);
            labelRole.Margin = new Padding(6, 0, 6, 0);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(187, 46);
            labelRole.TabIndex = 2;
            labelRole.Text = "labelRole";
            // 
            // labelPrenom
            // 
            labelPrenom.AutoSize = true;
            labelPrenom.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrenom.Location = new Point(50, 140);
            labelPrenom.Margin = new Padding(6, 0, 6, 0);
            labelPrenom.Name = "labelPrenom";
            labelPrenom.Size = new Size(305, 55);
            labelPrenom.TabIndex = 1;
            labelPrenom.Text = "labelPrenom";
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNom.Location = new Point(12, 69);
            labelNom.Margin = new Padding(6, 0, 6, 0);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(311, 73);
            labelNom.TabIndex = 0;
            labelNom.Text = "labelNom";
            labelNom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1356, 0);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 123;
            dataGridView1.Size = new Size(48, 1263);
            dataGridView1.TabIndex = 3;
            // 
            // contextMenuAdd
            // 
            contextMenuAdd.BackColor = Color.LightSteelBlue;
            contextMenuAdd.ImageScalingSize = new Size(48, 48);
            contextMenuAdd.Items.AddRange(new ToolStripItem[] { addEmployeeToolStripMenuItem, addTeamToolStripMenuItem, AddTasktoolStripMenuItem, AddProjettoolStripMenuItem });
            contextMenuAdd.Name = "contextMenuAdd";
            contextMenuAdd.ShowCheckMargin = true;
            contextMenuAdd.Size = new Size(353, 228);
            contextMenuAdd.Opening += contextMenuAdd_Opening;
            // 
            // addEmployeeToolStripMenuItem
            // 
            addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            addEmployeeToolStripMenuItem.Size = new Size(352, 56);
            addEmployeeToolStripMenuItem.Text = "Add Employee";
            addEmployeeToolStripMenuItem.Click += addEmployeeToolStripMenuItem_Click;
            // 
            // addTeamToolStripMenuItem
            // 
            addTeamToolStripMenuItem.Name = "addTeamToolStripMenuItem";
            addTeamToolStripMenuItem.Size = new Size(352, 56);
            addTeamToolStripMenuItem.Text = "Add Team";
            addTeamToolStripMenuItem.Click += addTeamToolStripMenuItem_Click;
            // 
            // AddTasktoolStripMenuItem
            // 
            AddTasktoolStripMenuItem.Name = "AddTasktoolStripMenuItem";
            AddTasktoolStripMenuItem.Size = new Size(352, 56);
            AddTasktoolStripMenuItem.Text = "Add Task";
            AddTasktoolStripMenuItem.Click += AddTasktoolStripMenuItem_Click;
            // 
            // AddProjettoolStripMenuItem
            // 
            AddProjettoolStripMenuItem.Name = "AddProjettoolStripMenuItem";
            AddProjettoolStripMenuItem.Size = new Size(352, 56);
            AddProjettoolStripMenuItem.Text = "Add Project";
            AddProjettoolStripMenuItem.Click += AddProjettoolStripMenuItem_Click;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.Control;
            dataGridView.ColumnHeadersHeight = 69;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(508, 365);
            dataGridView.Margin = new Padding(4);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 123;
            dataGridView.Size = new Size(2092, 1263);
            dataGridView.TabIndex = 1;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // textDataGridViewTextBoxColumn
            // 
            textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            textDataGridViewTextBoxColumn.HeaderText = "Text";
            textDataGridViewTextBoxColumn.MinimumWidth = 15;
            textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            textDataGridViewTextBoxColumn.Width = 300;
            // 
            // contextMenuEdit
            // 
            contextMenuEdit.ImageScalingSize = new Size(48, 48);
            contextMenuEdit.Items.AddRange(new ToolStripItem[] { editTaskInfoToolStripMenuItem, editTeamInfoToolStripMenuItem, editUserInfoToolStripMenuItem, editProjectInfoToolStripMenuItem });
            contextMenuEdit.Name = "contextMenuEdit";
            contextMenuEdit.Size = new Size(354, 228);
            contextMenuEdit.Opening += contextMenuEdit_Opening;
            // 
            // editTaskInfoToolStripMenuItem
            // 
            editTaskInfoToolStripMenuItem.Name = "editTaskInfoToolStripMenuItem";
            editTaskInfoToolStripMenuItem.Size = new Size(353, 56);
            editTaskInfoToolStripMenuItem.Text = "Edit Task Info";
            editTaskInfoToolStripMenuItem.Click += editTaskInfoToolStripMenuItem_Click;
            // 
            // editTeamInfoToolStripMenuItem
            // 
            editTeamInfoToolStripMenuItem.Name = "editTeamInfoToolStripMenuItem";
            editTeamInfoToolStripMenuItem.Size = new Size(353, 56);
            editTeamInfoToolStripMenuItem.Text = "Edit Team Info";
            editTeamInfoToolStripMenuItem.Click += editTeamInfoToolStripMenuItem_Click_1;
            // 
            // editUserInfoToolStripMenuItem
            // 
            editUserInfoToolStripMenuItem.Name = "editUserInfoToolStripMenuItem";
            editUserInfoToolStripMenuItem.Size = new Size(353, 56);
            editUserInfoToolStripMenuItem.Text = "Edit User Info";
            editUserInfoToolStripMenuItem.Click += editUserInfoToolStripMenuItem_Click;
            // 
            // editProjectInfoToolStripMenuItem
            // 
            editProjectInfoToolStripMenuItem.Name = "editProjectInfoToolStripMenuItem";
            editProjectInfoToolStripMenuItem.Size = new Size(353, 56);
            editProjectInfoToolStripMenuItem.Text = "Edit Project Info";
            editProjectInfoToolStripMenuItem.Click += editProjectInfoToolStripMenuItem_Click;
            // 
            // contextMenuDelete
            // 
            contextMenuDelete.ImageScalingSize = new Size(48, 48);
            contextMenuDelete.Items.AddRange(new ToolStripItem[] { deleteEmployeeToolStripMenuItem, deleteTeamToolStripMenuItem, deleteTaskToolStripMenuItem, deleteProjectToolStripMenuItem });
            contextMenuDelete.Name = "contextMenuStrip1";
            contextMenuDelete.Size = new Size(369, 228);
            contextMenuDelete.Opening += contextMenuDelete_Opening;
            // 
            // deleteEmployeeToolStripMenuItem
            // 
            deleteEmployeeToolStripMenuItem.Name = "deleteEmployeeToolStripMenuItem";
            deleteEmployeeToolStripMenuItem.Size = new Size(368, 56);
            deleteEmployeeToolStripMenuItem.Text = "Delete Employee";
            deleteEmployeeToolStripMenuItem.Click += deleteEmployeeToolStripMenuItem_Click;
            // 
            // deleteTeamToolStripMenuItem
            // 
            deleteTeamToolStripMenuItem.Name = "deleteTeamToolStripMenuItem";
            deleteTeamToolStripMenuItem.Size = new Size(368, 56);
            deleteTeamToolStripMenuItem.Text = "Delete Team";
            deleteTeamToolStripMenuItem.Click += deleteTeamToolStripMenuItem_Click;
            // 
            // deleteTaskToolStripMenuItem
            // 
            deleteTaskToolStripMenuItem.Name = "deleteTaskToolStripMenuItem";
            deleteTaskToolStripMenuItem.Size = new Size(368, 56);
            deleteTaskToolStripMenuItem.Text = "Delete Task";
            deleteTaskToolStripMenuItem.Click += deleteTaskToolStripMenuItem_Click;
            // 
            // deleteProjectToolStripMenuItem
            // 
            deleteProjectToolStripMenuItem.Name = "deleteProjectToolStripMenuItem";
            deleteProjectToolStripMenuItem.Size = new Size(368, 56);
            deleteProjectToolStripMenuItem.Text = "Delete Project";
            deleteProjectToolStripMenuItem.Click += deleteProjectToolStripMenuItem_Click;
            // 
            // MenuAdmin
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(3040, 1628);
            Controls.Add(dataGridView);
            Controls.Add(panelRight);
            Controls.Add(panelleft);
            Controls.Add(panelsup2);
            Controls.Add(panelSup);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MinimumSize = new Size(1200, 801);
            Name = "MenuAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "  ";
            Load += MenuDeApp_Load;
            panelSup.ResumeLayout(false);
            panelSup.PerformLayout();
            panelsup2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelleft.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            contextMenuEdit.ResumeLayout(false);
            contextMenuDelete.ResumeLayout(false);
            ResumeLayout(false);
        }



        private void treeViewEmployee_AfterSelect(object sender, TreeViewEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panelSup;
        private Panel panelsup2;
        private Panel panelleft;
        private Panel panelRight;
        public CuoreUI.Controls.cuiButton cuiButtonADD;
        private CuoreUI.Controls.cuiButton cuiButtonGenerateReport;
        private CuoreUI.Controls.cuiButton cuiButtonWtsp;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuAdd;
        private ToolStripMenuItem addEmployeeToolStripMenuItem;
        private ToolStripMenuItem addTeamToolStripMenuItem;
        private TreeView treeView;
        private DataGridView dataGridView;
        private ToolStripMenuItem AddTasktoolStripMenuItem;
        private ToolStripMenuItem AddProjettoolStripMenuItem;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        public CuoreUI.Controls.cuiButton cuiButtonDelete;
        public CuoreUI.Controls.cuiButton cuiButtonEdit;
        public CuoreUI.Controls.cuiButton cuiButtonProgress;
        private ContextMenuStrip contextMenuEdit;
        private ToolStripMenuItem editTaskInfoToolStripMenuItem;
        private ToolStripMenuItem editTeamInfoToolStripMenuItem;
        private ToolStripMenuItem editUserInfoToolStripMenuItem;
        private ToolStripMenuItem editProjectInfoToolStripMenuItem;
        private ContextMenuStrip contextMenuDelete;
        private ToolStripMenuItem deleteEmployeeToolStripMenuItem;
        private ToolStripMenuItem deleteTeamToolStripMenuItem;
        private ToolStripMenuItem deleteTaskToolStripMenuItem;
        private ToolStripMenuItem deleteProjectToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private Label labelRole;
        private Label labelPrenom;
        private Label labelNom;
        private Label label1;
        private Label btnLower;
        private Label lblLogOut;
    }
}
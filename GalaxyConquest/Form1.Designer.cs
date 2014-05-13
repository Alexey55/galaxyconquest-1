namespace GalaxyConquest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mainMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mainMenuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuText = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuTechTree = new System.Windows.Forms.ToolStripMenuItem();
            this.Close_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusSelectFleet = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusXY = new System.Windows.Forms.ToolStripStatusLabel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.tech_progressBar = new System.Windows.Forms.ProgressBar();
            this.tech_label = new System.Windows.Forms.Label();
            this.Credits = new System.Windows.Forms.Label();
            this.CreditsStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.galaxyImage = new System.Windows.Forms.PictureBox();
            this.buttonSpinLeft = new System.Windows.Forms.Button();
            this.buttonSpinRight = new System.Windows.Forms.Button();
            this.buttonSpinUp = new System.Windows.Forms.Button();
            this.buttonSpinDown = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.buttonMoveRight = new System.Windows.Forms.Button();
            this.buttonMoveLeft = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.conquer_progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonScalingUp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonScalingDown = new System.Windows.Forms.Button();
            this.textBox_planets = new System.Windows.Forms.TextBox();
            this.step_button = new System.Windows.Forms.Button();
            this.label_planets = new System.Windows.Forms.Label();
            this.sound_button = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galaxyImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.Transparent;
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuFile,
            this.mainMenuText,
            this.MainMenuTechTree,
            this.Close_btn});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(225, 30);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // mainMenuFile
            // 
            this.mainMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuNew,
            this.mainMenuOpen,
            this.mainMenuSave,
            this.toolStripSeparator1,
            this.mainMenuQuit});
            this.mainMenuFile.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenuFile.ForeColor = System.Drawing.Color.DarkCyan;
            this.mainMenuFile.Name = "mainMenuFile";
            this.mainMenuFile.Size = new System.Drawing.Size(55, 26);
            this.mainMenuFile.Text = "File";
            // 
            // mainMenuNew
            // 
            this.mainMenuNew.ForeColor = System.Drawing.Color.DarkCyan;
            this.mainMenuNew.Name = "mainMenuNew";
            this.mainMenuNew.Size = new System.Drawing.Size(143, 26);
            this.mainMenuNew.Text = "New";
            this.mainMenuNew.Click += new System.EventHandler(this.mainMenuNew_Click);
            // 
            // mainMenuOpen
            // 
            this.mainMenuOpen.ForeColor = System.Drawing.Color.DarkCyan;
            this.mainMenuOpen.Name = "mainMenuOpen";
            this.mainMenuOpen.Size = new System.Drawing.Size(143, 26);
            this.mainMenuOpen.Text = "Open...";
            this.mainMenuOpen.Click += new System.EventHandler(this.mainMenuOpen_Click);
            // 
            // mainMenuSave
            // 
            this.mainMenuSave.ForeColor = System.Drawing.Color.DarkCyan;
            this.mainMenuSave.Name = "mainMenuSave";
            this.mainMenuSave.Size = new System.Drawing.Size(143, 26);
            this.mainMenuSave.Text = "Save...";
            this.mainMenuSave.Click += new System.EventHandler(this.mainMenuSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.DarkCyan;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // mainMenuQuit
            // 
            this.mainMenuQuit.ForeColor = System.Drawing.Color.DarkCyan;
            this.mainMenuQuit.Name = "mainMenuQuit";
            this.mainMenuQuit.Size = new System.Drawing.Size(143, 26);
            this.mainMenuQuit.Text = "Quit";
            this.mainMenuQuit.Click += new System.EventHandler(this.mainMenuQuit_Click);
            // 
            // mainMenuText
            // 
            this.mainMenuText.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mainMenuText.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuAbout});
            this.mainMenuText.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenuText.ForeColor = System.Drawing.Color.DarkCyan;
            this.mainMenuText.Image = global::GalaxyConquest.Properties.Resources.help;
            this.mainMenuText.Name = "mainMenuText";
            this.mainMenuText.Size = new System.Drawing.Size(28, 26);
            // 
            // mainMenuAbout
            // 
            this.mainMenuAbout.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuAbout.ForeColor = System.Drawing.Color.DarkCyan;
            this.mainMenuAbout.Name = "mainMenuAbout";
            this.mainMenuAbout.Size = new System.Drawing.Size(152, 26);
            this.mainMenuAbout.Text = "About...";
            this.mainMenuAbout.Click += new System.EventHandler(this.mainMenuAbout_Click);
            // 
            // MainMenuTechTree
            // 
            this.MainMenuTechTree.BackColor = System.Drawing.Color.Transparent;
            this.MainMenuTechTree.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuTechTree.ForeColor = System.Drawing.Color.DarkCyan;
            this.MainMenuTechTree.Image = global::GalaxyConquest.Properties.Resources.configure;
            this.MainMenuTechTree.Name = "MainMenuTechTree";
            this.MainMenuTechTree.Size = new System.Drawing.Size(122, 26);
            this.MainMenuTechTree.Text = "Tech tree";
            this.MainMenuTechTree.Click += new System.EventHandler(this.MainMenuTechTree_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.BackgroundImage = global::GalaxyConquest.Properties.Resources.close;
            this.Close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(12, 26);
            this.Close_btn.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusSelectFleet,
            this.toolStripStatusXY});
            this.statusStrip1.Location = new System.Drawing.Point(0, 634);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1378, 27);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusSelectFleet
            // 
            this.toolStripStatusSelectFleet.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusSelectFleet.ForeColor = System.Drawing.Color.DarkCyan;
            this.toolStripStatusSelectFleet.Name = "toolStripStatusSelectFleet";
            this.toolStripStatusSelectFleet.Size = new System.Drawing.Size(253, 22);
            this.toolStripStatusSelectFleet.Text = "toolStripStatusSelectFleet";
            // 
            // toolStripStatusXY
            // 
            this.toolStripStatusXY.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusXY.ForeColor = System.Drawing.Color.DarkCyan;
            this.toolStripStatusXY.Name = "toolStripStatusXY";
            this.toolStripStatusXY.Size = new System.Drawing.Size(175, 22);
            this.toolStripStatusXY.Text = "toolStripStatusXY";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vScrollBar1.LargeChange = 100;
            this.vScrollBar1.Location = new System.Drawing.Point(7, 84);
            this.vScrollBar1.Maximum = 500;
            this.vScrollBar1.Minimum = -500;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 478);
            this.vScrollBar1.SmallChange = 50;
            this.vScrollBar1.TabIndex = 15;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hScrollBar1.LargeChange = 100;
            this.hScrollBar1.Location = new System.Drawing.Point(199, 562);
            this.hScrollBar1.Maximum = 500;
            this.hScrollBar1.Minimum = -500;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(893, 15);
            this.hScrollBar1.SmallChange = 50;
            this.hScrollBar1.TabIndex = 14;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // tech_progressBar
            // 
            this.tech_progressBar.Location = new System.Drawing.Point(68, 446);
            this.tech_progressBar.Maximum = 5;
            this.tech_progressBar.Name = "tech_progressBar";
            this.tech_progressBar.Size = new System.Drawing.Size(100, 23);
            this.tech_progressBar.Step = 1;
            this.tech_progressBar.TabIndex = 22;
            this.tech_progressBar.Visible = false;
            // 
            // tech_label
            // 
            this.tech_label.AutoSize = true;
            this.tech_label.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tech_label.ForeColor = System.Drawing.Color.DarkCyan;
            this.tech_label.Location = new System.Drawing.Point(-3, 446);
            this.tech_label.Name = "tech_label";
            this.tech_label.Size = new System.Drawing.Size(65, 22);
            this.tech_label.TabIndex = 23;
            this.tech_label.Text = "label1";
            // 
            // Credits
            // 
            this.Credits.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Credits.AutoSize = true;
            this.Credits.Location = new System.Drawing.Point(30, 25);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(75, 22);
            this.Credits.TabIndex = 40;
            this.Credits.Text = "Credits";
            // 
            // CreditsStatus
            // 
            this.CreditsStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CreditsStatus.AutoSize = true;
            this.CreditsStatus.Location = new System.Drawing.Point(40, 56);
            this.CreditsStatus.Name = "CreditsStatus";
            this.CreditsStatus.Size = new System.Drawing.Size(65, 22);
            this.CreditsStatus.TabIndex = 41;
            this.CreditsStatus.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.CreditsStatus);
            this.groupBox1.Controls.Add(this.Credits);
            this.groupBox1.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Location = new System.Drawing.Point(12, 543);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 81);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::GalaxyConquest.Properties.Resources.background_main;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.galaxyImage);
            this.panel2.Controls.Add(this.buttonSpinLeft);
            this.panel2.Controls.Add(this.buttonSpinRight);
            this.panel2.Controls.Add(this.hScrollBar1);
            this.panel2.Controls.Add(this.vScrollBar1);
            this.panel2.Location = new System.Drawing.Point(174, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1178, 591);
            this.panel2.TabIndex = 43;
            // 
            // galaxyImage
            // 
            this.galaxyImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.galaxyImage.BackColor = System.Drawing.Color.Black;
            this.galaxyImage.Location = new System.Drawing.Point(35, 15);
            this.galaxyImage.Name = "galaxyImage";
            this.galaxyImage.Size = new System.Drawing.Size(1132, 535);
            this.galaxyImage.TabIndex = 1;
            this.galaxyImage.TabStop = false;
            this.galaxyImage.Click += new System.EventHandler(this.galaxyImage_Click);
            this.galaxyImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.galaxyImage_MouseClick);
            this.galaxyImage.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.galaxyImage_MouseDoubleClick);
            this.galaxyImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.galaxyImage_MouseDown);
            this.galaxyImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.galaxyImage_MouseMove);
            // 
            // buttonSpinLeft
            // 
            this.buttonSpinLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSpinLeft.FlatAppearance.BorderSize = 0;
            this.buttonSpinLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpinLeft.Image = global::GalaxyConquest.Properties.Resources.btn_rotateright;
            this.buttonSpinLeft.Location = new System.Drawing.Point(73, 566);
            this.buttonSpinLeft.Name = "buttonSpinLeft";
            this.buttonSpinLeft.Size = new System.Drawing.Size(64, 26);
            this.buttonSpinLeft.TabIndex = 4;
            this.buttonSpinLeft.UseVisualStyleBackColor = true;
            this.buttonSpinLeft.Click += new System.EventHandler(this.buttonSpinLeft_Click);
            // 
            // buttonSpinRight
            // 
            this.buttonSpinRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSpinRight.FlatAppearance.BorderSize = 0;
            this.buttonSpinRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpinRight.Image = global::GalaxyConquest.Properties.Resources.btn_rotateleft;
            this.buttonSpinRight.Location = new System.Drawing.Point(3, 565);
            this.buttonSpinRight.Name = "buttonSpinRight";
            this.buttonSpinRight.Size = new System.Drawing.Size(64, 26);
            this.buttonSpinRight.TabIndex = 5;
            this.buttonSpinRight.UseVisualStyleBackColor = true;
            this.buttonSpinRight.Click += new System.EventHandler(this.buttonSpinRight_Click);
            // 
            // buttonSpinUp
            // 
            this.buttonSpinUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSpinUp.FlatAppearance.BorderSize = 0;
            this.buttonSpinUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpinUp.Image = global::GalaxyConquest.Properties.Resources.btn_spinup;
            this.buttonSpinUp.Location = new System.Drawing.Point(1352, 493);
            this.buttonSpinUp.Name = "buttonSpinUp";
            this.buttonSpinUp.Size = new System.Drawing.Size(26, 64);
            this.buttonSpinUp.TabIndex = 6;
            this.buttonSpinUp.UseVisualStyleBackColor = true;
            this.buttonSpinUp.Click += new System.EventHandler(this.buttonSpinUp_Click);
            // 
            // buttonSpinDown
            // 
            this.buttonSpinDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSpinDown.FlatAppearance.BorderSize = 0;
            this.buttonSpinDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpinDown.Image = global::GalaxyConquest.Properties.Resources.btn_spindown;
            this.buttonSpinDown.Location = new System.Drawing.Point(1352, 561);
            this.buttonSpinDown.Name = "buttonSpinDown";
            this.buttonSpinDown.Size = new System.Drawing.Size(26, 64);
            this.buttonSpinDown.TabIndex = 7;
            this.buttonSpinDown.UseVisualStyleBackColor = true;
            this.buttonSpinDown.Click += new System.EventHandler(this.buttonSpinDown_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.buttonMoveUp);
            this.panel1.Controls.Add(this.buttonMoveRight);
            this.panel1.Controls.Add(this.buttonMoveLeft);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.buttonMoveDown);
            this.panel1.Controls.Add(this.conquer_progressBar);
            this.panel1.Controls.Add(this.buttonScalingUp);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.buttonScalingDown);
            this.panel1.Controls.Add(this.textBox_planets);
            this.panel1.Controls.Add(this.step_button);
            this.panel1.Controls.Add(this.label_planets);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 396);
            this.panel1.TabIndex = 25;
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.FlatAppearance.BorderSize = 0;
            this.buttonMoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoveUp.Image = global::GalaxyConquest.Properties.Resources.btn_arrowup;
            this.buttonMoveUp.Location = new System.Drawing.Point(68, 41);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(21, 21);
            this.buttonMoveUp.TabIndex = 10;
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
            // 
            // buttonMoveRight
            // 
            this.buttonMoveRight.FlatAppearance.BorderSize = 0;
            this.buttonMoveRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoveRight.Image = global::GalaxyConquest.Properties.Resources.btn_arrowright;
            this.buttonMoveRight.Location = new System.Drawing.Point(90, 61);
            this.buttonMoveRight.Name = "buttonMoveRight";
            this.buttonMoveRight.Size = new System.Drawing.Size(21, 21);
            this.buttonMoveRight.TabIndex = 12;
            this.buttonMoveRight.UseVisualStyleBackColor = true;
            this.buttonMoveRight.Click += new System.EventHandler(this.buttonMoveRight_Click);
            // 
            // buttonMoveLeft
            // 
            this.buttonMoveLeft.FlatAppearance.BorderSize = 0;
            this.buttonMoveLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoveLeft.Image = global::GalaxyConquest.Properties.Resources.btn_arrowleft;
            this.buttonMoveLeft.Location = new System.Drawing.Point(46, 61);
            this.buttonMoveLeft.Name = "buttonMoveLeft";
            this.buttonMoveLeft.Size = new System.Drawing.Size(21, 21);
            this.buttonMoveLeft.TabIndex = 11;
            this.buttonMoveLeft.UseVisualStyleBackColor = true;
            this.buttonMoveLeft.Click += new System.EventHandler(this.buttonMoveLeft_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.DarkCyan;
            this.button3.Location = new System.Drawing.Point(18, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 33);
            this.button3.TabIndex = 21;
            this.button3.Text = "Отменить захват";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.FlatAppearance.BorderSize = 0;
            this.buttonMoveDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoveDown.Image = global::GalaxyConquest.Properties.Resources.btn_arrowdown;
            this.buttonMoveDown.Location = new System.Drawing.Point(68, 82);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(21, 21);
            this.buttonMoveDown.TabIndex = 13;
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
            // 
            // conquer_progressBar
            // 
            this.conquer_progressBar.Location = new System.Drawing.Point(29, 257);
            this.conquer_progressBar.Maximum = 5;
            this.conquer_progressBar.Name = "conquer_progressBar";
            this.conquer_progressBar.Size = new System.Drawing.Size(100, 20);
            this.conquer_progressBar.Step = 1;
            this.conquer_progressBar.TabIndex = 20;
            this.conquer_progressBar.Visible = false;
            // 
            // buttonScalingUp
            // 
            this.buttonScalingUp.FlatAppearance.BorderSize = 0;
            this.buttonScalingUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScalingUp.Image = global::GalaxyConquest.Properties.Resources.btn_plus;
            this.buttonScalingUp.Location = new System.Drawing.Point(46, 112);
            this.buttonScalingUp.Name = "buttonScalingUp";
            this.buttonScalingUp.Size = new System.Drawing.Size(21, 21);
            this.buttonScalingUp.TabIndex = 8;
            this.buttonScalingUp.UseVisualStyleBackColor = true;
            this.buttonScalingUp.Click += new System.EventHandler(this.buttonScalingUp_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.DarkCyan;
            this.button2.Location = new System.Drawing.Point(18, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 28);
            this.button2.TabIndex = 19;
            this.button2.Text = "Захватить систему";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonScalingDown
            // 
            this.buttonScalingDown.FlatAppearance.BorderSize = 0;
            this.buttonScalingDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScalingDown.Image = global::GalaxyConquest.Properties.Resources.btn_minus;
            this.buttonScalingDown.Location = new System.Drawing.Point(90, 112);
            this.buttonScalingDown.Name = "buttonScalingDown";
            this.buttonScalingDown.Size = new System.Drawing.Size(21, 21);
            this.buttonScalingDown.TabIndex = 9;
            this.buttonScalingDown.UseVisualStyleBackColor = true;
            this.buttonScalingDown.Click += new System.EventHandler(this.buttonScalingDown_Click);
            // 
            // textBox_planets
            // 
            this.textBox_planets.BackColor = System.Drawing.Color.Black;
            this.textBox_planets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_planets.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_planets.ForeColor = System.Drawing.Color.DarkCyan;
            this.textBox_planets.Location = new System.Drawing.Point(101, 177);
            this.textBox_planets.Name = "textBox_planets";
            this.textBox_planets.ReadOnly = true;
            this.textBox_planets.Size = new System.Drawing.Size(39, 22);
            this.textBox_planets.TabIndex = 17;
            this.textBox_planets.Visible = false;
            // 
            // step_button
            // 
            this.step_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.step_button.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step_button.ForeColor = System.Drawing.Color.DarkCyan;
            this.step_button.Location = new System.Drawing.Point(40, 139);
            this.step_button.Name = "step_button";
            this.step_button.Size = new System.Drawing.Size(71, 32);
            this.step_button.TabIndex = 18;
            this.step_button.Text = "STEP";
            this.step_button.UseVisualStyleBackColor = true;
            this.step_button.Click += new System.EventHandler(this.step_button_Click);
            // 
            // label_planets
            // 
            this.label_planets.AutoSize = true;
            this.label_planets.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_planets.ForeColor = System.Drawing.Color.DarkCyan;
            this.label_planets.Location = new System.Drawing.Point(14, 177);
            this.label_planets.Name = "label_planets";
            this.label_planets.Size = new System.Drawing.Size(78, 22);
            this.label_planets.TabIndex = 16;
            this.label_planets.Text = "Planets";
            this.label_planets.Visible = false;
            // 
            // sound_button
            // 
            this.sound_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sound_button.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sound_button.ForeColor = System.Drawing.Color.DarkCyan;
            this.sound_button.Location = new System.Drawing.Point(1371, 785);
            this.sound_button.Name = "sound_button";
            this.sound_button.Size = new System.Drawing.Size(79, 30);
            this.sound_button.TabIndex = 24;
            this.sound_button.Text = "mute on/off";
            this.sound_button.UseVisualStyleBackColor = true;
            this.sound_button.Click += new System.EventHandler(this.sound_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1378, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sound_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSpinUp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSpinDown);
            this.Controls.Add(this.tech_label);
            this.Controls.Add(this.tech_progressBar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainMenu);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Form1";
            this.Text = "GalaxyConquest";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.galaxyImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mainMenuFile;
        private System.Windows.Forms.ToolStripMenuItem mainMenuQuit;
        private System.Windows.Forms.PictureBox galaxyImage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuNew;
        private System.Windows.Forms.Button buttonSpinLeft;
        private System.Windows.Forms.Button buttonSpinRight;
        private System.Windows.Forms.Button buttonSpinUp;
        private System.Windows.Forms.Button buttonSpinDown;
        private System.Windows.Forms.ToolStripMenuItem mainMenuOpen;
        private System.Windows.Forms.ToolStripMenuItem mainMenuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuText;
        private System.Windows.Forms.ToolStripMenuItem mainMenuAbout;
        private System.Windows.Forms.Button buttonScalingUp;
        private System.Windows.Forms.Button buttonScalingDown;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Button buttonMoveLeft;
        private System.Windows.Forms.Button buttonMoveRight;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.ToolStripMenuItem MainMenuTechTree;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label_planets;
        private System.Windows.Forms.TextBox textBox_planets;
        private System.Windows.Forms.Button step_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar conquer_progressBar;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.ProgressBar tech_progressBar;
        public System.Windows.Forms.Label tech_label;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusSelectFleet;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusXY;
        private System.Windows.Forms.Button sound_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Credits;
        private System.Windows.Forms.Label CreditsStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem Close_btn;
    }
}


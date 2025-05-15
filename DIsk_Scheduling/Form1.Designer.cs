namespace DIsk_Scheduling
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage_Setting = new System.Windows.Forms.TabPage();
            this.txt_HeadValue = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_FillRandom = new System.Windows.Forms.Button();
            this.btn_clook = new System.Windows.Forms.RadioButton();
            this.btn_cscan = new System.Windows.Forms.RadioButton();
            this.btn_Scan = new System.Windows.Forms.RadioButton();
            this.btn_SSTF = new System.Windows.Forms.RadioButton();
            this.btn_FCFS = new System.Windows.Forms.RadioButton();
            this.tabPage_Control = new System.Windows.Forms.TabPage();
            this.lb_MaxCy = new System.Windows.Forms.Label();
            this.lb_MinCy = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.HeadValue = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Report = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SeekCnt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_Setting = new System.Windows.Forms.Panel();
            this.panel_Graph = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_Time = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPage_Setting.SuspendLayout();
            this.tabPage_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadValue)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_Report.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel_Setting.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.editToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(1984, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(63, 31);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(147, 32);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(147, 32);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(147, 32);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 32);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(66, 31);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(87, 31);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.aboutUsToolStripMenuItem.Text = "About us";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage_Setting);
            this.TabControl.Controls.Add(this.tabPage_Control);
            this.TabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(818, 366);
            this.TabControl.TabIndex = 1;
            // 
            // tabPage_Setting
            // 
            this.tabPage_Setting.Controls.Add(this.txt_HeadValue);
            this.tabPage_Setting.Controls.Add(this.button1);
            this.tabPage_Setting.Controls.Add(this.label2);
            this.tabPage_Setting.Controls.Add(this.txt_Input);
            this.tabPage_Setting.Controls.Add(this.label1);
            this.tabPage_Setting.Controls.Add(this.btn_Clear);
            this.tabPage_Setting.Controls.Add(this.btn_FillRandom);
            this.tabPage_Setting.Controls.Add(this.btn_clook);
            this.tabPage_Setting.Controls.Add(this.btn_cscan);
            this.tabPage_Setting.Controls.Add(this.btn_Scan);
            this.tabPage_Setting.Controls.Add(this.btn_SSTF);
            this.tabPage_Setting.Controls.Add(this.btn_FCFS);
            this.tabPage_Setting.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Setting.Location = new System.Drawing.Point(4, 33);
            this.tabPage_Setting.Name = "tabPage_Setting";
            this.tabPage_Setting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Setting.Size = new System.Drawing.Size(810, 329);
            this.tabPage_Setting.TabIndex = 0;
            this.tabPage_Setting.Text = "Setting";
            this.tabPage_Setting.UseVisualStyleBackColor = true;
            // 
            // txt_HeadValue
            // 
            this.txt_HeadValue.Location = new System.Drawing.Point(169, 53);
            this.txt_HeadValue.Multiline = true;
            this.txt_HeadValue.Name = "txt_HeadValue";
            this.txt_HeadValue.Size = new System.Drawing.Size(626, 57);
            this.txt_HeadValue.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 57);
            this.button1.TabIndex = 10;
            this.button1.Text = "Head Position";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(249, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please separate numbers using commas (\',\').\r\n";
            // 
            // txt_Input
            // 
            this.txt_Input.Location = new System.Drawing.Point(169, 126);
            this.txt_Input.Multiline = true;
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(626, 130);
            this.txt_Input.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Disk Request:";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(10, 199);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(153, 57);
            this.btn_Clear.TabIndex = 1;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_FillRandom
            // 
            this.btn_FillRandom.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FillRandom.Location = new System.Drawing.Point(10, 126);
            this.btn_FillRandom.Name = "btn_FillRandom";
            this.btn_FillRandom.Size = new System.Drawing.Size(153, 57);
            this.btn_FillRandom.TabIndex = 0;
            this.btn_FillRandom.Text = "Fill Random";
            this.btn_FillRandom.UseVisualStyleBackColor = true;
            this.btn_FillRandom.Click += new System.EventHandler(this.btn_FillRandom_Click);
            // 
            // btn_clook
            // 
            this.btn_clook.AutoSize = true;
            this.btn_clook.Location = new System.Drawing.Point(655, 294);
            this.btn_clook.Name = "btn_clook";
            this.btn_clook.Size = new System.Drawing.Size(108, 28);
            this.btn_clook.TabIndex = 9;
            this.btn_clook.TabStop = true;
            this.btn_clook.Text = "C-LOOK";
            this.btn_clook.UseVisualStyleBackColor = true;
            // 
            // btn_cscan
            // 
            this.btn_cscan.AutoSize = true;
            this.btn_cscan.Location = new System.Drawing.Point(486, 294);
            this.btn_cscan.Name = "btn_cscan";
            this.btn_cscan.Size = new System.Drawing.Size(106, 28);
            this.btn_cscan.TabIndex = 8;
            this.btn_cscan.TabStop = true;
            this.btn_cscan.Text = "C-SCAN";
            this.btn_cscan.UseVisualStyleBackColor = true;
            // 
            // btn_Scan
            // 
            this.btn_Scan.AutoSize = true;
            this.btn_Scan.Location = new System.Drawing.Point(339, 294);
            this.btn_Scan.Name = "btn_Scan";
            this.btn_Scan.Size = new System.Drawing.Size(84, 28);
            this.btn_Scan.TabIndex = 7;
            this.btn_Scan.TabStop = true;
            this.btn_Scan.Text = "SCAN";
            this.btn_Scan.UseVisualStyleBackColor = true;
            // 
            // btn_SSTF
            // 
            this.btn_SSTF.AutoSize = true;
            this.btn_SSTF.Location = new System.Drawing.Point(195, 294);
            this.btn_SSTF.Name = "btn_SSTF";
            this.btn_SSTF.Size = new System.Drawing.Size(81, 28);
            this.btn_SSTF.TabIndex = 6;
            this.btn_SSTF.TabStop = true;
            this.btn_SSTF.Text = "SSTF";
            this.btn_SSTF.UseVisualStyleBackColor = true;
            // 
            // btn_FCFS
            // 
            this.btn_FCFS.AutoSize = true;
            this.btn_FCFS.Location = new System.Drawing.Point(49, 294);
            this.btn_FCFS.Name = "btn_FCFS";
            this.btn_FCFS.Size = new System.Drawing.Size(83, 28);
            this.btn_FCFS.TabIndex = 4;
            this.btn_FCFS.TabStop = true;
            this.btn_FCFS.Text = "FCFS";
            this.btn_FCFS.UseVisualStyleBackColor = true;
            // 
            // tabPage_Control
            // 
            this.tabPage_Control.Controls.Add(this.lb_MaxCy);
            this.tabPage_Control.Controls.Add(this.lb_MinCy);
            this.tabPage_Control.Controls.Add(this.trackBar2);
            this.tabPage_Control.Controls.Add(this.trackBar1);
            this.tabPage_Control.Controls.Add(this.HeadValue);
            this.tabPage_Control.Controls.Add(this.label7);
            this.tabPage_Control.Controls.Add(this.label6);
            this.tabPage_Control.Controls.Add(this.label5);
            this.tabPage_Control.Location = new System.Drawing.Point(4, 33);
            this.tabPage_Control.Name = "tabPage_Control";
            this.tabPage_Control.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Control.Size = new System.Drawing.Size(810, 329);
            this.tabPage_Control.TabIndex = 1;
            this.tabPage_Control.Text = "Control";
            this.tabPage_Control.UseVisualStyleBackColor = true;
            // 
            // lb_MaxCy
            // 
            this.lb_MaxCy.AutoSize = true;
            this.lb_MaxCy.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaxCy.Location = new System.Drawing.Point(586, 242);
            this.lb_MaxCy.Name = "lb_MaxCy";
            this.lb_MaxCy.Size = new System.Drawing.Size(29, 32);
            this.lb_MaxCy.TabIndex = 7;
            this.lb_MaxCy.Text = "0";
            // 
            // lb_MinCy
            // 
            this.lb_MinCy.AutoSize = true;
            this.lb_MinCy.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MinCy.Location = new System.Drawing.Point(195, 242);
            this.lb_MinCy.Name = "lb_MinCy";
            this.lb_MinCy.Size = new System.Drawing.Size(29, 32);
            this.lb_MinCy.TabIndex = 6;
            this.lb_MinCy.Text = "0";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(427, 194);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(343, 45);
            this.trackBar2.TabIndex = 5;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(33, 194);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(343, 45);
            this.trackBar1.TabIndex = 4;
            // 
            // HeadValue
            // 
            this.HeadValue.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadValue.Location = new System.Drawing.Point(495, 35);
            this.HeadValue.Name = "HeadValue";
            this.HeadValue.Size = new System.Drawing.Size(120, 39);
            this.HeadValue.TabIndex = 3;
            this.HeadValue.ValueChanged += new System.EventHandler(this.HeadValue_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(482, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "Maximum cylinder:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Minimum cylinder:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(195, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Initial Head Position:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_Report);
            this.panel1.Controls.Add(this.panel_Setting);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.panel1.Size = new System.Drawing.Size(1984, 388);
            this.panel1.TabIndex = 2;
            // 
            // panel_Report
            // 
            this.panel_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Report.Controls.Add(this.groupBox2);
            this.panel_Report.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Report.Location = new System.Drawing.Point(834, 20);
            this.panel_Report.Name = "panel_Report";
            this.panel_Report.Size = new System.Drawing.Size(1140, 368);
            this.panel_Report.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Exit);
            this.groupBox2.Controls.Add(this.btn_Reset);
            this.groupBox2.Controls.Add(this.btn_Start);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_SeekCnt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1138, 366);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "REPORT";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(821, 149);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(176, 67);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(143, 149);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(176, 67);
            this.btn_Reset.TabIndex = 4;
            this.btn_Reset.Text = "RESET";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Start.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(482, 149);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(176, 67);
            this.btn_Start.TabIndex = 3;
            this.btn_Start.Text = "START";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(997, 54);
            this.label4.TabIndex = 2;
            this.label4.Text = "ALGORITHM ILLUSTRATION FOR DISK SCHEDULING";
            // 
            // txt_SeekCnt
            // 
            this.txt_SeekCnt.Location = new System.Drawing.Point(158, 294);
            this.txt_SeekCnt.Name = "txt_SeekCnt";
            this.txt_SeekCnt.ReadOnly = true;
            this.txt_SeekCnt.Size = new System.Drawing.Size(970, 35);
            this.txt_SeekCnt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "SEEK COUNT:";
            // 
            // panel_Setting
            // 
            this.panel_Setting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Setting.Controls.Add(this.TabControl);
            this.panel_Setting.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Setting.Location = new System.Drawing.Point(10, 20);
            this.panel_Setting.Name = "panel_Setting";
            this.panel_Setting.Size = new System.Drawing.Size(820, 368);
            this.panel_Setting.TabIndex = 2;
            // 
            // panel_Graph
            // 
            this.panel_Graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Graph.Location = new System.Drawing.Point(10, 38);
            this.panel_Graph.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Graph.Name = "panel_Graph";
            this.panel_Graph.Size = new System.Drawing.Size(1964, 672);
            this.panel_Graph.TabIndex = 3;
            this.panel_Graph.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Graph_Paint);
            this.panel_Graph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_Graph_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel_Graph);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 441);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(1984, 720);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GRAPH";
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_Time.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Time.Location = new System.Drawing.Point(1923, 423);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(61, 30);
            this.lb_Time.TabIndex = 3;
            this.lb_Time.Text = "Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1984, 1161);
            this.ControlBox = false;
            this.Controls.Add(this.lb_Time);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulator Disk Scheduling";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.tabPage_Setting.ResumeLayout(false);
            this.tabPage_Setting.PerformLayout();
            this.tabPage_Control.ResumeLayout(false);
            this.tabPage_Control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadValue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel_Report.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel_Setting.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage_Setting;
        private System.Windows.Forms.TabPage tabPage_Control;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Graph;
        private System.Windows.Forms.Panel panel_Report;
        private System.Windows.Forms.Panel panel_Setting;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_FillRandom;
        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton btn_FCFS;
        private System.Windows.Forms.RadioButton btn_clook;
        private System.Windows.Forms.RadioButton btn_cscan;
        private System.Windows.Forms.RadioButton btn_Scan;
        private System.Windows.Forms.RadioButton btn_SSTF;
        private System.Windows.Forms.TextBox txt_SeekCnt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.NumericUpDown HeadValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label lb_MaxCy;
        private System.Windows.Forms.Label lb_MinCy;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.TextBox txt_HeadValue;
        private System.Windows.Forms.Button button1;
    }
}


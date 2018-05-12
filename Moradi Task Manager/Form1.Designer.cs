namespace Moradi_Task_Manager
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SysInfo = new MetroFramework.Controls.MetroTabControl();
            this.TaskManager = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.processName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemorySize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CpuRamManager = new MetroFramework.Controls.MetroTabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBar2 = new MetroFramework.Controls.MetroProgressBar();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.faderPanel1 = new Fader_Theme.FaderPanel();
            this.faderLabel4 = new Fader_Theme.FaderLabel();
            this.faderLabel6 = new Fader_Theme.FaderLabel();
            this.faderLabel3 = new Fader_Theme.FaderLabel();
            this.faderLabel5 = new Fader_Theme.FaderLabel();
            this.faderLabel2 = new Fader_Theme.FaderLabel();
            this.faderLabel1 = new Fader_Theme.FaderLabel();
            this.About = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.killTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskmgrTimer = new System.Windows.Forms.Timer(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.CpuRamTimer = new System.Windows.Forms.Timer(this.components);
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.sysinfotimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifymenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sizeNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moradiTaskManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.SysInfo.SuspendLayout();
            this.TaskManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.CpuRamManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.metroTabPage1.SuspendLayout();
            this.faderPanel1.SuspendLayout();
            this.About.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            this.notifymenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // SysInfo
            // 
            this.SysInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SysInfo.Controls.Add(this.TaskManager);
            this.SysInfo.Controls.Add(this.CpuRamManager);
            this.SysInfo.Controls.Add(this.metroTabPage1);
            this.SysInfo.Controls.Add(this.About);
            this.SysInfo.Location = new System.Drawing.Point(16, 78);
            this.SysInfo.Margin = new System.Windows.Forms.Padding(4);
            this.SysInfo.Name = "SysInfo";
            this.SysInfo.SelectedIndex = 0;
            this.SysInfo.Size = new System.Drawing.Size(865, 574);
            this.SysInfo.TabIndex = 0;
            this.SysInfo.UseSelectable = true;
            // 
            // TaskManager
            // 
            this.TaskManager.Controls.Add(this.dataGridView1);
            this.TaskManager.HorizontalScrollbarBarColor = true;
            this.TaskManager.HorizontalScrollbarHighlightOnWheel = false;
            this.TaskManager.HorizontalScrollbarSize = 12;
            this.TaskManager.Location = new System.Drawing.Point(4, 38);
            this.TaskManager.Margin = new System.Windows.Forms.Padding(4);
            this.TaskManager.Name = "TaskManager";
            this.TaskManager.Size = new System.Drawing.Size(857, 532);
            this.TaskManager.TabIndex = 0;
            this.TaskManager.Text = "Task Manager";
            this.TaskManager.VerticalScrollbarBarColor = true;
            this.TaskManager.VerticalScrollbarHighlightOnWheel = false;
            this.TaskManager.VerticalScrollbarSize = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.processName,
            this.processID,
            this.MemorySize});
            this.dataGridView1.Location = new System.Drawing.Point(-5, 5);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(860, 522);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // processName
            // 
            this.processName.HeaderText = "Process Name";
            this.processName.Name = "processName";
            this.processName.ReadOnly = true;
            this.processName.Width = 190;
            // 
            // processID
            // 
            this.processID.HeaderText = "Process ID";
            this.processID.Name = "processID";
            this.processID.ReadOnly = true;
            this.processID.Width = 190;
            // 
            // MemorySize
            // 
            this.MemorySize.HeaderText = "Memory Size In Bytes";
            this.MemorySize.Name = "MemorySize";
            this.MemorySize.ReadOnly = true;
            this.MemorySize.Width = 190;
            // 
            // CpuRamManager
            // 
            this.CpuRamManager.Controls.Add(this.chart1);
            this.CpuRamManager.Controls.Add(this.metroLabel3);
            this.CpuRamManager.Controls.Add(this.metroLabel5);
            this.CpuRamManager.Controls.Add(this.metroLabel4);
            this.CpuRamManager.Controls.Add(this.metroLabel2);
            this.CpuRamManager.Controls.Add(this.metroProgressBar2);
            this.CpuRamManager.Controls.Add(this.metroProgressBar1);
            this.CpuRamManager.HorizontalScrollbarBarColor = true;
            this.CpuRamManager.HorizontalScrollbarHighlightOnWheel = false;
            this.CpuRamManager.HorizontalScrollbarSize = 12;
            this.CpuRamManager.Location = new System.Drawing.Point(4, 38);
            this.CpuRamManager.Margin = new System.Windows.Forms.Padding(4);
            this.CpuRamManager.Name = "CpuRamManager";
            this.CpuRamManager.Size = new System.Drawing.Size(857, 532);
            this.CpuRamManager.TabIndex = 1;
            this.CpuRamManager.Text = "CPU && RAM";
            this.CpuRamManager.VerticalScrollbarBarColor = true;
            this.CpuRamManager.VerticalScrollbarHighlightOnWheel = false;
            this.CpuRamManager.VerticalScrollbarSize = 13;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-47, 124);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(948, 402);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(7, 81);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 25);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "RAM";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(768, 85);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(37, 25);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "0%";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(768, 37);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(37, 25);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "0%";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(9, 39);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 25);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "CPU";
            // 
            // metroProgressBar2
            // 
            this.metroProgressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressBar2.Location = new System.Drawing.Point(75, 79);
            this.metroProgressBar2.Margin = new System.Windows.Forms.Padding(4);
            this.metroProgressBar2.Name = "metroProgressBar2";
            this.metroProgressBar2.Size = new System.Drawing.Size(685, 38);
            this.metroProgressBar2.TabIndex = 3;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressBar1.Location = new System.Drawing.Point(75, 37);
            this.metroProgressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(685, 38);
            this.metroProgressBar1.TabIndex = 2;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.faderPanel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 12;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(857, 532);
            this.metroTabPage1.TabIndex = 3;
            this.metroTabPage1.Text = "System Info";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 13;
            // 
            // faderPanel1
            // 
            this.faderPanel1.BackColor = System.Drawing.Color.Transparent;
            this.faderPanel1.Controls.Add(this.faderLabel4);
            this.faderPanel1.Controls.Add(this.faderLabel6);
            this.faderPanel1.Controls.Add(this.faderLabel3);
            this.faderPanel1.Controls.Add(this.faderLabel5);
            this.faderPanel1.Controls.Add(this.faderLabel2);
            this.faderPanel1.Controls.Add(this.faderLabel1);
            this.faderPanel1.Location = new System.Drawing.Point(-3, 4);
            this.faderPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.faderPanel1.Name = "faderPanel1";
            this.faderPanel1.Size = new System.Drawing.Size(857, 512);
            this.faderPanel1.TabIndex = 2;
            this.faderPanel1.Text = "faderPanel1";
            // 
            // faderLabel4
            // 
            this.faderLabel4.BackColor = System.Drawing.Color.Transparent;
            this.faderLabel4.Border = true;
            this.faderLabel4.Location = new System.Drawing.Point(13, 153);
            this.faderLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.faderLabel4.Name = "faderLabel4";
            this.faderLabel4.Size = new System.Drawing.Size(841, 37);
            this.faderLabel4.TabIndex = 0;
            this.faderLabel4.Text = "faderLabel1";
            // 
            // faderLabel6
            // 
            this.faderLabel6.BackColor = System.Drawing.Color.Transparent;
            this.faderLabel6.Border = true;
            this.faderLabel6.Location = new System.Drawing.Point(12, 241);
            this.faderLabel6.Margin = new System.Windows.Forms.Padding(4);
            this.faderLabel6.Name = "faderLabel6";
            this.faderLabel6.Size = new System.Drawing.Size(841, 37);
            this.faderLabel6.TabIndex = 0;
            this.faderLabel6.Text = "faderLabel1";
            // 
            // faderLabel3
            // 
            this.faderLabel3.BackColor = System.Drawing.Color.Transparent;
            this.faderLabel3.Border = true;
            this.faderLabel3.Location = new System.Drawing.Point(13, 108);
            this.faderLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.faderLabel3.Name = "faderLabel3";
            this.faderLabel3.Size = new System.Drawing.Size(841, 37);
            this.faderLabel3.TabIndex = 0;
            this.faderLabel3.Text = "faderLabel1";
            // 
            // faderLabel5
            // 
            this.faderLabel5.BackColor = System.Drawing.Color.Transparent;
            this.faderLabel5.Border = true;
            this.faderLabel5.Location = new System.Drawing.Point(12, 197);
            this.faderLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.faderLabel5.Name = "faderLabel5";
            this.faderLabel5.Size = new System.Drawing.Size(841, 37);
            this.faderLabel5.TabIndex = 0;
            this.faderLabel5.Text = "faderLabel1";
            // 
            // faderLabel2
            // 
            this.faderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.faderLabel2.Border = true;
            this.faderLabel2.Location = new System.Drawing.Point(12, 64);
            this.faderLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.faderLabel2.Name = "faderLabel2";
            this.faderLabel2.Size = new System.Drawing.Size(841, 37);
            this.faderLabel2.TabIndex = 0;
            this.faderLabel2.Text = "faderLabel1";
            // 
            // faderLabel1
            // 
            this.faderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.faderLabel1.Border = true;
            this.faderLabel1.Location = new System.Drawing.Point(12, 20);
            this.faderLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.faderLabel1.Name = "faderLabel1";
            this.faderLabel1.Size = new System.Drawing.Size(841, 37);
            this.faderLabel1.TabIndex = 0;
            this.faderLabel1.Text = "faderLabel1";
            // 
            // About
            // 
            this.About.Controls.Add(this.metroLabel6);
            this.About.Controls.Add(this.metroLabel9);
            this.About.Controls.Add(this.metroLabel7);
            this.About.Controls.Add(this.metroLabel8);
            this.About.HorizontalScrollbarBarColor = true;
            this.About.HorizontalScrollbarHighlightOnWheel = false;
            this.About.HorizontalScrollbarSize = 12;
            this.About.Location = new System.Drawing.Point(4, 38);
            this.About.Margin = new System.Windows.Forms.Padding(4);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(857, 532);
            this.About.TabIndex = 2;
            this.About.Text = "About";
            this.About.VerticalScrollbarBarColor = true;
            this.About.VerticalScrollbarHighlightOnWheel = false;
            this.About.VerticalScrollbarSize = 13;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Black;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(0, 12);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(271, 20);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Developed by: Brett Tech Networking";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.Black;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(0, 82);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(369, 20);
            this.metroLabel9.TabIndex = 2;
            this.metroLabel9.Text = "Github: https://github.com/Brett-Tech-Networking";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Black;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(0, 36);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(288, 20);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Developed for: Moradi OS Development";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Black;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(0, 59);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(276, 20);
            this.metroLabel8.TabIndex = 2;
            this.metroLabel8.Text = "Email: Support@Brett-TechRepair.com";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.killTaskToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 28);
            // 
            // killTaskToolStripMenuItem
            // 
            this.killTaskToolStripMenuItem.Name = "killTaskToolStripMenuItem";
            this.killTaskToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.killTaskToolStripMenuItem.Text = "Kill Task";
            // 
            // TaskmgrTimer
            // 
            this.TaskmgrTimer.Enabled = true;
            this.TaskmgrTimer.Interval = 1000;
            this.TaskmgrTimer.Tick += new System.EventHandler(this.TaskmgrTimer_Tick);
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Location = new System.Drawing.Point(761, 647);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(112, 28);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Kill Task";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // CpuRamTimer
            // 
            this.CpuRamTimer.Interval = 1000;
            this.CpuRamTimer.Tick += new System.EventHandler(this.CpuRamTimer_Tick);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(366, 2);
            this.metroTextBox1.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(256, 671);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.Size = new System.Drawing.Size(392, 28);
            this.metroTextBox1.TabIndex = 4;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(16, 668);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(185, 25);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Enter Program Name:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(301, 652);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Program Name To Kill That Task";
            // 
            // sysinfotimer
            // 
            this.sysinfotimer.Tick += new System.EventHandler(this.sysinfotimer_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(656, 647);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "New Task";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.notifymenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Moradi Task Manager\r\n";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipShown += new System.EventHandler(this.notifyIcon1_BalloonTipShown);
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // notifymenu
            // 
            this.notifymenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.notifymenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moradiTaskManagerToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sizeNormalToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.notifymenu.Name = "notifymenu";
            this.notifymenu.Size = new System.Drawing.Size(230, 82);
            this.notifymenu.Text = "Moradi Task Manager";
            // 
            // sizeNormalToolStripMenuItem
            // 
            this.sizeNormalToolStripMenuItem.Name = "sizeNormalToolStripMenuItem";
            this.sizeNormalToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.sizeNormalToolStripMenuItem.Text = "&Size: Normal";
            this.sizeNormalToolStripMenuItem.Click += new System.EventHandler(this.sizeNormalToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // moradiTaskManagerToolStripMenuItem
            // 
            this.moradiTaskManagerToolStripMenuItem.Enabled = false;
            this.moradiTaskManagerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.moradiTaskManagerToolStripMenuItem.Name = "moradiTaskManagerToolStripMenuItem";
            this.moradiTaskManagerToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.moradiTaskManagerToolStripMenuItem.Text = "&Moradi Task Manager";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(226, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 700);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.SysInfo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Moradi Task Manager | Moradi OS Development";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.SysInfo.ResumeLayout(false);
            this.TaskManager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.CpuRamManager.ResumeLayout(false);
            this.CpuRamManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.metroTabPage1.ResumeLayout(false);
            this.faderPanel1.ResumeLayout(false);
            this.About.ResumeLayout(false);
            this.About.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            this.notifymenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl SysInfo;
        private MetroFramework.Controls.MetroTabPage TaskManager;
        private MetroFramework.Controls.MetroTabPage CpuRamManager;
        private System.Windows.Forms.Timer TaskmgrTimer;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem killTaskToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar2;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Timer CpuRamTimer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroTabPage About;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn processName;
        private System.Windows.Forms.DataGridViewTextBoxColumn processID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemorySize;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private Fader_Theme.FaderPanel faderPanel1;
        private Fader_Theme.FaderLabel faderLabel4;
        private Fader_Theme.FaderLabel faderLabel6;
        private Fader_Theme.FaderLabel faderLabel3;
        private Fader_Theme.FaderLabel faderLabel5;
        private Fader_Theme.FaderLabel faderLabel2;
        private Fader_Theme.FaderLabel faderLabel1;
        private System.Windows.Forms.Timer sysinfotimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip notifymenu;
        private System.Windows.Forms.ToolStripMenuItem sizeNormalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moradiTaskManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}


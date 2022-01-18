
namespace SystemMonitor
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Processor = new System.Diagnostics.PerformanceCounter();
            this.MainTimerProgram = new System.Windows.Forms.Timer(this.components);
            this.Disk = new System.Diagnostics.PerformanceCounter();
            this.Memory = new System.Diagnostics.PerformanceCounter();
            this.BytesReceived = new System.Diagnostics.PerformanceCounter();
            this.SentBytes = new System.Diagnostics.PerformanceCounter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ChartForTCPCon = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BytesSentLabel = new System.Windows.Forms.Label();
            this.ReceivedBytesLabel = new System.Windows.Forms.Label();
            this.LabelItemsCount = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.NumberOfAuditTB = new System.Windows.Forms.TextBox();
            this.NumberOfAuditLabel = new System.Windows.Forms.Label();
            this.LabelLogonServer = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ChartForSysRes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CountProcesses = new System.Windows.Forms.Label();
            this.NumberOfProcTB = new System.Windows.Forms.TextBox();
            this.MemoryTB = new System.Windows.Forms.TextBox();
            this.PhysicalDiscTB = new System.Windows.Forms.TextBox();
            this.ProcesLoadTB = new System.Windows.Forms.TextBox();
            this.LabelMemoryLoad = new System.Windows.Forms.Label();
            this.LabelPhysicalDisk = new System.Windows.Forms.Label();
            this.ProcessLoadLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TimerWrkProgram = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MainStartBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnStopWrk = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.LabelValueIteration = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.LabelWrkTime = new System.Windows.Forms.ToolStripLabel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.Processor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Memory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BytesReceived)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SentBytes)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartForTCPCon)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartForSysRes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // Processor
            // 
            this.Processor.CategoryName = "Processor";
            this.Processor.CounterName = "% Processor Time";
            this.Processor.InstanceName = "_Total";
            // 
            // MainTimerProgram
            // 
            this.MainTimerProgram.Interval = 500;
            this.MainTimerProgram.Tick += new System.EventHandler(this.TimerProcLoad_Tick);
            // 
            // Disk
            // 
            this.Disk.CategoryName = "PhysicalDisk";
            this.Disk.CounterName = "% Idle Time";
            this.Disk.InstanceName = "_Total";
            // 
            // Memory
            // 
            this.Memory.CategoryName = "Memory";
            this.Memory.CounterName = "% Committed Bytes In Use";
            // 
            // BytesReceived
            // 
            this.BytesReceived.CategoryName = "Network Interface";
            this.BytesReceived.CounterName = "Bytes Received/sec";
            this.BytesReceived.InstanceName = "Realtek PCIe GBE Family Controller";
            // 
            // SentBytes
            // 
            this.SentBytes.CategoryName = "Network Interface";
            this.SentBytes.CounterName = "Bytes Sent/sec";
            this.SentBytes.InstanceName = "Realtek PCIe GBE Family Controller";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 744);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Silver;
            this.tabPage3.Controls.Add(this.splitContainer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1343, 711);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Network";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1336, 726);
            this.splitContainer1.SplitterDistance = 445;
            this.splitContainer1.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(16, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 669);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Active TCP Connections";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(401, 644);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.ChartForTCPCon);
            this.groupBox5.Location = new System.Drawing.Point(13, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(866, 545);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chart";
            // 
            // ChartForTCPCon
            // 
            this.ChartForTCPCon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartForTCPCon.BackColor = System.Drawing.SystemColors.Control;
            chartArea7.AxisX.ScaleView.Zoomable = false;
            chartArea7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea7.Name = "ChartArea1";
            this.ChartForTCPCon.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.ChartForTCPCon.Legends.Add(legend7);
            this.ChartForTCPCon.Location = new System.Drawing.Point(9, 19);
            this.ChartForTCPCon.Name = "ChartForTCPCon";
            this.ChartForTCPCon.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series19.BorderWidth = 3;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series19.LabelBorderWidth = 3;
            series19.Legend = "Legend1";
            series19.Name = "Tcp connections count";
            series19.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series20.BorderWidth = 3;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series20.LabelBorderWidth = 3;
            series20.Legend = "Legend1";
            series20.Name = "Received bytes";
            series21.BorderWidth = 3;
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series21.LabelBorderWidth = 3;
            series21.Legend = "Legend1";
            series21.Name = "Sent bytes";
            this.ChartForTCPCon.Series.Add(series19);
            this.ChartForTCPCon.Series.Add(series20);
            this.ChartForTCPCon.Series.Add(series21);
            this.ChartForTCPCon.Size = new System.Drawing.Size(851, 520);
            this.ChartForTCPCon.TabIndex = 6;
            this.ChartForTCPCon.Text = "chart3";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.BytesSentLabel);
            this.groupBox4.Controls.Add(this.ReceivedBytesLabel);
            this.groupBox4.Controls.Add(this.LabelItemsCount);
            this.groupBox4.Location = new System.Drawing.Point(13, 552);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(866, 125);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data";
            // 
            // BytesSentLabel
            // 
            this.BytesSentLabel.AutoSize = true;
            this.BytesSentLabel.Location = new System.Drawing.Point(6, 89);
            this.BytesSentLabel.Name = "BytesSentLabel";
            this.BytesSentLabel.Size = new System.Drawing.Size(74, 20);
            this.BytesSentLabel.TabIndex = 3;
            this.BytesSentLabel.Text = "Sent bytes";
            // 
            // ReceivedBytesLabel
            // 
            this.ReceivedBytesLabel.AutoSize = true;
            this.ReceivedBytesLabel.Location = new System.Drawing.Point(6, 60);
            this.ReceivedBytesLabel.Name = "ReceivedBytesLabel";
            this.ReceivedBytesLabel.Size = new System.Drawing.Size(102, 20);
            this.ReceivedBytesLabel.TabIndex = 2;
            this.ReceivedBytesLabel.Text = "Received bytes";
            // 
            // LabelItemsCount
            // 
            this.LabelItemsCount.AutoSize = true;
            this.LabelItemsCount.Location = new System.Drawing.Point(6, 30);
            this.LabelItemsCount.Name = "LabelItemsCount";
            this.LabelItemsCount.Size = new System.Drawing.Size(114, 20);
            this.LabelItemsCount.TabIndex = 1;
            this.LabelItemsCount.Text = "LabelItemsCount";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(1343, 711);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Security";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.listBox4);
            this.groupBox2.Controls.Add(this.listBox3);
            this.groupBox2.Controls.Add(this.NumberOfAuditTB);
            this.groupBox2.Controls.Add(this.NumberOfAuditLabel);
            this.groupBox2.Controls.Add(this.LabelLogonServer);
            this.groupBox2.Location = new System.Drawing.Point(3, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1321, 685);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Log entries";
            // 
            // listBox4
            // 
            this.listBox4.BackColor = System.Drawing.SystemColors.Control;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.HorizontalScrollbar = true;
            this.listBox4.ItemHeight = 20;
            this.listBox4.Location = new System.Drawing.Point(6, 85);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(1306, 264);
            this.listBox4.TabIndex = 4;
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.SystemColors.Control;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(6, 385);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(1306, 284);
            this.listBox3.TabIndex = 3;
            // 
            // NumberOfAuditTB
            // 
            this.NumberOfAuditTB.Location = new System.Drawing.Point(204, 19);
            this.NumberOfAuditTB.Name = "NumberOfAuditTB";
            this.NumberOfAuditTB.ReadOnly = true;
            this.NumberOfAuditTB.Size = new System.Drawing.Size(139, 26);
            this.NumberOfAuditTB.TabIndex = 2;
            this.NumberOfAuditTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NumberOfAuditLabel
            // 
            this.NumberOfAuditLabel.AutoSize = true;
            this.NumberOfAuditLabel.Location = new System.Drawing.Point(5, 22);
            this.NumberOfAuditLabel.Name = "NumberOfAuditLabel";
            this.NumberOfAuditLabel.Size = new System.Drawing.Size(193, 20);
            this.NumberOfAuditLabel.TabIndex = 1;
            this.NumberOfAuditLabel.Text = "Current number of log entries";
            // 
            // LabelLogonServer
            // 
            this.LabelLogonServer.AutoSize = true;
            this.LabelLogonServer.Location = new System.Drawing.Point(6, 365);
            this.LabelLogonServer.Name = "LabelLogonServer";
            this.LabelLogonServer.Size = new System.Drawing.Size(283, 20);
            this.LabelLogonServer.TabIndex = 0;
            this.LabelLogonServer.Text = "History of changes in the number of records";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(1343, 711);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "System resources";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.listBox2);
            this.groupBox8.Location = new System.Drawing.Point(397, 530);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(939, 155);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Processes";
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.Control;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(7, 20);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(927, 124);
            this.listBox2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.ChartForSysRes);
            this.groupBox6.Location = new System.Drawing.Point(6, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1330, 531);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chart";
            // 
            // ChartForSysRes
            // 
            this.ChartForSysRes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartForSysRes.BackColor = System.Drawing.SystemColors.Control;
            chartArea8.BackColor = System.Drawing.Color.LightGray;
            chartArea8.Name = "ChartArea1";
            this.ChartForSysRes.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.ChartForSysRes.Legends.Add(legend8);
            this.ChartForSysRes.Location = new System.Drawing.Point(6, 19);
            this.ChartForSysRes.Name = "ChartForSysRes";
            this.ChartForSysRes.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series22.BorderWidth = 3;
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series22.Legend = "Legend1";
            series22.Name = "CPU";
            series23.BorderWidth = 3;
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series23.Legend = "Legend1";
            series23.Name = "Phisycal disc";
            series24.BorderWidth = 3;
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series24.Legend = "Legend1";
            series24.Name = "Memory";
            this.ChartForSysRes.Series.Add(series22);
            this.ChartForSysRes.Series.Add(series23);
            this.ChartForSysRes.Series.Add(series24);
            this.ChartForSysRes.Size = new System.Drawing.Size(1318, 506);
            this.ChartForSysRes.TabIndex = 2;
            this.ChartForSysRes.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CountProcesses);
            this.groupBox1.Controls.Add(this.NumberOfProcTB);
            this.groupBox1.Controls.Add(this.MemoryTB);
            this.groupBox1.Controls.Add(this.PhysicalDiscTB);
            this.groupBox1.Controls.Add(this.ProcesLoadTB);
            this.groupBox1.Controls.Add(this.LabelMemoryLoad);
            this.groupBox1.Controls.Add(this.LabelPhysicalDisk);
            this.groupBox1.Controls.Add(this.ProcessLoadLabel);
            this.groupBox1.Location = new System.Drawing.Point(6, 530);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 155);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data ";
            // 
            // CountProcesses
            // 
            this.CountProcesses.AutoSize = true;
            this.CountProcesses.Location = new System.Drawing.Point(20, 19);
            this.CountProcesses.Name = "CountProcesses";
            this.CountProcesses.Size = new System.Drawing.Size(114, 20);
            this.CountProcesses.TabIndex = 1;
            this.CountProcesses.Text = "Count Processes";
            // 
            // NumberOfProcTB
            // 
            this.NumberOfProcTB.Location = new System.Drawing.Point(208, 16);
            this.NumberOfProcTB.Name = "NumberOfProcTB";
            this.NumberOfProcTB.ReadOnly = true;
            this.NumberOfProcTB.Size = new System.Drawing.Size(164, 26);
            this.NumberOfProcTB.TabIndex = 2;
            this.NumberOfProcTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MemoryTB
            // 
            this.MemoryTB.Location = new System.Drawing.Point(208, 118);
            this.MemoryTB.Name = "MemoryTB";
            this.MemoryTB.ReadOnly = true;
            this.MemoryTB.Size = new System.Drawing.Size(164, 26);
            this.MemoryTB.TabIndex = 8;
            this.MemoryTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PhysicalDiscTB
            // 
            this.PhysicalDiscTB.Location = new System.Drawing.Point(208, 85);
            this.PhysicalDiscTB.Name = "PhysicalDiscTB";
            this.PhysicalDiscTB.ReadOnly = true;
            this.PhysicalDiscTB.Size = new System.Drawing.Size(164, 26);
            this.PhysicalDiscTB.TabIndex = 7;
            this.PhysicalDiscTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ProcesLoadTB
            // 
            this.ProcesLoadTB.Location = new System.Drawing.Point(208, 50);
            this.ProcesLoadTB.Name = "ProcesLoadTB";
            this.ProcesLoadTB.ReadOnly = true;
            this.ProcesLoadTB.Size = new System.Drawing.Size(164, 26);
            this.ProcesLoadTB.TabIndex = 6;
            this.ProcesLoadTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelMemoryLoad
            // 
            this.LabelMemoryLoad.AutoSize = true;
            this.LabelMemoryLoad.Location = new System.Drawing.Point(20, 121);
            this.LabelMemoryLoad.Name = "LabelMemoryLoad";
            this.LabelMemoryLoad.Size = new System.Drawing.Size(46, 20);
            this.LabelMemoryLoad.TabIndex = 5;
            this.LabelMemoryLoad.Text = "label1";
            // 
            // LabelPhysicalDisk
            // 
            this.LabelPhysicalDisk.AutoSize = true;
            this.LabelPhysicalDisk.Location = new System.Drawing.Point(20, 88);
            this.LabelPhysicalDisk.Name = "LabelPhysicalDisk";
            this.LabelPhysicalDisk.Size = new System.Drawing.Size(46, 20);
            this.LabelPhysicalDisk.TabIndex = 3;
            this.LabelPhysicalDisk.Text = "label1";
            // 
            // ProcessLoadLabel
            // 
            this.ProcessLoadLabel.AutoSize = true;
            this.ProcessLoadLabel.Location = new System.Drawing.Point(20, 53);
            this.ProcessLoadLabel.Name = "ProcessLoadLabel";
            this.ProcessLoadLabel.Size = new System.Drawing.Size(46, 20);
            this.ProcessLoadLabel.TabIndex = 1;
            this.ProcessLoadLabel.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1351, 744);
            this.tabControl1.TabIndex = 1;
            // 
            // TimerWrkProgram
            // 
            this.TimerWrkProgram.Interval = 1000;
            this.TimerWrkProgram.Tick += new System.EventHandler(this.TimerWrkProgram_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainStartBtn,
            this.toolStripSeparator1,
            this.BtnStopWrk,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.LabelValueIteration,
            this.toolStripSeparator3,
            this.LabelWrkTime});
            this.toolStrip1.Location = new System.Drawing.Point(3, 717);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1348, 27);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MainStartBtn
            // 
            this.MainStartBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MainStartBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainStartBtn.Image = ((System.Drawing.Image)(resources.GetObject("MainStartBtn.Image")));
            this.MainStartBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MainStartBtn.Name = "MainStartBtn";
            this.MainStartBtn.Size = new System.Drawing.Size(115, 24);
            this.MainStartBtn.Text = "Start monitoring";
            this.MainStartBtn.Click += new System.EventHandler(this.MainStartBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // BtnStopWrk
            // 
            this.BtnStopWrk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnStopWrk.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.BtnStopWrk.Image = ((System.Drawing.Image)(resources.GetObject("BtnStopWrk.Image")));
            this.BtnStopWrk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnStopWrk.Name = "BtnStopWrk";
            this.BtnStopWrk.Size = new System.Drawing.Size(106, 24);
            this.BtnStopWrk.Text = "Stop rendering";
            this.BtnStopWrk.Click += new System.EventHandler(this.BtnStopWrk_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(212, 24);
            this.toolStripLabel1.Text = "Number of iterations performed: ";
            // 
            // LabelValueIteration
            // 
            this.LabelValueIteration.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.LabelValueIteration.Name = "LabelValueIteration";
            this.LabelValueIteration.Size = new System.Drawing.Size(16, 24);
            this.LabelValueIteration.Text = "0";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // LabelWrkTime
            // 
            this.LabelWrkTime.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.LabelWrkTime.Name = "LabelWrkTime";
            this.LabelWrkTime.Size = new System.Drawing.Size(258, 24);
            this.LabelWrkTime.Text = "Working hours of the program: 00:00:00 ";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Silver;
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage4.Size = new System.Drawing.Size(1343, 711);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "System resources history";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1309, 580);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dataGridView1);
            this.groupBox7.Location = new System.Drawing.Point(8, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1321, 662);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "System resources history";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Silver;
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage5.Size = new System.Drawing.Size(1343, 711);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Security history";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.Silver;
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage6.Size = new System.Drawing.Size(1343, 711);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Network history";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1351, 744);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System monitor";
            ((System.ComponentModel.ISupportInitialize)(this.Processor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Memory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BytesReceived)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SentBytes)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartForTCPCon)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartForSysRes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Diagnostics.PerformanceCounter Processor;
        private System.Windows.Forms.Timer MainTimerProgram;
        private System.Diagnostics.PerformanceCounter Disk;
        private System.Diagnostics.PerformanceCounter Memory;
        private System.Diagnostics.PerformanceCounter BytesReceived;
        private System.Diagnostics.PerformanceCounter SentBytes;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartForTCPCon;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label BytesSentLabel;
        private System.Windows.Forms.Label ReceivedBytesLabel;
        private System.Windows.Forms.Label LabelItemsCount;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LabelLogonServer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartForSysRes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabelMemoryLoad;
        private System.Windows.Forms.Label LabelPhysicalDisk;
        private System.Windows.Forms.Label ProcessLoadLabel;
        private System.Windows.Forms.Timer TimerWrkProgram;
        private System.Windows.Forms.TextBox MemoryTB;
        private System.Windows.Forms.TextBox PhysicalDiscTB;
        private System.Windows.Forms.TextBox ProcesLoadTB;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label CountProcesses;
        private System.Windows.Forms.TextBox NumberOfProcTB;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.TextBox NumberOfAuditTB;
        private System.Windows.Forms.Label NumberOfAuditLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton MainStartBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnStopWrk;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel LabelValueIteration;
        private System.Windows.Forms.ToolStripLabel LabelWrkTime;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
    }
}


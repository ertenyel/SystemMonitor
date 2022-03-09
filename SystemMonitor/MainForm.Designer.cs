
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Processor = new System.Diagnostics.PerformanceCounter();
            this.MainTimerProgram = new System.Windows.Forms.Timer(this.components);
            this.Disk = new System.Diagnostics.PerformanceCounter();
            this.Memory = new System.Diagnostics.PerformanceCounter();
            this.BytesReceived = new System.Diagnostics.PerformanceCounter();
            this.SentBytes = new System.Diagnostics.PerformanceCounter();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CaptureBtnNetwork = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ChartForTCPCon = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BytesSentLabel = new System.Windows.Forms.Label();
            this.ReceivedBytesLabel = new System.Windows.Forms.Label();
            this.LabelItemsCount = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.NumberOfAuditTB = new System.Windows.Forms.TextBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ChartForSysRes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CaptureBtnSysRes = new System.Windows.Forms.CheckBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.ClearTableDataSysRes = new System.Windows.Forms.Button();
            this.DeleteTableSysRes = new System.Windows.Forms.Button();
            this.CreateTableSysRes = new System.Windows.Forms.Button();
            this.AddToTableSysRes = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.ClearSysRes = new System.Windows.Forms.Button();
            this.GoBtnSysRes = new System.Windows.Forms.Button();
            this.richTextBoxSysRes = new System.Windows.Forms.RichTextBox();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.dataGridSysRes = new System.Windows.Forms.DataGridView();
            this.idSysRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSysRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberprocess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percproc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percdisc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percmemory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.ClearSecurity = new System.Windows.Forms.Button();
            this.GoBtnSecurity = new System.Windows.Forms.Button();
            this.richTextBoxSecurity = new System.Windows.Forms.RichTextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.dataGridViewSecurity = new System.Windows.Forms.DataGridView();
            this.idSecurity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSecurity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.ClearTableSecurity = new System.Windows.Forms.Button();
            this.DeleteToTableSecurity = new System.Windows.Forms.Button();
            this.CreateTableSecurity = new System.Windows.Forms.Button();
            this.AddToTableSecurity = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.ClearNetwork = new System.Windows.Forms.Button();
            this.GoBtnNetwork = new System.Windows.Forms.Button();
            this.richTextBoxNetwork = new System.Windows.Forms.RichTextBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.dataGridNetwork = new System.Windows.Forms.DataGridView();
            this.idNetwork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeNetwork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedBytes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sentByte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.ClearTableNetwork = new System.Windows.Forms.Button();
            this.DeleteTableNetwork = new System.Windows.Forms.Button();
            this.CreateTableNetwork = new System.Windows.Forms.Button();
            this.AddToTableNetwork = new System.Windows.Forms.Button();
            this.TimerWrkProgram = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MainStartBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnStopWrk = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ClearCharts = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ConnectToSqlData = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.StatConLbl = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.LabelValueIteration = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.LabelWrkTime = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenAnalysisBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.groupBox25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartForSysRes)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSysRes)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecurity)).BeginInit();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNetwork)).BeginInit();
            this.groupBox16.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.MainTimerProgram.Interval = 1000;
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
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Silver;
            this.tabPage3.Controls.Add(this.splitContainer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1339, 672);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Network";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.splitContainer1.Size = new System.Drawing.Size(1339, 672);
            this.splitContainer1.SplitterDistance = 445;
            this.splitContainer1.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CaptureBtnNetwork);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(441, 668);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Active TCP Connections";
            // 
            // CaptureBtnNetwork
            // 
            this.CaptureBtnNetwork.Appearance = System.Windows.Forms.Appearance.Button;
            this.CaptureBtnNetwork.AutoSize = true;
            this.CaptureBtnNetwork.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CaptureBtnNetwork.Location = new System.Drawing.Point(3, 639);
            this.CaptureBtnNetwork.Name = "CaptureBtnNetwork";
            this.CaptureBtnNetwork.Size = new System.Drawing.Size(435, 26);
            this.CaptureBtnNetwork.TabIndex = 2;
            this.CaptureBtnNetwork.Text = "Capture this list box";
            this.CaptureBtnNetwork.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CaptureBtnNetwork.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(435, 647);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ChartForTCPCon);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(886, 548);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chart";
            // 
            // ChartForTCPCon
            // 
            this.ChartForTCPCon.BackColor = System.Drawing.SystemColors.Control;
            chartArea9.AxisX.ScaleView.Zoomable = false;
            chartArea9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea9.Name = "ChartArea1";
            this.ChartForTCPCon.ChartAreas.Add(chartArea9);
            this.ChartForTCPCon.Dock = System.Windows.Forms.DockStyle.Fill;
            legend9.Name = "Legend1";
            this.ChartForTCPCon.Legends.Add(legend9);
            this.ChartForTCPCon.Location = new System.Drawing.Point(3, 18);
            this.ChartForTCPCon.Name = "ChartForTCPCon";
            this.ChartForTCPCon.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series25.BorderWidth = 3;
            series25.ChartArea = "ChartArea1";
            series25.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series25.LabelBorderWidth = 3;
            series25.Legend = "Legend1";
            series25.Name = "Tcp connections count";
            series25.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series26.BorderWidth = 3;
            series26.ChartArea = "ChartArea1";
            series26.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series26.LabelBorderWidth = 3;
            series26.Legend = "Legend1";
            series26.Name = "Received bytes";
            series27.BorderWidth = 3;
            series27.ChartArea = "ChartArea1";
            series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series27.LabelBorderWidth = 3;
            series27.Legend = "Legend1";
            series27.Name = "Sent bytes";
            this.ChartForTCPCon.Series.Add(series25);
            this.ChartForTCPCon.Series.Add(series26);
            this.ChartForTCPCon.Series.Add(series27);
            this.ChartForTCPCon.Size = new System.Drawing.Size(880, 527);
            this.ChartForTCPCon.TabIndex = 6;
            this.ChartForTCPCon.Text = "chart3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BytesSentLabel);
            this.groupBox4.Controls.Add(this.ReceivedBytesLabel);
            this.groupBox4.Controls.Add(this.LabelItemsCount);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 548);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(886, 120);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data";
            // 
            // BytesSentLabel
            // 
            this.BytesSentLabel.AutoSize = true;
            this.BytesSentLabel.Location = new System.Drawing.Point(6, 89);
            this.BytesSentLabel.Name = "BytesSentLabel";
            this.BytesSentLabel.Size = new System.Drawing.Size(81, 16);
            this.BytesSentLabel.TabIndex = 3;
            this.BytesSentLabel.Text = "Sent bytes";
            // 
            // ReceivedBytesLabel
            // 
            this.ReceivedBytesLabel.AutoSize = true;
            this.ReceivedBytesLabel.Location = new System.Drawing.Point(6, 60);
            this.ReceivedBytesLabel.Name = "ReceivedBytesLabel";
            this.ReceivedBytesLabel.Size = new System.Drawing.Size(117, 16);
            this.ReceivedBytesLabel.TabIndex = 2;
            this.ReceivedBytesLabel.Text = "Received bytes";
            // 
            // LabelItemsCount
            // 
            this.LabelItemsCount.AutoSize = true;
            this.LabelItemsCount.Location = new System.Drawing.Point(6, 30);
            this.LabelItemsCount.Name = "LabelItemsCount";
            this.LabelItemsCount.Size = new System.Drawing.Size(123, 16);
            this.LabelItemsCount.TabIndex = 1;
            this.LabelItemsCount.Text = "LabelItemsCount";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1339, 672);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Security";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox25);
            this.groupBox2.Controls.Add(this.splitContainer4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1333, 685);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.checkBox1);
            this.groupBox25.Controls.Add(this.NumberOfAuditTB);
            this.groupBox25.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox25.Location = new System.Drawing.Point(3, 18);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(1327, 47);
            this.groupBox25.TabIndex = 9;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "Current number of log entries";
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox1.Location = new System.Drawing.Point(3, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(184, 26);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Start security monitoring";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // NumberOfAuditTB
            // 
            this.NumberOfAuditTB.Dock = System.Windows.Forms.DockStyle.Right;
            this.NumberOfAuditTB.Location = new System.Drawing.Point(1095, 18);
            this.NumberOfAuditTB.Name = "NumberOfAuditTB";
            this.NumberOfAuditTB.ReadOnly = true;
            this.NumberOfAuditTB.Size = new System.Drawing.Size(229, 22);
            this.NumberOfAuditTB.TabIndex = 2;
            this.NumberOfAuditTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // splitContainer4
            // 
            this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer4.Location = new System.Drawing.Point(3, 85);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.groupBox23);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.groupBox24);
            this.splitContainer4.Size = new System.Drawing.Size(1327, 597);
            this.splitContainer4.SplitterDistance = 324;
            this.splitContainer4.TabIndex = 8;
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.listBox4);
            this.groupBox23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox23.Location = new System.Drawing.Point(0, 0);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(1323, 320);
            this.groupBox23.TabIndex = 6;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "Log entries";
            // 
            // listBox4
            // 
            this.listBox4.BackColor = System.Drawing.SystemColors.Control;
            this.listBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.HorizontalScrollbar = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(3, 18);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(1317, 299);
            this.listBox4.TabIndex = 4;
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.listBox3);
            this.groupBox24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox24.Location = new System.Drawing.Point(0, 0);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(1323, 265);
            this.groupBox24.TabIndex = 7;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "History of changes in the number of records";
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.SystemColors.Control;
            this.listBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(3, 18);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(1317, 244);
            this.listBox3.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.splitContainer3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(1339, 672);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "System resources";
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox6);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox8);
            this.splitContainer3.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer3.Size = new System.Drawing.Size(1333, 666);
            this.splitContainer3.SplitterDistance = 410;
            this.splitContainer3.TabIndex = 5;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ChartForSysRes);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1329, 406);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chart";
            // 
            // ChartForSysRes
            // 
            this.ChartForSysRes.BackColor = System.Drawing.SystemColors.Control;
            chartArea10.BackColor = System.Drawing.Color.LightGray;
            chartArea10.Name = "ChartArea1";
            this.ChartForSysRes.ChartAreas.Add(chartArea10);
            this.ChartForSysRes.Dock = System.Windows.Forms.DockStyle.Fill;
            legend10.Name = "Legend1";
            this.ChartForSysRes.Legends.Add(legend10);
            this.ChartForSysRes.Location = new System.Drawing.Point(3, 18);
            this.ChartForSysRes.Name = "ChartForSysRes";
            this.ChartForSysRes.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series28.BorderWidth = 3;
            series28.ChartArea = "ChartArea1";
            series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series28.Legend = "Legend1";
            series28.Name = "CPU";
            series29.BorderWidth = 3;
            series29.ChartArea = "ChartArea1";
            series29.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series29.Legend = "Legend1";
            series29.Name = "Phisycal disc";
            series30.BorderWidth = 3;
            series30.ChartArea = "ChartArea1";
            series30.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series30.Legend = "Legend1";
            series30.Name = "Memory";
            this.ChartForSysRes.Series.Add(series28);
            this.ChartForSysRes.Series.Add(series29);
            this.ChartForSysRes.Series.Add(series30);
            this.ChartForSysRes.Size = new System.Drawing.Size(1323, 385);
            this.ChartForSysRes.TabIndex = 2;
            this.ChartForSysRes.Text = "chart1";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBox1);
            this.groupBox8.Controls.Add(this.CaptureBtnSysRes);
            this.groupBox8.Controls.Add(this.listBox2);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(0, 62);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1329, 186);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Processes";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(3, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1323, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CaptureBtnSysRes
            // 
            this.CaptureBtnSysRes.Appearance = System.Windows.Forms.Appearance.Button;
            this.CaptureBtnSysRes.AutoSize = true;
            this.CaptureBtnSysRes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CaptureBtnSysRes.Location = new System.Drawing.Point(3, 157);
            this.CaptureBtnSysRes.Name = "CaptureBtnSysRes";
            this.CaptureBtnSysRes.Size = new System.Drawing.Size(1323, 26);
            this.CaptureBtnSysRes.TabIndex = 3;
            this.CaptureBtnSysRes.Text = "Capture this list box";
            this.CaptureBtnSysRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CaptureBtnSysRes.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.BackColor = System.Drawing.SystemColors.Control;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(7, 20);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(1316, 116);
            this.listBox2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CountProcesses);
            this.groupBox1.Controls.Add(this.NumberOfProcTB);
            this.groupBox1.Controls.Add(this.MemoryTB);
            this.groupBox1.Controls.Add(this.PhysicalDiscTB);
            this.groupBox1.Controls.Add(this.ProcesLoadTB);
            this.groupBox1.Controls.Add(this.LabelMemoryLoad);
            this.groupBox1.Controls.Add(this.LabelPhysicalDisk);
            this.groupBox1.Controls.Add(this.ProcessLoadLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1329, 62);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data ";
            // 
            // CountProcesses
            // 
            this.CountProcesses.AutoSize = true;
            this.CountProcesses.Location = new System.Drawing.Point(6, 19);
            this.CountProcesses.Name = "CountProcesses";
            this.CountProcesses.Size = new System.Drawing.Size(125, 16);
            this.CountProcesses.TabIndex = 1;
            this.CountProcesses.Text = "Count Processes";
            // 
            // NumberOfProcTB
            // 
            this.NumberOfProcTB.Location = new System.Drawing.Point(170, 16);
            this.NumberOfProcTB.Name = "NumberOfProcTB";
            this.NumberOfProcTB.ReadOnly = true;
            this.NumberOfProcTB.Size = new System.Drawing.Size(90, 22);
            this.NumberOfProcTB.TabIndex = 2;
            this.NumberOfProcTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MemoryTB
            // 
            this.MemoryTB.Location = new System.Drawing.Point(1139, 16);
            this.MemoryTB.Name = "MemoryTB";
            this.MemoryTB.ReadOnly = true;
            this.MemoryTB.Size = new System.Drawing.Size(164, 22);
            this.MemoryTB.TabIndex = 8;
            this.MemoryTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PhysicalDiscTB
            // 
            this.PhysicalDiscTB.Location = new System.Drawing.Point(809, 16);
            this.PhysicalDiscTB.Name = "PhysicalDiscTB";
            this.PhysicalDiscTB.ReadOnly = true;
            this.PhysicalDiscTB.Size = new System.Drawing.Size(164, 22);
            this.PhysicalDiscTB.TabIndex = 7;
            this.PhysicalDiscTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ProcesLoadTB
            // 
            this.ProcesLoadTB.Location = new System.Drawing.Point(427, 16);
            this.ProcesLoadTB.Name = "ProcesLoadTB";
            this.ProcesLoadTB.ReadOnly = true;
            this.ProcesLoadTB.Size = new System.Drawing.Size(164, 22);
            this.ProcesLoadTB.TabIndex = 6;
            this.ProcesLoadTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelMemoryLoad
            // 
            this.LabelMemoryLoad.AutoSize = true;
            this.LabelMemoryLoad.Location = new System.Drawing.Point(979, 19);
            this.LabelMemoryLoad.Name = "LabelMemoryLoad";
            this.LabelMemoryLoad.Size = new System.Drawing.Size(51, 16);
            this.LabelMemoryLoad.TabIndex = 5;
            this.LabelMemoryLoad.Text = "label1";
            // 
            // LabelPhysicalDisk
            // 
            this.LabelPhysicalDisk.AutoSize = true;
            this.LabelPhysicalDisk.Location = new System.Drawing.Point(597, 19);
            this.LabelPhysicalDisk.Name = "LabelPhysicalDisk";
            this.LabelPhysicalDisk.Size = new System.Drawing.Size(51, 16);
            this.LabelPhysicalDisk.TabIndex = 3;
            this.LabelPhysicalDisk.Text = "label1";
            // 
            // ProcessLoadLabel
            // 
            this.ProcessLoadLabel.AutoSize = true;
            this.ProcessLoadLabel.Location = new System.Drawing.Point(266, 18);
            this.ProcessLoadLabel.Name = "ProcessLoadLabel";
            this.ProcessLoadLabel.Size = new System.Drawing.Size(51, 16);
            this.ProcessLoadLabel.TabIndex = 1;
            this.ProcessLoadLabel.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1347, 701);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Silver;
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1339, 672);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "System resources (Data table)";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.splitter1);
            this.groupBox7.Controls.Add(this.panel3);
            this.groupBox7.Controls.Add(this.splitContainer2);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1333, 666);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "System resources history";
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Location = new System.Drawing.Point(905, 18);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 645);
            this.splitter1.TabIndex = 15;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.groupBox9);
            this.panel3.Controls.Add(this.groupBox10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(905, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 645);
            this.panel3.TabIndex = 14;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.listBox5);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox9.Location = new System.Drawing.Point(0, 134);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(421, 507);
            this.groupBox9.TabIndex = 9;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Errors or exeptions";
            // 
            // listBox5
            // 
            this.listBox5.BackColor = System.Drawing.SystemColors.Control;
            this.listBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 16;
            this.listBox5.Location = new System.Drawing.Point(3, 18);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(415, 486);
            this.listBox5.TabIndex = 6;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.ClearTableDataSysRes);
            this.groupBox10.Controls.Add(this.DeleteTableSysRes);
            this.groupBox10.Controls.Add(this.CreateTableSysRes);
            this.groupBox10.Controls.Add(this.AddToTableSysRes);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox10.Location = new System.Drawing.Point(0, 0);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(421, 128);
            this.groupBox10.TabIndex = 10;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Control";
            // 
            // ClearTableDataSysRes
            // 
            this.ClearTableDataSysRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearTableDataSysRes.Location = new System.Drawing.Point(239, 71);
            this.ClearTableDataSysRes.Name = "ClearTableDataSysRes";
            this.ClearTableDataSysRes.Size = new System.Drawing.Size(174, 47);
            this.ClearTableDataSysRes.TabIndex = 5;
            this.ClearTableDataSysRes.Text = "Clear this table";
            this.ClearTableDataSysRes.UseVisualStyleBackColor = true;
            this.ClearTableDataSysRes.Click += new System.EventHandler(this.ClearTableDataSysRes_Click);
            // 
            // DeleteTableSysRes
            // 
            this.DeleteTableSysRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteTableSysRes.Location = new System.Drawing.Point(25, 71);
            this.DeleteTableSysRes.Name = "DeleteTableSysRes";
            this.DeleteTableSysRes.Size = new System.Drawing.Size(184, 47);
            this.DeleteTableSysRes.TabIndex = 8;
            this.DeleteTableSysRes.Text = "Delete table";
            this.DeleteTableSysRes.UseVisualStyleBackColor = true;
            this.DeleteTableSysRes.Click += new System.EventHandler(this.DeleteTableSysRes_Click);
            // 
            // CreateTableSysRes
            // 
            this.CreateTableSysRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateTableSysRes.Location = new System.Drawing.Point(25, 25);
            this.CreateTableSysRes.Name = "CreateTableSysRes";
            this.CreateTableSysRes.Size = new System.Drawing.Size(184, 47);
            this.CreateTableSysRes.TabIndex = 7;
            this.CreateTableSysRes.Text = "Create table";
            this.CreateTableSysRes.UseVisualStyleBackColor = true;
            this.CreateTableSysRes.Click += new System.EventHandler(this.CreateTableSysRes_Click);
            // 
            // AddToTableSysRes
            // 
            this.AddToTableSysRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddToTableSysRes.Location = new System.Drawing.Point(239, 25);
            this.AddToTableSysRes.Name = "AddToTableSysRes";
            this.AddToTableSysRes.Size = new System.Drawing.Size(174, 47);
            this.AddToTableSysRes.TabIndex = 4;
            this.AddToTableSysRes.Text = "Fill to table";
            this.AddToTableSysRes.UseVisualStyleBackColor = true;
            this.AddToTableSysRes.Click += new System.EventHandler(this.AddToTableSysRes_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitContainer2.Location = new System.Drawing.Point(3, 18);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox20);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox19);
            this.splitContainer2.Size = new System.Drawing.Size(902, 645);
            this.splitContainer2.SplitterDistance = 275;
            this.splitContainer2.TabIndex = 13;
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.ClearSysRes);
            this.groupBox20.Controls.Add(this.GoBtnSysRes);
            this.groupBox20.Controls.Add(this.richTextBoxSysRes);
            this.groupBox20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox20.Location = new System.Drawing.Point(0, 0);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(898, 271);
            this.groupBox20.TabIndex = 12;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Filtering by request";
            // 
            // ClearSysRes
            // 
            this.ClearSysRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearSysRes.Location = new System.Drawing.Point(676, 237);
            this.ClearSysRes.Name = "ClearSysRes";
            this.ClearSysRes.Size = new System.Drawing.Size(216, 28);
            this.ClearSysRes.TabIndex = 10;
            this.ClearSysRes.Text = "Clear textbox";
            this.ClearSysRes.UseVisualStyleBackColor = true;
            this.ClearSysRes.Click += new System.EventHandler(this.ClearSysRes_Click);
            // 
            // GoBtnSysRes
            // 
            this.GoBtnSysRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GoBtnSysRes.Location = new System.Drawing.Point(454, 237);
            this.GoBtnSysRes.Name = "GoBtnSysRes";
            this.GoBtnSysRes.Size = new System.Drawing.Size(216, 28);
            this.GoBtnSysRes.TabIndex = 9;
            this.GoBtnSysRes.Text = "Go";
            this.GoBtnSysRes.UseVisualStyleBackColor = true;
            this.GoBtnSysRes.Click += new System.EventHandler(this.GoBtnSysRes_Click);
            // 
            // richTextBoxSysRes
            // 
            this.richTextBoxSysRes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxSysRes.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxSysRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxSysRes.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.richTextBoxSysRes.Location = new System.Drawing.Point(4, 20);
            this.richTextBoxSysRes.Name = "richTextBoxSysRes";
            this.richTextBoxSysRes.Size = new System.Drawing.Size(884, 211);
            this.richTextBoxSysRes.TabIndex = 0;
            this.richTextBoxSysRes.Text = "";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.dataGridSysRes);
            this.groupBox19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox19.Location = new System.Drawing.Point(0, 0);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(898, 362);
            this.groupBox19.TabIndex = 11;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Output";
            // 
            // dataGridSysRes
            // 
            this.dataGridSysRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSysRes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSysRes,
            this.timeSysRes,
            this.numberprocess,
            this.percproc,
            this.percdisc,
            this.percmemory});
            this.dataGridSysRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSysRes.Location = new System.Drawing.Point(3, 18);
            this.dataGridSysRes.Name = "dataGridSysRes";
            this.dataGridSysRes.Size = new System.Drawing.Size(892, 341);
            this.dataGridSysRes.TabIndex = 0;
            // 
            // idSysRes
            // 
            dataGridViewCellStyle9.NullValue = null;
            this.idSysRes.DefaultCellStyle = dataGridViewCellStyle9;
            this.idSysRes.HeaderText = "ID";
            this.idSysRes.Name = "idSysRes";
            // 
            // timeSysRes
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Format = "G";
            dataGridViewCellStyle10.NullValue = null;
            this.timeSysRes.DefaultCellStyle = dataGridViewCellStyle10;
            this.timeSysRes.HeaderText = "Time";
            this.timeSysRes.Name = "timeSysRes";
            this.timeSysRes.Width = 150;
            // 
            // numberprocess
            // 
            this.numberprocess.HeaderText = "NumberofProcess";
            this.numberprocess.Name = "numberprocess";
            this.numberprocess.Width = 130;
            // 
            // percproc
            // 
            this.percproc.HeaderText = "PercentProcessorLoad";
            this.percproc.Name = "percproc";
            this.percproc.Width = 155;
            // 
            // percdisc
            // 
            this.percdisc.HeaderText = "PercentDiscLoad";
            this.percdisc.Name = "percdisc";
            this.percdisc.Width = 130;
            // 
            // percmemory
            // 
            this.percmemory.HeaderText = "PercentMemoryLoad";
            this.percmemory.Name = "percmemory";
            this.percmemory.Width = 140;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Silver;
            this.tabPage5.Controls.Add(this.groupBox11);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1339, 672);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Security (Data table)";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.splitContainer5);
            this.groupBox11.Controls.Add(this.groupBox14);
            this.groupBox11.Controls.Add(this.groupBox13);
            this.groupBox11.Location = new System.Drawing.Point(8, 6);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(1327, 679);
            this.groupBox11.TabIndex = 0;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Security history";
            // 
            // splitContainer5
            // 
            this.splitContainer5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer5.Location = new System.Drawing.Point(6, 21);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.groupBox21);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.groupBox12);
            this.splitContainer5.Size = new System.Drawing.Size(931, 652);
            this.splitContainer5.SplitterDistance = 326;
            this.splitContainer5.TabIndex = 14;
            // 
            // groupBox21
            // 
            this.groupBox21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox21.Controls.Add(this.ClearSecurity);
            this.groupBox21.Controls.Add(this.GoBtnSecurity);
            this.groupBox21.Controls.Add(this.richTextBoxSecurity);
            this.groupBox21.Location = new System.Drawing.Point(3, 3);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(921, 316);
            this.groupBox21.TabIndex = 13;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Filtering by request";
            // 
            // ClearSecurity
            // 
            this.ClearSecurity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearSecurity.Location = new System.Drawing.Point(699, 282);
            this.ClearSecurity.Name = "ClearSecurity";
            this.ClearSecurity.Size = new System.Drawing.Size(216, 28);
            this.ClearSecurity.TabIndex = 10;
            this.ClearSecurity.Text = "Clear textbox";
            this.ClearSecurity.UseVisualStyleBackColor = true;
            this.ClearSecurity.Click += new System.EventHandler(this.ClearSecurity_Click);
            // 
            // GoBtnSecurity
            // 
            this.GoBtnSecurity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GoBtnSecurity.Location = new System.Drawing.Point(477, 282);
            this.GoBtnSecurity.Name = "GoBtnSecurity";
            this.GoBtnSecurity.Size = new System.Drawing.Size(216, 28);
            this.GoBtnSecurity.TabIndex = 9;
            this.GoBtnSecurity.Text = "Go";
            this.GoBtnSecurity.UseVisualStyleBackColor = true;
            this.GoBtnSecurity.Click += new System.EventHandler(this.GoBtnSecurity_Click);
            // 
            // richTextBoxSecurity
            // 
            this.richTextBoxSecurity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxSecurity.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.richTextBoxSecurity.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.richTextBoxSecurity.Location = new System.Drawing.Point(6, 25);
            this.richTextBoxSecurity.Name = "richTextBoxSecurity";
            this.richTextBoxSecurity.Size = new System.Drawing.Size(909, 251);
            this.richTextBoxSecurity.TabIndex = 0;
            this.richTextBoxSecurity.Text = "";
            // 
            // groupBox12
            // 
            this.groupBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox12.Controls.Add(this.dataGridViewSecurity);
            this.groupBox12.Location = new System.Drawing.Point(3, 3);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(921, 312);
            this.groupBox12.TabIndex = 0;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Data table";
            // 
            // dataGridViewSecurity
            // 
            this.dataGridViewSecurity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSecurity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSecurity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSecurity,
            this.timeSecurity,
            this.entryType});
            this.dataGridViewSecurity.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewSecurity.Name = "dataGridViewSecurity";
            this.dataGridViewSecurity.Size = new System.Drawing.Size(909, 285);
            this.dataGridViewSecurity.TabIndex = 0;
            // 
            // idSecurity
            // 
            this.idSecurity.HeaderText = "ID";
            this.idSecurity.Name = "idSecurity";
            // 
            // timeSecurity
            // 
            this.timeSecurity.HeaderText = "Time";
            this.timeSecurity.Name = "timeSecurity";
            // 
            // entryType
            // 
            this.entryType.HeaderText = "Audit";
            this.entryType.Name = "entryType";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.listBox6);
            this.groupBox14.Location = new System.Drawing.Point(943, 165);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(378, 508);
            this.groupBox14.TabIndex = 2;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Errors or exeptions";
            // 
            // listBox6
            // 
            this.listBox6.BackColor = System.Drawing.SystemColors.Control;
            this.listBox6.FormattingEnabled = true;
            this.listBox6.HorizontalScrollbar = true;
            this.listBox6.ItemHeight = 16;
            this.listBox6.Location = new System.Drawing.Point(6, 18);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(366, 484);
            this.listBox6.TabIndex = 0;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.ClearTableSecurity);
            this.groupBox13.Controls.Add(this.DeleteToTableSecurity);
            this.groupBox13.Controls.Add(this.CreateTableSecurity);
            this.groupBox13.Controls.Add(this.AddToTableSecurity);
            this.groupBox13.Location = new System.Drawing.Point(943, 25);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(378, 134);
            this.groupBox13.TabIndex = 1;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Control";
            // 
            // ClearTableSecurity
            // 
            this.ClearTableSecurity.Location = new System.Drawing.Point(196, 78);
            this.ClearTableSecurity.Name = "ClearTableSecurity";
            this.ClearTableSecurity.Size = new System.Drawing.Size(174, 47);
            this.ClearTableSecurity.TabIndex = 10;
            this.ClearTableSecurity.Text = "Clear this table";
            this.ClearTableSecurity.UseVisualStyleBackColor = true;
            this.ClearTableSecurity.Click += new System.EventHandler(this.ClearTableSecurity_Click);
            // 
            // DeleteToTableSecurity
            // 
            this.DeleteToTableSecurity.Location = new System.Drawing.Point(6, 78);
            this.DeleteToTableSecurity.Name = "DeleteToTableSecurity";
            this.DeleteToTableSecurity.Size = new System.Drawing.Size(184, 47);
            this.DeleteToTableSecurity.TabIndex = 12;
            this.DeleteToTableSecurity.Text = "Delete table";
            this.DeleteToTableSecurity.UseVisualStyleBackColor = true;
            this.DeleteToTableSecurity.Click += new System.EventHandler(this.DeleteToTableSecurity_Click);
            // 
            // CreateTableSecurity
            // 
            this.CreateTableSecurity.Location = new System.Drawing.Point(6, 25);
            this.CreateTableSecurity.Name = "CreateTableSecurity";
            this.CreateTableSecurity.Size = new System.Drawing.Size(184, 47);
            this.CreateTableSecurity.TabIndex = 11;
            this.CreateTableSecurity.Text = "Create table";
            this.CreateTableSecurity.UseVisualStyleBackColor = true;
            this.CreateTableSecurity.Click += new System.EventHandler(this.CreateTableSecurity_Click);
            // 
            // AddToTableSecurity
            // 
            this.AddToTableSecurity.Location = new System.Drawing.Point(196, 25);
            this.AddToTableSecurity.Name = "AddToTableSecurity";
            this.AddToTableSecurity.Size = new System.Drawing.Size(174, 47);
            this.AddToTableSecurity.TabIndex = 9;
            this.AddToTableSecurity.Text = "Fill to table";
            this.AddToTableSecurity.UseVisualStyleBackColor = true;
            this.AddToTableSecurity.Click += new System.EventHandler(this.AddToTableSecurity_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.Silver;
            this.tabPage6.Controls.Add(this.groupBox15);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1339, 672);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Network (Data table)";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.splitContainer6);
            this.groupBox15.Controls.Add(this.groupBox16);
            this.groupBox15.Controls.Add(this.groupBox17);
            this.groupBox15.Location = new System.Drawing.Point(6, 6);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(1327, 679);
            this.groupBox15.TabIndex = 1;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Network history";
            // 
            // splitContainer6
            // 
            this.splitContainer6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer6.Location = new System.Drawing.Point(6, 21);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.groupBox22);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.groupBox18);
            this.splitContainer6.Size = new System.Drawing.Size(931, 652);
            this.splitContainer6.SplitterDistance = 416;
            this.splitContainer6.TabIndex = 15;
            // 
            // groupBox22
            // 
            this.groupBox22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox22.Controls.Add(this.ClearNetwork);
            this.groupBox22.Controls.Add(this.GoBtnNetwork);
            this.groupBox22.Controls.Add(this.richTextBoxNetwork);
            this.groupBox22.Location = new System.Drawing.Point(3, 3);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(921, 406);
            this.groupBox22.TabIndex = 14;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Filtering by request";
            // 
            // ClearNetwork
            // 
            this.ClearNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearNetwork.Location = new System.Drawing.Point(699, 372);
            this.ClearNetwork.Name = "ClearNetwork";
            this.ClearNetwork.Size = new System.Drawing.Size(216, 28);
            this.ClearNetwork.TabIndex = 10;
            this.ClearNetwork.Text = "Clear textbox";
            this.ClearNetwork.UseVisualStyleBackColor = true;
            this.ClearNetwork.Click += new System.EventHandler(this.ClearNetwork_Click);
            // 
            // GoBtnNetwork
            // 
            this.GoBtnNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GoBtnNetwork.Location = new System.Drawing.Point(477, 372);
            this.GoBtnNetwork.Name = "GoBtnNetwork";
            this.GoBtnNetwork.Size = new System.Drawing.Size(216, 28);
            this.GoBtnNetwork.TabIndex = 9;
            this.GoBtnNetwork.Text = "Go";
            this.GoBtnNetwork.UseVisualStyleBackColor = true;
            this.GoBtnNetwork.Click += new System.EventHandler(this.GoBtnNetwork_Click);
            // 
            // richTextBoxNetwork
            // 
            this.richTextBoxNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxNetwork.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.richTextBoxNetwork.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.richTextBoxNetwork.Location = new System.Drawing.Point(6, 25);
            this.richTextBoxNetwork.Name = "richTextBoxNetwork";
            this.richTextBoxNetwork.Size = new System.Drawing.Size(909, 344);
            this.richTextBoxNetwork.TabIndex = 0;
            this.richTextBoxNetwork.Text = "";
            // 
            // groupBox18
            // 
            this.groupBox18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox18.Controls.Add(this.dataGridNetwork);
            this.groupBox18.Location = new System.Drawing.Point(3, 3);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(921, 222);
            this.groupBox18.TabIndex = 0;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Data table";
            // 
            // dataGridNetwork
            // 
            this.dataGridNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridNetwork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNetwork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNetwork,
            this.timeNetwork,
            this.connectionsCount,
            this.receivedBytes,
            this.sentByte});
            this.dataGridNetwork.Location = new System.Drawing.Point(6, 25);
            this.dataGridNetwork.Name = "dataGridNetwork";
            this.dataGridNetwork.Size = new System.Drawing.Size(909, 191);
            this.dataGridNetwork.TabIndex = 0;
            // 
            // idNetwork
            // 
            this.idNetwork.HeaderText = "ID";
            this.idNetwork.Name = "idNetwork";
            // 
            // timeNetwork
            // 
            this.timeNetwork.HeaderText = "Time";
            this.timeNetwork.Name = "timeNetwork";
            // 
            // connectionsCount
            // 
            this.connectionsCount.HeaderText = "Number connections";
            this.connectionsCount.Name = "connectionsCount";
            // 
            // receivedBytes
            // 
            this.receivedBytes.HeaderText = "Received bytes";
            this.receivedBytes.Name = "receivedBytes";
            // 
            // sentByte
            // 
            this.sentByte.HeaderText = "Sent bytes";
            this.sentByte.Name = "sentByte";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.listBox7);
            this.groupBox16.Location = new System.Drawing.Point(943, 165);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(378, 508);
            this.groupBox16.TabIndex = 2;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Errors or exeptions";
            // 
            // listBox7
            // 
            this.listBox7.BackColor = System.Drawing.SystemColors.Control;
            this.listBox7.FormattingEnabled = true;
            this.listBox7.HorizontalScrollbar = true;
            this.listBox7.ItemHeight = 16;
            this.listBox7.Location = new System.Drawing.Point(6, 18);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(366, 484);
            this.listBox7.TabIndex = 0;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.ClearTableNetwork);
            this.groupBox17.Controls.Add(this.DeleteTableNetwork);
            this.groupBox17.Controls.Add(this.CreateTableNetwork);
            this.groupBox17.Controls.Add(this.AddToTableNetwork);
            this.groupBox17.Location = new System.Drawing.Point(943, 25);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(378, 134);
            this.groupBox17.TabIndex = 1;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Control";
            // 
            // ClearTableNetwork
            // 
            this.ClearTableNetwork.Location = new System.Drawing.Point(196, 78);
            this.ClearTableNetwork.Name = "ClearTableNetwork";
            this.ClearTableNetwork.Size = new System.Drawing.Size(174, 47);
            this.ClearTableNetwork.TabIndex = 10;
            this.ClearTableNetwork.Text = "Clear this table";
            this.ClearTableNetwork.UseVisualStyleBackColor = true;
            this.ClearTableNetwork.Click += new System.EventHandler(this.ClearTableNetwork_Click);
            // 
            // DeleteTableNetwork
            // 
            this.DeleteTableNetwork.Location = new System.Drawing.Point(6, 78);
            this.DeleteTableNetwork.Name = "DeleteTableNetwork";
            this.DeleteTableNetwork.Size = new System.Drawing.Size(184, 47);
            this.DeleteTableNetwork.TabIndex = 12;
            this.DeleteTableNetwork.Text = "Delete table";
            this.DeleteTableNetwork.UseVisualStyleBackColor = true;
            this.DeleteTableNetwork.Click += new System.EventHandler(this.DeleteTableNetwork_Click);
            // 
            // CreateTableNetwork
            // 
            this.CreateTableNetwork.Location = new System.Drawing.Point(6, 25);
            this.CreateTableNetwork.Name = "CreateTableNetwork";
            this.CreateTableNetwork.Size = new System.Drawing.Size(184, 47);
            this.CreateTableNetwork.TabIndex = 11;
            this.CreateTableNetwork.Text = "Create table";
            this.CreateTableNetwork.UseVisualStyleBackColor = true;
            this.CreateTableNetwork.Click += new System.EventHandler(this.CreateTableNetwork_Click);
            // 
            // AddToTableNetwork
            // 
            this.AddToTableNetwork.Location = new System.Drawing.Point(196, 25);
            this.AddToTableNetwork.Name = "AddToTableNetwork";
            this.AddToTableNetwork.Size = new System.Drawing.Size(174, 47);
            this.AddToTableNetwork.TabIndex = 9;
            this.AddToTableNetwork.Text = "Fill to table";
            this.AddToTableNetwork.UseVisualStyleBackColor = true;
            this.AddToTableNetwork.Click += new System.EventHandler(this.AddToTableNetwork_Click);
            // 
            // TimerWrkProgram
            // 
            this.TimerWrkProgram.Interval = 1000;
            this.TimerWrkProgram.Tick += new System.EventHandler(this.TimerWrkProgram_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainStartBtn,
            this.toolStripSeparator1,
            this.BtnStopWrk,
            this.toolStripSeparator2,
            this.ClearCharts,
            this.toolStripSeparator6,
            this.ConnectToSqlData,
            this.toolStripSeparator5,
            this.toolStripLabel2,
            this.StatConLbl,
            this.toolStripSeparator4,
            this.toolStripLabel1,
            this.LabelValueIteration,
            this.toolStripSeparator3,
            this.LabelWrkTime,
            this.toolStripSeparator7,
            this.OpenAnalysisBtn,
            this.toolStripSeparator8});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1347, 35);
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
            this.MainStartBtn.Size = new System.Drawing.Size(115, 32);
            this.MainStartBtn.Text = "Start monitoring";
            this.MainStartBtn.Click += new System.EventHandler(this.MainStartBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // BtnStopWrk
            // 
            this.BtnStopWrk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnStopWrk.Enabled = false;
            this.BtnStopWrk.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.BtnStopWrk.Image = ((System.Drawing.Image)(resources.GetObject("BtnStopWrk.Image")));
            this.BtnStopWrk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnStopWrk.Name = "BtnStopWrk";
            this.BtnStopWrk.Size = new System.Drawing.Size(106, 32);
            this.BtnStopWrk.Text = "Stop rendering";
            this.BtnStopWrk.Click += new System.EventHandler(this.BtnStopWrk_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // ClearCharts
            // 
            this.ClearCharts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ClearCharts.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.ClearCharts.Image = ((System.Drawing.Image)(resources.GetObject("ClearCharts.Image")));
            this.ClearCharts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearCharts.Name = "ClearCharts";
            this.ClearCharts.Size = new System.Drawing.Size(89, 32);
            this.ClearCharts.Text = "Clear Charts";
            this.ClearCharts.Click += new System.EventHandler(this.ClearCharts_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 35);
            // 
            // ConnectToSqlData
            // 
            this.ConnectToSqlData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ConnectToSqlData.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.ConnectToSqlData.Image = ((System.Drawing.Image)(resources.GetObject("ConnectToSqlData.Image")));
            this.ConnectToSqlData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConnectToSqlData.Name = "ConnectToSqlData";
            this.ConnectToSqlData.Size = new System.Drawing.Size(139, 32);
            this.ConnectToSqlData.Text = "Connect to database";
            this.ConnectToSqlData.Click += new System.EventHandler(this.ConnectToSqlData_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(183, 32);
            this.toolStripLabel2.Text = "Database connection status:";
            // 
            // StatConLbl
            // 
            this.StatConLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.StatConLbl.Name = "StatConLbl";
            this.StatConLbl.Size = new System.Drawing.Size(93, 32);
            this.StatConLbl.Text = "Disconnected";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(212, 32);
            this.toolStripLabel1.Text = "Number of iterations performed: ";
            // 
            // LabelValueIteration
            // 
            this.LabelValueIteration.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.LabelValueIteration.Name = "LabelValueIteration";
            this.LabelValueIteration.Size = new System.Drawing.Size(16, 32);
            this.LabelValueIteration.Text = "0";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 35);
            // 
            // LabelWrkTime
            // 
            this.LabelWrkTime.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.LabelWrkTime.Name = "LabelWrkTime";
            this.LabelWrkTime.Size = new System.Drawing.Size(258, 32);
            this.LabelWrkTime.Text = "Working hours of the program: 00:00:00 ";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 35);
            // 
            // OpenAnalysisBtn
            // 
            this.OpenAnalysisBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OpenAnalysisBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.OpenAnalysisBtn.Image = ((System.Drawing.Image)(resources.GetObject("OpenAnalysisBtn.Image")));
            this.OpenAnalysisBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenAnalysisBtn.Name = "OpenAnalysisBtn";
            this.OpenAnalysisBtn.Size = new System.Drawing.Size(66, 32);
            this.OpenAnalysisBtn.Text = "Analysis";
            this.OpenAnalysisBtn.Click += new System.EventHandler(this.OpenAnalysisBtn_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 35);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 705);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1351, 39);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1351, 705);
            this.panel2.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1351, 744);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System monitor";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartForTCPCon)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.groupBox23.ResumeLayout(false);
            this.groupBox24.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartForSysRes)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox20.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSysRes)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecurity)).EndInit();
            this.groupBox14.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.groupBox22.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNetwork)).EndInit();
            this.groupBox16.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Diagnostics.PerformanceCounter Processor;
        private System.Windows.Forms.Timer MainTimerProgram;
        private System.Diagnostics.PerformanceCounter Disk;
        private System.Diagnostics.PerformanceCounter Memory;
        private System.Diagnostics.PerformanceCounter BytesReceived;
        private System.Diagnostics.PerformanceCounter SentBytes;
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
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.TextBox NumberOfAuditTB;
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
        private System.Windows.Forms.DataGridView dataGridSysRes;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel StatConLbl;
        private System.Windows.Forms.Button AddToTableSysRes;
        private System.Windows.Forms.Button ClearTableDataSysRes;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Button DeleteTableSysRes;
        private System.Windows.Forms.Button CreateTableSysRes;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ToolStripButton ConnectToSqlData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button ClearTableSecurity;
        private System.Windows.Forms.Button DeleteToTableSecurity;
        private System.Windows.Forms.Button CreateTableSecurity;
        private System.Windows.Forms.Button AddToTableSecurity;
        private System.Windows.Forms.DataGridView dataGridViewSecurity;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSecurity;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeSecurity;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryType;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Button ClearTableNetwork;
        private System.Windows.Forms.Button DeleteTableNetwork;
        private System.Windows.Forms.Button CreateTableNetwork;
        private System.Windows.Forms.Button AddToTableNetwork;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.DataGridView dataGridNetwork;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNetwork;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeNetwork;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedBytes;
        private System.Windows.Forms.DataGridViewTextBoxColumn sentByte;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.RichTextBox richTextBoxSysRes;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Button GoBtnSysRes;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.Button GoBtnSecurity;
        private System.Windows.Forms.RichTextBox richTextBoxSecurity;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.Button GoBtnNetwork;
        private System.Windows.Forms.RichTextBox richTextBoxNetwork;
        private System.Windows.Forms.Button ClearSysRes;
        private System.Windows.Forms.Button ClearSecurity;
        private System.Windows.Forms.Button ClearNetwork;
        private System.Windows.Forms.ToolStripButton ClearCharts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.CheckBox CaptureBtnNetwork;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.CheckBox CaptureBtnSysRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSysRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeSysRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberprocess;
        private System.Windows.Forms.DataGridViewTextBoxColumn percproc;
        private System.Windows.Forms.DataGridViewTextBoxColumn percdisc;
        private System.Windows.Forms.DataGridViewTextBoxColumn percmemory;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton OpenAnalysisBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Splitter splitter1;
    }
}


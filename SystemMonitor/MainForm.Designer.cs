
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series31 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series32 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series33 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series34 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series35 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series36 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series37 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series38 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series39 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series40 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Processor = new System.Diagnostics.PerformanceCounter();
            this.MainTimerProgram = new System.Windows.Forms.Timer(this.components);
            this.Disk = new System.Diagnostics.PerformanceCounter();
            this.Memory = new System.Diagnostics.PerformanceCounter();
            this.BytesReceived = new System.Diagnostics.PerformanceCounter();
            this.SentBytes = new System.Diagnostics.PerformanceCounter();
            this.ChartForRec = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.trackBarPosChartNet = new System.Windows.Forms.TrackBar();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TrBarMem = new System.Windows.Forms.TrackBar();
            this.ChartMemory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TrBarDisc = new System.Windows.Forms.TrackBar();
            this.ChartDisc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChartCPU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TrBarCPU = new System.Windows.Forms.TrackBar();
            this.trackBarPosChartSR = new System.Windows.Forms.TrackBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TrBarSent = new System.Windows.Forms.TrackBar();
            this.ChartForSent = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearTableDataSysRes = new System.Windows.Forms.Button();
            this.CreateTableSysRes = new System.Windows.Forms.Button();
            this.GoBtnSysRes = new System.Windows.Forms.Button();
            this.DeleteTableSysRes = new System.Windows.Forms.Button();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.richTextBoxSysRes = new System.Windows.Forms.RichTextBox();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.MainDataGrid = new System.Windows.Forms.DataGridView();
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
            this.StatConLbl = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ForecastingLabel = new System.Windows.Forms.ToolStripLabel();
            this.LabelValueIteration = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.ForecastingTime = new System.Windows.Forms.ToolStripLabel();
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
            ((System.ComponentModel.ISupportInitialize)(this.ChartForRec)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPosChartNet)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrBarMem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartMemory)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrBarDisc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDisc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrBarCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPosChartSR)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrBarSent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartForSent)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).BeginInit();
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
            // ChartForRec
            // 
            this.ChartForRec.BackColor = System.Drawing.SystemColors.Control;
            chartArea6.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea6.AxisX.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea6.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea6.AxisX.ScaleView.Size = 100D;
            chartArea6.AxisX.ScaleView.Zoomable = false;
            chartArea6.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Gray;
            chartArea6.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea6.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea6.AxisY.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea6.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea6.AxisY.ScrollBar.BackColor = System.Drawing.Color.DarkGray;
            chartArea6.BackColor = System.Drawing.Color.Transparent;
            chartArea6.Name = "ChartArea1";
            this.ChartForRec.ChartAreas.Add(chartArea6);
            this.ChartForRec.Dock = System.Windows.Forms.DockStyle.Top;
            legend6.Name = "Legend1";
            this.ChartForRec.Legends.Add(legend6);
            this.ChartForRec.Location = new System.Drawing.Point(3, 18);
            this.ChartForRec.Name = "ChartForRec";
            this.ChartForRec.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series21.BorderWidth = 2;
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series21.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series21.LabelBackColor = System.Drawing.Color.White;
            series21.LabelBorderWidth = 2;
            series21.Legend = "Legend1";
            series21.Name = "Received bytes";
            series22.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series22.BorderWidth = 2;
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series22.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series22.Legend = "Legend1";
            series22.Name = "Forecast";
            series23.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            series23.BorderWidth = 2;
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series23.Color = System.Drawing.Color.Red;
            series23.Legend = "Legend1";
            series23.Name = "Max";
            series24.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            series24.BorderWidth = 2;
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series24.Color = System.Drawing.Color.Red;
            series24.Legend = "Legend1";
            series24.Name = "Min";
            this.ChartForRec.Series.Add(series21);
            this.ChartForRec.Series.Add(series22);
            this.ChartForRec.Series.Add(series23);
            this.ChartForRec.Series.Add(series24);
            this.ChartForRec.Size = new System.Drawing.Size(620, 240);
            this.ChartForRec.TabIndex = 6;
            this.ChartForRec.Text = "chart3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.trackBarPosChartNet);
            this.groupBox4.Controls.Add(this.ChartForRec);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(626, 277);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Received bytes";
            // 
            // trackBarPosChartNet
            // 
            this.trackBarPosChartNet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBarPosChartNet.Location = new System.Drawing.Point(3, 229);
            this.trackBarPosChartNet.Maximum = 500;
            this.trackBarPosChartNet.Minimum = 10;
            this.trackBarPosChartNet.Name = "trackBarPosChartNet";
            this.trackBarPosChartNet.Size = new System.Drawing.Size(620, 45);
            this.trackBarPosChartNet.TabIndex = 12;
            this.trackBarPosChartNet.Value = 10;
            this.trackBarPosChartNet.Scroll += new System.EventHandler(this.trackBarPosChartNet_Scroll);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(1416, 700);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "System resources";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1410, 694);
            this.splitContainer1.SplitterDistance = 561;
            this.splitContainer1.TabIndex = 6;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer3.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer3.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer3.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer3.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer3.Size = new System.Drawing.Size(1410, 561);
            this.splitContainer3.SplitterDistance = 278;
            this.splitContainer3.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TrBarMem);
            this.groupBox3.Controls.Add(this.ChartMemory);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(1000, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(408, 276);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Memory";
            // 
            // TrBarMem
            // 
            this.TrBarMem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TrBarMem.Location = new System.Drawing.Point(3, 228);
            this.TrBarMem.Maximum = 500;
            this.TrBarMem.Minimum = 10;
            this.TrBarMem.Name = "TrBarMem";
            this.TrBarMem.Size = new System.Drawing.Size(402, 45);
            this.TrBarMem.TabIndex = 13;
            this.TrBarMem.Value = 10;
            this.TrBarMem.Scroll += new System.EventHandler(this.TrBarMem_Scroll);
            // 
            // ChartMemory
            // 
            this.ChartMemory.BackColor = System.Drawing.SystemColors.Control;
            chartArea7.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea7.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea7.AxisX.ScaleView.Size = 100D;
            chartArea7.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Gray;
            chartArea7.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea7.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea7.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea7.BackColor = System.Drawing.Color.Transparent;
            chartArea7.Name = "ChartArea1";
            this.ChartMemory.ChartAreas.Add(chartArea7);
            this.ChartMemory.Dock = System.Windows.Forms.DockStyle.Top;
            legend7.Name = "Legend1";
            this.ChartMemory.Legends.Add(legend7);
            this.ChartMemory.Location = new System.Drawing.Point(3, 18);
            this.ChartMemory.Name = "ChartMemory";
            this.ChartMemory.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series25.BorderWidth = 2;
            series25.ChartArea = "ChartArea1";
            series25.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series25.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series25.Legend = "Legend1";
            series25.Name = "Memory";
            series26.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series26.BorderWidth = 2;
            series26.ChartArea = "ChartArea1";
            series26.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series26.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series26.Legend = "Legend1";
            series26.Name = "Forecast";
            series27.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            series27.BorderWidth = 2;
            series27.ChartArea = "ChartArea1";
            series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series27.Color = System.Drawing.Color.Red;
            series27.Legend = "Legend1";
            series27.Name = "Max";
            series28.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            series28.BorderWidth = 2;
            series28.ChartArea = "ChartArea1";
            series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series28.Color = System.Drawing.Color.Red;
            series28.Legend = "Legend1";
            series28.Name = "Min";
            this.ChartMemory.Series.Add(series25);
            this.ChartMemory.Series.Add(series26);
            this.ChartMemory.Series.Add(series27);
            this.ChartMemory.Series.Add(series28);
            this.ChartMemory.Size = new System.Drawing.Size(402, 210);
            this.ChartMemory.TabIndex = 2;
            this.ChartMemory.Text = "chart2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TrBarDisc);
            this.groupBox2.Controls.Add(this.ChartDisc);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(407, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 276);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Physical disc";
            // 
            // TrBarDisc
            // 
            this.TrBarDisc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TrBarDisc.Location = new System.Drawing.Point(3, 228);
            this.TrBarDisc.Maximum = 500;
            this.TrBarDisc.Minimum = 10;
            this.TrBarDisc.Name = "TrBarDisc";
            this.TrBarDisc.Size = new System.Drawing.Size(587, 45);
            this.TrBarDisc.TabIndex = 12;
            this.TrBarDisc.Value = 10;
            this.TrBarDisc.Scroll += new System.EventHandler(this.TrBarDisc_Scroll);
            // 
            // ChartDisc
            // 
            this.ChartDisc.BackColor = System.Drawing.SystemColors.Control;
            chartArea8.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea8.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea8.AxisX.ScaleView.Size = 100D;
            chartArea8.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Gray;
            chartArea8.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea8.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea8.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea8.BackColor = System.Drawing.Color.Transparent;
            chartArea8.Name = "ChartArea1";
            this.ChartDisc.ChartAreas.Add(chartArea8);
            this.ChartDisc.Dock = System.Windows.Forms.DockStyle.Top;
            legend8.Name = "Legend1";
            this.ChartDisc.Legends.Add(legend8);
            this.ChartDisc.Location = new System.Drawing.Point(3, 18);
            this.ChartDisc.Name = "ChartDisc";
            this.ChartDisc.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series29.BorderWidth = 2;
            series29.ChartArea = "ChartArea1";
            series29.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series29.Color = System.Drawing.Color.Green;
            series29.Legend = "Legend1";
            series29.Name = "Phisycal disc";
            series30.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series30.BorderWidth = 2;
            series30.ChartArea = "ChartArea1";
            series30.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series30.Color = System.Drawing.Color.Green;
            series30.Legend = "Legend1";
            series30.Name = "Forecast";
            series31.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            series31.BorderWidth = 2;
            series31.ChartArea = "ChartArea1";
            series31.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series31.Color = System.Drawing.Color.Red;
            series31.Legend = "Legend1";
            series31.Name = "Max";
            series32.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            series32.BorderWidth = 2;
            series32.ChartArea = "ChartArea1";
            series32.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series32.Color = System.Drawing.Color.Red;
            series32.Legend = "Legend1";
            series32.Name = "Min";
            this.ChartDisc.Series.Add(series29);
            this.ChartDisc.Series.Add(series30);
            this.ChartDisc.Series.Add(series31);
            this.ChartDisc.Series.Add(series32);
            this.ChartDisc.Size = new System.Drawing.Size(587, 210);
            this.ChartDisc.TabIndex = 2;
            this.ChartDisc.Text = "chart1";
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(-400, 225);
            this.trackBar1.Maximum = 500;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(238, 45);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.Value = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChartCPU);
            this.groupBox1.Controls.Add(this.TrBarCPU);
            this.groupBox1.Controls.Add(this.trackBarPosChartSR);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 276);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPU";
            // 
            // ChartCPU
            // 
            this.ChartCPU.BackColor = System.Drawing.SystemColors.Control;
            chartArea9.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea9.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea9.AxisX.ScaleView.Size = 100D;
            chartArea9.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Gray;
            chartArea9.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea9.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea9.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea9.BackColor = System.Drawing.Color.Transparent;
            chartArea9.Name = "ChartArea1";
            this.ChartCPU.ChartAreas.Add(chartArea9);
            this.ChartCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            legend9.Name = "Legend1";
            this.ChartCPU.Legends.Add(legend9);
            this.ChartCPU.Location = new System.Drawing.Point(3, 18);
            this.ChartCPU.Name = "ChartCPU";
            this.ChartCPU.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series33.BorderWidth = 2;
            series33.ChartArea = "ChartArea1";
            series33.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series33.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series33.Legend = "Legend1";
            series33.LegendToolTip = "CPU";
            series33.Name = "CPU";
            series34.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series34.BorderWidth = 2;
            series34.ChartArea = "ChartArea1";
            series34.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series34.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series34.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series34.Legend = "Legend1";
            series34.LegendToolTip = "Forecast";
            series34.Name = "Forecast";
            series35.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            series35.BorderWidth = 2;
            series35.ChartArea = "ChartArea1";
            series35.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series35.Color = System.Drawing.Color.Red;
            series35.Legend = "Legend1";
            series35.Name = "Max";
            series36.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            series36.BorderWidth = 2;
            series36.ChartArea = "ChartArea1";
            series36.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series36.Color = System.Drawing.Color.Red;
            series36.Legend = "Legend1";
            series36.Name = "Min";
            this.ChartCPU.Series.Add(series33);
            this.ChartCPU.Series.Add(series34);
            this.ChartCPU.Series.Add(series35);
            this.ChartCPU.Series.Add(series36);
            this.ChartCPU.Size = new System.Drawing.Size(401, 210);
            this.ChartCPU.TabIndex = 2;
            this.ChartCPU.Text = "chart1";
            // 
            // TrBarCPU
            // 
            this.TrBarCPU.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TrBarCPU.Location = new System.Drawing.Point(3, 228);
            this.TrBarCPU.Maximum = 500;
            this.TrBarCPU.Minimum = 10;
            this.TrBarCPU.Name = "TrBarCPU";
            this.TrBarCPU.Size = new System.Drawing.Size(401, 45);
            this.TrBarCPU.TabIndex = 11;
            this.TrBarCPU.Value = 10;
            this.TrBarCPU.Scroll += new System.EventHandler(this.TrBarCPU_Scroll);
            // 
            // trackBarPosChartSR
            // 
            this.trackBarPosChartSR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarPosChartSR.Location = new System.Drawing.Point(-586, 225);
            this.trackBarPosChartSR.Maximum = 500;
            this.trackBarPosChartSR.Minimum = 10;
            this.trackBarPosChartSR.Name = "trackBarPosChartSR";
            this.trackBarPosChartSR.Size = new System.Drawing.Size(238, 45);
            this.trackBarPosChartSR.TabIndex = 11;
            this.trackBarPosChartSR.Value = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TrBarSent);
            this.groupBox5.Controls.Add(this.ChartForSent);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(626, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(782, 277);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sent bytes";
            // 
            // TrBarSent
            // 
            this.TrBarSent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TrBarSent.Location = new System.Drawing.Point(3, 229);
            this.TrBarSent.Maximum = 500;
            this.TrBarSent.Minimum = 10;
            this.TrBarSent.Name = "TrBarSent";
            this.TrBarSent.Size = new System.Drawing.Size(776, 45);
            this.TrBarSent.TabIndex = 12;
            this.TrBarSent.Value = 10;
            this.TrBarSent.Scroll += new System.EventHandler(this.TrBarSent_Scroll);
            // 
            // ChartForSent
            // 
            this.ChartForSent.BackColor = System.Drawing.SystemColors.Control;
            chartArea10.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea10.AxisX.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea10.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea10.AxisX.ScaleView.Size = 100D;
            chartArea10.AxisX.ScaleView.Zoomable = false;
            chartArea10.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Gray;
            chartArea10.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea10.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea10.AxisY.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea10.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea10.AxisY.ScrollBar.BackColor = System.Drawing.Color.DarkGray;
            chartArea10.BackColor = System.Drawing.Color.Transparent;
            chartArea10.Name = "ChartArea1";
            this.ChartForSent.ChartAreas.Add(chartArea10);
            this.ChartForSent.Dock = System.Windows.Forms.DockStyle.Top;
            legend10.Name = "Legend1";
            this.ChartForSent.Legends.Add(legend10);
            this.ChartForSent.Location = new System.Drawing.Point(3, 18);
            this.ChartForSent.Name = "ChartForSent";
            this.ChartForSent.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series37.BorderWidth = 2;
            series37.ChartArea = "ChartArea1";
            series37.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series37.Color = System.Drawing.Color.Teal;
            series37.LabelBorderWidth = 3;
            series37.Legend = "Legend1";
            series37.Name = "Sent bytes";
            series38.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series38.BorderWidth = 2;
            series38.ChartArea = "ChartArea1";
            series38.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series38.Color = System.Drawing.Color.Teal;
            series38.Legend = "Legend1";
            series38.Name = "Forecast";
            series39.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            series39.BorderWidth = 2;
            series39.ChartArea = "ChartArea1";
            series39.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series39.Color = System.Drawing.Color.Red;
            series39.Legend = "Legend1";
            series39.Name = "Max";
            series40.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            series40.BorderWidth = 2;
            series40.ChartArea = "ChartArea1";
            series40.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series40.Color = System.Drawing.Color.Red;
            series40.Legend = "Legend1";
            series40.Name = "Min";
            this.ChartForSent.Series.Add(series37);
            this.ChartForSent.Series.Add(series38);
            this.ChartForSent.Series.Add(series39);
            this.ChartForSent.Series.Add(series40);
            this.ChartForSent.Size = new System.Drawing.Size(776, 240);
            this.ChartForSent.TabIndex = 6;
            this.ChartForSent.Text = "chart3";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1408, 127);
            this.listBox1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1424, 729);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Transparent;
            this.tabPage4.Controls.Add(this.splitContainer2);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1416, 700);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Sql window";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.ClearTableDataSysRes);
            this.splitContainer2.Panel1.Controls.Add(this.CreateTableSysRes);
            this.splitContainer2.Panel1.Controls.Add(this.GoBtnSysRes);
            this.splitContainer2.Panel1.Controls.Add(this.DeleteTableSysRes);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox20);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox19);
            this.splitContainer2.Size = new System.Drawing.Size(1410, 694);
            this.splitContainer2.SplitterDistance = 493;
            this.splitContainer2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // ClearTableDataSysRes
            // 
            this.ClearTableDataSysRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearTableDataSysRes.Location = new System.Drawing.Point(757, 458);
            this.ClearTableDataSysRes.Name = "ClearTableDataSysRes";
            this.ClearTableDataSysRes.Size = new System.Drawing.Size(157, 28);
            this.ClearTableDataSysRes.TabIndex = 5;
            this.ClearTableDataSysRes.Text = "Clear table";
            this.ClearTableDataSysRes.UseVisualStyleBackColor = true;
            this.ClearTableDataSysRes.Click += new System.EventHandler(this.ClearTableDataSysRes_Click);
            // 
            // CreateTableSysRes
            // 
            this.CreateTableSysRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateTableSysRes.Location = new System.Drawing.Point(1083, 458);
            this.CreateTableSysRes.Name = "CreateTableSysRes";
            this.CreateTableSysRes.Size = new System.Drawing.Size(157, 28);
            this.CreateTableSysRes.TabIndex = 7;
            this.CreateTableSysRes.Text = "Create table";
            this.CreateTableSysRes.UseVisualStyleBackColor = true;
            this.CreateTableSysRes.Click += new System.EventHandler(this.CreateTableSysRes_Click);
            // 
            // GoBtnSysRes
            // 
            this.GoBtnSysRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GoBtnSysRes.Location = new System.Drawing.Point(1246, 458);
            this.GoBtnSysRes.Name = "GoBtnSysRes";
            this.GoBtnSysRes.Size = new System.Drawing.Size(157, 28);
            this.GoBtnSysRes.TabIndex = 9;
            this.GoBtnSysRes.Text = "Go";
            this.GoBtnSysRes.UseVisualStyleBackColor = true;
            this.GoBtnSysRes.Click += new System.EventHandler(this.GoBtnSysRes_Click);
            // 
            // DeleteTableSysRes
            // 
            this.DeleteTableSysRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteTableSysRes.Location = new System.Drawing.Point(920, 458);
            this.DeleteTableSysRes.Name = "DeleteTableSysRes";
            this.DeleteTableSysRes.Size = new System.Drawing.Size(157, 28);
            this.DeleteTableSysRes.TabIndex = 8;
            this.DeleteTableSysRes.Text = "Delete table";
            this.DeleteTableSysRes.UseVisualStyleBackColor = true;
            this.DeleteTableSysRes.Click += new System.EventHandler(this.DeleteTableSysRes_Click);
            // 
            // groupBox20
            // 
            this.groupBox20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox20.Controls.Add(this.richTextBoxSysRes);
            this.groupBox20.Location = new System.Drawing.Point(0, 0);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(1406, 452);
            this.groupBox20.TabIndex = 12;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Filtering by request";
            // 
            // richTextBoxSysRes
            // 
            this.richTextBoxSysRes.AutoWordSelection = true;
            this.richTextBoxSysRes.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxSysRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxSysRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxSysRes.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxSysRes.Location = new System.Drawing.Point(3, 18);
            this.richTextBoxSysRes.Name = "richTextBoxSysRes";
            this.richTextBoxSysRes.Size = new System.Drawing.Size(1400, 431);
            this.richTextBoxSysRes.TabIndex = 0;
            this.richTextBoxSysRes.Text = "";
            this.richTextBoxSysRes.TextChanged += new System.EventHandler(this.richTextBoxSysRes_TextChanged);
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.MainDataGrid);
            this.groupBox19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox19.Location = new System.Drawing.Point(0, 0);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(1406, 193);
            this.groupBox19.TabIndex = 11;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Output";
            // 
            // MainDataGrid
            // 
            this.MainDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDataGrid.Location = new System.Drawing.Point(3, 18);
            this.MainDataGrid.Name = "MainDataGrid";
            this.MainDataGrid.Size = new System.Drawing.Size(1400, 172);
            this.MainDataGrid.TabIndex = 0;
            // 
            // TimerWrkProgram
            // 
            this.TimerWrkProgram.Interval = 1000;
            this.TimerWrkProgram.Tick += new System.EventHandler(this.TimerWrkProgram_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainStartBtn,
            this.toolStripSeparator1,
            this.BtnStopWrk,
            this.toolStripSeparator2,
            this.ClearCharts,
            this.toolStripSeparator6,
            this.ConnectToSqlData,
            this.toolStripSeparator5,
            this.StatConLbl,
            this.toolStripSeparator4,
            this.ForecastingLabel,
            this.LabelValueIteration,
            this.toolStripSeparator9,
            this.ForecastingTime,
            this.toolStripSeparator3,
            this.LabelWrkTime,
            this.toolStripSeparator7,
            this.OpenAnalysisBtn,
            this.toolStripSeparator8});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1424, 35);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MainStartBtn
            // 
            this.MainStartBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MainStartBtn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.MainStartBtn.Image = ((System.Drawing.Image)(resources.GetObject("MainStartBtn.Image")));
            this.MainStartBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MainStartBtn.Name = "MainStartBtn";
            this.MainStartBtn.Size = new System.Drawing.Size(140, 32);
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
            this.BtnStopWrk.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnStopWrk.Image = ((System.Drawing.Image)(resources.GetObject("BtnStopWrk.Image")));
            this.BtnStopWrk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnStopWrk.Name = "BtnStopWrk";
            this.BtnStopWrk.Size = new System.Drawing.Size(124, 32);
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
            this.ClearCharts.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.ClearCharts.Image = ((System.Drawing.Image)(resources.GetObject("ClearCharts.Image")));
            this.ClearCharts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearCharts.Name = "ClearCharts";
            this.ClearCharts.Size = new System.Drawing.Size(108, 32);
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
            this.ConnectToSqlData.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.ConnectToSqlData.Image = ((System.Drawing.Image)(resources.GetObject("ConnectToSqlData.Image")));
            this.ConnectToSqlData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConnectToSqlData.Name = "ConnectToSqlData";
            this.ConnectToSqlData.Size = new System.Drawing.Size(164, 32);
            this.ConnectToSqlData.Text = "Connect to database";
            this.ConnectToSqlData.Click += new System.EventHandler(this.ConnectToSqlData_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 35);
            // 
            // StatConLbl
            // 
            this.StatConLbl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.StatConLbl.Name = "StatConLbl";
            this.StatConLbl.Size = new System.Drawing.Size(104, 32);
            this.StatConLbl.Text = "Disconnected";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 35);
            // 
            // ForecastingLabel
            // 
            this.ForecastingLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.ForecastingLabel.Name = "ForecastingLabel";
            this.ForecastingLabel.Size = new System.Drawing.Size(16, 32);
            this.ForecastingLabel.Text = "0";
            // 
            // LabelValueIteration
            // 
            this.LabelValueIteration.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.LabelValueIteration.Name = "LabelValueIteration";
            this.LabelValueIteration.Size = new System.Drawing.Size(16, 32);
            this.LabelValueIteration.Text = "0";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 35);
            // 
            // ForecastingTime
            // 
            this.ForecastingTime.Name = "ForecastingTime";
            this.ForecastingTime.Size = new System.Drawing.Size(136, 32);
            this.ForecastingTime.Text = "Forecasting time";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 35);
            // 
            // LabelWrkTime
            // 
            this.LabelWrkTime.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.LabelWrkTime.Name = "LabelWrkTime";
            this.LabelWrkTime.Size = new System.Drawing.Size(192, 32);
            this.LabelWrkTime.Text = "Working time: 00:00:00 ";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 35);
            // 
            // OpenAnalysisBtn
            // 
            this.OpenAnalysisBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OpenAnalysisBtn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.OpenAnalysisBtn.Image = ((System.Drawing.Image)(resources.GetObject("OpenAnalysisBtn.Image")));
            this.OpenAnalysisBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenAnalysisBtn.Name = "OpenAnalysisBtn";
            this.OpenAnalysisBtn.Size = new System.Drawing.Size(76, 32);
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
            this.panel1.Location = new System.Drawing.Point(0, 733);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1428, 39);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1428, 733);
            this.panel2.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1428, 772);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            ((System.ComponentModel.ISupportInitialize)(this.ChartForRec)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPosChartNet)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrBarMem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartMemory)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrBarDisc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDisc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrBarCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPosChartSR)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrBarSent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartForSent)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox20.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartForRec;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartCPU;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer TimerWrkProgram;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton MainStartBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnStopWrk;
        private System.Windows.Forms.ToolStripLabel ForecastingLabel;
        private System.Windows.Forms.ToolStripLabel LabelValueIteration;
        private System.Windows.Forms.ToolStripLabel LabelWrkTime;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView MainDataGrid;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel StatConLbl;
        private System.Windows.Forms.Button ClearTableDataSysRes;
        private System.Windows.Forms.Button DeleteTableSysRes;
        private System.Windows.Forms.Button CreateTableSysRes;
        private System.Windows.Forms.ToolStripButton ConnectToSqlData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.RichTextBox richTextBoxSysRes;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Button GoBtnSysRes;
        private System.Windows.Forms.ToolStripButton ClearCharts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton OpenAnalysisBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar trackBarPosChartSR;
        private System.Windows.Forms.TrackBar trackBarPosChartNet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripLabel ForecastingTime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartMemory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartDisc;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar TrBarCPU;
        private System.Windows.Forms.TrackBar TrBarMem;
        private System.Windows.Forms.TrackBar TrBarDisc;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TrackBar TrBarSent;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartForSent;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}


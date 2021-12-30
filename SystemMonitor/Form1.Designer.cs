
namespace SystemMonitor
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Processor = new System.Diagnostics.PerformanceCounter();
            this.TimerProcLoad = new System.Windows.Forms.Timer(this.components);
            this.Disk = new System.Diagnostics.PerformanceCounter();
            this.Memory = new System.Diagnostics.PerformanceCounter();
            this.BytesReceived = new System.Diagnostics.PerformanceCounter();
            this.SentBytes = new System.Diagnostics.PerformanceCounter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.CounterLogonServer = new System.Diagnostics.PerformanceCounter();
            this.CounterErrorLogon = new System.Diagnostics.PerformanceCounter();
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
            this.LabelErrorLogon = new System.Windows.Forms.Label();
            this.LabelLogonServer = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelMemoryLoad = new System.Windows.Forms.Label();
            this.MemoryLoadBar = new System.Windows.Forms.ProgressBar();
            this.LabelPhysicalDisk = new System.Windows.Forms.Label();
            this.PhisycalDiskBar = new System.Windows.Forms.ProgressBar();
            this.ProcessLoadBar = new System.Windows.Forms.ProgressBar();
            this.ProcessLoadLabel = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ChartForSysRes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.Processor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Memory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BytesReceived)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SentBytes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CounterLogonServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CounterErrorLogon)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartForSysRes)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Processor
            // 
            this.Processor.CategoryName = "Processor";
            this.Processor.CounterName = "% Processor Time";
            this.Processor.InstanceName = "_Total";
            // 
            // TimerProcLoad
            // 
            this.TimerProcLoad.Enabled = true;
            this.TimerProcLoad.Interval = 1000;
            this.TimerProcLoad.Tick += new System.EventHandler(this.TimerProcLoad_Tick);
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
            this.splitter1.Size = new System.Drawing.Size(3, 737);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // CounterLogonServer
            // 
            this.CounterLogonServer.CategoryName = "Server";
            this.CounterLogonServer.CounterName = "Logon/sec";
            // 
            // CounterErrorLogon
            // 
            this.CounterErrorLogon.CategoryName = "Server";
            this.CounterErrorLogon.CounterName = "Errors Logon";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1336, 708);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Network";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
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
            this.groupBox3.Size = new System.Drawing.Size(413, 693);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Active TCP Connections";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(401, 667);
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
            this.groupBox5.Size = new System.Drawing.Size(866, 533);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chart";
            // 
            // ChartForTCPCon
            // 
            this.ChartForTCPCon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.ChartForTCPCon.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartForTCPCon.Legends.Add(legend1);
            this.ChartForTCPCon.Location = new System.Drawing.Point(9, 19);
            this.ChartForTCPCon.Name = "ChartForTCPCon";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Legend = "Legend1";
            series1.Name = "Tcp connections count";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.Legend = "Legend1";
            series2.Name = "Received bytes";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series3.Legend = "Legend1";
            series3.Name = "Sent bytes";
            this.ChartForTCPCon.Series.Add(series1);
            this.ChartForTCPCon.Series.Add(series2);
            this.ChartForTCPCon.Series.Add(series3);
            this.ChartForTCPCon.Size = new System.Drawing.Size(851, 508);
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
            this.groupBox4.Location = new System.Drawing.Point(13, 547);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(866, 154);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data";
            // 
            // BytesSentLabel
            // 
            this.BytesSentLabel.AutoSize = true;
            this.BytesSentLabel.Location = new System.Drawing.Point(6, 89);
            this.BytesSentLabel.Name = "BytesSentLabel";
            this.BytesSentLabel.Size = new System.Drawing.Size(57, 13);
            this.BytesSentLabel.TabIndex = 3;
            this.BytesSentLabel.Text = "Sent bytes";
            // 
            // ReceivedBytesLabel
            // 
            this.ReceivedBytesLabel.AutoSize = true;
            this.ReceivedBytesLabel.Location = new System.Drawing.Point(6, 60);
            this.ReceivedBytesLabel.Name = "ReceivedBytesLabel";
            this.ReceivedBytesLabel.Size = new System.Drawing.Size(81, 13);
            this.ReceivedBytesLabel.TabIndex = 2;
            this.ReceivedBytesLabel.Text = "Received bytes";
            // 
            // LabelItemsCount
            // 
            this.LabelItemsCount.AutoSize = true;
            this.LabelItemsCount.Location = new System.Drawing.Point(6, 30);
            this.LabelItemsCount.Name = "LabelItemsCount";
            this.LabelItemsCount.Size = new System.Drawing.Size(86, 13);
            this.LabelItemsCount.TabIndex = 1;
            this.LabelItemsCount.Text = "LabelItemsCount";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1336, 708);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Security";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LabelErrorLogon);
            this.groupBox2.Controls.Add(this.LabelLogonServer);
            this.groupBox2.Location = new System.Drawing.Point(8, 421);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1321, 281);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // LabelErrorLogon
            // 
            this.LabelErrorLogon.AutoSize = true;
            this.LabelErrorLogon.Location = new System.Drawing.Point(26, 56);
            this.LabelErrorLogon.Name = "LabelErrorLogon";
            this.LabelErrorLogon.Size = new System.Drawing.Size(35, 13);
            this.LabelErrorLogon.TabIndex = 1;
            this.LabelErrorLogon.Text = "label1";
            // 
            // LabelLogonServer
            // 
            this.LabelLogonServer.AutoSize = true;
            this.LabelLogonServer.Location = new System.Drawing.Point(26, 27);
            this.LabelLogonServer.Name = "LabelLogonServer";
            this.LabelLogonServer.Size = new System.Drawing.Size(35, 13);
            this.LabelLogonServer.TabIndex = 0;
            this.LabelLogonServer.Text = "label1";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1336, 708);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "System resources";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer2.Size = new System.Drawing.Size(1336, 726);
            this.splitContainer2.SplitterDistance = 445;
            this.splitContainer2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.LabelMemoryLoad);
            this.groupBox1.Controls.Add(this.MemoryLoadBar);
            this.groupBox1.Controls.Add(this.LabelPhysicalDisk);
            this.groupBox1.Controls.Add(this.PhisycalDiskBar);
            this.groupBox1.Controls.Add(this.ProcessLoadBar);
            this.groupBox1.Controls.Add(this.ProcessLoadLabel);
            this.groupBox1.Location = new System.Drawing.Point(15, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 695);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data ";
            // 
            // LabelMemoryLoad
            // 
            this.LabelMemoryLoad.AutoSize = true;
            this.LabelMemoryLoad.Location = new System.Drawing.Point(15, 112);
            this.LabelMemoryLoad.Name = "LabelMemoryLoad";
            this.LabelMemoryLoad.Size = new System.Drawing.Size(35, 13);
            this.LabelMemoryLoad.TabIndex = 5;
            this.LabelMemoryLoad.Text = "label1";
            // 
            // MemoryLoadBar
            // 
            this.MemoryLoadBar.Location = new System.Drawing.Point(18, 128);
            this.MemoryLoadBar.Name = "MemoryLoadBar";
            this.MemoryLoadBar.Size = new System.Drawing.Size(206, 23);
            this.MemoryLoadBar.TabIndex = 4;
            // 
            // LabelPhysicalDisk
            // 
            this.LabelPhysicalDisk.AutoSize = true;
            this.LabelPhysicalDisk.Location = new System.Drawing.Point(15, 70);
            this.LabelPhysicalDisk.Name = "LabelPhysicalDisk";
            this.LabelPhysicalDisk.Size = new System.Drawing.Size(35, 13);
            this.LabelPhysicalDisk.TabIndex = 3;
            this.LabelPhysicalDisk.Text = "label1";
            // 
            // PhisycalDiskBar
            // 
            this.PhisycalDiskBar.Location = new System.Drawing.Point(18, 86);
            this.PhisycalDiskBar.Name = "PhisycalDiskBar";
            this.PhisycalDiskBar.Size = new System.Drawing.Size(206, 23);
            this.PhisycalDiskBar.TabIndex = 2;
            // 
            // ProcessLoadBar
            // 
            this.ProcessLoadBar.Location = new System.Drawing.Point(18, 42);
            this.ProcessLoadBar.Name = "ProcessLoadBar";
            this.ProcessLoadBar.Size = new System.Drawing.Size(206, 23);
            this.ProcessLoadBar.TabIndex = 0;
            // 
            // ProcessLoadLabel
            // 
            this.ProcessLoadLabel.AutoSize = true;
            this.ProcessLoadLabel.Location = new System.Drawing.Point(15, 26);
            this.ProcessLoadLabel.Name = "ProcessLoadLabel";
            this.ProcessLoadLabel.Size = new System.Drawing.Size(35, 13);
            this.ProcessLoadLabel.TabIndex = 1;
            this.ProcessLoadLabel.Text = "label1";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.ChartForSysRes);
            this.groupBox6.Location = new System.Drawing.Point(15, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(855, 695);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chart";
            // 
            // ChartForSysRes
            // 
            this.ChartForSysRes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.ChartForSysRes.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartForSysRes.Legends.Add(legend2);
            this.ChartForSysRes.Location = new System.Drawing.Point(6, 19);
            this.ChartForSysRes.Name = "ChartForSysRes";
            this.ChartForSysRes.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "CPU";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Phisycal disc";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Memory";
            this.ChartForSysRes.Series.Add(series4);
            this.ChartForSysRes.Series.Add(series5);
            this.ChartForSysRes.Series.Add(series6);
            this.ChartForSysRes.Size = new System.Drawing.Size(843, 670);
            this.ChartForSysRes.TabIndex = 2;
            this.ChartForSysRes.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1344, 734);
            this.tabControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 737);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System monitor";
            ((System.ComponentModel.ISupportInitialize)(this.Processor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Memory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BytesReceived)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SentBytes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CounterLogonServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CounterErrorLogon)).EndInit();
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
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartForSysRes)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Diagnostics.PerformanceCounter Processor;
        private System.Windows.Forms.Timer TimerProcLoad;
        private System.Diagnostics.PerformanceCounter Disk;
        private System.Diagnostics.PerformanceCounter Memory;
        private System.Diagnostics.PerformanceCounter BytesReceived;
        private System.Diagnostics.PerformanceCounter SentBytes;
        private System.Windows.Forms.Splitter splitter1;
        private System.Diagnostics.PerformanceCounter CounterLogonServer;
        private System.Diagnostics.PerformanceCounter CounterErrorLogon;
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
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabelMemoryLoad;
        private System.Windows.Forms.ProgressBar MemoryLoadBar;
        private System.Windows.Forms.Label LabelPhysicalDisk;
        private System.Windows.Forms.ProgressBar PhisycalDiskBar;
        private System.Windows.Forms.ProgressBar ProcessLoadBar;
        private System.Windows.Forms.Label ProcessLoadLabel;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartForSysRes;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label LabelErrorLogon;
    }
}


using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SystemMonitor
{
    public partial class MainForm : Form
    {
        public static string timeWritten;
        public static string audit;
        string numberAuditValue;        
        double recSegmentsValue;
        double sentSegmentsValue;
        double procesLoadValue;
        double physicalDiscValue;
        double memoryValue;
        bool btnMainStartBool = false;
        int waitForCounterProc;
        int itemsCount = 0;
        int btnWrkBool = 1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StatConLbl.Text =  SqlLiteDataBase.SqlCreateSysRes();
            StatConLbl.Text = SqlLiteDataBase.SqlCreateSecurity();
        }

        private void MainStartBtn_Click(object sender, EventArgs e)
        {
            if (!btnMainStartBool)
            {
                MainStartBtn.Text = "Stop monitoring";
                BtnStopWrk.Enabled = true;
                btnMainStartBool = true;
                MainTimerProgram.Enabled = true;
                TimerWrkProgram.Enabled = true;
                MainTimerProgram.Start();
                TimerWrkProgram.Start();
            }
            else
            {
                MainStartBtn.Text = "Start monitoring";
                BtnStopWrk.Enabled = false;
                btnMainStartBool = false;
                MainTimerProgram.Stop();
                TimerWrkProgram.Stop();
                MainTimerProgram.Enabled = false;
                TimerWrkProgram.Enabled = false;
            }
        }

        private void TimerProcLoad_Tick(object sender, EventArgs e)
        {
            SystemResourses();
            ShowActiveTcpConnections();
            SecurityLog();

            // todo: Реализовать очистку графика через определенное время 
            if (btnWrkBool == 1)
            {
                InitializeParameters((int)Math.Round(procesLoadValue), (int)Math.Round(physicalDiscValue), (int)Math.Round(memoryValue),
                    itemsCount, (int)Math.Round(recSegmentsValue), (int)Math.Round(sentSegmentsValue));
            }
            else
            {
                InitializeParameters((int)Math.Round(procesLoadValue), (int)Math.Round(physicalDiscValue), (int)Math.Round(memoryValue),
                    itemsCount, (int)Math.Round(recSegmentsValue), (int)Math.Round(sentSegmentsValue), true);
            }

            SqlLiteDataBase.SqlAddSysRes(listBox2.Items.Count, (int)Math.Round(procesLoadValue), (int)Math.Round(physicalDiscValue), (int)Math.Round(memoryValue));

            //if (Chart.i % 100 == 0 && Chart.i != 0)
            //{
            //    ChartForSysRes.Series[0].Points.Clear();
            //    ChartForSysRes.Series[1].Points.Clear();
            //    ChartForSysRes.Series[2].Points.Clear();
            //    ChartForTCPCon.Series[0].Points.Clear();
            //    ChartForTCPCon.Series[1].Points.Clear();6
            //    ChartForTCPCon.Series[2].Points.Clear();
            //    Chart.i++;
            //}
            //else
            //{
                
            //}

        }

        public void SystemResourses()
        {
            procesLoadValue = Processor.NextValue();
            physicalDiscValue = 100-Disk.NextValue();
            memoryValue = Memory.NextValue();

            ProcessLoadLabel.Text = "Processor load " + (int)Math.Round(procesLoadValue) + " %";
            LabelPhysicalDisk.Text = "Phisycal disk load " + (int)Math.Round(physicalDiscValue) + " %";
            LabelMemoryLoad.Text = "Memory load " + (int)Math.Round(memoryValue) + " %";

            ProcesLoadTB.Text = Convert.ToString(procesLoadValue);
            PhysicalDiscTB.Text = Convert.ToString(physicalDiscValue);
            MemoryTB.Text = Convert.ToString(memoryValue);

            if (waitForCounterProc == 0 || waitForCounterProc == 20)
            {
                listBox2.Items.Clear();
                foreach (var item in Process.GetProcesses())
                    listBox2.Items.Add($"Id: {item.Id}\t\tName: {item.ProcessName}");
                CountProcesses.Text = $"Number of processes";
                NumberOfProcTB.Text = $"{listBox2.Items.Count}";
                if (waitForCounterProc == 20)
                    waitForCounterProc = 1;
            }
            waitForCounterProc++;
        }

        public void SecurityLog()
        {
            var evLog = new EventLog();
            evLog.Log = "Security";
            NumberOfAuditTB.Text = Convert.ToString(evLog.Entries.Count);

            if (Chart.i == 0)
            {
                for (int i = evLog.Entries.Count-1; i > evLog.Entries.Count-10; i--)
                {
                    listBox4.Items.Add($"{evLog.Entries[i].TimeWritten}\t{evLog.Entries[i].Source}\t{evLog.Entries[i].Category}\t{evLog.Entries[i].Index}\t{evLog.Entries[i].EntryType}");
                    if (i - (evLog.Entries.Count - 10) == 1)
                    {
                        timeWritten = evLog.Entries[i].TimeWritten.ToString("dd.MM.yyyy HH:mm:ss");
                        audit = evLog.Entries[i].EntryType.ToString();
                    }
                }
                listBox6.Items.Add(SqlLiteDataBase.SqlAddSecurity(timeWritten, audit));
                listBox4.Items.Add("\n\t" + DateTime.Now + "\n");
                listBox3.Items.Add(DateTime.Now + "\t" + NumberOfAuditTB.Text);
            }
            else
            {
                if (numberAuditValue != NumberOfAuditTB.Text)
                {
                    for (int i = evLog.Entries.Count - 1; i > evLog.Entries.Count - Math.Abs(evLog.Entries.Count - Convert.ToInt32(numberAuditValue)); i--)
                    {
                        listBox4.Items.Add($"{evLog.Entries[i].TimeWritten}\t{evLog.Entries[i].Source}\t{evLog.Entries[i].Message}\t{evLog.Entries[i].Index}\t{evLog.Entries[i].EntryType}");
                        if ((i - evLog.Entries.Count - Math.Abs(evLog.Entries.Count - Convert.ToInt32(numberAuditValue))) == 1)
                        {
                            timeWritten = evLog.Entries[i].TimeWritten.ToString("dd.MM.yyyy HH:mm:ss");
                            audit = evLog.Entries[i].EntryType.ToString();
                        }
                    }
                    SqlLiteDataBase.SqlAddSecurity(timeWritten, audit);
                    listBox4.Items.Add("\n\t" + DateTime.Now + "\n");
                    listBox3.Items.Add(DateTime.Now + "\t" + NumberOfAuditTB.Text + "\t" + "difference: " + Math.Abs(evLog.Entries.Count - Convert.ToInt32(numberAuditValue)));
                }
            }
            numberAuditValue = Convert.ToString(evLog.Entries.Count);
        }

        public void ShowActiveTcpConnections()
        {
            recSegmentsValue = BytesReceived.NextValue();
            sentSegmentsValue = SentBytes.NextValue();
            ReceivedBytesLabel.Text = "Received bytes: " + recSegmentsValue + " bytes/sec";
            BytesSentLabel.Text = "Sent bytes: " + sentSegmentsValue + " bytes/sec";

            itemsCount = 0;
            listBox1.Items.Clear();
            TcpConnectionInformation[] connections = IPGlobalProperties.GetIPGlobalProperties().GetActiveTcpConnections();
            foreach (var c in connections)
                listBox1.Items.Add($"{itemsCount++}. >> \t" + $" Local connection\t{c.LocalEndPoint} <==> {c.RemoteEndPoint}\t remoute connection");
            LabelItemsCount.Text = "Connections count: " + itemsCount;
        }

        public void InitializeParameters(int valueCPUX, int valueDiscX, int valueMemX, int valueConX, int valueConRecX, int valueConSentX, bool count = false)
        {
            if (!count)
            {
                Chart.FillChart(valueCPUX, valueDiscX, valueMemX, valueConX, valueConRecX, valueConSentX);

                ChartForSysRes.ChartAreas[ChartForSysRes.Series["CPU"].ChartArea].AxisX.ScaleView.Zoom(10, 100);
                ChartForTCPCon.ChartAreas[ChartForTCPCon.Series["Tcp connections count"].ChartArea].AxisX.ScaleView.Zoom(10, 100);

                ChartForSysRes.ChartAreas[ChartForSysRes.Series["CPU"].ChartArea].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
                ChartForTCPCon.ChartAreas[ChartForTCPCon.Series["Tcp connections count"].ChartArea].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;

                ChartForSysRes.ChartAreas[ChartForSysRes.Series["CPU"].ChartArea].AxisX.ScaleView.SmallScrollSize = 0;
                ChartForTCPCon.ChartAreas[ChartForTCPCon.Series["Tcp connections count"].ChartArea].AxisX.ScaleView.SmallScrollSize = 0;

                //for (int k = 0; k < Chart.procX.Count; k++)
                //{
                //    ChartForSysRes.Series["CPU"].Points.AddXY(Chart.procX[k], Chart.procY[k]);
                //    ChartForSysRes.Series["Phisycal disc"].Points.AddXY(Chart.discX[k], Chart.diskY[k]);
                //    ChartForSysRes.Series["Memory"].Points.AddXY(Chart.memX[k], Chart.memY[k]);
                //}

                //for (int k = 0; k < Chart.conX.Count; k++)
                //{
                //    ChartForTCPCon.Series["Tcp connections count"].Points.AddXY(Chart.conX[k], Chart.conY[k]);
                //    ChartForTCPCon.Series["Received bytes"].Points.AddXY(Chart.conRecX[k], Chart.conRexY[k]);
                //    ChartForTCPCon.Series["Sent bytes"].Points.AddXY(Chart.conSentX[k], Chart.conSentY[k]);
                //}

                for (int k = 0; k < Chart.procX.Count; k++)
                {
                    ChartForSysRes.Series["CPU"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), Chart.procY[k]);
                    ChartForSysRes.Series["Phisycal disc"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), Chart.diskY[k]);
                    ChartForSysRes.Series["Memory"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), Chart.memY[k]);
                }

                for (int k = 0; k < Chart.conX.Count; k++)
                {
                    ChartForTCPCon.Series["Tcp connections count"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), Chart.conY[k]);
                    ChartForTCPCon.Series["Received bytes"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), Chart.conRexY[k]);
                    ChartForTCPCon.Series["Sent bytes"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), Chart.conSentY[k]);
                }
            }
            else
                Chart.FillChart(valueCPUX, valueDiscX, valueMemX,
                    valueConX, valueConRecX, valueConSentX, true);
        }

        private void TimerWrkProgram_Tick(object sender, EventArgs e)
        {
            LabelWrkTime.Text = WorkingTimer.TimeIntoLabel();            
            LabelValueIteration.Text = $"{Chart.i}";
        }

        private void BtnStopWrk_Click(object sender, EventArgs e)
        {
            if (btnWrkBool == 1)
            {
                BtnStopWrk.Text = "Start visualization";
                btnWrkBool = 0;
            }
            else
            {
                BtnStopWrk.Text = "Stop rendering";
                btnWrkBool = 1;
            }
        }

        private void ConnectToSqlData_Click(object sender, EventArgs e) => StatConLbl.Text = SqlLiteDataBase.SqlConnect();

        //SysRes history
        private void CreateTableSysRes_Click(object sender, EventArgs e) => StatConLbl.Text = SqlLiteDataBase.SqlCreateSysRes();
        private void AddToTableSysRes_Click(object sender, EventArgs e)
        {
            if (SqlLiteDataBase.SqlReadAllSysRes() != null)
            {
                dataGridSysRes.Rows.Clear();

                for (int i = 0; i < SqlLiteDataBase.SqlReadAllSysRes().Rows.Count; i++)
                  dataGridSysRes.Rows.Add(SqlLiteDataBase.SqlReadAllSysRes().Rows[i].ItemArray);
            }
            else
                listBox5.Items.Add("The data was not uploaded");
        }
        private void DeleteTableSysRes_Click(object sender, EventArgs e) => StatConLbl.Text = SqlLiteDataBase.SqlDeleteSysRes();
        private void ClearTableDataSysRes_Click(object sender, EventArgs e) => dataGridSysRes.Rows.Clear();

        //Security history
        private void CreateTableSecurity_Click(object sender, EventArgs e) => StatConLbl.Text = SqlLiteDataBase.SqlCreateSecurity();
        private void AddToTableSecurity_Click(object sender, EventArgs e)
        {
            if (SqlLiteDataBase.SqlReadAllSecurity() != null)
            {
                dataGridViewSecurity.Rows.Clear();

                for (int i = 0; i < SqlLiteDataBase.SqlReadAllSecurity().Rows.Count; i++)
                    dataGridViewSecurity.Rows.Add(SqlLiteDataBase.SqlReadAllSecurity().Rows[i].ItemArray);
            }
            else
                listBox6.Items.Add("The data was not uploaded");
        }
        private void DeleteToTableSecurity_Click(object sender, EventArgs e) => StatConLbl.Text = SqlLiteDataBase.SqlDeleteSecurity();
        private void ClearTableSecurity_Click(object sender, EventArgs e) => dataGridViewSecurity.Rows.Clear();
    }
}

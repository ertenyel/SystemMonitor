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
        public string numberAuditValue;
        public double recSegmentsValue;
        public double sentSegmentsValue;
        public double procesLoadValue;
        public double physicalDiscValue;
        public double memoryValue;
        public static bool btnMainStartBool = false;
        public static int waitForCounterProc;
        public static int itemsCount = 0;
        public bool btnWrkBool = true;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StatConLbl.Text =  SqlLiteDataBase.SqlCreateSysRes();
            StatConLbl.Text = SqlLiteDataBase.SqlCreateSecurity();
            StatConLbl.Text = SqlLiteDataBase.SqlCreateNetwork();
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
            var chart = new Chart();
            SystemResourses();
            ShowActiveTcpConnections();
            SecurityLog();
            ConditionOfInitiComp();
            SqlLiteDataBase.SqlAddSysRes(listBox2.Items.Count, (int)Math.Round(procesLoadValue), (int)Math.Round(physicalDiscValue), (int)Math.Round(memoryValue));
            SqlLiteDataBase.SqlAddNetwork(itemsCount, (int)Math.Round(recSegmentsValue), (int)Math.Round(sentSegmentsValue));
            clearChartsMethod(true);
        }
        //System resourses
        private void SystemResourses()
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

            if (CaptureBtnSysRes.Checked == true)
            {
                CountProcesses.Text = $"Number of processes";
                NumberOfProcTB.Text = $"{listBox2.Items.Count}";
                return;
            }
            else
            {
                if (waitForCounterProc == 0 || waitForCounterProc == 20)
                {
                    listBox2.Items.Clear();
                    foreach (var item in Process.GetProcesses())
                        listBox2.Items.Add($"Id: {item.Id}\t\tName: {item.ProcessName}");
                    CountProcesses.Text = $"Number of processes";
                    NumberOfProcTB.Text = $"{listBox2.Items.Count}";
                    if (waitForCounterProc == 20)
                        waitForCounterProc = 0;
                }
                waitForCounterProc++;
            }
        }

        //Security log
        private void SecurityLog()
        {
            var evLog = new EventLog();
            evLog.Log = "Security";
            NumberOfAuditTB.Text = Convert.ToString(evLog.Entries.Count);

            if (Chart.i == 0)
            {
                for (int i = evLog.Entries.Count-1; i > evLog.Entries.Count-10; i--)
                {
                    listBox4.Items.Add($"{evLog.Entries[i].TimeWritten}\t{evLog.Entries[i].Source}\t{evLog.Entries[i].UserName}\t{evLog.Entries[i].Index}\t{evLog.Entries[i].EntryType}");
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
                        listBox4.Items.Add($"{evLog.Entries[i].TimeWritten}\t{evLog.Entries[i].Source}\t{evLog.Entries[i].UserName}\t{evLog.Entries[i].Index}\t{evLog.Entries[i].EntryType}");
                        if ((i - evLog.Entries.Count - Math.Abs(evLog.Entries.Count - Convert.ToInt32(numberAuditValue))) == 1)
                        {
                            timeWritten = evLog.Entries[i].TimeWritten.ToString("dd.MM.yyyy HH:mm:ss");
                            audit = evLog.Entries[i].EntryType.ToString();
                        }
                    }
                    SqlLiteDataBase.SqlAddSecurity(timeWritten, audit);
                    listBox4.Items.Add("\n\t" + DateTime.Now + "\n");
                    listBox3.Items.Add(DateTime.Now + "\t" + NumberOfAuditTB.Text + "\tdifference: " + Math.Abs(evLog.Entries.Count - Convert.ToInt32(numberAuditValue)));
                }
            }
            numberAuditValue = Convert.ToString(evLog.Entries.Count);
        }
        // TCP connections
        private void ShowActiveTcpConnections()
        {
            recSegmentsValue = BytesReceived.NextValue();
            sentSegmentsValue = SentBytes.NextValue();
            ReceivedBytesLabel.Text = "Received bytes: " + recSegmentsValue + " bytes/sec";
            BytesSentLabel.Text = "Sent bytes: " + sentSegmentsValue + " bytes/sec";

            if (CaptureBtnNetwork.Checked == true)
            {
                LabelItemsCount.Text = "Connections count: " + itemsCount;
                return;
            }
            else
            {
                itemsCount = 0;
                listBox1.Items.Clear();
                TcpConnectionInformation[] connections = IPGlobalProperties.GetIPGlobalProperties().GetActiveTcpConnections();
                foreach (var c in connections)
                    listBox1.Items.Add($"{itemsCount++}. >> \t" + $" Local connection\t{c.LocalEndPoint} <==> {c.RemoteEndPoint}\t remoute connection");
            }
        }

        public void InitializeParameters(int valueCPUX, int valueDiscX, int valueMemX, int valueConX, int valueConRecX, int valueConSentX, bool count = false)
        {
            if (!count)
            {
                Chart.FillChart(valueCPUX, valueDiscX, valueMemX, valueConX, valueConRecX, valueConSentX);

                ChartForSysRes.ChartAreas[ChartForSysRes.Series["CPU"].ChartArea].AxisX.ScaleView.Zoom(10, 100);
                ChartForSysRes.ChartAreas[ChartForSysRes.Series["CPU"].ChartArea].AxisX.ScaleView.Zoom(10, 100);
                ChartForTCPCon.ChartAreas[ChartForTCPCon.Series["Tcp connections count"].ChartArea].AxisX.ScaleView.Zoom(10, 100);

                ChartForSysRes.ChartAreas[ChartForSysRes.Series["CPU"].ChartArea].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
                ChartForTCPCon.ChartAreas[ChartForTCPCon.Series["Tcp connections count"].ChartArea].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;

                ChartForSysRes.ChartAreas[ChartForSysRes.Series["CPU"].ChartArea].AxisX.ScaleView.SmallScrollSize = 0;
                ChartForTCPCon.ChartAreas[ChartForTCPCon.Series["Tcp connections count"].ChartArea].AxisX.ScaleView.SmallScrollSize = 0;

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
            if (btnWrkBool)
            {
                BtnStopWrk.Text = "Start visualization";
                btnWrkBool = false;
            }
            else
            {
                BtnStopWrk.Text = "Stop rendering";
                btnWrkBool = true;
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
        private void GoBtnSysRes_Click(object sender, EventArgs e)
        {
            if (SqlLiteDataBase.LetsQuery(richTextBoxSysRes.Text) != null)
            {
                dataGridSysRes.Rows.Clear();

                for (int i = 0; i < SqlLiteDataBase.LetsQuery(richTextBoxSysRes.Text).Rows.Count; i++)
                    dataGridSysRes.Rows.Add(SqlLiteDataBase.LetsQuery(richTextBoxSysRes.Text).Rows[i].ItemArray);
            }
            else
                listBox5.Items.Add("The data was not uploaded");
        }
        private void ClearSysRes_Click(object sender, EventArgs e) => richTextBoxSysRes.Clear();

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
        private void GoBtnSecurity_Click(object sender, EventArgs e)
        {
            if (SqlLiteDataBase.LetsQuery(richTextBoxSecurity.Text) != null)
            {
                dataGridViewSecurity.Rows.Clear();

                for (int i = 0; i < SqlLiteDataBase.LetsQuery(richTextBoxSecurity.Text).Rows.Count; i++)
                    dataGridViewSecurity.Rows.Add(SqlLiteDataBase.LetsQuery(richTextBoxSecurity.Text).Rows[i].ItemArray);
            }
            else
                listBox6.Items.Add("The data was not uploaded");
        }
        private void ClearSecurity_Click(object sender, EventArgs e) => richTextBoxSecurity.Clear();

        //Network history
        private void CreateTableNetwork_Click(object sender, EventArgs e) => StatConLbl.Text = SqlLiteDataBase.SqlCreateNetwork();
        private void AddToTableNetwork_Click(object sender, EventArgs e)
        {
            if (SqlLiteDataBase.SqlReadAllNetwork() != null)
            {
                dataGridNetwork.Rows.Clear();

                for (int i = 0; i < SqlLiteDataBase.SqlReadAllNetwork().Rows.Count; i++)
                    dataGridNetwork.Rows.Add(SqlLiteDataBase.SqlReadAllNetwork().Rows[i].ItemArray);
            }
            else
                listBox7.Items.Add("The data was not uploaded");
        }
        private void DeleteTableNetwork_Click(object sender, EventArgs e) => StatConLbl.Text = SqlLiteDataBase.SqlDeleteNetwork();
        private void ClearTableNetwork_Click(object sender, EventArgs e) => dataGridNetwork.Rows.Clear();
        private void GoBtnNetwork_Click(object sender, EventArgs e)
        {
            if (SqlLiteDataBase.LetsQuery(richTextBoxNetwork.Text) != null)
            {
                dataGridNetwork.Rows.Clear();

                for (int i = 0; i < SqlLiteDataBase.LetsQuery(richTextBoxNetwork.Text).Rows.Count; i++)
                    dataGridNetwork.Rows.Add(SqlLiteDataBase.LetsQuery(richTextBoxNetwork.Text).Rows[i].ItemArray);
            }
            else
                listBox7.Items.Add("The data was not uploaded");
        }
        private void ClearNetwork_Click(object sender, EventArgs e) => richTextBoxNetwork.Clear();

        //button clear charts
        private void ClearCharts_Click(object sender, EventArgs e) => clearChartsMethod(false);

        //methods clear charts
        private void clearChartsMethod(bool ifCondition = true)
        {
            if (ifCondition)
            {
                if (Chart.i % 1000 == 0 && Chart.i != 0)
                {
                    ChartForSysRes.Series[0].Points.Clear();
                    ChartForSysRes.Series[1].Points.Clear();
                    ChartForSysRes.Series[2].Points.Clear();
                    ChartForTCPCon.Series[0].Points.Clear();
                    ChartForTCPCon.Series[1].Points.Clear();
                    ChartForTCPCon.Series[2].Points.Clear();
                }
            }
            else
            {
                ChartForSysRes.Series[0].Points.Clear();
                ChartForSysRes.Series[1].Points.Clear();
                ChartForSysRes.Series[2].Points.Clear();
                ChartForTCPCon.Series[0].Points.Clear();
                ChartForTCPCon.Series[1].Points.Clear();
                ChartForTCPCon.Series[2].Points.Clear();
            }
        }

        //methods initialize component
        private void ConditionOfInitiComp()
        {
            if (btnWrkBool)
            {
                InitializeParameters((int)Math.Round(procesLoadValue), (int)Math.Round(physicalDiscValue), (int)Math.Round(memoryValue),
                    itemsCount, (int)Math.Round(recSegmentsValue), (int)Math.Round(sentSegmentsValue));
            }
            else
            {
                InitializeParameters((int)Math.Round(procesLoadValue), (int)Math.Round(physicalDiscValue), (int)Math.Round(memoryValue),
                    itemsCount, (int)Math.Round(recSegmentsValue), (int)Math.Round(sentSegmentsValue), true);
            }
        }

        private void OpenAnalysisBtn_Click(object sender, EventArgs e)
        {
            var dataAnalysisForm = new DataAnalysisForm();
            dataAnalysisForm.Show();
        }
    }
}
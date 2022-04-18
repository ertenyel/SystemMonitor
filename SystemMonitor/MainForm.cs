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
        private static int countProcess;

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
            SystemResourses();
            ShowActiveTcpConnections();            
            ConditionOfInitiComp();
            SqlLiteDataBase.SqlAddSysRes(countProcess, (int)Math.Round(procesLoadValue), (int)Math.Round(physicalDiscValue), (int)Math.Round(memoryValue));
            SqlLiteDataBase.SqlAddNetwork(itemsCount, (int)Math.Round(recSegmentsValue), (int)Math.Round(sentSegmentsValue));
            clearChartsMethod(true);
        }
        //System resources
        private void SystemResourses()
        {
            countProcess = Process.GetProcesses().Length;
            procesLoadValue = Processor.NextValue();            
            physicalDiscValue = 100 - Math.Round(Disk.NextValue());
            memoryValue = Memory.NextValue();

            if (physicalDiscValue < 0) physicalDiscValue = 0;
            CountProcesses.Text = $"Number of processes";
            NumberOfProcTB.Text = $"{countProcess}";
            ProcessLoadLabel.Text = "Processor load " + (int)Math.Round(procesLoadValue) + " %";
            LabelPhysicalDisk.Text = "Phisycal disk load " + (int)Math.Round(physicalDiscValue) + " %";
            LabelMemoryLoad.Text = "Memory load " + (int)Math.Round(memoryValue) + " %";

            ProcesLoadTB.Text = Convert.ToString(procesLoadValue);
            PhysicalDiscTB.Text = Convert.ToString(physicalDiscValue);
            MemoryTB.Text = Convert.ToString(memoryValue);

            if (CaptureBtnSysRes.Checked == true)
                return;
            else
            {
                foreach (var item in Process.GetProcesses())
                {
                    string processName = $"Id: {item.Id}\t\tName: {item.ProcessName}";
                    if (listBox2.Items.Count-1 > countProcess)
                        listBox2.Items.Clear();
                    if (!listBox2.Items.Contains(processName))
                        listBox2.Items.Add(processName);
                }
            }
            textBox1.Text = listBox2.Items.Count.ToString();
        }

        // TCP connections
        private void ShowActiveTcpConnections()
        {
            TcpConnectionInformation[] connections = IPGlobalProperties.GetIPGlobalProperties().GetActiveTcpConnections();
            string[] newTcpConnections = new string[connections.Length];
            itemsCount = connections.Length;
            for (int i = 0; i < connections.Length; i++)
                foreach (var item in connections)
                    newTcpConnections[i] = $"{item.LocalEndPoint} <==> {item.RemoteEndPoint} \t {item.State}";

            recSegmentsValue = BytesReceived.NextValue();
            sentSegmentsValue = SentBytes.NextValue();

            LabelItemsCount.Text = "Connections count: " + itemsCount;
            ReceivedBytesLabel.Text = "Received bytes: " + recSegmentsValue + " bytes/sec";
            BytesSentLabel.Text = "Sent bytes: " + sentSegmentsValue + " bytes/sec";

            if (CaptureBtnNetwork.Checked == true)
                return;
            else
            {                
                foreach (var item in newTcpConnections)
                    if (!listBox1.Items.Contains(item))
                        listBox1.Items.Add(item);
            }
        }

        public void InitializeParameters(int valueCPUY, int valueDiscY, int valueMemY, int valueConY, int valueConRecY, int valueConSentY, bool count = false)
        {
            if (!count)
            {
                ChartForSysRes.ChartAreas[ChartForSysRes.Series["CPU"].ChartArea].AxisX.ScaleView.Zoom(10, 100);
                ChartForSysRes.ChartAreas[ChartForSysRes.Series["CPU"].ChartArea].AxisX.ScaleView.Zoom(10, 100);
                ChartForTCPCon.ChartAreas[ChartForTCPCon.Series["Tcp connections count"].ChartArea].AxisX.ScaleView.Zoom(10, 100);

                ChartForSysRes.ChartAreas[ChartForSysRes.Series["CPU"].ChartArea].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
                ChartForTCPCon.ChartAreas[ChartForTCPCon.Series["Tcp connections count"].ChartArea].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;

                ChartForSysRes.ChartAreas[ChartForSysRes.Series["CPU"].ChartArea].AxisX.ScaleView.SmallScrollSize = 0;
                ChartForTCPCon.ChartAreas[ChartForTCPCon.Series["Tcp connections count"].ChartArea].AxisX.ScaleView.SmallScrollSize = 0;

                ChartForSysRes.Series["CPU"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), valueCPUY);
                ChartForSysRes.Series["Phisycal disc"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), valueDiscY);
                ChartForSysRes.Series["Memory"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), valueMemY);

                ChartForTCPCon.Series["Tcp connections count"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), valueConY);
                ChartForTCPCon.Series["Received bytes"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), valueConRecY);
                ChartForTCPCon.Series["Sent bytes"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), valueConSentY);

                Charts.i++;
            }
            else
                Charts.i++;
        }

        private void TimerWrkProgram_Tick(object sender, EventArgs e)
        {
            LabelWrkTime.Text = WorkingTimer.TimeIntoLabel();            
            LabelValueIteration.Text = $"{Charts.i}";
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
                if (Charts.i % 1000 == 0 && Charts.i != 0)
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
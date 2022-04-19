using System;
using System.Data;
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
        private void CreateTableSysRes_Click(object sender, EventArgs e)
        {
            StatConLbl.Text = SqlLiteDataBase.SqlCreateSysRes();
            StatConLbl.Text = SqlLiteDataBase.SqlCreateNetwork();
        }

        private void DeleteTableSysRes_Click(object sender, EventArgs e)
        {
            StatConLbl.Text = SqlLiteDataBase.SqlDeleteSysRes();
            StatConLbl.Text = SqlLiteDataBase.SqlDeleteNetwork();
        }
        private void ClearTableDataSysRes_Click(object sender, EventArgs e) => MainDataGrid.Rows.Clear();
        private void GoBtnSysRes_Click(object sender, EventArgs e)
        {
            if (SqlLiteDataBase.LetsQuery(richTextBoxSysRes.Text) != null)
            {
                MainDataGrid.Rows.Clear();
                MainDataGrid.Columns.Clear();
                DataTable query = SqlLiteDataBase.LetsQuery(richTextBoxSysRes.Text);
                for (int i = 0; i < query.Columns.Count; i++)
                    MainDataGrid.Columns.Add(query.Columns[i].ColumnName, query.Columns[i].ColumnName);
                for (int i = 0; i < query.Rows.Count; i++)
                    MainDataGrid.Rows.Add(query.Rows[i].ItemArray);
            }
            else
                MessageBox.Show("The data was not uploaded");
        }                 
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

        private void ForecastAnalysisTimer_Tick(object sender, EventArgs e)
        {
            //Изменить параметры прогнозированных графиков
            ForecastAnalysisTimer.Stop();
            if (Charts.i > 800)
            {
                SearchingMaxSel.InitializeValues(DateTime.Now, "systemresources");
                ForecastAnalize.InitializeValuesTests(Values.dateTimeResultMaxSel[0], Values.dateTimeResultMaxSel[Values.dateTimeResultMaxSel.Length - 1],
                    Values.dateTimeNewStory[0], Values.dateTimeNewStory[Values.dateTimeNewStory.Length - 1], "systemresources");
                ForecastAnalize.ComputeParamteres(Values.testMaxSel, Values.testNewStory, Values.resultMaxSel, Values.newStory);
                ChartForSysRes.Series.Add("% load processor forecast");
                ChartForSysRes.Series["% load processor forecast"].BorderWidth = 3;
                ChartForSysRes.Series["% load processor forecast"].BorderDashStyle = ChartDashStyle.Dash;
                ChartForSysRes.Series.Add("% Physical disc forecast");
                ChartForSysRes.Series["% Physical disc forecast"].BorderWidth = 3;
                ChartForSysRes.Series["% Physical disc forecast"].BorderDashStyle = ChartDashStyle.Dash;
                ChartForSysRes.Series.Add("% memory forecast");
                ChartForSysRes.Series["% memory forecast"].BorderWidth = 3;
                ChartForSysRes.Series["% memory forecast"].BorderDashStyle = ChartDashStyle.Dash;
                for (int i = 0; i < ForecastAnalize.forecast.Length; i++)
                {
                    for (int j = 0; j < ForecastAnalize.forecast[i].Length; j++)
                    {
                        if (j == 0)
                        {
                            ChartForSysRes.Series["% load processor forecast"].Points.AddXY(Values.dateTimeNewStory[Values.dateTimeNewStory.Length - 1].
                                AddMinutes(+i), ForecastAnalize.forecast[i][j]* Convert.ToDouble(countProcess));
                        }
                        else if (j == 1)
                        {
                            ChartForSysRes.Series["% Physical disc forecast"].Points.AddXY(Values.dateTimeNewStory[Values.dateTimeNewStory.Length - 1].
                                AddMinutes(+i), ForecastAnalize.forecast[i][j] * Convert.ToDouble(countProcess));
                        }
                        else if (j == 2)
                        {
                            ChartForSysRes.Series["% memory forecast"].Points.AddXY(Values.dateTimeNewStory[Values.dateTimeNewStory.Length - 1].
                                AddMinutes(+i), ForecastAnalize.forecast[i][j] * Convert.ToDouble(countProcess));
                        }
                    }
                }

                SearchingMaxSel.InitializeValues(DateTime.Now, "network");
                ForecastAnalize.InitializeValuesTests(Values.dateTimeResultMaxSel[0], Values.dateTimeResultMaxSel[Values.dateTimeResultMaxSel.Length - 1],
                    Values.dateTimeNewStory[0], Values.dateTimeNewStory[Values.dateTimeNewStory.Length - 1], "network");
                ForecastAnalize.ComputeParamteres(Values.testMaxSel, Values.testNewStory, Values.resultMaxSel, Values.newStory);
                ChartForTCPCon.Series.Add("Received bytes forecast");
                ChartForTCPCon.Series["Received bytes forecast"].BorderWidth = 3;
                ChartForTCPCon.Series["Received bytes forecast"].BorderDashStyle = ChartDashStyle.Dash;
                ChartForTCPCon.Series.Add("Sent bytes forecast");
                ChartForTCPCon.Series["Sent bytes forecast"].BorderWidth = 3;
                ChartForTCPCon.Series["Sent bytes forecast"].BorderDashStyle = ChartDashStyle.Dash;
                for (int i = 0; i < ForecastAnalize.forecast.Length; i++)
                {
                    for (int j = 0; j < ForecastAnalize.forecast[i].Length; j++)
                    {
                        if (j == 0)
                        {
                            ChartForTCPCon.Series["Received bytes forecast"].Points.AddXY(Values.dateTimeNewStory[Values.dateTimeNewStory.Length - 1].
                                AddMinutes(+i), ForecastAnalize.forecast[i][j] * Convert.ToDouble(countProcess));
                        }
                        else if (j == 1)
                        {
                            ChartForTCPCon.Series["Sent bytes forecast"].Points.AddXY(Values.dateTimeNewStory[Values.dateTimeNewStory.Length - 1].
                                AddMinutes(+i), ForecastAnalize.forecast[i][j] * Convert.ToDouble(countProcess));
                        }
                    }
                }
            }
            ForecastAnalysisTimer.Start();
        }
    }
}
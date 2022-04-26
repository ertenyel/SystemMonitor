using System;
using System.Data;
using System.Diagnostics;
using System.IO;
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
        private static int cnt = 0;

        public MainForm()
        {
            InitializeComponent();
        }
                       //изменит свойство графика и прогноз на сетевом интерфейсе бывает отрицательный
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
            MainTimerProgram.Stop();
            SystemResourses();
            ShowActiveTcpConnections();            
            ConditionOfInitiComp();
            SqlLiteDataBase.SqlAddSysRes(countProcess, (int)Math.Round(procesLoadValue), (int)Math.Round(physicalDiscValue), (int)Math.Round(memoryValue));
            SqlLiteDataBase.SqlAddNetwork(itemsCount, (int)Math.Round(recSegmentsValue), (int)Math.Round(sentSegmentsValue));
            ForecastingAnalysingMethod();
            clearChartsMethod(true);
            MainTimerProgram.Start();
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
                ChartForSysRes.Series["CPU"].Points.AddXY(Charts.i, valueCPUY);
                ChartForSysRes.Series["Phisycal disc"].Points.AddXY(Charts.i, valueDiscY);
                ChartForSysRes.Series["Memory"].Points.AddXY(Charts.i, valueMemY);

                ChartForTCPCon.Series["Tcp connections count"].Points.AddXY(Charts.i, valueConY);
                ChartForTCPCon.Series["Received bytes"].Points.AddXY(Charts.i, valueConRecY);
                ChartForTCPCon.Series["Sent bytes"].Points.AddXY(Charts.i, valueConSentY);

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
                if (Charts.i > 100)
                {
                    for (int i = 0; i < ChartForSysRes.Series.Count; i++)
                    {
                        if (ChartForSysRes.Series[i].Points.Count > 6)
                            ChartForSysRes.Series[i].Points.RemoveAt(0);
                    }
                    for (int i = 0; i < ChartForTCPCon.Series.Count; i++)
                    {
                        if (ChartForTCPCon.Series[i].Points.Count > 6)
                            ChartForTCPCon.Series[i].Points.RemoveAt(0);
                    }
                }             
            }
            else
            {
                for (int i = 0; i < ChartForSysRes.Series.Count; i++)
                {
                    if (ChartForSysRes.Series[i].Points.Count > 6)
                        ChartForSysRes.Series[i].Points.Clear();
                }
                for (int i = 0; i < ChartForTCPCon.Series.Count; i++)
                {
                    if (ChartForTCPCon.Series[i].Points.Count > 6)
                        ChartForTCPCon.Series[i].Points.Clear();
                }
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

        private void ForecastingAnalysingMethod()
        {
            //Изменить параметры прогнозированных графиков            
            if (Charts.i > 800)
            {
                if (cnt == 0 || Charts.i == cnt)
                {
                    cnt = Charts.i + 180;
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    using (StreamWriter streamWriter = new StreamWriter("C:\\test.txt"))
                    {
                        SearchingMaxSel.InitializeValues(DateTime.Now, "systemresources");
                        ForecastAnalize.InitializeValuesTests(Values.dateTimeResultMaxSel[0], Values.dateTimeResultMaxSel[Values.dateTimeResultMaxSel.Length - 1],
                            Values.dateTimeNewStory[0], Values.dateTimeNewStory[Values.dateTimeNewStory.Length - 1], "systemresources");
                        if (ForecastAnalize.ComputeParamteres(Values.testMaxSel, Values.testNewStory, Values.resultMaxSel, Values.newStory))
                        {
                            for (int i = 0; i < ForecastAnalize.forecast.Length; i++)
                            {
                                streamWriter.Write(Values.dateTimeNewStory[Values.dateTimeNewStory.Length - 1].AddMinutes(+i) + "\t");
                                for (int j = 0; j < ForecastAnalize.forecast[i].Length; j++)
                                {
                                    streamWriter.Write(Convert.ToString(ForecastAnalize.forecast[i][j] * Convert.ToDouble(countProcess)) + "\t");
                                    if (i == 0 && j == 0)
                                    {
                                        ChartForSysRes.Series["% load processor forecast"].Points.AddXY(Charts.i, (int)Math.Round(procesLoadValue));// (DateTime.Now.ToString("HH:mm:ss"), (int)Math.Round(procesLoadValue));
                                        ChartForSysRes.Series["% Physical disc forecast"].Points.AddXY(Charts.i, (int)Math.Round(physicalDiscValue));// (DateTime.Now.ToString("HH:mm:ss"), (int)Math.Round(physicalDiscValue));
                                        ChartForSysRes.Series["% memory forecast"].Points.AddXY(Charts.i, (int)Math.Round(memoryValue));//(DateTime.Now.ToString("HH:mm:ss"), (int)Math.Round(memoryValue));
                                    }
                                    if (j == 0)
                                    {
                                        ChartForSysRes.Series["% load processor forecast"].Points.AddXY(Charts.i + (60 * (i + 1)), ForecastAnalize.forecast[i][j] * Convert.ToDouble(countProcess));
                                        //(Values.dateTimeNewStory[Values.dateTimeNewStory.Length - 1].
                                        //AddMinutes(+i).ToString("HH:mm:ss"), ForecastAnalize.forecast[i][j] * Convert.ToDouble(countProcess));
                                    }
                                    else if (j == 1)
                                    {
                                        ChartForSysRes.Series["% Physical disc forecast"].Points.AddXY(Charts.i + (60 * (i + 1)), ForecastAnalize.forecast[i][j] * Convert.ToDouble(countProcess));
                                        //(Values.dateTimeNewStory[Values.dateTimeNewStory.Length - 1].
                                        //AddMinutes(+i).ToString("HH:mm:ss"), ForecastAnalize.forecast[i][j] * Convert.ToDouble(countProcess));
                                    }
                                    else if (j == 2)
                                    {
                                        ChartForSysRes.Series["% memory forecast"].Points.AddXY(Charts.i + (60 * (i + 1)), ForecastAnalize.forecast[i][j] * Convert.ToDouble(countProcess));
                                        //(Values.dateTimeNewStory[Values.dateTimeNewStory.Length - 1].
                                        //AddMinutes(+i).ToString("HH:mm:ss"), ForecastAnalize.forecast[i][j] * Convert.ToDouble(countProcess));
                                    }
                                }
                                streamWriter.WriteLine("");
                            }

                            streamWriter.WriteLine("");
                            streamWriter.WriteLine("");

                            SearchingMaxSel.InitializeValues(DateTime.Now, "network");
                            ForecastAnalize.InitializeValuesTests(Values.dateTimeResultMaxSel[0], Values.dateTimeResultMaxSel[Values.dateTimeResultMaxSel.Length - 1],
                                Values.dateTimeNewStory[0], Values.dateTimeNewStory[Values.dateTimeNewStory.Length - 1], "network");
                            ForecastAnalize.ComputeParamteres(Values.testMaxSel, Values.testNewStory, Values.resultMaxSel, Values.newStory);
                            for (int i = 0; i < ForecastAnalize.forecast.Length; i++)
                            {
                                streamWriter.Write(Values.dateTimeNewStory[Values.dateTimeNewStory.Length - 1].AddMinutes(+i) + "\t");
                                for (int j = 0; j < ForecastAnalize.forecast[i].Length; j++)
                                {
                                    streamWriter.Write(Convert.ToString(ForecastAnalize.forecast[i][j] * Convert.ToDouble(itemsCount)) + "\t");
                                    if (i == 0 && j == 0)              //поменять занчения и проверитьб
                                    {
                                        ChartForTCPCon.Series["Received bytes forecast"].Points.AddXY(Charts.i, (int)Math.Round(recSegmentsValue));//(DateTime.Now.ToString("HH:mm:ss"), (int)Math.Round(recSegmentsValue));
                                        ChartForTCPCon.Series["Sent bytes forecast"].Points.AddXY(Charts.i, (int)Math.Round(sentSegmentsValue));//(DateTime.Now.ToString("HH:mm:ss"), (int)Math.Round(sentSegmentsValue));
                                    }
                                    if (j == 0)
                                    {
                                        ChartForTCPCon.Series["Received bytes forecast"].Points.AddXY(Charts.i + (60 * (i + 1)), ForecastAnalize.forecast[i][j] * Convert.ToDouble(itemsCount));
                                        //(Values.dateTimeNewStory[Values.dateTimeNewStory.Length - 1].
                                        //AddMinutes(+i).ToString("HH:mm:ss"), ForecastAnalize.forecast[i][j] * Convert.ToDouble(itemsCount));
                                    }
                                    else if (j == 1)
                                    {
                                        ChartForTCPCon.Series["Sent bytes forecast"].Points.AddXY(Charts.i + (60 * (i + 1)), ForecastAnalize.forecast[i][j] * Convert.ToDouble(itemsCount));
                                        //(Values.dateTimeNewStory[Values.dateTimeNewStory.Length - 1].
                                        //AddMinutes(+i).ToString("HH:mm:ss"), ForecastAnalize.forecast[i][j] * Convert.ToDouble(itemsCount));
                                    }
                                }
                                streamWriter.WriteLine("");
                            }
                        }
                    }
                    stopwatch.Stop();
                    ForecastingTime.Text = "Forecasting time: " + stopwatch.ElapsedMilliseconds.ToString() + " ms";
                }
            }
            CounterLB.Text = "DataAnalysing counter: " + cnt;                    
        }
    }
}
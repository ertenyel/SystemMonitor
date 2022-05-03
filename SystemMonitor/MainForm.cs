using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
        public int recSegmentsValue;
        public int sentSegmentsValue;
        public int procesLoadValue;
        public int physicalDiscValue;
        public int memoryValue;
        public static bool btnMainStartBool = false;
        public static int waitForCounterProc;
        public static int itemsCount = 0;
        public bool btnWrkBool = true;
        private static int countProcess;
        private static int programIteration = 0;
        private static int cnt = 0;

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
            MainTimerProgram.Stop();
            LabelValueIteration.Text = $"{programIteration}";
            SystemResourses();
            ShowActiveTcpConnections();
            if (btnWrkBool) InitializeParameters(ref procesLoadValue, ref physicalDiscValue, ref memoryValue, ref recSegmentsValue, ref sentSegmentsValue);
            else InitializeParameters(ref procesLoadValue, ref physicalDiscValue, ref memoryValue, ref recSegmentsValue, ref sentSegmentsValue, true);
            SqlLiteDataBase.SqlAddSysRes(countProcess, procesLoadValue, physicalDiscValue, memoryValue);
            SqlLiteDataBase.SqlAddNetwork(itemsCount, recSegmentsValue, sentSegmentsValue);
            ForecastingAnalysingMethod();            
            MainTimerProgram.Start();
        }
        //System resources
        private void SystemResourses()
        {
            countProcess = Process.GetProcesses().Length;
            procesLoadValue = (int)Math.Round(Processor.NextValue());            
            physicalDiscValue = (int)(100 - Math.Round(Disk.NextValue()));
            memoryValue = (int)Math.Round(Memory.NextValue());
            if (physicalDiscValue < 0) physicalDiscValue = 0;
            CountProcesses.Text = $"Number of processes: {countProcess}";            
            ProcessLoadLabel.Text = "Processor load " + procesLoadValue + " %";
            LabelPhysicalDisk.Text = "Phisycal disk load " + physicalDiscValue + " %";
            LabelMemoryLoad.Text = "Memory load " + memoryValue + " %";
        }

        // TCP connections
        private void ShowActiveTcpConnections()
        {
            TcpConnectionInformation[] connections = IPGlobalProperties.GetIPGlobalProperties().GetActiveTcpConnections();
            itemsCount = connections.Length;
            recSegmentsValue = (int)Math.Round(BytesReceived.NextValue());
            sentSegmentsValue = (int)Math.Round(SentBytes.NextValue());

            LabelItemsCount.Text = "Connections count: " + itemsCount;
            ReceivedBytesLabel.Text = "Rec bytes: " +  recSegmentsValue + " bytes/sec";
            BytesSentLabel.Text = "Sent bytes: " + sentSegmentsValue + " bytes/sec";
        }

        public void InitializeParameters(ref int valueCPUY, ref int valueDiscY, ref int valueMemY, ref int valueConRecY, ref int valueConSentY, bool count = false)
        {
            if (!count)
            {
                ChartForSysRes.Series["CPU"].Points.AddXY(programIteration, valueCPUY);
                ChartForSysRes.Series["Phisycal disc"].Points.AddXY(programIteration, valueDiscY);
                ChartForSysRes.Series["Memory"].Points.AddXY(programIteration, valueMemY);
                
                ChartForTCPCon.Series["Received bytes"].Points.AddXY(programIteration, valueConRecY);
                ChartForTCPCon.Series["Sent bytes"].Points.AddXY(programIteration, valueConSentY);   
            }                            

            programIteration++;
        }

        private void TimerWrkProgram_Tick(object sender, EventArgs e)
        {
            LabelWrkTime.Text = WorkingTimer.TimeIntoLabel();
            clearChartsMethod(true);
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
                 if (programIteration > 500)
                 {
                    for (int i = 0; i < ChartForSysRes.Series.Count; i++)
                    {
                        if (ChartForSysRes.Series[i].Points.Count > 10)
                            ChartForSysRes.Series[i].Points.RemoveAt(0);
                    }
                    for (int i = 0; i < ChartForTCPCon.Series.Count; i++)
                    {
                        if (ChartForTCPCon.Series[i].Points.Count > 10)
                            ChartForTCPCon.Series[i].Points.RemoveAt(0);
                    }
                }
            }
            else
            {
                for (int i = 0; i < ChartForSysRes.Series.Count; i++) ChartForSysRes.Series[i].Points.Clear();
                for (int i = 0; i < ChartForTCPCon.Series.Count; i++) ChartForTCPCon.Series[i].Points.Clear();
            }
        }

        //methods initialize component
        private void ConditionOfInitiComp()
        {
            
        }

        private void OpenAnalysisBtn_Click(object sender, EventArgs e)
        {
            var dataAnalysisForm = new DataAnalysisForm();
            dataAnalysisForm.Show();
        }

        private void ForecastingAnalysingMethod()
        {
            //Изменить параметры прогнозированных графиков            
            if (programIteration > 4000)
            {
                if (cnt == 0 || programIteration == cnt)
                {
                    cnt = programIteration + 180;
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();

                    ChartForSysRes.Series["CPU forecast"].Points.Clear();
                    ChartForSysRes.Series["Physical disc forecast"].Points.Clear();
                    ChartForSysRes.Series["Memory forecast"].Points.Clear();
                    ChartForTCPCon.Series["Received bytes forecast"].Points.Clear();
                    ChartForTCPCon.Series["Sent bytes forecast"].Points.Clear();

                    SearchingMaxSel.InitializeValues(DateTime.Now, "systemresources");
                    ForecastAnalize.InitializeValuesTests(Values.dateTimeResultMaxSel[0], Values.dateTimeResultMaxSel[Values.dateTimeResultMaxSel.Length - 1],
                        Values.dateTimeNewStory[0], Values.dateTimeNewStory[Values.dateTimeNewStory.Length - 1], "systemresources");
                    if (ForecastAnalize.ComputeParamteres(ref Values.testMaxSel, ref Values.testNewStory, ref Values.resultMaxSel, ref Values.newStory))
                    {
                        double forecastVal;
                        for (int i = 0; i < ForecastAnalize.forecast.Length; i++)
                        {                            
                            for (int j = 0; j < ForecastAnalize.forecast[i].Length; j++)
                            {
                                if (i == 0 && j == 0)
                                {
                                    ChartForSysRes.Series["CPU forecast"].Points.AddXY(programIteration, procesLoadValue);
                                    ChartForSysRes.Series["Physical disc forecast"].Points.AddXY(programIteration, physicalDiscValue);
                                    ChartForSysRes.Series["Memory forecast"].Points.AddXY(programIteration, memoryValue);
                                }
                                if (j == 0)
                                {
                                    forecastVal = ForecastAnalize.forecast[i][j] * Convert.ToDouble(countProcess);
                                    if (forecastVal > 0) ChartForSysRes.Series["CPU forecast"].Points.AddXY(programIteration + (60 * (i + 1)), forecastVal);
                                    if (forecastVal < 0) ChartForSysRes.Series["CPU forecast"].Points.AddXY(programIteration + (60 * (i + 1)), 0);
                                }
                                else if (j == 1)
                                {
                                    forecastVal = ForecastAnalize.forecast[i][j] * Convert.ToDouble(countProcess);
                                    if (forecastVal > 0) ChartForSysRes.Series["Physical disc forecast"].Points.AddXY(programIteration + (60 * (i + 1)), forecastVal);
                                    if (forecastVal < 0) ChartForSysRes.Series["Physical disc forecast"].Points.AddXY(programIteration + (60 * (i + 1)), 0);
                                }
                                else if (j == 2)
                                {
                                    forecastVal = ForecastAnalize.forecast[i][j] * Convert.ToDouble(countProcess);
                                    if (forecastVal > 0) ChartForSysRes.Series["Memory forecast"].Points.AddXY(programIteration + (60 * (i + 1)), forecastVal);
                                    if (forecastVal < 0) ChartForSysRes.Series["Memory forecast"].Points.AddXY(programIteration + (60 * (i + 1)), 0);
                                }
                            }                            
                        }

                        SearchingMaxSel.InitializeValues(DateTime.Now, "network");
                        ForecastAnalize.InitializeValuesTests(Values.dateTimeResultMaxSel[0], Values.dateTimeResultMaxSel[Values.dateTimeResultMaxSel.Length - 1],
                            Values.dateTimeNewStory[0], Values.dateTimeNewStory[Values.dateTimeNewStory.Length - 1], "network");
                        ForecastAnalize.ComputeParamteres( ref Values.testMaxSel, ref Values.testNewStory, ref Values.resultMaxSel, ref Values.newStory);

                        for (int i = 0; i < ForecastAnalize.forecast.Length; i++)
                        {                            
                            for (int j = 0; j < ForecastAnalize.forecast[i].Length; j++)
                            {
                                if (i == 0 && j == 0)              //поменять занчения и проверитьб
                                {
                                    ChartForTCPCon.Series["Received bytes forecast"].Points.AddXY(programIteration, recSegmentsValue);
                                    ChartForTCPCon.Series["Sent bytes forecast"].Points.AddXY(programIteration, sentSegmentsValue);
                                }
                                if (j == 0)
                                {
                                    forecastVal = ForecastAnalize.forecast[i][j] * Convert.ToDouble(itemsCount);
                                    if (forecastVal > 0) ChartForTCPCon.Series["Received bytes forecast"].Points.AddXY(programIteration + (60 * (i + 1)), forecastVal);
                                    if (forecastVal < 0) ChartForTCPCon.Series["Received bytes forecast"].Points.AddXY(programIteration + (60 * (i + 1)), 0);
                                }
                                else if (j == 1)
                                {
                                    forecastVal = ForecastAnalize.forecast[i][j] * Convert.ToDouble(itemsCount);
                                    if (forecastVal > 0) ChartForTCPCon.Series["Sent bytes forecast"].Points.AddXY(programIteration + (60 * (i + 1)), forecastVal);
                                    if (forecastVal < 0) ChartForTCPCon.Series["Sent bytes forecast"].Points.AddXY(programIteration + (60 * (i + 1)), 0);
                                }
                            }                            
                        }
                    }
                    stopwatch.Stop();
                    ForecastingTime.Text = "Forecasting time: " + stopwatch.ElapsedMilliseconds.ToString() + " ms";
                }
            }
            CounterLB.Text = "DataAnalysing counter: " + cnt;                    
        }

        private void trackBarPosChartSR_Scroll(object sender, EventArgs e)
        {
            ChartForSysRes.ChartAreas[0].AxisX.ScaleView.Size = trackBarPosChartSR.Value;
        }

        private void trackBarPosChartNet_Scroll(object sender, EventArgs e)
        {
            ChartForTCPCon.ChartAreas[0].AxisX.ScaleView.Size = trackBarPosChartNet.Value;
        }

        private void richTextBoxSysRes_TextChanged(object sender, EventArgs e)
        {            
            string query = richTextBoxSysRes.Text;            
            int startPos;
            int wordLength;
            int cursorPos;
            foreach (var item in File.ReadAllLines("sqlkeyWords.txt"))
            {
                if (query.ToLower().Contains(" " + item.ToLower() + " ") || (query.ToLower().Contains(item.ToLower() + " ") && query.ToLower().IndexOf(item.ToLower() + " ") == 0))
                {
                    richTextBoxSysRes.ForeColor = Color.Black;
                    cursorPos = richTextBoxSysRes.SelectionStart;
                    startPos = query.ToLower().IndexOf(item.ToLower());
                    wordLength = item.Length;
                    richTextBoxSysRes.Select(startPos, wordLength);
                    richTextBoxSysRes.SelectionColor = Color.Green;
                    richTextBoxSysRes.SelectionStart = cursorPos;
                    richTextBoxSysRes.DeselectAll();
                    richTextBoxSysRes.SelectionColor = Color.Black;
                }
            }
        }
    }
}
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
                       //удалить не нужные элементы на форме. Решить проблему с очисткой и отрисовкой прогноза на графике
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
            LabelValueIteration.Text = $"{Charts.i}";
            SystemResourses();
            ShowActiveTcpConnections();            
            ConditionOfInitiComp();
            SqlLiteDataBase.SqlAddSysRes(countProcess, (int)Math.Round(procesLoadValue), (int)Math.Round(physicalDiscValue), (int)Math.Round(memoryValue));
            SqlLiteDataBase.SqlAddNetwork(itemsCount, (int)Math.Round(recSegmentsValue), (int)Math.Round(sentSegmentsValue));
            ForecastingAnalysingMethod();            
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
            CountProcesses.Text = $"Number of processes: {countProcess}";            
            ProcessLoadLabel.Text = "Processor load " + (int)Math.Round(procesLoadValue) + " %";
            LabelPhysicalDisk.Text = "Phisycal disk load " + (int)Math.Round(physicalDiscValue) + " %";
            LabelMemoryLoad.Text = "Memory load " + (int)Math.Round(memoryValue) + " %";
        }

        // TCP connections
        private void ShowActiveTcpConnections()
        {
            TcpConnectionInformation[] connections = IPGlobalProperties.GetIPGlobalProperties().GetActiveTcpConnections();            
            itemsCount = connections.Length;

            recSegmentsValue = BytesReceived.NextValue();
            sentSegmentsValue = SentBytes.NextValue();

            LabelItemsCount.Text = "Connections count: " + itemsCount;
            ReceivedBytesLabel.Text = "Rec bytes: " +  Math.Round(recSegmentsValue, 3) + " bytes/sec";
            BytesSentLabel.Text = "Sent bytes: " + Math.Round(sentSegmentsValue, 3) + " bytes/sec";
        }

        public void InitializeParameters(int valueCPUY, int valueDiscY, int valueMemY, int valueConRecY, int valueConSentY, bool count = false)
        {
            if (!count)
            {
                ChartForSysRes.Series["CPU"].Points.AddXY(Charts.i, valueCPUY);
                ChartForSysRes.Series["Phisycal disc"].Points.AddXY(Charts.i, valueDiscY);
                ChartForSysRes.Series["Memory"].Points.AddXY(Charts.i, valueMemY);
                
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
                 if (Charts.i > 500)
                 {
                    for (int i = 0; i < ChartForSysRes.Series.Count; i++)
                    {
                        if (ChartForSysRes.Series[i].Points.Count > 7)
                            ChartForSysRes.Series[i].Points.RemoveAt(0);
                    }
                    for (int i = 0; i < ChartForTCPCon.Series.Count; i++)
                    {
                        if (ChartForTCPCon.Series[i].Points.Count > 7)
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
            if (btnWrkBool)
            {
                InitializeParameters((int)Math.Round(procesLoadValue), (int)Math.Round(physicalDiscValue), (int)Math.Round(memoryValue), 
                    (int)Math.Round(recSegmentsValue), (int)Math.Round(sentSegmentsValue));
            }
            else
            {
                InitializeParameters((int)Math.Round(procesLoadValue), (int)Math.Round(physicalDiscValue), (int)Math.Round(memoryValue), 
                    (int)Math.Round(recSegmentsValue), (int)Math.Round(sentSegmentsValue), true);
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
                            for (int i = 0; i < Values.newStory.Length; i++)
                            {
                                streamWriter.Write(Values.dateTimeNewStory[i] + "\t");
                                for (int j = 0; j < Values.newStory[i].Length; j++)
                                    streamWriter.Write(Values.newStory[i][j] + "\t");
                                streamWriter.WriteLine("");
                            }

                            streamWriter.WriteLine("");
                            streamWriter.WriteLine("");


                            for (int i = 0; i < Values.resultMaxSel.Length; i++)
                            {
                                streamWriter.Write(Values.dateTimeResultMaxSel[i] + "\t");
                                for (int j = 0; j < Values.resultMaxSel[i].Length; j++)
                                    streamWriter.Write(Values.resultMaxSel[i][j] + "\t");
                                streamWriter.WriteLine("");
                            }

                            streamWriter.WriteLine("");
                            streamWriter.WriteLine("");

                            for (int i = 0; i < ForecastAnalize.forecast.Length; i++)
                            {
                                for (int j = 0; j < ForecastAnalize.forecast[i].Length; j++)
                                    streamWriter.Write(ForecastAnalize.forecast[i][j] + "\t");
                                streamWriter.WriteLine("");
                            }

                            streamWriter.WriteLine("");
                            streamWriter.WriteLine("");
                            streamWriter.Write(countProcess);
                            streamWriter.WriteLine("");
                            streamWriter.WriteLine("bt\t" + ForecastAnalize.factorNewBt);
                            streamWriter.Write("ct\t" + ForecastAnalize.factorNewCt);
                            streamWriter.WriteLine("");


                            for (int i = 0; i < ForecastAnalize.forecast.Length; i++)
                            {
                                streamWriter.Write(Values.dateTimeNewStory[Values.dateTimeNewStory.Length - 1].AddMinutes(+i) + "\t");
                                for (int j = 0; j < ForecastAnalize.forecast[i].Length; j++)
                                {
                                    streamWriter.Write(Convert.ToString(ForecastAnalize.forecast[i][j] * Convert.ToDouble(countProcess)) + "\t");
                                    if (i == 0 && j == 0)
                                    {
                                        ChartForSysRes.Series["CPU forecast"].Points.AddXY(Charts.i, (int)Math.Round(procesLoadValue));
                                        ChartForSysRes.Series["Physical disc forecast"].Points.AddXY(Charts.i, (int)Math.Round(physicalDiscValue));
                                        ChartForSysRes.Series["Memory forecast"].Points.AddXY(Charts.i, (int)Math.Round(memoryValue));
                                    }
                                    if (j == 0)
                                    {
                                        ChartForSysRes.Series["CPU forecast"].Points.AddXY(Charts.i + (60 * (i + 1)), ForecastAnalize.forecast[i][j] * Convert.ToDouble(countProcess));                                                                                
                                    }
                                    else if (j == 1)
                                    {
                                        ChartForSysRes.Series["Physical disc forecast"].Points.AddXY(Charts.i + (60 * (i + 1)), ForecastAnalize.forecast[i][j] * Convert.ToDouble(countProcess));
                                    }
                                    else if (j == 2)
                                    {
                                        ChartForSysRes.Series["Memory forecast"].Points.AddXY(Charts.i + (60 * (i + 1)), ForecastAnalize.forecast[i][j] * Convert.ToDouble(countProcess));                                                                                
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
                                        ChartForTCPCon.Series["Received bytes forecast"].Points.AddXY(Charts.i, (int)Math.Round(recSegmentsValue));
                                        ChartForTCPCon.Series["Sent bytes forecast"].Points.AddXY(Charts.i, (int)Math.Round(sentSegmentsValue));
                                    }
                                    if (j == 0)
                                    {
                                        ChartForTCPCon.Series["Received bytes forecast"].Points.AddXY(Charts.i + (60 * (i + 1)), ForecastAnalize.forecast[i][j] * Convert.ToDouble(itemsCount));
                                    }
                                    else if (j == 1)
                                    {
                                        ChartForTCPCon.Series["Sent bytes forecast"].Points.AddXY(Charts.i + (60 * (i + 1)), ForecastAnalize.forecast[i][j] * Convert.ToDouble(itemsCount));
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

        private void trackBarPosChartSR_Scroll(object sender, EventArgs e)
        {
            ChartForSysRes.ChartAreas[0].AxisX.ScaleView.Size = trackBarPosChartSR.Value;
        }

        private void trackBarPosChartNet_Scroll(object sender, EventArgs e)
        {
            ChartForTCPCon.ChartAreas[0].AxisX.ScaleView.Size = trackBarPosChartNet.Value;
        }
    }
}
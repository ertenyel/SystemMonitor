using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;

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
            StatConLbl.Text = SqlLiteDataBase.SqlCreateSysRes();
            StatConLbl.Text = SqlLiteDataBase.SqlCreateSecurity();
            StatConLbl.Text = "Connection status: " + SqlLiteDataBase.SqlCreateNetwork();
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
            LabelValueIteration.Text = $"Iteration: {programIteration}";
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
        }

        // TCP connections
        private void ShowActiveTcpConnections()
        {
            TcpConnectionInformation[] connections = IPGlobalProperties.GetIPGlobalProperties().GetActiveTcpConnections();
            itemsCount = connections.Length;
            recSegmentsValue = (int)Math.Round(BytesReceived.NextValue());
            sentSegmentsValue = (int)Math.Round(SentBytes.NextValue());
        }

        public void InitializeParameters(ref int valueCPUY, ref int valueDiscY, ref int valueMemY, ref int valueConRecY, ref int valueConSentY, bool count = false)
        {
            if (!count)
            {
                ChartCPU.Series["CPU"].Points.AddXY(programIteration, valueCPUY);
                ChartDisc.Series["Phisycal disc"].Points.AddXY(programIteration, valueDiscY);
                ChartMemory.Series["Memory"].Points.AddXY(programIteration, valueMemY);
                ChartForRec.Series["Received bytes"].Points.AddXY(programIteration, valueConRecY);
                ChartForSent.Series["Sent bytes"].Points.AddXY(programIteration, valueConSentY);

                ChartCPU.ChartAreas[0].AxisX.ScaleView.Position = programIteration - 99;
                ChartDisc.ChartAreas[0].AxisX.ScaleView.Position = programIteration - 99;
                ChartMemory.ChartAreas[0].AxisX.ScaleView.Position = programIteration - 99;
                ChartForRec.ChartAreas[0].AxisX.ScaleView.Position = programIteration - 99;
                ChartForSent.ChartAreas[0].AxisX.ScaleView.Position = programIteration - 99;
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
                    for (int i = 0; i < ChartCPU.Series.Count; i++)
                    {
                        if (ChartCPU.Series[i].Points.Count > 10)
                            ChartCPU.Series[i].Points.RemoveAt(0);
                    }
                    for (int i = 0; i < ChartDisc.Series.Count; i++)
                    {
                        if (ChartDisc.Series[i].Points.Count > 10)
                            ChartDisc.Series[i].Points.RemoveAt(0);
                    }
                    for (int i = 0; i < ChartMemory.Series.Count; i++)
                    {
                        if (ChartMemory.Series[i].Points.Count > 10)
                            ChartMemory.Series[i].Points.RemoveAt(0);
                    }
                    for (int i = 0; i < ChartForRec.Series.Count; i++)
                    {
                        if (ChartForRec.Series[i].Points.Count > 10)
                            ChartForRec.Series[i].Points.RemoveAt(0);
                    }
                    for (int i = 0; i < ChartForSent.Series.Count; i++)
                    {
                        if (ChartForSent.Series[i].Points.Count > 10)
                            ChartForSent.Series[i].Points.RemoveAt(0);
                    }
                }
            }
            else
            {
                for (int i = 0; i < ChartCPU.Series.Count; i++) ChartCPU.Series[i].Points.Clear();
                for (int i = 0; i < ChartDisc.Series.Count; i++) ChartCPU.Series[i].Points.Clear();
                for (int i = 0; i < ChartMemory.Series.Count; i++) ChartCPU.Series[i].Points.Clear();
                for (int i = 0; i < ChartForRec.Series.Count; i++) ChartForRec.Series[i].Points.Clear();
                for (int i = 0; i < ChartForSent.Series.Count; i++) ChartForRec.Series[i].Points.Clear();
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
            if (programIteration > 800)
            {
                if (cnt == 0 || programIteration == cnt)
                {
                    cnt = programIteration + 180;
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();

                    ChartCPU.Series["Forecast"].Points.Clear();
                    ChartDisc.Series["Forecast"].Points.Clear();
                    ChartMemory.Series["Forecast"].Points.Clear();
                    ChartForRec.Series["Forecast"].Points.Clear();
                    ChartForSent.Series["Forecast"].Points.Clear();

                    SearchingMaxSel.InitializeValues(DateTime.Now, "systemresources");
                    ForecastAnalize.InitializeValuesTests(Values.dateTimeResultMaxSel[0], Values.dateTimeResultMaxSel[Values.dateTimeResultMaxSel.Length - 1],
                        Values.dateTimeNewStory[0], Values.dateTimeNewStory[Values.dateTimeNewStory.Length - 1], "systemresources");
                    SearchingMaxSel.ComputeInterval(Values.dateTimeResultMaxSel[Values.dateTimeResultMaxSel.Length - 1], "systemresources");
                    if (ForecastAnalize.ComputeParamteres(ref Values.testMaxSel, ref Values.testNewStory, ref Values.resultMaxSel, ref Values.newStory))
                    {
                        double forecastVal;
                        for (int i = 0; i < ForecastAnalize.forecast.Length; i++)
                        {
                            for (int j = 0; j < ForecastAnalize.forecast[i].Length; j++)
                            {
                                if (i == 0 && j == 0)
                                {
                                    ChartCPU.Series["Forecast"].Points.AddXY(programIteration, procesLoadValue);
                                    ChartCPU.Series["Max"].Points.AddXY(programIteration, procesLoadValue + (3 * Values.dispersion[0]));
                                    ChartCPU.Series["Min"].Points.AddXY(programIteration, procesLoadValue - (3 * Values.dispersion[0]));
                                    ChartDisc.Series["Forecast"].Points.AddXY(programIteration, physicalDiscValue);
                                    ChartDisc.Series["Max"].Points.AddXY(programIteration, physicalDiscValue + (3 * Values.dispersion[1]));
                                    ChartDisc.Series["Min"].Points.AddXY(programIteration, physicalDiscValue - (3 * Values.dispersion[1]));
                                    ChartMemory.Series["Forecast"].Points.AddXY(programIteration, memoryValue);
                                    ChartMemory.Series["Max"].Points.AddXY(programIteration, memoryValue + (3 * Values.dispersion[2]));
                                    ChartMemory.Series["Min"].Points.AddXY(programIteration, memoryValue - (3 * Values.dispersion[2]));
                                }
                                if (j == 0)
                                {
                                    forecastVal = ForecastAnalize.forecast[i][j] * Convert.ToDouble(countProcess);
                                    if (forecastVal > 0)
                                    {
                                        ChartCPU.Series["Forecast"].Points.AddXY(programIteration + (60 * (i + 1)), forecastVal);
                                        ChartCPU.Series["Max"].Points.AddXY(programIteration + (60 * (i + 1)), forecastVal + (3 * Values.dispersion[0]));
                                        ChartCPU.Series["Min"].Points.AddXY(programIteration + (60 * (i + 1)), forecastVal - (3 * Values.dispersion[0]));
                                    }
                                    if (forecastVal < 0)
                                    {
                                        ChartCPU.Series["Forecast"].Points.AddXY(programIteration + (60 * (i + 1)), 0);
                                        ChartCPU.Series["Max"].Points.AddXY(programIteration + (60 * (i + 1)), 0 + (3 * Values.dispersion[0]));
                                        ChartCPU.Series["Min"].Points.AddXY(programIteration + (60 * (i + 1)), 0 - (3 * Values.dispersion[0]));
                                    }
                                }
                                else if (j == 1)
                                {
                                    forecastVal = ForecastAnalize.forecast[i][j] * Convert.ToDouble(countProcess);
                                    if (forecastVal > 0)
                                    {
                                        ChartDisc.Series["Forecast"].Points.AddXY(programIteration + (60 * (i + 1)), forecastVal);
                                        ChartDisc.Series["Max"].Points.AddXY(programIteration + (60 * (i + 1)), forecastVal + (3 * Values.dispersion[1]));
                                        ChartDisc.Series["Min"].Points.AddXY(programIteration + (60 * (i + 1)), forecastVal - (3 * Values.dispersion[1]));
                                    }
                                    if (forecastVal < 0)
                                    {
                                        ChartDisc.Series["Forecast"].Points.AddXY(programIteration + (60 * (i + 1)), 0);
                                        ChartDisc.Series["Max"].Points.AddXY(programIteration + (60 * (i + 1)), 0 + (3 * Values.dispersion[1]));
                                        ChartDisc.Series["Min"].Points.AddXY(programIteration + (60 * (i + 1)), 0 - (3 * Values.dispersion[1]));
                                    }
                                }
                                else if (j == 2)
                                {
                                    forecastVal = ForecastAnalize.forecast[i][j] * Convert.ToDouble(countProcess);
                                    if (forecastVal > 0)
                                    {
                                        ChartMemory.Series["Forecast"].Points.AddXY(programIteration + (60 * (i + 1)), forecastVal);
                                        ChartMemory.Series["Max"].Points.AddXY(programIteration + (60 * (i + 1)), forecastVal + (3 * Values.dispersion[2]));
                                        ChartMemory.Series["Min"].Points.AddXY(programIteration + (60 * (i + 1)), forecastVal - (3 * Values.dispersion[2]));
                                    }
                                    if (forecastVal < 0)
                                    {
                                        ChartMemory.Series["Forecast"].Points.AddXY(programIteration + (60 * (i + 1)), 0);
                                        ChartMemory.Series["Max"].Points.AddXY(programIteration + (60 * (i + 1)), 0 + (3 * Values.dispersion[2]));
                                        ChartMemory.Series["Min"].Points.AddXY(programIteration + (60 * (i + 1)), 0 - (3 * Values.dispersion[2]));
                                    }
                                }
                            }
                        }

                        SearchingMaxSel.InitializeValues(DateTime.Now, "network");
                        ForecastAnalize.InitializeValuesTests(Values.dateTimeResultMaxSel[0], Values.dateTimeResultMaxSel[Values.dateTimeResultMaxSel.Length - 1],
                            Values.dateTimeNewStory[0], Values.dateTimeNewStory[Values.dateTimeNewStory.Length - 1], "network");
                        SearchingMaxSel.ComputeInterval(Values.dateTimeResultMaxSel[Values.dateTimeResultMaxSel.Length - 1], "network");
                        ForecastAnalize.ComputeParamteres(ref Values.testMaxSel, ref Values.testNewStory, ref Values.resultMaxSel, ref Values.newStory);

                        for (int i = 0; i < ForecastAnalize.forecast.Length; i++)
                        {
                            for (int j = 0; j < ForecastAnalize.forecast[i].Length; j++)
                            {
                                if (i == 0 && j == 0)          
                                {
                                    ChartForRec.Series["Forecast"].Points.AddXY(programIteration, recSegmentsValue);
                                    ChartForRec.Series["Max"].Points.AddXY(programIteration, recSegmentsValue + (3 * Values.dispersion[0]));
                                    ChartForRec.Series["Min"].Points.AddXY(programIteration, recSegmentsValue - (3 * Values.dispersion[0]));
                                    ChartForSent.Series["Forecast"].Points.AddXY(programIteration, sentSegmentsValue);
                                    ChartForSent.Series["Max"].Points.AddXY(programIteration, sentSegmentsValue + (3 * Values.dispersion[1]));
                                    ChartForSent.Series["Min"].Points.AddXY(programIteration, sentSegmentsValue - (3 * Values.dispersion[1]));
                                }
                                if (j == 0)
                                {
                                    forecastVal = ForecastAnalize.forecast[i][j] * Convert.ToDouble(itemsCount);
                                    if (forecastVal > 0)
                                    {
                                        ChartForRec.Series["Forecast"].Points.AddXY(programIteration + (60 * (i + 1)), forecastVal);
                                        ChartForRec.Series["Max"].Points.AddXY(programIteration + (60 * (i + 1)), forecastVal + (3 * Values.dispersion[0]));
                                        ChartForRec.Series["Min"].Points.AddXY(programIteration + (60 * (i + 1)), forecastVal - (3 * Values.dispersion[0]));
                                    }
                                    if (forecastVal < 0)
                                    {
                                        ChartForRec.Series["Forecast"].Points.AddXY(programIteration + (60 * (i + 1)), 0);
                                        ChartForRec.Series["Max"].Points.AddXY(programIteration + (60 * (i + 1)), 0 + (3 * Values.dispersion[0]));
                                        ChartForRec.Series["Min"].Points.AddXY(programIteration + (60 * (i + 1)), 0 - (3 * Values.dispersion[0]));
                                    }
                                }
                                else if (j == 1)
                                {
                                    forecastVal = ForecastAnalize.forecast[i][j] * Convert.ToDouble(itemsCount);
                                    if (forecastVal > 0)
                                    {
                                        ChartForSent.Series["Forecast"].Points.AddXY(programIteration + (60 * (i + 1)), forecastVal);
                                        ChartForSent.Series["Max"].Points.AddXY(programIteration + (60 * (i + 1)), forecastVal + (3 * Values.dispersion[1]));
                                        ChartForSent.Series["Min"].Points.AddXY(programIteration + (60 * (i + 1)), forecastVal - (3 * Values.dispersion[1]));
                                    }
                                    if (forecastVal < 0)
                                    {
                                        ChartForSent.Series["Forecast"].Points.AddXY(programIteration + (60 * (i + 1)), 0);
                                        ChartForSent.Series["Max"].Points.AddXY(programIteration + (60 * (i + 1)), 0 + (3 * Values.dispersion[1]));
                                        ChartForSent.Series["Min"].Points.AddXY(programIteration + (60 * (i + 1)), 0 - (3 * Values.dispersion[1]));
                                    }
                                }
                            }
                        }
                    }
                    stopwatch.Stop();
                    ForecastingTime.Text = "Forecasting time: " + stopwatch.ElapsedMilliseconds.ToString() + " ms";
                }
            }
            ForecastingLabel.Text = "Forecast period: " + cnt;
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

        private void TrBarCPU_Scroll(object sender, EventArgs e)
        {
            ChartCPU.ChartAreas[0].AxisX.ScaleView.Size = TrBarCPU.Value;
        }

        private void TrBarDisc_Scroll(object sender, EventArgs e)
        {
            ChartDisc.ChartAreas[0].AxisX.ScaleView.Size = TrBarDisc.Value;
        }

        private void TrBarMem_Scroll(object sender, EventArgs e)
        {
            ChartMemory.ChartAreas[0].AxisX.ScaleView.Size = TrBarMem.Value;
        }

        private void trackBarPosChartNet_Scroll(object sender, EventArgs e)
        {
            ChartForRec.ChartAreas[0].AxisX.ScaleView.Size = trackBarPosChartNet.Value;
        }

        private void TrBarSent_Scroll(object sender, EventArgs e)
        {
            ChartForSent.ChartAreas[0].AxisX.ScaleView.Size = TrBarSent.Value;
        }
    }
}
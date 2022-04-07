using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SystemMonitor
{
    public partial class DataAnalysisForm : Form
    {
        DataAnalysingClust dataAnalysing = new DataAnalysingClust();
        private string id;
        private string count;
        private string time;

        public DataAnalysisForm()
        {
            InitializeComponent();
        }

        private void btnForNetClustAnalysis_Click(object sender, EventArgs e)
        {
            MethodForDataAnalysis(1, tbForNetData, numericForNetEntr, chartForNetRecClustAnalysis, chartForNetSenAnalysis, null);
        }

        private void BtnSysRes_Click(object sender, EventArgs e)
        {
            MethodForDataAnalysis(0, tbForSysResData, numericForSysResEntr, chartForDataAnalysisCpu, chartForDataAnalysisDisc, chartForDataAnalysisMem);
        }

        private void ShowClustering(double[][] rawData, int numClusters, int[] clustering, int parameters)
        {
            for (int k = 0; k < numClusters; ++k) // Каждый кластер
            {
                for (int i = 0; i < rawData.Length; ++i) // Каждая последовательность                    
                {
                    if (clustering[i] == k)
                    {
                        for (int j = 0; j < rawData[i].Length; ++j)
                        {
                            if (j != 0) initializeCharts(parameters, j, k, (int)rawData[i][0], (int)rawData[i][j]);
                        }
                    }
                }
            }
        }

        public void initializeCharts(int parameters, int j, int k, int x, int y)
        {
            if (parameters == 0)
            {
                if (j == 1) chartForDataAnalysisCpu.Series[k].Points.AddXY(x, y);
                if (j == 2) chartForDataAnalysisDisc.Series[k].Points.AddXY(x, y);
                if (j == 3) chartForDataAnalysisMem.Series[k].Points.AddXY(x, y);
            }
            else if (parameters == 1)
            {
                if (j == 1) chartForNetRecClustAnalysis.Series[k].Points.AddXY(x, y);
                if (j == 2) chartForNetSenAnalysis.Series[k].Points.AddXY(x, y);
            }
        }

        private void MethodForDataAnalysis(int parameters, TextBox textBox, NumericUpDown numeric, Chart chart1, Chart chart2, Chart chart3 = null)
        {
            textBox.Clear();
            if (chart3 != null)
            {
                for (int i = 0; i < chart1.Series.Count; i++) chart1.Series[i].Points.Clear();
                for (int i = 0; i < chart2.Series.Count; i++) chart2.Series[i].Points.Clear();
                for (int i = 0; i < chart3.Series.Count; i++) chart3.Series[i].Points.Clear();
            }
            else
            {
                for (int i = 0; i < chart1.Series.Count; i++) chart1.Series[i].Points.Clear();
                for (int i = 0; i < chart2.Series.Count; i++) chart2.Series[i].Points.Clear();
            }

            if (checkBox1.Checked) dataAnalysing.MainMethodOfAnalysis(parameters, 0, true);
            if (!checkBox1.Checked)
            {
                if (numeric.Value > 0) dataAnalysing.MainMethodOfAnalysis(parameters, (int)numeric.Value);
                else dataAnalysing.MainMethodOfAnalysis(parameters, 100);
            }

            textBox.AppendText(" Outlier:\t");
            for (int i = 0; i < dataAnalysing.outlier.Length; i++)
                textBox.AppendText($"\t{dataAnalysing.outlier[i]}");

            for (int i = 0; i < DataAnalysingClust.centroids.Length; i++)
            {
                textBox.AppendText($"{Environment.NewLine} Cluster {i + 1}\t");
                for (int j = 0; j < DataAnalysingClust.centroids[i].Length; j++)
                    textBox.AppendText($"\t{Convert.ToString(DataAnalysingClust.centroids[i][j])}");
            }
            int[] countValueClusters = new int[5];
            for (int i = 0; i < DataAnalysingClust.clustering.Length; i++)
            {
                if (DataAnalysingClust.clustering[i] == 0) countValueClusters[0] += 1;
                if (DataAnalysingClust.clustering[i] == 1) countValueClusters[1] += 1;
                if (DataAnalysingClust.clustering[i] == 2) countValueClusters[2] += 1;
                if (DataAnalysingClust.clustering[i] == 3) countValueClusters[3] += 1;
                if (DataAnalysingClust.clustering[i] == 4) countValueClusters[4] += 1;
            }
            textBox.AppendText($"{Environment.NewLine}{Environment.NewLine}");
            for (int i = 0; i < countValueClusters.Length; i++)
                textBox.AppendText($" {countValueClusters[i]}\t");
            textBox.AppendText($"{Environment.NewLine}{Environment.NewLine}Сlustering iterations: {DataAnalysingClust.ct}");

            textBox.AppendText($"{Environment.NewLine}{Environment.NewLine}");
            for (int i = 0; i < dataAnalysing.normalizeArr.Length; i++)
            {
                for (int j = 0; j < dataAnalysing.normalizeArr[i].Length; j++)
                    textBox.AppendText($"{dataAnalysing.normalizeArr[i][j]}\t");
                textBox.AppendText($"{Environment.NewLine}");
            }

            ShowClustering(DataAnalysingClust.rawData, DataAnalysingClust.numClusters, DataAnalysingClust.clustering, parameters);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                numericForSysResEntr.Enabled = false;
                numericForNetEntr.Enabled = false;
            }
            else
            {
                numericForSysResEntr.Enabled = true;
                numericForNetEntr.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            richTextBox1.Clear();
            DataTable table = SqlLiteDataBase.LetsQuery($"pragma table_info({comboBoxTableForModel.Text})");
            id = table.Rows[0][1].ToString();
            time = table.Rows[1][1].ToString();
            count = table.Rows[2][1].ToString();

            DataTable tableSelect = SqlLiteDataBase.LetsQuery($"select {id}" +
                $" from {comboBoxTableForModel.Text} where {time} between" +
                $" '{beginDateTime.Value.AddDays(-1).AddHours(-1):yyyy-MM-dd HH:mm:ss.fff}' " +
                $"and '{beginDateTime.Value.AddDays(-1).AddHours(1):yyyy-MM-dd HH:mm:ss.fff}'");

            ForecastingModel.ratio = new double[tableSelect.Rows.Count];

            for (int i = 3; i < table.Rows.Count; i++)
            {
                ForecastingModel.MainMethodForecatingModel(beginDateTime.Value, count, table.Rows[i][1].ToString(),
                    time, comboBoxTableForModel.Text, id, table.Rows.Count-3, i,  15);
            }                
            stopwatch.Stop();

            label5.Text = "Working time: " + stopwatch.ElapsedMilliseconds.ToString() + " ms";
            
            for (int i = 0; i < chartForOutputHistory.Series.Count; i++) chartForOutputHistory.Series[i].Points.Clear();

            try
            {
                double errMae = 0;
                double errMape = 0;

                DataTable NewStory = SqlLiteDataBase.LetsQuery("select idsysres, percproc, percmemory, percdisc from systemresources " +
                    $"where idsysres between {ForecastingModel.NewStory[0][0]} and {ForecastingModel.NewStory[ForecastingModel.NewStory.Length-1][0]}");

                DataTable MaxSimSampMin = SqlLiteDataBase.LetsQuery("select idsysres, percproc, percmemory, percdisc from systemresources " +
                    $"where idsysres between {ForecastingModel.MaxSimSampMin[0][0]} and {ForecastingModel.MaxSimSampMin[ForecastingModel.MaxSimSampMin.Length-1][0]}");


                //todo: сделать вывод времени вместо идентификатора + группировка по минутам
                //select strftime('%Y-%m-%d %H:%M', timesysres), avg(percproc) from systemresources where idsysres < 300
                //group by strftime('%Y-%m-%d %H:%M', timesysres)


                for (int i = 0; i < NewStory.Rows.Count; i++)
                {
                    for (int j = 0; j < NewStory.Columns.Count; j++)
                    {
                        for (int k = 0; k < chartForOutputHistory.Series.Count-4; k++)
                        {
                            chartForOutputHistory.Series[k].Points.AddXY(i, Convert.ToInt32(NewStory.Rows[i][k+1]));
                        }
                    }
                    for (int j = 0; j < NewStory.Columns.Count; j++)
                    {
                        for (int k = 4; k < chartForOutputHistory.Series.Count - 4; k++)
                        {
                            chartForOutputHistory.Series[k].Points.AddXY(i, Convert.ToInt32(MaxSimSampMin.Rows[i][k + 1]));
                        }
                    }
                }
                //for (int i = 0; i < ForecastingModel.NewStory.Length; i++)
                //{
                //    for (int j = 1; j < ForecastingModel.NewStory[i].Length; j++)
                //        richTextBox1.AppendText($"{ForecastingModel.NewStory[i][1]}\t");
                //}

                //richTextBox1.AppendText($"{Environment.NewLine}");

                //for (int i = 0; i < ForecastingModel.MaxSimSampMin.Length; i++)
                //{
                //    for (int j = 1; j < ForecastingModel.MaxSimSampMin[i].Length; j++)
                //        richTextBox1.AppendText($"{ForecastingModel.MaxSimSampMin[i][1]}\t");
                //}

                //richTextBox1.AppendText($"{Environment.NewLine}");
                /*chartForOutputHistory.Series[0].Name = "Max select samp";
                richTextBox1.AppendText($"Start index basic select: {ForecastingModel.basicSelect[0][0]}");
                richTextBox1.AppendText($"{Environment.NewLine}");
                for (int i = 0; i < ForecastingModel.basicSelect.Length; i++)
                {
                    for (int j = 1; j < ForecastingModel.basicSelect[i].Length; j++)
                    {
                        errMae += Math.Abs(ForecastingModel.basicSelect[i][1] - ForecastingModel.realVal[i][1]);
                        //errMape += Math.Abs(ForecastingModel.basicSelect[i][1] - ForecastingModel.realVal[i][1])/(ForecastingModel.realVal[i][1]);                        
                        chartForOutputHistory.Series["Max select samp"].Points.AddXY(i, ForecastingModel.basicSelect[i][1]);
                        if (ForecastingModel.MaxSimSampMin[ForecastingModel.MaxSimSampMin.Length - 1][0] == ForecastingModel.basicSelect[i][0])
                        {
                            chartForOutputHistory.Series[2].ChartType = SeriesChartType.Column;
                            chartForOutputHistory.Series[2].Points.AddXY(i, 70);
                        }
                    }
                }

                richTextBox1.AppendText($"{Environment.NewLine}");

                chartForOutputHistory.Series[1].Name = "Real values";
                richTextBox1.AppendText($"Start index forecast: {ForecastingModel.realVal[0][0]}");
                richTextBox1.AppendText($"{Environment.NewLine}");
                for (int i = 0; i < ForecastingModel.realVal.Length; i++)
                {
                    for (int j = 1; j < ForecastingModel.realVal[i].Length; j++)
                        chartForOutputHistory.Series["Real values"].Points.AddXY(i, ForecastingModel.realVal[i][1]);
                }*/
                //richTextBox1.AppendText($"{Environment.NewLine}");
                //richTextBox1.AppendText($"Error MAE: {errMae/ForecastingModel.basicSelect.Length}");
                //richTextBox1.AppendText($"{Environment.NewLine}");
                //richTextBox1.AppendText($"Error MAPE: {Math.Round(errMape / ForecastingModel.realVal.Length * 100)} %");                
                richTextBox1.AppendText($"{Environment.NewLine}");
                richTextBox1.AppendText($"Max likenes: {ForecastingModel.currentValKor}");
                richTextBox1.AppendText($"{Environment.NewLine}");
                richTextBox1.AppendText($"DispersionX: {Math.Sqrt(ForecastingModel.dispersionX)}");
                richTextBox1.AppendText($"{Environment.NewLine}");
                richTextBox1.AppendText($"DispersionY: {Math.Sqrt(ForecastingModel.dispersionY)}");
                richTextBox1.AppendText($"{Environment.NewLine}");
                richTextBox1.AppendText($"SumSquare: {ForecastingModel.sumSquare}");
                richTextBox1.AppendText($"{Environment.NewLine}");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void comboBoxTableForModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}


//DateTime.Now.AddHours(-1).ToString("yyyy-MM-dd HH:mm:ss.fff")

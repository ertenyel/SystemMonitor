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
            string columns = "";
            string time = "";

            stopwatch.Start();
            if (comboBoxTableForModel.Text == "Systemresources")
            {
                columns = "strftime('%Y-%m-%d %H:%M', timesysres), avg(percproc)/avg(numberprocess), avg(percdisc)/avg(numberprocess), avg(percmemory)/avg(numberprocess)";
                time = "timesysres";
            }
            else if (comboBoxTableForModel.Text == "Network")
            {
                columns = "strftime('%Y-%m-%d %H:%M', timenetwork), avg(receivedbytes)/avg(connectionscount), avg(sentbyte)/avg(connectionscount)";
                time = "timenetwork";
            }

            DataTable tableNewStory = SqlLiteDataBase.LetsQuery($"select {columns}" +
                $"from {comboBoxTableForModel.Text} where {time} between '{beginDateTime.Value.AddMinutes(-5):yyyy-MM-dd HH:mm:ss.fff}' and '{beginDateTime.Value:yyyy-MM-dd HH:mm:ss.fff}'" +
                $"group by strftime('%Y-%m-%d %H:%M', {time})");


            DataTable tableMaxSel = SqlLiteDataBase.LetsQuery($"select {columns}" +
                $"from {comboBoxTableForModel.Text} where {time} between '{beginDateTime.Value.AddDays(-1).AddHours(-1):yyyy-MM-dd HH:mm:ss.fff}' and '{beginDateTime.Value.AddDays(-1).AddHours(1):yyyy-MM-dd HH:mm:ss.fff}'" +
                $"group by strftime('%Y-%m-%d %H:%M', {time})");

            ForecastModelWithStruct.InitializeValues(tableNewStory, tableMaxSel);
            richTextBox1.Clear();

            for (int i = 0; i < Values.newStory.Length; i++)
            {
                richTextBox1.AppendText($"{Values.dateTimeNewStory[i]}\t");
                for (int j = 0; j < Values.newStory[i].Length; j++)
                    richTextBox1.AppendText($"{Values.newStory[i][j]}\t");
                richTextBox1.AppendText($"{Environment.NewLine}");
            }

            richTextBox1.AppendText($"{Environment.NewLine}");

            for (int i = 0; i < Values.resultMaxSel.Length; i++)
            {
                richTextBox1.AppendText($"{Values.dateTimeResultMaxSel[i]}\t");
                for (int j = 0; j < Values.resultMaxSel[i].Length; j++)
                    richTextBox1.AppendText($"{Values.resultMaxSel[i][j]}\t");
                richTextBox1.AppendText($"{Environment.NewLine}");
            }

            stopwatch.Stop();

            label5.Text = "Working time: " + stopwatch.ElapsedMilliseconds.ToString() + " ms";
        }

        private void comboBoxTableForModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}


//DateTime.Now.AddHours(-1).ToString("yyyy-MM-dd HH:mm:ss.fff")
//            DataTable tableInfo = SqlLiteDataBase.LetsQuery($"pragma table_info({comboBoxTableForModel.Text})");
//for (int i = 0; i < chartForOutputHistory.Series.Count; i++) chartForOutputHistory.Series[i].Points.Clear();
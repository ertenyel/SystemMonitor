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

        public DataAnalysisForm()
        {
            InitializeComponent();
        }

        private void btnForNetClustAnalysis_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //MethodForDataAnalysis(1, tbForNetData, numericForNetEntr, chartForNetRecClustAnalysis, chartForNetSenAnalysis, null);
            //dataAnalysing.MainMethodOfAnalysis(1, 0, true);
            stopwatch.Stop();
            label3.Text = "Working time: " + stopwatch.ElapsedMilliseconds.ToString() + " ms";
        }

        private void BtnSysRes_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            MethodForDataAnalysis(0, DtpForClust.Value, tbForSysResData, chartForDataAnalysisCpu, chartForDataAnalysisDisc, chartForDataAnalysisMem);
            dataAnalysing.MainMethodOfAnalysis(0, DtpForClust.Value);
            stopwatch.Stop();
            label3.Text = "Working time: " + stopwatch.ElapsedMilliseconds.ToString() + " ms";
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

        private void MethodForDataAnalysis(int parameters, DateTime dateTime, TextBox textBox, Chart chart1, Chart chart2, Chart chart3 = null)
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

            dataAnalysing.MainMethodOfAnalysis(parameters, dateTime);

            textBox.AppendText(" Outlier:\t");
            for (int i = 0; i < dataAnalysing.outlier.Length; i++)
                textBox.AppendText($"\t{dataAnalysing.outlier[i]}");

            for (int i = 0; i < DataAnalysingClust.centroids.Length; i++)
            {
                textBox.AppendText($"{Environment.NewLine} Cluster {i + 1}\t");
                for (int j = 0; j < DataAnalysingClust.centroids[i].Length; j++)
                {
                    textBox.AppendText($"\t{Convert.ToString(DataAnalysingClust.centroids[i][j])}");
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            DataTable dataTable = SqlLiteDataBase.LetsQuery($"select avg(percproc), avg(percdisc), avg(percmemory) " +
                      $"from systemresources where timesysres between '{beginDateTime.Value:yyyy-MM-dd HH:mm:ss.fff}' and '{beginDateTime.Value.AddDays(2):yyyy-MM-dd HH:mm:ss.fff}' " +
                      $"group by strftime('%Y-%m-%d %H:%M', timesysres)");
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                chartForOutputHistory.Series[0].Points.AddXY(i, dataTable.Rows[i][0]);
                /*for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    
                } */
            }


            stopwatch.Stop();

            label5.Text = "Working time: " + stopwatch.ElapsedMilliseconds.ToString() + " ms";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            chartForOutputHistory.ChartAreas[0].AxisX.ScaleView.Size = trackBar1.Value;
            label1.Text = Convert.ToString(trackBar1.Value);
        }
    }
}
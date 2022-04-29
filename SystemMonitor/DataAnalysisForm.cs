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
            richTextBox1.Clear();

            SearchingMaxSel.InitializeValues(beginDateTime.Value, comboBoxTableForModel.Text);
            ForecastAnalize.InitializeValuesTests(Values.dateTimeResultMaxSel[0], Values.dateTimeResultMaxSel[Values.dateTimeResultMaxSel.Length-1], 
                Values.dateTimeNewStory[0], Values.dateTimeNewStory[Values.dateTimeNewStory.Length - 1], comboBoxTableForModel.Text);
            ForecastAnalize.ComputeParamteres(ref Values.testMaxSel, ref Values.testNewStory, ref Values.resultMaxSel, ref Values.newStory);

            for (int i = 0; i < Values.newStory.Length; i++)
            {
                richTextBox1.AppendText($"{Values.dateTimeNewStory[i]}\t");

                for (int j = 0; j < Values.newStory[i].Length; j++)
                    richTextBox1.AppendText($"{Values.newStory[i][j]}\t");
                richTextBox1.AppendText($"{Environment.NewLine}");
            }

            richTextBox1.AppendText($"{Environment.NewLine}");

            for (int i = 0; i < Values.testNewStory.Length; i++)
            {
                richTextBox1.AppendText($"{Values.dateTimeTestNewStory[i]}\t");

                for (int j = 0; j < Values.testNewStory[i].Length; j++)
                    richTextBox1.AppendText($"{Values.testNewStory[i][j]}\t");
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

            richTextBox1.AppendText($"{Environment.NewLine}");

            for (int i = 0; i < Values.testMaxSel.Length; i++)
            {
                richTextBox1.AppendText($"{Values.dateTimeTestMaxSel[i]}\t");

                for (int j = 0; j < Values.testMaxSel[i].Length; j++)
                    richTextBox1.AppendText($"{Values.testMaxSel[i][j]}\t");
                richTextBox1.AppendText($"{Environment.NewLine}");
            }

            richTextBox1.AppendText($"{Environment.NewLine}");

            for (int i = 0; i < ForecastAnalize.forecast.Length; i++)
            {
                for (int j = 0; j < ForecastAnalize.forecast[i].Length; j++)
                    richTextBox1.AppendText($"{ForecastAnalize.forecast[i][j]}\t");
                richTextBox1.AppendText($"{Environment.NewLine}");
            }

            richTextBox1.AppendText($"{Environment.NewLine}");
            richTextBox1.AppendText($"Max factor: {SearchingMaxSel.maxFactor}");
            richTextBox1.AppendText($"{Environment.NewLine}");
            richTextBox1.AppendText($"factorNewBt: {ForecastAnalize.factorNewBt}");
            richTextBox1.AppendText($"{Environment.NewLine}");
            richTextBox1.AppendText($"factorNewCt: {ForecastAnalize.factorNewCt}"); 
             stopwatch.Stop();

            label5.Text = "Working time: " + stopwatch.ElapsedMilliseconds.ToString() + " ms";
        }

        private void comboBoxTableForModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
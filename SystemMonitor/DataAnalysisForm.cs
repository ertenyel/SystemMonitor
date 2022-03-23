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

        private void btnOutputHistory_Click(object sender, EventArgs e)
        {
            string table;
            DataTable dataTable;

            if (comboBoxForParam.SelectedIndex == 0)
            {
                table = "systemresources";
                if (numericBegin.Value != 0 && numericEnd.Value != 0)
                {
                    dataTable = SqlLiteDataBase.LetsQuery($"select idsysres, numberprocess, percproc, percdisc, percmemory from {table} where idsysres between '{numericBegin.Value}' and '{numericEnd.Value}' order by idsysres");
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        for (int j = 0; j < dataTable.Rows.Count; j++)
                        {
                            if (i != 0)
                                Charts.FillChartForOutputHis(Convert.ToInt32(dataTable.Rows[j][0]), Convert.ToInt32(dataTable.Rows[j][i]));
                        }

                        for (int k = 0; k < Charts.outputHisX.Count; k++)
                        {
                            if (i == 1)
                            {
                                chartForOutputHistory.Series[i - 1].Name = "Process count";
                                chartForOutputHistory.Series["Process count"].Points.AddXY(Charts.outputHisX[k], Charts.outputHisY[k]);
                            }
                            else if (i == 2)
                            {
                                chartForOutputHistory.Series[i - 1].Name = "% processor";
                                chartForOutputHistory.Series["% processor"].Points.AddXY(Charts.outputHisX[k], Charts.outputHisY[k]);
                            }
                            else if (i == 3)
                            {
                                chartForOutputHistory.Series[i - 1].Name = "% disc";
                                chartForOutputHistory.Series["% disc"].Points.AddXY(Charts.outputHisX[k], Charts.outputHisY[k]);
                            }
                            else if (i == 4)
                            {
                                chartForOutputHistory.Series[i - 1].Name = "% memory";
                                chartForOutputHistory.Series["% memory"].Points.AddXY(Charts.outputHisX[k], Charts.outputHisY[k]);
                            }
                        }
                        Charts.RefreshAxes();
                    }
                }
            }
            else if (comboBoxForParam.SelectedIndex == 1)
            {
                table = "network";
                dataTable = SqlLiteDataBase.LetsQuery($"select idnetwork, connectionscount, receivedbytes, sentbyte from {table} where idnetwork between '{numericBegin.Value}' and '{numericEnd.Value}' order by idnetwork");
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    for (int j = 0; j < dataTable.Rows.Count; j++)
                    {
                        if (i != 0)
                            Charts.FillChartForOutputHis(Convert.ToInt32(dataTable.Rows[j][0]), Convert.ToInt32(dataTable.Rows[j][i]));
                    }

                    for (int k = 0; k < Charts.outputHisX.Count; k++)
                    {
                        if (i == 1)
                        {
                            chartForOutputHistory.Series[i - 1].Name = "Count connections";
                            chartForOutputHistory.Series["Count connections"].Points.AddXY(Charts.outputHisX[k], Charts.outputHisY[k]);
                        }
                        else if (i == 2)
                        {
                            chartForOutputHistory.Series[i - 1].Name = "Received bytes";
                            chartForOutputHistory.Series["Received bytes"].Points.AddXY(Charts.outputHisX[k], Charts.outputHisY[k]);
                        }
                        else if (i == 3)
                        {
                            chartForOutputHistory.Series[i - 1].Name = "Sent bytes";
                            chartForOutputHistory.Series["Sent bytes"].Points.AddXY(Charts.outputHisX[k], Charts.outputHisY[k]);
                        }
                    }
                    Charts.RefreshAxes();
                }
            }
            else if (comboBoxForParam.SelectedIndex == -1)
                MessageBox.Show("You need to select a table");

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
            ForecastingModel.MainMethodForecatingModel(beginDateTime.Value, "percproc");
            stopwatch.Stop();

            label5.Text = "Working time: " + stopwatch.ElapsedMilliseconds.ToString() + " ms";

            for (int i = 0; i < chartForOutputHistory.Series.Count; i++) chartForOutputHistory.Series[i].Points.Clear();

            try
            {
                chartForOutputHistory.Series[0].Name = "Max select samp";
                
                for (int i = 0; i < ForecastingModel.basicSelect.Length; i++)
                {
                    for (int j = 1; j < ForecastingModel.basicSelect[i].Length; j++)
                    {
                        richTextBox1.AppendText($"{ForecastingModel.basicSelect[i][1]}, ");
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

                for (int i = 0; i < ForecastingModel.realVal.Length; i++)
                {
                    for (int j = 1; j < ForecastingModel.realVal[i].Length; j++)
                    {
                        richTextBox1.AppendText($"{ForecastingModel.realVal[i][1]}, ");
                        chartForOutputHistory.Series["Real values"].Points.AddXY(i, ForecastingModel.realVal[i][1]);
                    }                        
                }

                richTextBox1.AppendText($"{Environment.NewLine}");
                richTextBox1.AppendText($"{ForecastingModel.currentValKor}");
                
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            


            /*
            richTextBox1.AppendText($"{Environment.NewLine}");
            richTextBox1.AppendText($"{Environment.NewLine}");

            for (int i = 0; i < ForecastingModel.MaxSimSampMin.Length; i++)
            {
                for (int j = 1; j < ForecastingModel.MaxSimSampMin[i].Length; j++)
                    richTextBox1.AppendText($"{ForecastingModel.MaxSimSampMin[i][1]}, ");
            }

            richTextBox1.AppendText($"{Environment.NewLine}{ForecastingModel.minDistance}");
            richTextBox1.AppendText($"{Environment.NewLine}{ForecastingModel.currentValKor}");*/



            /*
            richTextBox1.AppendText($"{Environment.NewLine}");

            for (int i = 0; i < ForecastingModel.NewStory.Length; i++)
            {
                for (int j = 0; j < ForecastingModel.NewStory[i].Length; j++)
                    richTextBox1.AppendText($"{ForecastingModel.NewStory[i][j]}\t");
                richTextBox1.AppendText($"{Environment.NewLine}");
            }

            richTextBox1.AppendText($"{Environment.NewLine}");

            for (int i = 0; i < ForecastingModel.ratio.Length; i++)
                richTextBox1.AppendText($"{Environment.NewLine}{ForecastingModel.ratio[i]}");

            richTextBox1.AppendText($"{Environment.NewLine}{ForecastingModel.ct}");
            */

            //for (int i = 0; i < ForecastingModel.ratio.Length; i++)
            //  richTextBox1.AppendText($"{ForecastingModel.ratio[i]}");
        }
    }
}


//DateTime.Now.AddHours(-1).ToString("yyyy-MM-dd HH:mm:ss.fff")

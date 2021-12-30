using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace SystemMonitor
{
    public partial class Form1 : Form
    {        
        double recSegmentsValue;
        double sentSegmentsValue;
        int itemsCount = 0;       

        public Form1()
        {
            InitializeComponent();
        }

        private void TimerProcLoad_Tick(object sender, EventArgs e)
        {
            SystemResourses();
            InitializeParameters(ProcessLoadBar.Value, PhisycalDiskBar.Value, MemoryLoadBar.Value, itemsCount, (int)Math.Round(recSegmentsValue), (int)Math.Round(sentSegmentsValue));
            ShowActiveTcpConnections();
            SecurityLog();
        }
        /// <summary>
        /// Work with system resourses
        /// </summary>
        public void SystemResourses()
        {
            ProcessLoadBar.Value = (int)Math.Round(Processor.NextValue());
            try
            {
                PhisycalDiskBar.Value = (int)(100 - Math.Round(Disk.NextValue()));
            }
            catch (Exception ex)
            {
                PhisycalDiskBar.Value = 0;
                MessageBox.Show(ex.Message);
            }
            MemoryLoadBar.Value = (int)(Math.Round(Memory.NextValue()));
            ProcessLoadLabel.Text = "Processor load " + ProcessLoadBar.Value + " %";
            LabelPhysicalDisk.Text = "Phisycal disk load " + PhisycalDiskBar.Value + " %";
        }
        /// <summary>
        /// Work with servers security 
        /// </summary>
        public void SecurityLog()
        {
            LabelLogonServer.Text = "Logon to server: " + CounterLogonServer.NextValue() + " Logon/sec";
            LabelErrorLogon.Text = "Error logon to server: " + CounterErrorLogon.NextValue();
        }
        /// <summary>
        /// Sending active tcp connections
        /// </summary>
        public void ShowActiveTcpConnections()
        {
            recSegmentsValue = BytesReceived.NextValue();
            sentSegmentsValue = SentBytes.NextValue();
            LabelMemoryLoad.Text = "Memory load " + MemoryLoadBar.Value + " %";
            ReceivedBytesLabel.Text = "Received bytes: " + recSegmentsValue + " bytes/sec";
            BytesSentLabel.Text = "Sent bytes: " + sentSegmentsValue + " bytes/sec";

            itemsCount = 0;
            listBox1.Items.Clear();
            TcpConnectionInformation[] connections = IPGlobalProperties.GetIPGlobalProperties().GetActiveTcpConnections();
            foreach (var c in connections)
                listBox1.Items.Add($"{itemsCount++}. >> \t" + $" Local connection\t{c.LocalEndPoint} <==> {c.RemoteEndPoint}\t remoute connection");
            LabelItemsCount.Text = "Connections count: " + itemsCount;
        }
        /// <summary>
        /// Parameters for chart
        /// </summary>
        /// <param name="valueCPUX"></param>
        /// <param name="valueDiscX"></param>
        /// <param name="valueMemX"></param>
        /// <param name="valueConX"></param>
        /// <param name="valueConRecX"></param>
        /// <param name="valueConSentX"></param>
        public void InitializeParameters(int valueCPUX, int valueDiscX, int valueMemX, int valueConX, int valueConRecX, int valueConSentX)
        {
            Chart.FillChart(valueCPUX, valueDiscX, valueMemX, valueConX, valueConRecX, valueConSentX);

            ChartForSysRes.Series["CPU"].LegendText = "CPU";
            ChartForSysRes.Series["Phisycal disc"].LegendText = "Phisycal disc";
            ChartForSysRes.Series["Memory"].LegendText = "Memory";
            for (int k = 0; k < Chart.procX.Count; k++)
            {
                ChartForSysRes.Series["CPU"].Points.AddXY(Chart.procX[k], Chart.procY[k]);
                ChartForSysRes.Series["Phisycal disc"].Points.AddXY(Chart.discX[k], Chart.diskY[k]);
                ChartForSysRes.Series["Memory"].Points.AddXY(Chart.memX[k], Chart.memY[k]);
            }

            ChartForTCPCon.Series["Tcp connections count"].LegendText = "Tcp connections count";
            ChartForTCPCon.Series["Received bytes"].LegendText = "Received bytes";
            ChartForTCPCon.Series["Sent bytes"].LegendText = "Sent bytes";
            for (int k = 0; k < Chart.conX.Count; k++)
            {
                ChartForTCPCon.Series["Tcp connections count"].Points.AddXY(Chart.conX[k], Chart.conY[k]);
                ChartForTCPCon.Series["Received bytes"].Points.AddXY(Chart.conRecX[k], Chart.conRexY[k]);
                ChartForTCPCon.Series["Sent bytes"].Points.AddXY(Chart.conSentX[k], Chart.conSentY[k]);
            }
        }
    }
}

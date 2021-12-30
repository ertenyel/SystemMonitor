using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemMonitor
{
    class Chart
    {
        public static  List<int> procX;
        public static List<int> procY;
        public static List<int> discX;
        public static List<int> diskY;
        public static List<int> memX;
        public static List<int> memY;
        public static List<int> conX;
        public static List<int> conY;
        public static List<int> conRecX;
        public static List<int> conRexY;
        public static List<int> conSentX;
        public static List<int> conSentY;        
        public static int itemsCount = 0;
        public static int i;

        public static void FillChart(int valueCPUX, int valueDiscX, int valueMemX, int valueConX, int valueConRecX, int valueConSentX)
        {
            procX = new List<int>();
            procY = new List<int>();
            discX = new List<int>();
            diskY = new List<int>();
            memX = new List<int>();
            memY = new List<int>();
            conX = new List<int>();
            conY = new List<int>();
            conRecX = new List<int>();
            conRexY = new List<int>();
            conSentX = new List<int>();
            conSentY = new List<int>();
            try
            {
                procX.Add(i++);
                procY.Add(valueCPUX);
                discX.Add(i++);
                diskY.Add(valueDiscX);
                memX.Add(i++);
                memY.Add(valueMemX);
                conX.Add(i++);
                conY.Add(valueConX);
                conRecX.Add(i++);
                conRexY.Add(valueConRecX);
                conSentX.Add(i++);
                conSentY.Add(valueConSentX);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

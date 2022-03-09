using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemMonitor
{
    class Charts
    {
        public static List<int> outputHisX = new List<int>();
        public static List<int> outputHisY = new List<int>();        

        public static int itemsCount = 0;
        public static int i;

        public static void FillChartForOutputHis(int x, int y)
        {
            outputHisX.Add(x);
            outputHisY.Add(y);
        }

        public static void RefreshAxes()
        {
            outputHisX = new List<int>();
            outputHisY = new List<int>();
        }
    }
}

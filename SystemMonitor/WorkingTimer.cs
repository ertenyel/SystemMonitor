using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemMonitor
{
    class WorkingTimer
    {        
        private static int hours = 0;
        private static int minutes = 0;
        private static int seconds = 0;
        private static string hoursStr = "";
        private static string minutesStr = "";
        private static string secondsStr = "";

        public static string TimeIntoLabel()
        {
            if (seconds == 59)
            {
                seconds = 0;
                if (minutes == 59)
                {
                    minutes = 0;
                    hours++;
                }
                else
                    minutes++;
            }
            else
                seconds++;

            if (seconds < 10)
                secondsStr = $"0{seconds}";
            else
                secondsStr = $"{seconds}";

            if (minutes < 10)
                minutesStr = $"0{minutes}";
            else
                minutesStr = $"{minutes}";

            if (hours < 10)
                hoursStr = $"0{hours}";
            else
                hoursStr = $"{hours}";

            return $"Working time: {hoursStr}:{minutesStr}:{secondsStr}";
        }
    }
}

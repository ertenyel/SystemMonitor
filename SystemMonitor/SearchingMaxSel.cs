using System;
using System.Data;

namespace SystemMonitor
{
    struct Values
    {
        public static double[][] newStory;
        public static DateTime[] dateTimeNewStory;
        public static double[][] maxSel;
        public static DateTime[] dateTimeMaxSel;
        public static double[][] maybeMaxSel;
        public static DateTime[] dateTimeMaybeMaxSel;

        public static double[][] testMaxSel;
        public static DateTime[] dateTimeTestMaxSel;

        public static double[][] testNewStory;
        public static DateTime[] dateTimeTestNewStory;

        public static double[][] resultMaxSel;
        public static DateTime[] dateTimeResultMaxSel;

        public static double[] dispersion;
    }
    class SearchingMaxSel
    {
        private static double[][] ZMarksX;
        private static double[][] ZMarksY;
        private static double[] tempFactor;
        private static double factor;
        public static double maxFactor;
        private static int ct;

        public static void ComputeInterval(DateTime value, string table)
        {
            string columns = "";
            string time = "";
            if (table == "systemresources")
            {
                columns = " avg(percproc)/avg(numberprocess), avg(percdisc)/avg(numberprocess), avg(percmemory)/avg(numberprocess) ";
                time = "timesysres";
            }
            else if (table == "network")
            {
                columns = " avg(receivedbytes)/avg(connectionscount), avg(sentbyte)/avg(connectionscount) ";
                time = "timenetwork";
            }
            DataTable forecastMaxSel = SqlLiteDataBase.LetsQuery($"select {columns} " +
                $"from {table} where {time} between '{value:yyyy-MM-dd HH:mm:ss.fff}' and '{value.AddMinutes(3):yyyy-MM-dd HH:mm:ss.fff}' ");

            double[][] forecastMaxSelArr = new double[forecastMaxSel.Rows.Count][];
            for (int i = 0; i < forecastMaxSel.Rows.Count; i++)
            {
                forecastMaxSelArr[i] = new double[forecastMaxSel.Columns.Count];
                for (int j = 0; j < forecastMaxSel.Columns.Count; j++)
                    forecastMaxSelArr[i][j] = Convert.ToDouble(forecastMaxSel.Rows[i][j]);
            }
            ComputeParameters(forecastMaxSelArr, "sko");
        }
        public static void InitializeValues(DateTime value , string table)
        {
            maxFactor = 0;
            string columns = "";
            string time = "";
            int days = 0;

            if (table == "systemresources")
            {
                columns = "strftime('%Y-%m-%d %H:%M', timesysres), avg(percproc)/avg(numberprocess), avg(percdisc)/avg(numberprocess), avg(percmemory)/avg(numberprocess)";
                time = "timesysres";
            }
            else if (table == "network")
            {
                columns = "strftime('%Y-%m-%d %H:%M', timenetwork), avg(receivedbytes)/avg(connectionscount), avg(sentbyte)/avg(connectionscount)";
                time = "timenetwork";
            }

            DataTable tableNewStory = SqlLiteDataBase.LetsQuery($"select {columns} " +
                $"from {table} where {time} between '{value.AddMinutes(-60):yyyy-MM-dd HH:mm:ss.fff}' and '{value:yyyy-MM-dd HH:mm:ss.fff}' " +
                $"group by strftime('%Y-%m-%d %H:%M', {time})");

            DataTable tableMaxSel;
            for (int i = 1; i < 30; i++)
            {
                tableMaxSel = SqlLiteDataBase.LetsQuery($"select {columns} " +
                      $"from {table} where {time} between '{value.AddDays(-i).AddHours(-2):yyyy-MM-dd HH:mm:ss.fff}' and '{value.AddDays(-i).AddHours(2):yyyy-MM-dd HH:mm:ss.fff}' " +
                      $"group by strftime('%Y-%m-%d %H:%M', {time})");
                if (tableMaxSel != null && tableMaxSel.Rows.Count > 120)
                {
                    days = i;
                    break;
                }
                else if (i == 29)
                    return;
            }
            tableMaxSel = SqlLiteDataBase.LetsQuery($"select {columns} " +
                      $"from {table} where {time} between '{value.AddDays(-days).AddHours(-2):yyyy-MM-dd HH:mm:ss.fff}' and '{value.AddDays(-days).AddHours(2):yyyy-MM-dd HH:mm:ss.fff}' " +
                      $"group by strftime('%Y-%m-%d %H:%M', {time})");

            Values.newStory = new double[tableNewStory.Rows.Count][];
            Values.dateTimeNewStory = new DateTime[tableNewStory.Rows.Count];
            for (int i = 0; i < tableNewStory.Rows.Count; i++)
            {
                Values.newStory[i] = new double[tableNewStory.Columns.Count - 1];
                for (int j = 0; j < tableNewStory.Columns.Count; j++)
                {
                    if (j == 0)
                        Values.dateTimeNewStory[i] = Convert.ToDateTime(tableNewStory.Rows[i][j]);
                    else
                        Values.newStory[i][j - 1] = Convert.ToDouble(tableNewStory.Rows[i][j]);
                }
            }

            Values.maxSel = new double[tableMaxSel.Rows.Count][];
            Values.dateTimeMaxSel = new DateTime[tableMaxSel.Rows.Count];
            for (int i = 0; i < tableMaxSel.Rows.Count; i++)
            {
                Values.maxSel[i] = new double[tableMaxSel.Columns.Count - 1];
                for (int j = 0; j < tableMaxSel.Columns.Count; j++)
                {
                    if (j == 0)
                        Values.dateTimeMaxSel[i] = Convert.ToDateTime(tableMaxSel.Rows[i][j]);
                    else
                        Values.maxSel[i][j - 1] = Convert.ToDouble(tableMaxSel.Rows[i][j]);
                }
            }
            ct = 0;
            ComputeParameters(Values.newStory, "x");
            SearchMaxSel(Values.maxSel, Values.newStory.Length);            
        }
        private static void ComputeParameters(double[][] inputArray, string xOrYorSKO)
        {
            double[] avgVal = new double[inputArray[0].Length];
            double[] dispersion = new double[inputArray[0].Length];

            for (int i = 0; i < inputArray[0].Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                    avgVal[i] += inputArray[j][i];
                avgVal[i] /= inputArray.Length;
            }

            for (int i = 0; i < inputArray[0].Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                    dispersion[i] += (avgVal[i] - inputArray[j][i]) * (avgVal[i] - inputArray[j][i]);
                dispersion[i] = Math.Sqrt(dispersion[i] / (inputArray.Length - 1));
            }

            if (xOrYorSKO == "sko")
                Values.dispersion = dispersion;

            if (xOrYorSKO == "x")
            {
                ZMarksX = new double[inputArray.Length][];
                for (int i = 0; i < inputArray.Length; i++)
                {
                    ZMarksX[i] = new double[inputArray[i].Length];
                    for (int j = 0; j < inputArray[i].Length; j++)
                        ZMarksX[i][j] = (inputArray[i][j] - avgVal[j]) / dispersion[j];
                }
            }
            else if(xOrYorSKO == "y")
            {
                factor = 0;
                ZMarksY = new double[inputArray.Length][];
                for (int i = 0; i < inputArray.Length; i++)
                {
                    ZMarksY[i] = new double[inputArray[i].Length];
                    for (int j = 0; j < inputArray[i].Length; j++)
                        ZMarksY[i][j] = (inputArray[i][j] - avgVal[j]) / dispersion[j];
                }

                tempFactor = new double[inputArray[0].Length];
                for (int i = 0; i < inputArray[0].Length; i++)
                {
                    for (int j = 0; j < inputArray.Length; j++)
                        tempFactor[i] += ZMarksX[j][i] * ZMarksY[j][i];
                    tempFactor[i] /= (inputArray.Length - 1);

                    factor += tempFactor[i];
                }

                if (factor > maxFactor)
                {
                    maxFactor = factor;
                    Values.resultMaxSel = Values.maybeMaxSel;
                    Values.dateTimeResultMaxSel = Values.dateTimeMaybeMaxSel;                    
                }
                ct++;
                if (ct == Values.maxSel.Length - Values.newStory.Length - 1) return;
                SearchMaxSel(Values.maxSel, Values.newStory.Length);
            }
        }
        private static void SearchMaxSel(double[][] inputArray, int windLength)
        {
            Values.maybeMaxSel = new double[windLength][];
            Values.dateTimeMaybeMaxSel = new DateTime[windLength];

            for (int i = 0; i < windLength; i++)
            {
                Values.dateTimeMaybeMaxSel[i] = Values.dateTimeMaxSel[i + ct];
                Values.maybeMaxSel[i] = new double[inputArray[i].Length];
                for (int j = 0; j < inputArray[i].Length; j++)
                    Values.maybeMaxSel[i][j] = inputArray[i + ct][j];
            }
            ComputeParameters(Values.maybeMaxSel, "y");
        }
    }
}

using System;
using System.Data;

namespace SystemMonitor
{
    class ForecastingModel
    {


        //todo: изучить принцип выбора длины прогнозирования и базовой выборки
        // 
        public static int[][] NewStory;
        public static int[][] MaybeMaxSimSamp;
        public static int[][] MaxSimSampMin;
        public static int[][] basicSelect;
        public static double sumVal;
        public static double avgVal;
        public static double doubleValSum;
        public static double dispersionX;
        public static double dispersionY;
        public static double[] ratio;
        public static double[] ZXScore;
        public static double[] ZYScore;
        public static int ct = 0;
        public static double minDistance;
        public static double currentValKor;

        public static void MainMethodForecatingModel(DateTime sysdate)
        {
            DataTable table = SqlLiteDataBase.LetsQuery($"select idsysres, percproc from systemresources " +
                $"where timesysres between '{sysdate.AddMinutes(-1):yyyy-MM-dd HH:mm:ss.fff}' and '{sysdate:yyyy-MM-dd HH:mm:ss.fff}'");
            try
            {
                NewStory = new int[table.Rows.Count][];
                for (int i = 0; i < NewStory.Length; i++)
                {
                    NewStory[i] = new int[table.Columns.Count];
                    for (int j = 0; j < NewStory[i].Length; j++)
                        NewStory[i][j] = Convert.ToInt32(table.Rows[i][j]);
                }
            }
            catch (Exception)
            {
                return;
            }
            
            ct = 0;
            ComputeParameters(NewStory);
            ComputeFactor(NewStory);
        }

        private static void ComputeParameters(int[][] arr, bool othTable = false)
        {
            sumVal = 0;
            avgVal = 0;
            doubleValSum = 0;

            for (int j = 0; j < arr.Length; j++) sumVal += arr[j][1];
            avgVal = sumVal / arr.Length;

            for (int j = 0; j < arr.Length; j++) doubleValSum += arr[j][1] * arr[j][1];

            if (!othTable)
            {
                dispersionX = 0;
                dispersionX = Math.Sqrt((doubleValSum - (sumVal * sumVal / arr.Length)) / (arr.Length - 1));
                ZXScore = new double[arr.Length];
                for (int j = 0; j < arr.Length; j++) ZXScore[j] = (arr[j][1] - avgVal) / dispersionX;
            }
            else
            {
                dispersionY = 0;
                dispersionY = Math.Sqrt((doubleValSum - (sumVal * sumVal / arr.Length)) / (arr.Length - 1));
                ZYScore = new double[arr.Length];
                for (int j = 0; j < arr.Length; j++) ZYScore[j] = (arr[j][1] - avgVal) / dispersionY;
            }
        }

        private static void ComputeFactor(int[][] arr)
        {
            
            DataTable table = SqlLiteDataBase.LetsQuery($"select idsysres, percproc " +
                $"from systemresources where idsysres < {NewStory[NewStory.Length - 1][0]}");
            ratio = new double[table.Rows.Count - arr.Length];

        next:
            MaybeMaxSimSamp = new int[arr.Length][];
            for (int i = ct; i < table.Rows.Count; i++)
            {
                if (i - ct < MaybeMaxSimSamp.Length)
                {
                    MaybeMaxSimSamp[i - ct] = new int[table.Columns.Count];
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        MaybeMaxSimSamp[i - ct][j] = Convert.ToInt32(table.Rows[i][j]);
                    }
                }
                else
                    break;
            }

            ComputeParameters(MaybeMaxSimSamp, true);

            for (int j = 0; j < ZXScore.Length; j++)
                ratio[ct] += ZXScore[j] * ZYScore[j];

            ratio[ct] /= arr.Length;

            if (Math.Abs(1 - ratio[ct]) == minDistance)
                return;

            if (ct == 0 || Math.Abs(1 - ratio[ct]) < minDistance)
            {
                minDistance = Math.Abs(1 - ratio[ct]);
                currentValKor = ratio[ct];
                MaxSimSampMin = MaybeMaxSimSamp;
            }

            ct++;
            if (ct >= table.Rows.Count - arr.Length)
                return;
            else if (ct < table.Rows.Count - arr.Length)
                goto next;
        }
    }
}

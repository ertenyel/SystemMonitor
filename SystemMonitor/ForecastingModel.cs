using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemMonitor
{
    class ForecastingModel
    {
        public static int[][] NewStory;
        public static int[][] MaximumSimilaritySampling;
        public static double sumVal;
        public static double avgVal;
        public static double doubleValSum;
        public static double dispersionX;
        public static double dispersionY;
        public static double[] ratio;
        public static double[] ZXScore;
        public static double[] ZYScore;
        private static int ct = 0;

        public static void MainMethodForecatingModel(DateTime sysdate)
        {
            DataTable table = SqlLiteDataBase.LetsQuery($"select idsysres, percproc from systemresources where timesysres between '{sysdate.AddHours(-1):yyyy-MM-dd HH:mm:ss.fff}' and '{sysdate:yyyy-MM-dd HH:mm:ss.fff}'");
            NewStory = new int[table.Rows.Count][];
            for (int i = 0; i < NewStory.Length; i++)
            {
                NewStory[i] = new int[table.Columns.Count];
                for (int j = 0; j < NewStory[i].Length; j++)
                    NewStory[i][j] = Convert.ToInt32(table.Rows[i][j]);
            }

            ComputeParameters(NewStory);
            ComputeFactor(NewStory);
        }

        private static void ComputeParameters(int[][] arr, bool othTable = false)
        {
            sumVal = 0;
            avgVal = 0;
            doubleValSum = 0;

            for (int j = 0; j < arr.Length; j++) sumVal += arr[j][1];
            avgVal = sumVal/arr.Length;

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

            //todo: Работает! надо проверить правильные ли значения
            DataTable table = SqlLiteDataBase.LetsQuery($"select idsysres, percproc from systemresources");
            MaximumSimilaritySampling = new int[arr.Length][];
            ratio = new double[arr.Length];

            next:
            for (int i = ct; i < table.Rows.Count; i++)
            {
                if (i - ct < MaximumSimilaritySampling.Length)
                {
                    MaximumSimilaritySampling[i-ct] = new int[table.Columns.Count];
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        MaximumSimilaritySampling[i - ct][j] = Convert.ToInt32(table.Rows[i][j]);
                    }
                }
                else
                    break;
            }

            ComputeParameters(MaximumSimilaritySampling, true);


            for (int j = 0; j < ZXScore.Length; j++)
                ratio[ct] += ZXScore[j] * ZYScore[j];

            ratio[ct] /= arr.Length;
            ct++;
            if (ct >= arr.Length - 1)
                return;
            else if (ct < arr.Length - 1)
                goto next;
        }
    }
}

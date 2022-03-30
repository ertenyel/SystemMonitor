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
        public static int[][] realVal;
        public static double sumVal;
        public static double avgVal;
        public static double sumSquare;
        public static double doubleValSum;
        public static double dispersionX;
        public static double dispersionY;
        public static double[] ratio;
        public static double[] ZXScore;
        public static double[] ZYScore;
        public static int ct = 0;
        public static double minDistance;
        public static double currentValKor;               

        public static void MainMethodForecatingModel(DateTime sysdate, string column, string seltime, string outtable, string id, int min)
        {            
            DataTable table = SqlLiteDataBase.LetsQuery($"select {id}, {column} from {outtable} " +
                $"where {seltime} between '{sysdate.AddSeconds(-1 * min):yyyy-MM-dd HH:mm:ss.fff}' and '{sysdate:yyyy-MM-dd HH:mm:ss.fff}'");
            try
            {
                NewStory = new int[table.Rows.Count][];
                for (int i = 0; i < NewStory.Length; i++)
                {
                    NewStory[i] = new int[table.Columns.Count];
                    for (int j = 0; j < NewStory[i].Length; j++) NewStory[i][j] = Convert.ToInt32(table.Rows[i][j]);
                }
            }
            catch (Exception)
            {
                return;
            }
            
            ct = 0;
            ComputeParameters(NewStory);
            ComputeFactor(NewStory, column, outtable, id);
            BasicSel(MaxSimSampMin, column, id, outtable);
        }

        private static void ComputeParameters(int[][] arr, bool othTable = false)
        {
            sumVal = 0;
            sumSquare = 0;
            avgVal = 0;
            doubleValSum = 0;

            for (int j = 0; j < arr.Length; j++) sumVal += arr[j][1];
            avgVal = sumVal / arr.Length;

            for (int j = 0; j < arr.Length; j++) doubleValSum += arr[j][1] * arr[j][1];

            if (!othTable)
            {
                dispersionX = 0;
                //dispersionX = Math.Sqrt((doubleValSum - (sumVal * sumVal / arr.Length)) / (arr.Length - 1));
                for (int j = 0; j < arr.Length; j++)
                    sumSquare += (avgVal - arr[j][1]) * (avgVal - arr[j][1]);
                dispersionX = sumSquare / Convert.ToDouble(arr.Length - 1);
                ZXScore = new double[arr.Length];
                for (int j = 0; j < arr.Length; j++) ZXScore[j] = (arr[j][1] - avgVal) / Math.Sqrt(dispersionX);
            }
            else
            {
                dispersionY = 0;
                //dispersionY = Math.Sqrt((doubleValSum - (sumVal * sumVal / arr.Length)) / (arr.Length - 1));
                for (int j = 0; j < arr.Length; j++)
                    sumSquare += (avgVal - arr[j][1]) * (avgVal - arr[j][1]);
                dispersionY = sumSquare / Convert.ToDouble(arr.Length - 1);
                ZYScore = new double[arr.Length];
                for (int j = 0; j < arr.Length; j++) ZYScore[j] = (arr[j][1] - avgVal) / Math.Sqrt(dispersionY);
            }
        }

        private static void ComputeFactor(int[][] arr, string column, string outtable, string id)
        {
            
            DataTable table = SqlLiteDataBase.LetsQuery($"select {id}, {column} " +
                $"from {outtable} where {id} < {NewStory[NewStory.Length - 1][0]}");
            ratio = new double[table.Rows.Count - arr.Length];

        next:
            MaybeMaxSimSamp = new int[arr.Length][];
            for (int i = ct; i < table.Rows.Count; i++)
            {
                if (i - ct < MaybeMaxSimSamp.Length)
                {
                    MaybeMaxSimSamp[i - ct] = new int[table.Columns.Count];
                    for (int j = 0; j < table.Columns.Count; j++)
                        MaybeMaxSimSamp[i - ct][j] = Convert.ToInt32(table.Rows[i][j]);
                }
                else
                    break;
            }

            ComputeParameters(MaybeMaxSimSamp, true);

            for (int j = 0; j < ZXScore.Length; j++)
                ratio[ct] += ZXScore[j] * ZYScore[j];

            ratio[ct] /= arr.Length-1;

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

        private static void BasicSel(int[][] MaxSimSampMin, string column, string id, string tableName)
        {
            DataTable table = SqlLiteDataBase.LetsQuery($"select {id}, {column} from {tableName} where {id} " +
                $"between {MaxSimSampMin[0][0]} and {MaxSimSampMin[MaxSimSampMin.Length - 1][0]+15}");
            basicSelect = new int[table.Rows.Count][];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                basicSelect[i] = new int[table.Columns.Count];
                for (int j = 0; j < table.Columns.Count; j++)
                    basicSelect[i][j] = Convert.ToInt32(table.Rows[i][j]);
            }
            Forecast(NewStory, column, id, tableName);
        }

        private static void Forecast(int[][] NewStory, string column, string id, string tableName)
        {
            DataTable table = SqlLiteDataBase.LetsQuery($"select {id}, {column} from {tableName} where {id} " +
                $"between {NewStory[0][0]} and {NewStory[NewStory.Length - 1][0] + 15}");
            realVal = new int[table.Rows.Count][];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                realVal[i] = new int[table.Columns.Count];
                for (int j = 0; j < table.Columns.Count; j++)
                    realVal[i][j] = Convert.ToInt32(table.Rows[i][j]);
            }
        }
    }
}

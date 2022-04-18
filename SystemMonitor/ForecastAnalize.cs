using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemMonitor
{
    class ForecastAnalize
    {
        private static double factorAt = 0.35;
        private static double factorBt = 0.01;
        private static double factorCt = 0.01;
        public static double factorNewBt = 0.01;
        public static double factorNewCt = 0.01;
        public static double[][] forecast;
        public static double rmse = 10000000;
        private static double avgRmse;
        private static double[] tempRmse;
        private static double[][] At;
        private static double[][] Bt;
        private static double[][] Ct;
        private static double[][] NewAt;
        private static double[][] NewBt;
        private static double[][] NewCt;
        private static int cnt;


        public static void HoltsMethod(double[][] inputArray)
        {
            At = new double[inputArray.Length][];
            Bt = new double[inputArray.Length][];
            for (int i = 0; i < Values.resultMaxSel.Length; i++)
            {
                At[i] = new double[inputArray[i].Length];
                Bt[i] = new double[inputArray[i].Length];
                for (int j = 0; j < inputArray[i].Length; j++)
                {
                    if (i == 0)
                    {
                        At[i][j] = inputArray[i][j];
                        Bt[i][j] = 0;
                    }
                    else
                    {
                        At[i][j] = factorAt * inputArray[i][j] + (1 - factorAt) * (At[i - 1][j] - Bt[i - 1][j]);
                        Bt[i][j] = factorBt * (At[i][j] - At[i - 1][j]) + (1 - factorBt) * Bt[i - 1][j];
                    }
                }
            }

            forecast = new double[3][];
            for (int i = 0; i < forecast.Length; i++)
            {
                forecast[i] = new double[inputArray[i].Length];
                for (int j = 0; j < inputArray[i].Length; j++)
                {
                    forecast[i][j] = At[At.Length - 1][j] + (i + 1) * Bt[Bt.Length - 1][j];
                }
            }
        }

        public static void InitializeValuesTests(DateTime startMaxSel, DateTime endMaxSel, DateTime startNewStory, DateTime endNewStory, string table)
        {
            string columns = "";
            string time = "";

            if (table == "Systemresources")
            {
                columns = "strftime('%Y-%m-%d %H:%M', timesysres), avg(percproc)/avg(numberprocess), avg(percdisc)/avg(numberprocess), avg(percmemory)/avg(numberprocess)";
                time = "timesysres";
            }
            else if (table == "Network")
            {
                columns = "strftime('%Y-%m-%d %H:%M', timenetwork), avg(receivedbytes)/avg(connectionscount), avg(sentbyte)/avg(connectionscount)";
                time = "timenetwork";
            }

            DataTable tableNewStory = SqlLiteDataBase.LetsQuery($"select {columns}" +
                $"from {table} where {time} between '{startNewStory.AddMinutes(-3):yyyy-MM-dd HH:mm:ss.fff}' and '{endNewStory.AddMinutes(-2):yyyy-MM-dd HH:mm:ss.fff}'" +
                $"group by strftime('%Y-%m-%d %H:%M', {time})");


            DataTable tableMaxSel = SqlLiteDataBase.LetsQuery($"select {columns}" +
                $"from {table} where {time} between '{startMaxSel.AddMinutes(-3):yyyy-MM-dd HH:mm:ss.fff}' and '{endMaxSel.AddMinutes(-2):yyyy-MM-dd HH:mm:ss.fff}'" +
                $"group by strftime('%Y-%m-%d %H:%M', {time})");

            Values.testNewStory = new double[tableNewStory.Rows.Count][];
            Values.dateTimeTestNewStory = new DateTime[tableNewStory.Rows.Count];
            for (int i = 0; i < tableNewStory.Rows.Count; i++)
            {
                Values.testNewStory[i] = new double[tableNewStory.Columns.Count - 1];
                for (int j = 0; j < tableNewStory.Columns.Count; j++)
                {
                    if (j != 0) Values.testNewStory[i][j - 1] = Convert.ToDouble(tableNewStory.Rows[i][j]);
                    else Values.dateTimeTestNewStory[i] = Convert.ToDateTime(tableNewStory.Rows[i][j]);
                }
            }

            Values.testMaxSel = new double[tableMaxSel.Rows.Count][];
            Values.dateTimeTestMaxSel = new DateTime[tableMaxSel.Rows.Count];
            for (int i = 0; i < tableMaxSel.Rows.Count; i++)
            {
                Values.testMaxSel[i] = new double[tableMaxSel.Columns.Count - 1];
                for (int j = 0; j < tableMaxSel.Columns.Count; j++)
                {
                    if (j != 0) Values.testMaxSel[i][j - 1] = Convert.ToDouble(tableMaxSel.Rows[i][j]);
                    else Values.dateTimeTestMaxSel[i] = Convert.ToDateTime(tableMaxSel.Rows[i][j]);
                }
            }            
        }

        public static void ComputeParamteres(double[][] tempMaxSelSamp, double[][] tempNewStory, double[][] MaxSelSamp, double[][] NewStory)
        {
            // Расчет прогноза по выборке 57 из 60 и 3 значения из них сравнить с прогнозными, выбрать оценку и рассчитать все 60 значений
            double[][] realVal = new double[3][];
            for (int i = 0; i < realVal.Length; i++)
            {
                realVal[i] = new double[NewStory[i].Length];
                for (int j = 0; j < realVal[i].Length; j++)
                    realVal[i][j] = NewStory[NewStory.Length - 3 + i][j];
            }

            while (factorBt <= 0.99)
            {
                factorCt = 0.01;
                while (factorCt <= 0.99)
                {
                    HoltsWintersMethod(tempMaxSelSamp, tempNewStory, factorBt, factorCt);
                    ComputeRmse(realVal);
                    factorCt += 0.01;                    
                    cnt++;
                }
                factorBt += 0.01;                
            }

            HoltsWintersMethod(MaxSelSamp, NewStory, factorNewBt, factorNewCt);            
        }

        private static void ComputeRmse(double[][] realVal)
        {
            avgRmse = 0;
            tempRmse = new double[realVal[0].Length];
            for (int i = 0; i < realVal[0].Length; i++)
            {                
                for (int j = 0; j < realVal.Length; j++)
                {
                    tempRmse[i] += (realVal[j][i] - forecast[j][i]) * (realVal[j][i] - forecast[j][i]);
                }
                tempRmse[i] = Math.Sqrt(tempRmse[i] / realVal[i].Length);
            }

            for (int i = 0; i < tempRmse.Length; i++)
            {
                avgRmse += tempRmse[i];
            }
            avgRmse /= tempRmse.Length;

            if (avgRmse < rmse)
            {
                factorNewBt = factorBt;
                factorNewCt = factorCt;
                rmse = avgRmse;
            }
        }

        public static void HoltsWintersMethod(double[][] MaxSelSamp, double[][] NewStory, double factNewBt, double factNewCt)
        {
            At = new double[MaxSelSamp.Length][];
            Bt = new double[MaxSelSamp.Length][];
            Ct = new double[MaxSelSamp.Length][];
            for (int i = 0; i < MaxSelSamp.Length; i++)
            {
                At[i] = new double[MaxSelSamp[i].Length];
                Bt[i] = new double[MaxSelSamp[i].Length];
                Ct[i] = new double[MaxSelSamp[i].Length];
                for (int j = 0; j < MaxSelSamp[i].Length; j++)
                {
                    if (i == 0)
                    {
                        At[i][j] = MaxSelSamp[i][j];
                        Bt[i][j] = 0.0;
                        Ct[i][j] = MaxSelSamp[i][j] / At[i][j];
                    }
                    else
                    {
                        At[i][j] = factorAt * (MaxSelSamp[i][j] / 1) + (1 - factorAt) * (At[i - 1][j] + Bt[i - 1][j]);
                        Bt[i][j] = factNewBt * (At[i][j] - At[i - 1][j]) + (1 - factNewBt) * Bt[i - 1][j];
                        Ct[i][j] = MaxSelSamp[i][j] / At[i][j];
                    }
                }
            }

            NewAt = new double[NewStory.Length][];
            NewBt = new double[NewStory.Length][];
            NewCt = new double[NewStory.Length][];
            for (int i = 0; i < NewStory.Length; i++)
            {
                NewAt[i] = new double[NewStory[i].Length];
                NewBt[i] = new double[NewStory[i].Length];
                NewCt[i] = new double[NewStory[i].Length];
                for (int j = 0; j < NewStory[i].Length; j++)
                {
                    if (i == 0)
                    {
                        NewAt[i][j] = factorAt * (NewStory[i][j] / Ct[i][j]) + (1 - factorAt) * (At[At.Length - 1][j] + Bt[Bt.Length - 1][j]);
                        NewBt[i][j] = factNewBt * (NewAt[i][j] - At[At.Length - 1][j]) + (1 - factNewBt) * Bt[Bt.Length - 1][j];
                        NewCt[i][j] = factNewCt * (NewStory[i][j] / NewAt[i][j]) + (1 - factNewCt) * Ct[i][j];
                    }
                    else
                    {
                        NewAt[i][j] = factorAt * (NewStory[i][j] / Ct[i][j]) + (1 - factorAt) * (NewAt[i - 1][j] + NewBt[i - 1][j]);
                        NewBt[i][j] = factNewBt * (NewAt[i][j] - NewAt[i - 1][j]) + (1 - factNewBt) * NewBt[i - 1][j];
                        NewCt[i][j] = factNewCt * (NewStory[i][j] / NewAt[i][j]) + (1 - factNewCt) * Ct[i][j];
                    }
                }
            }

            forecast = new double[3][];
            for (int i = 0; i < forecast.Length; i++)
            {
                forecast[i] = new double[NewStory[i].Length];
                for (int j = 0; j < NewStory[i].Length; j++)
                    forecast[i][j] = (NewAt[NewAt.Length - 1][j] + ((i + 1) * NewBt[NewBt.Length - 1][j])) * Ct[i][j];
            }
        }
    }
}

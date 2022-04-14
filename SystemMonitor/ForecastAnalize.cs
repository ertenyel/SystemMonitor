using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemMonitor
{
    class ForecastAnalize
    {
        private static double factorAt = 0.35;
        private static double factorBt = 0.1;
        private static double factorCt = 0.1;
        public static double[][] forecast;
        private static double[][] At;
        private static double[][] Bt;
        private static double[][] Ct;
        private static double[][] NewAt;
        private static double[][] NewBt;
        private static double[][] NewCt;


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

        public static void HoltsWintersMethod(double[][] MaxSelSamp, double[][] NewStory)
        {
            // Расчет прогноза по выборке 57 из 60 и 3 значения из них сравнить с прогнозными, выбрать оценку и рассчитать все 60 значений

            double[][] tempMaxSelSamp = new double[MaxSelSamp.Length-3][];
            double[][] tempNewStory = new double[NewStory.Length - 3][];

            for (int i = 0; i < tempMaxSelSamp.Length; i++)
            {
                tempMaxSelSamp[i] = new double[MaxSelSamp[i].Length];
                tempNewStory[i] = new double[NewStory[i].Length];
                for (int j = 0; j < tempMaxSelSamp[i].Length; j++)
                {

                }
            }

            while (factorBt <= 0.99)
            {
                while (factorCt <= 0.99)
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
                                Bt[i][j] = 0;
                                Ct[i][j] = MaxSelSamp[i][j] / At[i][j];
                            }
                            else
                            {
                                At[i][j] = factorAt * (MaxSelSamp[i][j] / 1) + (1 - factorAt) * (At[i - 1][j] + Bt[i - 1][j]);
                                Bt[i][j] = factorBt * (At[i][j] - At[i - 1][j]) + (1 - factorBt) * Bt[i - 1][j];
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
                                NewBt[i][j] = factorBt * (NewAt[i][j] - At[At.Length - 1][j]) + (1 - factorBt) * Bt[Bt.Length - 1][j];
                                NewCt[i][j] = factorCt * (NewStory[i][j] / NewAt[i][j]) + (1 - factorCt) * Ct[i][j];
                            }
                            else
                            {
                                NewAt[i][j] = factorAt * (NewStory[i][j] / Ct[i][j]) + (1 - factorAt) * (NewAt[i - 1][j] + NewBt[i - 1][j]);
                                NewBt[i][j] = factorBt * (NewAt[i][j] - NewAt[i - 1][j]) + (1 - factorBt) * NewBt[i - 1][j];
                                NewCt[i][j] = factorCt * (NewStory[i][j] / NewAt[i][j]) + (1 - factorCt) * Ct[i][j];
                            }
                        }
                    }

                    forecast = new double[3][];
                    for (int i = 0; i < forecast.Length; i++)
                    {
                        forecast[i] = new double[NewStory[i].Length];
                        for (int j = 0; j < NewStory[i].Length; j++)
                            forecast[i][j] = (NewAt[NewAt.Length - 1][j] + (i + 1) * NewBt[NewBt.Length - 1][j]) * NewCt[i][j];
                    }



                    factorCt += 0.1;
                }
                factorBt += 0.1;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemMonitor
{
    class HoltsMethod
    {
        private static double factorAt = 0.25;
        private static double factorBt = 0.25;
        public static double[][] forecast;
        private static double[][] At;
        private static double[][] Bt;


        public static void InitialiizeSelected(double[][] inputArray)
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
    }
}

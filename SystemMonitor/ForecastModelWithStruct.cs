﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static double[][] resultMaxSel;
        public static DateTime[] dateTimeResultMaxSel;
    }
    class ForecastModelWithStruct
    {
        private static double[][] ZMarksX;
        private static double[][] ZMarksY;
        private static double[] tempFactor;
        private static double factor;
        private static double maxFactor;
        private static int ct;

        public static void InitializeValues(DataTable tableNewStory, DataTable tableMaxSel)
        {
            Values.newStory = new double[tableNewStory.Rows.Count][];
            Values.dateTimeNewStory = new DateTime[tableNewStory.Rows.Count];
            for (int i = 0; i < tableNewStory.Rows.Count; i++)
            {
                Values.newStory[i] = new double[tableNewStory.Columns.Count-1];
                for (int j = 0; j < tableNewStory.Columns.Count; j++)
                {
                    if (j == 0)
                        Values.dateTimeNewStory[i] = Convert.ToDateTime(tableNewStory.Rows[i][j]);
                    else
                        Values.newStory[i][j-1] = Convert.ToDouble(tableNewStory.Rows[i][j]);
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
            ComputeParameters(Values.newStory, true);
            SearchMaxSel(Values.maxSel, Values.newStory.Length);
            return;
        }
        private static void ComputeParameters(double[][] inputArray, bool XorY = false)
        {
            double[] avgVal =  new double[inputArray[0].Length];
            double[] dispersion = new double[inputArray[0].Length];

            for (int i = 0; i < inputArray[i].Length; i++)
            {                
                for (int j = 0; j < inputArray.Length; j++)
                    avgVal[i] += inputArray[j][i];
                avgVal[i] /= inputArray.Length;
            }

            for (int i = 0; i < inputArray[i].Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                    dispersion[i] += (avgVal[i] - inputArray[j][i])*(avgVal[i] - inputArray[j][i]);
                dispersion[i] = Math.Sqrt(dispersion[i]/(inputArray.Length-1));
            }

            if (XorY)
            {
                ZMarksX = new double[inputArray.Length][];
                for (int i = 0; i < inputArray.Length; i++)
                {
                    ZMarksX[i] = new double[inputArray[i].Length];
                    for (int j = 0; j < inputArray[i].Length; j++)
                        ZMarksX[i][j] = (inputArray[i][j] - avgVal[j]) / dispersion[j];
                }
            }
            else
            {
                ZMarksY = new double[inputArray.Length][];
                for (int i = 0; i < inputArray.Length; i++)
                {
                    ZMarksY[i] = new double[inputArray[i].Length];
                    for (int j = 0; j < inputArray[i].Length; j++)
                        ZMarksY[i][j] = (inputArray[i][j] - avgVal[j]) / dispersion[j];
                }

                tempFactor = new double[inputArray[0].Length];
                for (int i = 0; i < inputArray[i].Length; i++)
                {
                    for (int j = 0; j < inputArray.Length; j++)
                        tempFactor[i] += ZMarksX[j][i] * ZMarksY[j][i];
                    tempFactor[i] /= inputArray.Length - 1;

                    factor += tempFactor[i];
                }

                if (factor > maxFactor)
                {
                    maxFactor = factor;
                    Values.resultMaxSel = Values.maybeMaxSel;
                    Values.dateTimeResultMaxSel = Values.dateTimeMaybeMaxSel;
                }
                ct++;
                if (ct == Values.maxSel.Length - Values.newStory.Length-1) return;
                SearchMaxSel(Values.maxSel, Values.newStory.Length);
            }
        }
        private static void SearchMaxSel(double[][] inputArray, int windLength)
        {
            Values.maybeMaxSel = new double[windLength][];
            Values.dateTimeMaybeMaxSel = new DateTime[windLength];            

            for (int i = 0; i < windLength; i++)
            {
                Values.dateTimeMaybeMaxSel[i] = Values.dateTimeMaxSel[i+ct];
                Values.maybeMaxSel[i] = new double[inputArray[i].Length];
                for (int j = 0; j < inputArray[i].Length; j++)
                    Values.maybeMaxSel[i][j] = inputArray[i+ct][j];
            }            
            ComputeParameters(Values.maybeMaxSel);
        }
    }
}
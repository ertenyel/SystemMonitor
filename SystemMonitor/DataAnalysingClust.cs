using System;
using System.Data;
using System.Windows.Forms;

namespace SystemMonitor
{
    class DataAnalysingClust
    {
        public static int ct;
        public double x;
        public double y;
        private string[] attributes;
        public static double[][] rawData;
        public static int numClusters;
        public static double[][] centroids;
        public double[] outlier;
        public static int[] clustering;
        public double[][] normalizeArr;

        public void MainMethodOfAnalysis(int parameters, int entries, bool countEntry = false)
        {
            try
            {
                if (countEntry) selectedTable(parameters, entries, true);
                if (!countEntry) selectedTable(parameters, entries);
                int numAttributes = attributes.Length;
                numClusters = 5;
                int maxCount = 40;
                clustering = Cluster(rawData, numClusters, numAttributes, maxCount);
                outlier = Outlier(rawData, clustering, numClusters, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectedTable(int parameters, int entries, bool countEntry = false)
        {
            DataTable dataTable = new DataTable();

            if (countEntry)
            {
                if (parameters == 0) dataTable = SqlLiteDataBase.LetsQuery($"select numberprocess, percproc, percdisc, percmemory from systemresources");
                else if (parameters == 1) dataTable = SqlLiteDataBase.LetsQuery($"select connectionscount, receivedbytes, sentbyte from network where idnetwork");
            }
            else
            {
                if (parameters == 0) dataTable = SqlLiteDataBase.LetsQuery($"select numberprocess, percproc, percdisc, percmemory from systemresources where idsysres < {entries}");
                else if (parameters == 1) dataTable = SqlLiteDataBase.LetsQuery($"select connectionscount, receivedbytes, sentbyte from network where idnetwork < {entries}");
            }
            Normalize(dataTable, parameters);
            attributes = new string[dataTable.Columns.Count];
            for (int i = 0; i < dataTable.Columns.Count; i++)
                attributes[i] = dataTable.Columns[i].ColumnName;
            rawData = new double[dataTable.Rows.Count][];
            fillToArray(dataTable, parameters);
        }

        private void Normalize(DataTable dataTable, int parameters)
        {
            normalizeArr = new double[dataTable.Columns.Count][];
            for (int i = 0; i < normalizeArr.Length; i++)
            {
                normalizeArr[i] = new double[2];
                for (int k = 0; k < dataTable.Rows.Count; k++)
                {
                    if (normalizeArr[i][0] > Convert.ToDouble(dataTable.Rows[k][i]) || k == 0) normalizeArr[i][0] = Convert.ToDouble(dataTable.Rows[k][i]);
                    if (normalizeArr[i][1] < Convert.ToDouble(dataTable.Rows[k][i]) || k == 0) normalizeArr[i][1] = Convert.ToDouble(dataTable.Rows[k][i]);
                }
            }
        }

        private void fillToArray(DataTable dataTable, int parameters)
        {
            if (parameters == 0)
            {
                for (int i = 0; i < rawData.Length; i++)
                {
                    rawData[i] = new double[dataTable.Columns.Count];
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        if (j == 0)
                        {
                            double val = Convert.ToDouble(dataTable.Rows[i][j]);
                            rawData[i][j] = Math.Round((val - normalizeArr[j][0]) / (normalizeArr[j][1] - normalizeArr[j][0]) * 100);
                        }
                        else
                        {
                            double val = Convert.ToDouble(dataTable.Rows[i][j]);
                            rawData[i][j] = val;
                        }
                    }
                }
            }
            else if (parameters == 1)
            {
                for (int i = 0; i < rawData.Length; i++)
                {
                    rawData[i] = new double[dataTable.Columns.Count];
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        double val = Convert.ToDouble(dataTable.Rows[i][j]);
                        rawData[i][j] = Math.Round((val - normalizeArr[j][0]) / (normalizeArr[j][1] - normalizeArr[j][0]) * 100);
                    }
                }
            }
        }

        private static void UpdateMeans(double[][] rawData, int[] clustering, double[][] means)
        {
            int numClusters = means.Length;
            for (int k = 0; k < means.Length; ++k)
                for (int j = 0; j < means[k].Length; ++j)
                    means[k][j] = 0.0;
            int[] clusterCounts = new int[numClusters];
            for (int i = 0; i < rawData.Length; ++i)
            {
                int cluster = clustering[i];
                ++clusterCounts[cluster];
                for (int j = 0; j < rawData[i].Length; ++j)
                    means[cluster][j] += rawData[i][j];
            }
            for (int k = 0; k < means.Length; ++k)
                for (int j = 0; j < means[k].Length; ++j)
                    means[k][j] /= clusterCounts[k]; // опасность
            return;
        }

        private static double[][] Allocate(int numClusters, int numAttributes)
        {
            double[][] result = new double[numClusters][];
            for (int k = 0; k < numClusters; ++k)
                result[k] = new double[numAttributes];
            return result;
        }

        private static double[] ComputeCentroid(double[][] rawData, int[] clustering, int cluster, double[][] means)
        {
            int numAttributes = means[0].Length;
            double[] centroid = new double[numAttributes];
            double minDist = double.MaxValue;
            for (int i = 0; i < rawData.Length; ++i) // Перебираем каждую последовательность данных
            {
                int c = clustering[i];
                if (c != cluster) continue;
                double currDist = Distance(rawData[i], means[cluster]);
                if (currDist < minDist)
                {
                    minDist = currDist;
                    for (int j = 0; j < centroid.Length; ++j)
                        centroid[j] = rawData[i][j];
                }
            }
            return centroid;
        }

        private static void UpdateCentroids(double[][] rawData, int[] clustering, double[][] means, double[][] centroids)
        {
            for (int k = 0; k < centroids.Length; ++k)
            {
                double[] centroid = ComputeCentroid(rawData, clustering, k, means);
                centroids[k] = centroid;
            }
        }


        private static double Distance(double[] tuple, double[] vector)
        {
            // Квадрат евклидова расстояния
            //todo: Эксперименты с метриками
            /*
            double sumSquaredDiffs = 0.0;
            for (int j = 0; j < tuple.Length; ++j)
                sumSquaredDiffs += Math.Pow((tuple[j] - vector[j]), 2);
            return sumSquaredDiffs; 
            */
            //Расстояние городсих кварталов
            /*
            double sumSquaredDiffs = 0.0;
            for (int j = 0; j < tuple.Length; ++j)
                sumSquaredDiffs += Math.Abs(tuple[j] - vector[j]);
            return sumSquaredDiffs; */

            //Евклидово расстояние 
            
            double sumSquaredDiffs = 0.0;
            for (int j = 0; j < tuple.Length; ++j)
                sumSquaredDiffs += Math.Pow((tuple[j] - vector[j]), 2);
            return Math.Sqrt(sumSquaredDiffs);
        }

        static bool Assign(double[][] rawData, int[] clustering, double[][] centroids)
        {
            int numClusters = centroids.Length;
            bool changed = false;
            double[] distances = new double[numClusters];
            for (int i = 0; i < rawData.Length; ++i)
            {
                for (int k = 0; k < numClusters; ++k)
                    distances[k] = Distance(rawData[i], centroids[k]);
                int newCluster = MinIndex(distances);
                if (newCluster != clustering[i])
                {
                    changed = true;
                    clustering[i] = newCluster;
                }
            }
            return changed;
        }

        private static int MinIndex(double[] distances)
        {
            int indexOfMin = 0;
            double smallDist = distances[0];
            for (int k = 0; k < distances.Length; ++k)
            {
                if (distances[k] < smallDist)
                {
                    smallDist = distances[k]; indexOfMin = k;
                }
            }
            return indexOfMin;
        }

        private static int[] Cluster(double[][] rawData, int numClusters, int numAttributes, int maxCount)
        {
            bool changed = true;
            ct = 0;
            int numTuples = rawData.Length;
            int[] clustering = InitClustering(numTuples, numClusters, 0);
            double[][] means = Allocate(numClusters, numAttributes);
            centroids = Allocate(numClusters, numAttributes);
            UpdateMeans(rawData, clustering, means);
            UpdateCentroids(rawData, clustering, means, centroids);
            while (changed == true && ct < maxCount)
            {
                ++ct;
                changed = Assign(rawData, clustering, centroids);
                UpdateMeans(rawData, clustering, means);
                UpdateCentroids(rawData, clustering, means, centroids);
            }
            return clustering;
        }

        private static int[] InitClustering(int numTuples, int numClusters, int randomSeed)
        {
            Random random = new Random(randomSeed);
            int[] clustering = new int[numTuples];
            for (int i = 0; i < numClusters; ++i)
                clustering[i] = i;
            for (int i = numClusters; i < clustering.Length; ++i)
                clustering[i] = random.Next(0, numClusters);
            return clustering;
        }

        private static double[] Outlier(double[][] rawData, int[] clustering, int numClusters, int cluster)
        {
            int numAttributes = rawData[0].Length;
            double[] outlier = new double[numAttributes];
            double maxDist = 0.0;
            double[][] means = Allocate(numClusters, numAttributes);
            double[][] centroids = Allocate(numClusters, numAttributes);
            UpdateMeans(rawData, clustering, means);
            UpdateCentroids(rawData, clustering, means, centroids);
            for (int i = 0; i < rawData.Length; ++i)
            {
                int c = clustering[i];
                if (c != cluster) continue;
                double dist = Distance(rawData[i], centroids[cluster]);
                if (dist > maxDist)
                {
                    maxDist = dist;
                    Array.Copy(rawData[i], outlier, rawData[i].Length);
                }
            }
            return outlier;
        }
    }
}

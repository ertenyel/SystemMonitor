using System;
using System.Data.SQLite;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemMonitor
{
    class SqlLiteDataBase
    {
        private static string dbFileName = "sample.sqlite";
        private static string ds;
        private static SQLiteConnection m_dbConn;
        private static SQLiteCommand m_sqlCmd;
        public static string SqlConnect()
        {
            if (!File.Exists(dbFileName))
                MessageBox.Show("Please, create DB and blank table (Push \"Create\" button)");

            try
            {
                m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                m_dbConn.Open();
                m_sqlCmd.Connection = m_dbConn;

                return "Connected";
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return "Disconnected";
            }
        }

        public static string SqlCreateSysRes()
        {
            m_dbConn = new SQLiteConnection();
            m_sqlCmd = new SQLiteCommand();

            if (!File.Exists(dbFileName))
                SQLiteConnection.CreateFile(dbFileName);

            try
            {
                m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                m_dbConn.Open();
                m_sqlCmd.Connection = m_dbConn;                
                m_sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS SystemResources (idSysRes INTEGER PRIMARY KEY AUTOINCREMENT, timeSysRes TEXT, " +
                    "numberprocess INTEGER, percproc INTEGER, percdisc INTEGER, percmemory INTEGER)";
                m_sqlCmd.ExecuteNonQuery();

                return "Connected";
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return "Disconnected";
            }
        }

        public static string SqlCreateSecurity()
        {
            m_dbConn = new SQLiteConnection();
            m_sqlCmd = new SQLiteCommand();

            if (!File.Exists(dbFileName))
                SQLiteConnection.CreateFile(dbFileName);

            try
            {
                m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                m_dbConn.Open();
                m_sqlCmd.Connection = m_dbConn;
                m_sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS Security (idSecurity INTEGER PRIMARY KEY AUTOINCREMENT, timeSecurity TEXT, entryType TEXT)";
                m_sqlCmd.ExecuteNonQuery();

                return "Connected";
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return "Disconnected";
            }
        }

        public static string SqlDeleteSysRes()
        {
            m_dbConn = new SQLiteConnection();
            m_sqlCmd = new SQLiteCommand();

            if (!File.Exists(dbFileName))
                SQLiteConnection.CreateFile(dbFileName);

            try
            {
                m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                m_dbConn.Open();
                m_sqlCmd.Connection = m_dbConn;
                m_sqlCmd.CommandText = "DROP TABLE IF EXISTS SystemResources";
                m_sqlCmd.ExecuteNonQuery();

                return "Disconnected";
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return "Disconnected";
            }
        }

        public static string SqlDeleteSecurity()
        {
            m_dbConn = new SQLiteConnection();
            m_sqlCmd = new SQLiteCommand();

            if (!File.Exists(dbFileName))
                SQLiteConnection.CreateFile(dbFileName);

            try
            {
                m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                m_dbConn.Open();
                m_sqlCmd.Connection = m_dbConn;
                m_sqlCmd.CommandText = "DROP TABLE IF EXISTS Security";
                m_sqlCmd.ExecuteNonQuery();

                return "Disconnected";
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return "Disconnected";
            }
        }

        public static DataTable SqlReadAllSysRes()
        {
            DataTable dTable = new DataTable();
            String sqlQuery;

            if (m_dbConn.State != ConnectionState.Open)
            {
                MessageBox.Show("Open connection with database");
                return null;
            }

            try
            {
                sqlQuery = "SELECT * FROM SystemResources";
                var adapter = new SQLiteDataAdapter(sqlQuery, m_dbConn);
                adapter.Fill(dTable);

                if (dTable.Rows.Count > 0)
                    return dTable;
                else
                {
                    MessageBox.Show("Database is empty");
                    return null;
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        public static DataTable SqlReadAllSecurity()
        {
            DataTable dTable = new DataTable();
            String sqlQuery;

            if (m_dbConn.State != ConnectionState.Open)
            {
                MessageBox.Show("Open connection with database");
                return null;
            }

            try
            {
                sqlQuery = "SELECT * FROM Security";
                var adapter = new SQLiteDataAdapter(sqlQuery, m_dbConn);
                adapter.Fill(dTable);

                if (dTable.Rows.Count > 0)
                    return dTable;
                else
                {
                    MessageBox.Show("Database is empty");
                    return null;
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        public static string SqlAddSysRes(int NumberOfProcess, int percProc, int percDisc, int percMemory)
        {

            if (m_dbConn.State != ConnectionState.Open)
            {
                MessageBox.Show("Open connection with database");
                return "";
            }

            try
            {
                m_sqlCmd.CommandText = "INSERT INTO SystemResources ('time','numberprocess','percproc','percdisc','percmemory') " +
                    "values ('" + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + "','" + NumberOfProcess + "','" + percProc + "','" + percDisc + "','" + percMemory + "')";

                m_sqlCmd.ExecuteNonQuery();
                return "Successful data recording";
            }
            catch (SQLiteException ex)
            {
                return "Error: " + ex.Message;
            }
        }

        public static string SqlAddSecurity(string timeWritten, string audit)
        {

            if (m_dbConn.State != ConnectionState.Open)
            {
                MessageBox.Show("Open connection with database");
                return "";
            }

            try
            {
                m_sqlCmd.CommandText = "INSERT INTO Security ('timeSecurity','entryType') values ('" + timeWritten + "','" + audit + "')";

                m_sqlCmd.ExecuteNonQuery();
                return "Successful data recording";
            }
            catch (SQLiteException ex)
            {
                return "Error: " + ex.Message;
            }
        }
    }
}

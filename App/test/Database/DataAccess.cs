using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;


namespace Database 
{
    public class DataAccess 
    {
        
        public static string connectionString = @"Data Source = C:\Users\Rayen\Source\Repos\team-07\Lastenheft Dateien\Test für Pflichtenheft\Database\ChatAppDB.db; Version=3;New=False;Compress=True";

        static SQLiteConnection connection = null;
        public static SQLiteConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new SQLiteConnection(connectionString);
                    connection.Open();

                    return connection;
                }
                else if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                    return connection;
                }
                else
                {
                    return connection;
                }
            }
        }

        public static DataSet GetDataSet(string sql)
        {
            SQLiteCommand cmd = new SQLiteCommand(sql, connection);
            SQLiteDataAdapter adp = new SQLiteDataAdapter(cmd);

            DataSet ds = new DataSet();
            adp.Fill(ds);
            Connection.Close();

            return ds;
        }

        public static DataTable GetDataTable(string sql)
        {
            DataSet ds = GetDataSet(sql);

            if (ds.Tables.Count >0)
            {
                return ds.Tables[0];
            }
            return null;
        }

        public static int ExecuteSQL(string sql)
        {
            SQLiteCommand cmd = new SQLiteCommand(sql, Connection);
            return cmd.ExecuteNonQuery();
        }
      
        public static int ExecuteQuery (string txtQuery)
        {
            SQLiteCommand cmd = new SQLiteCommand(txtQuery, Connection);
            cmd.CommandText = txtQuery;
            return cmd.ExecuteNonQuery();
        }
      
    }
}

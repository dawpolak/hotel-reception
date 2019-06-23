using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace HotelReception
{
    public class DBConnection
    {
        private static DBConnection instance;
        private static MySqlConnection conn;
        public static DBConnection Instance
        {

            get
            {
                return instance ?? (instance = new DBConnection());
            }
        }
        public bool IsConnected
        {
            get
            {
                try
                {
                    conn.Open();
                    bool result = conn.Ping();
                    conn.Close();
                    return result;
                }
                catch
                {
                    return false;
                }
            }
        }

        private DBConnection()
        {
            MySqlConnectionStringBuilder connStrBuilder = new MySqlConnectionStringBuilder();
            connStrBuilder.Port = 3306;
            connStrBuilder.Server = "localhost";
            connStrBuilder.UserID = "root";
            connStrBuilder.Password = "root";
            connStrBuilder.Database = "hotel";
            conn = new MySqlConnection(connStrBuilder.ToString());
        }

        public DataTable ExecuteQuery(string sqlQuery)
        {
            DataTable data = new DataTable();
            try
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery.Replace('\'', '"'), conn);
                adapter.Fill(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return data;
        }
        public int ExecuteNonQuery(string sqlQuery)
        {
            int affectedRows = 0;
            try
            {
                conn.Open();
                using (MySqlCommand command = new MySqlCommand(sqlQuery.Replace('\'', '"'), conn))
                {
                    affectedRows = command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return affectedRows;
        }
    }
}

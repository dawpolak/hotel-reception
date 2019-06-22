using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                return conn.Ping();
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

        public void ExecuteQuery()
        {
                try
                {
                    conn.Open();
                    //execute query here
                    conn.Close();
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
        }
    }
}

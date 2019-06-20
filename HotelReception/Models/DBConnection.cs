using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HotelReception
{
    class DBConnection
    {
        private static DBConnection instance;
        public static DBConnection Instance
        {

            get
            {
                return instance ?? (instance = new DBConnection());
            }
        }

        private DBConnection() { }

        public void ExecuteCommand(uint port, string server, string user, string password, string database)
        {
            MySqlConnectionStringBuilder connStrB = new MySqlConnectionStringBuilder();

            connStrB.Port = port;
            connStrB.Server = server;
            connStrB.UserID = user;
            connStrB.Password = password;
            connStrB.Database = database;


            // int? x;

            using (MySqlConnection conn = new MySqlConnection(connStrB.ToString()))
            {
                try
                {
                    conn.Open();
                    /*using (MySqlCommand command = new MySqlCommand("SELECT * FROM `users`", conn))
                    {
                        using (var dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                var x = dataReader["fname"];
                                Console.WriteLine(x);
                            }
                        }
                    }*/
                    conn.Close();
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace HotelReception
{
    class Model
    {
        DBConnection database = DBConnection.Instance;
        public string UserName { get; set; }
        public bool Admin { get; set; }

        //do modelu maja dostep oba formy, wiec jak pierwszy wrzuci dane z logowania tutaj to drugi moze na nich pracowac
        public bool SetDatabaseAccess()
        {
            //polaczenie z baza
            //jesli sie udalo zwraca true
            return true;
        }

        #region FormLogin
        public bool Login(string login,string password)
        {
            //sprawdzenie danych logowania
            //jesli sie udalo zwraca true
            if (login == "admin" && password == "admin")
            {
                Console.WriteLine(database.IsConnected);
                UserName = "Imie Nazwisko";
                Admin = true;
                database.ExecuteQuery();
                return true;
            }
            else return false;
        }
        #endregion
        
        #region FormReception

        #endregion
        private string HashPassword(string password)
        {
            var passwordBytes = Encoding.UTF8.GetBytes(password);
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);
            StringBuilder hash = new StringBuilder();
        
            foreach (Byte b in passwordBytes)
                hash.Append(b.ToString("x2"));

            return hash.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                UserName = "Imie Nazwisko";
                Admin = true;
                return true;
            }
            else return false;
        }
        #endregion
        
        #region FormReception

        #endregion
    }
}

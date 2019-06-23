using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data;

namespace HotelReception
{
    class Model
    {
        DBConnection database;
        public string UserName { get; set; }
        public bool Admin { get; set; }

        //do modelu maja dostep oba formy, wiec jak pierwszy wrzuci dane z logowania tutaj to drugi moze na nich pracowac
        #region FormLogin
        public bool SetDatabaseAccess()
        {
            //polaczenie z baza
            //jesli sie udalo zwraca true
            database = DBConnection.Instance;
            if (database.IsConnected) return true; else return false;

        }

        
        public bool Login(string login,string password)
        {
            //sprawdzenie danych logowania
            //jesli sie udalo zwraca true

            //tutaj trzeba zrobic selecta szukajacego loginu i sprawdic przypisane do niego haslo
            //sprawdzamy czy znalazlo login i czy haslo jest dobre (i zwracamy true/false)
            DataTable result = database.ExecuteQuery($"SELECT * FROM worker WHERE login='{login}' AND password='{HashPassword(password)}'");
            return result.Rows.Count == 1;
        }
        #endregion

        #region FormReception
        //UU   UU WW       WW    AAA      GGGG      AAA
        //UU   UU WW       WW   AAAAA    GG  GG    AAAAA
        //UU   UU WW   W   WW  AA   AA  GG        AA   AA
        //UU   UU  WW WWW WW   AAAAAAA  GG   GG   AAAAAAA
        // UUUUU     WW WW     AA   AA   GGGGGG   AA   AA
        //narazie dalem void bo bedzie trzeba to jako instancje klasy Rooms raczej wyslac a jej jeszcze nie ma albo Tuple

        //dodatkowo trzeba zrobic wyzwalacz ktory czy insercie i selectcie bedzie pilnowal wielkosci znakow( imiona i nazwiska z duzej reszta z malej)
        //myslalem o czyms takim co by usuwalo wynajmy starszy niz miesiac zeby baza nie puchła w nieskonczonosc 
        public void SelectRooms(int ileOsob, DateTime odKiedy, DateTime dokiedy, bool czyMaTaras)
        {
            //metoda ma zwracac liste pokoi ze wszystkimi parametrami spelniajace warunki z argumentow
            
        }
        public void SelectRooms()
        {
            //metoda ma zwraca wszystkie pokoje
        }
        public void SelectRent()
        {
            //zwraca wszsytkie wynajmy
        }
        public void SelectEmployee()
        {
            //metoda ma zwracac wszystkich pracownikow 
        }
        public void InsertRoom(int ileOsob,int ilePoje, int ilePodw,bool czyTaras, int koszt)
        {
            //dodanie rooma 
            
        }
        public void UpdateRoom(int id,int ileOsob, int ilePoje, int ilePodw, bool czyTaras, int koszt)
        {
            //cala reszta chyba wiadomo o co chodzi 
        }
        public void DeleteRoom(int id)
        {

        }
        public void InsertRent(DateTime start, DateTime end, int idRoom, int idWorker, string imie, string nazwisko, string tel)
        {

        }
        public void UpdateRent(int id, DateTime start, DateTime end, int idRoom, int idWorker, string imie, string nazwisko, string tel)
        {
            //koszt sie zmieni w zaleznosci od cilosci dni
        }
        public void DeleteRent(int id)
        {

        }
        public void InsertEmployee(string imie, string nazwisko, bool isAdmin, string phone, string login, string pass)
        {

        }
        public void UpdateEmployee(int id, string imie, string nazwisko, bool isAdmin, string phone, string login, string pass)
        {
            //koszt sie zmieni w zaleznosci od cilosci dni
        }
        public void DeleteEmployee(int id)
        {

        }
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

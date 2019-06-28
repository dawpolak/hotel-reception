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
        public bool IsAdmin { get; set; }
        List<Rent> rents = new List<Rent>();
        List<Room> rooms = new List<Room>();
        List<Employee> employees = new List<Employee>();

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
            var result = database.ExecuteQuery($"SELECT * FROM worker WHERE login='{login}' AND password='{HashPassword(password)}'");
            foreach (DataRowView row in result)
            {
                UserName=row["firstname"].ToString()+" "+ row["lastname"].ToString();
                if (Int32.Parse(row["isadmin"].ToString()) == 1) IsAdmin = true; else IsAdmin = false;
                
            }
            return result.Count == 1;
            
        }

        private string HashPassword(string password)
        {
            var passwordBytes = Encoding.UTF8.GetBytes(password);
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);
            StringBuilder hash = new StringBuilder();

            foreach (Byte b in passwordBytes)
                hash.Append(b.ToString("x2"));

            return hash.ToString();
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
        public void SelectRooms(int guests, DateTime start, DateTime end, bool balcony)
        {
            //metoda ma zwracac liste pokoi ze wszystkimi parametrami spelniajace warunki z argumentow
            var result = database.ExecuteQuery("select r.idroom from room r, rental p " +
                                               "where r.idroom = p.idroom and " +
                                               $"guests = {guests} balcony = {balcony} " +
                                               $"and not('{start.ToShortDateString()}' <= p.end AND p.start <= '{end.ToShortDateString()}');");
        }
        public List<Room> SelectRooms()
        {
            //metoda ma zwraca wszystkie pokoje
            rooms.Clear();
            var result = database.ExecuteQuery("SELECT * FROM room");
            foreach (DataRowView row in result)
            {
                rooms.Add(new Room(row));
            }
            return rooms;
        }
        public List<Rent> SelectRental()
        {
            //zwraca wszsytkie wynajmy
            rents.Clear();
            var result = database.ExecuteQuery("SELECT * FROM rental");
            foreach (DataRowView row in result)
            {
                rents.Add(new Rent(row));
            }
            return rents;
        }
        public List<Employee> SelectEmployee()
        {
            //metoda ma zwracac wszystkich pracownikow 
            employees.Clear();
            var result = database.ExecuteQuery("SELECT * FROM worker");
            foreach (DataRowView row in result)
            {
                employees.Add(new Employee(row));
            }
            return employees;
        }
        public void InsertRoom(int guests, int singleBeds, int doubleBeds, bool balcony, int cost)
        {
            //dodanie rooma 
            var result = database.ExecuteNonQuery($"INSERT INTO room (idroom, guests, singlebeds, doublebeds, balcony, occupied, cost)" +
                                                  $" VALUES ({null}, {guests}, {singleBeds}, {doubleBeds}, {balcony}, {0}, {cost})");
        }
        public void UpdateRoom(int id,int ileOsob, int ilePoje, int ilePodw, bool czyTaras, int koszt)
        {
            //cala reszta chyba wiadomo o co chodzi 
        }
        public void DeleteRoom(int id)
        {
            int result = database.ExecuteNonQuery($"DELETE FROM room WHERE idroom={id}");
        }
        public void InsertRent(DateTime start, DateTime end, int idRoom, int idWorker, string imie, string nazwisko, string tel)
        {

        }
        public void UpdateRent(int id, DateTime start, DateTime end, int idRoom, int idWorker, string imie, string nazwisko, string tel)
        {
            //koszt sie zmieni w zaleznosci od cilosci dni
        }
        public void DeleteRent(int idroom, DateTime start, DateTime end)
        {
            //tych to raczej nie usuwamy tylko jakoś archiwizujemy
        }
        public void InsertEmployee(string firstname, string lastname, bool isAdmin, string phone, string login, string pass)
        {
            int result = database.ExecuteNonQuery($"INSERT INTO worker (idworker, firstname, lastname, isadmin, phone, login, password)" +
                                                  $" VALUES ({null}, {firstname}, {lastname}, {isAdmin}, {phone}, {login}, {HashPassword(pass)})");
        }
        public void UpdateEmployee(int id, string imie, string nazwisko, bool isAdmin, string phone, string login, string pass)
        {

        }
        public void DeleteEmployee(int id)
        {
            //tutaj też nie wiem czy nie lepiej archiwizować
        }
        #endregion
        
    }
}

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
        public string UserName
        {
            get
            {
                return CurrentUser.FirstName + " " + CurrentUser.LastName;
            }
        }
        public bool IsAdmin
        {
            get
            {
                return CurrentUser.IsAdmin;
            }
        }
        public int? GetUserId
        {
            get
            {
                return CurrentUser.Idworker;
            }
        }
        List<Rent> rents = new List<Rent>();
        List<Room> rooms = new List<Room>();
        List<Employee> employees = new List<Employee>();
        Employee CurrentUser;

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
                CurrentUser = new Employee(row);
                
            }
            if (result.Count == 1 && !CurrentUser.Archived) return true; else return false;
            
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
        #region Select
        public List<Room> FilterRooms(int guests, DateTime start, DateTime end, bool balcony)
        {
            int b = balcony ? 1 : 0;
            //metoda ma zwracac liste pokoi ze wszystkimi parametrami spelniajace warunki z argumentow
            var result = database.ExecuteQuery($"SELECT * FROM room r where r.guests = {guests} and balcony = {b} and NOT EXISTS (SELECT * FROM rental p WHERE r.idroom=p.idroom and('{start.ToString("yyyy-MM-dd")}' <= p.end AND p.start <= '{end.ToString("yyyy-MM-dd")}'))");
            rooms.Clear();
            Console.WriteLine(result.Count);
            foreach (DataRowView row in result)
            {
                Console.WriteLine(row);
                rooms.Add(new Room(row));
            }
            return rooms;
        }
        public List<Room> SelectRooms()
        {
            //metoda ma zwraca wszystkie pokoje
            rooms.Clear();
            var result = database.ExecuteQuery("SELECT * FROM room WHERE archived=0");
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
            var result = database.ExecuteQuery("SELECT * FROM rental WHERE archived=0");
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
            var result = database.ExecuteQuery("SELECT * FROM worker WHERE archived=0");
            foreach (DataRowView row in result)
            {
                employees.Add(new Employee(row));
            }
            return employees;
        }
        #endregion
        #region Insert
        public void InsertRoom(Room room)
        {
            //dodanie rooma 
            var result = database.ExecuteNonQuery($"INSERT INTO room (idroom, guests, singlebeds, doublebeds, balcony, cost) VALUES ({room.Idroom}, {room.Guests}, {room.SingleBeds}, {room.DoubleBeds}, {room.Balcony}, {room.Cost})");
        }
        public void InsertRent(Rent rent, int workerId)
        {
            var result = database.ExecuteNonQuery($"INSERT INTO rental (start, end, idroom, idworker, firstname, lastname, phone) VALUES ('{rent.Start.ToString("yyyy-MM-dd")}', '{rent.End.ToString("yyyy-MM-dd")}', {rent.Idroom}, {workerId}, '{rent.Firstname}', '{rent.Lastname}', '{rent.Phone}')");
        }
        public void InsertEmployee(Employee employee)
        {
            int result = database.ExecuteNonQuery($"INSERT INTO worker (firstname, lastname, isadmin, phone, login, password)" +
                                                  $" VALUES ('{employee.FirstName}', '{employee.LastName}', {employee.IsAdmin}, '{employee.Phone}', '{employee.Login}', '{HashPassword(employee.Password)}')");
        }
        #endregion
        #region Update
        public void UpdateRoom(Room room)
        {
            //int balcony = room.Balcony == true ? 1 : 0;
            var result = database.ExecuteNonQuery($"UPDATE room SET guests={room.Guests}, singlebeds={room.SingleBeds}, doublebeds={room.DoubleBeds}, balcony={room.Balcony}, cost={room.Cost} WHERE idroom={room.Idroom}");
        }
        public void UpdateRent(Rent rent)
        {
            var result = database.ExecuteNonQuery($"UPDATE rental SET end='{rent.End.ToString("yyyy-MM-dd")}', idroom={rent.Idroom}, idworker={CurrentUser.Idworker}, firstname='{rent.Firstname}', lastname='{rent.Lastname}', phone='{rent.Phone}' WHERE (start='{rent.Start.ToString("yyyy-MM-dd")}' AND idroom={rent.Idroom})");
        }
        public void UpdateEmployee(Employee employee)
        {
            if (employee.Password != "")
            {
                int result = database.ExecuteNonQuery($"UPDATE worker SET firstname='{employee.FirstName}', lastname='{employee.LastName}', isadmin={employee.IsAdmin}, phone='{employee.Phone}', password='{HashPassword(employee.Password)}')" +
                                                      $" WHERE login='{employee.Login}'");
            }
            else
            {
                int result = database.ExecuteNonQuery($"UPDATE worker SET firstname='{employee.FirstName}', lastname='{employee.LastName}', isadmin={employee.IsAdmin}, phone='{employee.Phone}'" +
                                      $" WHERE login='{employee.Login}'");
            }
        }
        #endregion
        #region Delete
        public void DeleteRoom(int id)
        {
            int result = database.ExecuteNonQuery($"UPDATE room SET archived=1 WHERE idroom={id}");
        }
        public void DeleteRent(int idroom, DateTime start, DateTime end)
        {
            int result = database.ExecuteNonQuery($"UPDATE rental SET archived=1 WHERE idroom={idroom} and start='{start.ToString("yyyy-MM-dd")}'");
        }
        public void DeleteEmployee(int id)
        {
            int result = database.ExecuteNonQuery($"UPDATE worker SET archived=1 WHERE idworker={id}");
        }
        #endregion
        #endregion

    }
}

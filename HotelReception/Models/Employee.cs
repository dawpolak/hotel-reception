using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReception
{
    public class Employee
    {
        public int? Idworker { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAdmin { get; set; }
        public string Phone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public Employee() { }

        public Employee(DataRowView row)
        {
            this.Idworker = (int)row["idworker"];
            this.FirstName = row["firstname"].ToString();
            this.LastName = row["lastname"].ToString();
            if (Int32.Parse(row["isadmin"].ToString()) == 1) this.IsAdmin = true; else this.IsAdmin = false;
            this.Phone = row["phone"].ToString(); ;
            this.Login = row["login"].ToString(); ;
        }

        //public Employee(int? idworker, string firstName, string lastName, bool isAdmin, string phone, string login, string password)
        //{
        //    this.idworker = idworker;
        //    this.firstName = firstName;
        //    this.lastName = lastName;
        //    this.isAdmin = isAdmin;
        //    this.phone = phone;
        //    this.login = login;
        //    this.password = password;
        //}

        public override string ToString()
        {
            return $"{FirstName} | {LastName} | {IsAdmin} | {Phone} | {Login}";
        }

    }
}

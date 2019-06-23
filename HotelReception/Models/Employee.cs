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
        string firstName;
        string lastName;
        bool isAdmin;
        string phone;
        string login;

        public Employee(DataRowView row)
        {
            this.firstName = row["firstname"].ToString();
            this.lastName = row["lastname"].ToString();
            if (Int32.Parse(row["isadmin"].ToString()) == 1) this.isAdmin = true; else this.isAdmin = false;
            this.phone = row["phone"].ToString(); ;
            this.login = row["login"].ToString(); ;
        }

        public override string ToString()
        {
            return $"{firstName} | {lastName} | {isAdmin} | {phone} | {login}";
        }

    }
}

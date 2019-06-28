using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReception
{
    interface IReception
    {
        string UserName { set; }
        bool IfAdmin { set; get; }
        List<Employee> Employees { set; }
        List<Rent> Rents { set; }
        List<Room> Rooms { set; }

        event Action GetInfo;
        event Action SelectEmployees;
        event Action SelectRooms;
        event Action<int, DateTime, DateTime, bool> SelectRoomsFilter;
        event Action SelectRents;

        event Action<Rent> InsertRent;
        event Action<Room> InsertRoom;
        event Action<Employee> InsertEmployee;

        event Action<Rent> UpdateRent;
        event Action<Room> UpdateRoom;
        event Action<Employee> UpdateEmployee;

        event Action<int, DateTime,DateTime> DeleteRent;
        event Action<int> DeleteRoom;
        event Action<int> DeleteEmployee;



    }
}

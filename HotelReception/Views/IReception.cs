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

        event Action GetInfo;
        event Action SelectEmployees;
    }
}

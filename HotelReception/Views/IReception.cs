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


        event Action GetInfo;
    }
}

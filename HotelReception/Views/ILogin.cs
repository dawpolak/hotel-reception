using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReception
{
    interface ILogin
    {
        bool Access { get; set; }
        bool CorrectUser { get; set; }
        event Action<string,string> Login;

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReception
{
    class PresenterReception
    {
        IReception view;
        Model model;
        public PresenterReception(IReception view, Model model)
        {
            this.view = view;
            this.model = model;
        }
    }
}

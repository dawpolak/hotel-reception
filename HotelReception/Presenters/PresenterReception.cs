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
            this.view.GetInfo += View_GetInfo;
        }

        private void View_GetInfo()
        {
            view.UserName = model.UserName;
            view.IfAdmin = model.Admin;
        }
    }
}

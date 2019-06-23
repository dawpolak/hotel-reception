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
            this.view.SelectEmployees += View_SelectEmployees;
        }

        private void View_SelectEmployees()
        {
            view.Employees = model.SelectEmployee();
        }

        private void View_GetInfo()
        {
            view.UserName = model.UserName;
            view.IfAdmin = model.IsAdmin;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReception
{
    class PresenterLogin
    {
        ILogin view;
        Model model;
        public PresenterLogin(ILogin view, Model model)
        {
            this.view = view;
            this.model = model;
            this.view.Login += View_Login;
        }

        private void View_Login(string l, string p)
        {
            view.Access=model.SetDatabaseAccess();
            view.CorrectUser=model.Login(l,p);
        }
    }
}

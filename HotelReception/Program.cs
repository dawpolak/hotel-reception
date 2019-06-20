using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReception
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Model model = new Model();

            FormReception viewReception = new FormReception();
            PresenterReception presenterSaper = new PresenterReception(viewReception, model);

            ILogin viewLogin = new FormLogin(viewReception);
            PresenterLogin presenterMenu = new PresenterLogin(viewLogin, model);


            Application.Run((Form)viewLogin);
        }
    }
}

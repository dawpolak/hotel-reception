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
            this.view.SelectRents += View_SelectRents;
            this.view.SelectRooms += View_SelectRooms;
            this.view.SelectRoomsFilter += View_SelectRoomsFilter;

            this.view.InsertRent += View_InsertRent;
            this.view.InsertRoom += View_InsertRoom;
            this.view.InsertEmployee += View_InsertEmployee;

            this.view.UpdateEmployee += View_UpdateEmployee;
            this.view.UpdateRent += View_UpdateRent;
            this.view.UpdateRoom += View_UpdateRoom;

            this.view.DeleteEmployee += View_DeleteEmployee;
            this.view.DeleteRent += View_DeleteRent;
            this.view.DeleteRoom += View_DeleteRoom;

        }

        #region Selects
        private void View_SelectRoomsFilter(int arg1, DateTime arg2, DateTime arg3, bool arg4)
        {
            Console.WriteLine("[PRESENTER] Select rooms with filters: " +arg1 + " | " + arg2 + " => " + arg3 + " | " + arg4);
            //view.Rooms = model.SelectRooms(arg1,arg2,arg3,arg4);
        }

        private void View_SelectRooms()
        {
            Console.WriteLine("[PRESENTER] Select rooms");
            view.Rooms = model.SelectRooms();
        }

        private void View_SelectRents()
        {
            Console.WriteLine("[PRESENTER] Select rents");
            view.Rents = model.SelectRental();
        }

        private void View_SelectEmployees()
        {
            Console.WriteLine("[PRESENTER] Select employees");
            view.Employees = model.SelectEmployee();
        }
        #endregion

        #region Insert
        private void View_InsertEmployee(Employee obj)
        {
            Console.WriteLine("[PRESENTER] Insert employee: "+obj);
            //haslo tez leci w tym obiekcie ale sie nie wyswietla
        }

        private void View_InsertRoom(Room obj)
        {
            Console.WriteLine("[PRESENTER] Insert room: " + obj);
        }

        private void View_InsertRent(Rent obj)
        {
            Console.WriteLine("[PRESENTER] Insert rent: " + obj);
        }
        #endregion

        #region Update
        private void View_UpdateRoom(Room obj)
        {
            Console.WriteLine("[PRESENTER] Update room: " + obj);
        }

        private void View_UpdateRent(Rent obj)
        {
            Console.WriteLine("[PRESENTER] Update rent: " + obj);
        }

        private void View_UpdateEmployee(Employee obj)
        {
            Console.WriteLine("[PRESENTER] Update employee: " + obj);
            //haslo tez leci w tym obiekcie ale sie nie wyswietla
        }
        #endregion

        #region Delete
        private void View_DeleteRoom(int obj)
        {
            Console.WriteLine("[PRESENTER] Delete room id: " + obj);
        }

        private void View_DeleteRent(int arg1, DateTime arg2, DateTime arg3)
        {
            Console.WriteLine("[PRESENTER] Delete rent roomId: " + arg1 + " | " + arg2 + " => " + arg3 );
        }

        private void View_DeleteEmployee(int obj)
        {
            Console.WriteLine("[PRESENTER] Delete employee id: " + obj);
        }
        #endregion

        
        private void View_GetInfo()
        {
            view.UserName = model.UserName;
            view.IfAdmin = model.IsAdmin;
        }
    }
}

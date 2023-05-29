using Hotel_Management_System.Interface;
using WindowsFormsApp1;

namespace Hotel_Management_System.models
{
    public class Admin : User , Interface.Manager, Interface.Receptionist
    {
        private Interface.Manager _managerImplementation;
        private Receptionist _receptionistImplementation;

        public void ManageOffers()
        {
            _managerImplementation.ManageOffers();
        }

        public void ManageEvents()
        {
            _managerImplementation.ManageEvents();
        }

        public void ManageRooms()
        {
            _managerImplementation.ManageRooms();
        }

        public void ManageRoomType()
        {
            _managerImplementation.ManageRoomType();
        }

        public void CreateRoomType()
        {
            _managerImplementation.CreateRoomType();
        }

        public void editEmployeeRole()
        {
            _managerImplementation.editEmployeeRole();
        }

        public void acceptReservation()
        {
            _receptionistImplementation.acceptReservation();
        }

        public void editReservation()
        {
            _receptionistImplementation.editReservation();
        }

        public void cancelReservation()
        {
            _receptionistImplementation.cancelReservation();
        }
    }
}
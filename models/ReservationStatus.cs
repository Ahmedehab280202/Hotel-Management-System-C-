using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ReservationStatus
    {
        private int id;
        private string status;

        public ReservationStatus(int id, string status)
        {
            this.id = id;
            this.status = status;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class RoomStatus
    {
        public int id { get; set; }
        public string status { get; set; }

        public RoomStatus(int id, string status)
        {
            this.id = id;
            this.status = status;
        }
    }
}
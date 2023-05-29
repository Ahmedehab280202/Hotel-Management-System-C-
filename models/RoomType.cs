using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class RoomType
    {
        private int id { get; set; }
        private string description { get; set; }

        public RoomType(int id, string description)
        {
            this.id = id;
            this.description = description;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class RoomType
    {
        public int id { get; set; }
        public string name { get; set; }
        public int size { get; set; }
        public int capacity { get; set; }

        public List<Room> rooms { get; set; }

        public RoomType(int id, string name, int size, int capacity)
        {
            this.id = id;
            this.name = name;
            this.size = size;
            this.capacity = capacity;
        }
    }
}

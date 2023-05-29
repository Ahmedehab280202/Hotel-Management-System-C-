using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Room 
    {
        private int id { get; set; }
        private double price { get; set; }
        private RoomType roomType { get; set; }
        private RoomStatus roomStatus { get; set; }
        private Offer offer { get; set; }

        public Room(int id, double price, RoomType roomType, RoomStatus roomStatus, Offer offer)
        {
            this.id = id;
            this.price = price;
            this.roomType = roomType;
            this.roomStatus = roomStatus;
            this.offer = offer;
        }
    }
}
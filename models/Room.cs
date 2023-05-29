using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Room 
    {
        public int id { get; set; }
        public int roomNum { get; set; }
        public int floor { get; set; }
        public double price { get; set; }
        public RoomType roomType { get; set; }
        public string status { get; set; }
        public Offer offer { get; set; }
        public Reservation reservation { get; set; }
        public Review reviews { get; set; }

        public Room(int id, int roomNum, int floor, double price, RoomType roomType, string status, Offer offer, Reservation reservation, Review reviews)
        {
            this.id = id;
            this.roomNum = roomNum;
            this.floor = floor;
            this.price = price;
            this.roomType = roomType;
            this.status = status;
            this.offer = offer;
            this.reservation = reservation;
            this.reviews = reviews;
        }
    }
}
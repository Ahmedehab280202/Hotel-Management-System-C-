using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{ 
    class Reservation
    {
        public int id { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public double price { get; set; }
        public User customer { get; set; }
        public List<Room> rooms { get; set; }
        public Payment payment { get; set; }
        public ReservationStatus reservationStatus { get; set; }

        public Reservation(int id, DateTime startDate, DateTime endDate, double price, User customer, List<Room> rooms, Payment payment, ReservationStatus reservationStatus)
        {
            this.id = id;
            this.startDate = startDate;
            this.endDate = endDate;
            this.price = price;
            this.customer = customer;
            this.rooms = rooms;
            this.payment = payment;
            this.reservationStatus = reservationStatus;
        }
    }
}
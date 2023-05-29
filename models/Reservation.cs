using Hotel_Management_System.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    public class Reservation
    {
        public int id { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public double price { get; set; }
        public Customer customer { get; set; }
        public Room rooms { get; set; }
        public Payment payment { get; set; }
        public string status { get; set; }

        public Reservation(int id, DateTime startDate, DateTime endDate, double price, Customer customer, Room rooms, Payment payment, string status)
        {
            this.id = id;
            this.startDate = startDate;
            this.endDate = endDate;
            this.price = price;
            this.customer = customer;
            this.rooms = rooms;
            this.payment = payment;
            this.status = status;
        }
    }
}
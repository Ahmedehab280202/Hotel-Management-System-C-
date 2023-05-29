﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace Hotel_Management_System.models
{
    class Customer
    {
        public int id { get; set; }
        public Reservation reservation { get; set; }

        public List<Review> reviews { get; set; }

        public List<Payment> payments { get; set; }

        public Customer(int id, Reservation reservation, List<Review> reviews, List<Payment> payments)
        {
            this.id = id;
            this.reservation = reservation;
            this.reviews = reviews;
            this.payments = payments;
        }
    }
}
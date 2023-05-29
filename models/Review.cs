using Hotel_Management_System.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Review
    {
        public int id { get; set; }
        public string description { get; set; }
        public string title { get; set; }
        public Customer customer { get; set; }

        public Review(int id, string description, string title, Customer customer)
        {
            this.id = id;
            this.description = description;
            this.title = title;
            this.customer = customer;
        }

 
    }

}

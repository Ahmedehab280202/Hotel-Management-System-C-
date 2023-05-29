using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Review
    {
        private int id;
        private string description;
        private string title;
        private User customer;

        public Review(int id, string description, string title, User customer)
        {
            this.id = id;
            this.description = description;
            this.title = title;
            this.customer = customer;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public User Customer
        {
            get { return customer; }
            set { customer = value; }
        }
    }

}

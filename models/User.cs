using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_Management_System.models;


namespace WindowsFormsApp1
{
    public class User 
    {
        public int id { get; set; }
        public string password { get; set; }
        public string username { get; set; }
        public Role role { get; set; }
        

        public User(int id, string username, string email, string password, Role role)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public void signup(string username, string password)
        {
            username = this.username;
            password = this.password;
        }

        public bool login(string username,string password)
        {
            if (this.username == username && this.password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected User()
        {
            throw new NotImplementedException();
        }
    }
}


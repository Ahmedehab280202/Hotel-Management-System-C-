using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WindowsFormsApp1
{
    class User
    {
        private int id;
        private string name;
        private string email;
        private string password;
        private Role role;

        public User(int id, string name, string email, string password, Role role)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.role = role;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Role Role
        {
            get { return role; }
            set { role = value; }
        }

       

    }
}


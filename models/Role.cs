using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Role
    {
        public int id { get; set; }
        public string roleTitle { get; set; }

        public Role(int id, string roleTitle)
        {
            this.id = id;
            this.roleTitle = roleTitle;
        }
    }
}
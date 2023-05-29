using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Payment
	{
		public int id { get; set; }
		public string name { get; set; }
		public string description { get; set; }

        public Payment(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }
    }
}

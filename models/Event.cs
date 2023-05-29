using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.models
{
    public class Event
    {
        public string name { get; set; }
        public DateTime date { get; set; }
        public int durationHrs { get; set; }
        public string hostname { get; set; }

        public Event(string name, DateTime date, int durationHrs, string hostname)
        {
            this.name = name;
            this.date = date;
            this.durationHrs = durationHrs;
            this.hostname = hostname;
        }

    }
}

using System;

namespace Hotel_Management_System.models
{
    public class Employe : Person
    {
        public int id { get; set; }
        public int salary { get; set; }
        public string jobTitle { get; set; }
        public DateTime hireDate { get; set; }
        public int workingHrs { get; set; }

        public Employe(int id, int salary, string jobTitle, DateTime hireDate, int workingHrs) : base()
        {
            this.id = id;
            this.salary = salary;
            this.jobTitle = jobTitle;
            this.hireDate = hireDate;
            this.workingHrs = workingHrs;
        }
    }
}
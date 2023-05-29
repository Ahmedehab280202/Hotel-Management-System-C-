using System;

namespace WindowsFormsApp1
{
    class Offer
    {
        private int id { get; set; }
        private double percentage { get; set; }
        private DateTime expirationdate { get; set; }

        public Offer(int id, double percentage, DateTime expirationDate)
        {
            this.id = id;
            this.percentage = percentage;
            this.expirationdate = expirationDate;
        }

    }
}

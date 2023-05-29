using System;

namespace WindowsFormsApp1
{
    public class Offer
    {
        public int id { get; set; }
        public int discountPercentage { get; set; }
        public DateTime expirationDate { get; set; }

        public Offer(int id, int discountPercentage, DateTime expirationDate)
        {
            this.id = id;
            this.discountPercentage = discountPercentage;
            this.expirationDate = expirationDate;
        }

    }
}

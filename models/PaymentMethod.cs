namespace WindowsFormsApp1
{
    public class PaymentMethod
    {
        public int id { get; set; }
        public string name { get; set; }

        public PaymentMethod(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
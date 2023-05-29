namespace Hotel_Management_System.models
{
    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public string phoneNum { get; set; }

        public Person(string name, int age, string gender, string address, string phoneNum)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.address = address;
            this.phoneNum = phoneNum;
        }

        protected Person()
        {
            throw new System.NotImplementedException();
        }
    }
}
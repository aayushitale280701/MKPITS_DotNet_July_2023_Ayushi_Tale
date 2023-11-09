using System;
namespace staticConstructor
{
   public  class Account
    {
        public int id;
        public string name;
        public static float rateOfInterest;
        public Account(int id, string name)
        {
            Console.WriteLine("Instance constructor is called");
            this.id = id;
            this.name = name;
        }
        static Account()
        {
            Console.WriteLine("Static constructor is called");
            rateOfInterest = 9.5f;
        }
        public void dispaly()
        {
            Console.WriteLine(id + " " + name + " " + rateOfInterest);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(123, "Ayushi");
            Account a2 = new Account(156, "om");
            a1.dispaly();
            a2.dispaly();
        }
    }
}
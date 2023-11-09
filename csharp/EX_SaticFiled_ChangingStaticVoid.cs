using System;
namespace ChangingSaticField
{
    public class Account
    {
        public int accno;
        public string name;
        public static float reatOfInterest = 8.8f;
        public Account(int accno, string name)
        {
            this.accno = accno;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine(accno + " " + name + " " + reatOfInterest);
        }
    }
    class TestAccount
    {
        public static void Main(string[] args)
        {
            Account.reatOfInterest = 10.5f;
            Account A1 = new Account(111, "Ayushi");
            Account A2 = new Account(452, "Om");
            A1.display();
            A2.display();
        }
    }
}
using System;
namespace ChangingSaticField
{
    public class Account
    {
        public int accno;
        public string name;
        public static int count=0;
        public Account(int accno, string name)
        {
            this.accno = accno;
            this.name = name;
            count++;
        }
        public void display()
        {
            Console.WriteLine(accno + " " + name + " ");
            
        }
    }
    class TestAccount
    {
        public static void Main(string[] args)
        {
            
            Account A1 = new Account(111, "Ayushi");
            Account A2 = new Account(452, "Om");
            Account A3 = new Account(231, "Rajesh");
            A1.display();
            A2.display();
            A3.display();
            Console.WriteLine("Total Object are: " + Account.count);
        }
    }
}
using System;
namespace AbstractMethod
{
    abstract class account
    {
        public int acctno;
        public int bal = 1000;
        public abstract void deposit(int amt);

        public void showbalance()
        {
            Console.WriteLine("Balance amount for account no {0} is {1} ", acctno, bal);
        }
    }
    class current : account
    {
        public override void deposit(int amt)
        {
            bal = bal + amt;

        }
    }
    class saving : account
    {
        public override void deposit(int amt)
        {
            int interest = 200;
            bal = bal + amt + interest;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter account no");
            int acctno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount to be deposited");
            int amt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter account type saving or current");
            string acttype = Console.ReadLine();
            account act = null;
            if (acttype == "Saving")
            {
                act = new saving();
            }
            else if (acttype == "Current")
            {
                act = new current();
            }
            act.acctno = acctno;
            act.deposit(amt);
            act.showbalance();
            Console.ReadKey();
        }
    }
}

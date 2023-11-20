using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class account
    {
        public int bal = 1000;
        public abstract void deposit(int amount);
        public abstract void withdrawl(int amount);
        public void showbalance()
        {
            Console.WriteLine("Balance is " + bal);
        }
    }
    class saving : account
    {
        public override void withdrawl(int amount)
        {
            bal = bal - amount;
        }
        public override void deposit(int amount)
        {
            int interest = 500;
            bal = bal + amount + interest;
            Console.WriteLine("Amount deposited with interest, bal is " + bal);
        }
    }

    class current : account
    {
        public override void withdrawl(int amount)
        {
            bal = bal - amount;

        }
        public override void deposit(int amt)
        {
            bal = bal + amt;
            Console.WriteLine("Amount deposited without interest bal is " + bal);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            account act = null;
            Console.WriteLine("Enter amount ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter saving or current");
            string acttype = Console.ReadLine();
            Console.WriteLine("Enter deposit or withdrawl");
            string tt = Console.ReadLine();
            if (acttype == "Saving")
            {
                act = new saving();
            }
            else if (acttype == "Current")
            {
                act = new current();
            }

            if (tt == "Deposit")
            {
                act.deposit(amount);
            }
            else if (tt == "Withdrawl")
            {
                act.withdrawl(amount);
            }
            act.showbalance();

            Console.ReadLine();
        }
    }
}

using System;
using System.Security.Principal;

namespace interfaceaccount
{
    interface Bank
    {
        string deposit(int actno, int amt);
        string withdrawl(int  actno, int amt);
    }
    class Account
    {
        public int actno;
        public int bal = 1000;
        public string showbalance()
        {
            return "Bal is : " + bal;
        }
    }
    class Saving : Account, Bank
    {
        public string deposit(int actno, int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            return "Deposit successfully bal is : " + bal;
        }
        public string withdrawl(int actno, int amt)
        {
            this.actno = actno;
            bal = bal - amt;
            return "Withdrawl successfully is : " + bal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Saving b;
            b = new Saving();
            string str = b.deposit(11, 200);
            Console.WriteLine(str);
            str= b.withdrawl(11, 1000);
            Console.WriteLine(str);
            Console.WriteLine(b.showbalance());
            Console.ReadKey();
        }
    }
}
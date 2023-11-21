using System;
using System.Security.Principal;

namespace interfaceaccount
{
    interface Bank
    {
        string deposit(int actno, int amt);
    }
    class Account 
    {
        public int actno;
        public int bal = 1000;
    }
    class Saving :Account, Bank
    {
        public string deposit(int actno, int amt)
        {
            this.actno = actno;
            bal=bal+amt;
            return "Deposit successfully bal is " + bal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bank b;
            b= new Saving();
            string str = b.deposit(11, 200);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
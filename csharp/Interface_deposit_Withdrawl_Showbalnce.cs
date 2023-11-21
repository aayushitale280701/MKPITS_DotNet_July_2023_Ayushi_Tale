using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    interface bank
    {
        string deposit(int actno, int amount);
        string withdrawl(int actno, int amount);
        string showbalance();
    }
    class account
    {
        public int actno;
        public int bal = 1000;
        public int interest = 500;

    }
    class saving : account, bank
    {

        public string deposit(int actno, int amount)
        {
            this.actno = actno;
            bal = bal + amount + interest;
            return "actno  : " + actno + " bal is : " + bal;
        }

        public string withdrawl(int actno, int amount)
        {
            this.actno = actno;
            bal = bal - amount;
            return "actno  : " + actno + " bal is : " + bal;
        }
        public string showbalance()
        {
            return "actno " + actno + "bal is " + bal;
        }
    }

    class current : account, bank
    {


        public string deposit(int actno, int amount)
        {
            this.actno = actno;
            bal = bal + amount;
            return "actno  : " + actno + " bal is : " + bal;
        }
        public string withdrawl(int actno, int amount)
        {
            this.actno = actno;
            bal = bal - amount;
            return "actno  : " + actno + " bal is : " + bal;
        }
        public string showbalance()
        {
            return "actno " + actno + "bal is " + bal;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            bank b = null;

            Console.WriteLine("enter saving or current");
            string acttype = Console.ReadLine();
            string res = null;
            switch (acttype)
            {
                case "saving":
                    b = new saving();
                    break;
                case "current":
                    b = new current();
                    break;

            }
            Console.WriteLine("enter deposit or withdrawl");
            string tt = Console.ReadLine();


            if (tt == "deposit")
                res = b.deposit(1, 700);
            else if (tt == "withdrawl")
                res = b.withdrawl(1, 500);

            Console.WriteLine(res);
            Console.WriteLine(b.showbalance());
            Console.ReadKey();
        }
    }
}

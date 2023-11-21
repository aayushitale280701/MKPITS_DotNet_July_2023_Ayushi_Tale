using System;
namespace abstractkeyword
{
    interface Bank
    {
        string deposit(int actno, int amt);
    }
    class Saving : Bank
    {
        int actno;
        int bal=1000;
        public string deposit(int actno,int amt)
        {
            this .actno = actno;
            bal = bal + amt;
            return ("Deposit succesfully bal is, " + bal);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Bank b;
            b = new Saving();
            string  str=b.deposit(1, 2000);
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
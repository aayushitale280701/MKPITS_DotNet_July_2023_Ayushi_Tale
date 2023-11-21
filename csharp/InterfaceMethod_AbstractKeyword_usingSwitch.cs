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
        int bal = 1000;
        int intrest = 500;
        public string deposit(int actno, int amt)
        {
            this.actno = actno;
            bal = bal + amt + intrest;
            return "Act no" + actno + "Bal is" + bal;
        }
    }
    class Current : Bank
    {
        int actno;
        int bal = 1000;
        public string deposit(int actno, int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            return"Act no" + actno + "Bal is" + bal;
        }
    }
    class program
    {
        static void Main(string[] args)
        {

            Bank b=null;
            Console.WriteLine("Enter Saving and Current");
            string acttype=Console.ReadLine();
            switch(acttype)
            {
                case "Saving":
                    b=new Saving();
                    break;
                case "Current":
                    b=new Current();
                    break;
            }
            
            string res = b.deposit(1, 2000);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
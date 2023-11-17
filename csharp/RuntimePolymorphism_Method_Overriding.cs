using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOverriding
{
    class Account
    {
        public int actno;
        public int balance = 1000;

        public virtual String deposit(int actno, int amount)
        {
            return "Deposit method of account class";
        }
        public String showbalance()
        {
            return "Balance amount : " + balance;
        }
    }

    class Current : Account
    {
        //overriding the base class deposit method
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            return "Amount deposited successfully without interest in current class";
        }
    }

    class Saving : Account
    {
        //overriding the base class deposit method
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            int interest = 500;
            balance = balance + amount + interest;
            return "Amount deposited successfully with interest in saving class";
        }
    }
    public class TestBase
    {
        public static void Main(string[] args)
        {
            //runtime polymorphism : base class reference variable having instance of derieved class current

            Console.WriteLine("Enter account no ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount to be deposited ");
            int amount = Convert.ToInt32(Console.ReadLine());

            Account act = new Current();
            String res = act.deposit(actno, amount);
            Console.WriteLine("Account no is " + act.actno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);

            Console.WriteLine("Enter account no ");
            int actno1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount to be deposited ");
            int amount1 = Convert.ToInt32(Console.ReadLine());
            Account sav = new Saving();
            String res1 = sav.deposit(actno1, amount1);
            Console.WriteLine("Account no is " + sav.actno);
            Console.WriteLine(res1);
            res1 = sav.showbalance();
            Console.WriteLine(res1);

        }
    }

}


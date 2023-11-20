using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAccount
{
    abstract class Account
    {
        public int actno;
        public int balance = 1000;
        //creating abstract method deposit
        public abstract String deposit(int actno, int amount);

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
        public static void Main()
        {
            //runtime polymorphism : base class reference variable having instance of derieved class current

            Console.WriteLine("Enter account no ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount to be deposited ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter account type (saving or currrent)");
            String acttype = Console.ReadLine();


            Account act = null;
            if (acttype == "Saving")
            {
                act = new Saving();
            }
            else if (acttype == "Current")
            {
                act = new Current();
            }
            String res = act.deposit(actno, amount);
            Console.WriteLine("Account no is " + act.actno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);
        }
    }

}



using System;
namespace runtimepolymorphism
{
    class Account
    {
         public int balance = 1000;
        public int actno;

        public virtual string deposit(int actno, int amount)
        {
            return "Deposit Method of Account Class";
        }
        public string showbalance()
        {
            return "Balance Amount:- " + balance;
        }
    }
    class Current : Account
    {
        //overriding the base class deposite method
        public override string deposit(int actno, int amount)
        {
            this. actno = actno;
            balance = balance + amount;
            return "Amount deposited successfully without interest in current class";
        }
    }
    class Saving : Account
    {
        //overriding the base class deposite method
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            int interest = 500;
            balance = balance + amount + interest;
            return "Amount deposited successfully without interest in saving class";
        }
    } 
    class Program
    {
        public static void Main (string[] args)
        {
            //runtime polymorphism: base class reference variable having instance of derived class current
            Console.WriteLine("Enter Account No");
            int actno= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount to be Deposite");
            int amount= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Account type (Saving or Current) ");
            string acttype= Console.ReadLine();

            Account act = null;
            if (acttype == "Saving") 
            {
                act = new Saving();
            }
            else if(acttype == "Current")
            {
                act = new Current();
            }
            string res= act.deposit(actno, amount);
            Console.WriteLine(res);
            res=act.showbalance();
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
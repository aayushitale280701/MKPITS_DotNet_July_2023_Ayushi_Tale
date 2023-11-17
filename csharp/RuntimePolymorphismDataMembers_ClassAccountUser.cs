using System;
namespace ClassAccountUser
{
    class Account
    {
        public int actno;
        public int balance = 1000;
        public virtual string deposit(int actno,int amount)
        {
            return "Deposite method of account class";
        }
        public string showbalance()
        {
            return "Balance Amount:- " + balance;
        }
    }
    class Current : Account
    {
        //overriding the base class deposit method

        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            return "Amount deposited successfully in current class";
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            //runtime polymorphism: base class reference variable having instance of class current

            Account act= new Current();
            Console.WriteLine("Enter account no");
            int actno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount to be deposited ");
            int amount =Convert.ToInt32(Console.ReadLine());
            string res=act.deposit(actno, amount);
            Console.WriteLine("Account no is " + act.actno);
            Console.WriteLine(res);
            res=act.showbalance();
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
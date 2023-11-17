using System;
namespace classAccount
{
    class Account
    {
        public int actno;
        public int balance = 1000;

        public virtual string deposit(int actno, int balance)
        {
            return "Deposit method of account class ";
        }
        public string showbalance()
        {
            return "Balance Amount : "+balance;
        }
    }

    class Current: Account
    {
        //overriding the base class deposit method
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            return "Amount deposited successfully in current class";
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            //runtime polymorphism : base class reference variable having instance of derieved class current

            Account act = new Current();
            string res = act.deposit(123, 2000);
            Console.WriteLine("Account no is "+act.actno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
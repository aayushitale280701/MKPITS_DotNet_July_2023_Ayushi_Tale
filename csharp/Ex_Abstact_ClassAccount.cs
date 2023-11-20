using System;
namespace exabstact
{
    abstract class account
    {
        public abstract void deposit();
    }
    class saving : account
    {
        public override void deposit()
        {
            Console.WriteLine("Hello from saving deposite mathod");
        }
    }
    class program
    {
        static void Main (string[] args)
        {
            account act= new saving();
            act.deposit();
        }
    }
}
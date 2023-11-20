using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractClass
{
    abstract class account
    {
        public abstract void deposit(); 
        //abstract method
        //non abstract method
        public void showbalance()
        {
            Console.WriteLine("Balance Method ");
        }

    }
    class saving : account
    {
        public override void deposit()
        {
            Console.WriteLine("Hello from saving depsoit method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //  account act = new account(); error 
            account act = new saving();
            act.deposit();
            act.showbalance();
            Console.ReadKey();
        }
    }
}

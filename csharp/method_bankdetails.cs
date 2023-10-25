using System;
namespace bankdetails
{
    class program
    {
        static int claculate(int actno, int amt)
        {
            int balance = 1000;
            int deposite, withdrawl;
            int result = 0;
            deposite = amt + balance;
            Console.WriteLine("Deposite value is :" + deposite);
            withdrawl = amt-balance;
            Console.WriteLine("Withdrawl value is :" + withdrawl);
            return result;
        }
        static void Main(string[] args)
        {
            int accountno, amount;
            Console.WriteLine("Enter Account Number");
            accountno = Convert.ToInt32(Console.ReadLine());
           
            

            Console.WriteLine("Enter Amount");
            amount = Convert.ToInt32(Console.ReadLine());
            int res = claculate(accountno, amount);      
            

            Console.ReadKey();
        }
    }
}
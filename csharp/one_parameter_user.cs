using System;
namespace userparameterone
{
    class Program
    {
        static void factorial(int num) 
        {
            int fact = 1;
            while (num > 0)
            {
                fact = fact * num;
                num--;
            }
            Console.WriteLine("fact " + fact);
        }
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("enter number");
            number = Convert.ToInt32(Console.ReadLine());
            factorial(number);
            Console.ReadKey();
        }
    }
}

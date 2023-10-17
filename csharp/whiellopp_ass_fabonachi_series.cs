using System;
namespace fabonachiseries
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num1 = 0, num2 = 1;
            int total=0,n ,cnt=3;
            Console.WriteLine("Enter a number: ");
            n=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci Series:- {0} ", num1);
            
            while (cnt <= num1)
            {
                
                num1 = num2;
                num2 = total;
                total = num1 + num2;
                Console.WriteLine("{0}", total);
                cnt++;
            }
            Console.ReadKey();
        }
    }
}

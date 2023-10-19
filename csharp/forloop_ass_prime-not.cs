using System;
using System.Diagnostics.Metrics;

namespace primeornot
{
    public class program
    {
        public static void Main(string[] args)
        {
            int num;
            int flag=0;
           
            Console.WriteLine("Enter the number");
            num=Convert.ToInt32(Console.ReadLine());
            for (int counte = 2; counte <= num; counte++)
            {
                if (num % 2 == 0)
                {
                    flag = 1;
                    break;
                }
            }

                if(flag==0)
                {
                    Console.WriteLine("No. is prime");
                }
                else
                {
                    Console.WriteLine("No. is not prime");
                }
                Console.ReadKey();         
        }
    }
}
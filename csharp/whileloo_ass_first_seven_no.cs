using System;
namespace sevennaturalnumbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i, num = 7, sum = 0;

            i = 1;
            while (i <= num)
            {
                sum = sum + i;
                i++;
            }

            Console.WriteLine("Sum of first seven no. :- " + num + "\nnatural numbers sum of  = " + sum);
            Console.ReadLine();
        }
    }
}
using System;
namespace tennaturalnumbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i, num = 10, sum = 0;

            i = 1;
            while (i <= num)
            {
                sum = sum + i;
                i++;
            }

            Console.WriteLine("Sum of first ten no. :- " + num + "\nnatural numbers = " + sum);
            Console.ReadLine();
        }
    }
}
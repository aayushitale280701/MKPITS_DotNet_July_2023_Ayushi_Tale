using System;
namespace oddnosum
{

    public class Program
    {
        public static void Main(string[]args)
        {
            int cnt, cnt1, sum = 0;
            Console.Write("Enter the no. ");
            cnt = Convert.ToInt32(Console.ReadLine());
            cnt1= Convert.ToInt32(Console.ReadLine());

            Console.Write("Odd numbers are :");
            for (cnt  = 1; cnt <= cnt1; cnt++)
            {
                Console.Write("{0} ", 2 * cnt - 1);
                sum += 2 * cnt1 - 1;
            }
            Console.Write("Odd number sum {0} terms : {1} ", cnt1, sum);
            Console.ReadKey();
        }
    }
}

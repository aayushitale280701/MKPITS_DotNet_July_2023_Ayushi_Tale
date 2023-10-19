using System;
namespace sumtennaturalnumbers
{
    public class program
    {
        public static void Main(string[] args)
        {
            int num;
            int sum = 0;
            for (int cnt = 1; cnt <= 10; cnt++)
            {
                Console.WriteLine("Enter the no.");
                num=Convert.ToInt32(Console.ReadLine());
                sum = sum + cnt;
            }
            Console.WriteLine("sum {0}", sum);
            Console.ReadKey();
        }
    }
}
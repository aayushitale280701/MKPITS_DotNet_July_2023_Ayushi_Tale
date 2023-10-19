using System;
namespace sumavgtennaturalnumbers
{
    public class program
    {
        public static void Main(string[] args)
        {
            int num;
            float avg = 0;
            int sum = 0;
            int cnt = 1;
            for (int counter = 1; cnt <= 10; cnt++)
            {
                Console.WriteLine("Enter the no.");
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum + cnt;
             
                 avg = sum / 10.0f;
            }
            Console.WriteLine("sum {0}", sum);
            Console.WriteLine("The average of 10 numbers is {0}", avg);
            Console.ReadKey();
        }
    }
}
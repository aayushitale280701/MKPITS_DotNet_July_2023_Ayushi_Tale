using System;
namespace sumaverage
{
    class Program
    {
        public static void Main(string[] args) 
        {
            int i = 1, num, sum = 0;

            Console.WriteLine("Enter the 10 numbers and calculate sum and average");
            do
            {
                Console.Write("Number -:  ");
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
                i++;
            } while (i <= 10);

            double avg = (double)sum / 10;

            Console.WriteLine("The sum of 10 numbers is: {0}",sum);
            Console.WriteLine("The average of 10 numbers is: {0}",avg);
            Console.ReadKey();
        }
    }
}

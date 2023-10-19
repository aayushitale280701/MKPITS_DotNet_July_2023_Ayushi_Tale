using System;
namespace sumoffiveno
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num;
            int sum = 0;
            for (int cnt=1; cnt<=5; cnt++)
            {
                Console.WriteLine("Enter the number ");
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum+num;

            }
            Console.WriteLine("Sum of five no. = "+sum);
            Console.ReadLine();
        }
    }
}

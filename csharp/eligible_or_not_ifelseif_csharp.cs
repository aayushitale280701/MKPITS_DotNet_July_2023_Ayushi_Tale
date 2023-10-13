using System;
namespace eligibleornot
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num=Convert.ToInt32(Console.ReadLine());

            if(num > 18)
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible for casting your vote.");
            }
        }
    }
}

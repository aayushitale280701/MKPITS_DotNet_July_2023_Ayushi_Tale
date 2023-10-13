using System;
namespace leapyearnot
{
    class Program
    {
        public static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter the year");
            year=Convert.ToInt32(Console.ReadLine());

            if (year % 4 ==0)
            {
                Console.WriteLine("The year is leap");
            }
            else
            {
                Console.WriteLine("The year is not leap");
            }
            Console.ReadKey();
        }
    }
}
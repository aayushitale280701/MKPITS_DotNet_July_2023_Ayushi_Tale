using System;
namespace monthday
{
    class program
    {
        public static void Main(string[] args)
        {
            int day;
            Console.WriteLine("Enter the days.");
            day = Convert.ToInt32(Console.ReadLine());

            if (day == '1' || day == '3' || day == '5' || day == '7')
            {
                Console.WriteLine("Month 31 days.");
            }

            else if (day == '4' || day == '6' || day == '8' || day == '10' || day == '12')
            {
                Console.WriteLine("Month 30 days.");
            }
            else if(day == '2')
            {
                Console.WriteLine("Month on 29 or 32");
            }
        }
    }
}
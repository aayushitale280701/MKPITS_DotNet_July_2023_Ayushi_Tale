using System;
namespace positivenegative
{
    class program
    {
        public static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num=Convert.ToInt32(Console.ReadLine());

            if (num > 0 )
            {
                Console.WriteLine("Number is Positive");
            }
            else
            {
                Console.WriteLine("Number is Negative");
            }
            Console.ReadLine();
        }
    }
}

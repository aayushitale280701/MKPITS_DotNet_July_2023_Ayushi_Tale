using System;
namespace whileloopfactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int fact = 1;
            Console.WriteLine("Enter Number");
            number = Convert.ToInt32(Console.ReadLine());
            while (number > 0)
            {
                fact = fact * number;
                number--;

            }
            Console.WriteLine("Factorial = " + fact);


            Console.ReadKey();
        }
    }
}
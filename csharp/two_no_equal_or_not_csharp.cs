using System;
namespace twonoequalornot
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num1 ,num2;
            Console.WriteLine("Enter the no1.");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the no2.");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Two Number are equa");
            }
            else 
            {
                Console.WriteLine("two not Number are equal");
            }         
            Console.ReadKey();
        }
    }
}
using System;
namespace greaternoifelse
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter Number1");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number2");
            num2=Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Number 1 is greater");
            }
            else
            {
                Console.WriteLine("Number 2 is greater");
            }
            Console.ReadKey();
        }
    }
}

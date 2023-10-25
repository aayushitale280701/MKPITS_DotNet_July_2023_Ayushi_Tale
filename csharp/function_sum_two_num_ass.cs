using System;
using System.Diagnostics.CodeAnalysis;

namespace simplemethod
{
    class program
    {
        static void display(int num1, int num2)
        {
           int sum = num1 + num2;
            Console.WriteLine("Sum of two number  ." + sum);
        }
        static void Main()
        {
            int num1 , num2;
            Console.WriteLine("Enter num1, num2");
            num1=Convert.ToInt32(Console.ReadLine());
            num2= Convert.ToInt32(Console.ReadLine());
            display(num1, num2);
            Console.ReadKey();
        }
    }
}
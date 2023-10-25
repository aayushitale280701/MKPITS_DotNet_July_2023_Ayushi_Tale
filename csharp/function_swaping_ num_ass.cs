using System;
using System.Diagnostics.CodeAnalysis;

namespace swapofnum
{
    class program
    {
        static void display(int num1, int num2)
        {
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1= num1 - num2;      
            Console.WriteLine("Now the first no is " + num1);
            Console.WriteLine("Now the second no is " + num2);
        }
        static void Main()
        {
            int num1, num2;
            Console.WriteLine("Enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            display(num1, num2);
            Console.ReadKey();
        }
    }
}
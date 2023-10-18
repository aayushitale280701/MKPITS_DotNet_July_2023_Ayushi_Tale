using System;
namespace fibonacciseries
{
    class Program
    {
        static void Main()
        {
            int num, f1 = -1, f2 = 1, f;
            Console.Write("Enter the number: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("The Fibonacci Series is: ");
            do
            {
                f = f1 + f2;
                f1 = f2;
                f2 = f;
                Console.Write(f + " ");
                num--;
            } while (num > 0);
            Console.ReadLine();
        }
    }
}

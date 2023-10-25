using System;
namespace oneparameter
{
    class Program
    {
        static void factorial(int num) //method with one integer parameter
        {
            int fact = 1;
            while (num > 0)
            {
                fact = fact * num;
                num--;
            }
            Console.WriteLine("fact " + fact);
        }
        static void Main(string[] args)
        {
            factorial(5);
            Console.ReadKey();
        }
    }
}

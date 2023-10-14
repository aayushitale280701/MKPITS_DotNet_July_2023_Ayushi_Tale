using System;
namespace quadraticequation
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, result;
            Console.WriteLine("Enter A value");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B value");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter C value");
            c = Convert.ToInt32(Console.ReadLine());

            result = a * b - 4 * a * c;

            if (result != 0)
            {
                Console.WriteLine("It is imaginanry");
            }
            else
            {
                Console.WriteLine("It is real");
            }
        }
    }
}
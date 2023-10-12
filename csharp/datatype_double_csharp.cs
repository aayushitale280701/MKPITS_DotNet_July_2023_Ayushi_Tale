using System;
namespace datatypedouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = 123456.1234567890123;
            Console.WriteLine("value"+b);
            Console.WriteLine("Enter value");
            b=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("value =" + b);
            Console.ReadLine();
        }
    }
}
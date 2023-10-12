using System;
namespace datatypefloat
{
    class Program
    {
        static void Main(string[] args)
        {
            float b = 123.4567890f;
            Console.WriteLine("value " + b);
            Console.WriteLine("Enter value");
            b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("value =" + b);
            Console.ReadKey();
        }
    }
}

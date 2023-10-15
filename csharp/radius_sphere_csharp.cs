using System;
namespace radiussphere
{
    class Program
    {
        public static void Main()
        {
            float r;
            float pi = 3.1415926535f;

            Console.Write("Radius: ");
            r = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(4 * pi * (r * r));

            Console.WriteLine(4f / 3f * pi * (r * r * r));
        }
    }
}
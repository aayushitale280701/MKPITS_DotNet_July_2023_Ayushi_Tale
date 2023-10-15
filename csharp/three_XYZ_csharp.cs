using System;
namespace threexyz
{
    class program
    {
        public static void Main(string[] args)
        {
            int x, y, z, total;
            Console.WriteLine("Enter num");
            x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second num");
            y=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third num");
            z=Convert.ToInt32(Console.ReadLine());

            total = (x) + (y) * (z);
            Console.WriteLine("Total", + total);
            total= (x) * (y) + (y) * (z);
            Console.WriteLine("Total", + total);
            Console.ReadKey();
        }
    }
}
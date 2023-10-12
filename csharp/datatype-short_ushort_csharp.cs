using System;
namespace datatypeshortushort
{
    class Program
    {
        public static void Main(string[] args)
        {
            short b = 25809;
            Console.WriteLine("Value ="+b);
            Console.WriteLine("Enter Short");
            b=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("value =" + b);

            ushort b1 = 23890;
            Console.WriteLine("value =" + b1);
            Console.WriteLine("Enter ushort");
            b1 = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("value =" + b1);
            Console.ReadKey();
        }
    }
}

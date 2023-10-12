using System;
namespace datatypelongulong
{
    class Program
    {
        public static void Main(string[] args)
        {
            long b = -2589022888L;
            Console.WriteLine("value ="+b);
            Console.WriteLine("Enter ");
            b=Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("value =" + b);

            ulong b1 = 2389000L;
            Console.WriteLine("value =" + b1);
            Console.WriteLine("Enter");
            b1=Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("value =" + b1);
            Console.ReadLine();
        }
    }
}
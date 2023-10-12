using System;
namespace datatypeintuint
{
    class program
    {
        static void Main(string[] args)
        {
            int b = -25890;
            Console.WriteLine("value " + b);
            Console.WriteLine("Enter ");
            b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("value =" + b);

            uint b1 = 2389000;
            Console.WriteLine("value " + b1);
            Console.WriteLine("Enter ");
            b1=Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("value =" + b1);

        }
    }
}

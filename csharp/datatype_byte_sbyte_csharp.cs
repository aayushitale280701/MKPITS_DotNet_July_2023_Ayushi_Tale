using System;
namespace datatypebytesbyte
{
    class Program
    {
        public static void Main(string[] args)
        {
            byte b = 25;
            Console.WriteLine("byte value =" +b);
            Console.WriteLine("Enter byte:");
            b=Convert.ToByte(Console.ReadLine());
            Console.WriteLine("byte =" + b);

            sbyte b1 = -23;
            Console.WriteLine("sbyte value =" + b1);
            Console.WriteLine("Enter sbyte");
            b1=Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("sbyte =" + b1);
            Console.ReadLine();
        }
    }
}

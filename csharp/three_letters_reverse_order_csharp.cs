using System;
using System.Security.Cryptography;

namespace threelettersreverseorder
{
    class program
    {
        static void Main(string[] args)
        {
            char  c1, c2, c3;
            Console.WriteLine("Enter char: a");
            c1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter char: b");
            c2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter char: t");
            c3 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(" " +c3);
            Console.WriteLine(" " +c2);
            Console.WriteLine(" " +c1);

        }
    }
}

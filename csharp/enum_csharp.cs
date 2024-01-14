using System;
using System.Collections.Generic;
namespace enum_csharp
{
    class Program
    {
        enum grade { a,b, c };
        static void Main(string[] args)
        {
            int g = Convert.ToInt32(grade.b);
            Console.WriteLine("Value of b is..." + g);
            Console.ReadLine();
        }
    }
}
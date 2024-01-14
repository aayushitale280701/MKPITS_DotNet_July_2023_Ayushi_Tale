using System;
using System.Collections.Generic;

namespace enum_Category
{
    internal class Program
    {
        enum category { Student, IT_Professional};
        static void Main(string[] args)
        {
            int c = Convert.ToInt32(category.Student);
            if (c == 0)
            {
                Console.WriteLine("Category is Student");
            }
            else if (c == 1)
            {
                Console.WriteLine("Category is IT_Professional");
            }
            Console.ReadLine();
        }
    }
}

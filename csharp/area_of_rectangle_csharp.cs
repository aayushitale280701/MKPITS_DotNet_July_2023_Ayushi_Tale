﻿using System;
namespace areaofrectangleprogram
{
    class program
    {
        static void Main()
        {
            int length, bredth, area;
            Console.WriteLine("Enter length");
            length=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter bredth");
            bredth=Convert.ToInt32(Console.ReadLine());

            area = length * bredth;
            Console.WriteLine("Area of Rectangle =" + area);
            Console.ReadKey();

        }
    }
}
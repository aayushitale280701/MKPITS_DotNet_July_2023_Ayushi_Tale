﻿using System;
namespace triangle
{
    class Program
    {
        public static void Main()
        {
            int sidea, sideb, sidec;

            Console.Write("Check whether a triangle is Equilateral, Isosceles or Scalene:\n");

            Console.Write("Enter side 1 of triangle: ");
            sidea = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter side 2 of triangle: ");
            sideb = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter side 3 of triangle: ");
            sidec = Convert.ToInt32(Console.ReadLine());



            if (sidea == sideb && sideb == sidec)
            {
                Console.Write("This is an equilateral triangle.\n");
            }
            else if (sidea == sideb || sidea == sidec || sideb == sidec)
            {
                Console.Write("This is an isosceles triangle.\n");
            }
            else
            {
                Console.Write("This is a scalene triangle.\n");
            }
        }
    }
}

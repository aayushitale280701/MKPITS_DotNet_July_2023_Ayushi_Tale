﻿using System;
namespace areaofcirclecircumference
{
    class Program
    {
        static void Main(string[] args) 
        {
            int radius;
            float area, circumference;
            Console.WriteLine("Enter the Radius");
            radius=Convert.ToInt32(Console.ReadLine());
            area=3.14f*radius*radius;
            circumference = 2 * 3.14f * radius;
            Console.WriteLine("Area =" + area);
            Console.WriteLine("circumference =" + circumference);
            Console.ReadKey();

        }
    }
}

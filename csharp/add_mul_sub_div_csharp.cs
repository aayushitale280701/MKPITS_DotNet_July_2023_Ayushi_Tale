﻿using System;

namespace addsubtmuldivtwonumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, add, sub;
            float div, mul;

            Console.WriteLine("Enter The Number1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Number2");
            num2 = Convert.ToInt32(Console.ReadLine());

            add = num1 + num2;
            sub = num1 - num2;
            mul = num1 * num2;
            div = (float)num1 / (float)num2;

            Console.WriteLine("Addition =" + add);
            Console.WriteLine("Subtraction =" + sub);
            Console.WriteLine("Multiplication =" + mul);
            Console.WriteLine("Divied =" + div);
            Console.ReadKey();



        }
    }
}


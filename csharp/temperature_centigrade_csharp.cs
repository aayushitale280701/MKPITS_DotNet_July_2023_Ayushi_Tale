﻿using System;
namespace temperaturecentigrade
{
    class Program
    {
        public static void Main(string[] args)
        {
            int temp;
            Console.WriteLine("Enter Temperature");
            temp=Convert.ToInt32(Console.ReadLine());

            if (temp < 0)
            {
                Console.WriteLine("Freezing weather");
            }
            else if (temp > 0 && temp < 10)
            {
                Console.WriteLine("Very Cold weather");
            }
            else if (temp > 10 && temp < 20)
            {
                Console.WriteLine("Cold weather");
            }
            else if (temp > 20 && temp < 30)
            {
                Console.WriteLine("Normal in Temp");
            }
            else if (temp > 30 && temp < 40)
            {
                Console.WriteLine("Very Cold weather");
            }
            else if (temp > 40 && temp < 50)
            {
                Console.WriteLine("Its Hot");
            }
            else
            {
                Console.WriteLine("Very Hot");
            }
        }
    }
}

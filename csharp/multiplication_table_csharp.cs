﻿using System;
namespace multiplicationtable
{
    class program
    {
        static void Main()
        {
            int num;
            Console.Write("Enter an Number: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; ++i)
            {
                Console.WriteLine("{0} * {1} = {2}", num, i, num * i);
            }
        }
    }

}

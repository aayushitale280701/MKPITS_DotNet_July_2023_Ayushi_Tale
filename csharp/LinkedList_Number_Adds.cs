using System;
using System.Collections;
using System.Collections.Generic;
namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> Num = new LinkedList<int>();
            Num.AddLast(45);
            Num.AddLast(55);
            Num.AddLast(75);
            Num.AddLast(65);
            Num.AddLast(35);           

            foreach(int num in Num)
            {
                Console.WriteLine(Num);
            }
        }
    }
}
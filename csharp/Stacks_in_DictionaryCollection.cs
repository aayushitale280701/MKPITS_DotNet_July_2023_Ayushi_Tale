using System;
using System.Collections;
using System.Collections.Generic;
namespace DictionaryCollection_Ex
{
    class Program
    {
        static void Main(String[] args)
        {
            Stack<int>stc = new Stack<int>();
            stc.Push(1);
            stc.Push(7);
            stc.Push(3);
            stc.Push(9);
            stc.Push(5);
            stc.Push(6);
            stc.Push(2);
            Console.WriteLine(stc.Pop());
            Console.WriteLine(stc.Peek());
            Console.WriteLine(stc.Peek());
            Console.WriteLine("\n");
            foreach (int i in stc)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
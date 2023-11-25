using System;
using System.Collections;
namespace usingInteger
{
    class program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("Adding some No   ");
            al.Add(1);
            al.Add(2);
            al.Add(3);
            al.Add(4);
            Console.WriteLine("\n");
            Console.WriteLine("Capacity: {0} ", al.Capacity);
            Console.WriteLine("Count: {0} ", al.Count);
            Console.WriteLine("\n");
            Console.WriteLine("Content  ");
            foreach(int i in al) Console.WriteLine("  "+i);
            Console.WriteLine("\n");
            Console.WriteLine("Stored in Contened  ");
            al.Sort();
            foreach(int i in al) Console.WriteLine("  "+i);
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
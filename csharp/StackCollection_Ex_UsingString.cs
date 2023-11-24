using System;
using System.Collections;
namespace StackCollectionEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push("Ayushi");
            s.Push("Om");
            s.Push("Rajesh");
            s.Push("Ritu");
            foreach(string val in s)
            {
                Console.WriteLine("Name: "+val);
            }
            s.Push("Khushi");
            Console.WriteLine("\n");
            Console.WriteLine("Last item added: "+s.Peek());
            Console.WriteLine("After peek method");
            Console.WriteLine("\n");
            foreach(string val in s)
            {
                Console.WriteLine("Name: " + val);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Last item added: "+s.Pop());
            Console.WriteLine("After pop method");
            Console.WriteLine("\n");
            foreach(string val in s)
            {
                Console.WriteLine("Name: "+val);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Last item added: "+s.Pop());
            Console.WriteLine("After pop Method");
            Console.WriteLine("\n");
            foreach (string val in s)
            {
                Console.WriteLine("Name: "+val);
            }
            Console.ReadLine();
        }
    }
}
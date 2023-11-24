using System;
using System.Collections;
namespace InCharQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue('A');
            q.Enqueue('B');
            q.Enqueue('C');
            q.Enqueue('D');
            Console.WriteLine("Current Queue: ");
            foreach(char c in q) Console.WriteLine(c+" ");
            Console.WriteLine("\n");
            q.Enqueue('V');
            q.Enqueue('H');
            Console.WriteLine("Current Queue: ");
            foreach(char c in q ) Console.WriteLine(c+" ");
            Console.WriteLine("\n");
            Console.WriteLine("Removing Some Value");
            char ch = (char)q.Dequeue();
            Console.WriteLine("The removing Value {0}", ch);
            ch = (char)q.Dequeue();
            Console.WriteLine("The removing value {0}",ch);
        }
    }
}
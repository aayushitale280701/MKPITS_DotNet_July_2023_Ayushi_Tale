using System;
using System.Collections;
using System.Collections.Generic;
namespace DictionaryCollection_Ex
{
    class Program
    {
        static void Main (String[] args)
        {
            Queue<string> msgs = new Queue<string>();
            msgs.Enqueue("Message 1");
            msgs.Enqueue("Message 2");
            msgs.Enqueue("Message 3");
            msgs.Enqueue("Message 4");
            msgs.Enqueue("Message 5");
            msgs.Enqueue("Message 6");
            Console.WriteLine(msgs.Dequeue());
            Console.WriteLine(msgs.Peek());
            Console.WriteLine(msgs.Peek());
            Console.WriteLine("\n");
            foreach(string msg in msgs)
            {
                Console.WriteLine(msg);
            }
            Console.ReadKey();
        }
    }
}
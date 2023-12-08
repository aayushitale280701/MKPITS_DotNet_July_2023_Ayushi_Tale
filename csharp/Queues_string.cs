using System;
using System.Collections.Generic;
using System.Collections;

namespace Queues_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> Msg = new Queue<string>();
            Msg.Enqueue("Message 1");
            Msg.Enqueue("Message 2");
            Msg.Enqueue("Message 3");
            Msg.Enqueue("Message 4");
            Console.WriteLine(Msg.Dequeue());
            Console.WriteLine(Msg.Peek());
            Console.WriteLine(Msg.Peek());

            Console.WriteLine("\n");

            foreach(string M in Msg)
            {
                Console.WriteLine(Msg);
            }
        }
    }
}
using System;
using System.Collections;
namespace queue_using_string
{
    class program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue("Ayushi");
            q.Enqueue("Om");
            q.Enqueue("Khushi");
            q.Enqueue("Aruushi");
            q.Enqueue("Yash");
            q.Enqueue("Tanisha");
            Console.WriteLine("Current Queue: ");
            foreach (string s in q)
            {
                Console.WriteLine(s + " ");
            }
            Console.WriteLine("\n");
            q.Enqueue("Varun");
            q.Enqueue("Avinash");
            Console.WriteLine("Current Queue");
            foreach(string s in q)
            {
                Console.WriteLine(s+" ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Removing Some Value");
            string ch=(string)q.Dequeue();
            Console.WriteLine("The removing value:{0}", ch);
            ch=(string)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);
            Console.ReadLine();
        }
    }
}
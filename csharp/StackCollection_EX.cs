using System;
using System.Collections;
namespace EX_StackCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push('A');
            s.Push('B');
            s.Push('C');
            s.Push('D');
            s.Push('E');
            Console.WriteLine("Current Stack: ");
            foreach(char c in s)
            {
                Console.WriteLine(c+" ");
            }

            Console.WriteLine("\n");
            s.Push('F');
            s.Push('G');
            Console.WriteLine("The next poppable value in stack :{0}",s.Peek());
            Console.WriteLine("Current Stack: ");
            foreach (char c in s)
            {
                Console.WriteLine(c+" ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Removing Value: ");
            s.Pop();
            s.Pop();
            s.Pop();
            Console.WriteLine("Current Stack: ");
            foreach(char c in s)
            {
                Console.WriteLine(c+" ");
            }
            Console.ReadLine();
        }
    }
}
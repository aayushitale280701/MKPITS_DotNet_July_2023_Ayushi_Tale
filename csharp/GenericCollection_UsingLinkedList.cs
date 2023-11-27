using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace usingLinkedList
{
    class program
    {
        static void Main(string[] args)
        {
            LinkedList<int> li = new LinkedList<int>();
            li.AddLast(23);
            li.AddLast(34);
            li.AddLast(25);
            li.AddLast(30);
            li.AddFirst(19);
            li.AddFirst(10);
            
            LinkedListNode<int> node = li.Find(30);
            li.AddBefore(node, 4);

            foreach (int it in li)
            {
                Console.WriteLine(it); 
            }
            Console.ReadLine();
        }
    }
}
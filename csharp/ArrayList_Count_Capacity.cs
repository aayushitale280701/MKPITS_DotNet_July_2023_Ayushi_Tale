using System;
using System.Collections;
namespace CountCapacity
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(11);
            ar.Add(12);
            ar.Add(13);
            foreach(object obj in ar)
            {
                Console.WriteLine("Student Roll no:- "+obj);
            }
            Console.WriteLine("Capacity:  "+ ar.Capacity);
            Console.WriteLine("Count:  " + ar.Count);
            Console.ReadLine();
        } 
    }
}
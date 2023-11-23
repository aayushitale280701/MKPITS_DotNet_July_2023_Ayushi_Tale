using System;
using System.Collections;
namespace ShortMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(19);
            ar.Add(16);
            ar.Add(20);
            Console.WriteLine("Array List Collection Without Sorting");
            foreach(int obj in ar)
            {
                Console.WriteLine("Student Rollno:  "+obj);
            }
            ar.Sort();
            Console.WriteLine("Arraylist Collection with sorting  ");
            foreach(int obj in ar)
            {
                Console.WriteLine("Student Rno:  "+obj);
                
            }
            Console.ReadKey();
        }
    }
}
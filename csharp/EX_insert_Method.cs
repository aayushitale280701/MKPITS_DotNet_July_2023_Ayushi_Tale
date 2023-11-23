using System;
using System.Collections;
namespace insertmethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(19);
            ar.Add(10);
            ar.Add(18);
            ar.Add(20);
            Console.WriteLine("ArrayList Collection Without Intrest");
            foreach(object o in ar)
            {
                Console.WriteLine("Student Rno:  "+o);
            }
            ar.Insert(2, 17);
            ar.Sort();
            Console.WriteLine("ArrayList Collection With Intrest");
            foreach (object o in ar)
            {
                Console.WriteLine("Student Rno:  "+o);
            }
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections;
namespace remove
{
    class program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(12);
            ar.Add(13);
            ar.Add(14);
            ar.Add(15);
            Console.WriteLine("ArrayList Collection without Remove   ");
            foreach (object o in ar)
            {
                Console.WriteLine("Student RollNo:  "+o);
            }
            ar.Remove(12);
            Console.WriteLine("\n");
            Console.WriteLine("ArrayList Collection After Removingat (12)   ");
            foreach(object o in ar)
            {
                Console.WriteLine("Student Rollno:  "+o);
            }
            ar.RemoveAt(1);
            Console.WriteLine("\n");
            Console.WriteLine("ArrayList Collection After Removingat 1");
            foreach (int obj in ar)
            {
                Console.WriteLine("Student Rollno " + obj);
            }
            Console.ReadLine();
        }
    }
}
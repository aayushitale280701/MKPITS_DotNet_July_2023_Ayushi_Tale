using System;
using System.Collections;
namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("Ayushi");
            ar.Add("Khushi");
            ar.Add("Piyush");
            foreach (object obj in ar)
            {
                Console.WriteLine("Student Name  " + obj);
            }
        }
    }
}
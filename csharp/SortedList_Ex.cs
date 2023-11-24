using System;
using System.Collections;
namespace SortedListEx
{
    class program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add("02", "Ayushi");
            sl.Add("03", "Om");
            sl.Add("04", "Rajesh");
            if (sl.ContainsValue("Nishu")) 
            {
                Console.WriteLine("The student name is already existed");
            }
            else
            {
                sl.Add("05","Nishu");
            }
            ICollection key=sl.Keys;
            foreach(string s in key)
            {
                Console.WriteLine(s + "  " + sl[s]);
            }
            Console.ReadLine();
        }
    }
}
using System;
using System.Text;

namespace InvalidCastException
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Ayushi");
            sb.Append("Tale");
            Console.WriteLine("Sb= "+sb.ToString());
            object obj = sb;
            Console.WriteLine("Obj= "+obj.ToString());
            try
            {
                System.IO.StreamReader sr = (System.IO.StreamReader)obj;
            }
            catch(Exception ie)
            {
                Console.WriteLine(ie.ToString());
            }
            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}
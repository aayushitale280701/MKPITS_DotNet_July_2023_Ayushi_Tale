using System;
using System.Text;

namespace UsingStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Ayushi \n");
            sb.Append("Tale");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("\n");
            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}
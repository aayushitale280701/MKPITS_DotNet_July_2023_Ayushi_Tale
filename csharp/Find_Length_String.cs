using System;
namespace lengthString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int l = 0;
            Console.WriteLine("Enter the String");
            str= Console.ReadLine();
            foreach(char chr in str)
            {
                l += 1;
            }
            Console.WriteLine("Length of string is :- {0} \n", l);
            Console.ReadKey();
        }
    }
}
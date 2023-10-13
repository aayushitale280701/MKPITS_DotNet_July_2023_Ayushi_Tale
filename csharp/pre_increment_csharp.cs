using System;
namespace preincrement
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i = 0;
            int j = i++;
            Console.WriteLine("value of i: "+i+"\n value of j: "+j);
            Console.ReadLine();
        }
    }
}

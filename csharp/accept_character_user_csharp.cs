using System;
namespace acceptcharacteruser
{
    class Program
    {
        static void Main(string[] args) 
        {
            char ch;
            Console.WriteLine("Enter the character");
            ch=Convert.ToChar(Console.Read());
            Console.WriteLine("ch = " +ch);
            Console.ReadKey();
        }
    }
}
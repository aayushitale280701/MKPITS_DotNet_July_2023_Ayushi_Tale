using System;
namespace vawel
{
    class Program
    {
        public static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter a charecter");
            ch=Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                Console.WriteLine("charecter are vowal");
            else
                Console.WriteLine("character are not volwe");
        }
    }
}
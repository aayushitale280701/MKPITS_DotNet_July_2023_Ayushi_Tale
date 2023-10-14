using System;
namespace vawel
{
    class Program
    {
        public static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter a alphabet");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                Console.WriteLine("alphabet are vowal");
            else if (ch == 'b'|| ch == 'c' || ch == 'd' || ch == 'f' || ch == 'g' || ch == 'h' || ch == 'j' || ch == 'k' || ch == 'l' || ch == 'm' || ch == 'n'||
                ch == 'p' || ch == 'q' || ch == 'r' || ch == 's' || ch == 't' || ch == 'v' || ch == 'w' || ch == 'x' || ch == 'y' || ch == 'z')
                Console.WriteLine("alphabet are consonant volwe");
            else
            {
                Console.WriteLine("Invalid alphabet letter");
            }
        }
    }
}

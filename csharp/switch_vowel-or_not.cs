using System;
namespace switchvowelornot
{
    class program
    {
        public static void Main(string[] args)
        {
            char op;
            Console.WriteLine("Enter character");
            op=Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Enter character is vowel");
                    break;
                default:
                    Console.WriteLine("Enter character is consonent");
                    break;

                    Console.ReadKey();

            }

        }
    }
}
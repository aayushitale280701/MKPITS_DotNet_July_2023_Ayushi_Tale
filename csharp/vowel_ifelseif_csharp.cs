using System;
namespace vawel
{
    class Program
    {
        public static void Main(string[] args)
        {
            char ch;
           
            Console.Write("Enter an Alphabet (A-Z or a-z) : ");
            ch = Convert.ToChar(Console.ReadLine().ToLower());

            int i = ch;
            if (i >= 48 && i <= 57)
            {
                Console.Write("You entered a number, Please enter an alpahbet.");
            }
            else if (ch=='a'|| ch=='i'|| ch=='o' ||ch=='e' ||ch=='u')
            {
                Console.WriteLine("The Alphabet is vowel");
            }
            else
            {
                Console.WriteLine("The Alphabet is not vowel");
            }
        }
    }
}
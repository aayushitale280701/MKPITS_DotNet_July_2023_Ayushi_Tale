using System;
namespace vawel
{
    class Program
    {
        public static void Main(string[] args)
        {
            char ch;

            Console.Write("Enter the grade: ");
            ch = Convert.ToChar(Console.ReadLine().ToLower());
            

            int i = ch;
            if (ch== 'E')
            {
                Console.Write("Excellent");
            }
            else if (ch=='V')
            {
                Console.WriteLine("Very Good");
            }
            else if (ch=='G')
            {
                Console.WriteLine("Good");
            }
            else if (ch == 'A')
            {
                Console.WriteLine("Average");
            }
            else if (ch == 'F')
            {
                Console.WriteLine("Fail");
            }
            else
            {
                Console.WriteLine("Invalid Grade Found.");
            }
        }
    }
}
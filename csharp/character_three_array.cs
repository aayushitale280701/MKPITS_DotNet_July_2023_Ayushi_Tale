using System;
namespace characterthreearray
{
    class program
    {
        static void Main(string[] args)
        {
            Char[] ch = new char[3];
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Number");
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0}", ch[i]);
            }
           
            Console.ReadKey();
        }
    }
}
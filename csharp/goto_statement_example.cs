using System;
namespace gotostatement
{
    class program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number");
            num=Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0) goto Even;
            Console.WriteLine("Odd number");
            goto End;
        Even:
            Console.WriteLine("Even number.");
        End:
            Console.WriteLine("Bye");
        Console.ReadKey();
        }
    }
}
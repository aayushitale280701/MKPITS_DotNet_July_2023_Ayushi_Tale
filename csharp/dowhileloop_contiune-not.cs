using System;
namespace dowhileloopcontinueornot
{
    class dowhileloop_continue_not
    {
        static void Main(string[] args)
        {
            int num, square;
            char choice = 'y';
            do
            {
                Console.WriteLine("Enter the number");
                num = Convert.ToInt32(Console.ReadLine());

                square = num * num;
                Console.WriteLine("Square =" + square);
                Console.WriteLine("Do you want to contiune, press y or n");
                choice = Convert.ToChar(Console.ReadLine());
            }
            while (choice == 'y' || choice == 'Y');
            Console.ReadLine();
        }
    }
}
using System;
namespace height
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num=Convert.ToInt32(Console.ReadLine());

            if (num > 10) 
            {
                Console.WriteLine("Your height is tall");
            }
            else
            {
                Console.WriteLine("Your height is short");
            }
        }
    }
}

using System;
namespace factorial
{
    public class program
    {
        static void Main(string[] args)
        {
            int num;
            int fact = 1;
            Console.WriteLine("Enter the number");
            num=Convert.ToInt32(Console.ReadLine());

            for (int counte=num; counte>0; counte--)
            {
                fact=fact*counte;
            }
            Console.WriteLine("Factorial:- {0}", fact);
            Console.ReadLine();
        }
    }
}
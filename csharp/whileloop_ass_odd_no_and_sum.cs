using System;
namespace oddnoandsum
{
    class Program
    {
        public static void Main()
        {
            int i = 1, num, sum = 0;

            Console.Write("Enter the number : ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nThe odd numbers are :");
            while (i <= num)
            {
                Console.Write(" {0} ", 2 * i - 1);
                sum += 2 * i - 1;
                i++;
            }

            Console.Write("\nThe Sum of odd Natural Number upto {0} terms : {1} ", num, sum);
            Console.ReadLine();
        }
    }
}


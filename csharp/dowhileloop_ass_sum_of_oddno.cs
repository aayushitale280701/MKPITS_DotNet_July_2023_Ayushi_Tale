using System;
namespace sumofoddno
{

    class Program
    {
        public static void Main(string[] args)
        {
            int i = 1, num, sum = 0;
            Console.Write("Enter number of terms : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe odd numbers are :");

            do
            {
                Console.Write(" {0} ", 2 * i - 1);
                sum += 2 * i - 1;
                i++;
            } while (i <= num);

            Console.WriteLine("\nThe Sum of odd Natural Number upto terms {0} ",sum);
            Console.ReadKey();
        }
    }
}

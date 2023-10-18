using System;
namespace sumofonetosevenno
{
    class Program
    {
        public static void Main()
        {
            int i = 1, sum = 0;

            do
            {
                sum += i;
                i++;
            } while (i <= 7);

            Console.WriteLine("The sum of the first 7 natural numbers is: " + sum);
            Console.ReadKey();
        }
    }
}

using System;
namespace sumofonetoten
{
    class program
    {
        public static void Main(string[] args)
        {
            int i = 1, sum = 0;

            do
            {
                sum += i;
                i++;
            } while (i <= 10);

            Console.WriteLine("Sum of first 10 natural numbers is: " + sum);
            Console.ReadLine();
        }
    }
}

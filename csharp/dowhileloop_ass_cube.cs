using System;
namespace cube
{
    class program
    {
        public static void Main(string[] args)
        {
            int i = 1, num, cube;

            Console.Write("Enter an integer: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The cube of the numbers up to {0} are:", num);

            do
            {
                cube = i * i * i;
                Console.WriteLine("Number is: {0} and cube of the {1} is: {2}", i, i, cube);
                i++;
            } while (i <= num);
        }
    }
}

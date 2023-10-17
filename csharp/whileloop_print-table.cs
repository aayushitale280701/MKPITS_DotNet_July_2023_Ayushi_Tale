using System;
namespace whileloopprinttable
{
    class program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter No.");
            number=Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int counter = 1;
            while (counter <=10 )
            {
                result = number * counter;
                Console.WriteLine("{0} * {1} = {2}", number, counter, result);
                counter++;
            }
            Console.ReadLine();
        }
    }
}
using System;
namespace whileloopevenno
{
    class program
    {
        static void Main(String[] args)
        {
            int counter = 1;
            while (counter <= 20)
            {
                if (counter % 2 != 0)
                {
                    Console.WriteLine("{0} is prime ", counter);
                }
                counter = counter + 1;
            }
            Console.ReadLine();
        }
    }
}
using System;
namespace whileloopevenno
{
    class program
    {
        static void Main(String[] args)
        {
            int counter =20;
            while (counter <= 30)
            {
                if (counter % 2 != 0)
                {
                    Console.WriteLine("{0} is odd ", counter);
                }
                counter = counter + 1;
            }
            Console.ReadLine();
        }
    }
}
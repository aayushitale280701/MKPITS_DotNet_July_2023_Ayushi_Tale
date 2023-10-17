using System;
namespace whilelooptentoone
{
    class program
    {
        static void Main(string[] args)
        {
            int counter = 10;
            while (counter > 0)
            {
                Console.WriteLine(counter);
                counter --;
            }
            Console.ReadKey();
        }
    }
}
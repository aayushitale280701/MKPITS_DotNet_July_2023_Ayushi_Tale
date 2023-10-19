using System;
namespace rowcolsame
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int outercounter=1; outercounter<=3; outercounter++)
            {
                for (int innercounter=1; innercounter<=outercounter; innercounter++)
                {
                    Console.Write( "*\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

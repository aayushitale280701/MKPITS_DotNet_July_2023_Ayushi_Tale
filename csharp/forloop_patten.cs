using System;
namespace patten
{
    public class program
    {
        public static void Main(string[] args)
        {
            for (int innercounter = 0, outercounter = 0; innercounter <= 5; innercounter++, outercounter++)
            {
                Console.WriteLine("Innercounter {0}",innercounter);
                Console.WriteLine("Outercounter {0}",outercounter);
            }
            Console.ReadLine();
        }
    }
}
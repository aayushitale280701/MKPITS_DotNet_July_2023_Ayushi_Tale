using System;
namespace dowhileloopexone
{
    class program
    {
        static void Main(string[] args)
        {
            int num = 11;
            do
            {
                Console.WriteLine("{0} = num", num);
                num++;
            }
            while (num <= 5);
            Console.WriteLine("Hello");
            Console.ReadLine();
        }
    }
}
using System;
namespace exampleofcontinue
{
    class example_of_continue
    {
        static void Main(string[] args)
        {
            int num = 0;
            while(true)
            {
                Console.WriteLine(num);
                num++;
                if (num < 10)
                {
                    continue;

                }
                else
                    break;
            }
            Console.ReadKey();
        }
    }
}
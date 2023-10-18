using System;
namespace printonetofive
{
    class program
    {
        public static void Main(string[] args)
        {
            int num = 1;
            do
            {
                Console.WriteLine("{0} num", num);
                num++;
            }
            while (num <= 5);
            Console.ReadLine();
        }  
    }
}
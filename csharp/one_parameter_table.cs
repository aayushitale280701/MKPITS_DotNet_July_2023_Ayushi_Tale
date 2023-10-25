using System;
namespace oneparametertable
{
    class program
    {
        static int claculate(int num)
        {
            int result = 0;
            int cnt = 1;

            for ( cnt = 1; cnt <= 10; cnt++)
            {
                 result = num * cnt;
                Console.WriteLine(num + "*" + cnt + "=" + result + "\n");
            }
            return result;
        }
            static void Main(string[] args)
            {
                int number;
                Console.WriteLine("Enter Number");
            number=Convert.ToInt32(Console.ReadLine());
                int  res = claculate(number);
               
                Console.ReadKey();
            }       
    }
}
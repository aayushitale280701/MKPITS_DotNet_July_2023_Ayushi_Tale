using System;
namespace oneparametertable
{
    class program
    {
        static int claculate(int num)
        {
            int result = 0;
           
           if (num%2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
            return result;
        }
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter Number");
            number = Convert.ToInt32(Console.ReadLine());
            int res = claculate(number);

            Console.ReadKey();
        }
    }
}
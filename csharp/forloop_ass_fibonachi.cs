using System;
namespace fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num1 = 0,num2=1 ;
            int add = num1 + num2;
            int cnt;
            Console.WriteLine("Enter Number");
            num=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0},{1},", num1, num2);
            for(cnt=3; cnt <= num; cnt++)
            {
                Console.Write(" {0}, ", add);
                num1 = num2;
                num2 = add;
                add = num1 + num2;
            }
            Console.ReadKey();
        }
    }
}
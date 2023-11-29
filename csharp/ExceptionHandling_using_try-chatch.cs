using System;
namespace using_try_chatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int n;
            Console.WriteLine("Enter number 1 ");
            num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2 ");
            n=Convert.ToInt32(Console.ReadLine());
            int res = 0;
            try
            {
                res = num / n;//error will come here the program terminated
            }
            catch(Exception ee)
            {
                Console.WriteLine("Cannot divided by zero ");
            }
            Console.WriteLine("Res= " + res);
            Console.WriteLine("Bye ");
            Console.ReadKey();
        }
    }
}
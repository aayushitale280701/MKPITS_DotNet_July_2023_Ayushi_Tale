using System;
namespace UsingTryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int n;
            Console.WriteLine("Enter No 1 ");
            num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter No 2 ");
            n=Convert.ToInt32(Console.ReadLine());
            int res = 0;
            try
            {
                res = num / n;//error will come here and program terminated
            }
            catch (Exception ee) 
            {
                Console.WriteLine("Catch block is executing  ");
                Console.WriteLine("Cannot divided by zero  ");
            }
            finally
            {
                Console.WriteLine("Finally block is executings  ");
                Console.WriteLine("Res= " + res);
            }
            Console.ReadKey();
        }
    }
}
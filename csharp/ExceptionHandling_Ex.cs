using System;
namespace Exception_Handling_ex
{
    class program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int n = 0;
            int res = num / n;//error will Come here and program terminated
            Console.WriteLine("Res = "+res);
            Console.WriteLine("Bay");
            Console.ReadLine();
        }
    }
}
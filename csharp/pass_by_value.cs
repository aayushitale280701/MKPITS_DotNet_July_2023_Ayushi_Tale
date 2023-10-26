using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{

    class Program
    {
        
        static void display(int num)
        {
             num = 20;//local variable
            Console.WriteLine("num inside method " + num);

        }
        static void Main(string[] args)
        {
            int num = 10;
            display(num);
            Console.WriteLine("num (shared)  " + num);
            Console.ReadKey();
        }
    }
}

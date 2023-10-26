using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraynewkeyword
{

    class Program
    {


        static void Main(string[] args)
        {
            int[] num= new int[3];
             num[0]=  11;
            num[1]= 12;
            num[2]= 13;
            Console.WriteLine("num[0]= " + num[0]);
            Console.WriteLine("num[1]= " + num[1]);
            Console.WriteLine("num[2]= " + num[2]);

            Console.ReadKey();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circleandcirc
{

    class Program
    {

        static void calculate(int radius, out float area, out float circ)
        {
            area = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;
        }
        static void Main(string[] args)
        {
            int radius = 10;
            float area = 0, circ = 0;
            calculate(radius, out area, out circ);
            Console.WriteLine("Area =" + area);
            Console.WriteLine("Circ =" + circ);
            Console.ReadKey();
        }
    }
}
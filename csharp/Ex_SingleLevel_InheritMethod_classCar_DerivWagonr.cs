using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritMethod
{
    class car
    {
        public void start()
        {
            Console.WriteLine("Car is starting");
        }
    }
    class wagonr : car
    {
        public void startmusic()
        {
            Console.WriteLine("Music is starting");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            wagonr r = new wagonr();
            r.start();
            r.startmusic();

            Console.ReadLine();

        }
    }
}

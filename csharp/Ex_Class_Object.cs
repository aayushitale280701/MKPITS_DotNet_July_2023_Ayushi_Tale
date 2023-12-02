using System;
using System.Collections.Generic;
using System.Collections;
namespace Class_Object
{
    class Rectangle
    {
        int length;
        int breadth;

        public void getdata(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public void dispaly()
        {
            int area = length*breadth;
            Console.WriteLine("Area: "+area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.getdata(4,5);
            r.dispaly();
            Console.ReadLine();
        }
    }
}
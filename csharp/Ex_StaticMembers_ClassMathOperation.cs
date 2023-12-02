using System;
using System.Collections;
using System.Collections.Generic;
namespace MathOperation
{
    interface Shape
    {
        void Claculate(int n1, int n2);
    }
    public class Rectangle : Shape
    {
        public void Claculate(int n1,int n2)
        {
            int area= n1*n2;
            Console.WriteLine("Area of Rectangle: "+area);
        }
    }
    public class Circle : Shape
    {
       public  void Claculate (int n1, int n2)
        {
           float  area = 0.5f * n1 * n2;
            Console.WriteLine("Area of Circle: " + area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No 1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter No 2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Shape r = new Rectangle();
            r.Claculate(n1, n2);
            Shape c = new Circle();
            c.Claculate(n1, n2);
            Console.ReadKey();
        }
    }
}
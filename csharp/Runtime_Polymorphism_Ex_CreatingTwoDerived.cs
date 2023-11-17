using System;
namespace RuntimePolyEX
{
    class Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("Draw a shape");
        }
    }
    class Rectangle:Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing a shape rectangle");
        }
    }
    class Circle:Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing a shape circle");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Shape s;
            s = new Shape();
            s.draw();
            s = new Rectangle();
            s.draw();
            s= new Circle();
            s.draw();

            Console.ReadKey();
        }
    }
}
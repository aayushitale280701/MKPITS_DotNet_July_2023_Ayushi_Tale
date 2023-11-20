using System;
namespace AbstractClassShape
{
    public abstract class Shape
    {
        public abstract void draw();
    }
    public class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Rectangle...");
        }
    }
    public class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Circle...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Rectangle();
            s.draw();
            s= new Circle();
            s.draw();
            Console.ReadKey();
        }
    }
}
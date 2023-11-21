using System;
namespace interfaceCsharp
{
    interface Shape
    {
        void draw();

    }
    class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Draw method of rectangle class");
        }
    }
    class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Draw method of circle class");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Shape s = new Rectangle();
            s.draw();
            s=new Circle();
            s.draw();
            Console.ReadKey();
        }
    }
}
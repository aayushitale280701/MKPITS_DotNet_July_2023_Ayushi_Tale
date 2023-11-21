using System;
namespace methoddraw
{
    public interface Drawable
    {
        void draw();

    }
    class Rectangle : Drawable
    {
        public void draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }
    class Circle: Drawable
    {
        public void draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Drawable d;
            d=new Circle();
            d.draw();
            d=new Rectangle();
            d.draw();
            Console.ReadKey();
        }
    }
}
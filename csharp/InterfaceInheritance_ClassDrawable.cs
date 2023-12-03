using System;
namespace InterfaceInheritance
{
    interface Drawable
    {
        void Draw();
    }
    class Circle : Drawable
    {
        public void Draw()
        {
            Console.WriteLine("Circle Drawing...  ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Drawable d = new Circle();
            d.Draw();
            Console.ReadKey();
        }
    }
}
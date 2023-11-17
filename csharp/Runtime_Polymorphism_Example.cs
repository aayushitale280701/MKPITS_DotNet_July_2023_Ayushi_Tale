using System;
namespace runtimePolymorphism
{
    class baseclass
    {
        public virtual void show()
        {
            Console.WriteLine("Show the baseclass method.");
        }
    }
    class childclass:baseclass
    {
        public override void show()
        {
            Console.WriteLine("Show the override method.");
        }
    }
    class program
    {
        public static void Main(String[] args)
        {
            baseclass b = new childclass();
            b.show();
            Console.ReadKey();
        }
    }
}
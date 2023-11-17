using System;
namespace MethodOverriding
{
    class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating Bread...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal d = new Dog();
            d.eat();
            Console.ReadKey();
        }
    }
}
using System;
namespace runtimePolymorphismClassAnimal
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
    class program
    {
        static void Main(string[] args)
        {
            Animal d =new Dog();
            d.eat();
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
namespace ZooSimulation
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name,int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public virtual void MakingSound()
        {
            Console.WriteLine("Sound of Animal: ");
        }
    }
    class Mammal : Animal
    {
        public Mammal(string Name,int Age): base(Name, Age) 
        {
           
        }
        public override void MakingSound()
        {
            Console.WriteLine("Lion sound is roars roars....");
        }
    }
    class Reptile : Animal
    {
        public Reptile(String Name, int Age): base(Name, Age)
        {

        }
        public override void MakingSound()
        {
            Console.WriteLine("Snake sound is hiss hiss.....");
        }
    }
    class Bird : Animal
    {
        public Bird(string Name, int Age): base(Name, Age)
        {

        }
        public override void MakingSound()
        {
            Console.WriteLine("Eagel sound is screech screech....");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal m = new Mammal("Lion" , 46);
            m.MakingSound();

            Animal r = new Reptile("Snake", 110);
            r.MakingSound();

            Animal b = new Bird("Eagel", 80);
            b.MakingSound();

            Console.ReadKey();
        }
    }
}
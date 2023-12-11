using System;
using System.Collections.Generic;

class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic animal sound");
    }
}

class Mammal : Animal
{
    public Mammal(string name, int age) : base(name, age)
    {
    }

}

class Reptile : Animal
{
    public Reptile(string name, int age) : base(name, age)
    {
    }

}

class Bird : Animal
{
    public Bird(string name, int age) : base(name, age)
    {
    }

}

class Lion : Mammal
{
    public Lion(string name, int age) : base(name, age)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Roar!");
    }

}

class Snake : Reptile
{
    public Snake(string name, int age) : base(name, age)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Hiss!");
    }

}

class Eagle : Bird
{
    public Eagle(string name, int age) : base(name, age)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Screech!");
    }

}

class Program
{
    static void Main()
    {
        Lion lion = new Lion("Simba", 5);
        Snake snake = new Snake("Nagini", 3);
        Eagle eagle = new Eagle("Thunder", 2);

        Animal[] animals = { lion, snake, eagle };

        foreach (var animal in animals)
        {
            Console.WriteLine($"Name: {animal.Name}, Age: {animal.Age}");
            animal.MakeSound();
            Console.WriteLine();
        }
    }
}

﻿using System;
using static inheritsMethod.Animal;

namespace inheritsMethod
{
    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating...");
        }
        public class Dog : Animal
        {
            public void bark()
            {
                Console.WriteLine("Barking...");
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Dog d1 = new Dog();
            d1.eat();
            d1.bark();
        }
    }
}
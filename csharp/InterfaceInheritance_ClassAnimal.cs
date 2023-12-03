using System;
using System.Collections;
using System.Collections.Generic;
namespace ClassAnimalInterfaceInheritance
{
    interface Animals
    {
        void Makesound();

    }
    class Dog : Animals
    {
        public void Makesound()
        {
            Console.WriteLine("Dog Sound is Bhooo....");
        }
    }
    class Cat : Animals
    {
        public void Makesound()
        {
            Console.WriteLine("Cat sound is mew mew....");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animals[] d = new Animals();
            d[0]=new Dog() ;
            d[1]=new Cat() ;
            for (int i = 0; i < d.Length; i++)
            {
                d[i].Makesound();
            }
            Console.ReadLine();
        }
    }
}

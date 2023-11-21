using System;
namespace basekeyword
{
    class Animal
    {
        public string color = "White";
    }
    class Dog : Animal
    {
        public string color = "Red";
        public void displaycolor()
        {
            Console.WriteLine("Color Dog - "+color );
            Console.WriteLine("Color Dog - "+ base.color);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.displaycolor();
            Console.ReadKey();
        }
    }


}
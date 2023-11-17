using System;
namespace Runtimepoly_DataMembers
{
    class Animal
    {
        public string color = "White";
    }
    class Dog : Animal
    {
        public string color = "Black";
    }
    class program
    {
        public static void Main(string[] args)
        {
            Animal d=new Animal();
            Console.WriteLine(d.color);
            Console.ReadKey();
        }
    }
}
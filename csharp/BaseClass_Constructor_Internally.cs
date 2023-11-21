using System;
namespace baseClassConstructor
{
    class Company
    {
        public string name = "MKCL";
        public Company()
        {
            Console.WriteLine("Base class constructor: ");
            Console.WriteLine("Company name:- " + name);
        }
    }
    class Franchise : Company
    {
        public string name = "MKPITS";
        public Franchise()
        {
            Console.WriteLine("Drived class constructor: ");
            Console.WriteLine("Franchise Name:- " + name);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Franchise f = new Franchise();
            
            Console.ReadKey();
        }
    }
}
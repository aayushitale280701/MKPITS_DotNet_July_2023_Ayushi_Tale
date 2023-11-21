using System;
namespace baseClassmethod
{
    class Company
    {
        public string name = "MKCL";
        public void display()
        {
            Console.WriteLine("Company name:- "+name);
        }
    }
    class Franchise : Company
    {
        public string name = "MKPITS";
        public void display()
        {
            base.display();
            Console.WriteLine("Franchise Name:- " + name);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Franchise f = new Franchise();
            f.display();
            Console.ReadKey();
        }
    }
}
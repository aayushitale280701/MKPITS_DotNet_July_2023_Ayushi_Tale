using System;
using System.ComponentModel.DataAnnotations;

namespace CLASSCAR
{
    class Car
    {
        int id;
        string name;
        int price;

        //Creating a constructor with no parameters
        public Car()
        {
            Console.WriteLine("Constructor with no parameter called");
            id = 546;
            name = "KIW";
            price = 2000000;
        }
        //creating a  parameterized constructor
        public Car (int id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
        public void dispaly()
        {
            Console.WriteLine("Car ID- " + id);
            Console.WriteLine("Car Name- " + name);
            Console.WriteLine("Car Price- "+ price);
        }
    }
    class program
    {
        public static void Main (string[] args)
        {
            Car c=new Car();
            c.dispaly(); //this will call constructor with no parameter automatically
            Console.WriteLine("\n");
            Car c1 = new Car(546,"Swite", 1500000); //this will call parameterized constructor
            c1.dispaly();

            Console.ReadKey();
        }
    }
}
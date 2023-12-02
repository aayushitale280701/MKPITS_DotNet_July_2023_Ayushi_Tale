using System;
using System.Collections;
using System.Collections.Generic;
namespace inheritance
{
     class Vehical
    {
        public int make;
        public String  model;
    }
    class Car:Vehical
    {
        public int numdoors;
        public String fueltype;
    }
    class program
    {
        static void Main(string[] args)
        {
            Car v = new Car();

            v.make = 2009;
            v.model = "BMW";
            v.numdoors = 4;
            v.fueltype = "Petrol";

            Console.WriteLine("Make : "+v.make);
            Console.WriteLine("Model : " + v.model);
            Console.WriteLine("Numbers of Doors : " + v.numdoors);
            Console.WriteLine("Fuel Type : " + v.fueltype);
            Console.ReadKey();
        }
    }
}
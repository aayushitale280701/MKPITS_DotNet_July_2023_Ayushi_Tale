using System;
namespace copyconstructor
{
    class Car
    {
        int carid;
        string name;
        int price;
        //creating constructor
        public Car()
        {
            carid = 345;
            name = "BMW";
            price = 1500000;
        }
        //creating a copy constructor
        public Car (Car c2)
        {
            carid= c2.carid;
            name = c2.name;
            price = c2.price;
        }
        //method to dispaly the data
        public void display()
        {
            Console.WriteLine("Car ID = "+carid);
            Console.WriteLine("Model Name = " + name);
            Console.WriteLine("Model Price = " + price);
        }
    }
    class program
    {
        public static void Main (string[] args)
        {
            Car c= new Car();
            Car c2= new Car();
            Console.WriteLine("-------Car1 details are------- ");
            c.display();
            Console.WriteLine("\n");
            Console.WriteLine("-------Car2 details are -------- ");
            c2.display();
            Console.ReadKey();
        }
    }
}
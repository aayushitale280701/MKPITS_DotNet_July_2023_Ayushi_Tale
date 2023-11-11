using System;
namespace ClassCar
{
    class Car
    {
        int carid;
        string name;
        int price;
        //creating a constructor with no parameters
        public Car()
        {
            carid = 333;
            name = "BMW";
            price = 60000;
        }
        public void display()
        {
            Console.WriteLine("Car ID = " +  carid);
            Console.WriteLine("Car Name = " +  name);
            Console.WriteLine("Car Price = " + price);
        }
    }
    class program
    {
        public static void Main (string[] args)
        {
            Car c = new Car();//this will call constructor automaticaly
            c.display();
            Console.ReadLine();
        }
    }
}
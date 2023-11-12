using System;
namespace MemeberMethodConstructor
{
    class Car
    {
        static string name;
        static int id;
        static int price;
        static Car()
        {
            Console.WriteLine("Static Constructor Called");
            name = "BMW";
            id = 5678;
            price = 6000000;
        }
        public static void dispaly()
        {
            Console.WriteLine("Model Name:- " +name);
            Console.WriteLine("Model ID:- " + id);
            Console.WriteLine("Model Price:- " + price);
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            Car.dispaly();
            Console.ReadKey();
        }
    }
}
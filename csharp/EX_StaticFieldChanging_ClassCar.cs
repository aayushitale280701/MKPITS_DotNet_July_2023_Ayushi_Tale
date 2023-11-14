using System;
namespace SaticFieledChanging
{
    public class Car
    {
        public int carid;
        public string name;
        public static float rateOfInterest = 8.8f;
        public Car(int carid, string name)
        {
            this.carid = carid;
            this.name = name;
        }
        public void dispaly()
        {
            Console.WriteLine(carid + " " + name + " " + rateOfInterest);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Car.rateOfInterest = 10.6f;//changing value
            Car c1 = new Car(364, "BMW");
            Car c2 = new Car(687, "Venue");
            c1.dispaly();
            c2.dispaly();
            Console.ReadKey();
        }
    }
}
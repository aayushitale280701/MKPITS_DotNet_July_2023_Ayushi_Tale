using System;
namespace SaticFieledCountingObjects
{
    public class Car
    {
        public int carid;
        public string name;
        public static int count = 0;
        public Car(int carid, string name)
        {
            this.carid = carid;
            this.name = name;
            count++;
        }
        public void dispaly()
        {
            Console.WriteLine(carid + " " + name);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Car c1 = new Car(678, "Swite");
            Car c2 = new Car(364, "BMW");
            Car c3 = new Car(687, "Venue");
            c1.dispaly();
            c2.dispaly();
            c3.dispaly();
            Console.WriteLine("Total Objects Are: " + Car.count);
            Console.ReadKey();
        }
    }
}

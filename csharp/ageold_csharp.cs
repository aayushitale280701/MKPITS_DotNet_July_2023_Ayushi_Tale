using System;
namespace ageold
{
    class Program
    {
        public static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter the age");
            age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you look older than age 20 : " + age);
            Console.ReadLine();
        }
    }
}
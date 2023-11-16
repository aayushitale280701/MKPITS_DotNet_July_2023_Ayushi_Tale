using System;
namespace SingleLevelInheritance
{
    //Creating base class
    public class Employee
    {
        public float salary = 40000;
    }
    //Creating derieved class 
    public class Prograamer : Employee
    {
        public float bonus = 10000;
    }
    class Program
    {
        public static void Main (string[] args)
        {
            Prograamer p1 = new Prograamer();
            Console.WriteLine("Salary:- " +p1.salary);
            Console.WriteLine("Bonus:- "+p1.bonus);
            Console.ReadKey();
        }
    }
}
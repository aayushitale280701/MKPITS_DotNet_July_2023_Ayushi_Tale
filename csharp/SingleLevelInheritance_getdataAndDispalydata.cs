using System;
namespace SingleLevelInheritance
{
    //Creating a base class employee
    class Employee
    {
        protected int salary;
    }
    //Creating a derieved class programmer
    class programmer : Employee
    {
        int bonus;
        public void getdata(int salary, int bonus)
        {
            this .salary = salary;
            this .bonus = bonus;
        }
        public void displaydata()
        {
            Console.WriteLine("Salary :- "+salary);
            Console.WriteLine("Bonus :- " +  bonus);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            programmer p= new programmer();
            p.getdata(23000, 5600);
            p.displaydata();
        }
    }
}
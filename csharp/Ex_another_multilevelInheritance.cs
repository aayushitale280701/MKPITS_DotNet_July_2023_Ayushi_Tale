using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevelinheritance
{
    public class Person
    {
        String name;
        String address;
        public void getPersonData(String name, String address)
        {
            this.name = name;
            this.address = address;
        }
        public void displayPersonData()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Address : " + address);

        }
    }
    public class Employee : Person
    {
        int salary;
        String designation;
        public void getEmployeeData(int salary, String designation)
        {
            //   getPersonData("arifa", "nagpur"); //calling base class method from derieved class
            this.salary = salary;
            this.designation = designation;
        }
        public void displayEmployeeData()
        {
            //  displayPersonData(); //calling base class method from derieved class
            Console.WriteLine("Salary : " + salary);
            Console.WriteLine("Designation : " + designation);

        }
    }

    public class ParttimeEmployee : Employee
    {
        int no_of_hours;
        public void getParttimeEmployeeData(int no_of_hours)
        {
            //   getPersonData("arifa", "nagpur"); //calling base class method from derieved class
            this.no_of_hours = no_of_hours;

        }
        public void displayparttimeEmployeeData()
        {
            //  displayPersonData(); //calling base class method from derieved class
            Console.WriteLine("No of hours  : " + no_of_hours);


        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            ParttimeEmployee p1 = new ParttimeEmployee();//creating object of child class\
            p1.getPersonData("Ayushi", "Nagpur");
            p1.getEmployeeData(111, "Manager");
            p1.getParttimeEmployeeData(5);
            p1.displayPersonData();
            p1.displayEmployeeData();
            p1.displayparttimeEmployeeData();

        }
    }

}



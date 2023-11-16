using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritMethod
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
        int empno;
        int salary;
        public void getStudentData(int empno, int salary)
        {
            this.empno = empno;
            this.salary= salary;
        }
        public void displayStudentData()
        {
            Console.WriteLine("Employee No : " + empno);
            Console.WriteLine("Salary : " + salary);

        }
    }
    class TestInheritance
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee();//creating object of child class\
            e1.getPersonData("Ayushi", "Nagpur");
            e1.getStudentData(111, 50000);
            e1.displayStudentData();
            e1.displayPersonData();

        }
    }

}


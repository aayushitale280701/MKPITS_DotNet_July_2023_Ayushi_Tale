using System;
namespace classempanotherpara
{
    class Employee
    {
        int empno;
        string empname;
        string designation;
        int salary;

        //creating a constructor with no parameters

        public Employee()
        {
            empno = 22;
            empname = "Ayushi";
            designation = "HR";
            salary = 50000;
        }
        //constructor with 4 parameters(parameterized constructor)
        public Employee(int empno,string  empname, string designation, int salary)
        {
            this.empno = empno;
            this.empname = empname;
            this.designation = designation;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine("Employee No= " + empno);
            Console.WriteLine("Employee Name= "+ empname);
            Console.WriteLine("Designation= " + designation);
            Console.WriteLine("Employee Salary= " + salary);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();//this will call constructor automatically;
            emp.display();
            Console.WriteLine("------------Employee details------------");
            Employee emp1=new Employee(22,"Aradhaya","HR",35000);// this will call parameterized constructor
            emp1.display();
            Console.WriteLine("------------Employee details------------");
            Console.WriteLine("Enter Employee No.");
            int empno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Emter Employee Name");
            string empname= Console.ReadLine();
            Console.WriteLine("Enter Designation");
            string designation= Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            int salary=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------Employee details------------");
            Employee emp2 = new Employee(empno, empname,designation,salary);
            emp2.display();
            Console.ReadLine();
        
        }
    }
}
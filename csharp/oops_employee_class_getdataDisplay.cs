using System;
namespace class_employee
{
    class program
    {
        class employee
        {
            public int emp_no;
            public string emp_name;
            public string emp_designation;
            public int emp_salary;

            public void getdata(int en, string ename, string ed, int es)
            {
                emp_no = en;
                emp_name=ename;
                emp_designation = ed;
                emp_salary = es;

            }
            public void displaydata()
            {
                Console.WriteLine("Employee No : " + emp_no);
                Console.WriteLine("Name : " + emp_name);
                Console.WriteLine("Designation : " + emp_designation);
                Console.WriteLine("Salary : " + emp_salary);
            }
        }
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.getdata(123, "Ayushi", "HR", 50000);
            emp.displaydata();

            Console.ReadKey();
        }

    }
}
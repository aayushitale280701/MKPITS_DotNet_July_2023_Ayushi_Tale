using System;
namespace calculatesalaryifelseif
{
    class Program
    {
        static void Main(string[] args)
        {
            int empno ;
            string empname;
            int bsalary;
            string designation;
            float bonus = 0;
            float total;
            

            Console.WriteLine("Enter EmpNo");
            empno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Ename");
            empname=Console.ReadLine();
            Console.WriteLine("Enter Salary");
            bsalary=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Designation");
            designation=Console.ReadLine();

            if (designation == "manager")
            {
                bonus = bsalary * 0.55f;
            }
            else if (designation == "clerk")
            {
                bonus = bsalary * 0.25f;
            }
            else if (designation == "peon")
            {
                bonus = bsalary * 0.10f;
            }
            
            total = bonus * bsalary;
            Console.WriteLine("Empno{0} : \nEmpname{1} :\n Bsalary{2} : \nDesignation{3} :",empno ,empname ,bsalary ,designation);
            Console.WriteLine("Total {0}", total);
            Console.WriteLine("Bonus {0}", bonus);
            Console.ReadKey();
        }
    }
}

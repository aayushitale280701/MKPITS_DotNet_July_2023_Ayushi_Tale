using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace singlelevelinritancprotected
{
    class person
    {
        string name;
        protected void getpersondata(string name)
        {
            this.name = name;
            Console.WriteLine("Name " + name);
        }
    }
    class employee : person
    {
        int empno;
        internal void getemployeedata(int empno, string name)
        {
            getpersondata(name);//calling base class method 
            this.empno = empno;
            Console.WriteLine("Empno " + empno);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            employee emp = new employee();
            emp.getemployeedata(333, "Ayushi");


        }
    }
}

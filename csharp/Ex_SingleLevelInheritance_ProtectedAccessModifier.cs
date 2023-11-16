using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedAccessModifier
{
    public class Person
    {
        String name;
        String address;
        protected void getPersonData(String name, String address)
        {
            this.name = name;
            this.address = address;
        }
        protected void displayPersonData()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Address : " + address);

        }
    }
    public class Student : Person
    {
        int rno;
        int marks;
        public void getStudentData(int rno, int marks)
        {
            getPersonData("Ayushi", "Nagpur"); //calling base class method from derieved class
            this.rno = rno;
            this.marks = marks;
        }
        public void displayStudentData()
        {
            displayPersonData(); //calling base class method from derieved class
            Console.WriteLine("Rno : " + rno);
            Console.WriteLine("Marks : " + marks);

        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Student p1 = new Student();//creating object of child class
                                       //  p1.getPersonData("ayushi", "nagpur"); since testinhertance class in not derived class of person
            p1.getStudentData(111, 999);
            p1.displayStudentData();
            // p1.displayPersonData(); since testinhertance class in not derived class of person

        }
    }

}


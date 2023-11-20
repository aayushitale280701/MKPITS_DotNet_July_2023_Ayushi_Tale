using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonAbstractMethod
{
    abstract class person
    {
        //abstract method 
        public abstract void display();
        //non abstract method
        public void showdata()
        {
            Console.WriteLine("Hello from showdata");
        }
    }
    class student : person
    {
        //implementation of abstract method display in derieved class
        public override void display()
        {
            Console.WriteLine("Hello from display method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //person p = new person(); error since person is abstract class
            student s = new student();
            s.display();
            s.showdata();
        }
    }
}

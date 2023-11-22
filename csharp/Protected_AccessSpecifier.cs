using System;
namespace protectedaccess
{
    class person
    {
        protected string name;

    }
    //creating a child class student inherited from person class
    class student : person
    {
        public void getdata()
        {
            name = "Ayushi";
            Console.WriteLine("Name " + name);
        }
    }
    class ProtectedAccessSpecifier_usingInheritance
    {
        static void Main(string[] args)
        {
            student s = new student();
            //s.name = "Ayushi";
            s.getdata();
        }
    }
}


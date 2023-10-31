using System;
namespace class_person
{
    class program
    {
        class person
        {
            string name;
            string address;
            int age;
            public void getdata(string name, string address, int age)
            {
                this.age = age;
                this.address = address;
                this.name = name;
            }
            public void displaydata()
            {
                Console.WriteLine("Name :" + name);
                Console.WriteLine("Address :" + address);
                Console.WriteLine("Age :" + age);
            }
        }
            static void Main(string[] args)
            {
            person per=new person();
            Console.WriteLine("Enter Name: ");
            string n=Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            string add=Console.ReadLine();
            Console.WriteLine("Enter Age");
            int a=Convert.ToInt32(Console.ReadLine());


            per.getdata(n,add,a);
            per.displaydata();
            Console.ReadKey();
            }      
    }
}
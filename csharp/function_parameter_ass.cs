using System;
namespace functionparameter
{
    class program
    {
        static void display(string name)
        {
            Console.WriteLine("Welcome Friends!" +" "+name+"!");
            Console.WriteLine("Have a nice day!");
        }
        static void Main()
        {
            string name;
            Console.WriteLine("Enter Name");
            name =(Console.ReadLine());
            display(name);
            Console.ReadKey();
        }
    }
}
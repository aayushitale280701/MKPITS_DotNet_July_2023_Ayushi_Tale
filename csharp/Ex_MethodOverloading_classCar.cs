using System;
namespace MethodOverloading
{
    class Car
    {
        int modelid;
        string name;
        int price;
        public void getdata()
        {
            modelid = 456;
            name = "BMW";
            price = 6000000;
        }
        //Method Overloaded
        public void getdata(int  modelid,string name,int price)
        {
            this.modelid = modelid;
            this.name = name;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("Model ID :- " +modelid);
            Console.WriteLine("Model Name :- " + name);
            Console.WriteLine("Model Price :- "+ price);
        }
    }
    class program
    {
        public static void Main (string[] args)
        {
            Car c=new Car();
            c.getdata();
            c.display();
            Console.WriteLine("--------Car details--------");
            Car c1= new Car();
            c1.getdata(678,"Jaguwar", 9000000);
            c1.display();
            Console.WriteLine("-------Car1 details--------");
            Console.WriteLine("Enter ModelId:- ");
            int modelid=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Model Name:- ");
            string name=Console.ReadLine();
            Console.WriteLine("Enter Model Price:- ");
            int price=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------Car2 details-------");
            Car c2 = new Car();
            c2.getdata(modelid,name,price);
            c2.display();
            Console.ReadKey();
        }
    }
}
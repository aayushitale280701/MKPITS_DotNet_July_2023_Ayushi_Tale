using System;
using System.Collections;
namespace ClassCustomer
{
    class Customer
    {
        public int custid;
        public string custname;
        public string email;
        public int mobno;
        public Customer(int custid, string custname, string email, int mobno)
        {
            this.custid = custid;
            this.custname = custname;
            this.email = email;
            this.mobno = mobno;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Customer c1 = new Customer(1111,"Ayushi", "Ayushitale123@gmail.com",2345);               
                Customer c2 = new Customer(1112, "Om", "omtale@gmail.com", 23455);              
                Customer c3 = new Customer(1113, "Ritu", "Rita@123gmail.com", 45677);
               
                Queue c = new Queue();
                c.Enqueue(c1);
                c.Enqueue(c2);
                c.Enqueue(c3);
                foreach(Customer val in c)
                {
                    Console.WriteLine("Customer id: "+val.custid);
                    Console.WriteLine("Customer name: "+val.custname);
                    Console.WriteLine("Customer email: " + val.email);
                    Console.WriteLine("Customer mobno: " + val.mobno);
                }
                Customer r=(Customer)c.Dequeue();
                Console.WriteLine("\n"+"item deque: "+r.custid+" : "+r.custname+" : "+r.email+" : "+r.mobno);
                Console.WriteLine("after deque");
                foreach(Customer val in c)
                {
                    Console.WriteLine("Name: " + val.custname);
                }
                Console.ReadLine();
            }
        }
    }
}
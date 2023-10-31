using System;
namespace class_customer
{
    class program
    {
        class customer
        {
             int customer_code;
             string customer_name;

            public void getdata(int customer_code, string customer_name)
            {
               this.customer_code = customer_code;
               this.customer_name = customer_name;
            }
            public void displaydata()
            {
                Console.WriteLine("Customer No : " + customer_code);
                Console.WriteLine("Name : " + customer_name);
            }
        }
        static void Main(string[] args)
        {
            customer cust = new customer();
            Console.Write("Enter customer code and name : ");
            int cc=Convert.ToInt32(Console.ReadLine());
            string cn = Console.ReadLine();

            cust.getdata(cc,cn);
            cust.displaydata();

            Console.ReadKey();
        }

    }
}
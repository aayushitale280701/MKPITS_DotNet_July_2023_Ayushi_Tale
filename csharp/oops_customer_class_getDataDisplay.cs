using System;
namespace class_customer
{
    class program
    {
        class customer
        {
            public int customer_code;
            public string customer_name;

            public void getdata (int cc, string cn)
            {
                customer_code = cc;
                customer_name = cn;
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
            cust.getdata(123, "Ayushi");
            cust.displaydata();

            Console.ReadKey();
        }

    }
}
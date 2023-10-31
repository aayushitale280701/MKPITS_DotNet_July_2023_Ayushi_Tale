using System;
namespace class_customer
{
    class program
    {
        class customer
        {
           public  int customer_code;
          public  string customer_name;
        }
        static void Main(string[] args)
        {
            customer cust= new customer();
            cust.customer_code = 123;
            cust.customer_name = "Ayushi";
            Console.WriteLine("Cstomer Code: " +cust.customer_code);
            Console.WriteLine("Customer Name :" + cust.customer_name);
            Console.ReadKey();
        }
        
    }
}
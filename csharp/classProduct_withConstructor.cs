using System;
namespace classproduct
{
    class product
    {
        int productid;
        string productname;
        int price;
        int quantity;

        //creating a constructor with no parameter
       public product()
        {
            productid=1;
            productname = "Book";
            price = 500;
            quantity = 2;
        }
        public void display()
        {
            Console.WriteLine("Product ID = " + productid);
            Console.WriteLine("Product Name = " + productname);
            Console.WriteLine("product Price = " + price);
            Console.WriteLine("Product Quantity = "+ quantity);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            //this with call constructor automatically
            product pro = new product();
            pro.display();
            Console.ReadLine();
        }
    }
}
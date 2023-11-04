using System;
namespace classempanotherpara
{
    class Product
    {
        int productid;
        string productname;
        int price;
        int quantity;

        //creating a constructor with no parameters

        public Product()
        {
            productid = 1;
            productname = "Book";
            price = 5000;
            quantity = 3;
        }
        //constructor with 4 parameters(parameterized constructor)
        public Product(int productid, string productname, int price , int quantity)
        {
            this.productid = productid;
            this.productname = productname;
            this.price = price;
            this.quantity = quantity;
        }
        public void display()
        {
            Console.WriteLine("Product ID= " + productid);
            Console.WriteLine("Product Name= " + productname);
            Console.WriteLine("Product Price= " + price);
            Console.WriteLine("Product Quantity= "+quantity);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Product pro = new Product();//this will call constructor automatically;
            pro.display();
            Console.WriteLine("------------Product details------------");
            Product pro1 = new Product(22, "T.V",35000,1);// this will call parameterized constructor
            pro1.display();
            Console.WriteLine("------------Product details------------");
            Console.WriteLine("Enter Product ID");
            int productid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Name");
            string productname = Console.ReadLine();
            Console.WriteLine("Enter Product Price");
            int price= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Quantity");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------Product details------------");
            Product pro2 = new Product( productid, productname, price, quantity);
            pro2.display();
            Console.ReadLine();

        }
    }
}
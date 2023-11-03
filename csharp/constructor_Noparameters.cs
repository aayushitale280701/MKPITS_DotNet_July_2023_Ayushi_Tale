using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructornoparameterbyusere
{

    class Book
    {
        int bookid;
        String title, author;
        int price;
        //creating a constructor with no parameters
        public Book()
        {
            bookid = 1;
            title = "oracle";
            author = "james";
            price = 200;
        }
        //constructor with 4 parameters(parameterized constructor)
        public Book(int bookid, String title, String author, int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("Book id = " + bookid);
            Console.WriteLine("Book title = " + title);
            Console.WriteLine("Book author= " + author);
            Console.WriteLine("Price = " + price);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();//this will call constructor automatically
            b.display();
            Console.WriteLine("-----------------Book1 details ----------");
            Book b1 = new Book(111, "csharp", "martin", 2000); // this will call parameterized constructor
            b1.display();
            Console.WriteLine("-----------------Book1 details ----------");
            Console.WriteLine("Enter bookid");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter title");
            String title = Console.ReadLine();
            Console.WriteLine("Enter author");
            String author = Console.ReadLine();
            Console.WriteLine("Enter price");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------Book2 details ----------");
            Book b2 = new Book(id, title, author, price);
            b2.display();

            Console.ReadLine();

        }
    }
}

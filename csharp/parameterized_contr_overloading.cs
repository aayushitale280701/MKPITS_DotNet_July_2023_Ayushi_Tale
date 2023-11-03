using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameterizedconstroctor
{
    class Book
    {
        int bookid;
        string title;
        string author;
        int price;
        //creating  a constructor with no parameters
        public Book()
        {
            Console.WriteLine("Constructor with no parameters called");
            bookid = 123;
            title = "vb.net";
            author = "Roshan kumar";
            price = 2333;
        }
        //creating a  parameterized constructor with 4 parameters
        public Book(int bookid, string title, string author, int price)
        {
            Console.WriteLine("Constructor with  parameters called");
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;

        }
        public void display()
        {
            Console.WriteLine("Book id : " + bookid);
            Console.WriteLine("Title : " + title);
            Console.WriteLine("Author : " + author);
            Console.WriteLine("Price : " + price);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book(); //this will call constructor with no parameter automatically
            b1.display();


            Book b2 = new Book(22, "Oracle", "Ashis", 400); //this will call parameterized constructor
            b2.display();
        }
    }
}

using System;
namespace classbook
{
    class books
    {
        string title;
        string author;
        int year;
        int[] book;


        public void getdata(string title, string author, int year)
        {
            this.title = title;
            this.author = author;
            this.year = year;

        }
        public void displaydata()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Year: " + year);
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            books[] bookied = new books[3];
            bookied[0] = new books();
            bookied[1] = new books();
            bookied[2] = new books();
            string auth = null;
            string tit = null;
            int publication = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\nEnter Author");
                auth = Console.ReadLine();

                Console.WriteLine("\nEnter Title");
                tit = Console.ReadLine();

                Console.WriteLine("\nEnter Year");
                publication = Convert.ToInt32(Console.ReadLine());
                bookied[i].getdata(auth, tit, publication);
            }

            for (int i = 0; i < 3; i++)
            {
                bookied[i].displaydata();

            }

            Console.ReadKey();
        }
    }
}
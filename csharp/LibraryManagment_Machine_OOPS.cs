using System;
using System.Collections.Generic;

class Author
{
    public string AuthorName { get; }

    public Author(string authorName)
    {
        AuthorName = authorName;
    }
}

class Book
{
    public string Title { get; }
    public string ISBN { get; }
    public Author Author { get; }

    public Book(string title, string isbn, Author author)
    {
        Title = title;
        ISBN = isbn;
        Author = author;
    }

    public override string ToString()
    {
        return $"Title: {Title}, ISBN: {ISBN}, Author: {Author.AuthorName}";
    }
}

class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Book added to the library: {book}");
    }

    public void RemoveBook(string isbn)
    {
        Book bookToRemove = null;

        foreach (var book in books)
        {
            if (book.ISBN == isbn)
            {
                bookToRemove = book;
                break;
            }
        }

        if (bookToRemove != null)
        {
            books.Remove(bookToRemove);
            Console.WriteLine($"Book removed from the library: {bookToRemove}");
        }
        else
        {
            Console.WriteLine($"Book with ISBN {isbn} not found in the library.");
        }
    }

    public void DisplayBooks()
    {
        Console.WriteLine("Books in the library:");
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Author author1 = new Author("John Doe");
        Author author2 = new Author("Jane Smith");

        Book book1 = new Book("Introduction to C#", "123456", author1);
        Book book2 = new Book("Introduction to C#", "789012", author2);
        Book book3 = new Book("Advanced C#", "345678", author1);

        Library library = new Library();

        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        library.DisplayBooks();

        library.RemoveBook("789012");

        library.DisplayBooks();

        Console.ReadKey();
    }
}

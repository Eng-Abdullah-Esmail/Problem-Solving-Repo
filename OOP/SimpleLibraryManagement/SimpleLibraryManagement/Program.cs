using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }
}

class Library
{
    private List<Book> books;

    public Library()
    {
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        books.Remove(book);
    }

    public void CheckoutBook(Book book)
    {
        if (books.Contains(book))
        {
            Console.WriteLine("Checking out book: {0}", book.Title);
            books.Remove(book);
        }
        else
        {
            Console.WriteLine("Book not found in library.");
        }
    }

    public void PrintBooks()
    {
        Console.WriteLine("Library Books:");
        foreach (Book book in books)
        {
            Console.WriteLine("- {0} by {1} (ISBN: {2})", book.Title, book.Author, book.ISBN);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new library object
        Library library = new Library();

        // Add some books to the library
        library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "978-1471229015"));
        library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "978-0060935467"));
        library.AddBook(new Book("Pride and Prejudice", "Jane Austen", "978-0141439518"));

        // Print the library books
        library.PrintBooks();

        // Check out a book and print the library books again
        library.CheckoutBook(new Book("To Kill a Mockingbird", "Harper Lee", "978-0060935467"));
        library.PrintBooks();

        Console.ReadKey();
    }
}
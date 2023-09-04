using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public override string ToString()
        {
            return Title + " by " + Author + " (" + Year + ")";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create a linked list to store books
            LinkedList<Book> bookList = new LinkedList<Book>();

            // Add some books to the list
            bookList.AddLast(new Book("To Kill a Mockingbird", "Harper Lee", 1960));
            bookList.AddLast(new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925));
            bookList.AddLast(new Book("1984", "George Orwell", 1949));

            // Iterate over the list and print the book details
            foreach (Book book in bookList)
            {
                Console.WriteLine(book);
            }

            Console.ReadKey();

        }
    }
}

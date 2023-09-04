using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
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

            // Create a queue to store books
            Queue<Book> bookQueue = new Queue<Book>();

            // Add some books to the queue
            bookQueue.Enqueue(new Book("To Kill a Mockingbird", "Harper Lee", 1960));
            bookQueue.Enqueue(new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925));
            bookQueue.Enqueue(new Book("1984", "George Orwell", 1949));

            // Dequeue books from the queue and print their details
            while (bookQueue.Count > 0)
            {
                Book book = bookQueue.Dequeue();
                Console.WriteLine(book);
            }

            Console.ReadKey();

        }
    }
}

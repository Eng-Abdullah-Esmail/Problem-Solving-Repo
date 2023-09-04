using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
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
            Stack<Book> bookStack = new Stack<Book>();

            // Add some books to the stack
            bookStack.Push(new Book("To Kill a Mockingbird", "Harper Lee", 1960));
            bookStack.Push(new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925));
            bookStack.Push(new Book("1984", "George Orwell", 1949));

            // Pop books off the stack and print their details
            while (bookStack.Count > 0)
            {
                Book book = bookStack.Pop();
                Console.WriteLine(book);
            }



            Console.ReadKey();
        }
    }
}

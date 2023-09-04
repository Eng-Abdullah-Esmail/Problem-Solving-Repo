using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetAddRemoveElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a hash set to store book titles
            HashSet<string> bookSet = new HashSet<string>();

            // Add some books to the set
            bookSet.Add("To Kill a Mockingbird");
            bookSet.Add("The Great Gatsby");
            bookSet.Add("1984");

            // Remove a book from the set
            string bookTitle = "The Great Gatsby";
            if (bookSet.Contains(bookTitle))
            {
                bookSet.Remove(bookTitle);
                Console.WriteLine("Removed book: " + bookTitle);
            }
            else
            {
                Console.WriteLine("Book not found: " + bookTitle);
            }

            // Print out the remaining books in the set
            Console.WriteLine("Remaining books:");
            foreach (string book in bookSet)
            {
                Console.WriteLine(book);
            }

            Console.ReadKey();
        }
    }
}

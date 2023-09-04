using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingIEnumerable
{
    internal class Program
    {
        // Define a method that takes an IEnumerable parameter and prints its contents
        static void PrintBooks(IEnumerable<string> books)
        {
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }


        }
        static void Main(string[] args)
        {
            // Create a list of book titles
            List<string> bookList = new List<string>();
            bookList.Add("To Kill a Mockingbird");
            bookList.Add("The Great Gatsby");
            bookList.Add("1984");

            // Pass the list to a method that takes an IEnumerable parameter
            PrintBooks(bookList);

            Console.ReadKey();
        }

      
       
    }
}

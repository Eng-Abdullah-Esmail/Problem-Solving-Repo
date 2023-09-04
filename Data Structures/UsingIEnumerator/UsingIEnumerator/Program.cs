using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingIEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of book titles
            List<string> bookList = new List<string>();
            bookList.Add("To Kill a Mockingbird");
            bookList.Add("The Great Gatsby");
            bookList.Add("1984");

            // Get an enumerator for the list
            IEnumerator<string> enumerator = bookList.GetEnumerator();

            // Use the enumerator to iterate over the list
            try
            {
                while (enumerator.MoveNext())
                {
                    string book = enumerator.Current;
                    Console.WriteLine(book);
                }
            }
            finally
            {
                enumerator.Dispose();
            }

            Console.ReadKey();
        }
    }
}

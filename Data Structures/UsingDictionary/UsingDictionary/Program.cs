using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a dictionary to store book titles and authors
            Dictionary<string, string> bookDict = new Dictionary<string, string>();

            // Add some books to the dictionary
            bookDict.Add("To Kill a Mockingbird", "Harper Lee");
            bookDict.Add("The Great Gatsby", "F. Scott Fitzgerald");
            bookDict.Add("1984", "George Orwell");

            // Iterate over the dictionary and print each key-value pair
            foreach (KeyValuePair<string, string> pair in bookDict)
            {
                Console.WriteLine(pair.Key + " by " + pair.Value);
            }


            Console.ReadKey();
        }
    }
}

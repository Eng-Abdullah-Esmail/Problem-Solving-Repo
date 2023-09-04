using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetUnionDifferenceOps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create two hash sets to store book titles
            HashSet<string> setA = new HashSet<string>();
            HashSet<string> setB = new HashSet<string>();

            // Add some books to the sets
            setA.Add("To Kill a Mockingbird");
            setA.Add("The Great Gatsby");
            setB.Add("The Catcher in the Rye");
            setB.Add("1984");

            // Compute the union of the sets
            HashSet<string> unionSet = new HashSet<string>(setA);
            unionSet.UnionWith(setB);
            Console.WriteLine("Union of the sets:");
            foreach (string book in unionSet)
            {
                Console.WriteLine(book);
            }

            // Compute the intersection of the sets
            HashSet<string> intersectSet = new HashSet<string>(setA);
            intersectSet.IntersectWith(setB);
            Console.WriteLine("Intersection of the sets:");
            foreach (string book in intersectSet)
            {
                Console.WriteLine(book);
            }

            // Compute the difference of the sets
            HashSet<string> diffSet = new HashSet<string>(setA);
            diffSet.ExceptWith(setB);
            Console.WriteLine("Difference of the sets:");
            foreach (string book in diffSet)
            {
                Console.WriteLine(book);
            }

            Console.ReadKey();

        }
    }
}

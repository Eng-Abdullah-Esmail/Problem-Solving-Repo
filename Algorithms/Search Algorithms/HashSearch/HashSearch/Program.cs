using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSearch
{
    public class HashSearch
    {
        public static int Search(int[] arr, int target)
        {
            // Create a hash table to store the elements and their indices
            Dictionary<int, int> hashTable = new Dictionary<int, int>();

            // Populate the hash table with array elements
            for (int i = 0; i < arr.Length; i++)
            {
                if (!hashTable.ContainsKey(arr[i]))
                {
                    hashTable.Add(arr[i], i);
                }
            }

            // Check if the target element exists in the hash table
            if (hashTable.ContainsKey(target))
            {
                return hashTable[target]; // Return the index of the target element
            }

            return -1; // Target element not found
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int target = 8;

            int index = HashSearch.Search(arr, target);

            if (index != -1)
            {
                Console.WriteLine("Element found at index: " + index);
            }
            else
            {
                Console.WriteLine("Element not found in the array.");
            }

            Console.ReadKey();


        }
    }
}

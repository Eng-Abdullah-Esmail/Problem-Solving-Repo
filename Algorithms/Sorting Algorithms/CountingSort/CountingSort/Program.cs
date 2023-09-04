using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSort
{
    public class CountingSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            // Find the maximum element in the array
            int max = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            int[] count = new int[max + 1]; // Create a count array to store the count of each element

            // Store count of each element in the count array
            for (int i = 0; i < n; i++)
            {
                count[arr[i]]++;
            }

            // Modify the count array such that each element at each index stores the sum of previous counts
            for (int i = 1; i <= max; i++)
            {
                count[i] += count[i - 1];
            }

            int[] output = new int[n]; // The output array that will have sorted values

            // Build the output array
            for (int i = n - 1; i >= 0; i--)
            {
                output[count[arr[i]] - 1] = arr[i];
                count[arr[i]]--;
            }

            // Copy the sorted elements back to the original array
            for (int i = 0; i < n; i++)
            {
                arr[i] = output[i];
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] items = { 90, 45, 32, 8, 7, 6, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };

            CountingSort.Sort(items);
            foreach (int item in items)
            {
                Console.Write(item + "  ");
            }

            Console.ReadKey();



        }
    }
}

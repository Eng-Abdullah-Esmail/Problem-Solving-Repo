using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadixSort
{
    public class RadixSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            // Find the maximum number to determine the number of digits
            int max = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            // Perform counting sort for every digit
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountingSortByDigit(arr, n, exp);
            }
        }

        private static void CountingSortByDigit(int[] arr, int n, int exp)
        {
            int[] output = new int[n]; // The output array that will have sorted values
            int[] count = new int[10]; // Create a count array to store the count of each digit

            // Store count of occurrences in count[]
            for (int i = 0; i < n; i++)
            {
                count[(arr[i] / exp) % 10]++;
            }

            // Modify the count array such that each element at each index stores the sum of previous counts
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            // Build the outputarray
            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
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

            RadixSort.Sort(items);
            foreach (int item in items)
            {
                Console.Write(item + "  ");
            }

            Console.ReadKey();


        }
    }
}

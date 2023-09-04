using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] items = { 90, 45, 32, 8, 7, 6, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };

            BucketSort.Sort(items);
            foreach (int item in items)
            {
                Console.Write(item + "  ");
            }

            Console.ReadKey();


        }
    }

    public class InsertionSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], that are greater than key, to one position ahead of their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = key;
            }
        }
    }

    public class BucketSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            // Find the minimum and maximum values in the array
            int min = arr[0];
            int max = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                else if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            int numBuckets = (max - min) / n + 1; // Determine the number of buckets
            List<List<int>> buckets = new List<List<int>>(numBuckets); // Create empty buckets

            // Initialize empty buckets
            for (int i = 0; i < numBuckets; i++)
            {
                buckets.Add(new List<int>());
            }

            // Put array elements into different buckets based on the value range
            for (int i = 0; i < n; i++)
            {
                int bucketIndex = (arr[i] - min) / n;
                buckets[bucketIndex].Add(arr[i]);
            }

            // Sort buckets and place the elements back into the original array
            int index = 0;
            foreach (var bucket in buckets)
            {
                int[] tempArray = bucket.ToArray();
                InsertionSort.Sort(tempArray); // Use any sorting algorithm to sort elements in the bucket
                tempArray.CopyTo(arr, index);
                index += tempArray.Length;
            }
        }
    }



}

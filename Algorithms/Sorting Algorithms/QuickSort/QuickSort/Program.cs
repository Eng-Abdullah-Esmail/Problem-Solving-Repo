using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class QuickSort
    {
        public static void Sort(int[] arr)
        {
            QuickSortRecursive(arr, 0, arr.Length - 1);
        }

        private static void QuickSortRecursive(int[] arr, int low, int high)
        {
            if (low < high)
            {
                // Partition the array
                int partitionIndex = Partition(arr, low, high);

                // Recursively sort the sub-arrays
                QuickSortRecursive(arr, low, partitionIndex - 1);
                QuickSortRecursive(arr, partitionIndex + 1, high);
            }
        }

        private static int Partition(int[] arr, int low, int high)
        {
            // Choose the rightmost element as the pivot
            int pivot = arr[high];

            // Index of the smaller element
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                // If the current element is smaller than or equal to the pivot
                if (arr[j] <= pivot)
                {
                    i++;

                    // Swap arr[i] and arr[j]
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // Swap arr[i+1] and arr[high] (or the pivot)
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] items = { 90, 45, 32, 8, 7, 6, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            QuickSort.Sort(items);

            foreach (int item in items)
            {
                Console.Write(item + "  ");
            }

            Console.ReadKey();


        }
    }
}

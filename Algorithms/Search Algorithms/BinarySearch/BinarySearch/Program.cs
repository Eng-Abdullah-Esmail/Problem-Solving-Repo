using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{

    public class BinarySearch
    {
        public static int Search(int[] arr, int target)
        {
            return BinarySearchRecursive(arr, target, 0, arr.Length - 1);
        }

        private static int BinarySearchRecursive(int[] arr, int target, int low, int high)
        {
            if (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] == target)
                    return mid;
                else if (arr[mid] > target)
                    return BinarySearchRecursive(arr, target, low, mid - 1);
                else
                    return BinarySearchRecursive(arr, target, mid + 1, high);
            }

            return -1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
            int target = 23;

            

            int binarySearchIndex = BinarySearch.Search(arr, target);
            Console.WriteLine("Binary Search: " + binarySearchIndex);

            Console.ReadKey();

        }
    }
}

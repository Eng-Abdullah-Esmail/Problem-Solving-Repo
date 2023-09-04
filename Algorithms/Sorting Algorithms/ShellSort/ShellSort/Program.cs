using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    public class ShellSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            // Start with a large gap, then reduce the gap until it becomes 1
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                // Perform insertion sort on each sublist defined by the gap
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j = i;

                    // Shift earlier gap-sorted elements until the correct position for arr[i] is found
                    while (j >= gap && arr[j - gap] > temp)
                    {
                        arr[j] = arr[j - gap];
                        j -= gap;
                    }

                    arr[j] = temp;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] items = { 90, 45, 32, 8, 7, 6, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            ShellSort.Sort(items);

            foreach (int item in items)
            {
                Console.Write(item + "  ");
            }

            Console.ReadKey();


        }
    }
}

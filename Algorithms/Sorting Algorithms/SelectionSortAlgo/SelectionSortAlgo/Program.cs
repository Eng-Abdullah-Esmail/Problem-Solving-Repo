﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSortAlgo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] items = { 90, 45, 32, 8, 7, 6, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            SelectionSort.Sort(items);

            foreach(int item in items)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

    public class SelectionSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    internal class Program
    {

        public class LinearSearch
        {
            public static int Search(int[] arr, int target)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == target)
                        return i;
                }
                return -1;
            }
        }
        static void Main(string[] args)
        {

            int[] items = { 90, 45, 32, 8, 7, 6, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };


            int target = 45;
            Console.Write("Index is:");
            Console.WriteLine(LinearSearch.Search(items, target).ToString() );

            Console.ReadKey();


        }
    }
}

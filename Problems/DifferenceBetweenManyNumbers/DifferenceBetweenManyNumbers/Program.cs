using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfMultipleNumbers
{
    internal class Program
    {
        static int DifferenceOfMultipleNumbers(int[] nums)
        {
            int diff = 0;

            foreach (int number in nums)
            {
                diff -= number;
            }

            return diff;
        }

        static void PrintResult(int diff)
        {
            Console.WriteLine("Difference  Of Multiple Numbers is :" + diff);
        }


        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 6, 8, 10 };

            PrintResult(DifferenceOfMultipleNumbers(numbers));

            Console.ReadKey();

        }
    }
}

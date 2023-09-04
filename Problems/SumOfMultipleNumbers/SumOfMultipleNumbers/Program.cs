using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfMultipleNumbers
{
    internal class Program
    {
        static int SumOfMultipleNumbers(int[] nums)
        {
            int sum = 0;

            foreach (int number in nums)
            {
                sum += number;
            }

            return sum;
        }

        static void PrintResult(int sum)
        {
            Console.WriteLine("Sumation Of Multiple Numbers is :" + sum);
        }


        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 6, 8, 10 };

            PrintResult(SumOfMultipleNumbers(numbers));

            Console.ReadKey();

        }
    }
}

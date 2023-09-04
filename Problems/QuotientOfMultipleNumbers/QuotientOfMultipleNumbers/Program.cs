using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfMultipleNumbers
{
    internal class Program
    {
        static double QuotientOfMultipleNumbers(int[] nums)
        {
            float quotient = nums[0];

            foreach (int number in nums)
            {
                quotient /= number;
            }

            return (double) quotient;
        }

        static void PrintResult(double q)
        {
            Console.WriteLine("Quotient  Of Multiple Numbers is :" + q);
        }


        static void Main(string[] args)
        {
            int[] numbers = { 60000, 4, 6, 8, 10 };

            PrintResult(QuotientOfMultipleNumbers(numbers));

            Console.ReadKey();

        }
    }
}

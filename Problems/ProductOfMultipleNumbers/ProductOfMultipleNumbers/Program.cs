using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfMultipleNumbers
{
    internal class Program
    {
        static int ProductOfMultipleNumbers(int[] nums)
        {
            int product = 1;

            foreach (int number in nums)
            {
                product *= number;
            }

            return product;
        }

        static void PrintResult(int product)
        {
            Console.WriteLine("Product  Of Multiple Numbers is :" + product);
        }


        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 6, 8, 10 };

            PrintResult(ProductOfMultipleNumbers(numbers));

            Console.ReadKey();

        }
    }
}

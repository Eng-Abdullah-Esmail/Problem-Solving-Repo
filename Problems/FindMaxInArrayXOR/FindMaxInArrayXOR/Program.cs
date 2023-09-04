using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxInArrayXOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 5, 20, 15, 30 };
            int maxNumber = 0;

            foreach (int num in numbers)
            {
                maxNumber ^= num ^ (num - maxNumber);
            }

            Console.WriteLine("Max Number: " + maxNumber); // Output: 30

            Console.ReadKey();
        }
    }
}

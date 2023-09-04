using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMissingNuminArrayXOR
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3, 4, 6, 7, 8, 9, 10 };
            int missingNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                missingNumber ^= numbers[i] ^ (i + 1);
            }

            Console.WriteLine("Missing Number: " + missingNumber); // Output: 5

            Console.ReadKey();
        }
    }
}

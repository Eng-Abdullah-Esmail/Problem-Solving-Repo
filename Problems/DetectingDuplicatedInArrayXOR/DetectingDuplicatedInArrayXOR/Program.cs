using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectingDuplicatedInArrayXOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 3,8,4,3, 6, 7, 8, 2, 9 };
            int duplicateNumber = 0;

            foreach (int num in numbers)
            {
                duplicateNumber ^= num;
            }

            Console.WriteLine("Duplicate Number: " + duplicateNumber); // Output: 4


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CkeckIFTwoArraysHasSameITemXOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4 };
            int[] array2 = { 3, 2, 1, 4 };
            bool hasSameElements = true;

            if (array1.Length != array2.Length)
            {
                hasSameElements = false;
            }
            else
            {
                int xorResult = 0;

                for (int i = 0; i < array1.Length; i++)
                {
                    xorResult ^= array1[i] ^ array2[i];
                }

                if (xorResult != 0)
                {
                    hasSameElements = false;
                }
            }

            Console.WriteLine("Do arrays have the same elements? " + hasSameElements); // Output: True


            Console.ReadKey();
        }
    }
}

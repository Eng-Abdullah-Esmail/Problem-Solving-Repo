using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumberOf1BitsInSetsXOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10; // Binary: 0000 1010
            int count = 0;

            while (num != 0)
            {
                if ((num & 1) == 1)
                    count++;

                num = num >> 1;
            }

            Console.WriteLine("Number of set bits: " + count); // Output: 2


            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNon_repeatingNumberXOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 2, 1, 4, 4 };
            int nonRepeatingElement = 0;

            foreach (int num in numbers)
            {
                nonRepeatingElement ^= num;
            }

            Console.WriteLine("Non-Repeating Element: " + nonRepeatingElement); // Output: 3

            Console.ReadKey();
        }
    }
}

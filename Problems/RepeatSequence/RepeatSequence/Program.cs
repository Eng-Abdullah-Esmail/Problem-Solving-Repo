using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = { 1, 2, 3 };
            int[] repeatedSequence = new int[10];

            for (int i = 0; i < 10; i++)
            {
                repeatedSequence[i] = sequence[i % sequence.Length];
            }

            Console.WriteLine("Repeated Sequence: " + string.Join(", ", repeatedSequence)); // Output: 1, 2, 3, 1, 2, 3, 1, 2, 3, 1

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapingVariableUsingXOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            a = a ^ b;
            b = a ^ b;
            a = a ^ b;

            Console.WriteLine("a: " + a);  // Output: 20
            Console.WriteLine("b: " + b);  // Output: 10

            Console.ReadKey();
        }
    }
}

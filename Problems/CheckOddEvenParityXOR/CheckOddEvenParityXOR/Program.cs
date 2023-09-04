using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOddEvenParityXOR
{
    internal class Program
    {
        // Helper method to check parity
        private static bool GetParity(byte value)
        {
            bool parity = false;
            while (value != 0)
            {
                parity ^= (value & 1) == 1;
                value >>= 1;
            }
            return parity;
        }
        static void Main(string[] args)
        {
            byte[] data = { 0x01, 0x02, 0x03, 0x04, 0x05 };
            bool hasEvenParity = false;

            foreach (byte b in data)
            {
                hasEvenParity ^= GetParity(b);
            }

            Console.WriteLine("Has even parity: " + hasEvenParity); // Output: True or False

           
      
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChecksumUsingXOR
{
    internal class Program
    {
        static void Main(string[] args)
        {

            byte[] data = { 0x01, 0x02, 0x03, 0x04, 0x05 };
            byte checksum = 0;

            foreach (byte b in data)
            {
                checksum ^= b;
            }
            Console.WriteLine("Checksum: 0x" + checksum.ToString("X2")); // Output: Checksum value in hexadecimal format

            Console.ReadKey();
        }
    }
}

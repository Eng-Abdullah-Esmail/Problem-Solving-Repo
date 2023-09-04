using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectingChangesInDataXOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] originalData = { 0x01, 0x02, 0x03, 0x04, 0x05 };
            byte[] modifiedData = { 0x01, 0x02, 0x03, 0x07, 0x05 };

            bool hasChanged = false;
            for (int i = 0; i < originalData.Length; i++)
            {
                if ((originalData[i] ^ modifiedData[i]) != 0)
                {
                    hasChanged = true;
                    break;
                }
            }

            Console.WriteLine("Data has changed: " + hasChanged);  // Output: True


            Console.ReadKey();
        }
    }
}

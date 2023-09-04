using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIFStringAnagramXOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "listen";
            string str2 = "silent";
            bool isAnagram = true;

            if (str1.Length != str2.Length)
            {
                isAnagram = false;
            }
            else
            {
                int xorValue = 0;

                for (int i = 0; i < str1.Length; i++)
                {
                    xorValue ^= str1[i] ^ str2[i];
                }

                if (xorValue != 0)
                {
                    isAnagram = false;
                }
            }

            Console.WriteLine("Are the strings anagrams? " + isAnagram); // Output: True


            Console.ReadKey();
        }
    }
}

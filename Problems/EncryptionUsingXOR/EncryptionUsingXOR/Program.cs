using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionUsingXOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string originalString = "Hello, World!";
            char xorKey = 'K';

            // Encrypting the string
            string encryptedString = "";
            foreach (char c in originalString)
            {
                char encryptedChar = (char)(c ^ xorKey);
                encryptedString += encryptedChar;
            }
            Console.WriteLine("Encrypted String: " + encryptedString);

            // Decrypting the string
            string decryptedString = "";
            foreach (char c in encryptedString)
            {
                char decryptedChar = (char)(c ^ xorKey);
                decryptedString += decryptedChar;
            }
            Console.WriteLine("Decrypted String: " + decryptedString);


            Console.ReadKey();

        }
    }
}

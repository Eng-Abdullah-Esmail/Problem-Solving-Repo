using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ComputerSecProject
{
    class CaesarCipher
    {
        private int shift;

        public CaesarCipher(int shift)
        {
            this.shift = shift;
        }

        public string Encrypt(string plaintext)
        {
            char[] chars = plaintext.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];
                if (char.IsLetter(c))
                {
                    //get the starting character in order to determine the position of other letters
                    char baseChar = char.IsUpper(c) ? 'A' : 'a';
                    c = (char)(((c + shift - baseChar) % 26) + baseChar);
                    chars[i] = c;
                }
            }

            return new string(chars);
        }

        public string Decrypt(string ciphertext)
        {
            CaesarCipher reverseCipher = new CaesarCipher(26 - shift);
            return reverseCipher.Encrypt(ciphertext);
        }

        public static int ReadKey()
        {
            int key;
            Console.WriteLine("Enter the Key please");
            key = int.Parse(Console.ReadLine());

            return key;
        }
        public static string ReadText()
        {
            Console.WriteLine("Enter the Text to cipher");
            string plainText = Console.ReadLine();

            return plainText;
        }


    }




    //******************************************************************88
    public class PlayfairCipher
    {
        private string key;
        private char[,] playfairMatrix;

        public PlayfairCipher(string key)
        {
            SetKey(key);

        }

        public void SetKey(string key)
        {
            // Remove any non-alphabetic characters and convert to upper case
            this.key = new string(key.Where(char.IsLetter).Select(char.ToUpper).ToArray());

            // Remove any occurrences of 'J' and replace with 'I'
            this.key = this.key.Replace('J', 'I');

            // Initialize the playfair matrix with the key
            playfairMatrix = new char[5, 5];
            int rowIndex = 0, colIndex = 0;

            foreach (char c in this.key)
            {
                if (!playfairMatrix.Cast<char>().Contains(c))
                {
                    playfairMatrix[rowIndex, colIndex] = c;
                    colIndex++;

                    if (colIndex == 5)
                    {
                        colIndex = 0;
                        rowIndex++;
                    }
                }
            }

            // Fill in the rest of the matrix with unused letters in alphabetical order
            for (char c = 'A'; c <= 'Z'; c++)
            {
                if (c == 'J')
                {
                    continue;
                }

                if (!playfairMatrix.Cast<char>().Contains(c))
                {
                    playfairMatrix[rowIndex, colIndex] = c;
                    colIndex++;

                    if (colIndex == 5)
                    {
                        colIndex = 0;
                        rowIndex++;
                    }
                }
            }
        }

        public string Encrypt(string plaintext)
        {
            // Convert the plaintext to upper case and remove any non-alphabetic characters
            plaintext = new string(plaintext.Where(char.IsLetter).Select(char.ToUpper).ToArray());

            // Replace any occurrences of 'J' with 'I'
            plaintext = plaintext.Replace('J', 'I');

            // Split the plaintext into pairs of two letters
            List<string> pairs = new List<string>();

            for (int i = 0; i < plaintext.Length; i += 2)
            {
                if (i == plaintext.Length - 1 || plaintext[i] == plaintext[i + 1])
                {
                    pairs.Add(plaintext[i] + "X");
                    i--;
                }
                else
                {
                    pairs.Add(plaintext.Substring(i, 2));
                }
            }

            // Encrypt each pair of letters using the playfair matrix
            string ciphertext = "";

            foreach (string pair in pairs)
            {
                int row1 = 0, col1 = 0, row2 = 0, col2 = 0;
                FindLetter(pair[0], out row1, out col1);
                FindLetter(pair[1], out row2, out col2);

                if (row1 == row2)
                {
                    col1 = (col1 + 1) % 5;
                    col2 = (col2 + 1) % 5;
                }
                else if (col1 == col2)
                {
                    row1 = (row1 + 1) % 5;
                    row2 = (row2 + 1) % 5;
                }
                else
                {
                    int temp = col1;
                    col1 = col2;
                    col2 = temp;
                }

                ciphertext += playfairMatrix[row1, col1];
                ciphertext += playfairMatrix[row2, col2];
            }

            return ciphertext;
        }

        public string Decrypt(string ciphertext)
        {
            // Convert the ciphertext to upper case and remove any non-alphabetic characters
            ciphertext = new string(ciphertext.Where(char.IsLetter).Select(char.ToUpper).ToArray());

            // Replace any occurrences of 'J' with 'I'
            ciphertext = ciphertext.Replace('J', 'I');

            // Decrypt each pair of letters using the playfair matrix
            string plaintext = "";

            foreach (string pair in Enumerable.Range(0, ciphertext.Length / 2).Select(i => ciphertext.Substring(i * 2, 2)))
            {
                int row1 = 0, col1 = 0, row2 = 0, col2 = 0;
                FindLetter(pair[0], out row1, out col1);
                FindLetter(pair[1], out row2, out col2);

                if (row1 == row2)
                {
                    col1 = (col1 - 1 + 5) % 5;
                    col2 = (col2 - 1 + 5) % 5;
                }
                else if (col1 == col2)
                {
                    row1 = (row1 - 1 + 5) % 5;
                    row2 = (row2 - 1 + 5) % 5; }
                else
                {
                    int temp = col1;
                    col1 = col2;
                    col2 = temp;
                }

                plaintext += playfairMatrix[row1, col1];
                plaintext += playfairMatrix[row2, col2];
            }

            return plaintext;
        }

        private void FindLetter(char letter, out int row, out int col)
        {
            for (row = 0; row < 5; row++)
            {
                for (col = 0; col < 5; col++)
                {
                    if (playfairMatrix[row, col] == letter)
                    {
                        return;
                    }
                }
            }

            throw new ArgumentException($"The letter '{letter}' is not in the playfair matrix.");
        }




    }


    class MonoalphabeticCipher
    {
        private string key;

        public MonoalphabeticCipher(string key)
        {
            this.key = key;
        }

        public string Encrypt(string plaintext)
        {
            char[] chars = plaintext.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];
                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'A' : 'a';
                    int keyIndex = char.ToUpper(c) - 'A';
                    c = key[keyIndex];
                    if (char.IsLower(chars[i]))
                    {
                        c = char.ToLower(c);
                    }
                    chars[i] = c;
                }
            }

            return new string(chars);
        }

        public string Decrypt(string ciphertext)
        {
            char[] chars = ciphertext.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];
                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'A' : 'a';
                    int keyIndex = key.IndexOf(char.ToUpper(c));
                    c = (char)(baseChar + keyIndex);
                    if (char.IsLower(chars[i]))
                    {
                        c = char.ToLower(c);
                    }
                    chars[i] = c;
                }
            }

            return new string(chars);
        }
    }


    //********************************************************************************8
    class OneTimePadCipher
    {
        private string key;

        public OneTimePadCipher(string key)
        {
            this.key = key;
        }

        public string Encrypt(string plaintext)
        {
            plaintext = plaintext.ToUpper().Replace(" ", "");
            string ciphertext = "";
            for (int i = 0; i < plaintext.Length; i++)
            {
                char c = plaintext[i];
                int keyIndex = i % key.Length;
                int shift = key[keyIndex] - 'A';
                c = (char)(((c - 'A' + shift) % 26) + 'A');
                ciphertext += c;
            }
            return ciphertext;
        }

        public string Decrypt(string ciphertext)
        {
            string plaintext = "";
            for (int i = 0; i < ciphertext.Length; i++)
            {
                char c = ciphertext[i];
                int keyIndex = i % key.Length;
                int shift = key[keyIndex] - 'A';
                c = (char)(((c - 'A' - shift + 26) % 26) + 'A');
                plaintext += c;
            }
            return plaintext;
        }
    }


    class VernamCihper
    {

        public static void StartVernam()
        {


            WriteLine(@"The idea is to perform xor operation between the key and the message you want to cipher with consider to take the same key and

                                    ");
            // Define the message and the passphrase as strings
            string message = "Abdullah";
            string passphrase = "SECRETKY";

            // Convert the message and the passphrase to binary format
            string binaryMessage = StringToBinary(message);
            string binaryPassphrase = StringToBinary(passphrase);

            // Generate the key by performing the XOR operation between the message and the passphrase
            string key = Xor(binaryMessage, binaryPassphrase);

            // Encrypt the message by performing the XOR operation between the message and the key
            string encryptedMessage = Xor(binaryMessage, key);

            // Print the encrypted message and the key to the console
            Console.WriteLine("Encrypted message: " + BinaryToString(encryptedMessage));
            Console.WriteLine("Key: " + BinaryToString(key));

            // Decrypt the message by performing the XOR operation between the encrypted message and the key
            string decryptedMessage = Xor(encryptedMessage, key);

            // Print the decrypted message to the console
            Console.WriteLine("Decrypted message: " + BinaryToString(decryptedMessage));
        }

        static string StringToBinary(string text)
        {
            // Convert the string to a byte array
            byte[] bytes = Encoding.ASCII.GetBytes(text);

            // Convert each byte to a binary string and concatenate the results
            StringBuilder binary = new StringBuilder();
            foreach (byte b in bytes)
            {
                binary.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
            }

            return binary.ToString();
        }

        static string BinaryToString(string binary)
        {
            // Split the binary string into 8-bit chunks
            int numBytes = binary.Length / 8;
            byte[] bytes = new byte[numBytes];

            for (int i = 0; i < numBytes; i++)
            {
                string binaryByte = binary.Substring(i * 8, 8);
                bytes[i] = Convert.ToByte(binaryByte, 2);
            }

            // Convert the byte array to a string
            return Encoding.ASCII.GetString(bytes);
        }

        static string Xor(string binary1, string binary2)
        {
            // Perform the XOR operation between the two binary strings
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < binary1.Length; i++)
            {
                if (binary1[i] == binary2[i])
                {
                    result.Append('0');
                }
                else
                {
                    result.Append('1');
                }
            }

            return result.ToString();
        }

    }


        
    



    internal class Program
    {

        public static void StartCaser()
        {
            WriteLine(@"The idea is to take a key and add it to the value of the letter you want to cipher");
            CaesarCipher cipher = new CaesarCipher(CaesarCipher.ReadKey());


            string ciphertext = cipher.Encrypt(CaesarCipher.ReadText());
            Console.WriteLine($"Ciphertext: {ciphertext}");

            string decryptedText = cipher.Decrypt(ciphertext);
            Console.WriteLine($"Decrypted text: {decryptedText}");
        }


        private static void StartPlayFair()
        {
            WriteLine(@"Dear Teacher: \n The IDEA of PlayFair is to create 5x5 matrix and add the secert key 
            We Take Two Letter at a time and cipher them , if there to letter in the same row, then we take the corrospond letter, \n
            if they in the same column we take the corrospond within the column
");

            string key = "SECRETKEY";
            string plaintext = "Samia Kasim";

            PlayfairCipher cipher = new PlayfairCipher(key);

            string ciphertext = cipher.Encrypt(plaintext);
            Console.WriteLine(ciphertext);

            string decryptedText = cipher.Decrypt(ciphertext);
            Console.WriteLine(decryptedText);
        }


        private static void StartMono()
        {
            WriteLine(@"The idea is to take the permuataion of the set of alphabetic, in this algorithm i checked if i found a letter then swap it with another value within the 
                    within the range of the set of characters: 26 letter ");
            MonoalphabeticCipher cipher = new MonoalphabeticCipher("QWERTYUIOPASDFGHJKLZXCVBNM");

            string plaintext = "Samia Kasim!";
            string ciphertext = cipher.Encrypt(plaintext);
            Console.WriteLine($"Ciphertext: {ciphertext}");

            string decryptedText = cipher.Decrypt(ciphertext);
            Console.WriteLine($"Decrypted text: {decryptedText}");
        }



        private static void StartOneTimePad()
        {
            WriteLine(@"This implementation of the algorithm is not completed as it uses a shifing cipher. Ignore it");

            OneTimePadCipher cipher = new OneTimePadCipher("SECRETKEY");

            string plaintext = "Abdullah";
            string ciphertext = cipher.Encrypt(plaintext);
            Console.WriteLine($"Ciphertext: {ciphertext}");

            string decryptedText = cipher.Decrypt(ciphertext);
            Console.WriteLine($"Decrypted text: {decryptedText}");
        }


        

        static void Startup()
        {
            WriteLine("Press 1 : caser");
            WriteLine("Press 2- Playfair");
            WriteLine("Press 3 : MonoApha");
            WriteLine("Press 4- One Time pad");
          
            WriteLine("Press 5 - Vernam cipher:");
            WriteLine("Enter your choice");
            int choic = int.Parse(ReadLine());
            switch(choic)
            {
                case 1:
                    StartCaser();
                        break;
                case 2:
                    StartPlayFair();
                    break;
                case 3:
                    StartMono();
                    break;
                case 4:
                    StartOneTimePad();
                    break;

                case 5:
                    VernamCihper.StartVernam();
                    break;

                default:
                    WriteLine("Application Stopped, Start it again");
                    break;
                    
            }
        }

        static void Main(string[] args)
        {
           

            while (true)
            {
                Startup();
            }

            ReadKey();
        }
    }
}

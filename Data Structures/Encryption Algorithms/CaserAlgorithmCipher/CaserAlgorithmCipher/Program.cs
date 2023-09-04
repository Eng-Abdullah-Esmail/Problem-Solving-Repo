using System;

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

class Program
{

    
    static void Main(string[] args)
    {
        CaesarCipher cipher = new CaesarCipher(CaesarCipher.ReadKey());

       
        string ciphertext = cipher.Encrypt(CaesarCipher.ReadText());
        Console.WriteLine($"Ciphertext: {ciphertext}");

        string decryptedText = cipher.Decrypt(ciphertext);
        Console.WriteLine($"Decrypted text: {decryptedText}");
        Console.ReadKey();
    }
}
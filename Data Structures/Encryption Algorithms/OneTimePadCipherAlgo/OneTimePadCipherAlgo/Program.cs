using System;

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

class Program
{
    static void Main(string[] args)
    {
        OneTimePadCipher cipher = new OneTimePadCipher("KEY");

        string plaintext = "HELLO WORLD";
        string ciphertext = cipher.Encrypt(plaintext);
        Console.WriteLine($"Ciphertext: {ciphertext}");

        string decryptedText = cipher.Decrypt(ciphertext);
        Console.WriteLine($"Decrypted text: {decryptedText}");

        Console.ReadKey();
    }
}
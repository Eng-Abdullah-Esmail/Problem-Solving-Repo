using System;

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

class Program
{
    static void Main(string[] args)
    {
        MonoalphabeticCipher cipher = new MonoalphabeticCipher("QWERTYUIOPASDFGHJKLZXCVBNM");

        string plaintext = "Hello, World!";
        string ciphertext = cipher.Encrypt(plaintext);
        Console.WriteLine($"Ciphertext: {ciphertext}");

        string decryptedText = cipher.Decrypt(ciphertext);
        Console.WriteLine($"Decrypted text: {decryptedText}");

        Console.ReadKey();
    }
}
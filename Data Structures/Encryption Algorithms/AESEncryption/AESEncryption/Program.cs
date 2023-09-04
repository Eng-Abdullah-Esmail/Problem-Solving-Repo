using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string message = "This is a secret message.";
        string password = "MySecretPassword123";

        byte[] encrypted = EncryptString(message, password);
        string decrypted = DecryptString(encrypted, password);

        Console.WriteLine("Original message: " + message);
        Console.WriteLine("Encrypted message: " + Convert.ToBase64String(encrypted));
        Console.WriteLine("Decrypted message: " + decrypted);

        Console.ReadKey();
    }

    static byte[] EncryptString(string message, string password)
    {
        byte[] salt = new byte[16];
        using (var rng = new RNGCryptoServiceProvider())
        {
            rng.GetBytes(salt);
        }

        var key = new Rfc2898DeriveBytes(password, salt, 10000, HashAlgorithmName.SHA256);
        byte[] keyBytes = key.GetBytes(32);
        byte[] ivBytes = key.GetBytes(16);

        using (var aes = Aes.Create())
        {
            aes.Key = keyBytes;
            aes.IV = ivBytes;

            using (var encryptor = aes.CreateEncryptor())
            {
                using (var ms = new MemoryStream())
                {
                    ms.Write(salt, 0, salt.Length);
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (var sw = new StreamWriter(cs))
                        {
                            sw.Write(message);
                        }
                    }
                    return ms.ToArray();
                }
            }
        }
    }

    static string DecryptString(byte[] encrypted, string password)
    {
        byte[] salt = new byte[16];
        Array.Copy(encrypted, salt, salt.Length);

        var key = new Rfc2898DeriveBytes(password, salt, 10000, HashAlgorithmName.SHA256);
        byte[] keyBytes = key.GetBytes(32);
        byte[] ivBytes = key.GetBytes(16);

        using (var aes = Aes.Create())
        {
            aes.Key = keyBytes;
            aes.IV = ivBytes;

            using (var decryptor = aes.CreateDecryptor())
            {
                using (var ms = new MemoryStream(encrypted, salt.Length, encrypted.Length - salt.Length))
                {
                    using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (var sr = new StreamReader(cs))
                        {
                            return sr.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
using System;
using System.Linq;

class PlayfairCipher
{
    private char[,] keyMatrix;

    public PlayfairCipher(string key)
    {
        // Remove duplicate letters from the key
        string cleanedKey = new string(key.ToUpper().Distinct().ToArray());

        // Fill the key matrix with the cleaned key
        keyMatrix = new char[5, 5];
        int rowIndex = 0, colIndex = 0;
        foreach (char c in cleanedKey)
        {
            keyMatrix[rowIndex, colIndex] = c;
            colIndex++;
            if (colIndex == 5)
            {
                rowIndex++;
                colIndex = 0;
            }
        }

        // Fill the rest of the matrix with the remaining letters of the alphabet
        char currentChar = 'A';
        while (rowIndex < 5)
        {
            if (!cleanedKey.Contains(currentChar))
            {
                keyMatrix[rowIndex, colIndex] = currentChar;
                colIndex++;
                if (colIndex == 5)
                {
                    rowIndex++;
                    colIndex = 0;
                }
            }
            currentChar++;
        }
    }

    private Tuple<int, int> FindPosition(char c)
    {
        for (int row = 0; row < 5; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                if (keyMatrix[row, col] == c)
                {
                    return Tuple.Create(row, col);
                }
            }
        }
        return null;
    }

    private char GetCharAtPosition(int row, int col)
    {
        return keyMatrix[row, col];
    }

    private string ProcessPair(char c1, char c2, int shift)
    {
        Tuple<int, int> pos1 = FindPosition(c1);
        Tuple<int, int> pos2 = FindPosition(c2);

        if (pos1 == null || pos2 == null)
        {
            // Invalid characters
            return "";
        }

        int row1 = pos1.Item1, col1 = pos1.Item2;
        int row2 = pos2.Item1, col2 = pos2.Item2;

        if (row1 == row2)
        {
            // Same row
            col1 = (col1 + shift) % 5;
            col2 = (col2 + shift) % 5;
        }
        else if (col1 == col2)
        {
            // Same column
            row1 = (row1 + shift) % 5;
            row2 = (row2 + shift) % 5;
        }
        else
        {
            // Different row and column
            int temp = col1;
            col1 = col2;
            col2 = temp;
        }

        return $"{GetCharAtPosition(row1, col1)}{GetCharAtPosition(row2, col2)}";
    }

    public string Encrypt(string plaintext)
    {
        plaintext = plaintext.ToUpper().Replace("J", "I").Replace(" ", "");
        if (plaintext.Length % 2 == 1)
        {
            plaintext += "X";
        }

        string ciphertext = "";
        for (int i = 0; i < plaintext.Length; i += 2)
        {
            ciphertext += ProcessPair(plaintext[i], plaintext[i + 1], 1);
        }

        return ciphertext;
    }

    public string Decrypt(string ciphertext)
    {
        string plaintext = "";
        for (int i = 0; i < ciphertext.Length; i += 2)
        {
            plaintext += ProcessPair(ciphertext[i], ciphertext[i + 1], 4);
        }
        return plaintext;
    }
}

class Program
{
    static void Main(string[] args)
    {
        PlayfairCipher cipher = new PlayfairCipher("KEYWORD");

        string plaintext = "HELLO WORLD";
        string ciphertext = cipher.Encrypt(plaintext);
        Console.WriteLine($"Ciphertext: {ciphertext}");

        string decryptedText = cipher.Decrypt(ciphertext);
        Console.WriteLine($"Decrypted text: {decryptedText}");

        Console.ReadKey();
    }
}
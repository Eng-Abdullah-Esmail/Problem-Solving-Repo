using System;

class Guid
{
    private byte[] data;

    public Guid()
    {
        data = new byte[16];
        GenerateGuid();
    }

    public override string ToString()
    {
        return BitConverter.ToString(data).Replace("-", "");
    }

    private void GenerateGuid()
    {
        // Generate 16 random bytes
        byte[] bytes = new byte[16];
        new Random().NextBytes(bytes);

        // Set the version bits (4 MSBs of byte 6) to 0100 (version 4)
        bytes[6] = (byte)((bytes[6] & 0x0F) | 0x40);

        // Set the variant bits (2 MSBs of byte 8) to 10xx (variant 2)
        bytes[8] = (byte)((bytes[8] & 0x3F) | 0x80);

        // Copy the bytes to the data array
        Array.Copy(bytes, data, 16);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new Guid object
        Guid guid = new Guid();

        // Print the GUID as a string
        Console.WriteLine(guid.ToString());

        Console.ReadKey();
    }
}
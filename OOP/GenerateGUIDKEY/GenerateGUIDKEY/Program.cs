using System;

class GuidGenerator
{
    private Guid guid;

    public GuidGenerator()
    {
        GenerateGuid();
    }

    public Guid GetGuid()
    {
        return guid;
    }

    private void GenerateGuid()
    {
        guid = Guid.NewGuid();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new GuidGenerator object
        GuidGenerator guidGenerator = new GuidGenerator();

        // Get the GUID from the GuidGenerator object
        Guid guid = guidGenerator.GetGuid();

        // Print the GUID as a string
        Console.WriteLine(guid.ToString());

        Console.ReadKey();
    }
}
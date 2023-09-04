using System;
using System.Collections.Generic;

class Table
{
    private List<List<string>> data;
    private List<string> columnNames;

    public Table()
    {
        data = new List<List<string>>();
        columnNames = new List<string>();
    }

    public void AddColumn(string columnName)
    {
        columnNames.Add(columnName);
    }

    public void AddRow(List<string> rowData)
    {
        data.Add(rowData);
    }

    public void PrintTable()
    {
        // Print column names
        foreach (var columnName in columnNames)
        {
            Console.Write($"{columnName}\t");
        }
        Console.WriteLine();

        // Print rows
        foreach (var row in data)
        {
            foreach (var cell in row)
            {
                Console.Write($"{cell}\t");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        Table table = new Table();

        table.AddColumn("Name");
        table.AddColumn("Age");
        table.AddColumn("City");

        table.AddRow(new List<string> { "John", "25", "New York" });
        table.AddRow(new List<string> { "Emily", "30", "Los Angeles" });
        table.AddRow(new List<string> { "Michael", "35", "Chicago" });

        table.PrintTable();

        Console.ReadKey();
    }
}
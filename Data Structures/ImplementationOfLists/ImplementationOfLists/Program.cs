using System;

class List
{
    private object[] items;
    private int count;

    public List(int capacity)
    {
        items = new object[capacity];
        count = 0;
    }

    public void Add(object item)
    {
        if (count == items.Length)
        {
            Resize();
        }
        items[count++] = item;
    }

    public void Insert(int index, object item)
    {
        if (index < 0 || index > count)
        {
            throw new IndexOutOfRangeException();
        }
        if (count == items.Length)
        {
            Resize();
        }
        for (int i = count; i > index; i--)
        {
            items[i] = items[i - 1];
        }
        items[index] = item;
        count++;
    }

    public void Remove(object item)
    {
        int index = IndexOf(item);
        if (index != -1)
        {
            RemoveAt(index);
        }
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new IndexOutOfRangeException();
        }
        for (int i = index; i < count - 1; i++)
        {
            items[i] = items[i + 1];
        }
        items[count - 1] = null;
        count--;
    }

    public int IndexOf(object item)
    {
        for (int i = 0; i < count; i++)
        {
            if (items[i].Equals(item))
            {
                return i;
            }
        }
        return -1;
    }

    public bool Contains(object item)
    {
        return IndexOf(item) != -1;
    }

    public int Count
    {
        get { return count; }
    }

    public void Clear()
    {
        for (int i = 0; i < count; i++)
        {
            items[i] = null;
        }
        count = 0;
    }

    private void Resize()
    {
        int newCapacity = items.Length * 2;
        object[] newItems = new object[newCapacity];
        Array.Copy(items, newItems, count);
        items = newItems;
    }

    public object this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }
            return items[index];
        }
        set
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }
            items[index] = value;
        }
    }

    public void Print()
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write(items[i] + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new List object and add some items
        List list = new List(3);
        list.Add("A");
        list.Add("B");
        list.Add("C");

        // Print the list and its count
        list.Print();
        Console.WriteLine("Count: " + list.Count);

        // Insert an item at index 1 and print the list
        list.Insert(1, "D");
        list.Print();

        // Remove an item and print the list
        list.Remove("B");
        list.Print();

        // Modify an item and print the list
        list[2] = "E";
        list.Print();

        // Clear the list and print its count
        list.Clear();
        Console.WriteLine("Count: " + list.Count);

        Console.ReadKey();

    }
}
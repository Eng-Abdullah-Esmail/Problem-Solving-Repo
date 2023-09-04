using System;

class HashSet
{
    private int capacity;
    private int count;
    private object[] items;

    public HashSet(int capacity)
    {
        this.capacity = capacity;
        count = 0;
        items = new object[capacity];
    }

    public bool Add(object item)
    {
        if (Contains(item))
        {
            return false;
        }
        if (count == capacity)
        {
            Resize();
        }
        int index = GetIndex(item);
        items[index] = item;
        count++;
        return true;
    }

    public bool Remove(object item)
    {
        int index = GetIndex(item);
        if (index == -1 || items[index] == null)
        {
            return false;
        }
        items[index] = null;
        count--;
        return true;
    }

    public bool Contains(object item)
    {
        int index = GetIndex(item);
        return index != -1 && items[index] != null;
    }

    public int Count
    {
        get { return count; }
    }

    public void Clear()
    {
        count = 0;
        items = new object[capacity];
    }

    private int GetIndex(object item)
    {
        int hashCode = item.GetHashCode();
        int index = Math.Abs(hashCode % capacity);
        while (items[index] != null && !items[index].Equals(item))
        {
            index = (index + 1) % capacity;
        }
        return index;
    }

    private void Resize()
    {
        int newCapacity = capacity * 2;
        object[] newItems = new object[newCapacity];
        foreach (object item in items)
        {
            if (item != null)
            {
                int index = GetIndex(item);
                newItems[index] = item;
            }
        }
        capacity = newCapacity;
        items = newItems;
    }

    public void Print()
    {
        foreach (object item in items)
        {
            if (item != null)
            {
                Console.Write(item + " ");
            }
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new HashSet object and add some items
        HashSet set = new HashSet(3);
        set.Add("A");
        set.Add("B");
        set.Add("C");

        // Print the set and its count
        set.Print();
        Console.WriteLine("Count: " + set.Count);

        // Add and remove an item and print the set
        set.Add("D");
        set.Remove("B");
        set.Print();

        // Clear the set and print its count
        set.Clear();
        Console.WriteLine("Count: " + set.Count);

        Console.ReadKey();
    }
}
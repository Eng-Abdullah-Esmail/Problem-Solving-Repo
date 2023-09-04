using System;

class Dictionary
{
    private int capacity;
    private int count;
    private object[] keys;
    private object[] values;

    public Dictionary(int capacity)
    {
        this.capacity = capacity;
        count = 0;
        keys = new object[capacity];
        values = new object[capacity];
    }

    public void Add(object key, object value)
    {
        if (count == capacity)
        {
            Resize();
        }
        int index = GetIndex(key);
        keys[index] = key;
        values[index] = value;
        count++;
    }

    public void Remove(object key)
    {
        int index = GetIndex(key);
        if (index == -1 || keys[index] == null)
        {
            return;
        }
        keys[index] = null;
        values[index] = null;
        count--;
    }

    public bool ContainsKey(object key)
    {
        int index = GetIndex(key);
        return index != -1 && keys[index] != null;
    }

    public bool TryGetValue(object key, out object value)
    {
        value = null;
        int index = GetIndex(key);
        if (index != -1 && keys[index] != null)
        {
            value = values[index];
            return true;
        }
        return false;
    }

    public int Count
    {
        get { return count; }
    }

    public void Clear()
    {
        count = 0;
        keys = new object[capacity];
        values = new object[capacity];
    }

    private int GetIndex(object key)
    {
        int hashCode = key.GetHashCode();
        int index = Math.Abs(hashCode % capacity);
        while (keys[index] != null && !keys[index].Equals(key))
        {
            index = (index + 1) % capacity;
        }
        return index;
    }

    private void Resize()
    {
        int newCapacity = capacity * 2;
        object[] newKeys = new object[newCapacity];
        object[] newValues = new object[newCapacity];
        foreach (object key in keys)
        {
            if (key != null)
            {
                int index = GetIndex(key);
                newKeys[index] = key;
                newValues[index] = values[index];
            }
        }
        capacity = newCapacity;
        keys = newKeys;
        values = newValues;
    }

    public void Print()
    {
        for (int i = 0; i < capacity; i++)
        {
            if (keys[i] != null)
            {
                Console.WriteLine(keys[i] + ": " + values[i]);
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new Dictionary object and add some key-value pairs
        Dictionary dict = new Dictionary(3);
        dict.Add("A", 1);
        dict.Add("B", 2);
        dict.Add("C", 3);

        // Print the dictionary and its count
        dict.Print();
        Console.WriteLine("Count: " + dict.Count);

        // Remove a key-value pair and print the dictionary
        dict.Remove("B");
        dict.Print();

        // Try to get a value for a key and print the result
        object value;
        if (dict.TryGetValue("C", out value))
        {
            Console.WriteLine("Value for C: " + value);
        }
        else
        {
            Console.WriteLine("C not found");
        }

        // Clear the dictionary and print its count
        dict.Clear();
        Console.WriteLine("Count: " + dict.Count);

        Console.ReadKey ();
    }
}
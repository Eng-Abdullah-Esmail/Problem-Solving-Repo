using System;

class Queue
{
    private object[] items;
    private int head;
    private int tail;

    public Queue(int size)
    {
        items = new object[size];
        head = 0;
        tail = -1;
    }

    public void Enqueue(object item)
    {
        if (tail == items.Length - 1)
        {
            throw new InvalidOperationException("Queue is full.");
        }
        items[++tail] = item;
    }

    public object Dequeue()
    {
        if (head > tail)
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        return items[head++];
    }

    public object Peek()
    {
        if (head > tail)
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        return items[head];
    }

    public int Count
    {
        get { return tail - head + 1; }
    }

    public void Clear()
    {
        head = 0;
        tail = -1;
    }

    public bool Contains(object item)
    {
        for (int i = head; i <= tail; i++)
        {
            if (items[i].Equals(item))
            {
                return true;
            }
        }
        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new Queue object and enqueue some items
        Queue queue = new Queue(3);
        queue.Enqueue("A");
        queue.Enqueue("B");
        queue.Enqueue("C");

        // Dequeue items from the queue and print them
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }

        Console.ReadKey();
    }
}
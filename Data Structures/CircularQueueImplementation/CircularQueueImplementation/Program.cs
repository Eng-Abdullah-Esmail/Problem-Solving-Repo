using System;

class CircularQueue
{
    private int[] items;
    private int front;
    private int rear;
    private int capacity;
    private int count;

    public CircularQueue(int capacity)
    {
        this.capacity = capacity;
        items = new int[capacity];
        front = 0;
        rear = -1;
        count = 0;
    }

    public void Enqueue(int item)
    {
        if (count == capacity)
        {
            throw new Exception("Queue is full");
        }
        rear = (rear + 1) % capacity;
        items[rear] = item;
        count++;
    }

    public int Dequeue()
    {
        if (count == 0)
        {
            throw new Exception("Queue is empty");
        }
        int item = items[front];
        front = (front + 1) % capacity;
        count--;
        return item;
    }

    public int Peek()
    {
        if (count == 0)
        {
            throw new Exception("Queue is empty");
        }
        return items[front];
    }

    public bool IsEmpty()
    {
        return count == 0;
    }

    public bool IsFull()
    {
        return count == capacity;
    }

    public int Count
    {
        get { return count; }
    }

    public void Clear()
    {
        front = 0;
        rear = -1;
        count = 0;
    }

    public void Print()
    {
        int current = front;
        for (int i = 0; i < count; i++)
        {
            Console.Write(items[current] + " ");
            current = (current + 1) % capacity;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new CircularQueue object and add some items
        CircularQueue queue = new CircularQueue(3);
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        // Print the queue and its count
        queue.Print();
        Console.WriteLine("Count: " + queue.Count);

        // Remove an item and print the queue
        queue.Dequeue();
        queue.Print();

        // Peek at the front item and print the result
        Console.WriteLine("Peek: " + queue.Peek());

        // Clear the queue and print its count
        queue.Clear();
        Console.WriteLine("Count: " + queue.Count);

        Console.ReadKey();
    }
}
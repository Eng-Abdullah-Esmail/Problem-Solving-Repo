using System;

class Node
{
    public object Data;
    public Node Next;

    public Node(object data)
    {
        Data = data;
        Next = null;
    }
}

class LinkedList
{
    private Node head;

    public void AddFirst(object data)
    {
        Node newNode = new Node(data);
        newNode.Next = head;
        head = newNode;
    }

    public void AddLast(object data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void RemoveFirst()
    {
        if (head == null)
        {
            throw new InvalidOperationException("List is empty.");
        }
        head = head.Next;
    }

    public void RemoveLast()
    {
        if (head == null)
        {
            throw new InvalidOperationException("List is empty.");
        }
        if (head.Next == null)
        {
            head = null;
        }
        else
        {
            Node current = head;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }
            current.Next = null;
        }
    }

    public void Clear()
    {
        head = null;
    }

    public bool Contains(object data)
    {
        Node current = head;
        while (current != null)
        {
            if (current.Data.Equals(data))
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public int Count
    {
        get
        {
            int count = 0;
            Node current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }
    }

    public void Print()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new LinkedList object and add some nodes
        LinkedList list = new LinkedList();
        list.AddLast("A");
        list.AddLast("B");
        list.AddLast("C");

        // Print the list and its count
        list.Print();
        Console.WriteLine("Count: " + list.Count);

        // Remove the first and last nodes and print the list
        list.RemoveFirst();
        list.RemoveLast();
        list.Print();

        // Clear the list and print its count
        list.Clear();
        Console.WriteLine("Count: " + list.Count);

        Console.ReadKey();
    }
}
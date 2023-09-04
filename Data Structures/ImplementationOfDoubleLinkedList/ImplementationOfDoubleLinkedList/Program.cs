using System;

class DoublyLinkedList
{
    private Node head;
    private Node tail;
    private int count;

    public DoublyLinkedList()
    {
        head = null;
        tail = null;
        count = 0;
    }

    public void AddFirst(object data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
        }
        count++;
    }

    public void AddLast(object data)
    {
        Node newNode = new Node(data);
        if (tail == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            newNode.Prev = tail;
            tail.Next = newNode;
            tail = newNode;
        }
        count++;
    }

    public bool Remove(object data)
    {
        Node current = head;
        while (current != null)
        {
            if (current.Data.Equals(data))
            {
                if (current == head)
                {
                    head = current.Next;
                    if (head != null)
                    {
                        head.Prev = null;
                    }
                    else
                    {
                        tail = null;
                    }
                }
                else if (current == tail)
                {
                    tail = current.Prev;
                    if (tail != null)
                    {
                        tail.Next = null;
                    }
                    else
                    {
                        head = null;
                    }
                }
                else
                {
                    current.Prev.Next = current.Next;
                    current.Next.Prev = current.Prev;
                }
                count--;
                return true;
            }
            current = current.Next;
        }
        return false;
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
        get { return count; }
    }

    public void Clear()
    {
        head = null;
        tail = null;
        count = 0;
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

    private class Node
    {
        public object Data;
        public Node Prev;
        public Node Next;

        public Node(object data)
        {
            Data = data;
            Prev = null;
            Next = null;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new DoublyLinkedList object and add some items
        DoublyLinkedList list = new DoublyLinkedList();
        list.AddFirst("A");
        list.AddLast("B");
        list.AddLast("C");

        // Print the list and its count
        list.Print();
        Console.WriteLine("Count: " + list.Count);

        // Remove an item and print the list
        list.Remove("B");
        list.Print();

        // Check if the list contains an item and print the result
        Console.WriteLine("Contains C: " + list.Contains("C"));

        // Clear the list and print its count
        list.Clear();
        Console.WriteLine("Count: " + list.Count);

        Console.ReadKey();
    }
}
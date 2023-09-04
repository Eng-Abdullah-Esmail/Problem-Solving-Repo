using System;

class Stack<T>
{
    private T[] items;
    private int top;

    public Stack(int size)
    {
        items = new T[size];
        top = -1;
    }

    public void Push(T item)
    {
        if (top == items.Length - 1)
        {
            throw new StackOverflowException("Stack is full.");
        }
        items[++top] = item;
    }

    public T Pop()
    {
        if (top == -1)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        return items[top--];
    }

    public T Peek()
    {
        if (top == -1)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        return items[top];
    }

    public int Count
    {
        get { return top + 1; }
    }

    public void Clear()
    {
        top = -1;
    }

    public bool Contains(T item)
    {
        for (int i = 0; i <= top; i++)
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
        // Create a new Stack object and push some items
        Stack<int> stack = new Stack<int>(3);
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        // Pop items off the stack and print them
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }

        Console.ReadKey();
    }
}
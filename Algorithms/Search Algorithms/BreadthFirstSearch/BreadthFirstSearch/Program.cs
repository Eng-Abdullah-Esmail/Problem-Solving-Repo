using System;
using System.Collections.Generic;

public class Graph
{
    private int vertices; // Number of vertices
    private List<int>[] adjacencyList; // Adjacency list representation

    public Graph(int v)
    {
        vertices = v;
        adjacencyList = new List<int>[v];
        for (int i = 0; i < v; i++)
        {
            adjacencyList[i] = new List<int>();
        }
    }

    public void AddEdge(int v, int w)
    {
        adjacencyList[v].Add(w);
    }

    public void BFS(int startVertex)
    {
        bool[] visited = new bool[vertices];
        Queue<int> queue = new Queue<int>();

        visited[startVertex] = true;
        queue.Enqueue(startVertex);

        while (queue.Count != 0)
        {
            int currentVertex = queue.Dequeue();
            Console.Write(currentVertex + " ");

            foreach (int adjacentVertex in adjacencyList[currentVertex])
            {
                if (!visited[adjacentVertex])
                {
                    visited[adjacentVertex] = true;
                    queue.Enqueue(adjacentVertex);
                }
            }
        }
    }
}

public class Program
{
    public static void Main()
    {
        Graph graph = new Graph(5);
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(1, 4);

        Console.WriteLine("Breadth-First Traversal (starting from vertex 0):");
        graph.BFS(0);

        Console.ReadKey();

    }
}
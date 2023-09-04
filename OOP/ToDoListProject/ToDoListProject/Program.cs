using System;
using System.Collections.Generic;

namespace ToDoListProject
{
    class TodoList
    {
        private List<string> tasks;

        public TodoList()
        {
            tasks = new List<string>();
        }

        public void AddTask(string task)
        {
            tasks.Add(task);
            Console.WriteLine("Task added: {0}", task);
        }

        public void EditTask(int index, string newTask)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks[index] = newTask;
                Console.WriteLine("Task edited: {0}", newTask);
            }
            else
            {
                Console.WriteLine("Invalid task index.");
            }
        }

        public void DeleteTask(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                string task = tasks[index];
                tasks.RemoveAt(index);
                Console.WriteLine("Task deleted: {0}", task);
            }
            else
            {
                Console.WriteLine("Invalid task index.");
            }
        }

        public void PrintTasks()
        {
            Console.WriteLine("Todo List:");
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks.");
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine("{0}. {1}", i + 1, tasks[i]);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TodoList todoList = new TodoList();

            while (true)
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Add a task");
                Console.WriteLine("2. Edit a task");
                Console.WriteLine("3. Delete a task");
                Console.WriteLine("4. Print tasks");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Enter the task to add: ");
                        string task = Console.ReadLine();
                        todoList.AddTask(task);
                        break;
                    case "2":
                        Console.Write("Enter the index of the task to edit: ");
                        int index = int.Parse(Console.ReadLine()) - 1;
                        Console.Write("Enter the new task: ");
                        string newTask = Console.ReadLine();
                        todoList.EditTask(index, newTask);
                        break;
                    case "3":
                        Console.Write("Enter the index of the task to delete: ");
                        index = int.Parse(Console.ReadLine()) - 1;
                        todoList.DeleteTask(index);
                        break;
                    case "4":
                        todoList.PrintTasks();
                        break;
                    case "5":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
               
            }

           // Console.ReadKey();

        }
        
    }
}

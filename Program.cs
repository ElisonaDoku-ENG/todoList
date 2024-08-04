using System;
using System.Collections.Generic;

class Program
{
    static List<string> todos = new List<string>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Hello1");
            Console.WriteLine("[S]ee all to do's");
            Console.WriteLine("[A]dd a todo");
            Console.WriteLine("[R]emove a todo");
            Console.WriteLine("[E]xit");

            string input = Console.ReadLine();
            char userInput = string.IsNullOrEmpty(input) ? '\0' : input[0];

            switch (userInput)
            {
                case 's':
                case 'S':
                    SeeAllTodos();
                    break;
                case 'a':
                case 'A':
                    AddTodo();
                    break;
                case 'r':
                case 'R':
                    RemoveTodo();
                    break;
                case 'e':
                case 'E':
                    Console.WriteLine("Exiting the application.");
                    return;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void SeeAllTodos()
    {
        if (todos.Count == 0)
        {
            Console.WriteLine("No TODOs have been added yet.");
        }
        else
        {
            for (int i = 0; i < todos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {todos[i]}");
            }
        }
    }

    static void AddTodo()
    {
        Console.WriteLine("Enter a new TODO:");
        string newTodo = Console.ReadLine();
        if (!string.IsNullOrEmpty(newTodo))
        {
            todos.Add(newTodo);
            Console.WriteLine("TODO added.");
        }
        else
        {
            Console.WriteLine("Invalid TODO. Nothing was added.");
        }
    }

    static void RemoveTodo()
    {
        SeeAllTodos();
        if (todos.Count > 0)
        {
            Console.WriteLine("Enter the number of the TODO to remove:");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= todos.Count)
            {
                todos.RemoveAt(index - 1);
                Console.WriteLine("TODO removed.");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }
    }
}

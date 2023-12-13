using System;
using System.Collections.Generic;

namespace git_exercise
{
    internal class Program
    {
        class TodoItem
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public enum Status { Ready, Active, Done }

            public TodoItem(string title, string description)
            {
                Title = title;
                Description = description;
            }

            public Status ItemStatus { get; set; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Worldie!");
            Console.WriteLine("Error TODO");

            List<TodoItem> taskList = new List<TodoItem>();

            while (true)
            {
                Console.WriteLine("Please choose an action:");
                Console.WriteLine("1. Add a new task");
                Console.WriteLine("2. List all tasks");
                Console.WriteLine("3. Mark a task as done");
                Console.WriteLine("4. Create a new task list");
                Console.WriteLine("5. Show help");
                Console.WriteLine("6. Quit");

                Console.WriteLine("Enter your choice:");
                string input = Console.ReadLine();

                Console.Clear(); // Rensa konsolen för en renare användargränssnitt

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Adding a new task...");
                        Console.Beep(); // Spela upp ett beep för att indikera handlingen
                        Console.WriteLine("Enter task title:");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter task description:");
                        string description = Console.ReadLine();
                        taskList.Add(new TodoItem(title, description));
                        Console.WriteLine("Task added!");
                        Console.Beep(); // Ett beep för att indikera att uppgiften har lagts till
                        break;
                    case "2":
                        Console.WriteLine("Listing all tasks...");
                        Console.Beep(); // Beep för att indikera handlingen
                        if (taskList.Count == 0)
                        {
                            Console.WriteLine("No tasks found.");
                        }
                        else
                        {
                            foreach (TodoItem item in taskList)
                            {
                                Console.WriteLine($"Title: {item.Title}, Description: {item.Description}, Status: {item.ItemStatus}");
                            }
                        }
                        Console.Beep(); // Ett beep för att indikera att listningen är klar
                        break;
                    case "3":
                        Console.WriteLine("Marking a task as done...");
                        Console.Beep(); // Beep för att indikera handlingen
                        Console.WriteLine("Enter task title to mark as done:");
                        string taskTitle = Console.ReadLine();
                        foreach (TodoItem item in taskList)
                        {
                            if (item.Title == taskTitle)
                            {
                                item.ItemStatus = TodoItem.Status.Done;
                                Console.WriteLine($"Task '{item.Title}' marked as done.");
                                Console.Beep(); // Ett beep för att indikera att uppgiften är markerad som klar
                                break;
                            }
                        }
                        break;
                    case "4":
                        Console.WriteLine("Creating a new task list...");
                        Console.Beep(); // Beep för att indikera handlingen
                        taskList = new List<TodoItem>();
                        Console.WriteLine("New task list created.");
                        Console.Beep(); // Ett beep för att indikera att en ny uppgiftslista har skapats
                        break;
                    case "5":
                        Console.WriteLine("Showing help...");
                        Console.Beep(); // Beep för att indikera handlingen
                        Console.WriteLine("Available commands:");
                        Console.WriteLine("1. Add - Add a new task");
                        Console.WriteLine("2. List - List all tasks");
                        Console.WriteLine("3. Done - Mark a task as done");
                        Console.WriteLine("4. New - Create a new task list");
                        Console.WriteLine("5. Help - Show available commands");
                        Console.WriteLine("6. Quit - Exit the program");
                        Console.Beep(); // Ett beep för att indikera att hjälpen visas
                        break;
                    case "6":
                        Console.WriteLine("Quitting...");
                        Console.Beep(300, 500); // Beep för att indikera avslutning
                        Environment.Exit(0); // Avsluta programmet
                        break;
                    default:
                        Console.WriteLine("Unknown command. Please enter a valid option.");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear(); // Rensa konsolen för att förbereda nästa iteration av loopen
            }
        }
    }
}

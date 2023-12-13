using System.Threading.Channels;

namespace git_exercise
{
    internal class Program
    {
        List<TodoItem> taskList;
        class TodoItem
        {
            public string Title { get; set; }
            public string Description { get; set; }
            enum Status { Ready, Active, Done }
            public TodoItem(string title, string description)
            {
                Title = title;
                Description = description;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Worldie!");
            Console.WriteLine("Error TODO");

            while (true)
            {
                Console.WriteLine("Bash!");
                string input = Console.ReadLine();
            }
        }
        // None of this is real code, just a test...
    }
}

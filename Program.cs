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
        }
    }
}

using System.Threading.Channels;

namespace git_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Worldie!");
            
        for (int gitLoop = 1; gitLoop <= 10; gitLoop++)            
            Console.WriteLine("-> " + gitLoop);           
        }
    }
}

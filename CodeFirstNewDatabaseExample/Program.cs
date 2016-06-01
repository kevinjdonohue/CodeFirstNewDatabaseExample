using System;

namespace CodeFirstNewDatabaseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a name for a new blog:");
            string blogName = Console.ReadLine();

            Save save = new Save();
            save.CreateNewBlog(blogName);

            Read read = new Read();
            read.ListAllBlogs();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

using System;
using System.Linq;

namespace CodeFirstNewDatabaseExample
{
    public class Read
    {
        public void ListAllBlogs()
        {
            using (BloggingContext db = new BloggingContext())
            {
                db.Blogs.Select(b => b).OrderBy(b => b.Name).ToList().ForEach(b => Console.WriteLine(b.Name));
            }
        }
    }
}

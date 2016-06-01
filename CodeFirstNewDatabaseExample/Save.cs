using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeFirstNewDatabaseExample
{
    public class Save
    {
        public void CreateNewBlog(string blogName)
        {
            using (BlogContext db = new BlogContext())
            {
                Blog newBlog = new Blog() { Name = blogName };

                db.Blogs.Add(newBlog);

                db.SaveChanges();

                List<Blog> retrievedBlogs = db.Blogs.Select(b => b).OrderBy(b => b.Name).ToList();

                retrievedBlogs.ForEach(b => Console.WriteLine(b.Name));
            }
        }
    }
}

namespace CodeFirstNewDatabaseExample
{
    public class Save
    {
        public void CreateNewBlog(string blogName)
        {
            using (BloggingContext db = new BloggingContext())
            {
                Blog newBlog = new Blog() { Name = blogName };

                db.Blogs.Add(newBlog);

                db.SaveChanges();
            }
        }
    }
}

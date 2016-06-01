namespace CodeFirstNewDatabaseExample.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }

        //Navigation Properties
        //EF feature - lazy loading
        public virtual Blog Blog { get; set; }
    }
}
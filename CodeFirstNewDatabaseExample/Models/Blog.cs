﻿using CodeFirstNewDatabaseExample.Models;
using System.Collections.Generic;

namespace CodeFirstNewDatabaseExample
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        //Navigation Properties
        //EF feature - lazy loading
        public virtual List<Post> Posts { get; set; }
    }
}
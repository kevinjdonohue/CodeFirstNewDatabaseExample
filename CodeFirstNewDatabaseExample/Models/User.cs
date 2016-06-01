using System.ComponentModel.DataAnnotations;

namespace CodeFirstNewDatabaseExample
{
    public class User
    {
        [Key]
        public string UserName { get; set; }
        public string DisplayName { get; set; }
    }
}

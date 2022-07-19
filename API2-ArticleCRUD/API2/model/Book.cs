using System.ComponentModel.DataAnnotations;

namespace API2.model
{
    public class Book
    {
        [Key]
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }
}

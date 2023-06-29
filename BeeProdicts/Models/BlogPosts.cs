using System.ComponentModel.DataAnnotations;

namespace BeeProdicts.Models
{
    public class BlogPosts
    {
        [Key]
        public int Id { get; set; }
        public DateTime TimeOfPost { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string BlogImage { get; set; }

    }
}

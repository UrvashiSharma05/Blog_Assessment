using System.ComponentModel.DataAnnotations;

namespace Blog_Assessment.Models
{
    public class BlogPosts
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Content { get; set; }
        public string? DateCreated { get; set; }
        public string? DateModified { get; set; }
    }
}

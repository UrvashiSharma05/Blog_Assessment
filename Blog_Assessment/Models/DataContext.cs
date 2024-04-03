using Microsoft.EntityFrameworkCore;

namespace Blog_Assessment.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<BlogPosts>? blogPosts { get; set; }
    }
}
  
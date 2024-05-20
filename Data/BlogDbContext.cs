using Microsoft.EntityFrameworkCore;
using EntityFrameworkHerhaling.Models;

namespace EntityFrameworkHerhaling.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options):
            base(options)
        { }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}

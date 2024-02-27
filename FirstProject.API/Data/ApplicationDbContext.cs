using FirstProject.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace FirstProject.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
       public DbSet<BlogPost> blogPosts { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}

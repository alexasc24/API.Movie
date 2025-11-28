using API.Movies.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Movies.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Models.Movie> Movies { get; set; }
    }
}

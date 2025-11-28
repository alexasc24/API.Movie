using API.Movie.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Movie.DAL
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

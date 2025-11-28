using API.Movie.DAL;
using API.Movie.DAL.Models;
using API.Movie.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace API.Movie.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _context;
        public MovieRepository(ApplicationDbContext context)
        {
            _context = context; 
        }
        public async Task<bool> CreateMovieAsync(DAL.Models.Movie movie)
        {
            movie.CreatedDate = DateTime.UtcNow;
            await _context.Movies.AddAsync(movie);
            return await SaveAsync();
        }

        public async Task<bool> DeleteMovieAsync(int id)
        {
            var movie = await GetMovieAsync(id);
            if (movie == null)
            {
                return false;
            }
            _context.Movies.Remove(movie);
            return await SaveAsync();
        }

        public async Task<DAL.Models.Movie> GetMovieAsync(int id)
        {
            return await _context.Movies
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<ICollection<DAL.Models.Movie>> GetMoviesAsync()
        {
            return await _context.Movies
                .AsNoTracking()
                .OrderBy(m => m.Name)
                .ToListAsync();
        }

        public async Task<bool> UpdateMovieAsync(DAL.Models.Movie movie)
        {
            movie.ModifiedDate = DateTime.UtcNow;
            _context.Movies.Update(movie);
            return await SaveAsync();
        }
        private async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() >= 0 ? true : false;
        }
    }
}

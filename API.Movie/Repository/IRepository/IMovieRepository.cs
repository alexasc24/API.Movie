using API.Movies.DAL.Models;
using API.Movies.DAL.Models.Dtos;

namespace API.Movies.Repository.IRepository
{
    public interface IMovieRepository
    {
        Task<ICollection<Movie>> GetMoviesAsync();

        Task<Movie> GetMovieAsync(int id);
        Task<bool> MovieExistsByIdAsync(int id);

        Task<bool> MovieExistsByNameAsync(string name);

        Task<bool> CreateMovieAsync(Movie movie);

        Task<bool> UpdateMovieAsync(Movie movie);

        Task<bool> DeleteMovieAsync(int id);
    }
}

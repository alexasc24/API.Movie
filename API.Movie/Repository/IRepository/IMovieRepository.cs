using API.Movie.DAL.Models;

namespace API.Movie.Repository.IRepository
{
    public interface IMovieRepository
    {
        Task<ICollection<DAL.Models.Movie>> GetMoviesAsync();

        Task<DAL.Models.Movie> GetMovieAsync(int id);

        Task<bool> CreateMovieAsync(DAL.Models.Movie movie);

        Task<bool> UpdateMovieAsync(DAL.Models.Movie movie);

        Task<bool> DeleteMovieAsync(int id);
    }
}

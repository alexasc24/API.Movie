using API.Movie.DAL.Models;
using API.Movie.DAL.Models.Dtos;

namespace API.Movie.Services.IServices
{
    public interface ICategoryService
    {
        Task<ICollection<CategoryDto>> GetCategoriesAsync();
        Task<CategoryDto> GetCategoryAsync(int id);

        Task<bool> CategoryExistsByIdAsync(int id);

        Task<bool> CategoryExistsByNameAsync(string name);

        Task<bool> CreateCategoryAsync(Category catergory);

        Task<bool> UpdateCategoryAsync(Category category);

        Task<bool> DeleteCategoryAsync(int id);
    }
}

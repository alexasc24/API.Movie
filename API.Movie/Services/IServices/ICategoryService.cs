using API.Movie.DAL.Models;
using API.Movie.DAL.Models.Dtos;

namespace API.Movie.Services.IServices
{
    public interface ICategoryService
    {
        Task<ICollection<CategoryDto>> GetCategoriesAsync();
        Task<CategoryDto> GetCategoryAsync(int id);

        Task<CategoryDto> CreateCategoryAsync(CategoryCreateDto catergoryDto);

        Task<CategoryDto> UpdateCategoryAsync(int id, Category categoryDto);

        Task<bool> CategoryExistsByIdAsync(int id);

        Task<bool> CategoryExistsByNameAsync(string name);

        Task<bool> DeleteCategoryAsync(int id);

    }
}

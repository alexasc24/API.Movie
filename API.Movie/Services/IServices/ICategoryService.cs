using API.Movie.DAL.Models;
using API.Movie.DAL.Models.Dtos;

namespace API.Movie.Services.IServices
{
    public interface ICategoryService
    {
        Task<ICollection<CategoryDto>> GetCategoriesAsync();
        Task<CategoryDto> GetCategoryAsync(int id);

        Task<CategoryDto> CreateCategoryAsync(CategoryCreateUpdateDto catergoryDto);

        Task<CategoryDto> UpdateCategoryAsync(CategoryCreateUpdateDto dto, int id);

        Task<bool> CategoryExistsByIdAsync(int id);

        Task<bool> CategoryExistsByNameAsync(string name);

        Task<bool> DeleteCategoryAsync(int id);

    }
}

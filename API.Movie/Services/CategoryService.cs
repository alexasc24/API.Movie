using API.Movie.DAL.Models;
using API.Movie.DAL.Models.Dtos;
using API.Movie.Repository.IRepository;
using API.Movie.Services.IServices;
using AutoMapper;

namespace API.Movie.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper) 
        { 
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public Task<bool> CategoryExistsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public  Task<bool> CategoryExistsByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<CategoryDto> CreateCategoryAsync(CategoryCreateUpdateDto categoryCreateDto)
        {
            var categoryExists = await _categoryRepository.CategoryExistsByNameAsync(categoryCreateDto.Name);

            if (categoryExists) 
            {
                throw new InvalidOperationException($"Ya existe una categría con el nombre de '{categoryCreateDto.Name}'");
            }
            var category = _mapper.Map<Category>(categoryCreateDto);

            var categoryCreated = await _categoryRepository.CreateCategoryAsync(category);

            if (!categoryCreated) 
            {
                throw new Exception("Ocurrió un error al crear la categoría.");
            }

            return _mapper.Map<CategoryDto>(category);
        }

        public  async Task<bool> DeleteCategoryAsync(int id)
        {
            var categoryExists = await _categoryRepository.GetCategoryAsync(id);
            if(categoryExists == null)
            {
                throw new InvalidOperationException($"No se encontró la categoría con ID: '{id}'");
            }
            var categoryDeleted = await _categoryRepository.DeleteCategoryAsync(id);
            if (!categoryDeleted)
            {
                throw new Exception("Ocurrió un error al eliminar la categorpia.");
            }
            return categoryDeleted;

        }

        public async Task<ICollection<CategoryDto>> GetCategoriesAsync()
        {
            var categories = await _categoryRepository.GetCategoriesAsync();
            return _mapper.Map<ICollection<CategoryDto>>(categories);
            
        }

        public async Task<CategoryDto> GetCategoryAsync(int id)
        {
            var category = await _categoryRepository.GetCategoryAsync(id);

            if (category == null)
            {
                throw new InvalidOperationException($"No se encontró la categoría con ID: '{id}'");
            }

            return _mapper.Map<CategoryDto>(category);

        }

        public async Task<CategoryDto> UpdateCategoryAsync(CategoryCreateUpdateDto dto, int id)
        {
            var categoryExists = await _categoryRepository.GetCategoryAsync(id);

            if (categoryExists == null)
            {
                throw new InvalidOperationException($"No se encontró la categoría con ID: '{id}'");
            }

            var nameExistes = await _categoryRepository.CategoryExistsByNameAsync(dto.Name);

            if (nameExistes) 
            {
                throw new InvalidOperationException($"Ya existe una categoría con el nombre de '{dto.Name}'");
            }

            _mapper.Map(dto, categoryExists);

            var categoryUpdated = await _categoryRepository.UpdateCategoryAsync(categoryExists);

            if (!categoryUpdated)
            {
                throw new Exception("Ocurrió un error al actualizar la categoría");

            }

            return _mapper.Map<CategoryDto>(categoryExists);
            
        }
    }
}


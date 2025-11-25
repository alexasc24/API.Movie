using API.Movie.DAL.Models;
using API.Movie.DAL.Models.Dtos;
using AutoMapper;

namespace API.Movie.MoviesMapper
{
    public class Mappers : Profile
    {
        public Mappers() 
        { 
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryCreateDto>().ReverseMap();
        }
    }
}

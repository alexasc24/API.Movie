using System.ComponentModel.DataAnnotations;

namespace API.Movie.DAL.Models.Dtos
{
    public class CategoryCreateUpdateDto
    {
        [Required(ErrorMessage = "El nombre de la catogría es obligatorio")]
        [MaxLength(100, ErrorMessage = "El número máximo de caracteres es de 100.")]
        public string Name { get; set; }

    }
}

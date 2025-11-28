

using System.ComponentModel.DataAnnotations;

namespace API.Movies.DAL.Models.Dtos
{
    public class MovieCreateDto
    {
        [Required(ErrorMessage = "El nombre de la película es obligatorio")]
        [MaxLength(100, ErrorMessage = "El número máximo de caracteres es de 100")]
        public string Name { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace API.Movies.DAL.Models.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre de la película es obligatorio")]
        [MaxLength(100, ErrorMessage = "El número máximo de caracteres es de 100")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }

        [Required(ErrorMessage = "La clasificación de la película es obligatoria")]
        [MaxLength(100, ErrorMessage = "El número máximo de caracteres es de 100")]
        public string Clasification { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}

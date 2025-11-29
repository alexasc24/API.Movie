using System.ComponentModel.DataAnnotations;

namespace API.Movies.DAL.Models
{
    public class Movie : AuditBase
    {
        [Required]
        [Display(Name = "Nombre de la película")]
        public string Name { get; set; }

        [Display(Name = "Descripción de la película")]
        public string? Description { get; set; }

        [Required]
        [Display(Name = "Duración de la película")]
        public int Duration { get; set; }

        [Required]
        [Display(Name = "Clasificación de la película")]
        public int Clasification { get; set; }
    }
}

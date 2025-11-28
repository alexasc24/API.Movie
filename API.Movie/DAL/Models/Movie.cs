using System.ComponentModel.DataAnnotations;

namespace API.Movie.DAL.Models
{
    public class Movie : AuditBase
    {
        [Required]
        [Display(Name = "Nombre de la película")]
        public string Name { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace API.Movie.DAL.Models
{
    public class Category : AuditBase
    {
        [Required]
        [Display(Name="Nombre de la Categoría")]
        public string Name { get; set; }
    }
}

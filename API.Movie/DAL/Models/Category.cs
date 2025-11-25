using System.ComponentModel.DataAnnotations;

namespace API.Movie.DAL.Models
{
    public class Category : AuditBase
    {
        [Required]
        public string Name { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace mvcProyect.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; } = string.Empty;

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        // Puedes añadir más campos (Email, Roles, CreatedAt...) según necesites
    }
}
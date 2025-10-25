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

        // Puedes a�adir m�s campos (Email, Roles, CreatedAt...) seg�n necesites
    }
}
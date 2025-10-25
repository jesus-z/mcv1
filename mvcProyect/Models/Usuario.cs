using System;
using System.ComponentModel.DataAnnotations;

namespace mvcProyect.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "el correo electronico es obligatorio")]
        [EmailAddress(ErrorMessage = "debe ingresar un correo electrónico valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "la contraseña es obligatoria")]
        [DataType(DataType.Password)]
        public string Contraseña { get; set; }

        [Required(ErrorMessage = "el nombre completo es obligatorio")]
        [Display(Name = "nombre completo")]
        public string NombreCompleto { get; set; }

        [Required(ErrorMessage = "la fecha de nacimiento es obligatoria")]
        [DataType(DataType.Date)]
        [Display(Name = "fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "el rol es obligatorio")]
        public string Rol { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "fecha de registro")]
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        [Display(Name = "activo")]
        public bool Activo { get; set; } = true;
    }
}

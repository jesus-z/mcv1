using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mvcProyect.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }

        [Display(Name = "Nombre completo")]
        [Required(ErrorMessage = "Debe ingresar el nombre completo")]
        [MinLength(5, ErrorMessage = "El nombre debe tener al menos 5 caracteres")]
        [MaxLength(80, ErrorMessage = "El nombre no puede superar los 80 caracteres")]
        public string NombreCompleto { get; set; }

        [Display(Name = "Tel�fono de contacto")]
        [Phone(ErrorMessage = "Debe ingresar un n�mero de tel�fono v�lido")]
        [StringLength(15, ErrorMessage = "El tel�fono no puede tener m�s de 15 d�gitos")]
        public string Telefono { get; set; }

        [Display(Name = "Fecha de registro")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Debe especificar la fecha de registro")]
        public DateTime FechaRegistro { get; set; }

        [Display(Name = "Ciudad de residencia")]
        [StringLength(50, ErrorMessage = "La ciudad no puede superar los 50 caracteres")]
        public string Ciudad { get; set; }

        [Display(Name = "Activo")]
        public bool Activo { get; set; }

        public ICollection<PedidoModel>? Pedidos { get; set; }
    }
}

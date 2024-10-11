using System.ComponentModel.DataAnnotations;

namespace Supermarket_mvp.Models
{
    internal class CustomersModel
    {
        [Key]
        public int Customer_Id { get; set; } // Identificador del cliente

        [Required]
        [StringLength(50)]
        public string Document_Number { get; set; } // Número de documento

        [Required]
        [StringLength(50)]
        public string First_Name { get; set; } // Primer nombre

        [Required]
        [StringLength(50)]
        public string Last_Name { get; set; } // Apellido

        [Required]
        [StringLength(100)]
        public string Address { get; set; } // Dirección

        [Required]
        [StringLength(10)]
        public string Birth_Day { get; set; } // Fecha de nacimiento (almacenada como string)

        [Required]
        [StringLength(15)]
        public string Phone_Number { get; set; } // Número de teléfono

        [Required]
        [StringLength(100)]
        public string Email { get; set; } // Correo electrónico
    }
}

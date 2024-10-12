using System.ComponentModel.DataAnnotations;

namespace Supermarket_mvp.Models
{
    internal class CustomersModel
    {
        [Key]
        public int Customer_Id { get; set; }  // Identificador del cliente

        [Required(ErrorMessage = "Document number es requerido.")]
        [StringLength(50, ErrorMessage = "Document number debe tener un máximo de 50 caracteres.")]
        public string Document_Number { get; set; }  // Número de documento

        [Required(ErrorMessage = "First name es requerido.")]
        [StringLength(50, ErrorMessage = "First name debe tener un máximo de 50 caracteres.")]
        public string First_Name { get; set; }  // Primer nombre

        [Required(ErrorMessage = "Last name es requerido.")]
        [StringLength(50, ErrorMessage = "Last name debe tener un máximo de 50 caracteres.")]
        public string Last_Name { get; set; }  // Apellido

        [Required(ErrorMessage = "Address es requerido.")]
        [StringLength(100, ErrorMessage = "Address debe tener un máximo de 100 caracteres.")]
        public string Address { get; set; }  // Dirección

        [Required(ErrorMessage = "Birth day es requerido.")]
        [StringLength(10, ErrorMessage = "Birth day debe tener un máximo de 10 caracteres.")]
        public string Birth_Day { get; set; }  // Fecha de nacimiento (almacenada como cadena)

        [Required(ErrorMessage = "Phone number es requerido.")]
        [StringLength(15, ErrorMessage = "Phone number debe tener un máximo de 15 caracteres.")]
        public string Phone_Number { get; set; }  // Número de teléfono

        [Required(ErrorMessage = "Email es requerido.")]
        [StringLength(100, ErrorMessage = "Email debe tener un máximo de 100 caracteres.")]
        public string Email { get; set; }  // Correo electrónico
    }
}

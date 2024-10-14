using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class CustomersModel
    {
        [Key]
        [DisplayName("ID del Cliente")]
        public int Customer_Id { get; set; }  

        [Required(ErrorMessage = "El número de documento es requerido.")]
        [StringLength(50, ErrorMessage = "El número de documento debe tener un máximo de 50 caracteres.")]
        [DisplayName("Número de Documento")]
        public string Document_Number { get; set; }  

        [Required(ErrorMessage = "El primer nombre es requerido.")]
        [StringLength(50, ErrorMessage = "El primer nombre debe tener un máximo de 50 caracteres.")]
        [DisplayName("Primer Nombre")]
        public string First_Name { get; set; }  

        [Required(ErrorMessage = "El apellido es requerido.")]
        [StringLength(50, ErrorMessage = "El apellido debe tener un máximo de 50 caracteres.")]
        [DisplayName("Apellido")]
        public string Last_Name { get; set; }  

        [Required(ErrorMessage = "La dirección es requerida.")]
        [StringLength(100, ErrorMessage = "La dirección debe tener un máximo de 100 caracteres.")]
        [DisplayName("Dirección")]
        public string Address { get; set; }  

        [Required(ErrorMessage = "La fecha de nacimiento es requerida.")]
        [StringLength(10, ErrorMessage = "La fecha de nacimiento debe tener un máximo de 10 caracteres.")]
        [DisplayName("Fecha de Nacimiento")]
        public string Birth_Day { get; set; } 

        [Required(ErrorMessage = "El número de teléfono es requerido.")]
        [StringLength(15, ErrorMessage = "El número de teléfono debe tener un máximo de 15 caracteres.")]
        [DisplayName("Número de Teléfono")]
        public string Phone_Number { get; set; } 

        [Required(ErrorMessage = "El correo electrónico es requerido.")]
        [StringLength(100, ErrorMessage = "El correo electrónico debe tener un máximo de 100 caracteres.")]
        [DisplayName("Correo Electrónico")]
        public string Email { get; set; }  
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    public class ProductModel
    {
        [Key]
        [DisplayName("ID del Producto")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "El nombre del producto es requerido.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre del producto debe tener entre 3 y 100 caracteres.")]
        [DisplayName("Nombre del Producto")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "El precio del producto es requerido.")]
        [Range(1, 999999.99, ErrorMessage = "El precio del producto debe estar entre 1 y 999999.99.")]
        [DisplayName("Precio del Producto")]
        public decimal ProductPrice { get; set; }

        [Required(ErrorMessage = "La cantidad en stock es requerida.")]
        [Range(1, 10000, ErrorMessage = "El stock debe estar entre 1 y 10000 unidades.")]
        [DisplayName("Stock del Producto")]
        public int ProductStock { get; set; }

        [Required(ErrorMessage = "El ID de la categoría es requerido.")]
        [Range(0, 100, ErrorMessage = "El ID de la categoría debe estar entre 0 y 100.")]
        [DisplayName("Category Id")]
        public int CategoryId { get; set; }
    }
}

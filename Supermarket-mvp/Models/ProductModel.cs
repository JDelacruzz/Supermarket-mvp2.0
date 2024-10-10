using System.ComponentModel.DataAnnotations;

namespace Supermarket_mvp.Models
{
    public class ProductModel
    {
        [Key]
        public int Product_Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Product_Name { get; set; }

        [Required]
        [Range(0.01, 999999.99)]
        public decimal Product_Price { get; set; }

        [Required]
        [Range(1, 10000)]
        public int Product_Stock { get; set; }

        [Required]
        public int Category_Id { get; set; }
        public int Id { get; internal set; }
        public string? Name { get; internal set; }
    }
}

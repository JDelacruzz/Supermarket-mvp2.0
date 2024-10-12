using System.ComponentModel.DataAnnotations;

namespace Supermarket_mvp.Models
{
    internal class CustomersModel
    {
        [Key]
        public int Customer_Id { get; set; } 

        [Required]
        [StringLength(50)]
        public string Document_Number { get; set; } 

        [Required]
        [StringLength(50)]
        public string First_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Last_Name { get; set; } 

        [Required]
        [StringLength(100)]
        public string Address { get; set; } 

        [Required]
        [StringLength(10)]
        public string Birth_Day { get; set; }

        [Required]
        [StringLength(15)]
        public string Phone_Number { get; set; } 

        [Required]
        [StringLength(100)]
        public string Email { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class CategoriesModel
    {
        [DisplayName("Category Id")]
        public int Id { get; set; }

        [DisplayName("Category Name")]
        [Required(ErrorMessage = "Category name es requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Category name tiene que tener entre 3 y 50 caracteres")]
        public string Name { get; set; }

        [DisplayName("Description")]
        [Required(ErrorMessage = "Category description es requerido")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Category description tiene que tener entre 3 y 200 caracteres")]
        public string Description { get; set; }
    }
}

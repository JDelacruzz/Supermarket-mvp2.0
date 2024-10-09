using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class PayModeModel
    {
        [DisplayName("Pay mode Id")]
        public int Id { get; set; }
        [DisplayName("Pay Mode Name")]
        [Required(ErrorMessage = "Pay mode name es requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pay mode name tiene que tener entre 3 y 50 caracteres")]
        public string Name { get; set; }

        [DisplayName("Observation")]
        [Required(ErrorMessage = "Pay mode observation es requerido")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Pay mode observation tiene que tener entre 3 y 200 caracteres")]
        public string Observation { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Distritos
    {
        [Key]
        public int DistritoId { get; set; }
        [Required(ErrorMessage = "Debes de introducir un nombre para el distrito")]
        public string? CodigoRegional { get; set; }
        public string? NombreDistrital { get; set; }
        [Required(ErrorMessage = "Debes de introducir un codigo para el distrito")]
        public string? CodigoDistrito { get; set; }
    }
}

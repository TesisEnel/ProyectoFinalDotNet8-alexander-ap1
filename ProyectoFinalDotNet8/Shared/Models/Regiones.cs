using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Regiones
    {
        [Key]
        public int RegionId { get; set; }
        [Required(ErrorMessage = "Debes de introducir un nombre para la región")]
        public string? NombreRegion { get; set; }
        [Required(ErrorMessage = "Debes de introducir un codigo para la región")]
        public string? CodigoRegional { get; set; }
    }
}

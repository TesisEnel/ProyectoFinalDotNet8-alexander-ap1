using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Comidas
    {
        [Key]
        public int ComidaId { get; set; }
        [Required(ErrorMessage = "Debes de introducir una descripción a la comida")]
        public string? Descripcion { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Debes de eligir un tipo de comida")]
        public int TipoComidaId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class TiposComidas

    {
        [Key]
        public int TipoComidaId { get; set; }
        public string Tipo { get; set; }
    }
    //public enum TiposComidas
    //{
    //    Carbohidratos,
    //    Proteina,
    //    Grasas,
    //    otros
    //}
}

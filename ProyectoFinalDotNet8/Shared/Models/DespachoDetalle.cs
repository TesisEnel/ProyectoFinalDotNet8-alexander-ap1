using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class DespachoDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        public int DespachoId { get; set; }
        public int ComidaId { get; set; }
        public int CantidadDecomida { get; set; }
    }
}

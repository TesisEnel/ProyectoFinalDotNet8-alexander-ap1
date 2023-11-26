using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class MenuDetalles
    {
        [Key]
        public int DetalleId { get; set; }
        public int MenuId { get; set; }
        public int ComidaId { get; set; }
    }
}

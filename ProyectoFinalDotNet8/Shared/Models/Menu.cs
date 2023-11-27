using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }
        [Required(ErrorMessage = "El campo descripción es obligatorio")]
        public string? Descripcion { get; set; }
        [Required(ErrorMessage = "El campo descripción es obligatorio")]
        public string? DiaSemana { get; set; }
        public byte[]? Imagen { get; set; }  

        [ForeignKey("MenuId")]
        public ICollection<MenuDetalles> MenuDetalles { get; set; } = new List<MenuDetalles>();
        [ForeignKey("MenuId")]
        public ICollection<Comentarios> ComenentarioDetalle { get; set; } = new List<Comentarios>();


    }
}
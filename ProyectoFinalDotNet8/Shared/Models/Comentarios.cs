using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Comentarios
    {
        [Key]
        public int ComentarioId { get; set; }
        [Required(ErrorMessage = "Debes de escribir un comentario antes de enviar.")]
        public string? ComentarioTexto { get; set; }
        [Required(ErrorMessage = "Debes de escribir un nombre de usuario.")]
        public string? Usuario { get; set; }
        [Required]
        public string? UsuarioId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public int MenuId { get; set; }
        [Range(1, 5, ErrorMessage = "La nota debe de ser entre 1 y 5.")]
        public int Nota { get; set; }
    }
}

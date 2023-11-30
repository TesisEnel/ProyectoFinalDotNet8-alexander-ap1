using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class CentrosEducativos
    {
        [Key]
        public int CentroEducativoId { get; set; }
        [Required(ErrorMessage = "Debes de poner el nombre del Centro Educativo")]
        public string? Nombre { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad de estudiantes matriculados debe de ser mayor a 0")]
        public int CantidadMatricula { get; set; }
        public string? DirectorId { get; set; }
        [Required(ErrorMessage = "Debes de poner el código distrital del Centro Educativo")]
        public string? CodigoDistrital { get; set; }
        [Required(ErrorMessage = "Debes de poner el código regional del Centro Educativo")]
        public string? CodigoRegional { get; set; }
        [Required(ErrorMessage = "Debes de poner la dirección del Centro Educativo")]
        public string? Direccion { get; set; }
    }
}
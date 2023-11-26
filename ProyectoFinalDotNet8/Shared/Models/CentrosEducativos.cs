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
        [Required(ErrorMessage = "Debes de poner la cantidad de estudiantes matricualdos")]
        public int CantidadMatricula { get; set; }
        public string? CodigoDistrital { get; set; }
        public string? CodigoRegional { get; set; }
        [Required(ErrorMessage = "Debes de poner la dirección del Centro Educativo")]
        public string? Direccion { get; set; }
        //creo que debo crear el codigo regional y distrital en OnMelCreating
    }
}
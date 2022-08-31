
using System;
using System.ComponentModel.DataAnnotations;
namespace TallerCofiable.Models
{
    public class personaModelo
    {
        public int IdPersona { get; set; }

        [Required(ErrorMessage = "El campo es oblogatorio")]
        public string? Identificacion { get; set; }
        [Required(ErrorMessage="El campo es oblogatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El campo es oblogatorio")]
        public string? Apellido { get; set; }
        [Required(ErrorMessage = "El campo es oblogatorio")]
        public string? anacimiento { get; set; }
        

    }
}



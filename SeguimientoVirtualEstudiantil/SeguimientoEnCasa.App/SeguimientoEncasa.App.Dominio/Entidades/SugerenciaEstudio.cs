using System;
using System.ComponentModel.DataAnnotations;

namespace SeguimientoEnCasa.App.Dominio
{
    public class SugerenciaEstudio
    {
        public int Id{get;set;}
        [Required (ErrorMessage = "Fecha es obligatoria")]
        public DateTime FechaHora{get;set;}
        [Required (ErrorMessage = "{0} es obligatorio")]
        public string Descripcion{get;set;}
        [Required]
        public Estado Estado{get;set;}
        
    }
}








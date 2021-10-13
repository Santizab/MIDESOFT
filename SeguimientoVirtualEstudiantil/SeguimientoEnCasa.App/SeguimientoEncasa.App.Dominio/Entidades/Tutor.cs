using System;
using System.ComponentModel.DataAnnotations;

namespace SeguimientoEnCasa.App.Dominio
{
    public class Tutor:Persona
    {
        [Required (ErrorMessage = "{0} es obligatorio"), MaxLength(30, ErrorMessage = "El {0} no puede ser mayor a {1} caracteres"),
            MinLength(3, ErrorMessage = "El {0} no puede ser menor a {1} caracteres"),DataType(DataType.Text)]
        public string TarjetaProfesional {get;set;}
        [Required]
        public int HorasLaborales {get;set;}
        
    }
}
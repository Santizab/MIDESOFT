using System;
using System.ComponentModel.DataAnnotations;

namespace SeguimientoEnCasa.App.Dominio
{
    public class Maestro:Persona
    {
        [Required (ErrorMessage = "{0} es obligatorio"), MaxLength(30, ErrorMessage = "El {0} no puede ser mayor a {1} caracteres"),
            MinLength(3, ErrorMessage = "El {0} no puede ser menor a {1} caracteres"),DataType(DataType.Text)]
        public string Asignatura {get;set;}
        [Required (ErrorMessage = "{0} es obligatorio"), MaxLength(30, ErrorMessage = "El {0} no puede ser mayor a {1} caracteres"),
            MinLength(3, ErrorMessage = "El {0} no puede ser menor a {1} caracteres"),DataType(DataType.Text)]
        public string Curso {get;set;}
        public string Registro{get;set;}
        


    }
}
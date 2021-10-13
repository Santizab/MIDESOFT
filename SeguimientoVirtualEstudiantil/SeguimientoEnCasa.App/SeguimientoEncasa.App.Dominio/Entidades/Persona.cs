using System;
using System.ComponentModel.DataAnnotations;

namespace SeguimientoEnCasa.App.Dominio
{

    public class Persona
    {
        public int Id {get;set;}
        [Required (ErrorMessage = "{0} es obligatorio"), MaxLength(30, ErrorMessage = "El {0} no puede ser mayor a {1} caracteres"),
            MinLength(3, ErrorMessage = "El {0} no puede ser menor a {1} caracteres"),DataType(DataType.Text)]
        public string Nombre {get;set;}
        [Required (ErrorMessage = "{0} es obligatorio"), MaxLength(30, ErrorMessage = "El {0} no puede ser mayor a {1} caracteres"),
            MinLength(3, ErrorMessage = "El {0} no puede ser menor a {1} caracteres"),DataType(DataType.Text)]
        public string Apellidos {get;set;}
        [Required (ErrorMessage = "{0} es obligatorio"), MaxLength(13, ErrorMessage = "El {0} no puede ser mayor a {1} caracteres"),
            MinLength(7, ErrorMessage = "El {0} no puede ser menor a {1} caracteres"),DataType(DataType.PhoneNumber )]
        public string NumeroTelefono {get;set;}
        [Required]
        public Genero Genero {get;set;}

    }
}






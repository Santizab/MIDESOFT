using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SeguimientoEnCasa.App.Dominio
{
    public class Estudiante:Persona
    {
        [Required (ErrorMessage = "{0} es obligatorio"), MaxLength(30, ErrorMessage = "El {0} no puede ser mayor a {1} caracteres"),
            MinLength(3, ErrorMessage = "El {0} no puede ser menor a {1} caracteres"),DataType(DataType.Text)]
        public string Direccion {get;set;}
        public float Latitud {get;set;}
        public float Longitud {get;set;}
        [Required (ErrorMessage = "{0} es obligatorio"), MaxLength(30, ErrorMessage = "El {0} no puede ser mayor a {1} caracteres"),
            MinLength(2, ErrorMessage = "El {0} no puede ser menor a {1} caracteres"),DataType(DataType.Text)]
        public string Ciudad {get;set;}
        [Required (ErrorMessage = "{0} es obligatorio")]
        public DateTime FechaDeNacimiento {get;set;}
        public List<Acudiente> AcudienteList{get;set;}
        public List<Tutor> TutorList{get;set;}
        public List<Maestro> MaestroList{get;set;}
        public List<Historico> HistoricoList{get;set;}
        
    }



}
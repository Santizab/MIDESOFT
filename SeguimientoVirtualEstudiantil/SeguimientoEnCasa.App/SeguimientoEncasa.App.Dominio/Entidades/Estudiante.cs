using System;

namespace SeguimientoEnCasa.App.Dominio
{
    public class Estudiante:Persona
    {
        public string Direccion {get;set;}
        public float Latitud {get;set;}
        public float Longitud {get;set;}
        public string Ciudad {get;set;}
        public DateTime FechaDeNacimiento {get;set;}
        public Acudiente Acudiente{get;set;}
        
        
    }



}
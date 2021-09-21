using System;

namespace SeguimientoEnCasa.App.Dominio
{
    public class Maestro:Persona
    {
        public string Asignatura {get;set;}
        public string curso {get;set;}
        public string Registro{get;set;}
        public SugerenciaEstudio SugerenciaEstudio {get;set;}
        public Estudiante Estudiante {get;set;}


    }
}
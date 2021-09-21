using System;

namespace SeguimientoEnCasa.App.Dominio
{
    public class SugerenciaEstudio
    {
        public DateTime FechaHora{get;set;}
        public string Descripcion{get;set;}
        public string Estado{get;set;}
        public Acudiente Acudiente {get;set;}
        public Tutor Tutor{get;set;}
        public Maestro Maestro{get;set;}
        public Estudiante Estudiante{get;set;}
    }
}








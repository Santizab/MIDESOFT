using System;

namespace SeguimientoEnCasa.App.Dominio
{
    public class Acudiente:Persona
    {
        public string Parentesco {get;set;}
        public string Correo {get;set;}
        public SugerenciaEstudio SugerenciaEstudio {get;set;}

    }

}
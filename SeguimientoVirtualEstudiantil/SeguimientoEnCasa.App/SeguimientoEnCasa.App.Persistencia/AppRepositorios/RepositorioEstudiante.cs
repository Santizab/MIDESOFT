using System.Collections.Generic;
using SeguimientoEnCasa.App.Dominio;
using System;
using SeguimientoEnCasa.App.Persistencia;
using System.Linq;


namespace SeguimientoEnCasa.App.Persistencia
{

    public class RepositorioEstudiante : IRepositorioEstudiante
    {
        private readonly SeguimientoEnCasa.App.Persistencia.AppContext _appContext=new AppContext();
        //public RepositorioEstudiante(SeguimientoEnCasa.App.Persistencia.AppContext appContext)
        //{
        //    _appContext=appContext;
        //}
        Estudiante IRepositorioEstudiante.AddEstudiante(Estudiante estudiante)
        {
            var estudianteAdicionado=_appContext.Estudiantes.Add(estudiante);
            _appContext.SaveChanges();
            return estudianteAdicionado.Entity;
        }

        Estudiante IRepositorioEstudiante.UpdateEstudiante(Estudiante estudiante)
        {
            var estudianteEncontrado=_appContext.Estudiantes.FirstOrDefault(p => p.Id ==estudiante.Id);
            if(estudianteEncontrado!=null)
            {
                 estudianteEncontrado.Nombre= estudiante.Nombre;
                 estudianteEncontrado.Apellidos= estudiante.Apellidos;
                 estudianteEncontrado.NumeroTelefono= estudiante.NumeroTelefono;
                 estudianteEncontrado.Genero= estudiante.Genero;
                 estudianteEncontrado.Direccion= estudiante.Direccion;
                 estudianteEncontrado.Latitud= estudiante.Latitud;
                 estudianteEncontrado.Longitud= estudiante.Longitud;
                 estudianteEncontrado.Ciudad= estudiante.Ciudad;
                 estudianteEncontrado.FechaDeNacimiento= estudiante.FechaDeNacimiento;
                 estudianteEncontrado.Acudiente= estudiante.Acudiente;
                 estudianteEncontrado.Tutor= estudiante.Tutor;
                 estudianteEncontrado.Maestro= estudiante.Maestro;
                 estudianteEncontrado.Historico= estudiante.Historico;

                 _appContext.SaveChanges();
            }
            return estudianteEncontrado;
        }

        void IRepositorioEstudiante.DeleteEstudiante(int IdEstudiante)
        {
            var estudianteEncontrado=_appContext.Estudiantes.FirstOrDefault(p => p.Id ==IdEstudiante);
            if(estudianteEncontrado==null)
            return;
            _appContext.Estudiantes.Remove(estudianteEncontrado);
            _appContext.SaveChanges();
        }

        Estudiante IRepositorioEstudiante.GetEstudiante(int IdEstudiante)
        {
            var estudianteEncontrado=_appContext.Estudiantes.FirstOrDefault(p => p.Id ==IdEstudiante);
            return estudianteEncontrado;
        }

        IEnumerable<Estudiante> IRepositorioEstudiante.GetAllEstudiantes()
        {
            return _appContext.Estudiantes;
        }
        
    }

}
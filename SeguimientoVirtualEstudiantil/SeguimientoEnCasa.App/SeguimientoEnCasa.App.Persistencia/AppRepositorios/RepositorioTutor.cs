using System.Collections.Generic;
using SeguimientoEnCasa.App.Dominio;
using System;
using SeguimientoEnCasa.App.Persistencia;
using System.Linq;


namespace SeguimientoEnCasa.App.Persistencia
{

    public class RepositorioTutor : IRepositorioTutor
    {
        private readonly SeguimientoEnCasa.App.Persistencia.AppContext _appContext;
        public RepositorioTutor(SeguimientoEnCasa.App.Persistencia.AppContext appContext)
        {
            _appContext=appContext;
        }
        Tutor IRepositorioTutor.AddTutor(Tutor tutor)
        {
            var tutorAdicionado=_appContext.Tutores.Add(tutor);
            _appContext.SaveChanges();
            return tutorAdicionado.Entity;
        }

        Tutor IRepositorioTutor.UpdateTutor(Tutor tutor)
        {
            var tutorEncontrado=_appContext.Tutores.FirstOrDefault(p => p.Id ==tutor.Id);
            if(tutorEncontrado!=null)
            {
                 tutorEncontrado.Nombre= tutor.Nombre;
                 tutorEncontrado.Apellidos= tutor.Apellidos;
                 tutorEncontrado.NumeroTelefono= tutor.NumeroTelefono;
                 tutorEncontrado.Genero= tutor.Genero;
                 tutorEncontrado.TarjetaProfesional= tutor.TarjetaProfesional;
                 tutorEncontrado.HorasLaborales= tutor.HorasLaborales;
                 
                 _appContext.SaveChanges();
            }
            return tutorEncontrado;
        }

        void IRepositorioTutor.DeleteTutor(int IdTutor)
        {
            var tutorEncontrado=_appContext.Tutores.FirstOrDefault(p => p.Id ==IdTutor);
            if(tutorEncontrado==null)
            return;
            _appContext.Tutores.Remove(tutorEncontrado);
            _appContext.SaveChanges();
        }

        Tutor IRepositorioTutor.GetTutor(int IdTutor)
        {
            var tutorEncontrado=_appContext.Tutores.FirstOrDefault(p => p.Id ==IdTutor);
            return tutorEncontrado;
        }

        IEnumerable<Tutor> IRepositorioTutor.GetAllTutores()
        {
            return _appContext.Tutores;
        }
        
    }

}
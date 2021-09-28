using System.Collections.Generic;
using SeguimientoEnCasa.App.Dominio;
using System;
using SeguimientoEnCasa.App.Persistencia;
using System.Linq;


namespace SeguimientoEnCasa.App.Persistencia
{

    public class RepositorioMaestro : IRepositorioMaestro
    {
        private readonly SeguimientoEnCasa.App.Persistencia.AppContext _appContext;
        public RepositorioMaestro(SeguimientoEnCasa.App.Persistencia.AppContext appContext)
        {
            _appContext=appContext;
        }
        Maestro IRepositorioMaestro.AddMaestro(Maestro maestro)
        {
            var maestroAdicionado=_appContext.Maestros.Add(maestro);
            _appContext.SaveChanges();
            return maestroAdicionado.Entity;
        }

        Maestro IRepositorioMaestro.UpdateMaestro(Maestro maestro)
        {
            var maestroEncontrado=_appContext.Maestros.FirstOrDefault(p => p.Id ==maestro.Id);
            if(maestroEncontrado!=null)
            {
                 maestroEncontrado.Nombre= maestro.Nombre;
                 maestroEncontrado.Apellidos= maestro.Apellidos;
                 maestroEncontrado.NumeroTelefono= maestro.NumeroTelefono;
                 maestroEncontrado.Genero= maestro.Genero;
                 maestroEncontrado.Asignatura= maestro.Asignatura;
                 maestroEncontrado.Curso= maestro.Curso;
                 maestroEncontrado.Registro= maestro.Registro;
                 

                 _appContext.SaveChanges();
            }
            return maestroEncontrado;
        }

        void IRepositorioMaestro.DeleteMaestro(int IdMaestro)
        {
            var maestroEncontrado=_appContext.Maestros.FirstOrDefault(p => p.Id ==IdMaestro);
            if(maestroEncontrado==null)
            return;
            _appContext.Maestros.Remove(maestroEncontrado);
            _appContext.SaveChanges();
        }

        Maestro IRepositorioMaestro.GetMaestro(int IdMaestro)
        {
            var maestroEncontrado=_appContext.Maestros.FirstOrDefault(p => p.Id ==IdMaestro);
            return maestroEncontrado;
        }

        IEnumerable<Maestro> IRepositorioMaestro.GetAllMaestros()
        {
            return _appContext.Maestros;
        }
        
    }

}
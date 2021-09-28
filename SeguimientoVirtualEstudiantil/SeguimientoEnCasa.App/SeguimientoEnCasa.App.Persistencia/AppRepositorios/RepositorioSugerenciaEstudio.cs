using System.Collections.Generic;
using SeguimientoEnCasa.App.Dominio;
using System;
using SeguimientoEnCasa.App.Persistencia;
using System.Linq;


namespace SeguimientoEnCasa.App.Persistencia
{

    public class RepositorioSugerenciaEstudio : IRepositorioSugerenciaEstudio
    {
        private readonly SeguimientoEnCasa.App.Persistencia.AppContext _appContext;
        public RepositorioSugerenciaEstudio(SeguimientoEnCasa.App.Persistencia.AppContext appContext)
        {
            _appContext=appContext;
        }
        SugerenciaEstudio IRepositorioSugerenciaEstudio.AddSugerenciaEstudio(SugerenciaEstudio sugerenciaEstudio)
        {
            var sugerenciaEstudioAdicionado=_appContext.SugerenciaEstudios.Add(sugerenciaEstudio);
            _appContext.SaveChanges();
            return sugerenciaEstudioAdicionado.Entity;
        }

        SugerenciaEstudio IRepositorioSugerenciaEstudio.UpdateSugerenciaEstudio(SugerenciaEstudio sugerenciaEstudio)
        {
            var sugerenciaEstudioEncontrado=_appContext.SugerenciaEstudios.FirstOrDefault(p => p.Id ==sugerenciaEstudio.Id);
            if(sugerenciaEstudioEncontrado!=null)
            {
                 sugerenciaEstudioEncontrado.FechaHora= sugerenciaEstudio.FechaHora;
                 sugerenciaEstudioEncontrado.Descripcion= sugerenciaEstudio.Descripcion;
                 sugerenciaEstudioEncontrado.Estado= sugerenciaEstudio.Estado;
                 

                 _appContext.SaveChanges();
            }
            return sugerenciaEstudioEncontrado;
        }

        void IRepositorioSugerenciaEstudio.DeleteSugerenciaEstudio(int IdSugerenciaEstudio)
        {
            var sugerenciaEstudioEncontrado=_appContext.SugerenciaEstudios.FirstOrDefault(p => p.Id ==IdSugerenciaEstudio);
            if(sugerenciaEstudioEncontrado==null)
            return;
            _appContext.SugerenciaEstudios.Remove(sugerenciaEstudioEncontrado);
            _appContext.SaveChanges();
        }

        SugerenciaEstudio IRepositorioSugerenciaEstudio.GetSugerenciaEstudio(int IdSugerenciaEstudio)
        {
            var sugerenciaEstudioEncontrado=_appContext.SugerenciaEstudios.FirstOrDefault(p => p.Id ==IdSugerenciaEstudio);
            return sugerenciaEstudioEncontrado;
        }

        IEnumerable<SugerenciaEstudio> IRepositorioSugerenciaEstudio.GetAllSugerenciaEstudios()
        {
            return _appContext.SugerenciaEstudios;
        }
        
    }

}
using System.Collections.Generic;
using SeguimientoEnCasa.App.Dominio;
using System;
using SeguimientoEnCasa.App.Persistencia;
using System.Linq;


namespace SeguimientoEnCasa.App.Persistencia
{

    public class RepositorioHistorico : IRepositorioHistorico
    {
        private readonly SeguimientoEnCasa.App.Persistencia.AppContext _appContext;
        public RepositorioHistorico(SeguimientoEnCasa.App.Persistencia.AppContext appContext)
        {
            _appContext=appContext;
        }
        Historico IRepositorioHistorico.AddHistorico(Historico historico)
        {
            var historicoAdicionado=_appContext.Historicos.Add(historico);
            _appContext.SaveChanges();
            return historicoAdicionado.Entity;
        }

        Historico IRepositorioHistorico.UpdateHistorico(Historico historico)
        {
            var historicoEncontrado=_appContext.Historicos.FirstOrDefault(p => p.Id ==historico.Id);
            if(historicoEncontrado!=null)
            {
                 
                 historicoEncontrado.SugerenciaEstudio= historico.SugerenciaEstudio;
                 

                 _appContext.SaveChanges();
            }
            return historicoEncontrado;
        }

        void IRepositorioHistorico.DeleteHistorico(int IdHistorico)
        {
            var historicoEncontrado=_appContext.Historicos.FirstOrDefault(p => p.Id ==IdHistorico);
            if(historicoEncontrado==null)
            return;
            _appContext.Historicos.Remove(historicoEncontrado);
            _appContext.SaveChanges();
        }

        Historico IRepositorioHistorico.GetHistorico(int IdHistorico)
        {
            var historicoEncontrado=_appContext.Historicos.FirstOrDefault(p => p.Id ==IdHistorico);
            return historicoEncontrado;
        }

        IEnumerable<Historico> IRepositorioHistorico.GetAllHistoricos()
        {
            return _appContext.Historicos;
        }
        
    }

}
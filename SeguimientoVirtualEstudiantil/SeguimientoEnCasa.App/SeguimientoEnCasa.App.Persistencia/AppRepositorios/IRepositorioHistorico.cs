using System.Collections.Generic;
using SeguimientoEnCasa.App.Dominio;
using System;
using SeguimientoEnCasa.App.Persistencia;
using System.Linq;

namespace SeguimientoEnCasa.App.Persistencia
{

    public interface IRepositorioHistorico
    {
       IEnumerable<Historico> GetAllHistoricos();
       Historico AddHistorico(Historico historico);
       Historico UpdateHistorico(Historico historico);
       void DeleteHistorico(int IdHistorico);
       Historico GetHistorico(int IdHistorico);

    }
    
}
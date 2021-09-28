using System.Collections.Generic;
using SeguimientoEnCasa.App.Dominio;
using System;
using SeguimientoEnCasa.App.Persistencia;
using System.Linq;

namespace SeguimientoEnCasa.App.Persistencia
{

    public interface IRepositorioSugerenciaEstudio
    {
       IEnumerable<SugerenciaEstudio> GetAllSugerenciaEstudios();
       SugerenciaEstudio AddSugerenciaEstudio(SugerenciaEstudio sugerenciaEstudio);
       SugerenciaEstudio UpdateSugerenciaEstudio(SugerenciaEstudio sugerenciaEstudio);
       void DeleteSugerenciaEstudio(int IdSugerenciaEstudio);
       SugerenciaEstudio GetSugerenciaEstudio(int IdSugerenciaEstudio);

    }
    
}
using System.Collections.Generic;
using SeguimientoEnCasa.App.Dominio;
using System;
using SeguimientoEnCasa.App.Persistencia;
using System.Linq;

namespace SeguimientoEnCasa.App.Persistencia
{

    public interface IRepositorioMaestro
    {
       IEnumerable<Maestro> GetAllMaestros();
       Maestro AddMaestro(Maestro maestro);
       Maestro UpdateMaestro(Maestro maestro);
       void DeleteMaestro(int IdMaestro);
       Maestro GetMaestro(int IdMaestro);

    }
    
}
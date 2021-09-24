using System.Collections.Generic;
using SeguimientoEnCasa.App.Dominio;
using System;
using SeguimientoEnCasa.App.Persistencia;
using System.Linq;

namespace SeguimientoEnCasa.App.Persistencia
{

    public interface IRepositorioEstudiante
    {
       IEnumerable<Estudiante> GetAllEstudiantes();
       Estudiante AddEstudiante(Estudiante estudiante);
       Estudiante UpdateEstudiante(Estudiante estudiante);
       void DeleteEstudiante(int IdEstudiante);
       Estudiante GetEstudiante(int IdEstudiante);

    }
    
}
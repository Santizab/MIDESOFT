using System.Collections.Generic;
using SeguimientoEnCasa.App.Dominio;
using System;
using SeguimientoEnCasa.App.Persistencia;
using System.Linq;

namespace SeguimientoEnCasa.App.Persistencia
{

    public interface IRepositorioTutor
    {
       IEnumerable<Tutor> GetAllTutores();
       Tutor AddTutor(Tutor tutor);
       Tutor UpdateTutor(Tutor tutor);
       void DeleteTutor(int IdTutor);
       Tutor GetTutor(int IdTutor);

    }
    
}
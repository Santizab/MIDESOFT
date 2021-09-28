using System.Collections.Generic;
using SeguimientoEnCasa.App.Dominio;
using System;
using SeguimientoEnCasa.App.Persistencia;
using System.Linq;

namespace SeguimientoEnCasa.App.Persistencia
{

    public interface IRepositorioAcudiente
    {
       IEnumerable<Acudiente> GetAllAcudientes();
       Acudiente AddAcudiente(Acudiente acudiente);
       Acudiente UpdateAcudiente(Acudiente acudiente);
       void DeleteAcudiente(int IdAcudiente);
       Acudiente GetAcudiente(int IdAcudiente);

    }
    
}
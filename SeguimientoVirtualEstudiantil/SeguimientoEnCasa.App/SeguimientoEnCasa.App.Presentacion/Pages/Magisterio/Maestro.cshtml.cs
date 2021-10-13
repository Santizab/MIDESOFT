using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeguimientoEnCasa.App.Dominio;
using SeguimientoEnCasa.App.Persistencia;

namespace SeguimientoEnCasa.App.Presentacion.Pages.Magisterio
{
    public class MaestroModel : PageModel
    {
        private readonly IRepositorioMaestro _repoMaestro;
        public IEnumerable<Maestro> Maestros{get;set;}
        public MaestroModel(IRepositorioMaestro _repoMaestro)
        {
            this._repoMaestro=_repoMaestro;
        }

        public void OnGet()
        {
            Maestros=_repoMaestro.GetAllMaestros();
        }
    }
}

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
    public class DetallesMaestroModel : PageModel
    {
        private readonly IRepositorioMaestro _repoMaestro;
        public Maestro Maestro{get;set;}
        public DetallesMaestroModel(IRepositorioMaestro _repoMaestro)
        {
            this._repoMaestro=_repoMaestro;
        }
        public IActionResult OnGet(int IdMaestro)
        {
            Maestro =_repoMaestro.GetMaestro(IdMaestro);
            if(Maestro==null)
            {
                return RedirectToPage("../Error");
            }
            else
                return Page();
        }
    }
}

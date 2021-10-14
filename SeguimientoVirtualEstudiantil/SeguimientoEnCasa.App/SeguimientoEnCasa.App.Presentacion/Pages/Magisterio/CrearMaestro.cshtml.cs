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
    public class CrearMaestroModel : PageModel
    {
        private readonly IRepositorioMaestro _repoMaestro;
        public Maestro Maestro{get;set;}

        public CrearMaestroModel(IRepositorioMaestro _repoMaestro)
        {
            this._repoMaestro=_repoMaestro;
        }

        public void OnGet()
        {
            Maestro=new Maestro();
        }

        public IActionResult OnPost(Maestro Maestro)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Maestro=_repoMaestro.AddMaestro(Maestro);
            return RedirectToPage("./Maestro");
        }
    }
}

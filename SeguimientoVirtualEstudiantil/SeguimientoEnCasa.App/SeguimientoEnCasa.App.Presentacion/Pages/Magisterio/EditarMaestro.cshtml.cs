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
    public class EditarMaestroModel : PageModel
    {
        private readonly IRepositorioMaestro _repoMaestro;
        
        [BindProperty]
        public Maestro Maestro{get;set;}
        

        public EditarMaestroModel(IRepositorioMaestro _repoMaestro)
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

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Maestro=_repoMaestro.UpdateMaestro(Maestro);
            return RedirectToPage("./Maestro");
        }
    }
}

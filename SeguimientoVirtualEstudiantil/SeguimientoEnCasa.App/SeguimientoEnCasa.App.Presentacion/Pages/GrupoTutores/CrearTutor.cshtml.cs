using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeguimientoEnCasa.App.Dominio;
using SeguimientoEnCasa.App.Persistencia;

namespace SeguimientoEnCasa.App.Presentacion.Pages.GrupoTutores
{
    public class CrearTutorModel : PageModel
    {
        private readonly IRepositorioTutor _repoTutor;
        public Tutor Tutor{get;set;}

        public CrearTutorModel(IRepositorioTutor _repoTutor)
        {
            this._repoTutor=_repoTutor;
        }

        public void OnGet()
        {
            Tutor=new Tutor();
        }

        public IActionResult OnPost(Tutor Tutor)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Tutor=_repoTutor.AddTutor(Tutor);
            return RedirectToPage("./Tutor");
        }
    }
}

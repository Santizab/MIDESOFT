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
    public class EditarTutorModel : PageModel
    {
        private readonly IRepositorioTutor _repoTutor;
        
        [BindProperty]
        public Tutor Tutor{get;set;}
        

        public EditarTutorModel(IRepositorioTutor _repoTutor)
        {
            this._repoTutor=_repoTutor;
        }
            

        public IActionResult OnGet(int IdTutor)
        {
            Tutor =_repoTutor.GetTutor(IdTutor);

            if(Tutor==null)
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
            Tutor=_repoTutor.UpdateTutor(Tutor);
            return RedirectToPage("./Tutor");
        }
    }
}

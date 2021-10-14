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
    public class DetallesTutorModel : PageModel
    {
        private readonly IRepositorioTutor _repoTutor;
        public Tutor Tutor{get;set;}
        public DetallesTutorModel(IRepositorioTutor _repoTutor)
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
    }
}

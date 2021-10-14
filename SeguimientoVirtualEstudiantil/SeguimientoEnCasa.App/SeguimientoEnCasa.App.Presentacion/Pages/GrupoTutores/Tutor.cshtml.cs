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
    public class TutorModel : PageModel
    {
        private readonly IRepositorioTutor _repoTutor;
        public IEnumerable<Tutor> Tutors{get;set;}
        public TutorModel(IRepositorioTutor _repoTutor)
        {
            this._repoTutor=_repoTutor;
        }

        public void OnGet()
        {
            Tutors=_repoTutor.GetAllTutores();
        }
    }
}

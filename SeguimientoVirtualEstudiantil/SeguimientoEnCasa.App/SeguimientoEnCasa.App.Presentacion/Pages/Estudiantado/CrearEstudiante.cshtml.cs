using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeguimientoEnCasa.App.Dominio;
using SeguimientoEnCasa.App.Persistencia;

namespace SeguimientoEnCasa.App.Presentacion.Pages.Estudiantado
{
    public class CrearEstudianteModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante;
        public Estudiante Estudiante{get;set;}

        public CrearEstudianteModel(IRepositorioEstudiante _repoEstudiante)
        {
            this._repoEstudiante=_repoEstudiante;
        }

        public void OnGet()
        {
            Estudiante=new Estudiante();
        }

        public IActionResult OnPost(Estudiante Estudiante)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Estudiante=_repoEstudiante.AddEstudiante(Estudiante);
            return RedirectToPage("./Estudiante");
        }
    }
}

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
    public class CrearAcudienteModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante;
        public Estudiante Estudiante{get;set;}
        public Acudiente Acudiente{get;set;}
        public CrearAcudienteModel(IRepositorioEstudiante _repoEstudiante)
        {
            this._repoEstudiante=_repoEstudiante;
        }
        public IActionResult OnGet(int IdEstudiante)
        {
            Estudiante =_repoEstudiante.GetEstudiante(IdEstudiante);
            if(Estudiante==null)
            {
                return RedirectToPage("../Error");
            }
            else
                return Page();
        }

        public IActionResult OnPost(int IdEstudiante, Acudiente Acudiente)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Estudiante=_repoEstudiante.AddAcudiente(IdEstudiante, Acudiente);
            return RedirectToPage("./Estudiante");
        }
    }
}

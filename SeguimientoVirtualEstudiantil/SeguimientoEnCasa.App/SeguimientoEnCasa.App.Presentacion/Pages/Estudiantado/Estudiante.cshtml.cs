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
    public class EstudianteModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante;
        public IEnumerable<Estudiante> Estudiantes{get;set;}
        public EstudianteModel(IRepositorioEstudiante _repoEstudiante)
        {
            this._repoEstudiante=_repoEstudiante;
        }

        public void OnGet()
        {
            Estudiantes=_repoEstudiante.GetAllEstudiantes();
        }
    }
}

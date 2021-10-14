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
    public class EditarEstudianteModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante;
        private readonly IRepositorioAcudiente _repoEstudiante2;
        private readonly IRepositorioTutor _repoEstudiante3;
        private readonly IRepositorioMaestro _repoEstudiante4;
        private readonly IRepositorioHistorico _repoEstudiante5;
        [BindProperty]
        public Estudiante Estudiante{get;set;}
        public Acudiente Acudiente{get;set;}
        public IEnumerable<Acudiente> Acudientes{get;set;}
        public Tutor Tutor{get;set;}
        public IEnumerable<Tutor> Tutores{get;set;}
        public Maestro Maestro{get;set;}
        public IEnumerable<Maestro> Maestros{get;set;}
        public Historico Historico{get;set;}
        public IEnumerable<Historico> Historicos{get;set;}


        public EditarEstudianteModel(IRepositorioEstudiante _repoEstudiante, IRepositorioAcudiente _repoEstudiante2, 
                            IRepositorioTutor _repoEstudiante3, IRepositorioMaestro _repoEstudiante4, IRepositorioHistorico _repoEstudiante5)
        {
            this._repoEstudiante=_repoEstudiante;
            this._repoEstudiante2=_repoEstudiante2;
            this._repoEstudiante3=_repoEstudiante3;
            this._repoEstudiante4=_repoEstudiante4;
            this._repoEstudiante5=_repoEstudiante5;
        }
            

        public IActionResult OnGet(int IdEstudiante)
        {
            Acudiente=_repoEstudiante2.GetAcudiente(IdEstudiante);
            Acudientes=_repoEstudiante2.GetAllAcudientes();

            Tutor=_repoEstudiante3.GetTutor(IdEstudiante);
            Tutores=_repoEstudiante3.GetAllTutores();

            Maestro=_repoEstudiante4.GetMaestro(IdEstudiante);
            Maestros=_repoEstudiante4.GetAllMaestros();

            Historico=_repoEstudiante5.GetHistorico(IdEstudiante);
            Historicos=_repoEstudiante5.GetAllHistoricos();

            Estudiante =_repoEstudiante.GetEstudiante(IdEstudiante);

            if(Estudiante==null)
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
            Estudiante=_repoEstudiante.UpdateEstudiante(Estudiante);
            return RedirectToPage("./Estudiante");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using persistencia;
using Dominio;

namespace MyApp.Namespace
{
    public class CreateTecnicoModel : PageModel
    {
        private readonly IRepositorioTecnico _repo;
        public Tecnico tecnico { get; set;}

        public CreateTecnicoModel(IRepositorioTecnico RepositorioMant)
        
        {
            _repo = RepositorioMant;
        }

        public void OnGet()
        {
        }
         public IActionResult OnPost(Tecnico tecnico)
        {
            _repo.Add(tecnico);
            return new RedirectToPageResult("/Tecnico/List");
        }
    }
}

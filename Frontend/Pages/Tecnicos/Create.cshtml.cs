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
    public class CreateTecModel : PageModel
    {
        private readonly IRepositorio _repo;
        public Persona Persona { get; set;}

        public CreateTecModel(IRepositorio repositorio)
        
        {
            _repo = repositorio;
        }

        public void OnGet()
        {
        }
         public IActionResult OnPost(Persona persona)
        {
            _repo.Add(persona);
            return new RedirectToPageResult("/Personas/List");
        }
    }
}

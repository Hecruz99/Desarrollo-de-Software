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
    public class UpdateTecnicosModel : PageModel{
        private readonly IRepositorio _repo;

        public Persona Persona { get; set; }

        public UpdateTecnicosModel(IRepositorio repositorio){
        _repo = repositorio;
        }
 
    public void OnGet(int Id)
        {
        Persona = _repo.Get(Id);
        }
    public IActionResult OnPost(Persona persona){
    
        _repo.Update(persona);
        return new RedirectToPageResult("Tecnicos/list");
        }
    }
}

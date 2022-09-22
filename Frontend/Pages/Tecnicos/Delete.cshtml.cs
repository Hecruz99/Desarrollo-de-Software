using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;   
using persistencia;

namespace MyApp.Namespace
{
    public class DeleteTecModel : PageModel
    {

        private readonly IRepositorio _repo;

        public Persona Persona { get; set;}

        public DeleteTecModel(IRepositorio repo)    
        {
            _repo = repo;
        }
    
        public void OnGet(int id)
        {
           Persona = _repo.Get(id);
           
        }

        public  IActionResult OnPost(int id)
        {
            _repo.Delete(id);
            return new RedirectToPageResult("/Tecnicos/List");
            
        }
    }
}

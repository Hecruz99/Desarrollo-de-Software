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
    public class DeleteCarModel : PageModel
    {

        private readonly IRepositorioCarro _repo;

        public Carro Carro { get; set;}

        public DeleteCarModel(IRepositorioCarro repo)    
        {
            _repo = repo;
        }
    
        public void OnGet(int id)
        {
            _repo.Get(id);
           
        }

        public  IActionResult OnPost(int id)
        {
            _repo.Delete(id);
            return new RedirectToPageResult("/Carros/List");
            
        }
    }
}
